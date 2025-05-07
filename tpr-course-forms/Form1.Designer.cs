namespace TPR_Kursovaia_Forms
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.but_conf = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_warning_income = new System.Windows.Forms.Label();
            this.lbl_warning_expences = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_free_money = new System.Windows.Forms.Label();
            this.lbl_mine_free_money_text = new System.Windows.Forms.Label();
            this.but_next = new System.Windows.Forms.Button();
            this.tb_income = new System.Windows.Forms.TextBox();
            this.tb_expenses = new System.Windows.Forms.TextBox();
            this.lbl_warning_but = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(300, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(306, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "Введите ваш заработок";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(275, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(362, 54);
            this.label3.TabIndex = 5;
            this.label3.Text = "Введите ваши обязательные\r\nмесячные траты";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // but_conf
            // 
            this.but_conf.Font = new System.Drawing.Font("Calibri", 15F);
            this.but_conf.ForeColor = System.Drawing.Color.LightSalmon;
            this.but_conf.Location = new System.Drawing.Point(342, 360);
            this.but_conf.Name = "but_conf";
            this.but_conf.Size = new System.Drawing.Size(219, 66);
            this.but_conf.TabIndex = 6;
            this.but_conf.Text = "Подтвердить";
            this.but_conf.UseVisualStyleBackColor = true;
            this.but_conf.Click += new System.EventHandler(this.but_prof_Click);
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Courier New", 14F);
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(864, 79);
            this.label7.TabIndex = 10;
            this.label7.Text = "Определение свободных финансовых стредств";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_warning_income
            // 
            this.lbl_warning_income.AutoSize = true;
            this.lbl_warning_income.ForeColor = System.Drawing.Color.Red;
            this.lbl_warning_income.Location = new System.Drawing.Point(547, 157);
            this.lbl_warning_income.Name = "lbl_warning_income";
            this.lbl_warning_income.Size = new System.Drawing.Size(77, 20);
            this.lbl_warning_income.TabIndex = 11;
            this.lbl_warning_income.Text = "Ошибка! ";
            this.lbl_warning_income.Visible = false;
            // 
            // lbl_warning_expences
            // 
            this.lbl_warning_expences.AutoSize = true;
            this.lbl_warning_expences.ForeColor = System.Drawing.Color.Red;
            this.lbl_warning_expences.Location = new System.Drawing.Point(547, 307);
            this.lbl_warning_expences.Name = "lbl_warning_expences";
            this.lbl_warning_expences.Size = new System.Drawing.Size(77, 20);
            this.lbl_warning_expences.TabIndex = 12;
            this.lbl_warning_expences.Text = "Ошибка! ";
            this.lbl_warning_expences.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.DarkSalmon;
            this.label6.Location = new System.Drawing.Point(175, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Например: 45550,155";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.DarkSalmon;
            this.label8.Location = new System.Drawing.Point(169, 309);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(176, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Не больше заработка";
            // 
            // lbl_free_money
            // 
            this.lbl_free_money.AutoSize = true;
            this.lbl_free_money.Font = new System.Drawing.Font("Courier New", 20F);
            this.lbl_free_money.Location = new System.Drawing.Point(519, 384);
            this.lbl_free_money.Name = "lbl_free_money";
            this.lbl_free_money.Size = new System.Drawing.Size(42, 42);
            this.lbl_free_money.TabIndex = 9;
            this.lbl_free_money.Text = "-";
            this.lbl_free_money.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_free_money.Visible = false;
            // 
            // lbl_mine_free_money_text
            // 
            this.lbl_mine_free_money_text.AutoSize = true;
            this.lbl_mine_free_money_text.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mine_free_money_text.Location = new System.Drawing.Point(219, 370);
            this.lbl_mine_free_money_text.Name = "lbl_mine_free_money_text";
            this.lbl_mine_free_money_text.Size = new System.Drawing.Size(264, 54);
            this.lbl_mine_free_money_text.TabIndex = 8;
            this.lbl_mine_free_money_text.Text = "Ваши свободные\r\nмесячные средства:";
            this.lbl_mine_free_money_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_mine_free_money_text.Visible = false;
            // 
            // but_next
            // 
            this.but_next.Font = new System.Drawing.Font("Calibri", 15F);
            this.but_next.ForeColor = System.Drawing.Color.LightSalmon;
            this.but_next.Location = new System.Drawing.Point(674, 435);
            this.but_next.Name = "but_next";
            this.but_next.Size = new System.Drawing.Size(192, 46);
            this.but_next.TabIndex = 15;
            this.but_next.Text = "Продолжить";
            this.but_next.UseVisualStyleBackColor = true;
            this.but_next.Visible = false;
            this.but_next.Click += new System.EventHandler(this.but_next_Click);
            // 
            // tb_income
            // 
            this.tb_income.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_income.ForeColor = System.Drawing.Color.LightSalmon;
            this.tb_income.Location = new System.Drawing.Point(370, 147);
            this.tb_income.Name = "tb_income";
            this.tb_income.Size = new System.Drawing.Size(156, 39);
            this.tb_income.TabIndex = 16;
            this.tb_income.Text = "50000";
            this.tb_income.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_income.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_income_KeyPress);
            // 
            // tb_expenses
            // 
            this.tb_expenses.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_expenses.ForeColor = System.Drawing.Color.LightSalmon;
            this.tb_expenses.Location = new System.Drawing.Point(370, 297);
            this.tb_expenses.Name = "tb_expenses";
            this.tb_expenses.Size = new System.Drawing.Size(156, 39);
            this.tb_expenses.TabIndex = 17;
            this.tb_expenses.Text = "35000";
            this.tb_expenses.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_expenses.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_expences_KeyPress);
            // 
            // lbl_warning_but
            // 
            this.lbl_warning_but.AutoSize = true;
            this.lbl_warning_but.ForeColor = System.Drawing.Color.Red;
            this.lbl_warning_but.Location = new System.Drawing.Point(576, 388);
            this.lbl_warning_but.Name = "lbl_warning_but";
            this.lbl_warning_but.Size = new System.Drawing.Size(73, 20);
            this.lbl_warning_but.TabIndex = 18;
            this.lbl_warning_but.Text = "Ошибка!";
            this.lbl_warning_but.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(220)))), ((int)(((byte)(196)))));
            this.ClientSize = new System.Drawing.Size(888, 502);
            this.Controls.Add(this.lbl_warning_but);
            this.Controls.Add(this.tb_expenses);
            this.Controls.Add(this.tb_income);
            this.Controls.Add(this.but_next);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_warning_expences);
            this.Controls.Add(this.lbl_warning_income);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl_free_money);
            this.Controls.Add(this.lbl_mine_free_money_text);
            this.Controls.Add(this.but_conf);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button but_conf;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_warning_income;
        private System.Windows.Forms.Label lbl_warning_expences;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_free_money;
        private System.Windows.Forms.Label lbl_mine_free_money_text;
        private System.Windows.Forms.Button but_next;
        private System.Windows.Forms.TextBox tb_income;
        private System.Windows.Forms.TextBox tb_expenses;
        private System.Windows.Forms.Label lbl_warning_but;
    }
}

