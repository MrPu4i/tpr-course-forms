namespace TPR_Kursovaia_Forms
{
    partial class Start_Form
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
            this.label8 = new System.Windows.Forms.Label();
            this.but_comp_w = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Courier New", 15F);
            this.label8.Location = new System.Drawing.Point(12, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(917, 106);
            this.label8.TabIndex = 27;
            this.label8.Text = "С помощью этой программы вы сможете быстро создать план покупок ваших целей!";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // but_comp_w
            // 
            this.but_comp_w.Font = new System.Drawing.Font("Calibri", 15F);
            this.but_comp_w.ForeColor = System.Drawing.Color.LightSalmon;
            this.but_comp_w.Location = new System.Drawing.Point(364, 332);
            this.but_comp_w.Name = "but_comp_w";
            this.but_comp_w.Size = new System.Drawing.Size(219, 66);
            this.but_comp_w.TabIndex = 36;
            this.but_comp_w.Text = "Начать";
            this.but_comp_w.UseVisualStyleBackColor = true;
            this.but_comp_w.Click += new System.EventHandler(this.but_comp_w_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(82, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(796, 85);
            this.label1.TabIndex = 37;
            this.label1.Text = "Калькулятор целей";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Courier New", 12F);
            this.label2.Location = new System.Drawing.Point(18, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(911, 85);
            this.label2.TabIndex = 38;
            this.label2.Text = "Вам будет выдан помесячный план того, сколько надо откладывать на каждую цель и ч" +
    "ерез сколько вы сможете её получить";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Start_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(220)))), ((int)(((byte)(196)))));
            this.ClientSize = new System.Drawing.Size(954, 433);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.but_comp_w);
            this.Controls.Add(this.label8);
            this.Name = "Start_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start_Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button but_comp_w;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}