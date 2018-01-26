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
    public partial class Profile : MetroFramework.Forms.MetroForm
    {
        
        //dummy data
        User user = new User("ethan", "1234567890123", "kilina", "0989788433", "SouthAfrika/Gouteng/pretoria/Erasmuskloof/kasuka/123", "ethankilian5@gmail.com", "1234", "Active", "Sybrin");

        List<PaymentAccount> UserEFTList = new List<PaymentAccount>();
        List<Card> UserCardList = new List<Card>();
     
        Card Card = new Card();
        PaymentAccount EFT = new PaymentAccount();


        public Profile()
        {
            InitializeComponent();
        }
        public Profile(User _user)
        {
            InitializeComponent();
            user = _user;
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            //dummy data
            UserCardList = CardController.RetrveCards(user.RsaID);
            UserEFTList = PaymentsAccountController.SearchBenPaymentAcount(user.RsaID);
          //fill datagrids
            FillUserEFTDatagrid(UserEFTList);
            FillUserCardDatagrid(UserCardList);
            popID();
        }
        //populate UPI feilds
        public void popID() {
            string address = user.Address;
            string[] a = address.Split('/');
            // split address into fields
          
            string Province = a[1];
            string Suburb = a[5];
            string Streer = a[4];
            string StrNum = a[3];
            string City = a[2];
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
            txtPassword.Text = user.Password;
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
                    table.Rows.Add(item.AccountNumber,item.AccountHolder, item.Reference, item.TypeAcc);
                }
                return table;
                //eryhfse54r
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
                    table.Rows.Add(item.CardNr,item.AccountHolder,item.Cvv,item.Expiry.ToString());
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
        public void ClearEFT() {

            txtEFTNum.Text = "";
            txtEFTReference.Text = "";
            txtEFTHolder.Text = "";
            cbPaymentType.SelectedItem = "";
        }
        //cler personal info boxes
        public void ClearPI() {
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
            String Address = txtStreetNumber.Text + "/" + txtStreet.Text + "/" + txtSuburb.Text + "/" + txtCity.Text + "/" + txtProvince.Text + "/" + txtCountry.Text;
            User user = new User(txtName.Text, txtID.Text, txtSurname.Text, txtCellNum.Text, Address, txtEmail.Text, txtPassword.Text, "Active", txtBusinessName.Text);
            return user;
           

        }
        //make new card
        public Card makecard() { Card newcard = new Card(txtCardNum.Text, txtCardHolder.Text, txtCVV.Text, DateTime.Now, "11111");
            return newcard;
        }

        // add new card account
        public bool SendUserCardAcc()
        {
            makecard();
            //send new user Card acount to daniel
            return true;
        }
        // update card
        public bool SendUserCardAccUp()
        {
            makecard();
            //send new user Card acount to daniel to update
            return true;
        }
        //make new eft  
        public PaymentAccount makeneweft() {
            AccountTypes Acounttype = new AccountTypes();
            switch (EFT.TypeAcc)
            {
                case AccountTypes.Savings:
                    Acounttype = AccountTypes.Savings;
                    break;
                case AccountTypes.Cheque:
                    Acounttype = AccountTypes.Cheque;
                    break;
                case AccountTypes.Credit:
                    Acounttype = AccountTypes.Credit;
                    break;
                default:
                    break;
            }
            PaymentAccount neweft = new PaymentAccount(txtEFTNum.Text, txtEFTHolder.Text, txtEFTReference.Text, Acounttype, "11111", "11111");
            return neweft;
        }
        // add new eft acount 

        public bool SendUserEFTAcc() {
            makeneweft();
            //send new user eft acount to daniel
            return true;

        }
        // updaet new eft acount 
        
        public bool SendUserEFTAccUp()
        {
            makeneweft();
            //send new user eft acount to daniel to update
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
            Benenficiarys beneficiarys = new Benenficiarys();
            this.Hide();
            beneficiarys.Show();
        }

        private void btnScheduel_Click(object sender, EventArgs e)
        {
            Schedules scheduels = new Schedules();
            this.Hide();
            scheduels.Show();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            History history = new History();
            this.Hide();
            history.Show();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            Payments payments = new Payments();
            this.Hide();
            payments.Show();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            this.Hide();
            profile.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Main main = new Main();
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
          // validate feilds  
            UserController.UpdateUser(CreateNewUer());
            ClearPI();


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

            //send thrue Card to ddelete to daniel
            UserCardList.Remove(Card);
            FillUserCardDatagrid(UserCardList);
            ClearCard();
            FillUserCardDatagrid(UserCardList);
        }

        private void metroButton7_Click(object sender, EventArgs e)
        {
            SendUserCardAccUp();
            //update the list
            ClearCard();
            FillUserCardDatagrid(UserCardList);
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {////edit the ep date
            int index = e.RowIndex;
            Card = UserCardList[index];
            txtCardHolder.Text = Card.AccountHolder;
            txtCVV.Text = Card.Cvv;
            txtCardNum.Text = Card.CardNr;
            dtpED.Value = DateTime.Now;

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
        {
            SendUserCardAcc();
            UserCardList.Add(Card);
            ClearCard();
            FillUserCardDatagrid(UserCardList);
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

        private void metroButton9_Click(object sender, EventArgs e)
        {
            //sent eft to delete

            UserEFTList.Remove(EFT);
            FillUserEFTDatagrid(UserEFTList);
            ClearEFT();
        }

        private void metroButton10_Click(object sender, EventArgs e)
        {
            SendUserEFTAccUp();
            ///the update of the list 
            FillUserEFTDatagrid(UserEFTList);
            ClearEFT();
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
        {
            SendUserEFTAcc();
            UserEFTList.Add(EFT);
            FillUserEFTDatagrid(UserEFTList);
            ClearEFT();
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
    }
}
