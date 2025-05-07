namespace TPR_Kursovaia_Forms
{
    partial class Form_component_weight
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
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_urgency = new System.Windows.Forms.TextBox();
            this.tb_importance = new System.Windows.Forms.TextBox();
            this.tb_emotion = new System.Windows.Forms.TextBox();
            this.but_default = new System.Windows.Forms.Button();
            this.but_conf = new System.Windows.Forms.Button();
            this.lbl_weight_info = new System.Windows.Forms.Label();
            this.lbl_warning_but = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.but_next = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Courier New", 12F);
            this.label7.Location = new System.Drawing.Point(22, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(932, 98);
            this.label7.TabIndex = 11;
            this.label7.Text = "Теперь, когда вы добавили свои цели, вам нужно указать ВЕС для трёх критериев \"ср" +
    "очность\", \"важность\" и \"эмоциональная ценность\"";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 12F);
            this.label2.Location = new System.Drawing.Point(131, 379);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 27);
            this.label2.TabIndex = 13;
            this.label2.Text = "Срочность";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 12F);
            this.label3.Location = new System.Drawing.Point(423, 379);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 27);
            this.label3.TabIndex = 14;
            this.label3.Text = "Важность";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 12F);
            this.label4.Location = new System.Drawing.Point(682, 365);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 54);
            this.label4.TabIndex = 15;
            this.label4.Text = "Эмоциональная\r\nценность";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_urgency
            // 
            this.tb_urgency.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold);
            this.tb_urgency.ForeColor = System.Drawing.Color.Coral;
            this.tb_urgency.Location = new System.Drawing.Point(145, 428);
            this.tb_urgency.Name = "tb_urgency";
            this.tb_urgency.Size = new System.Drawing.Size(90, 48);
            this.tb_urgency.TabIndex = 16;
            this.tb_urgency.Text = "0,5";
            this.tb_urgency.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_importance
            // 
            this.tb_importance.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold);
            this.tb_importance.ForeColor = System.Drawing.Color.Coral;
            this.tb_importance.Location = new System.Drawing.Point(428, 428);
            this.tb_importance.Name = "tb_importance";
            this.tb_importance.Size = new System.Drawing.Size(90, 48);
            this.tb_importance.TabIndex = 17;
            this.tb_importance.Text = "0,3";
            this.tb_importance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_emotion
            // 
            this.tb_emotion.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold);
            this.tb_emotion.ForeColor = System.Drawing.Color.Coral;
            this.tb_emotion.Location = new System.Drawing.Point(733, 428);
            this.tb_emotion.Name = "tb_emotion";
            this.tb_emotion.Size = new System.Drawing.Size(97, 48);
            this.tb_emotion.TabIndex = 18;
            this.tb_emotion.Text = "0,2";
            this.tb_emotion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // but_default
            // 
            this.but_default.Font = new System.Drawing.Font("Calibri", 9F);
            this.but_default.ForeColor = System.Drawing.Color.LightSalmon;
            this.but_default.Location = new System.Drawing.Point(297, 313);
            this.but_default.Name = "but_default";
            this.but_default.Size = new System.Drawing.Size(365, 43);
            this.but_default.TabIndex = 19;
            this.but_default.Text = "Задать значения по умолчанию (0.5, 0.3, 0.2)";
            this.but_default.UseVisualStyleBackColor = true;
            this.but_default.Click += new System.EventHandler(this.but_default_Click);
            // 
            // but_conf
            // 
            this.but_conf.Font = new System.Drawing.Font("Calibri", 15F);
            this.but_conf.ForeColor = System.Drawing.Color.LightSalmon;
            this.but_conf.Location = new System.Drawing.Point(362, 498);
            this.but_conf.Name = "but_conf";
            this.but_conf.Size = new System.Drawing.Size(219, 66);
            this.but_conf.TabIndex = 20;
            this.but_conf.Text = "Подтвердить";
            this.but_conf.UseVisualStyleBackColor = true;
            this.but_conf.Click += new System.EventHandler(this.but_comp_w_Click);
            // 
            // lbl_weight_info
            // 
            this.lbl_weight_info.BackColor = System.Drawing.Color.Transparent;
            this.lbl_weight_info.Font = new System.Drawing.Font("Courier New", 10F);
            this.lbl_weight_info.Location = new System.Drawing.Point(56, 496);
            this.lbl_weight_info.Name = "lbl_weight_info";
            this.lbl_weight_info.Size = new System.Drawing.Size(857, 81);
            this.lbl_weight_info.TabIndex = 22;
            this.lbl_weight_info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_warning_but
            // 
            this.lbl_warning_but.AutoSize = true;
            this.lbl_warning_but.ForeColor = System.Drawing.Color.Red;
            this.lbl_warning_but.Location = new System.Drawing.Point(599, 526);
            this.lbl_warning_but.Name = "lbl_warning_but";
            this.lbl_warning_but.Size = new System.Drawing.Size(73, 20);
            this.lbl_warning_but.TabIndex = 23;
            this.lbl_warning_but.Text = "Ошибка!";
            this.lbl_warning_but.Visible = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightSalmon;
            this.label1.Font = new System.Drawing.Font("Courier New", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(23, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(931, 59);
            this.label1.TabIndex = 24;
            this.label1.Text = "ВЕС будет показывать то, насколько вам важен тот или иной критерий";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Courier New", 13F);
            this.label5.Location = new System.Drawing.Point(27, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(927, 56);
            this.label5.TabIndex = 25;
            this.label5.Text = "Значение ВЕСОВ для трёх критериев в СУММЕ должны быть = 1";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // but_next
            // 
            this.but_next.Font = new System.Drawing.Font("Calibri", 12F);
            this.but_next.ForeColor = System.Drawing.Color.LightSalmon;
            this.but_next.Location = new System.Drawing.Point(751, 580);
            this.but_next.Name = "but_next";
            this.but_next.Size = new System.Drawing.Size(203, 52);
            this.but_next.TabIndex = 39;
            this.but_next.Text = "Продолжить";
            this.but_next.UseVisualStyleBackColor = true;
            this.but_next.Visible = false;
            this.but_next.Click += new System.EventHandler(this.but_next_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Courier New", 11F);
            this.label6.Location = new System.Drawing.Point(28, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(926, 42);
            this.label6.TabIndex = 40;
            this.label6.Text = "Сейчас заданы значения по умолчанию | Вы можете их поменять";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form_component_weight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(220)))), ((int)(((byte)(196)))));
            this.ClientSize = new System.Drawing.Size(967, 652);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.but_next);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_warning_but);
            this.Controls.Add(this.but_conf);
            this.Controls.Add(this.but_default);
            this.Controls.Add(this.tb_emotion);
            this.Controls.Add(this.tb_importance);
            this.Controls.Add(this.tb_urgency);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl_weight_info);
            this.Name = "Form_component_weight";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_component_weight";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_urgency;
        private System.Windows.Forms.TextBox tb_importance;
        private System.Windows.Forms.TextBox tb_emotion;
        private System.Windows.Forms.Button but_default;
        private System.Windows.Forms.Button but_conf;
        private System.Windows.Forms.Label lbl_weight_info;
        private System.Windows.Forms.Label lbl_warning_but;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button but_next;
        private System.Windows.Forms.Label label6;
    }
}