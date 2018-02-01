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
using System.Net.Mail;

namespace Project500
{
    public partial class Profile : MetroFramework.Forms.MetroForm
    {
        //Empty Personal Details Variables for Data Capture when Updating
        string province = "";
        string suurb = "";
        string street = "";
        string streetnum = "";
        string name = "";
        string ID = "";
        string surname = "";
        string cell = "";
        string Email = "";
        string password = "";
        string buznessname = "";
        string convirmpassword = "";
        string country = "";
        string City = "";
        string Address = "";


        //dummy data
        User user = new User();
        User newuser = new User();
        List<PaymentAccount> UserEFTList = new List<PaymentAccount>();
        List<Card> UserCardList = new List<Card>();
        List<Crypto> BenCryptoList = new List<Crypto>();

        // wat de seop hier gebeer is nog onseker
        Crypto UserCrypto = new Crypto();
        Card Card = new Card();
        PaymentAccount EFT = new PaymentAccount();
        Crypto wallet = new Crypto();

        public Profile()
        {
            InitializeComponent();
            tabUserRegister.SelectTab(0);
        }
        public Profile(User _user)
        {
            InitializeComponent();
            user = _user;
            tabUserRegister.SelectTab(0);
            btnProfileImage.Text = " " + user.Name;
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            //populate mar dei random fields van btc
           
           
            if (CryptoController.GetUserCrypto(user.RsaID) != null)
            {
                UserCrypto = CryptoController.GetUserCrypto(user.RsaID);
            }
            else
            {
                UserCrypto = new Crypto("", "", 0, "", user.RsaID);
            }

            UserCardList = CardController.RetrveCards(user.RsaID);
            UserEFTList = PaymentsAccountController.SearchUserPaymentAcount(user.RsaID);
            //sf
            txtWalletName.Text = UserCrypto.WaletName;
            txtWalletCode.Text = UserCrypto.Waletaddress;
            txtWalletAmount.Text = UserCrypto.Amount.ToString();
            //fill datagrids
            FillUserEFTDatagrid(UserEFTList);
            FillUserCardDatagrid(UserCardList);
            popID();
        }
        //populate UPI feilds
        public void popID()
        {
            string address = user.Address;
            string[] a = address.Split('/');
            // split address into fields

            string Province = a[1];
            string Suburb = a[2];
            string Streer = a[4];
            string StrNum = a[5];
            string City = a[3];
            string Country = a[0];

            txtCountry.Text = Country;
            txtCity.Text = City;
            txtProvince.Text = Province;
            txtSuburb.Text = Suburb;
            txtStreet.Text = Streer;
            txtStreetNumber.Text = StrNum;
            txtName.Text = user.Name;
            txtID.Text = user.RsaID;
            txtSurname.Text = user.Surname;
            txtCellNum.Text = user.CellNr;
            txtEmail.Text = user.Email;

            //string password1 = EncryptData.ConvertHexToString(user.Password, System.Text.Encoding.Unicode);
            //string password2 = EncryptData.Decrypt(password1);

            //txtPassword.Text = password2;
            txtBusinessName.Text = user.BusinessName;

        }

        // method to populate user eft dgv

        public void FillUserEFTDatagrid(List<PaymentAccount> EFTDataGridList)
        {

            DataTable bentable = ConvertListToDataTable(EFTDataGridList);
            dgvEFT.DataSource = bentable;
            DataTable ConvertListToDataTable(List<PaymentAccount> EFTlist)
            {
                DataTable table = new DataTable();
                table.Columns.Add("Account Number");
                table.Columns.Add("Account Holder");
                table.Columns.Add("Reference");
                table.Columns.Add("Account Type");
                foreach (PaymentAccount item in EFTlist)
                {
                    table.Rows.Add(item.AccountNumber, item.AccountHolder, item.Reference, item.TypeAcc);
                }
                return table;

            }

        }
        // method to pop user card dgv

        public void FillUserCardDatagrid(List<Card> CardDataGridList)
        {

            DataTable bentable = ConvertListToDataTable(CardDataGridList);
            dgvCard.DataSource = bentable;
            DataTable ConvertListToDataTable(List<Card> Cardlist)
            {
                DataTable table = new DataTable();
                table.Columns.Add("Card Number");
                table.Columns.Add("Account Holder");
                table.Columns.Add("CVV");
                table.Columns.Add("Expirey Date");
                foreach (Card item in Cardlist)
                {
                    table.Rows.Add(item.CardNr, item.CardHolder, item.Cvv, item.Expiry.ToString());
                }
                return table;
            }

        }
        //clear Card boxes

