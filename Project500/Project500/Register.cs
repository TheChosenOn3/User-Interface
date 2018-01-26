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
using Controllers;

namespace Project500
{
    public partial class Register : MetroFramework.Forms.MetroForm
    {
        string province = "";
        string suurb  = "";
        string street  = "";
        string streetnum  = "";
        string name =  "";
        string ID  = "";
        string surname = "";
        string cell = "";
        string Email  = "";
        string password  = "";
        string buznessname  = "";
        string convirmpassword = "";
        string country = "";
        string City = "";
        string Address = "";

        // get list to check if user exist 
        List<User> userlist = UserController.GetUser();


        public Register()
        {
            InitializeComponent();

        }

        private void Register_Load(object sender, EventArgs e)
        {
        
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
            bool cool = true;
            Email = txtEmail.Text.Trim();
            password = txtPassword.Text.Trim();
            convirmpassword = txtConfirmPassword.Text.Trim();
            if (Email == "" || password == "" || convirmpassword == "")
            {
                MessageBox.Show("Please fill all the fields");
                cool = false;
            }
            else if (password != convirmpassword)
            {
                MessageBox.Show("Passwords do not match");
                cool = false;
            } 
            else
            {
                foreach (User item in userlist)
                {
                    if (item.Password == password)
                    {
                        MessageBox.Show("password alreddy taken");
                        cool = false;
                    }
                    else if ( item.Email == Email)
                    {
                        MessageBox.Show("Username alreddy taken");
                        cool = false;
                    }
                }
            }
            if (cool)
            {
                User user = new User(name, ID, surname, cell, Address, Email, password, "Active", buznessname);

                if (UserController.registerUser(user))
                {// dummy user so fields stay shap in rest of forms
                    User _user = new User("ethan", "1234", "kilina", "0989788433", "SouthAfrika/Gouteng/pretoria/Erasmuskloof/kasuka/123", "ethankilian5@gmail.com", "1234", "Active", "Sybrin");
                    // take underscore away
                    Main main = new Main(_user);
                    this.Hide();
                    main.Show();
                }

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void txtBusiness_Click(object sender, EventArgs e)
        {

        }

        private void txtCellNum_Click(object sender, EventArgs e)
        {

        }

        private void txtStreetNumber_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel7_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel8_Click(object sender, EventArgs e)
        {

        }

        private void txtStreet_Click(object sender, EventArgs e)
        {

        }

        private void mtpAddress_Click(object sender, EventArgs e)
        {

        }

        private void txtProvince_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {

        }

        private void btnNextAddress_Click(object sender, EventArgs e)
        {
            name = txtName.Text.Trim();
            ID = txtID.Text.Trim();
            surname = txtSurname.Text.Trim();
            cell = txtCellNum.Text.Trim();
            buznessname = txtBusiness.Text.Trim();

            if (name == "" || ID == "" || surname == "" || cell == "" || buznessname == "") {
                MessageBox.Show("Please Fill in all of the Fields");
            } else if (ID.Length != 13)
            {
                MessageBox.Show("ID must be 13 caracters long");
            } 
            else
            {
                tabCRegister.SelectTab(1);
            }

          
        }

        private void btnBackPersonal_Click(object sender, EventArgs e)
        {
            tabCRegister.SelectTab(0);
        }

        private void btnNextLogin_Click(object sender, EventArgs e)
        {
            province = txtProvince.Text.Trim();
            suurb = txtSuburb.Text.Trim();
            street = txtStreet.Text.Trim();
            streetnum = txtStreetNumber.Text.Trim();
            country = txtCountry.Text.Trim();
            City = txtCity.Text.Trim();
            
            if (province == "" || suurb == "" || street == "" || streetnum == ""|| City == ""|| country== "")
            {
                MessageBox.Show("Please Fill in all of the Fields");
            }
            else {
                 Address = country + "/" + province + "/" + City + "/" + suurb + "/" + street + "/" + streetnum;
                tabCRegister.SelectTab(2);
            }
           
           
        }

        private void btnBackAddress_Click(object sender, EventArgs e)
        {
            tabCRegister.SelectTab(1);
        }
    }
}
