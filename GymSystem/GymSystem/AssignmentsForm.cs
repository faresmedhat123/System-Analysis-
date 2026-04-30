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

namespace GymSystem
{
    public partial class AssignmentsForm : Form
    {
        public AssignmentsForm()
        {
            InitializeComponent();
            CreateMemberTrainerTable();
            LoadMembers();
            LoadTrainers();
        }


        private void LoadMembers()
        {
            Database db = new Database();

            using (SqlConnection con = db.GetConnection())
            {
                con.Open();

                SqlDataAdapter da = new SqlDataAdapter("SELECT ID, Name FROM Member", con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                comboMember.DataSource = dt;
                comboMember.DisplayMember = "Name";
                comboMember.ValueMember = "ID";
            }
        }
        private void LoadTrainers()
        {
            Database db = new Database();

            using (SqlConnection con = db.GetConnection())
            {
                con.Open();

                SqlDataAdapter da = new SqlDataAdapter("SELECT ID, Name FROM Trainer", con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                comboTrainer.DataSource = dt;
                comboTrainer.DisplayMember = "Name";
                comboTrainer.ValueMember = "ID";
            }
        }

        private void CreateMemberTrainerTable()
        {
            Database db = new Database();

            using (SqlConnection con = db.GetConnection())
            {
                con.Open();

                string query = @"
        IF NOT EXISTS (
            SELECT * FROM sysobjects 
            WHERE name='Member_Trainer' AND xtype='U'
        )
        CREATE TABLE Member_Trainer (
            ID INT PRIMARY KEY IDENTITY,
            MemberID INT,
            TrainerID INT,
            AssignedDate DATE DEFAULT GETDATE(),

            FOREIGN KEY (MemberID) REFERENCES Member(ID),
            FOREIGN KEY (TrainerID) REFERENCES Trainer(ID)
        )";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
            }
        }
        private void panelAssignment_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            int memberId = Convert.ToInt32(comboMember.SelectedValue);
            int trainerId = Convert.ToInt32(comboTrainer.SelectedValue);

            Database db = new Database();

            using (SqlConnection con = db.GetConnection())
            {
                con.Open();

                string query = @"INSERT INTO Member_Trainer (MemberID, TrainerID)
                         VALUES (@MemberID, @TrainerID)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@MemberID", memberId);
                cmd.Parameters.AddWithValue("@TrainerID", trainerId);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Assigned successfully ✅");
            }
        }
    }
}