        public void ClearCard()
        {

            txtCardHolder.Text = "";
            txtCVV.Text = "";
            txtCardNum.Text = "";
            dtpED.Value = DateTime.Now;
        }
        /// clear eft boxes
        /// 
        public void ClearEFT()
        {

            txtEFTNum.Text = "";
            txtEFTReference.Text = "";
            txtEFTHolder.Text = "";
            cbPaymentType.SelectedIndex = -1;
        }
        //cler personal info boxes
        public void ClearPI()
        {
            txtProvince.Text = "";
            txtSuburb.Text = "";
            txtStreet.Text = "";
            txtStreetNumber.Text = "";
            txtName.Text = "";
            txtID.Text = "";
            txtSurname.Text = "";
            txtCellNum.Text = "";
            txtEmail.Text = "";
            txtPassword.Text = "";
            txtBusinessName.Text = "";
        }
        //make new user
        public User CreateNewUer()
        {
            String Address = txtCountry.Text + "/" + txtProvince.Text + "/" + txtCity.Text + "/" + txtSuburb.Text + "/" + txtStreet.Text + "/" + txtStreetNumber.Text;
            newuser = new User(txtName.Text, user.RsaID, txtSurname.Text, txtCellNum.Text, Address, txtEmail.Text, password, "Active", txtBusinessName.Text);
            return newuser;


        }
        //make new card
        public Card makecard()
        {
            string someDate = dtpED.Value.ToString("dd/MM/yyyy");
            DateTime NewDate = DateTime.ParseExact(someDate, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            Card newcard = new Card(txtCardNum.Text,txtCardHolder.Text, txtCVV.Text, NewDate,user.RsaID);/////////////////ikujyhtgvrfoikujyht8kiju7yht
            return newcard;
        }

        // add new card account
        public bool SendUserCardAcc()
        {
            CardController.AddCard(makecard());
            return true;
        }
        // update card
        public bool SendUserCardAccUp()
        {
            CardController.UpdateCard(makecard());
            return true;
        }
        //make new eft  
        public PaymentAccount makeneweft()
        {
            AccountTypes Acounttype = new AccountTypes();
            switch (cbPaymentType.SelectedIndex)
            {
                case 0:
                    Acounttype = AccountTypes.Savings;
                    break;
                case 1:
                    Acounttype = AccountTypes.Cheque;
                    break;
                case 2:
                    Acounttype = AccountTypes.Credit;
                    break;
                default:
                    break;
            }
            PaymentAccount neweft = new PaymentAccount(txtEFTNum.Text, txtEFTHolder.Text, txtEFTReference.Text, Acounttype, "", user.RsaID);
            return neweft;
        }
        // add new eft acount 
        public bool SendUserEFTAcc()
        {
            PaymentsAccountController.AddUserPaymentAcount(makeneweft());
            return true;
        }
        // updaet new eft acount 
        public bool SendUserEFTAccUp()
        {
            PaymentsAccountController.UpdateUserPaymentAcount(makeneweft());
            return true;
        }
        private void navpan_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPersonalDetail_Click(object sender, EventArgs e)
        {

        }

        private void btnBeneficiary_Click(object sender, EventArgs e)
        {
            Benenficiarys beneficiarys = new Benenficiarys(user);
            this.Hide();
            beneficiarys.Show();
        }

        private void btnScheduel_Click(object sender, EventArgs e)
        {
            Schedules scheduels = new Schedules(user);
            this.Hide();
            scheduels.Show();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            History history = new History(user);
            this.Hide();
            history.Show();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            Payments payments = new Payments(user);
            this.Hide();
            payments.Show();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile(user);
            this.Hide();
            profile.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Main main = new Main(user);
            this.Hide();
            main.Show();
        }

        private void lblHeading_Click(object sender, EventArgs e)
        {

        }

        private void lblUser_Click(object sender, EventArgs e)
        {

        }

        private void metroPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblP500_Click(object sender, EventArgs e)
        {

        }

        private void tabCRegister_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //Field Capture
            //User Details
            name = txtName.Text.Trim();
            ID = txtID.Text.Trim();
            surname = txtSurname.Text.Trim();
            cell = txtCellNum.Text.Trim();
            buznessname = txtBusinessName.Text.Trim();

            //Address Details
            province = txtProvince.Text.Trim();
            suurb = txtSuburb.Text.Trim();
            street = txtStreet.Text.Trim();
            streetnum = txtStreetNumber.Text.Trim();
            country = txtCountry.Text.Trim();
            City = txtCity.Text.Trim();

            //Account Details
            Email = txtEmail.Text.Trim();
            //password = txtPassword.Text.Trim();
            //convirmpassword = txtConfirmPassword.Text.Trim();

            string password1 = EncryptData.Encrypt(txtPassword.Text.Trim());

            password = EncryptData.ConvertStringToHex(password1, System.Text.Encoding.Unicode);

            string Confirm = EncryptData.Encrypt(txtConfirmPassword.Text.Trim());

            convirmpassword = EncryptData.ConvertStringToHex(Confirm, System.Text.Encoding.Unicode);

            //Field Validation
            List<string> ErrorLog = new List<string>();

            //Here comes a lot of Validation
            //User Details
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
                txtBusinessName.Style = MetroColorStyle.Red;
                txtBusinessName.UseStyleColors = true;
            }

