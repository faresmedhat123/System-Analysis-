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
    public partial class ManageTrainerForm : Form
    {
        int trainerId = 0;
        public ManageTrainerForm(int trainerId)
        {
            InitializeComponent();
            this.trainerId = trainerId;
            mainTitle.Text = trainerId == 0 ? "Add Trainer" : "Edit Trainer";
            LoadTrainerData();
        }

        private void LoadTrainerData()
        {
            Database db = new Database();

            using (SqlConnection con = db.GetConnection())
            {
                con.Open();

                string query = "SELECT * FROM Trainer WHERE ID=@ID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ID", trainerId);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    textboxName.Text = reader["Name"].ToString();
                    textboxPhone.Text = reader["Phone"].ToString();
                    textBoxSalary.Text = reader["Salary"].ToString();
                }
            }
        }

        private void ManageTrainerForm_Load(object sender, EventArgs e)
        {

        }

        private void mainTitle_Click(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
         
            if (textboxName.Text.Trim() == "" || textboxPhone.Text.Trim() == "")
            {
                MessageBox.Show("Enter required fields");
                return;
            }

            Database db = new Database();

            using (SqlConnection con = db.GetConnection())
            {
                con.Open();

                SqlCommand cmd;

                if (trainerId == 0)
                {
                    // ADD
                    string query = @"
            INSERT INTO Trainer (Name, Phone, Salary)
            VALUES (@Name, @Phone, @Salary)";

                    cmd = new SqlCommand(query, con);
                }
                else
                {
                    // EDIT
                    string query = @"
            UPDATE Trainer SET
            Name=@Name,
            Phone=@Phone,
            Salary=@Salary
            WHERE ID=@ID";

                    cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@ID", trainerId);
                }

                cmd.Parameters.AddWithValue("@Name", textboxName.Text);
                cmd.Parameters.AddWithValue("@Phone", textboxPhone.Text);
                cmd.Parameters.AddWithValue("@Salary", Convert.ToDecimal(textBoxSalary.Text));

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Saved successfully");
            this.Close();
        }
    }
}
