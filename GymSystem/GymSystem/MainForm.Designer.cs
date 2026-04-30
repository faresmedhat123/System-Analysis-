namespace GymManagement
{
    partial class MainForm
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
            panelSidebar = new Panel();
            btnAssignments = new Button();
            btnSubscriptions = new Button();
            btnWorkouts = new Button();
            btnTrainers = new Button();
            btnDashboard = new Button();
            btnMembers = new Button();
            Label2 = new Label();
            Label1 = new Label();
            Label4 = new Label();
            Label3 = new Label();
            panelTop = new Panel();
            panelContainer = new Panel();
            labelexit = new Label();
            panelSidebar.SuspendLayout();
            panelTop.SuspendLayout();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = SystemColors.ControlLight;
            panelSidebar.BorderStyle = BorderStyle.FixedSingle;
            panelSidebar.Controls.Add(btnAssignments);
            panelSidebar.Controls.Add(btnSubscriptions);
            panelSidebar.Controls.Add(btnWorkouts);
            panelSidebar.Controls.Add(btnTrainers);
            panelSidebar.Controls.Add(btnDashboard);
            panelSidebar.Controls.Add(btnMembers);
            panelSidebar.Controls.Add(Label2);
            panelSidebar.Controls.Add(Label1);
            panelSidebar.Dock = DockStyle.Fill;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Margin = new Padding(3, 4, 3, 4);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(1094, 748);
            panelSidebar.TabIndex = 2;
            // 
            // btnAssignments
            // 
            btnAssignments.BackColor = SystemColors.ControlLight;
            btnAssignments.FlatAppearance.BorderSize = 0;
            btnAssignments.FlatStyle = FlatStyle.Flat;
            btnAssignments.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAssignments.ForeColor = SystemColors.WindowFrame;
            btnAssignments.Location = new Point(-1, 438);
            btnAssignments.Margin = new Padding(3, 4, 3, 4);
            btnAssignments.Name = "btnAssignments";
            btnAssignments.Size = new Size(257, 70);
            btnAssignments.TabIndex = 6;
            btnAssignments.Text = "ASSIGNMENTS";
            btnAssignments.UseVisualStyleBackColor = false;
            btnAssignments.Click += btnAssignments_Click;
            // 
            // btnSubscriptions
            // 
            btnSubscriptions.BackColor = SystemColors.ControlLight;
            btnSubscriptions.FlatAppearance.BorderSize = 0;
            btnSubscriptions.FlatStyle = FlatStyle.Flat;
            btnSubscriptions.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubscriptions.ForeColor = SystemColors.WindowFrame;
            btnSubscriptions.Location = new Point(-1, 367);
            btnSubscriptions.Margin = new Padding(3, 4, 3, 4);
            btnSubscriptions.Name = "btnSubscriptions";
            btnSubscriptions.Size = new Size(257, 70);
            btnSubscriptions.TabIndex = 5;
            btnSubscriptions.Text = "SUBSCRIPTION";
            btnSubscriptions.UseVisualStyleBackColor = false;
            btnSubscriptions.Click += btnSubscriptions_Click;
            // 
            // btnWorkouts
            // 
            btnWorkouts.BackColor = SystemColors.ControlLight;
            btnWorkouts.FlatAppearance.BorderSize = 0;
            btnWorkouts.FlatStyle = FlatStyle.Flat;
            btnWorkouts.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnWorkouts.ForeColor = SystemColors.WindowFrame;
            btnWorkouts.Location = new Point(-1, 508);
            btnWorkouts.Margin = new Padding(3, 4, 3, 4);
            btnWorkouts.Name = "btnWorkouts";
            btnWorkouts.Size = new Size(257, 70);
            btnWorkouts.TabIndex = 8;
            btnWorkouts.Text = "WORKOUTS";
            btnWorkouts.UseVisualStyleBackColor = false;
            btnWorkouts.Click += btnWorkouts_Click;
            // 
            // btnTrainers
            // 
            btnTrainers.BackColor = SystemColors.ControlLight;
            btnTrainers.FlatAppearance.BorderSize = 0;
            btnTrainers.FlatStyle = FlatStyle.Flat;
            btnTrainers.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTrainers.ForeColor = SystemColors.WindowFrame;
            btnTrainers.Location = new Point(-1, 297);
            btnTrainers.Margin = new Padding(3, 4, 3, 4);
            btnTrainers.Name = "btnTrainers";
            btnTrainers.Size = new Size(257, 70);
            btnTrainers.TabIndex = 4;
            btnTrainers.Text = "TRAINERS";
            btnTrainers.UseVisualStyleBackColor = false;
            btnTrainers.Click += btnTrainers_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = SystemColors.ControlLight;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = SystemColors.WindowFrame;
            btnDashboard.Location = new Point(-1, 157);
            btnDashboard.Margin = new Padding(3, 4, 3, 4);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(257, 70);
            btnDashboard.TabIndex = 2;
            btnDashboard.Text = "DASHBOARD";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnMembers
            // 
            btnMembers.BackColor = SystemColors.ControlLight;
            btnMembers.FlatAppearance.BorderSize = 0;
            btnMembers.FlatStyle = FlatStyle.Flat;
            btnMembers.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMembers.ForeColor = SystemColors.WindowFrame;
            btnMembers.Location = new Point(-1, 227);
            btnMembers.Margin = new Padding(3, 4, 3, 4);
            btnMembers.Name = "btnMembers";
            btnMembers.Size = new Size(257, 70);
            btnMembers.TabIndex = 3;
            btnMembers.Text = "MEMBERS";
            btnMembers.UseVisualStyleBackColor = false;
            btnMembers.Click += btnMembers_Click;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label2.ForeColor = SystemColors.ControlDarkDark;
            Label2.Location = new Point(37, 116);
            Label2.Name = "Label2";
            Label2.Size = new Size(179, 16);
            Label2.TabIndex = 1;
            Label2.Text = "S Y S T E M   A C T I V E ";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label1.Location = new Point(19, 22);
            Label1.Name = "Label1";
            Label1.Size = new Size(197, 42);
            Label1.TabIndex = 0;
            Label1.Text = "GYM CORE";
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label4.Location = new Point(318, 22);
            Label4.Name = "Label4";
            Label4.Size = new Size(143, 19);
            Label4.TabIndex = 2;
            Label4.Text = "ADMINISTRATOR";
            Label4.Click += Label4_Click;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Arial Black", 10.8F, FontStyle.Bold);
            Label3.Location = new Point(20, 17);
            Label3.Name = "Label3";
            Label3.Size = new Size(292, 26);
            Label3.TabIndex = 1;
            Label3.Text = "GYMMANAGEMENT SYSTEM";
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.White;
            panelTop.Controls.Add(labelexit);
            panelTop.Controls.Add(Label3);
            panelTop.Controls.Add(Label4);
            panelTop.Location = new Point(257, 1);
            panelTop.Margin = new Padding(2);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(2000, 62);
            panelTop.TabIndex = 3;
            // 
            // panelContainer
            // 
            panelContainer.BackColor = Color.White;
            panelContainer.Location = new Point(257, 64);
            panelContainer.Margin = new Padding(2);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(2000, 700);
            panelContainer.TabIndex = 4;
            panelContainer.Paint += panelContainer_Paint;
            // 
            // labelexit
            // 
            labelexit.AutoSize = true;
            labelexit.Font = new Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelexit.Location = new Point(784, 8);
            labelexit.Name = "labelexit";
            labelexit.Size = new Size(41, 42);
            labelexit.TabIndex = 3;
            labelexit.Text = "X";
            labelexit.Click += label5_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1094, 748);
            Controls.Add(panelContainer);
            Controls.Add(panelTop);
            Controls.Add(panelSidebar);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            panelSidebar.ResumeLayout(false);
            panelSidebar.PerformLayout();
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel panelSidebar;
        internal System.Windows.Forms.Button btnAssignments;
        internal System.Windows.Forms.Button btnSubscriptions;
        internal System.Windows.Forms.Button btnWorkouts;
        internal System.Windows.Forms.Button btnTrainers;
        internal System.Windows.Forms.Button btnDashboard;
        internal System.Windows.Forms.Button btnMembers;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelContainer;
        internal Label labelexit;
    }
}