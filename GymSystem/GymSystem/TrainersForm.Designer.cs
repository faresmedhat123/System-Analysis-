namespace GymSystem
{
    partial class TrainersForm
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
            panelTrainers = new Panel();
            trainersdataGridView = new DataGridView();
            btnDeleteTrainer = new Button();
            btnEditTrainer = new Button();
            btnAddTrainer = new Button();
            label7 = new Label();
            label6 = new Label();
            panel1 = new Panel();
            label5 = new Label();
            panelTrainers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trainersdataGridView).BeginInit();
            SuspendLayout();
            // 
            // panelTrainers
            // 
            panelTrainers.Controls.Add(trainersdataGridView);
            panelTrainers.Controls.Add(btnDeleteTrainer);
            panelTrainers.Controls.Add(btnEditTrainer);
            panelTrainers.Controls.Add(btnAddTrainer);
            panelTrainers.Controls.Add(label7);
            panelTrainers.Controls.Add(label6);
            panelTrainers.Controls.Add(panel1);
            panelTrainers.Controls.Add(label5);
            panelTrainers.Dock = DockStyle.Fill;
            panelTrainers.Location = new Point(0, 0);
            panelTrainers.Margin = new Padding(2);
            panelTrainers.Name = "panelTrainers";
            panelTrainers.Size = new Size(1300, 599);
            panelTrainers.TabIndex = 8;
            panelTrainers.Paint += panelTrainers_Paint;
            // 
            // trainersdataGridView
            // 
            trainersdataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            trainersdataGridView.Location = new Point(32, 289);
            trainersdataGridView.Name = "trainersdataGridView";
            trainersdataGridView.RowHeadersWidth = 51;
            trainersdataGridView.Size = new Size(531, 188);
            trainersdataGridView.TabIndex = 13;
            trainersdataGridView.CellContentClick += trainersdataGridView_CellContentClick;
            // 
            // btnDeleteTrainer
            // 
            btnDeleteTrainer.FlatAppearance.BorderSize = 0;
            btnDeleteTrainer.FlatStyle = FlatStyle.Flat;
            btnDeleteTrainer.Font = new Font("Segoe UI", 7.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteTrainer.Location = new Point(407, 183);
            btnDeleteTrainer.Margin = new Padding(3, 2, 3, 2);
            btnDeleteTrainer.Name = "btnDeleteTrainer";
            btnDeleteTrainer.Size = new Size(131, 60);
            btnDeleteTrainer.TabIndex = 12;
            btnDeleteTrainer.Text = "DELETE TRAINER";
            btnDeleteTrainer.UseVisualStyleBackColor = true;
            btnDeleteTrainer.Click += btnDeleteTrainer_Click;
            // 
            // btnEditTrainer
            // 
            btnEditTrainer.BackColor = Color.White;
            btnEditTrainer.FlatAppearance.BorderColor = Color.Black;
            btnEditTrainer.FlatStyle = FlatStyle.Flat;
            btnEditTrainer.Font = new Font("Segoe UI", 7.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditTrainer.Location = new Point(220, 183);
            btnEditTrainer.Margin = new Padding(3, 2, 3, 2);
            btnEditTrainer.Name = "btnEditTrainer";
            btnEditTrainer.Size = new Size(159, 60);
            btnEditTrainer.TabIndex = 11;
            btnEditTrainer.Text = "EDIT TRAINER";
            btnEditTrainer.UseVisualStyleBackColor = false;
            btnEditTrainer.Click += btnEditTrainer_Click;
            // 
            // btnAddTrainer
            // 
            btnAddTrainer.BackColor = Color.Black;
            btnAddTrainer.FlatAppearance.BorderSize = 0;
            btnAddTrainer.FlatStyle = FlatStyle.Flat;
            btnAddTrainer.Font = new Font("Segoe UI", 7.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddTrainer.ForeColor = Color.White;
            btnAddTrainer.Location = new Point(43, 183);
            btnAddTrainer.Margin = new Padding(3, 2, 3, 2);
            btnAddTrainer.Name = "btnAddTrainer";
            btnAddTrainer.Size = new Size(155, 60);
            btnAddTrainer.TabIndex = 10;
            btnAddTrainer.Text = "ADD TRAINER";
            btnAddTrainer.UseVisualStyleBackColor = false;
            btnAddTrainer.Click += btnAddTrainer_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.DimGray;
            label7.Location = new Point(10, 150);
            label7.Margin = new Padding(1, 0, 1, 0);
            label7.Name = "label7";
            label7.Size = new Size(328, 20);
            label7.TabIndex = 6;
            label7.Text = "information, and professional assignment status.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DimGray;
            label6.Location = new Point(10, 124);
            label6.Margin = new Padding(1, 0, 1, 0);
            label6.Name = "label6";
            label6.Size = new Size(515, 20);
            label6.TabIndex = 5;
            label6.Text = "Registry of certified athletic instructors, managing payroll structures, contact ";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(14, 92);
            panel1.Margin = new Padding(1, 2, 1, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1910, 8);
            panel1.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 30F, FontStyle.Bold);
            label5.Location = new Point(5, 2);
            label5.Margin = new Padding(1, 0, 1, 0);
            label5.Name = "label5";
            label5.Size = new Size(282, 67);
            label5.TabIndex = 3;
            label5.Text = "TRAINERS";
            // 
            // TrainersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 599);
            Controls.Add(panelTrainers);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TrainersForm";
            Text = "TrainersForm";
            panelTrainers.ResumeLayout(false);
            panelTrainers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trainersdataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTrainers;
        private Button btnDeleteTrainer;
        private Button btnEditTrainer;
        private Button btnAddTrainer;
        private Label label7;
        private Label label6;
        private Panel panel1;
        private Label label5;
        private DataGridView trainersdataGridView;
    }
}