using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GymSystem
{
    public partial class SubscriptionsForm : Form
    {

        public SubscriptionsForm()
        {
            InitializeComponent();
            LoadMemberIDs();
        }


        private void LoadMemberIDs()
        {
            Database db = new Database();

            using (SqlConnection con = db.GetConnection())
            {
                con.Open();

                string query = "SELECT ID FROM Member";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                membercomboBox.DataSource = dt;
                membercomboBox.DisplayMember = "ID";
                membercomboBox.ValueMember = "ID";
                int selectedId = Convert.ToInt32(membercomboBox.SelectedValue);

            }
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnConfirm_Assignment_Click(object sender, EventArgs e)
        {
            int memberId = Convert.ToInt32(membercomboBox.SelectedValue);
            string plan = plancomboBox.SelectedItem.ToString();

            DateTime start = startdateTimePicker.Value;
            DateTime end = enddateTimePicker.Value;

            Database db = new Database();

            using (SqlConnection con = db.GetConnection())
            {
                con.Open();

                string query = @"
        INSERT INTO Member_Subscription
        (Member_ID, Plan_Name, Start_Date, End_Date)
        VALUES (@Member_ID, @Plan_Name, @Start_Date, @End_Date)";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@Member_ID", memberId);
                cmd.Parameters.AddWithValue("@Plan_Name", plan);
                cmd.Parameters.AddWithValue("@Start_Date", start);
                cmd.Parameters.AddWithValue("@End_Date", end);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Subscription added successfully");
        }
    }
}
