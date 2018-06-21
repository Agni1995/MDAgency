using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmLogin : Form
    {
        //defining custom colors:
        Color customOrange = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
        Color customBlue = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));

        //Variable to keep the state of viewPassword
        bool viewPasswordState;

        public frmLogin()
        {
            InitializeComponent();
        }
        //
        //Close button
        //
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //
        //Change the color of the strip bellow User Name Textbox
        //
        private void txtUserName_MouseEnter(object sender, EventArgs e)
        {
            lblUserName.BackColor = customOrange;
        }

        private void txtUserName_MouseLeave(object sender, EventArgs e)
        {
            lblUserName.BackColor = customBlue;
        }
        //
        //Change the color of the strip bellow Password Textbox
        //
        private void txtPassword_MouseEnter(object sender, EventArgs e)
        {
            lblPassword.BackColor = customOrange;
        }

        private void txtPassword_MouseLeave(object sender, EventArgs e)
        {
            lblPassword.BackColor = customBlue;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        //
        //Password Textbox behaviour
        //
        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Clear();
                txtPassword.ForeColor = SystemColors.ControlText;
                if (!viewPasswordState)
                    txtPassword.UseSystemPasswordChar = true;
                else
                    txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            lblPassword.Focus();
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Password";
                txtPassword.ForeColor = Color.Gray;
                txtPassword.UseSystemPasswordChar = false;
            }
        }
        //
        //User Name Textbox behaviour
        //
        private void txtUserName_Enter(object sender, EventArgs e)
        {
            if (txtUserName.Text == "User Name")
            {
                txtUserName.Clear();
                txtUserName.ForeColor = SystemColors.ControlText;
            }
        }

        private void txtUserName_Leave(object sender, EventArgs e)
        {
            lblUserName.Focus();
            if (txtUserName.Text == "")
            {
                txtUserName.Text = "User Name";
                txtUserName.ForeColor = Color.Gray;
            }
        }
        //
        //Form Click: focus changed from textboxes to login button
        //
        private void frmLogin_Click(object sender, EventArgs e)
        {
            btnLogin.Focus();
        }

        private void lblViewPassword_Click(object sender, EventArgs e)
        {
            viewPasswordState = !viewPasswordState;
            if(viewPasswordState == true)
            {
                lblViewPassword.Image = WindowsFormsApp1.Properties.Resources.if_lock__view__visibility__security_2541980;
                if(txtPassword.Text != "Password")
                    txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                if (txtPassword.Text != "Password")
                    txtPassword.UseSystemPasswordChar = true;
                lblViewPassword.Image = WindowsFormsApp1.Properties.Resources.if_eye__vision__view__watch_2538678;
            }
        }
    }
}
