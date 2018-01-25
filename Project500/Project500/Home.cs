using Controllers;
using Entities1;
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
    public partial class Home : MetroFramework.Forms.MetroForm
    {

       
        public Home()
        {
            InitializeComponent();
            //this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            User user = new User {Name="Danie" };
            UserController.registerUser(user);
            //Register register = new Register();
            //register.Show();
            //this.Hide();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
                login.Show();
            this.Hide();
        }
    }
}
