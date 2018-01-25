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

           // btnLogin.Enabled = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string username = txtUsername.Text.Trim();
            string passworrd = txtPassword.Text.Trim();
            User _user = UserController.CheckLogin(username, passworrd);
            if (_user.RsaID!=null)
            {
                Main main = new Main();
                this.Hide();
                main.Show();

            }
            else { MessageBox.Show("Credentials are wrong"); }

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home main = new Home();
            this.Hide();
            main.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "";
            txtUsername.Text = "";
        }
    }
}
