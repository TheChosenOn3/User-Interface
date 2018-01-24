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
    public partial class Register : MetroFramework.Forms.MetroForm
    {
       

        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {
         //   btnRegister.Enabled = false;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home main = new Home();
            this.Hide();
            main.Show();
        }

        private void tabCryptoDetail_Click(object sender, EventArgs e)
        {

        }

        private void tabCardDetail_Click(object sender, EventArgs e)
        {

        }

        private void tabPersonalDetail_Click(object sender, EventArgs e)
        {

        }

        private void tabEFTDetail_Click(object sender, EventArgs e)
        {

        }

        private void metroButton8_Click(object sender, EventArgs e)
        {

        }

        private void metroButton5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroLabel19_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel20_Click(object sender, EventArgs e)
        {

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {

        }

        private void metroButton4_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel21_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            
            String Address = txtCountry.Text+" "+ txtSuburb.Text+ " " +txtStreet.Text+ " " +txtStreetNumber.Text ;
            User user = new User(txtName.Text,txtID.Text,txtSurname.Text,txtCellNum.Text,Address,txtEmail.Text,txtPassword.Text,"Active",txtBusiness.Text);
        
            Main main = new Main();
            this.Hide();
            main.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCountry.Text = "";
            txtSuburb.Text = "";
            txtStreet.Text = "";
            txtStreetNumber.Text = "";
            txtName.Text = "";
            txtID.Text = "";
            txtSurname.Text = "";
            txtCellNum.Text = "";
            txtEmail.Text = "";
            txtPassword.Text = "";
            txtBusiness.Text = "";

        }
    }
}
