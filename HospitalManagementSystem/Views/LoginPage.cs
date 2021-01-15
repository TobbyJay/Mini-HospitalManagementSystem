using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class LoginPage : Form
    {
        DashBoard dashBoard = new DashBoard();
        public LoginPage()
        {
            InitializeComponent();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPassword.Checked == true && txtPassword.UseSystemPasswordChar == true)
            {
                checkPassword.Text = "Hide Password";
                txtPassword.UseSystemPasswordChar = true;
            }
            else
            {
                checkPassword.Text = "Show Password";
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserId.Text == "admin" && txtPassword.Text == "admin")
            {
               
                dashBoard.Show();
                this.Hide();
            }
            else
            {
                lblError.Visible = true;
                lblError.Text = "Please check credentials and try again";
            }

            
        }


        private void Close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close this app?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            lblError.Visible = false;

        }
    }
}
