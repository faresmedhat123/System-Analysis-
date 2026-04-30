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
    public partial class MembersForm : Form
    {
        int selectedMemberId;
        public MembersForm()
        {
            InitializeComponent();
        }

        private void createMembersTable()
        {
            Database db = new Database();

            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string query = @"
                IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Member' AND xtype='U')
                      CREATE TABLE Member (
                     ID INT PRIMARY KEY IDENTITY(1,1),
    Name VARCHAR(100) NOT NULL,
    BirthDate DATE,
    Phone VARCHAR(20),
    Gender VARCHAR(10),
    JoinDate DATE DEFAULT GETDATE()
);";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void createMemberSubscriptionTable()
        {
            Database db = new Database();

            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string query = @"
        IF NOT EXISTS (SELECT * FROM sysobjects 
                       WHERE name='Member_Subscription' AND xtype='U')
        CREATE TABLE Member_Subscription (
            ID INT PRIMARY KEY IDENTITY(1,1),
            Member_ID INT NOT NULL,
            Plan_Name VARCHAR(50),
            Start_Date DATE,
            End_Date DATE,

            CONSTRAINT FK_MemberSubscription_Member
            FOREIGN KEY (Member_ID) REFERENCES Member(ID)
        );";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void LoadMembers()
        {
            Database db = new Database();

            using (SqlConnection con = db.GetConnection())
            {
                con.Open();

                string query = "SELECT * FROM Member";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();

                da.Fill(dt);

                membersGridView.DataSource = dt;
            }
        }


        private void MembersForm_Load(object sender, EventArgs e)
        {
            createMembersTable();
            createMemberSubscriptionTable();
            LoadMembers();
        }

        private void panelMembers_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedMemberId = Convert.ToInt32(membersGridView.Rows[e.RowIndex].Cells["ID"].Value);
        }

        private void btnAdd_Member_Click(object sender, EventArgs e)
        {
            ManageMemberForm frm = new ManageMemberForm(0);
            frm.ShowDialog();
        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            selectedMemberId = Convert.ToInt32(membersGridView.Rows[e.RowIndex].Cells["ID"].Value);
        }

        private void panelMembers_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadMembers();
        }

        private void panelMembers_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void btnDelete_Member_Click(object sender, EventArgs e)
        {
            if (selectedMemberId == 0)
            {
                MessageBox.Show("Select member first");
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

                    string query = "DELETE FROM Member WHERE ID=@ID";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@ID", selectedMemberId);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Deleted successfully");

                LoadMembers();
            }
        }

        private void btnEdit_Member_Click(object sender, EventArgs e)
        {
            if (selectedMemberId == 0)
            {
                MessageBox.Show("Select member first");
                return;
            }

            ManageMemberForm frm = new ManageMemberForm(selectedMemberId);
            frm.ShowDialog();

            LoadMembers();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedMemberId = Convert.ToInt32(membersGridView.Rows[e.RowIndex].Cells["ID"].Value);
        }
    }
}
