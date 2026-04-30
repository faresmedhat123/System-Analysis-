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
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
            LoadStatistics();
        }

        private void LoadStatistics()
        {
            Database db = new Database();

            using (SqlConnection con = db.GetConnection())
            {
                con.Open();

                // Members Count
                SqlCommand cmd1 = new SqlCommand("SELECT COUNT(*) FROM Member", con);
                int membersCount = (int)cmd1.ExecuteScalar();
                lblMembersCount.Text = membersCount.ToString();

                // Trainers Count
                SqlCommand cmd2 = new SqlCommand("SELECT COUNT(*) FROM Trainer", con);
                int trainersCount = (int)cmd2.ExecuteScalar();
                lblTrainersCount.Text = trainersCount.ToString();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadStatistics();
        }

        private void panelSystemStatistics_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