            //Beginning of Address Validation
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


            //Beginning of Account Validation
            //Email Validation
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

            //List All Errors, if none, continue.
            if (ErrorLog.Count > 0)
            {
                string ErrorMessage = "The following issues have to be resolved:\n\n";

                foreach (string item in ErrorLog)
                {
                    ErrorMessage += item.ToString() + "\n";
                }

                MetroMessageBox.Show(this, ErrorMessage, "Input Errors");

                //This is to refresh the tab, to display all the incorrect fields in Red
                tabUserRegister.SelectTab(1);
                tabUserRegister.SelectTab(0);
            }
            else if (UserController.UpdateUser(CreateNewUer()))
            {
                MessageBox.Show("sccount succsessfully updaated");
                user = CreateNewUer();
                ClearPI();
            }


        }

        private void metroTextBox11_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel11_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox10_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel10_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox9_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel9_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox8_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel8_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox7_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel7_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox6_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel6_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox5_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox4_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox3_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearPI();
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void tabCryptoDetail_Click(object sender, EventArgs e)
        {

        }

        private void metroButton8_Click(object sender, EventArgs e)
        {

        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
           string  Waletname = txtWalletName.Text.Trim();




            Crypto newcryp = new Crypto(txtWalletName.Text,txtWalletCode.Text,float.Parse( txtWalletAmount.Text), "",user.RsaID);
            CryptoController.UpateUserCrypto(newcryp);


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void metroTextBox14_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel19_Click(object sender, EventArgs e)
        {

        }

        private void metroComboBox4_SelectedIndexChanged(object sender, EventArgs e)
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
            txtWalletName.Text = "";
            txtWalletCode.Text = "";
            txtWalletAmount.Text = "";
        }

        private void metroTextBox16_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel21_Click(object sender, EventArgs e)
        {

        }

        private void tabCardDetail_Click(object sender, EventArgs e)
        {

        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            CardController.DeleteCard(Card.CardNr);
            UserCardList.Remove(Card);
            ClearCard();
            FillUserCardDatagrid(UserCardList);

        }

