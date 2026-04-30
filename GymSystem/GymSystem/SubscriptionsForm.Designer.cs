namespace GymSystem
{
    partial class SubscriptionsForm
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
            panelSubscriptionManagement = new Panel();
            panel8 = new Panel();
            enddateTimePicker = new DateTimePicker();
            startdateTimePicker = new DateTimePicker();
            plancomboBox = new ComboBox();
            membercomboBox = new ComboBox();
            label29 = new Label();
            label28 = new Label();
            label27 = new Label();
            label26 = new Label();
            btnConfirm_Assignment = new Button();
            label25 = new Label();
            label24 = new Label();
            panel6 = new Panel();
            label23 = new Label();
            panelSubscriptionManagement.SuspendLayout();
            panel8.SuspendLayout();
            SuspendLayout();
            // 
            // panelSubscriptionManagement
            // 
            panelSubscriptionManagement.Controls.Add(panel8);
            panelSubscriptionManagement.Controls.Add(label24);
            panelSubscriptionManagement.Controls.Add(panel6);
            panelSubscriptionManagement.Controls.Add(label23);
            panelSubscriptionManagement.Dock = DockStyle.Fill;
            panelSubscriptionManagement.Location = new Point(0, 0);
            panelSubscriptionManagement.Margin = new Padding(2);
            panelSubscriptionManagement.Name = "panelSubscriptionManagement";
            panelSubscriptionManagement.Size = new Size(1050, 599);
            panelSubscriptionManagement.TabIndex = 5;
            // 
            // panel8
            // 
            panel8.Controls.Add(enddateTimePicker);
            panel8.Controls.Add(startdateTimePicker);
            panel8.Controls.Add(plancomboBox);
            panel8.Controls.Add(membercomboBox);
            panel8.Controls.Add(label29);
            panel8.Controls.Add(label28);
            panel8.Controls.Add(label27);
            panel8.Controls.Add(label26);
            panel8.Controls.Add(btnConfirm_Assignment);
            panel8.Controls.Add(label25);
            panel8.Location = new Point(368, 22);
            panel8.Margin = new Padding(2);
            panel8.Name = "panel8";
            panel8.Size = new Size(430, 563);
            panel8.TabIndex = 9;
            panel8.Paint += panel8_Paint;
            // 
            // enddateTimePicker
            // 
            enddateTimePicker.Location = new Point(245, 326);
            enddateTimePicker.Margin = new Padding(2);
            enddateTimePicker.Name = "enddateTimePicker";
            enddateTimePicker.Size = new Size(183, 27);
            enddateTimePicker.TabIndex = 11;
            // 
            // startdateTimePicker
            // 
            startdateTimePicker.Location = new Point(30, 326);
            startdateTimePicker.Margin = new Padding(2);
            startdateTimePicker.Name = "startdateTimePicker";
            startdateTimePicker.Size = new Size(185, 27);
            startdateTimePicker.TabIndex = 10;
            // 
            // plancomboBox
            // 
            plancomboBox.FormattingEnabled = true;
            plancomboBox.Items.AddRange(new object[] { "1 Month", "3 Months", "6 Months", "1 Year" });
            plancomboBox.Location = new Point(33, 192);
            plancomboBox.Margin = new Padding(2);
            plancomboBox.Name = "plancomboBox";
            plancomboBox.Size = new Size(366, 28);
            plancomboBox.TabIndex = 9;
            // 
            // membercomboBox
            // 
            membercomboBox.FormattingEnabled = true;
            membercomboBox.Location = new Point(33, 67);
            membercomboBox.Margin = new Padding(2);
            membercomboBox.Name = "membercomboBox";
            membercomboBox.Size = new Size(366, 28);
            membercomboBox.TabIndex = 8;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Font = new Font("Microsoft Sans Serif", 7.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label29.ForeColor = SystemColors.GrayText;
            label29.Location = new Point(245, 278);
            label29.Margin = new Padding(2, 0, 2, 0);
            label29.Name = "label29";
            label29.Size = new Size(149, 17);
            label29.TabIndex = 7;
            label29.Text = "0 4. E N D  D A T E";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("Microsoft Sans Serif", 7.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label28.ForeColor = SystemColors.GrayText;
            label28.Location = new Point(37, 279);
            label28.Margin = new Padding(2, 0, 2, 0);
            label28.Name = "label28";
            label28.Size = new Size(178, 17);
            label28.TabIndex = 6;
            label28.Text = "0 3. S T A R T  D A T E";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Microsoft Sans Serif", 7.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label27.ForeColor = SystemColors.GrayText;
            label27.Location = new Point(33, 161);
            label27.Margin = new Padding(2, 0, 2, 0);
            label27.Name = "label27";
            label27.Size = new Size(190, 17);
            label27.TabIndex = 5;
            label27.Text = "0 2. S E L E C T  P L A N";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Microsoft Sans Serif", 7.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label26.ForeColor = SystemColors.GrayText;
            label26.Location = new Point(30, 37);
            label26.Margin = new Padding(2, 0, 2, 0);
            label26.Name = "label26";
            label26.Size = new Size(225, 17);
            label26.TabIndex = 4;
            label26.Text = "0 1. S E L E C T  M E M B E R";
            // 
            // btnConfirm_Assignment
            // 
            btnConfirm_Assignment.BackColor = SystemColors.ActiveCaptionText;
            btnConfirm_Assignment.ForeColor = SystemColors.HighlightText;
            btnConfirm_Assignment.Location = new Point(48, 442);
            btnConfirm_Assignment.Margin = new Padding(3, 4, 3, 4);
            btnConfirm_Assignment.Name = "btnConfirm_Assignment";
            btnConfirm_Assignment.Size = new Size(338, 59);
            btnConfirm_Assignment.TabIndex = 3;
            btnConfirm_Assignment.Text = "C O N F I R M  A S S I G N M E N T";
            btnConfirm_Assignment.UseVisualStyleBackColor = false;
            btnConfirm_Assignment.Click += btnConfirm_Assignment_Click;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Microsoft Sans Serif", 6F);
            label25.ForeColor = SystemColors.GrayText;
            label25.Location = new Point(47, 516);
            label25.Name = "label25";
            label25.Size = new Size(327, 26);
            label25.TabIndex = 2;
            label25.Text = "SUBMISSION WILL GENERATE A FISCAL RECORD AND MEMBER\r\n                                         ACCESS KEY.";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Microsoft YaHei", 8F);
            label24.Location = new Point(57, 164);
            label24.Name = "label24";
            label24.Size = new Size(289, 80);
            label24.TabIndex = 8;
            label24.Text = "Configure professional service access for\r\nvalidated gym members.Select duration,\r\nplan architecture,and verification dates to\r\nfinalize the operational agreement.";
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ActiveCaptionText;
            panel6.Location = new Point(45, 164);
            panel6.Margin = new Padding(3, 4, 3, 4);
            panel6.Name = "panel6";
            panel6.Size = new Size(6, 96);
            panel6.TabIndex = 7;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Arial Black", 22F, FontStyle.Bold);
            label23.Location = new Point(37, 24);
            label23.Name = "label23";
            label23.Size = new Size(338, 104);
            label23.TabIndex = 5;
            label23.Text = "SUBSCRIPTION\r\nMANAGEMENT";
            // 
            // SubscriptionsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 599);
            Controls.Add(panelSubscriptionManagement);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SubscriptionsForm";
            Text = "SubscriptionsForm";
            panelSubscriptionManagement.ResumeLayout(false);
            panelSubscriptionManagement.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSubscriptionManagement;
        private Panel panel8;
        private DateTimePicker enddateTimePicker;
        private DateTimePicker startdateTimePicker;
        private ComboBox plancomboBox;
        private ComboBox membercomboBox;
        private Label label29;
        private Label label28;
        private Label label27;
        private Label label26;
        private Button btnConfirm_Assignment;
        private Label label25;
        private Label label24;
        private Panel panel6;
        private Label label23;
    }
}