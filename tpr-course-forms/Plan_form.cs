using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPR_Kursovaia_Forms
{
    public partial class Plan_form : Form
    {
        DataGridView grid_plan;
        public Plan_form(Main_Form form) //из main только sorce нужен
        {
            InitializeComponent();
            grid_plan = new DataGridView() //создаём grid
            {
                Dock = DockStyle.Fill,
                BackgroundColor = Color.FromArgb(253, 220, 196),
                AutoGenerateColumns = true,
                AllowUserToAddRows = false,
                ReadOnly = true,
            };

            grid_plan.CellPainting += dataGridView1_CellPainting;
            grid_plan.CellFormatting += dataGridView1_CellFormatting;
            grid_plan.DataBindingComplete += dataGridView1_DataBindingComplete;

            Controls.Add(grid_plan);
            //присваиваем наш список гриду
            //grid_plan.DataSource = profile.Goals;
            grid_plan.DataSource = form.grid_data.Select(g => new {
                month = g.Month_when,
                name = g.Name,
                rub_per_month = Math.Round(g.Monthly_saving),
                how_much = $"{Math.Round(g.Current_saved)}/{Math.Round(g.Target_amount)}",
            }).ToList();

            grid_plan.Columns[0].HeaderText = "Месяц";
            grid_plan.Columns[1].HeaderText = "Название";
            grid_plan.Columns[2].HeaderText = "Руб/месяц";
            grid_plan.Columns[3].HeaderText = "Сколько будет накопленно";

            //название стобцов поменять
            grid_plan.Visible = true;
            grid_plan.ReadOnly = true; //нельзя трогать эту таблицу
            grid_plan.BringToFront();
            grid_plan.Location = new Point(16, 12); //местоположение
            grid_plan.Size = new Size(522, 684);
            grid_plan.Columns[0].Width = 80;
            grid_plan.Columns[3].Width = 100;
            grid_plan.ColumnHeadersHeight = 40;
            grid_plan.RowHeadersWidth = 4;
            this.Width = grid_plan.Columns[0].Width + grid_plan.Columns[1].Width + grid_plan.Columns[2].Width + grid_plan.Columns[3].Width + 80;
            this.Padding = new Padding(20); //отступ 20 со всех сторон
        }
        bool IsTheSameCellValue(int column, int row)
        {
            if (column != 0)
                return false;
            DataGridViewCell cell1 = grid_plan[column, row];
            DataGridViewCell cell2 = grid_plan[column, row - 1];
            if (cell1.Value == null || cell2.Value == null)
            {
                return false;
            }
            return cell1.Value.ToString() == cell2.Value.ToString();
        }
        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            //если в строчке в 4й таблице значения равны, подчеркнуть значения
            if (e.RowIndex < 1 || e.ColumnIndex != 0) //только первый проверяем
                return;
            e.AdvancedBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None;
            if (IsTheSameCellValue(e.ColumnIndex, e.RowIndex))
            {
                e.AdvancedBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;

            }
            else
            {
                e.AdvancedBorderStyle.Top = grid_plan.AdvancedCellBorderStyle.Top;
            }
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ColorizeByMonth();
        }
        private void ColorizeByMonth()
        {
            string currentMonth = null;
            Color[] monthColors = { Color.FromArgb(255, 236, 223), Color.White }; // Два цвета для чередования
            int colorIndex = 0;

            foreach (DataGridViewRow row in grid_plan.Rows)
            {
                if (row.IsNewRow) continue; // Пропускаем новую строку для добавления

                var monthCell = row.Cells[0]; // Убедитесь, что имя столбца совпадает
                if (monthCell?.Value != null)
                {
                    string rowMonth = monthCell.Value.ToString();

                    // Если месяц изменился - меняем цвет
                    if (rowMonth != currentMonth)
                    {
                        currentMonth = rowMonth;
                        colorIndex = (colorIndex + 1) % monthColors.Length;
                    }
                }

                // Применяем цвет ко всей строке
                row.DefaultCellStyle.BackColor = monthColors[colorIndex];
            }
        }
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex == 0 || e.ColumnIndex != 0) //только 0 столбец смотрим
                return;
            if (IsTheSameCellValue(e.ColumnIndex, e.RowIndex))
            {
                e.Value = "";
                e.FormattingApplied = true;
            }
        }
    }
}
