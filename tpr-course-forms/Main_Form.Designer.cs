namespace TPR_Kursovaia_Forms
{
    partial class Main_Form
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
            this.but_default = new System.Windows.Forms.Button();
            this.lbl_emotion = new System.Windows.Forms.Label();
            this.lbl_importance = new System.Windows.Forms.Label();
            this.lbl_urgency = new System.Windows.Forms.Label();
            this.goals_grid = new System.Windows.Forms.DataGridView();
            this.but_add_goal = new System.Windows.Forms.Button();
            this.but_show_plan = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_income = new System.Windows.Forms.Label();
            this.lbl_expenses = new System.Windows.Forms.Label();
            this.lbl_free_money = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.but_about = new System.Windows.Forms.Button();
            this.but_edit_money = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.goals_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // but_default
            // 
            this.but_default.BackColor = System.Drawing.Color.White;
            this.but_default.Font = new System.Drawing.Font("Calibri", 9F);
            this.but_default.ForeColor = System.Drawing.Color.LightSalmon;
            this.but_default.Location = new System.Drawing.Point(651, 20);
            this.but_default.Name = "but_default";
            this.but_default.Size = new System.Drawing.Size(149, 40);
            this.but_default.TabIndex = 42;
            this.but_default.Text = "Редактировать";
            this.but_default.UseVisualStyleBackColor = false;
            this.but_default.Click += new System.EventHandler(this.but_default_Click);
            // 
            // lbl_emotion
            // 
            this.lbl_emotion.AutoSize = true;
            this.lbl_emotion.Font = new System.Drawing.Font("Consolas", 12F);
            this.lbl_emotion.Location = new System.Drawing.Point(421, 162);
            this.lbl_emotion.Name = "lbl_emotion";
            this.lbl_emotion.Size = new System.Drawing.Size(311, 28);
            this.lbl_emotion.TabIndex = 38;
            this.lbl_emotion.Text = "Эмоциональная ценность:";
            this.lbl_emotion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_importance
            // 
            this.lbl_importance.AutoSize = true;
            this.lbl_importance.Font = new System.Drawing.Font("Consolas", 12F);
            this.lbl_importance.Location = new System.Drawing.Point(421, 119);
            this.lbl_importance.Name = "lbl_importance";
            this.lbl_importance.Size = new System.Drawing.Size(116, 28);
            this.lbl_importance.TabIndex = 37;
            this.lbl_importance.Text = "Важность";
            this.lbl_importance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_urgency
            // 
            this.lbl_urgency.AutoSize = true;
            this.lbl_urgency.Font = new System.Drawing.Font("Consolas", 12F);
            this.lbl_urgency.Location = new System.Drawing.Point(421, 76);
            this.lbl_urgency.Name = "lbl_urgency";
            this.lbl_urgency.Size = new System.Drawing.Size(142, 28);
            this.lbl_urgency.TabIndex = 36;
            this.lbl_urgency.Text = "Срочность:";
            this.lbl_urgency.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // goals_grid
            // 
            this.goals_grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(192)))), ((int)(((byte)(156)))));
            this.goals_grid.ColumnHeadersHeight = 32;
            this.goals_grid.Location = new System.Drawing.Point(23, 279);
            this.goals_grid.Name = "goals_grid";
            this.goals_grid.ReadOnly = true;
            this.goals_grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.goals_grid.RowHeadersWidth = 4;
            this.goals_grid.Size = new System.Drawing.Size(699, 274);
            this.goals_grid.TabIndex = 50;
            this.goals_grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Goals_grid_CellClick);
            this.goals_grid.DoubleClick += new System.EventHandler(this.goals_grid_DoubleClick);
            // 
            // but_add_goal
            // 
            this.but_add_goal.Font = new System.Drawing.Font("Calibri", 12F);
            this.but_add_goal.ForeColor = System.Drawing.Color.LightSalmon;
            this.but_add_goal.Location = new System.Drawing.Point(743, 279);
            this.but_add_goal.Name = "but_add_goal";
            this.but_add_goal.Size = new System.Drawing.Size(214, 75);
            this.but_add_goal.TabIndex = 44;
            this.but_add_goal.Text = "Добавить новую\r\nцель +";
            this.but_add_goal.UseVisualStyleBackColor = true;
            this.but_add_goal.Click += new System.EventHandler(this.but_add_Click);
            // 
            // but_show_plan
            // 
            this.but_show_plan.BackColor = System.Drawing.Color.White;
            this.but_show_plan.Cursor = System.Windows.Forms.Cursors.Default;
            this.but_show_plan.Font = new System.Drawing.Font("Calibri", 12F);
            this.but_show_plan.ForeColor = System.Drawing.Color.LightSalmon;
            this.but_show_plan.Location = new System.Drawing.Point(743, 467);
            this.but_show_plan.Name = "but_show_plan";
            this.but_show_plan.Size = new System.Drawing.Size(214, 75);
            this.but_show_plan.TabIndex = 46;
            this.but_show_plan.Text = "Расчитать план";
            this.but_show_plan.UseVisualStyleBackColor = false;
            this.but_show_plan.Click += new System.EventHandler(this.but_show_plan_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(420, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(225, 33);
            this.label5.TabIndex = 47;
            this.label5.Text = "Весв критериев";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(18, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 33);
            this.label6.TabIndex = 48;
            this.label6.Text = "Ваши цели";
            // 
            // lbl_income
            // 
            this.lbl_income.AutoSize = true;
            this.lbl_income.Font = new System.Drawing.Font("Consolas", 12F);
            this.lbl_income.Location = new System.Drawing.Point(18, 76);
            this.lbl_income.Name = "lbl_income";
            this.lbl_income.Size = new System.Drawing.Size(129, 28);
            this.lbl_income.TabIndex = 53;
            this.lbl_income.Text = "Зарплата:";
            // 
            // lbl_expenses
            // 
            this.lbl_expenses.AutoSize = true;
            this.lbl_expenses.Font = new System.Drawing.Font("Consolas", 12F);
            this.lbl_expenses.Location = new System.Drawing.Point(18, 119);
            this.lbl_expenses.Name = "lbl_expenses";
            this.lbl_expenses.Size = new System.Drawing.Size(90, 28);
            this.lbl_expenses.TabIndex = 54;
            this.lbl_expenses.Text = "Траты:";
            // 
            // lbl_free_money
            // 
            this.lbl_free_money.AutoSize = true;
            this.lbl_free_money.Font = new System.Drawing.Font("Consolas", 12F);
            this.lbl_free_money.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbl_free_money.Location = new System.Drawing.Point(19, 162);
            this.lbl_free_money.Name = "lbl_free_money";
            this.lbl_free_money.Size = new System.Drawing.Size(259, 28);
            this.lbl_free_money.TabIndex = 55;
            this.lbl_free_money.Text = "Свободные средства:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(17, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 33);
            this.label1.TabIndex = 57;
            this.label1.Text = "Деньги";
            // 
            // but_about
            // 
            this.but_about.Font = new System.Drawing.Font("Cambria", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_about.ForeColor = System.Drawing.Color.LightSalmon;
            this.but_about.Location = new System.Drawing.Point(897, 20);
            this.but_about.Name = "but_about";
            this.but_about.Size = new System.Drawing.Size(60, 60);
            this.but_about.TabIndex = 58;
            this.but_about.Text = "i";
            this.but_about.UseVisualStyleBackColor = true;
            this.but_about.Click += new System.EventHandler(this.but_about_Click);
            // 
            // but_edit_money
            // 
            this.but_edit_money.BackColor = System.Drawing.Color.White;
            this.but_edit_money.Font = new System.Drawing.Font("Calibri", 9F);
            this.but_edit_money.ForeColor = System.Drawing.Color.LightSalmon;
            this.but_edit_money.Location = new System.Drawing.Point(128, 20);
            this.but_edit_money.Name = "but_edit_money";
            this.but_edit_money.Size = new System.Drawing.Size(149, 40);
            this.but_edit_money.TabIndex = 59;
            this.but_edit_money.Text = "Редактировать";
            this.but_edit_money.UseVisualStyleBackColor = false;
            this.but_edit_money.Click += new System.EventHandler(this.but_edit_money_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(220)))), ((int)(((byte)(196)))));
            this.ClientSize = new System.Drawing.Size(969, 568);
            this.Controls.Add(this.but_edit_money);
            this.Controls.Add(this.but_about);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_free_money);
            this.Controls.Add(this.lbl_expenses);
            this.Controls.Add(this.lbl_income);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.but_show_plan);
            this.Controls.Add(this.but_add_goal);
            this.Controls.Add(this.goals_grid);
            this.Controls.Add(this.but_default);
            this.Controls.Add(this.lbl_emotion);
            this.Controls.Add(this.lbl_importance);
            this.Controls.Add(this.lbl_urgency);
            this.Name = "Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная";
            ((System.ComponentModel.ISupportInitialize)(this.goals_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button but_default;
        private System.Windows.Forms.Label lbl_emotion;
        private System.Windows.Forms.Label lbl_importance;
        private System.Windows.Forms.Label lbl_urgency;
        private System.Windows.Forms.DataGridView goals_grid;
        private System.Windows.Forms.Button but_add_goal;
        private System.Windows.Forms.Button but_show_plan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_income;
        private System.Windows.Forms.Label lbl_expenses;
        private System.Windows.Forms.Label lbl_free_money;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button but_about;
        private System.Windows.Forms.Button but_edit_money;
    }
}