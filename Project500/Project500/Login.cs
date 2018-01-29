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
        public Login()
        {
            InitializeComponent();
            
        }

        private void Login_Load(object sender, EventArgs e)
        {

         
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string passworrd = txtPassword.Text.Trim();
            
            if (username == "" || passworrd == "")
            {
                MetroMessageBox.Show(this, "Username and Password Cannot be Blank!", "Input Error");
            }
            else
            {
                User user = UserController.CheckLogin(username, passworrd);
                if (user.RsaID != null)
                {
                    //dummy user to use for now
                    Main main = new Main(user);
                    this.Hide();
                    main.Show();

                }
                else
                {
                    MetroMessageBox.Show(this, "Username or Password is Incorrect", "Login Failed!");
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
    }
}
