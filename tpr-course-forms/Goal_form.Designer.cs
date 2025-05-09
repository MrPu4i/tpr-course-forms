namespace TPR_Kursovaia_Forms
{
    partial class Goal_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_amount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_urgency = new System.Windows.Forms.TextBox();
            this.tb_importance = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_emotion = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_info = new System.Windows.Forms.Label();
            this.but_conf = new System.Windows.Forms.Button();
            this.lbl_correct = new System.Windows.Forms.Label();
            this.but_new_goal = new System.Windows.Forms.Button();
            this.but_next = new System.Windows.Forms.Button();
            this.lbl_warning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_name
            // 
            this.tb_name.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold);
            this.tb_name.ForeColor = System.Drawing.Color.LightSalmon;
            this.tb_name.Location = new System.Drawing.Point(67, 152);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(372, 40);
            this.tb_name.TabIndex = 18;
            this.tb_name.Text = "пони";
            this.tb_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F);
            this.label2.Location = new System.Drawing.Point(171, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 28);
            this.label2.TabIndex = 19;
            this.label2.Text = "Название цели";
            // 
            // tb_amount
            // 
            this.tb_amount.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold);
            this.tb_amount.ForeColor = System.Drawing.Color.LightSalmon;
            this.tb_amount.Location = new System.Drawing.Point(549, 152);
            this.tb_amount.Name = "tb_amount";
            this.tb_amount.Size = new System.Drawing.Size(258, 45);
            this.tb_amount.TabIndex = 20;
            this.tb_amount.Text = "15000";
            this.tb_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F);
            this.label3.Location = new System.Drawing.Point(539, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(272, 28);
            this.label3.TabIndex = 21;
            this.label3.Text = "Стоимость цели (руб)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 11F);
            this.label4.Location = new System.Drawing.Point(438, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(288, 52);
            this.label4.TabIndex = 22;
            this.label4.Text = "1 - можно отложить\r\n10 - нужно прямо сейчас";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 13F);
            this.label7.Location = new System.Drawing.Point(172, 318);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 31);
            this.label7.TabIndex = 25;
            this.label7.Text = "Срочность";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 12F);
            this.label8.Location = new System.Drawing.Point(71, 238);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(740, 28);
            this.label8.TabIndex = 26;
            this.label8.Text = "Введите уровень значимости каждого критерия (от 1 до 10)";
            // 
            // tb_urgency
            // 
            this.tb_urgency.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold);
            this.tb_urgency.ForeColor = System.Drawing.Color.LightSalmon;
            this.tb_urgency.Location = new System.Drawing.Point(340, 312);
            this.tb_urgency.Name = "tb_urgency";
            this.tb_urgency.Size = new System.Drawing.Size(73, 50);
            this.tb_urgency.TabIndex = 27;
            this.tb_urgency.Text = "4";
            this.tb_urgency.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_importance
            // 
            this.tb_importance.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold);
            this.tb_importance.ForeColor = System.Drawing.Color.LightSalmon;
            this.tb_importance.Location = new System.Drawing.Point(340, 415);
            this.tb_importance.Name = "tb_importance";
            this.tb_importance.Size = new System.Drawing.Size(73, 50);
            this.tb_importance.TabIndex = 30;
            this.tb_importance.Text = "2";
            this.tb_importance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 13F);
            this.label5.Location = new System.Drawing.Point(186, 426);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 31);
            this.label5.TabIndex = 29;
            this.label5.Text = "Важность";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 11F);
            this.label6.Location = new System.Drawing.Point(438, 417);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(336, 52);
            this.label6.TabIndex = 28;
            this.label6.Text = "1 - не критично требуется\r\n10 - очень сильно требуется";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_emotion
            // 
            this.tb_emotion.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold);
            this.tb_emotion.ForeColor = System.Drawing.Color.LightSalmon;
            this.tb_emotion.Location = new System.Drawing.Point(340, 531);
            this.tb_emotion.Name = "tb_emotion";
            this.tb_emotion.Size = new System.Drawing.Size(73, 50);
            this.tb_emotion.TabIndex = 33;
            this.tb_emotion.Text = "6";
            this.tb_emotion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 13F);
            this.label9.Location = new System.Drawing.Point(116, 524);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(196, 62);
            this.label9.TabIndex = 32;
            this.label9.Text = "Эмоциональная\r\nценность";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Consolas", 11F);
            this.label10.Location = new System.Drawing.Point(438, 531);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(264, 52);
            this.label10.TabIndex = 31;
            this.label10.Text = "1 - было бы неплохо\r\n10 - мечта всей жизни";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_info
            // 
            this.lbl_info.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_info.Font = new System.Drawing.Font("Consolas", 15F);
            this.lbl_info.Location = new System.Drawing.Point(12, 9);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Padding = new System.Windows.Forms.Padding(10);
            this.lbl_info.Size = new System.Drawing.Size(876, 85);
            this.lbl_info.TabIndex = 34;
            this.lbl_info.Text = "Добавление новой цели";
            this.lbl_info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // but_conf
            // 
            this.but_conf.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_conf.ForeColor = System.Drawing.Color.LightSalmon;
            this.but_conf.Location = new System.Drawing.Point(345, 650);
            this.but_conf.Name = "but_conf";
            this.but_conf.Size = new System.Drawing.Size(214, 75);
            this.but_conf.TabIndex = 35;
            this.but_conf.Text = "Подтвердить";
            this.but_conf.UseVisualStyleBackColor = true;
            this.but_conf.Click += new System.EventHandler(this.but_comp_w_Click);
            // 
            // lbl_correct
            // 
            this.lbl_correct.AutoSize = true;
            this.lbl_correct.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Bold);
            this.lbl_correct.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbl_correct.Location = new System.Drawing.Point(353, 661);
            this.lbl_correct.Name = "lbl_correct";
            this.lbl_correct.Size = new System.Drawing.Size(196, 47);
            this.lbl_correct.TabIndex = 36;
            this.lbl_correct.Text = "Успешно!";
            this.lbl_correct.Visible = false;
            // 
            // but_new_goal
            // 
            this.but_new_goal.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_new_goal.ForeColor = System.Drawing.Color.LightSalmon;
            this.but_new_goal.Location = new System.Drawing.Point(345, 738);
            this.but_new_goal.Name = "but_new_goal";
            this.but_new_goal.Size = new System.Drawing.Size(214, 75);
            this.but_new_goal.TabIndex = 37;
            this.but_new_goal.Text = "Добавить новую\r\nцель +";
            this.but_new_goal.UseVisualStyleBackColor = true;
            this.but_new_goal.Visible = false;
            this.but_new_goal.Click += new System.EventHandler(this.but_next_Click);
            // 
            // but_next
            // 
            this.but_next.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_next.ForeColor = System.Drawing.Color.LightSalmon;
            this.but_next.Location = new System.Drawing.Point(674, 738);
            this.but_next.Name = "but_next";
            this.but_next.Size = new System.Drawing.Size(214, 75);
            this.but_next.TabIndex = 38;
            this.but_next.Text = "Продолжить";
            this.but_next.UseVisualStyleBackColor = true;
            this.but_next.Visible = false;
            this.but_next.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbl_warning
            // 
            this.lbl_warning.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold);
            this.lbl_warning.ForeColor = System.Drawing.Color.Red;
            this.lbl_warning.Location = new System.Drawing.Point(578, 659);
            this.lbl_warning.Name = "lbl_warning";
            this.lbl_warning.Size = new System.Drawing.Size(266, 66);
            this.lbl_warning.TabIndex = 39;
            this.lbl_warning.Text = "Что-то введено неверно!";
            this.lbl_warning.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_warning.Visible = false;
            // 
            // Goal_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(220)))), ((int)(((byte)(196)))));
            this.ClientSize = new System.Drawing.Size(900, 834);
            this.Controls.Add(this.lbl_warning);
            this.Controls.Add(this.but_next);
            this.Controls.Add(this.but_new_goal);
            this.Controls.Add(this.lbl_correct);
            this.Controls.Add(this.but_conf);
            this.Controls.Add(this.lbl_info);
            this.Controls.Add(this.tb_emotion);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tb_importance);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_urgency);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_amount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_name);
            this.Name = "Goal_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Цель";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_amount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_urgency;
        private System.Windows.Forms.TextBox tb_importance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_emotion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_info;
        private System.Windows.Forms.Button but_conf;
        private System.Windows.Forms.Label lbl_correct;
        private System.Windows.Forms.Button but_new_goal;
        private System.Windows.Forms.Button but_next;
        private System.Windows.Forms.Label lbl_warning;
    }
}