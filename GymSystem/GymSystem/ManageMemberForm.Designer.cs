namespace GymSystem
{
    partial class ManageMemberForm
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
            colorDialog1 = new ColorDialog();
            textboxName = new TextBox();
            textboxPhone = new TextBox();
            dateTimePickerJoindate = new DateTimePicker();
            dateTimePickerBirthdate = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            comboboxGender = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            buttonLogin = new Button();
            mainTitle = new Label();
            SuspendLayout();
            // 
            // textboxName
            // 
            textboxName.Location = new Point(28, 126);
            textboxName.Name = "textboxName";
            textboxName.Size = new Size(250, 27);
            textboxName.TabIndex = 0;
            // 
            // textboxPhone
            // 
            textboxPhone.Location = new Point(376, 127);
            textboxPhone.Name = "textboxPhone";
            textboxPhone.Size = new Size(250, 27);
            textboxPhone.TabIndex = 2;
            // 
            // dateTimePickerJoindate
            // 
            dateTimePickerJoindate.Location = new Point(690, 291);
            dateTimePickerJoindate.Name = "dateTimePickerJoindate";
            dateTimePickerJoindate.Size = new Size(250, 27);
            dateTimePickerJoindate.TabIndex = 3;
            // 
            // dateTimePickerBirthdate
            // 
            dateTimePickerBirthdate.Location = new Point(28, 291);
            dateTimePickerBirthdate.Name = "dateTimePickerBirthdate";
            dateTimePickerBirthdate.Size = new Size(250, 27);
            dateTimePickerBirthdate.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(90, 75);
            label1.Name = "label1";
            label1.Size = new Size(59, 23);
            label1.TabIndex = 6;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(463, 85);
            label2.Name = "label2";
            label2.Size = new Size(60, 23);
            label2.TabIndex = 10;
            label2.Text = "phone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(806, 85);
            label3.Name = "label3";
            label3.Size = new Size(74, 23);
            label3.TabIndex = 11;
            label3.Text = "Gender";
            // 
            // comboboxGender
            // 
            comboboxGender.FormattingEnabled = true;
            comboboxGender.Items.AddRange(new object[] { "Male", "Female" });
            comboboxGender.Location = new Point(690, 126);
            comboboxGender.Name = "comboboxGender";
            comboboxGender.Size = new Size(250, 28);
            comboboxGender.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(90, 237);
            label4.Name = "label4";
            label4.Size = new Size(94, 23);
            label4.TabIndex = 13;
            label4.Text = "BirthDate";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(794, 237);
            label5.Name = "label5";
            label5.Size = new Size(86, 23);
            label5.TabIndex = 14;
            label5.Text = "JoinDate";
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = SystemColors.ActiveCaptionText;
            buttonLogin.FlatStyle = FlatStyle.Popup;
            buttonLogin.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLogin.ForeColor = SystemColors.ButtonHighlight;
            buttonLogin.Location = new Point(351, 401);
            buttonLogin.Margin = new Padding(2, 3, 2, 3);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(324, 70);
            buttonLogin.TabIndex = 15;
            buttonLogin.Text = "SAVE";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonSave_Click;
            // 
            // mainTitle
            // 
            mainTitle.AutoSize = true;
            mainTitle.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mainTitle.Location = new Point(388, 9);
            mainTitle.Name = "mainTitle";
            mainTitle.Size = new Size(213, 38);
            mainTitle.TabIndex = 17;
            mainTitle.Text = "Add Member";
            mainTitle.Click += label7_Click;
            // 
            // ManageMemberForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1025, 500);
            Controls.Add(mainTitle);
            Controls.Add(buttonLogin);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(comboboxGender);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePickerBirthdate);
            Controls.Add(dateTimePickerJoindate);
            Controls.Add(textboxPhone);
            Controls.Add(textboxName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageMemberForm";
            Text = "AddMemberForm";
            Load += AddMemberForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ColorDialog colorDialog1;
        private TextBox textboxName;
        private TextBox textboxPhone;
        private DateTimePicker dateTimePickerJoindate;
        private DateTimePicker dateTimePickerBirthdate;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboboxGender;
        private Label label4;
        private Label label5;
        private Button buttonLogin;
        private Label mainTitle;
    }
}