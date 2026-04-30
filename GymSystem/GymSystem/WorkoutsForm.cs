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
using System.Xml.Linq;

namespace GymSystem
{
    public partial class WorkoutsForm : Form
    {
        public WorkoutsForm()
        {
            InitializeComponent();
            LoadWorkouts();
        }
     

        private void LoadWorkouts()
        {
            Database db = new Database();

            using (SqlConnection con = db.GetConnection())
            {
                con.Open();

                string query = "SELECT * FROM Workout";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                workoutdataGridView.DataSource = dt;
            }
        }

        private void WorkoutsForm_Load(object sender, EventArgs e)
        {

        }

        private void panelWorkout_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdd_Workout_Click(object sender, EventArgs e)
        {

            Database db = new Database();

            using (SqlConnection con = db.GetConnection())
            {
                con.Open();

                string query = @"
        INSERT INTO Workout (Name, Sets, Reps, Target_Muscle)
        VALUES (@Name, @Sets, @Reps, @Target_Muscle)";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@Name", workoutnametextBox.Text);
                cmd.Parameters.AddWithValue("@Sets", Convert.ToInt32(setstextBox.Text));
                cmd.Parameters.AddWithValue("@Reps", Convert.ToInt32(repstextBox.Text));
                cmd.Parameters.AddWithValue("@Target_Muscle", targetmusclecomboBox.SelectedItem.ToString());

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Workout added successfully");

            LoadWorkouts();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
