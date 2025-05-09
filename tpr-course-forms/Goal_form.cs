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
    public partial class Goal_form : Form
    {
        Finan_profile profile;
        public Goal_form(Finan_profile prof, String info_text)
        {
            InitializeComponent();
            lbl_info.Text = info_text;
            this.profile = prof;
            //Console.WriteLine();
        }
        public Goal_form(Finan_goal goal, String info_text) //это для изменения цели
        {
            InitializeComponent();
            //потом заполним все ячейки
            tb_name.Text = goal.Name;
        }

        private async void but_comp_w_Click(object sender, EventArgs e)
        {
            try
            {
                Finan_goal goal = new Finan_goal(); //создаём новую цель
                goal.Name = tb_name.Text;
                goal.Target_amount = Convert.ToDecimal(tb_amount.Text);
                goal.Urgency = Convert.ToInt32(tb_urgency.Text);
                goal.Importance = Convert.ToInt32(tb_importance.Text);
                goal.Emotion = Convert.ToInt32(tb_emotion.Text);
                profile.Goals.Add(goal);
                //так же добавляем в лист, который будем отрисовывать в grid
                profile.Goals_grid.Add(goal); //отсюда удалять мы не будем
            }
            catch
            {
                //выводим в label ошибку
                //lbl_warning.Text = "Что-то введено неверно!";
                lbl_warning.Visible = true;
                await Task.Delay(3000);
                lbl_warning.Visible = false;
                return;
            }
            //Выводим Успешно!
            lbl_warning.Visible = false;
            lbl_correct.Visible = true;
            but_new_goal.Visible = true;
            but_conf.Visible = false;
            but_next.Visible = true; //включаем кнопку дальше
        }

        private void but_next_Click(object sender, EventArgs e)
        {
            //новую форму создаём goal_form
            Goal_form new_goal_form = new Goal_form(profile, "Добавим ещё одну цель");
            new_goal_form.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (profile.New_goal_from_main == false)
            {
                //переходим на веса
                Form_component_weight f_comp_w = new Form_component_weight(profile);
                this.Close();
                f_comp_w.Show();
            }
            else
            {
                //переходим на main_form
                //каждый раз когда заходим отбратно надо 
                Main_Form main_f = new Main_Form(profile);
                this.Close();
                main_f.Show();
            }
        }
    }
}
