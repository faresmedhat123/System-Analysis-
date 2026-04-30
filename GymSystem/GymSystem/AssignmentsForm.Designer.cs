namespace GymSystem
{
    partial class AssignmentsForm
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
            panelAssignment = new Panel();
            panel10 = new Panel();
            comboTrainer = new ComboBox();
            comboMember = new ComboBox();
            btnAssign = new Button();
            label35 = new Label();
            label34 = new Label();
            panel11 = new Panel();
            btnSecure = new Button();
            btnReady = new Button();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            label33 = new Label();
            label32 = new Label();
            label31 = new Label();
            label30 = new Label();
            panelAssignment.SuspendLayout();
            panel10.SuspendLayout();
            panel11.SuspendLayout();
            SuspendLayout();
            // 
            // panelAssignment
            // 
            panelAssignment.Controls.Add(panel10);
            panelAssignment.Controls.Add(label31);
            panelAssignment.Controls.Add(label30);
            panelAssignment.Dock = DockStyle.Fill;
            panelAssignment.Location = new Point(0, 0);
            panelAssignment.Margin = new Padding(2);
            panelAssignment.Name = "panelAssignment";
            panelAssignment.Size = new Size(1050, 599);
            panelAssignment.TabIndex = 11;
            panelAssignment.Paint += panelAssignment_Paint;
            // 
            // panel10
            // 
            panel10.Controls.Add(comboTrainer);
            panel10.Controls.Add(comboMember);
            panel10.Controls.Add(btnAssign);
            panel10.Controls.Add(label35);
            panel10.Controls.Add(label34);
            panel10.Controls.Add(panel11);
            panel10.Location = new Point(15, 106);
            panel10.Margin = new Padding(2);
            panel10.Name = "panel10";
            panel10.Size = new Size(794, 546);
            panel10.TabIndex = 3;
            // 
            // comboTrainer
            // 
            comboTrainer.FormattingEnabled = true;
            comboTrainer.Location = new Point(349, 211);
            comboTrainer.Margin = new Padding(2);
            comboTrainer.Name = "comboTrainer";
            comboTrainer.Size = new Size(414, 28);
            comboTrainer.TabIndex = 5;
            // 
            // comboMember
            // 
            comboMember.FormattingEnabled = true;
            comboMember.Location = new Point(349, 84);
            comboMember.Margin = new Padding(2);
            comboMember.Name = "comboMember";
            comboMember.Size = new Size(414, 28);
            comboMember.TabIndex = 4;
            // 
            // btnAssign
            // 
            btnAssign.BackColor = Color.Black;
            btnAssign.FlatStyle = FlatStyle.Flat;
            btnAssign.Font = new Font("Microsoft Sans Serif", 7.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAssign.ForeColor = Color.White;
            btnAssign.Location = new Point(345, 381);
            btnAssign.Margin = new Padding(2);
            btnAssign.Name = "btnAssign";
            btnAssign.Size = new Size(413, 69);
            btnAssign.TabIndex = 3;
            btnAssign.Text = "A S S I G N ";
            btnAssign.UseVisualStyleBackColor = false;
            btnAssign.Click += btnAssign_Click;
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Font = new Font("Microsoft Sans Serif", 7.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label35.ForeColor = SystemColors.GrayText;
            label35.Location = new Point(345, 157);
            label35.Margin = new Padding(2, 0, 2, 0);
            label35.Name = "label35";
            label35.Size = new Size(204, 17);
            label35.TabIndex = 2;
            label35.Text = "S E L E C T  T R A I N E R ";
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Font = new Font("Microsoft Sans Serif", 7.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label34.ForeColor = SystemColors.GrayText;
            label34.Location = new Point(345, 38);
            label34.Margin = new Padding(2, 0, 2, 0);
            label34.Name = "label34";
            label34.Size = new Size(197, 17);
            label34.TabIndex = 1;
            label34.Text = "S E L E C T  M E M B E R ";
            // 
            // panel11
            // 
            panel11.BackColor = SystemColors.ControlLight;
            panel11.Controls.Add(btnSecure);
            panel11.Controls.Add(btnReady);
            panel11.Controls.Add(textBox5);
            panel11.Controls.Add(textBox4);
            panel11.Controls.Add(label33);
            panel11.Controls.Add(label32);
            panel11.ForeColor = SystemColors.ControlText;
            panel11.Location = new Point(1, 0);
            panel11.Margin = new Padding(2);
            panel11.Name = "panel11";
            panel11.Size = new Size(317, 546);
            panel11.TabIndex = 0;
            // 
            // btnSecure
            // 
            btnSecure.FlatAppearance.BorderSize = 0;
            btnSecure.FlatStyle = FlatStyle.Flat;
            btnSecure.Font = new Font("Microsoft Sans Serif", 7.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSecure.Location = new Point(213, 285);
            btnSecure.Margin = new Padding(2);
            btnSecure.Name = "btnSecure";
            btnSecure.Size = new Size(82, 25);
            btnSecure.TabIndex = 5;
            btnSecure.Text = "SECURE";
            btnSecure.UseVisualStyleBackColor = true;
            // 
            // btnReady
            // 
            btnReady.FlatAppearance.BorderSize = 0;
            btnReady.FlatStyle = FlatStyle.Flat;
            btnReady.Font = new Font("Microsoft Sans Serif", 7.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReady.Location = new Point(219, 217);
            btnReady.Margin = new Padding(2);
            btnReady.Name = "btnReady";
            btnReady.Size = new Size(69, 31);
            btnReady.TabIndex = 4;
            btnReady.Text = "READY";
            btnReady.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(19, 285);
            textBox5.Margin = new Padding(2);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(176, 27);
            textBox5.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(19, 220);
            textBox4.Margin = new Padding(2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(176, 27);
            textBox4.TabIndex = 2;
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Location = new Point(19, 63);
            label33.Margin = new Padding(2, 0, 2, 0);
            label33.Name = "label33";
            label33.Size = new Size(232, 120);
            label33.TabIndex = 1;
            label33.Text = "Select a member from the active\r\ndatabase and pair them with a\r\ncertified trainer. This action \r\nupdates the member's current\r\ntraining cycle and notifies the\r\ntrainer via the internal dashboard.";
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Font = new Font("Microsoft Sans Serif", 7.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label32.Location = new Point(16, 21);
            label32.Margin = new Padding(2, 0, 2, 0);
            label32.Name = "label32";
            label32.Size = new Size(177, 17);
            label32.TabIndex = 0;
            label32.Text = "I N S T R U C T I O N S";
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Font = new Font("Microsoft Sans Serif", 6F, FontStyle.Bold);
            label31.ForeColor = SystemColors.GrayText;
            label31.Location = new Point(5, 75);
            label31.Margin = new Padding(2, 0, 2, 0);
            label31.Name = "label31";
            label31.Size = new Size(381, 13);
            label31.TabIndex = 2;
            label31.Text = "T R A I N E R  T O  M E M B E R  A L L O C A T I O N M O D U L E";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new Font("Arial Black", 22F, FontStyle.Bold);
            label30.Location = new Point(5, 1);
            label30.Name = "label30";
            label30.Size = new Size(301, 52);
            label30.TabIndex = 1;
            label30.Text = "ASSIGNMENT";
            // 
            // AssignmentsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 599);
            Controls.Add(panelAssignment);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AssignmentsForm";
            Text = "AssignmentsForm";
            panelAssignment.ResumeLayout(false);
            panelAssignment.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelAssignment;
        private Panel panel10;
        private ComboBox comboTrainer;
        private ComboBox comboMember;
        private Button btnAssign;
        private Label label35;
        private Label label34;
        private Panel panel11;
        private Button btnSecure;
        private Button btnReady;
        private TextBox textBox5;
        private TextBox textBox4;
        private Label label33;
        private Label label32;
        private Label label31;
        private Label label30;
    }
}