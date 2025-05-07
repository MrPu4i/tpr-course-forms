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
    public partial class Start_Form : Form //главная форма
    {
        Finan_profile profile = new Finan_profile();
        public Start_Form()
        {
            InitializeComponent();
        }

        private void but_comp_w_Click(object sender, EventArgs e)
        {
            Goal_form g_form = new Goal_form(profile, "Добавление новой цели"); //первый заход в цели
            //переходим к добавлению цели(Goal_form), указывая какой текст будет
            this.Hide();
            g_form.ShowDialog();
        }
    }
}
