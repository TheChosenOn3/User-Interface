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
using MetroFramework;
using System.Text.RegularExpressions;
using System.ComponentModel.DataAnnotations;
using System.Net.Mail;

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
            tabCRegister.SelectTab(0);
        }

        private void Register_Load(object sender, EventArgs e)
        {
        
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Login LoginForm = new Login();
            LoginForm.Show();
            this.Hide();
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

            List<string> ErrorLog = new List<string>();

            try
            {
                var addr = new MailAddress(Email);
            }
            catch
            {
                ErrorLog.Add("Email is not valid!");
                txtEmail.Style = MetroColorStyle.Red;
                txtEmail.UseStyleColors = true;
            }

            if (password == "" || convirmpassword == "")
            {
                ErrorLog.Add("Password or Confirm Password Cannot be Blank!");
                txtPassword.Style = MetroColorStyle.Red;
                txtPassword.UseStyleColors = true;
                txtConfirmPassword.Style = MetroColorStyle.Red;
                txtConfirmPassword.UseStyleColors = true;
            }
            else if (password != convirmpassword)
            {
                ErrorLog.Add("Passwords do not match!");
                txtPassword.Style = MetroColorStyle.Red;
                txtPassword.UseStyleColors = true;
                txtConfirmPassword.Style = MetroColorStyle.Red;
                txtConfirmPassword.UseStyleColors = true;
            }

            if (ErrorLog.Count > 0)
            {
                cool = false;

                string ErrorMessage = "The following issues have to be resolved:\n\n";

                foreach (string item in ErrorLog)
                {
                    ErrorMessage += item.ToString() + "\n";
                }

                MetroMessageBox.Show(this, ErrorMessage, "Input Errors");

                //This is to refresh the tab, to display all the incorrect fields in Red
                tabCRegister.SelectTab(1);
                tabCRegister.SelectTab(2);
            }
            else
            {
                foreach (User item in userlist)
                {
                    if ( item.Email == Email)
                    {
                        MetroMessageBox.Show(this,"Your Provided Email is Already in Use!", "Email Already in Use");
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

            //Start of Input Validation - Jason
            List<String> ErrorLog = new List<string>();

            //Name Validation
            if (name == "")
            {
                ErrorLog.Add("Name Field is Blank");
                txtName.Style = MetroColorStyle.Red;
                txtName.UseStyleColors = true;
            }
            else if (name.All(char.IsDigit))
            {
                ErrorLog.Add("Name Field Cannot Contain Digits");
                txtName.Style = MetroColorStyle.Red;
                txtName.UseStyleColors = true;
            }
            else if (!Regex.IsMatch(name.ToString(), "^[A-Za-z ]+$"))
            {
                ErrorLog.Add("Name Field cannot contain special characters!");
                txtName.Style = MetroColorStyle.Red;
                txtName.UseStyleColors = true;
            }

            //Surname Validation
            if (surname == "")
            {
                ErrorLog.Add("Surname Field is Blank!");
                txtSurname.Style = MetroColorStyle.Red;
                txtSurname.UseStyleColors = true;
            }
            else if (surname.All(char.IsDigit))
            {
                ErrorLog.Add("Surname Field cannot contain digits!");
                txtSurname.Style = MetroColorStyle.Red;
                txtSurname.UseStyleColors = true;
            }
            else if (!Regex.IsMatch(surname, "^[A-Za-z ]+$"))
            {
                ErrorLog.Add("Surname Field cannot contain special characters!");
                txtSurname.Style = MetroColorStyle.Red;
                txtSurname.UseStyleColors = true;
            }

            //ID Validation
            if (ID == "")
            {
                ErrorLog.Add("ID Field is Blank");
                txtID.Style = MetroColorStyle.Red;
                txtID.UseStyleColors = true;
            }
            else if (ID.Length != 13)
            {
                ErrorLog.Add("ID Field must be 13 characters long.");
                txtID.Style = MetroColorStyle.Red;
                txtID.UseStyleColors = true;
            }
            else if (!float.TryParse(ID, out float IDNum))
            {
                ErrorLog.Add("ID field can only contain numbers!");
                txtID.Style = MetroColorStyle.Red;
                txtID.UseStyleColors = true;
            }

            //Cell Number Validation
            if (cell == "")
            {
                ErrorLog.Add("Cell Number Field is Blank");
                txtCellNum.Style = MetroColorStyle.Red;
                txtCellNum.UseStyleColors = true;
            }
            else if (!float.TryParse(cell, out float CellNum))
            {
                ErrorLog.Add("Cell Number field can only contain numbers!");
                txtCellNum.Style = MetroColorStyle.Red;
                txtCellNum.UseStyleColors = true;
            }

            //Business Name Validation
            if (buznessname == "")
            {
                ErrorLog.Add("Business Name Field is Blank");
                txtBusiness.Style = MetroColorStyle.Red;
                txtBusiness.UseStyleColors = true;
            }
            
            
            
            //Sum up all errors in messagebox, if none, continue to next.
            if (ErrorLog.Count > 0)
            {
                string ErrorMessage = "The following issues have to be resolved:\n\n";

                foreach (string item in ErrorLog)
                {
                    ErrorMessage += item.ToString() + "\n";
                }

                MetroMessageBox.Show(this, ErrorMessage, "Input Errors");

                //This is to refresh the tab, to display all the incorrect fields in Red
                tabCRegister.SelectTab(1);
                tabCRegister.SelectTab(0);
            }
            else
            {
                tabCRegister.SelectTab(1);
                this.AcceptButton = btnNextLogin;
                txtStreetNumber.Focus();
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

            //Beginning of Validation Checks for Form 2
            List<string> ErrorLog = new List<string>();

            //Street Number
            if (streetnum == "")
            {
                ErrorLog.Add("Street Number Cannot be Blank!");
                txtStreetNumber.Style = MetroColorStyle.Red;
                txtStreetNumber.UseStyleColors = true;
            }
            else if (streetnum.All(char.IsLetter))
            {
                ErrorLog.Add("Street Number Can only contain digits!");
                txtStreetNumber.Style = MetroColorStyle.Red;
                txtStreetNumber.UseStyleColors = true;
            }
            else if (!Regex.IsMatch(streetnum, "^[0-9]+$"))
            {
                ErrorLog.Add("Street Number Cannot contain special characters!");
                txtStreetNumber.Style = MetroColorStyle.Red;
                txtStreetNumber.UseStyleColors = true;
            }

            //Street Name
            if (street == "")
            {
                ErrorLog.Add("Street Name Cannot be Blank!");
                txtStreet.Style = MetroColorStyle.Red;
                txtStreet.UseStyleColors = true;
            }
            else if (street.All(char.IsDigit))
            {
                ErrorLog.Add("Street Name cannot contain digits!");
                txtStreet.Style = MetroColorStyle.Red;
                txtStreet.UseStyleColors = true;
            }
            else if (!Regex.IsMatch(street, "^[A-Za-z ]+$"))
            {
                ErrorLog.Add("Street Name cannot contain special characters!");
                txtStreet.Style = MetroColorStyle.Red;
                txtStreet.UseStyleColors = true;
            }

            //Suburb
            if (suurb == "")
            {
                ErrorLog.Add("Suburb Cannot be Blank!");
                txtSuburb.Style = MetroColorStyle.Red;
                txtSuburb.UseStyleColors = true;
            }
            else if (suurb.All(char.IsDigit))
            {
                ErrorLog.Add("Suburb cannot contain digits!");
                txtSuburb.Style = MetroColorStyle.Red;
                txtSuburb.UseStyleColors = true;
            }
            else if (!Regex.IsMatch(suurb, "^[A-Za-z ]+$"))
            {
                ErrorLog.Add("Suburb cannot contain special characters!");
                txtSuburb.Style = MetroColorStyle.Red;
                txtSuburb.UseStyleColors = true;
            }

            //City
            if (City == "")
            {
                ErrorLog.Add("City Cannot be Blank!");
                txtCity.Style = MetroColorStyle.Red;
                txtStreet.UseStyleColors = true;
            }
            else if (City.All(char.IsDigit))
            {
                ErrorLog.Add("City cannot contain digits!");
                txtCity.Style = MetroColorStyle.Red;
                txtCity.UseStyleColors = true;
            }
            else if (!Regex.IsMatch(City, "^[A-Za-z ]+$"))
            {
                ErrorLog.Add("City cannot contain special characters!");
                txtCity.Style = MetroColorStyle.Red;
                txtCity.UseStyleColors = true;
            }

            //Province
            if (province == "")
            {
                ErrorLog.Add("Province Cannot be Blank!");
                txtProvince.Style = MetroColorStyle.Red;
                txtProvince.UseStyleColors = true;
            }
            else if (province.All(char.IsDigit))
            {
                ErrorLog.Add("Province Cannot contain digits!");
                txtProvince.Style = MetroColorStyle.Red;
                txtProvince.UseStyleColors = true;
            }
            else if (!Regex.IsMatch(province, "^[A-Za-z ]+$"))
            {
                ErrorLog.Add("Province Cannot contain special characters!");
                txtProvince.Style = MetroColorStyle.Red;
                txtProvince.UseStyleColors = true;
            }

            //Country
            if (country == "")
            {
                ErrorLog.Add("Country Cannot be Blank!");
                txtCountry.Style = MetroColorStyle.Red;
                txtCountry.UseStyleColors = true;
            }
            else if (country.All(char.IsDigit))
            {
                ErrorLog.Add("Country Cannot contain digits!");
                txtCountry.Style = MetroColorStyle.Red;
                txtCountry.UseStyleColors = true;
            }
            else if (!Regex.IsMatch(country, "^[A-Za-z ]+$"))
            {
                ErrorLog.Add("Country Cannot contain special characters!");
                txtCountry.Style = MetroColorStyle.Red;
                txtCountry.UseStyleColors = true;
            }


            //Display all Validation Fails, else, continue to next
            if (ErrorLog.Count > 0)
            {
                string ErrorMessage = "The following issues have to be resolved:\n\n";

                foreach (string item in ErrorLog)
                {
                    ErrorMessage += item.ToString() + "\n";
                }

                MetroMessageBox.Show(this, ErrorMessage, "Input Errors");

                //This is to refresh the tab, to display all the incorrect fields in Red
                tabCRegister.SelectTab(2);
                tabCRegister.SelectTab(1);
            }
            else
            {
                Address = country + "/" + province + "/" + City + "/" + suurb + "/" + street + "/" + streetnum;
                tabCRegister.SelectTab(2);
                this.AcceptButton = metroButton2;
                txtEmail.Focus();
            }
           
           
        }

        private void btnBackAddress_Click(object sender, EventArgs e)
        {
            tabCRegister.SelectTab(1);
        }

        private void tabCRegister_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void mtpAccount_Click(object sender, EventArgs e)
        {

        }
    }
}
