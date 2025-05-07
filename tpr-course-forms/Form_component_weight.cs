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
    public partial class Form_component_weight : Form
    {
        Finan_profile profile = new Finan_profile();
        public Form_component_weight(Finan_profile prof)
        {
            InitializeComponent();
            this.profile = prof;
        }

        private void but_default_Click(object sender, EventArgs e)
        {
            tb_urgency.Text = 0.5.ToString();
            tb_importance.Text = 0.3.ToString();
            tb_emotion.Text = 0.2.ToString();
        }

        private void but_comp_w_Click(object sender, EventArgs e)
        {
            profile.W_Urgency = Convert.ToDecimal(tb_urgency.Text);
            profile.W_Importance = Convert.ToDecimal(tb_importance.Text);
            profile.W_Emotion = Convert.ToDecimal(tb_emotion.Text);
            lbl_weight_info.Text = $"Вы задали значения:\n" +
                $"срочность: {profile.W_Urgency}  важность: {profile.W_Importance}  эмоциональная ценность: {profile.W_Emotion}";
            but_next.Visible = true;
            but_conf.Visible = false; //скрываем кнопку подтвердить
        }

        private void but_next_Click(object sender, EventArgs e)
        {
            //переходм на профиль
            Form1 profile_f = new Form1(profile);
            this.Close();
            profile_f.Show();
        }
    }
}
