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
using MetroFramework.Forms;
using MetroFramework;

namespace Project500
{

    public partial class Schedules : MetroFramework.Forms.MetroForm
    {
        List<Payment> PaymentList = new List<Payment>();
        List<Payment> PaymentListS = new List<Payment>();
        List<Payment> PaymentListF = new List<Payment>();
        List<Beneficiary> BeneficairyList = new List<Beneficiary>();
        List<PaymentAccount> BenPaymentAccountList = new List<PaymentAccount>();
        List<PaymentAccount> BenPaymentListS = new List<PaymentAccount>();
        List<Beneficiary> BeneficiaryListS = new List<Beneficiary>();
        List<PaymentAccount> UserPaymentAccountList = new List<PaymentAccount>();
        List<Card> UserCardList = new List<Card>();
        List<Crypto> BeneficairyCrypoList = new List<Crypto>();

        Payment payment = new Payment();
        Beneficiary beneficiary = new Beneficiary();
        User user = new User();
        PaymentType paymentType = new PaymentType();
        string status = "";
        Crypto userCrypto = new Crypto();
        List<String> UobjectListe = new List<String>();
        List<String> BenbjectListe = new List<String>();

        public void FillPaymentsDatagrid(List<Payment> PaymentDataGridList)
        {

            DataTable paytable = ConvertListToDataTable(PaymentDataGridList);
            dgvScheduels.DataSource = paytable;
            DataTable ConvertListToDataTable(List<Payment> list)
            {
                DataTable table = new DataTable();
                table.Columns.Add("Payment Number");
                table.Columns.Add("Your Account");
                table.Columns.Add("Beneficairy Name");
                table.Columns.Add("Beneficairy Account");
                table.Columns.Add("Description");
                table.Columns.Add("paydate");
                table.Columns.Add("Amont");
                table.Columns.Add("Interval");
                table.Columns.Add("Status");
                table.Columns.Add("type");

                foreach (Payment item in list)
                {
                    string bennnaem = "";
                    foreach (Beneficiary benitem in BeneficairyList)
                    {
                        if (item.BeneficairyID == benitem.BeneficairyID)
                        {
                            bennnaem = benitem.BeneficairyName.ToString() ;
                            break;
                        }
                    }
                    table.Rows.Add(item.ScheduleNr, item.PaymentNumber, bennnaem,item.BeneficiaryAccount, item.Description, item.PayDate.ToString(), item.Amount, item.Interval, item.Status, item.TypePayment);

                }
                return table;
            }
        }
        public void FillBeneficiaryDatagrid(List<Beneficiary> BenDataGridList)
        {

            DataTable bentable = ConvertListToDataTable(BenDataGridList);
            dgvBeneficiary.DataSource = bentable;
            DataTable ConvertListToDataTable(List<Beneficiary> benlist)
            {
                DataTable table = new DataTable();
                table.Columns.Add("Beneficairy Nme");
                table.Columns.Add("Beneficiary Branch");
                foreach (Beneficiary item in benlist)
                {
                    table.Rows.Add(item.BeneficairyName, item.BeneficiaryBranch);
                }
                return table;
            }

        }
        public List<string> PopSelectedBenAcount(List<PaymentAccount> beneftlist, List<Crypto> bencryptolist)
        {

            foreach (Crypto item in bencryptolist)
            {
                BenbjectListe.Add("Crypto:" + item.Waletaddress);

            }
            foreach (PaymentAccount item in beneftlist)
            {
                BenbjectListe.Add("EFT:" + item.AccountNumber);
            }
            return BenbjectListe;

        }


