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
        Finan_profile profile;
        public Form_component_weight(Finan_profile prof)
        {
            InitializeComponent();
            this.profile = prof;
            if (profile.W_Urgency != 0 && profile.W_Importance != 0 && profile.W_Emotion != 0)
            { 
                tb_urgency.Text = profile.W_Urgency.ToString();
                tb_importance.Text = profile.W_Importance.ToString();
                tb_emotion.Text = profile.W_Emotion.ToString();
            }
        }

        private void but_default_Click(object sender, EventArgs e)
        {
            tb_urgency.Text = 0.5.ToString();
            tb_importance.Text = 0.3.ToString();
            tb_emotion.Text = 0.2.ToString();
        }

        private async void but_comp_w_Click(object sender, EventArgs e)
        {
            try
            {
                profile.W_Urgency = Convert.ToDecimal(tb_urgency.Text);
                profile.W_Importance = Convert.ToDecimal(tb_importance.Text);
                profile.W_Emotion = Convert.ToDecimal(tb_emotion.Text);
                if (profile.New_goal_from_main == false)
                {
                    Form1 profile_f = new Form1(profile);
                    this.Close();
                    profile_f.Show();
                }
                else
                {
                    Main_Form main_f = new Main_Form(profile);
                    this.Close();
                    main_f.Show();
                }
            }
            catch
            {
                lbl_warning.Visible = true;
                await Task.Delay(3000);
                lbl_warning.Visible = false;
            }
        }
    }
}
