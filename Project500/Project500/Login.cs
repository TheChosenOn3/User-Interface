using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            this.Hide();
            main.Show();
            
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home main = new Home();
            this.Hide();
            main.Show();
        }
    }
}
