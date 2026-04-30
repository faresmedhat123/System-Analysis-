namespace GymManagement
{
    partial class LoginForm
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
            panel1 = new Panel();
            panel4 = new Panel();
            label7 = new Label();
            label8 = new Label();
            label5 = new Label();
            panel3 = new Panel();
            textboxEmail = new TextBox();
            panel2 = new Panel();
            textboxPassword = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            buttonLogin = new Button();
            labelexit = new Label();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(labelexit);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(buttonLogin);
            panel1.Location = new Point(288, 29);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(451, 647);
            panel1.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label8);
            panel4.Location = new Point(2, 541);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new Size(451, 105);
            panel4.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ControlDarkDark;
            label7.Location = new Point(355, 44);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(74, 22);
            label7.TabIndex = 10;
            label7.Text = "V.2.0.4";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ControlDarkDark;
            label8.Location = new Point(49, 46);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(236, 22);
            label8.TabIndex = 11;
            label8.Text = "SECURE ACCESS ONLY";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(191, 457);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(textboxEmail);
            panel3.Location = new Point(66, 222);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(327, 63);
            panel3.TabIndex = 7;
            // 
            // textboxEmail
            // 
            textboxEmail.BorderStyle = BorderStyle.None;
            textboxEmail.Location = new Point(-1, 17);
            textboxEmail.Margin = new Padding(2);
            textboxEmail.Name = "textboxEmail";
            textboxEmail.Size = new Size(326, 20);
            textboxEmail.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(textboxPassword);
            panel2.Location = new Point(66, 331);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(327, 62);
            panel2.TabIndex = 6;
            // 
            // textboxPassword
            // 
            textboxPassword.BorderStyle = BorderStyle.None;
            textboxPassword.Location = new Point(-1, 20);
            textboxPassword.Margin = new Padding(2);
            textboxPassword.Name = "textboxPassword";
            textboxPassword.Size = new Size(326, 20);
            textboxPassword.TabIndex = 1;
            textboxPassword.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(66, 107);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(214, 19);
            label4.TabIndex = 5;
            label4.Text = "GYM CORE SYSTEM ACTIVE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Black", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(59, 20);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(207, 70);
            label3.TabIndex = 4;
            label3.Text = "LOGIN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(66, 294);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(139, 18);
            label2.TabIndex = 3;
            label2.Text = "P A S S W O R D";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(66, 180);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(136, 18);
            label1.TabIndex = 2;
            label1.Text = "U S E R N A M E";
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = SystemColors.ActiveCaptionText;
            buttonLogin.FlatStyle = FlatStyle.Popup;
            buttonLogin.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLogin.ForeColor = SystemColors.ButtonHighlight;
            buttonLogin.Location = new Point(68, 415);
            buttonLogin.Margin = new Padding(2, 3, 2, 3);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(324, 70);
            buttonLogin.TabIndex = 1;
            buttonLogin.Text = "LOGIN \r\n";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += button1_Click;
            // 
            // labelexit
            // 
            labelexit.AutoSize = true;
            labelexit.Font = new Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelexit.Location = new Point(391, 9);
            labelexit.Name = "labelexit";
            labelexit.Size = new Size(41, 42);
            labelexit.TabIndex = 11;
            labelexit.Text = "X";
            labelexit.Click += labelexit_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1063, 774);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "LoginForm";
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox textboxEmail;
        private System.Windows.Forms.TextBox textboxPassword;
        internal Label labelexit;
    }
}

