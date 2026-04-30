namespace GymSystem
{
    partial class ManageTrainerForm
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
            mainTitle = new Label();
            buttonLogin = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textboxPhone = new TextBox();
            textboxName = new TextBox();
            textBoxSalary = new TextBox();
            SuspendLayout();
            // 
            // mainTitle
            // 
            mainTitle.AutoSize = true;
            mainTitle.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mainTitle.Location = new Point(416, 19);
            mainTitle.Name = "mainTitle";
            mainTitle.Size = new Size(197, 38);
            mainTitle.TabIndex = 29;
            mainTitle.Text = "Add Trainer";
            mainTitle.Click += mainTitle_Click;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = SystemColors.ActiveCaptionText;
            buttonLogin.FlatStyle = FlatStyle.Popup;
            buttonLogin.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLogin.ForeColor = SystemColors.ButtonHighlight;
            buttonLogin.Location = new Point(371, 310);
            buttonLogin.Margin = new Padding(2, 3, 2, 3);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(324, 70);
            buttonLogin.TabIndex = 28;
            buttonLogin.Text = "SAVE";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonSave_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(834, 95);
            label3.Name = "label3";
            label3.Size = new Size(64, 23);
            label3.TabIndex = 24;
            label3.Text = "Salary";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(491, 95);
            label2.Name = "label2";
            label2.Size = new Size(60, 23);
            label2.TabIndex = 23;
            label2.Text = "phone";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(118, 85);
            label1.Name = "label1";
            label1.Size = new Size(59, 23);
            label1.TabIndex = 22;
            label1.Text = "Name";
            // 
            // textboxPhone
            // 
            textboxPhone.Location = new Point(404, 137);
            textboxPhone.Name = "textboxPhone";
            textboxPhone.Size = new Size(250, 27);
            textboxPhone.TabIndex = 19;
            // 
            // textboxName
            // 
            textboxName.Location = new Point(56, 136);
            textboxName.Name = "textboxName";
            textboxName.Size = new Size(250, 27);
            textboxName.TabIndex = 18;
            // 
            // textBoxSalary
            // 
            textBoxSalary.Location = new Point(739, 137);
            textBoxSalary.Name = "textBoxSalary";
            textBoxSalary.Size = new Size(250, 27);
            textBoxSalary.TabIndex = 30;
            // 
            // ManageTrainerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1025, 500);
            Controls.Add(textBoxSalary);
            Controls.Add(mainTitle);
            Controls.Add(buttonLogin);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textboxPhone);
            Controls.Add(textboxName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageTrainerForm";
            Text = "ManageTrainerForm";
            Load += ManageTrainerForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label mainTitle;
        private Button buttonLogin;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textboxPhone;
        private TextBox textboxName;
        private TextBox textBoxSalary;
    }
}