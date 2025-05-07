using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPR_Kursovaia_Forms
{
    public partial class Main_Form : Form
    {
        public string plan_text_m;
        Finan_profile profile;
        Plan_form plan_f;
        Finan_decision_maker decision_maker;

        public DataGridView grid_plan;
        public List<Finan_goal> grid_data;

        public Main_Form(Finan_profile prof)
        {
            InitializeComponent();
            this.profile = prof;
            grid_data = new List<Finan_goal>();

            Mathing(); //делаем вычисления

            SetGrid(); //при заходе заполняем грид

            profile.New_goal_from_main = true; //теперь новая цель из main_form

            Set_data();
        }
        private void Set_data()
        {
            /*tb_urgency.Text = profile.W_Urgency.ToString();
            tb_importance.Text = profile.W_Importance.ToString();
            tb_emotion.Text = profile.W_Emotion.ToString();*/

            lbl_income.Text = "Зарплата: "+ profile.Monthly_income.ToString();
            lbl_expenses.Text = "Траты: " + profile.Monthly_expenses.ToString();
            lbl_free_money.Text = "Свободные средства: " + profile.Free_money.ToString();

            lbl_urgency.Text = "Срочность: " + profile.W_Urgency.ToString();
            lbl_importance.Text = "Важность: " + profile.W_Importance.ToString();
            lbl_emotion.Text = "Эмоциональная ценность " + profile.W_Emotion.ToString();
        }
        public void Mathing()
        {
            decision_maker = new Finan_decision_maker(this); //создаём класс счетовод
            decision_maker.Counts_score(profile); //первоначально считаем score
            decision_maker.Set_monthly_saves(profile, profile.Free_money); //первоначально задаём бюджет
            decision_maker.How_many_months(profile); //сначала прогноз
            Spinning_months(decision_maker, profile); //потом циклическая симуляция
        }
        private void Spinning_months(Finan_decision_maker finan_dec_maker, Finan_profile profile)
        { //вывод по месяцам

            for (int month = 1; month <= 300; month++)
            {
                //в этот момент в лист, который мы будем указывать как grid.DataSors мы добавляем
                finan_dec_maker.Update_goals(profile, month);
                if (finan_dec_maker.output_checker) //если true, тогда можем выводить
                {
                    finan_dec_maker.Output(profile, month); //мы тут выводим обычно
                }
                finan_dec_maker.output_checker = true; //вернулись из Update_goals и опять можно выводить
                                                       //Console.WriteLine("         то что выше, это из цикла month");
                if (!profile.Goals.Any()) break; // Все цели достигнуты
            }
        }

        private void SetGrid()
        {
            goals_grid.DataSource = profile.Goals_grid.Select(g => new
            {
                name = g.Name,
                target_amount = g.Target_amount,
                urgency = g.Urgency,
                importance = g.Importance,
                emotion = g.Emotion,
                month = g.Target_months
            }).ToList();

            goals_grid.Columns[0].HeaderText = "Название";
            goals_grid.Columns[1].HeaderText = "Стоимость";
            goals_grid.Columns[2].HeaderText = "Ср";
            goals_grid.Columns[3].HeaderText = "Важ";
            goals_grid.Columns[4].HeaderText = "ЭЦ";
            goals_grid.Columns[5].HeaderText = "Через сколько месяцев купим";

            goals_grid.Columns[0].Width = 150;
            goals_grid.Columns[1].Width = 100;
            goals_grid.Columns[2].Width = 30;
            goals_grid.Columns[3].Width = 30;
            goals_grid.Columns[4].Width = 30;
            goals_grid.Columns[5].Width = 100;

            goals_grid.ColumnHeadersHeight = 50;
            foreach (DataGridViewColumn column in goals_grid.Columns)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void Goals_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void but_show_plan_Click(object sender, EventArgs e)
        {
            //открываем рядом окно плана
            plan_f = new Plan_form(this);
            plan_f.Show();
        }

        private void but_default_Click(object sender, EventArgs e)
        {
            Reset();
            //открываем веса
            Form_component_weight f_comp_w = new Form_component_weight(profile);
            this.Close();
            f_comp_w.Show();
        }

        private void but_add_Click(object sender, EventArgs e)
        {
            //добавляем goal_form
            Reset();
            Goal_form g_form = new Goal_form(profile, "Добавляем новую цель"); //добавляю новую цель
            this.Hide();
            if (plan_f != null)
            { 
                plan_f.Close(); //закрываем plan_form
            }
            g_form.ShowDialog();
            
        }
        public void Reset()
        {
            profile.Goals.AddRange(profile.Goals_grid);
            foreach (var goal in profile.Goals)
            {
                goal.Current_saved = 0;
                goal.Is_completed = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*if (Convert.ToDecimal(tb_urgency.Text) != profile.W_Urgency || Convert.ToDecimal(tb_importance.Text) != profile.W_Importance
                || Convert.ToDecimal(tb_emotion.Text) != profile.W_Emotion)
            {//тоесть если хотя бы одно значение другое - изменяем веса
                profile.W_Urgency = Convert.ToDecimal(tb_urgency.Text);
                profile.W_Importance = Convert.ToDecimal(tb_importance.Text);
                profile.W_Emotion = Convert.ToDecimal(tb_emotion.Text);

                Reset();
                //заново открыть main_form
                Main_Form main_f = new Main_Form(profile);
                this.Close();
                main_f.Show();
            }*/
            //иначе ничего не делаем
        }

        private void but_edit_money_Click(object sender, EventArgs e)
        {
            //открываем где деньги
            Reset();
            Form1 money = new Form1(profile);
            this.Close();
            money.Show();
        }

        private void goals_grid_DoubleClick(object sender, EventArgs e)
        {
            /*//двойной клик для изменения целей
            //оно работает даже с ReadOnly
            //тут будем по дабл клику находить цель и изменять её
            if (e.RowIndex >= 0)
            {
                // Получаем выбранную строку
                DataGridViewRow selectedRow = goals_grid.Rows[e.RowIndex];

                foreach (var goal in profile.Goals)
                {
                    if (goal.Name == selectedRow.Cells[0].Value.ToString())
                    {
                        //нашли что это за цель была
                        //перейти в goal_form с этим goal
                        //в goal содержится тот самый goal, который надо показать
                        Goal_form g_f = new Goal_form(goal, "Измените существующую цель");
                        g_f.ShowDialog();
                        this.Hide();
                    }
                }
            }*/
        }
    }
}
