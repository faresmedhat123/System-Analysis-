namespace GymSystem
{
    partial class WorkoutsForm
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
            panelWorkout = new Panel();
            workoutdataGridView = new DataGridView();
            panel2 = new Panel();
            btnAdd_Workout = new Button();
            targetmusclecomboBox = new ComboBox();
            label19 = new Label();
            repstextBox = new TextBox();
            setstextBox = new TextBox();
            label18 = new Label();
            label17 = new Label();
            workoutnametextBox = new TextBox();
            label15 = new Label();
            label16 = new Label();
            label14 = new Label();
            label13 = new Label();
            panelWorkout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)workoutdataGridView).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panelWorkout
            // 
            panelWorkout.Controls.Add(workoutdataGridView);
            panelWorkout.Controls.Add(panel2);
            panelWorkout.Controls.Add(label14);
            panelWorkout.Controls.Add(label13);
            panelWorkout.Dock = DockStyle.Fill;
            panelWorkout.Location = new Point(0, 0);
            panelWorkout.Margin = new Padding(2);
            panelWorkout.Name = "panelWorkout";
            panelWorkout.Size = new Size(1050, 599);
            panelWorkout.TabIndex = 7;
            panelWorkout.Paint += panelWorkout_Paint;
            // 
            // workoutdataGridView
            // 
            workoutdataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            workoutdataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            workoutdataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            workoutdataGridView.Location = new Point(12, 174);
            workoutdataGridView.Name = "workoutdataGridView";
            workoutdataGridView.RowHeadersWidth = 51;
            workoutdataGridView.Size = new Size(492, 273);
            workoutdataGridView.TabIndex = 17;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(btnAdd_Workout);
            panel2.Controls.Add(targetmusclecomboBox);
            panel2.Controls.Add(label19);
            panel2.Controls.Add(repstextBox);
            panel2.Controls.Add(setstextBox);
            panel2.Controls.Add(label18);
            panel2.Controls.Add(label17);
            panel2.Controls.Add(workoutnametextBox);
            panel2.Controls.Add(label15);
            panel2.Controls.Add(label16);
            panel2.Location = new Point(544, 29);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(290, 529);
            panel2.TabIndex = 16;
            // 
            // btnAdd_Workout
            // 
            btnAdd_Workout.BackColor = SystemColors.ActiveCaptionText;
            btnAdd_Workout.Font = new Font("Microsoft Sans Serif", 7.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd_Workout.ForeColor = SystemColors.HighlightText;
            btnAdd_Workout.Location = new Point(58, 395);
            btnAdd_Workout.Margin = new Padding(3, 4, 3, 4);
            btnAdd_Workout.Name = "btnAdd_Workout";
            btnAdd_Workout.Size = new Size(161, 60);
            btnAdd_Workout.TabIndex = 9;
            btnAdd_Workout.Text = "ADD WORKOUT";
            btnAdd_Workout.UseVisualStyleBackColor = false;
            btnAdd_Workout.Click += btnAdd_Workout_Click;
            // 
            // targetmusclecomboBox
            // 
            targetmusclecomboBox.FormattingEnabled = true;
            targetmusclecomboBox.Items.AddRange(new object[] { "Back", "Sholder", "Leg", "Arms", "Chest" });
            targetmusclecomboBox.Location = new Point(26, 309);
            targetmusclecomboBox.Margin = new Padding(2);
            targetmusclecomboBox.Name = "targetmusclecomboBox";
            targetmusclecomboBox.Size = new Size(197, 28);
            targetmusclecomboBox.TabIndex = 8;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            label19.ForeColor = SystemColors.GrayText;
            label19.Location = new Point(24, 273);
            label19.Margin = new Padding(2, 0, 2, 0);
            label19.Name = "label19";
            label19.Size = new Size(178, 16);
            label19.TabIndex = 7;
            label19.Text = "T A R G E T  M U S C L E";
            // 
            // repstextBox
            // 
            repstextBox.BorderStyle = BorderStyle.None;
            repstextBox.Location = new Point(155, 207);
            repstextBox.Margin = new Padding(2);
            repstextBox.Name = "repstextBox";
            repstextBox.Size = new Size(67, 20);
            repstextBox.TabIndex = 6;
            // 
            // setstextBox
            // 
            setstextBox.BorderStyle = BorderStyle.None;
            setstextBox.Location = new Point(27, 207);
            setstextBox.Margin = new Padding(2);
            setstextBox.Name = "setstextBox";
            setstextBox.Size = new Size(67, 20);
            setstextBox.TabIndex = 5;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            label18.ForeColor = SystemColors.GrayText;
            label18.Location = new Point(152, 174);
            label18.Margin = new Padding(2, 0, 2, 0);
            label18.Name = "label18";
            label18.Size = new Size(60, 16);
            label18.TabIndex = 4;
            label18.Text = "R E P S";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            label17.ForeColor = SystemColors.GrayText;
            label17.Location = new Point(24, 174);
            label17.Margin = new Padding(2, 0, 2, 0);
            label17.Name = "label17";
            label17.Size = new Size(59, 16);
            label17.TabIndex = 3;
            label17.Text = "S E T S";
            // 
            // workoutnametextBox
            // 
            workoutnametextBox.BorderStyle = BorderStyle.None;
            workoutnametextBox.Location = new Point(26, 126);
            workoutnametextBox.Margin = new Padding(2);
            workoutnametextBox.Name = "workoutnametextBox";
            workoutnametextBox.Size = new Size(214, 20);
            workoutnametextBox.TabIndex = 2;
            workoutnametextBox.TextChanged += textBox1_TextChanged;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = SystemColors.GrayText;
            label15.Location = new Point(23, 98);
            label15.Name = "label15";
            label15.Size = new Size(175, 16);
            label15.TabIndex = 1;
            label15.Text = "W O R K O U T  N A M E ";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.ForeColor = SystemColors.Desktop;
            label16.Location = new Point(18, 32);
            label16.Name = "label16";
            label16.Size = new Size(198, 28);
            label16.TabIndex = 0;
            label16.Text = "ADD WORKOUTS";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Bold);
            label14.Location = new Point(7, 69);
            label14.Name = "label14";
            label14.Size = new Size(381, 15);
            label14.TabIndex = 2;
            label14.Text = "L A T E S T  T E C H N I C A L   L E D G E R   -   V . 2 4 . 0 2";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial Black", 20F, FontStyle.Bold);
            label13.ForeColor = SystemColors.ActiveCaptionText;
            label13.Location = new Point(1, 0);
            label13.Name = "label13";
            label13.Size = new Size(240, 48);
            label13.TabIndex = 1;
            label13.Text = "WORKOUTS";
            // 
            // WorkoutsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 599);
            Controls.Add(panelWorkout);
            FormBorderStyle = FormBorderStyle.None;
            Name = "WorkoutsForm";
            Text = "WorkoutsForm";
            Load += WorkoutsForm_Load;
            panelWorkout.ResumeLayout(false);
            panelWorkout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)workoutdataGridView).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelWorkout;
        private Panel panel2;
        internal Button btnAdd_Workout;
        private ComboBox targetmusclecomboBox;
        private Label label19;
        private TextBox repstextBox;
        private TextBox setstextBox;
        private Label label18;
        private Label label17;
        private TextBox workoutnametextBox;
        private Label label15;
        private Label label16;
        private Label label14;
        private Label label13;
        private DataGridView workoutdataGridView;
    }
}