namespace GymSystem
{
    partial class DashboardForm
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
            panelSystemStatistics = new Panel();
            btnRefresh = new Button();
            label12 = new Label();
            label11 = new Label();
            label1 = new Label();
            label5 = new Label();
            lblMembersCount = new Label();
            lblTrainersCount = new Label();
            panelSystemStatistics.SuspendLayout();
            SuspendLayout();
            // 
            // panelSystemStatistics
            // 
            panelSystemStatistics.Controls.Add(lblTrainersCount);
            panelSystemStatistics.Controls.Add(lblMembersCount);
            panelSystemStatistics.Controls.Add(label5);
            panelSystemStatistics.Controls.Add(label1);
            panelSystemStatistics.Controls.Add(btnRefresh);
            panelSystemStatistics.Controls.Add(label12);
            panelSystemStatistics.Controls.Add(label11);
            panelSystemStatistics.Dock = DockStyle.Fill;
            panelSystemStatistics.Location = new Point(0, 0);
            panelSystemStatistics.Margin = new Padding(2);
            panelSystemStatistics.Name = "panelSystemStatistics";
            panelSystemStatistics.Size = new Size(1050, 599);
            panelSystemStatistics.TabIndex = 4;
            panelSystemStatistics.Paint += panelSystemStatistics_Paint;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = SystemColors.ActiveCaptionText;
            btnRefresh.ForeColor = SystemColors.HighlightText;
            btnRefresh.Location = new Point(648, 38);
            btnRefresh.Margin = new Padding(3, 4, 3, 4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(161, 60);
            btnRefresh.TabIndex = 7;
            btnRefresh.Text = "REFRESH";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Bold);
            label12.ForeColor = SystemColors.WindowFrame;
            label12.Location = new Point(5, 72);
            label12.Name = "label12";
            label12.Size = new Size(301, 15);
            label12.TabIndex = 6;
            label12.Text = "CORE  DATABASE  PERFORMANVE  LEDGER ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial Black", 20F, FontStyle.Bold);
            label11.Location = new Point(7, 0);
            label11.Name = "label11";
            label11.Size = new Size(412, 48);
            label11.TabIndex = 5;
            label11.Text = "SYSTEM STATISTICS";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 177);
            label1.Name = "label1";
            label1.Size = new Size(326, 60);
            label1.TabIndex = 8;
            label1.Text = " Total Members";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(21, 332);
            label5.Name = "label5";
            label5.Size = new Size(291, 60);
            label5.TabIndex = 12;
            label5.Text = " Total Trainers";
            // 
            // lblMembersCount
            // 
            lblMembersCount.AutoSize = true;
            lblMembersCount.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMembersCount.Location = new Point(503, 177);
            lblMembersCount.Name = "lblMembersCount";
            lblMembersCount.Size = new Size(73, 60);
            lblMembersCount.TabIndex = 13;
            lblMembersCount.Text = "25";
            // 
            // lblTrainersCount
            // 
            lblTrainersCount.AutoSize = true;
            lblTrainersCount.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTrainersCount.Location = new Point(503, 332);
            lblTrainersCount.Name = "lblTrainersCount";
            lblTrainersCount.Size = new Size(49, 60);
            lblTrainersCount.TabIndex = 14;
            lblTrainersCount.Text = "5";
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 599);
            Controls.Add(panelSystemStatistics);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DashboardForm";
            Text = "DashboardForm";
            panelSystemStatistics.ResumeLayout(false);
            panelSystemStatistics.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSystemStatistics;
        internal Button btnRefresh;
        internal Label label12;
        internal Label label11;
        private Label label1;
        private Label lblTrainersCount;
        private Label lblMembersCount;
        private Label label5;
    }
}