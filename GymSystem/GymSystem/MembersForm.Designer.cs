namespace GymSystem
{
    partial class MembersForm
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
            panelMembers = new Panel();
            membersGridView = new DataGridView();
            button1 = new Button();
            label8 = new Label();
            btnDelete_Member = new Button();
            btnEdit_Member = new Button();
            btnAdd_Member = new Button();
            label9 = new Label();
            panel3 = new Panel();
            label10 = new Label();
            panelMembers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)membersGridView).BeginInit();
            SuspendLayout();
            // 
            // panelMembers
            // 
            panelMembers.Controls.Add(membersGridView);
            panelMembers.Controls.Add(button1);
            panelMembers.Controls.Add(label8);
            panelMembers.Controls.Add(btnDelete_Member);
            panelMembers.Controls.Add(btnEdit_Member);
            panelMembers.Controls.Add(btnAdd_Member);
            panelMembers.Controls.Add(label9);
            panelMembers.Controls.Add(panel3);
            panelMembers.Controls.Add(label10);
            panelMembers.Dock = DockStyle.Fill;
            panelMembers.Location = new Point(0, 0);
            panelMembers.Margin = new Padding(2);
            panelMembers.Name = "panelMembers";
            panelMembers.Size = new Size(1081, 599);
            panelMembers.TabIndex = 17;
            panelMembers.Paint += panelMembers_Paint_2;
            // 
            // membersGridView
            // 
            membersGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            membersGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            membersGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            membersGridView.GridColor = SystemColors.Info;
            membersGridView.Location = new Point(143, 262);
            membersGridView.Name = "membersGridView";
            membersGridView.RowHeadersWidth = 51;
            membersGridView.Size = new Size(550, 188);
            membersGridView.TabIndex = 24;
            membersGridView.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new Point(347, 34);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 23;
            button1.Text = "Refresh";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.DimGray;
            label8.Location = new Point(21, 141);
            label8.Margin = new Padding(1, 0, 1, 0);
            label8.Name = "label8";
            label8.Size = new Size(338, 20);
            label8.TabIndex = 22;
            label8.Text = "memberships within the core facility environment.";
            // 
            // btnDelete_Member
            // 
            btnDelete_Member.FlatStyle = FlatStyle.Flat;
            btnDelete_Member.Font = new Font("Segoe UI", 7.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete_Member.Location = new Point(671, 115);
            btnDelete_Member.Margin = new Padding(3, 2, 3, 2);
            btnDelete_Member.Name = "btnDelete_Member";
            btnDelete_Member.Size = new Size(104, 60);
            btnDelete_Member.TabIndex = 20;
            btnDelete_Member.Text = "DELETE MEMBER";
            btnDelete_Member.UseVisualStyleBackColor = true;
            btnDelete_Member.Click += btnDelete_Member_Click;
            // 
            // btnEdit_Member
            // 
            btnEdit_Member.BackColor = Color.White;
            btnEdit_Member.FlatAppearance.BorderColor = Color.Black;
            btnEdit_Member.FlatStyle = FlatStyle.Flat;
            btnEdit_Member.Font = new Font("Segoe UI", 7.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit_Member.Location = new Point(547, 115);
            btnEdit_Member.Margin = new Padding(3, 2, 3, 2);
            btnEdit_Member.Name = "btnEdit_Member";
            btnEdit_Member.Size = new Size(104, 60);
            btnEdit_Member.TabIndex = 19;
            btnEdit_Member.Text = "EDIT MEMBER";
            btnEdit_Member.UseVisualStyleBackColor = false;
            btnEdit_Member.Click += btnEdit_Member_Click;
            // 
            // btnAdd_Member
            // 
            btnAdd_Member.BackColor = Color.Black;
            btnAdd_Member.FlatAppearance.BorderSize = 0;
            btnAdd_Member.FlatStyle = FlatStyle.Flat;
            btnAdd_Member.Font = new Font("Segoe UI", 7.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd_Member.ForeColor = Color.White;
            btnAdd_Member.Location = new Point(425, 115);
            btnAdd_Member.Margin = new Padding(3, 2, 3, 2);
            btnAdd_Member.Name = "btnAdd_Member";
            btnAdd_Member.Size = new Size(104, 60);
            btnAdd_Member.TabIndex = 18;
            btnAdd_Member.Text = "ADD MEMBER";
            btnAdd_Member.UseVisualStyleBackColor = false;
            btnAdd_Member.Click += btnAdd_Member_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.DimGray;
            label9.Location = new Point(21, 115);
            label9.Margin = new Padding(1, 0, 1, 0);
            label9.Name = "label9";
            label9.Size = new Size(380, 20);
            label9.TabIndex = 16;
            label9.Text = "comprehensive registry of all active and inactive athletic";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.Black;
            panel3.Location = new Point(12, 87);
            panel3.Margin = new Padding(1, 2, 1, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(1691, 8);
            panel3.TabIndex = 15;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Black", 30F, FontStyle.Bold);
            label10.Location = new Point(0, 0);
            label10.Margin = new Padding(1, 0, 1, 0);
            label10.Name = "label10";
            label10.Size = new Size(281, 67);
            label10.TabIndex = 14;
            label10.Text = "MEMBERS";
            // 
            // MembersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1081, 599);
            Controls.Add(panelMembers);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MembersForm";
            Text = "MembersForm";
            Load += MembersForm_Load;
            panelMembers.ResumeLayout(false);
            panelMembers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)membersGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMembers;
        private Button btnDelete_Member;
        private Button btnEdit_Member;
        private Button btnAdd_Member;
        private Panel panel3;
        private Label label10;
        private Label label8;
        private Label label9;
        private Button button1;
        private DataGridView membersGridView;
    }
}