        public Schedules()
        {
            InitializeComponent();
        }
        public Schedules(User _user)
        {
            InitializeComponent();
            user = _user;
            btnProfileImage.Text = " " + user.Name;
        }
        private void Schedules_Load(object sender, EventArgs e)
        {

            BeneficairyList = BeneficiaryController.GetBeneficiarys(user.RsaID);
            PaymentListF = PaymentsController.GetPayments(user.RsaID);
            foreach (Payment   item in PaymentListF)
            {
                //DateTime payDate = DateTime.ParseExact(item.PayDate, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);

                //if (payDate > DateTime.Now || item.Recurring == true)
                //{
                    PaymentList.Add(item);
                //}
              
            }
            if (CryptoController.GetUserCrypto(user.RsaID) != null)
            {
                userCrypto = CryptoController.GetUserCrypto(user.RsaID);
            }
            else
            {
                userCrypto = new Crypto("", "", 0, "", user.RsaID);
            }


            UserPaymentAccountList = PaymentsAccountController.SearchUserPaymentAcount(user.RsaID);
            UserCardList = CardController.RetrveCards(user.RsaID);
            FillPaymentsDatagrid(PaymentList);
            BeneficairyList = BeneficiaryController.GetBeneficiarys(user.RsaID);
            FillBeneficiaryDatagrid(BeneficairyList);
            popUcb();
        }
        public void popUcb()
        {

            // fill object list
            string mycryp = userCrypto.Waletaddress;
            UobjectListe.Add("Crypto:" + mycryp);
            foreach (PaymentAccount item in UserPaymentAccountList)
            {
                UobjectListe.Add("EFT:" + item.AccountNumber);
            }
            foreach (Card item in UserCardList)
            {
                UobjectListe.Add("Card:" + item.CardNr);
            }
            foreach (string item in UobjectListe)
            {
                cbuserpaymentmethod.Items.Add(item);

            }



        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            Main main = new Main(user);
            this.Hide();
            main.Show();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile(user);
            this.Hide();
            profile.Show();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            Payments payments = new Payments(user);
            this.Hide();
            payments.Show();
            //ref
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            History history = new History(user);
            this.Hide();
            history.Show();
        }

        private void btnScheduel_Click(object sender, EventArgs e)
        {
            Schedules scheduels = new Schedules(user);
            this.Hide();
            scheduels.Show();
        }

        private void btnBeneficiary_Click(object sender, EventArgs e)
        {
            Benenficiarys beneficiarys = new Benenficiarys(user);
            this.Hide();
            beneficiarys.Show();
        }