        private void metroButton7_Click(object sender, EventArgs e)
        {

            bool go = false;
            Card eftup = new Card();
            foreach (Card item in UserCardList)
            {
                if (txtCardNum.Text == item.CardNr)
                {
                    UserCardList.Remove(item);
                    UserCardList.Add(new Card(txtCardNum.Text.Trim(), txtCardHolder.Text.Trim(), txtCVV.Text.Trim(), DateTime.Now, user.RsaID));
                    SendUserCardAccUp();
                    ClearCard();
                    FillUserCardDatagrid(UserCardList);
                    go = true;
                    break;
                }
            }
            if (go != true)
            {
                MessageBox.Show("Sorry the Account deos not exsist that you are trying to update");
            }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {////edit the ep date
            

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void metroLabel17_Click(object sender, EventArgs e)
        {

        }

        private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroTextBox15_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel16_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel15_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox13_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel14_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel13_Click(object sender, EventArgs e)
        {

        }

        private void btnCSubmit_Click(object sender, EventArgs e)
        {    //check for aclidation
            bool go = false;
            foreach (Card item in UserCardList)
            {
                if (txtCardNum.Text.Trim() == item.CardNr)
                {
                    go = true;
                    break;
                }
            }
            if (go == false)
            {
                SendUserCardAcc();
                UserCardList.Add(makecard());
                ClearCard();
                FillUserCardDatagrid(UserCardList);
            }
            else
            {
                MessageBox.Show("Sorry the Account alreddy exists");
            }
        }

        private void BtnCClear_Click(object sender, EventArgs e)
        {
            ClearCard();
        }

        private void metroTextBox12_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel12_Click(object sender, EventArgs e)
        {

        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void metroButton9_Click(object sender, EventArgs e)
        {
            PaymentsAccountController.DeleteUserPaymentAcount(EFT.AccountNumber);
            UserEFTList.Remove(EFT);
            FillUserEFTDatagrid(UserEFTList);
            ClearEFT();
        }

        private void metroButton10_Click(object sender, EventArgs e)
        {
            // check the vields for validation checks
            bool go = false;
            PaymentAccount eftup = new PaymentAccount();
            foreach (PaymentAccount item in UserEFTList)
            {
                if (txtEFTNum.Text == item.AccountNumber)
                {
                    UserEFTList.Remove(item);
                    AccountTypes Acounttype = new AccountTypes();
                    switch (cbPaymentType.SelectedIndex)
                    {
                        case 0:
                            Acounttype = AccountTypes.Savings;
                            break;
                        case 1:
                            Acounttype = AccountTypes.Cheque;
                            break;
                        case 2:
                            Acounttype = AccountTypes.Credit;
                            break;
                        default:
                            break;
                    }
                    UserEFTList.Add(new PaymentAccount(txtEFTNum.Text.Trim(), txtEFTHolder.Text.Trim(), txtEFTReference.Text.Trim(), Acounttype, "", user.RsaID));
                    //rtgfdsgrgdf4terfds34erwfsd34erwfd
                    SendUserEFTAccUp();
                    FillUserEFTDatagrid(UserEFTList);
                    ClearEFT();
                    go = true;
                    break;
                }
            }
            if (go != true)
            {
                MessageBox.Show("Sorry the Account deos not exsist that you are trying to update");

            }

        }

        private void tabEFTDetail_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox18_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel18_Click(object sender, EventArgs e)
        {

        }

        private void metroComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroLabel22_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {// check if card alreddy existes
            bool go = false;
            foreach (PaymentAccount item in UserEFTList)
            {
                if (txtEFTNum.Text.Trim() == item.AccountNumber)
                {
                    go = true;
                    break;
                }
            }
            if (go == false)
            {
                SendUserEFTAcc();
                UserEFTList.Add(makeneweft());
                FillUserEFTDatagrid(UserEFTList);
                ClearEFT();
            }
            else
            {
                MessageBox.Show("Sorry the Accountalreddy exists");
            }

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {


            ClearEFT();
        }

        private void metroTextBox17_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel23_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you wish to exit this application?", "Exit Project 500", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Login LoginForm = new Login();
                LoginForm.Show();
                this.Hide();
            }
        }

        private void dgvCard_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            Card = UserCardList[index];
            txtCardHolder.Text = Card.CardHolder;
            txtCVV.Text = Card.Cvv;
            txtCardNum.Text = Card.CardNr;
            dtpED.Value = DateTime.Now;
        }

        private void dgvEFT_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            EFT = UserEFTList[index];
            txtEFTNum.Text = EFT.AccountNumber;
            txtEFTReference.Text = EFT.Reference;
            txtEFTHolder.Text = EFT.AccountHolder;
            switch (EFT.TypeAcc)
            {
                case AccountTypes.Savings:
                    cbPaymentType.SelectedIndex = 0;
                    break;
                case AccountTypes.Cheque:
                    cbPaymentType.SelectedIndex = 1;
                    break;
                case AccountTypes.Credit:
                    cbPaymentType.SelectedIndex = 2;
                    break;
                default:
                    break;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddWallet_Click(object sender, EventArgs e)
        {
            string Waletname = txtWalletName.Text.Trim();

            Crypto newcryp = new Crypto(txtWalletName.Text, txtWalletCode.Text, float.Parse(txtWalletAmount.Text), "", user.RsaID);
            CryptoController.AddCrypto(newcryp);
        }
    }
}
