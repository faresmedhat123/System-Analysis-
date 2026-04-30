using GymSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagement
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Database db = new Database();

            db.InitializeDatabase();

            createWorkoutTable();
        }

        private void createWorkoutTable()
        {
            Database db = new Database();

            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string query = @"
        IF NOT EXISTS (SELECT * FROM sysobjects 
                       WHERE name='Workout' AND xtype='U')
        CREATE TABLE Workout (
            ID INT PRIMARY KEY IDENTITY(1,1),
            Name VARCHAR(100) NOT NULL,
            Sets INT,
            Reps INT,
            Target_Muscle VARCHAR(50)
        );";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void LoadForm(Form f)
        {
            panelContainer.Controls.Clear();

            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;

            panelContainer.Controls.Add(f);
            f.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            LoadForm(new DashboardForm());
        }

        private void btnMembers_Click(object sender, EventArgs e)
        {
            LoadForm(new MembersForm());
        }

        private void btnTrainers_Click(object sender, EventArgs e)
        {
            LoadForm(new TrainersForm());
        }

        private void btnSubscriptions_Click(object sender, EventArgs e)
        {
            LoadForm(new SubscriptionsForm());
        }

        private void btnAssignments_Click(object sender, EventArgs e)
        {
            LoadForm(new AssignmentsForm());
        }

        private void btnWorkouts_Click(object sender, EventArgs e)
        {
            LoadForm(new WorkoutsForm());
        }

      

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}