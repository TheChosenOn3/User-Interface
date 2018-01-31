using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controllers;
using Entities1;
using MetroFramework;

namespace Project500
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        //Global Variables
        int IncorrectLoginCount = 0;

        public Login()
        {
            InitializeComponent();
            txtUsername.Focus();
        }

        //Constructor used for Server Offline or Maintenance: True = Maintenance, False = Server Offline
        public Login(bool Status)
        {
            InitializeComponent();
            txtUsername.Focus();

            if (Status)
            {
                this.Style = MetroColorStyle.Yellow;
                MetroMessageBox.Show(this, "Server is Currently in Maintenance Mode! Please Come back Later!", "Server Maintenance");
                LockControls();
            }
            else
            {
                this.Style = MetroColorStyle.Red;
                MetroMessageBox.Show(this, "Server is Currently Offline! Please Come back Later!", "Server Offline");
                LockControls();
            }
        }

        public void LockControls()
        {
            txtUsername.Enabled = false;
            txtPassword.Enabled = false;

            btnLogin.Enabled = false;
            lblLinkToRegister.Enabled = false;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
            txtUsername.Select();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string password1 = "", passworrd;
            string username = txtUsername.Text.Trim();
            password1 = EncryptData.Encrypt(txtPassword.Text.Trim());

            passworrd = EncryptData.ConvertStringToHex(password1, System.Text.Encoding.Unicode);
            //passworrd = password1.Replace('*', '/');


            if (IncorrectLoginCount > 2)
            {
                MetroMessageBox.Show(this, "Your Account has been locked! Contact Administrator to Unlock your account and change you password!", "Account Lock!");
            }
            else
            {
                if (username == "" || passworrd == "")
                {
                    MetroMessageBox.Show(this, "Username and Password Cannot be Blank!", "Input Error");
                }
                else
                {
                    User user = UserController.CheckEmailExist(username, passworrd);
                    if (user.Email == null)
                    {
                        MetroMessageBox.Show(this, "Username or Password Does not exist!", "Incorrect Login!");
                    }
                    else if (user.RsaID == null && user.Email != null)
                    {
                        MetroMessageBox.Show(this, "Username or Password Does not exist!", "Incorrect Login!");
                        IncorrectLoginCount++;

                        if (IncorrectLoginCount > 2)
                        {
                            //Lock Account on DB
                        }
                    }
                    else if (user.RsaID != null && user.Email != null)
                    {
                        if (user.AccountStatus == "Locked")
                        {
                            MetroMessageBox.Show(this, "Your Account has been locked! Contact Administrator to Unlock your account and change you password!", "Account Lock!");
                        }
                        else
                        {
                            Main main = new Main(user);
                            this.Hide();
                            main.Show();
                        }
                        
                    }
                }
            }

            

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "";
            txtUsername.Text = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Home main = new Home();
            this.Hide();
            main.Show();
        }

        private void txtUsername_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_Click(object sender, EventArgs e)
        {

        }

        private void lblLinkToRegister_Click(object sender, EventArgs e)
        {
            Register RegisterForm = new Register();
            RegisterForm.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MetroMessageBox.Show(this,"Are you sure you wish to Exit this application?","Exit Project 500",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }
    }
}
