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
    public partial class ManageMemberForm : Form
    {
        int memberId = 0;
        public ManageMemberForm(int memberId)
        {
            InitializeComponent();
            this.memberId = memberId;
            mainTitle.Text = memberId == 0 ? "Add Member" : "Edit Member";
            LoadMemberData();
        }
        private void LoadMemberData()
        {
            Database db = new Database();

            using (SqlConnection con = db.GetConnection())
            {
                con.Open();

                string query = "SELECT * FROM Member WHERE ID=@ID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ID", memberId);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    textboxName.Text = reader["Name"].ToString();
                    dateTimePickerBirthdate.Value = Convert.ToDateTime(reader["BirthDate"]);
                    textboxPhone.Text = reader["Phone"].ToString();
                    comboboxGender.Text = reader["Gender"].ToString();
                    dateTimePickerJoindate.Value = Convert.ToDateTime(reader["JoinDate"]);
                }
            }
        }
        private void AddMemberForm_Load(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {

        }
        private void AddMember()
        {
            Database db = new Database();

            using (SqlConnection con = db.GetConnection())
            {
                con.Open();

                string query = @"INSERT INTO Member 
                        (Name, BirthDate, Phone, Gender, JoinDate)
                        VALUES (@Name, @BirthDate, @Phone, @Gender, @JoinDate)";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@Name", textboxName.Text);
                cmd.Parameters.AddWithValue("@BirthDate", dateTimePickerBirthdate.Value);
                cmd.Parameters.AddWithValue("@Phone", textboxPhone.Text);
                cmd.Parameters.AddWithValue("@Gender", comboboxGender.Text);
                cmd.Parameters.AddWithValue("@JoinDate", dateTimePickerJoindate.Value);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Member Added ✅");
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Database db = new Database();

            using (SqlConnection con = db.GetConnection())
            {
                con.Open();

                SqlCommand cmd;

                if (memberId == 0)
                {
                    // ADD
                    string query = @"INSERT INTO Member 
            (Name, BirthDate, Phone, Gender, JoinDate)
            VALUES (@Name, @BirthDate, @Phone, @Gender, @JoinDate)";

                    cmd = new SqlCommand(query, con);
                }
                else
                {
                    // EDIT
                    string query = @"UPDATE Member SET
            Name=@Name,
            BirthDate=@BirthDate,
            Phone=@Phone,
            Gender=@Gender,
            JoinDate=@JoinDate
            WHERE ID=@ID";

                    cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@ID", memberId);
                }

                cmd.Parameters.AddWithValue("@Name", textboxName.Text);
                cmd.Parameters.AddWithValue("@BirthDate", dateTimePickerBirthdate.Value);
                cmd.Parameters.AddWithValue("@Phone", textboxPhone.Text);
                cmd.Parameters.AddWithValue("@Gender", comboboxGender.Text);
                cmd.Parameters.AddWithValue("@JoinDate", dateTimePickerJoindate.Value);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Saved successfully");
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            
        }
    }
}