        private void btnUpdatePayment_Click(object sender, EventArgs e)
        {
           
            PaymentType typepay = new PaymentType();
            bool recur = false;

            if (checkInter.Checked)
            {
                recur = true;
                lblInterval.Visible = true;
                txtInterval.Visible = true;

            }
            if (recur == true && txtInterval.Text == "")
            {
                MetroMessageBox.Show(this, "Recurring Payment Selected, but Interval for Recurring Payment is blank, Please Enter a Interval with the following format: Days/Months\n\nExample: 01/01 - This repeats every 1 day and 1 month that has passed", "Interval Input Error");
            }
            else if (recur == true && txtInterval.Text.Length != 5)
            {
                MetroMessageBox.Show(this, "Your Interval for a Recurring Payment is incorrect, please you the following format: Days/Months\n\nExample: 01/01 - This repeats every 1 day and 1 month that has passed", "Interval Input Error");
            }
            else if (txtAmount.Text == "" || cbBAcounType.SelectedIndex == -1 || cbuserpaymentmethod.SelectedIndex == -1 || txtDescription.Text == "" || txtBname.Text == "")
            {
                MetroMessageBox.Show(this, "Fill in all fields to Add a Payment to Execute", "Blank Fields Input Error");
            }
            else if (checkInter.Checked == true && txtInterval.Text == "")
            {
                MetroMessageBox.Show(this, "Please Select Proper Interval for a Recurring Payment, with format: Days/Months\n\nExample: 01/01 - This repeats every 1 day and 1 month that has passed", "Interval Input Error");
            }
            else if (cbBAcounType.SelectedIndex != -1 && cbuserpaymentmethod.SelectedIndex != -1)
            {

                string benected = cbBAcounType.SelectedItem.ToString();
                string userlected = cbuserpaymentmethod.SelectedItem.ToString();
                string usertype = userlected.Substring(0, 3);
                string bentype = benected.Substring(0, 3);
                if ((usertype == "Car" && bentype == "EFT") || (usertype == "EFT" && bentype == "EFT") || (usertype == "Cry" && bentype == "Cry"))
                {

                    string UAccNum = "";
                    string BenAccNum = "";
                    int range1 = benected.IndexOf(":");
                    string selectPayAcc = benected.Substring(range1 + 1, benected.Length - range1 - 1);
                    string selectUser = userlected.Substring(userlected.IndexOf(":") + 1, userlected.Length - userlected.IndexOf(":") - 1);

                    if (usertype == "Cry")
                    {
                        UAccNum = userCrypto.Waletaddress;

                        typepay = PaymentType.Crypto;
                        foreach (Crypto item in BeneficairyCrypoList)
                        {
                            if (item.Waletaddress == selectPayAcc)
                            {
                                BenAccNum = item.Waletaddress;
                            }

                        }
                    }
                    else if (usertype == "Car")
                    {
                        typepay = PaymentType.Card;
                        foreach (Card item in UserCardList)
                        {
                            if (item.CardNr == selectUser)
                            {
                                UAccNum = item.CardNr;
                            }

                        }
                        foreach (PaymentAccount item in BenPaymentAccountList)
                        {
                            if (item.AccountNumber == selectPayAcc)
                            {
                                BenAccNum = item.AccountNumber;
                            }

                        }
                    }
                    else
                    {
                        typepay = PaymentType.EFT;
                        foreach (PaymentAccount item in UserPaymentAccountList)
                        {
                            if (item.AccountNumber == selectUser)
                            {
                                UAccNum = item.AccountNumber;
                            }

                        }
                        foreach (PaymentAccount item in BenPaymentAccountList)
                        {
                            if (item.AccountNumber == selectPayAcc)
                            {
                                BenAccNum = item.AccountNumber;
                            }

                        }
                    }
                  



        string Paydate1 = dtpPaymentdate.Value.ToString("dd/MM/yyyy");
                 
                    Payment newPayment = new Payment(payment.ScheduleNr, txtDescription.Text.Trim(), beneficiary.BeneficairyID, Paydate1, float.Parse(txtAmount.Text.Trim()), txtInterval.Text.Trim(), "Pending", UAccNum, typepay, recur, DateTime.Now.ToString(), user.RsaID, BenAccNum);
                    PaymentsController.UpdatePyaments(newPayment);
                    foreach (Payment item in PaymentList)
                    {
                        if (item.PaymentNumber == payment.PaymentNumber)
                        {
                            PaymentList.Remove(item);

                            break;
                        }
                    }
                    PaymentList.Add(newPayment);
                    FillPaymentsDatagrid(PaymentList);

                }
                else
                {
                    MetroMessageBox.Show(this, "payment types must match", "Interval Input Error");
                }


            }

            // add ne payment to datagrid payments

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

        private void dgvScheduels_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            payment = PaymentList[index];
            txtAmount.Text = payment.Amount.ToString();
            txtDescription.Text = payment.Description;
            txtInterval.Text = payment.Interval;
          //  DateTime payDate = DateTime.ParseExact(processedPayment.PayDate, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);//Convert Date format to correct 
            dtpPaymentdate.Value = DateTime.ParseExact(payment.PayDate, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture); //Paste Groot value as die uit fok.
            FillBeneficiaryDatagrid(BeneficairyList);
            FillBeneficiaryDatagrid(BeneficairyList);
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            PaymentList = PaymentsController.GetPayments(user.RsaID);
            BeneficairyList = BeneficiaryController.GetBeneficiarys(user.RsaID);
            List<string> BeneficiarySearchIDs = new List<string>();
            bool UsePaymentList = false;

            List<Payment> SearchList = new List<Payment>();

            //Filter for Beneficiary Name
            if (!txtFBName.Text.Equals(""))
            {
                //Get All ID's of Beneficiaries that fall under search Criteria
                foreach (Beneficiary item in BeneficairyList)
                {
                    if (item.BeneficairyName.IndexOf(txtFBName.Text.Trim(), StringComparison.CurrentCultureIgnoreCase) != -1)
                    {
                        BeneficiarySearchIDs.Add(item.BeneficairyID);
                    }
                }

                //Filter All Payments, based on BeneficiaryID
                foreach (Payment item in PaymentList)
                {
                    if (BeneficiarySearchIDs.Contains(item.BeneficairyID))
                    {
                        SearchList.Add(item);
                    }
                }

                //Changes the Criteria list, depending on this Filter Criteria, only showing payments that meet this criteria, for the next criteria methods.
                PaymentList = SearchList;
                SearchList = new List<Payment>();
                UsePaymentList = true;
            }

            //Filter by Payment Method
            if (!cbFPaymentMethod.Text.Equals(""))
            {
                foreach (Payment item in PaymentList)
                {
                    if (item.TypePayment.ToString() == cbFPaymentMethod.Text.ToString())
                    {
                        SearchList.Add(item);
                    }
                }

                PaymentList = SearchList;
                SearchList = new List<Payment>();
                UsePaymentList = true;
            }

            //Filter by Date
            if (cxbDate.Checked)
            {
                string StartDateString = dtpFStart.Value.ToString("dd/MM/yyyy");
                DateTime StartDate = DateTime.ParseExact(StartDateString, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);

                string EndDateString = dtpFEnd.Value.ToString("dd/MM/yyyy");
                DateTime EndDate = DateTime.ParseExact(EndDateString, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);

                foreach (Payment item in PaymentList)
                {
                    DateTime PaymentDate = DateTime.ParseExact(item.PayDate, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);

                    if (PaymentDate > StartDate && PaymentDate < EndDate)
                    {
                        SearchList.Add(item);
                    }
                }

                PaymentList = SearchList;
                SearchList = new List<Payment>();
                UsePaymentList = true;
            }

            

            //Now Populate depending on which list, true means using PaymentList global variable, false means using the searchlist
            if (UsePaymentList)
            {
                FillPaymentsDatagrid(PaymentList);
            }
            else
            {
                FillPaymentsDatagrid(SearchList);
            }


        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            txtFBName.Text = "";
            cbFPaymentMethod.SelectedIndex = -1;
            dtpFEnd.Value = DateTime.Now;
            dtpFStart.Value = DateTime.Now;
            FillPaymentsDatagrid(PaymentList);

          
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //kyk of die id wat deer stuur ioj, us
           
            if (PaymentsController.DeletePyaments(payment.ScheduleNr))
            {
                PaymentList.Remove(payment);
                FillPaymentsDatagrid(PaymentList);
            }
            txtAmount.Text = "";

            txtDescription.Text = "";
            txtInterval.Text = "";
            cbuserpaymentmethod.SelectedIndex = -1;
            dtpPaymentdate.Value = DateTime.Now;
            checkInter.Checked = false;

        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            foreach (Payment item in PaymentList)
            {//kyk of num reg sis
                if (PaymentsController.DeletePyaments(payment.ScheduleNr))
                {
                    PaymentList.Remove(item);
                    
                }


            }
            txtAmount.Text = "";

            txtDescription.Text = "";
            txtInterval.Text = "";
            cbuserpaymentmethod.SelectedIndex = -1;
            dtpPaymentdate.Value = DateTime.Now;
            checkInter.Checked = false;
            FillPaymentsDatagrid(PaymentList);

        }

