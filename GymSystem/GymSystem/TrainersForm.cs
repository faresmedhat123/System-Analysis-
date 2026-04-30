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
    public partial class TrainersForm : Form
    {
        int selectedTrainerId;
        public TrainersForm()
        {
            InitializeComponent();
            createTrainersTable();
            LoadTrainers();
        }

        private void createTrainersTable()
        {
            Database db = new Database();

            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string query = @"
        IF NOT EXISTS (SELECT * FROM sysobjects 
                       WHERE name='Trainer' AND xtype='U')
        CREATE TABLE Trainer (
            ID INT PRIMARY KEY IDENTITY(1,1),
            Name VARCHAR(100) NOT NULL,
            Phone VARCHAR(20),
            Salary DECIMAL(10,2)
        );";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }


        private void LoadTrainers()
        {
            Database db = new Database();

            using (SqlConnection con = db.GetConnection())
            {
                con.Open();

                string query = "SELECT * FROM Trainer";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                trainersdataGridView.DataSource = dt;
            }
        }

        private void panelTrainers_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddTrainer_Click(object sender, EventArgs e)
        {
            ManageTrainerForm frm = new ManageTrainerForm(0);
            frm.ShowDialog();
            LoadTrainers();
        }

        private void btnEditTrainer_Click(object sender, EventArgs e)
        {
            if (selectedTrainerId == 0)
            {
                MessageBox.Show("Select trainer first");
                return;
            }

            ManageTrainerForm frm = new ManageTrainerForm(selectedTrainerId);
            frm.ShowDialog();

            LoadTrainers();
        }

        private void trainersdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedTrainerId = Convert.ToInt32(trainersdataGridView.Rows[e.RowIndex].Cells["ID"].Value);
        }

        private void btnDeleteTrainer_Click(object sender, EventArgs e)
        {
            if (selectedTrainerId == 0)
            {
                MessageBox.Show("Select trainer first");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure?",
                "Confirm Delete",
                MessageBoxButtons.YesNo
            );

            if (result == DialogResult.Yes)
            {
                Database db = new Database();

                using (SqlConnection con = db.GetConnection())
                {
                    con.Open();

                    string query = "DELETE FROM Trainer WHERE ID=@ID";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@ID", selectedTrainerId);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Deleted successfully");

                LoadTrainers();
            }
        }
    }
}
