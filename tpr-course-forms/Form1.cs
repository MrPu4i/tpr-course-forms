using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TPR_Kursovaia_Forms
{
    public partial class Form1 : Form
    {
        Finan_profile profile; //создаём профиль
        public Form1(Finan_profile prof)
        {
            InitializeComponent();
            this.profile = prof;
            //вносим в поля значения, если они не пустые
            if (profile.Monthly_income != 0 && profile.Monthly_expenses != 0) //уже введён заработок, заходим с main_form
            {
                tb_income.Text = profile.Monthly_income.ToString();
                tb_expenses.Text = profile.Monthly_expenses.ToString();
            }
        }
        private void but_prof_Click(object sender, EventArgs e)
        {
            //принимаем всё из текстбоксов
            if (tb_income.Text == "" || tb_expenses.Text == "") //если пустые
            {
                ShowError("Ошибка! Какое-то поле пустое!", lbl_warning_but);
                return;
            }
            if (decimal.TryParse(tb_income.Text, out decimal maxValue) && Convert.ToDecimal(tb_expenses.Text) > maxValue)
            {
                ShowError($"Ошибка! Расходы не должны \nпревышать доход ({maxValue})!", lbl_warning_expences);
                return;
            }
            profile.Monthly_income = decimal.Parse(tb_income.Text);
            profile.Monthly_expenses = decimal.Parse(tb_expenses.Text);
            ClearError(lbl_warning_but);
            ClearError(lbl_warning_expences);

            //переходим на Main_Form
            Main_Form main_f = new Main_Form(profile);
            this.Close();
            main_f.Show();
        }

        private void tb_income_KeyPress(object sender, KeyPressEventArgs e)
        {
            System.Windows.Forms.TextBox textBox = (System.Windows.Forms.TextBox)sender; //привеодим sender(объект который вызвал метод) в тип textbox

            // Разрешаем:
            // - цифры (0-9)
            // - Backspace ('\b')
            // - точку ('.') (но только одну)
            // - управляющие символы (Ctrl+V, Ctrl+C и т.д.)

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != ',' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                ShowError("Ошибка! Можно вводить \nтолько цифры и запятые!", lbl_warning_income);
                return;
            }

            // Проверка на несколько запятых
            if (e.KeyChar == ',' && textBox.Text.Contains(','))
            {
                e.Handled = true;
                ShowError("Ошибка! Можно использовать \nтолько одну запятую!", lbl_warning_income);
                return;
            }

            // Если всё правильно - очищаем ошибку
            ClearError(lbl_warning_income);
        }
        private void tb_expences_KeyPress(object sender, KeyPressEventArgs e)
        {
            System.Windows.Forms.TextBox textBox = (System.Windows.Forms.TextBox)sender;
            // Разрешаем: цифры, Backspace, Delete
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != (char)Keys.Delete && e.KeyChar != ',')
            {
                e.Handled = true;
                ShowError("Ошибка! Можно вводить \nтолько цифры и запятые!", lbl_warning_expences);
                return;
            }

            // Проверка на пустую строку
            if (string.IsNullOrEmpty(textBox.Text))
            {
                ShowError("Ошибка! Пустое поле!", lbl_warning_expences);
                return;
            }

            // Проверка на несколько запятых
            if (e.KeyChar == ',' && textBox.Text.Contains(','))
            {
                e.Handled = true;
                ShowError("Ошибка! Можно использовать \nтолько одну запятую!", lbl_warning_income);
                return;
            }

            ClearError(lbl_warning_expences);
        }
        private void ShowError(string errorMessage, Label lbl_error)
        {
            lbl_error.Text = errorMessage;
            lbl_error.Visible = true;
        }

        private void ClearError(Label lbl_error)
        {
            lbl_error.Visible = false;
        }
    }
}
