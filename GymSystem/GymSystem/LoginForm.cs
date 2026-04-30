using GymSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagement
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = textboxEmail.Text.Trim();
            string password = textboxPassword.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter your data");
                return;
            }

            if (email == "admin" && password == "123")
            {
                MessageBox.Show("Login success");

                MainForm main = new MainForm();
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid email or password");
            }
        }

        private void labelexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
