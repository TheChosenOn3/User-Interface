using Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Boolean LoginSuccessful = true; //UserController.checkLogin(1);

            if (LoginSuccessful)
            {
                MessageBox.Show("Success");
                Main main = new Main();
                this.Hide();
                main.Show();
            }
            else
            {
                MessageBox.Show("Failed");
            }
            
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home main = new Home();
            this.Hide();
            main.Show();
        }
    }
}