        private void dgvBeneficiary_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnSearchBeneficiary_Click(object sender, EventArgs e)
        {
            
            BeneficiaryListS.Clear();
            foreach (Beneficiary item in BeneficairyList)
            {
                if (item.BeneficairyName.IndexOf(txtBname.Text.Trim(), StringComparison.CurrentCultureIgnoreCase) != -1)
                {
                    BeneficiaryListS.Add(item);
                }
            }

            FillBeneficiaryDatagrid(BeneficiaryListS);

        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            FillBeneficiaryDatagrid(BeneficairyList);
            txtBname.Text = "";
            cbBAcounType.SelectedIndex = -1;
        }

        private void btnClearCurentPayment_Click(object sender, EventArgs e)
        {

            txtAmount.Text = "";

            txtDescription.Text = "";
            txtInterval.Text = "";
            cbuserpaymentmethod.SelectedIndex = -1;
            dtpPaymentdate.Value = DateTime.Now;
            checkInter.Checked = false;
        }

        private void dgvScheduels_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            payment = PaymentList[index];
            txtAmount.Text = payment.Amount.ToString();
            txtDescription.Text = payment.Description;
            txtInterval.Text = payment.Interval;
            FillBeneficiaryDatagrid(BeneficairyList);
            
            dtpPaymentdate.Value = DateTime.ParseExact(payment.PayDate, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
        
        
        }

        private void dgvBeneficiary_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            if (BeneficiaryListS.Count == 0)
            {

                beneficiary = BeneficairyList[index];
            }
            else
            {
                beneficiary = BeneficiaryListS[index];
                BeneficiaryListS.Clear();
            }
            txtBname.Text = beneficiary.BeneficairyName;
            BenPaymentAccountList = PaymentsAccountController.SearchBenPaymentAcount(beneficiary.BeneficairyID);
            BeneficairyCrypoList = CryptoController.GetCrypto(beneficiary.BeneficairyID);

            BenbjectListe = PopSelectedBenAcount(BenPaymentAccountList, BeneficairyCrypoList);
            List<string> remove = new List<string>();
            cbBAcounType.Items.Clear();
            foreach (string item in BenbjectListe)
            {
                cbBAcounType.Items.Add(item);

            }

            BenbjectListe.Clear();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabFilterScheduel_Click(object sender, EventArgs e)
        {

        }

        private void cxbDate_CheckedChanged(object sender, EventArgs e)
        {
            if (cxbDate.Checked)
            {
                metroLabel1.Visible = true;
                metroLabel4.Visible = true;

                dtpFStart.Visible = true;
                dtpFEnd.Visible = true;
            }
            else
            {
                metroLabel1.Visible = false;
                metroLabel4.Visible = false;

                dtpFStart.Visible = false;
                dtpFEnd.Visible = false;
            }
        }
    }
}
