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
                AutoGenerateColumns = true,
                AllowUserToAddRows = false,
                ReadOnly = true,
                //Visible = false
            };

            grid_plan.CellPainting += dataGridView1_CellPainting;
            grid_plan.CellFormatting += dataGridView1_CellFormatting;
            Controls.Add(grid_plan);
            //присваиваем наш список гриду
            //grid_plan.DataSource = profile.Goals;
            grid_plan.DataSource = form.grid_data.Select(g => new {
                Месяц = g.Month_when,
                Название = g.Name,
                Руб_м = Math.Round(g.Monthly_saving),
                Сколько_будет_накоплено = $"{Math.Round(g.Current_saved)}/{Math.Round(g.Target_amount)}",
            }).ToList();
            ColorizeByMonth(); //задаём цвета
                               //Console.WriteLine(grid_plan.DataSource);
            grid_plan.BringToFront();

            this.Controls.Add(grid_plan);
            grid_plan.Dock = DockStyle.Fill;
            grid_plan.Visible = true;
            grid_plan.BringToFront();
            //настроить размер и тд

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
            e.AdvancedBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None;
            if (e.RowIndex < 1 || e.ColumnIndex != 0) //только первый проверяем
                return;
            if (IsTheSameCellValue(e.ColumnIndex, e.RowIndex))
            {
                e.AdvancedBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
            }
            else
            {
                e.AdvancedBorderStyle.Top = grid_plan.AdvancedCellBorderStyle.Top;
            }
        }

        private void ColorizeByMonth()
        {
            string currentMonth = null;
            Color[] monthColors = { Color.LavenderBlush, Color.White }; // Два цвета для чередования
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
