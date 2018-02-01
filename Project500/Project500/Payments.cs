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
using System.Text.RegularExpressions;
using System.IO;
using MetroFramework;

namespace Project500
{
    public partial class Payments : MetroFramework.Forms.MetroForm
    {

        List<Payment> PaymentList = new List<Payment>();
        List<Beneficiary> BeneficairyList = new List<Beneficiary>();
        List<PaymentAccount> BenPaymentAccountList = new List<PaymentAccount>();
        List<PaymentAccount> BenPaymentListS = new List<PaymentAccount>();
        List<Beneficiary> BeneficiaryListS = new List<Beneficiary>();
        List<PaymentAccount> UserPaymentAccountList = new List<PaymentAccount>();
        List<Card> UserCardList = new List<Card>();
        List<Crypto> BeneficairyCrypoList = new List<Crypto>();

        List<Crypto> BeneficairyCrypoListS = new List<Crypto>();
        Payment payment = new Payment();
        Beneficiary beneficiary = new Beneficiary();
        PaymentAccount UserPaymentAccount = new PaymentAccount();
        PaymentAccount BeneficiaryPaymentAccount = new PaymentAccount();
        Card userCard = new Card();
        Crypto benficairyCrypto = new Crypto();
        Crypto userCrypto = new Crypto();
        string BenName = "";
        string Discription = "";
        float Amount1 = 0;
        string interval = "";
        DateTime paymentdate = DateTime.Now;
        Random rnd = new Random();
        Random rnd1 = new Random();
        Random rnd2 = new Random();


        


        //hier kom die SEOP nou   fill combo box met die # lists
        List<String> UobjectListe = new List<String>();
        List<String> BenbjectListe = new List<String>();
        List<Payment> ALLPAY = new List<Payment>();
        List<Payment> history = new List<Payment>();
        List<Payment> scheduals = new List<Payment>();


        
        User user = new User();
        public Payments(User _user)
        {
            InitializeComponent();
            user = _user;
            btnProfileImage.Text = " " + user.Name;

        }
        public Payments()
        {
            InitializeComponent();
        }

        private void Payments_Load(object sender, EventArgs e)
        {
            
            if (CryptoController.GetUserCrypto(user.RsaID) == null)
            {
                userCrypto  = new Crypto("","",0,"",user.RsaID);
            }
            else
            {
                userCrypto = CryptoController.GetUserCrypto(user.RsaID);
            }
            history= HistoryController.getHistory(user.RsaID);
            scheduals = PaymentsController.GetPayments(user.RsaID);

            foreach (Payment item in history)
            {
                ALLPAY.Add(item);
            }
            foreach (Payment item in scheduals)
            {
                ALLPAY.Add(item);
            }

            BeneficairyList = BeneficiaryController.GetBeneficiarys(user.RsaID);
            UserPaymentAccountList = PaymentsAccountController.SearchUserPaymentAcount(user.RsaID);
            UserCardList = CardController.RetrveCards(user.RsaID);
            FillBeneficiaryDatagrid(BeneficairyList);

            popUcb();

        }

        public void popUcb()
        {

            // fill object list
            string mycryp = userCrypto.Waletaddress;
            UobjectListe.Add("Crypto:"+mycryp);
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
                cbxPaymentType.Items.Add(item);

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




        // method to populate datagrid beneficharys
        public void FillBeneficiaryDatagrid(List<Beneficiary> BenDataGridList)
        {

            DataTable bentable = ConvertListToDataTable(BenDataGridList);
            dgvBeneficiarys.DataSource = bentable;
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
        public void FillPaymentDatagrid(List<Payment> paylist)
        {

            DataTable paytable = ConvertListToDataTable(paylist);
            dgvAddedPayments.DataSource = paytable;
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

                string bennnaem = "";
                foreach (Payment item in list)
                {
                    foreach (Beneficiary benitem in BeneficairyList)
                    {
                        if (item.BeneficairyID == benitem.BeneficairyID)
                        {
                            bennnaem = benitem.BeneficairyName;
                        }
                    }

                    table.Rows.Add(item.ScheduleNr,item.PaymentNumber, bennnaem,item.BeneficiaryAccount, item.Description, item.PayDate.ToString(), item.Amount, item.Interval, item.Status, item.TypePayment);

                }
                return table;
            }

        }
        //fill payment


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

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

        private void btnDeletePayment_Click(object sender, EventArgs e)
        {

            PaymentList.Remove(payment);
            FillPaymentDatagrid(PaymentList);

        }

        private void btnRetryPayment_Click(object sender, EventArgs e)
        {//rt
            if (PaymentsController.UpdatePyaments(payment))
            {
                foreach (Payment item in PaymentList)
                {
                    if (payment.PaymentNumber == item.PaymentNumber)
                    {
                        item.Status = "Pending";
                        MetroMessageBox.Show(this, "Payment Scheduled Successfully!", "Success");
                    }
                    else
                    {
                        item.Status = "Failed";
                    }
                }

            }
            else
            {
                MetroMessageBox.Show(this, "Unable to retrieve data from server, Server is offline!", "Connection Issues");
            }
            FillPaymentDatagrid(PaymentList);

        }

        private void btnExacutePayment_Click(object sender, EventArgs e)
        {

            if (PaymentsController.AddPyaments(payment))
            {
                foreach (Payment item in PaymentList)
                {
                    if (payment.PaymentNumber == item.PaymentNumber)
                    {
                        item.Status = "Pending";
                    }
                    else
                    {
                        item.Status = "Failed";
                    }
                }
            }


            FillPaymentDatagrid(PaymentList);

            ClearFields();
        }

        private void btnDeleteAllPayment_Click(object sender, EventArgs e)
        {
            PaymentList.Clear();
            FillPaymentDatagrid(PaymentList);

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            ClearFields();
        }
        public void ClearFields()
        {

            txtAmount.Text = "";
            txtDescription.Text = "";
            txtInterval.Text = "";
            cbBAccType.SelectedIndex = -1;
            dtpPayDate.Value = DateTime.Now;
            checkInter.Checked = false;
            lblInterval.Visible = false;
            txtInterval.Visible = false;

        }

        private void btnRetryAllPayment_Click(object sender, EventArgs e)
        {
            bool issusck = false;
            List<Payment> newpaylist = PaymentList;
            foreach (Payment item in newpaylist)
            {
                if (PaymentsController.UpdatePyaments(item))
                {
                    foreach (Payment item1 in PaymentList)
                    {
                        if (item.PaymentNumber == item1.PaymentNumber)
                        {
                            issusck = true;
                            item1.Status = "Pending";
                        }
                        else
                        {
                            item1.Status = "Failed";
                        }
                    }

                }

            }
            if (issusck == false)
            {
                MetroMessageBox.Show(this, "Unable to retrieve data from server, Server is offline!", "Connection Issues");
            }
            else
            {
                MetroMessageBox.Show(this, "Payment Scheduled Successfully!", "Success");
            }

            FillPaymentDatagrid(PaymentList);

            ClearFields();
        }

        private void btnExacuteAllPayment_Click(object sender, EventArgs e)
        {
            bool issusck = false;
            List<Payment> newpaylist = PaymentList;
            foreach (Payment item in newpaylist)
            {
                if (PaymentsController.AddPyaments(item))
                {
                    foreach (Payment item1 in PaymentList)
                    {
                        if (item.PaymentNumber == item1.PaymentNumber)
                        {
                            item1.Status = "Pending";
                        }
                        else
                        {
                            item1.Status = "Failed";
                        }
                    }

                }

            }
            if (issusck == false)
            {
                MetroMessageBox.Show(this, "Unable to retrieve data from server, Server is offline!", "Connection Issues");
            }
            else
            {
                MetroMessageBox.Show(this, "Payment Scheduled Successfully!", "Success");
            }

            FillPaymentDatagrid(PaymentList);
        }

        private void dgvAddedPayments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            payment = PaymentList[index];
        }

        private void dgvBeneficiarys_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // get selected ben from datagrid
            // update combobox to mach selected benac0ount
        }

        private void btnSearchB_Click(object sender, EventArgs e)
        {
            // send thru name  in txtBName.Text
            //get bens acounts
            // populate datagrid benacount



        }

        private void btnAddPayment_Click(object sender, EventArgs e)
        {
            payment = new Payment();
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
            else if (txtAmount.Text == "" || cbBAccType.SelectedIndex == -1 || cbxPaymentType.SelectedIndex == -1 || txtDescription.Text == "" || txtBName.Text == "")
            {
                MetroMessageBox.Show(this, "Fill in all fields to Add a Payment to Execute", "Blank Fields Input Error");
            }
            else if (checkInter.Checked == true && txtInterval.Text == "")
            {
                MetroMessageBox.Show(this, "Please Select Proper Interval for a Recurring Payment, with format: Days/Months\n\nExample: 01/01 - This repeats every 1 day and 1 month that has passed", "Interval Input Error");
            }
            else if (cbBAccType.SelectedIndex != -1 && cbxPaymentType.SelectedIndex != -1)
            {

                string benected = cbBAccType.SelectedItem.ToString();
                string userlected = cbxPaymentType.SelectedItem.ToString();
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
                    int PaymentNum1 = rnd.Next(4, 1024);
                    int PaymentNum2 = rnd.Next(10, 1042);
                    int SchedueldNum = rnd.Next(11, 1022);
                    string Schedpaynum = PaymentNum1.ToString() + PaymentNum2.ToString() + SchedueldNum.ToString();

                    foreach (Payment item1 in ALLPAY)
                    {
                        foreach (Payment item in PaymentList)
                        {
                            if (Schedpaynum == item.PaymentNumber)
                            {
                                Schedpaynum += "9";
                            }

                        }
                    }

                    
                    string Paydate1 = dtpPayDate.Value.ToString("dd/MM/yyyy");

                    PaymentList.Add(new Payment(Schedpaynum, txtDescription.Text.Trim(), beneficiary.BeneficairyID, Paydate1, float.Parse(txtAmount.Text.Trim()), txtInterval.Text.Trim(), "Pending", UAccNum, typepay, recur, DateTime.Now.ToString(), user.RsaID, BenAccNum));
                    //add payment
                    FillPaymentDatagrid(PaymentList);
                    ClearFields();

                }

                else
                {
                    MetroMessageBox.Show(this, "Your Payment type and Beneficiary Payment Type Does Not Match!", "Payment Type Input Error");
                }


            }

            // add ne payment to datagrid payments

        }



        private void chxInterval_Click(object sender, EventArgs e)
        {

        }

        private void chxInterval_CheckedChanged(object sender, EventArgs e)
        {
            if (checkInter.Checked)
            {
                lblInterval.Visible = true;
                txtInterval.Visible = true;
            }
            else
            {
                lblInterval.Visible = false;
                txtInterval.Visible = false;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MetroMessageBox.Show(this, "Are you sure you wish to exit this application?", "Exit Project 500", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Login LoginForm = new Login();
                LoginForm.Show();
                this.Hide();
            }
        }

        private void btnSearchB_Click_1(object sender, EventArgs e)
        {
            BeneficairyList = BeneficiaryController.GetBeneficiarys(user.RsaID);

            List<Beneficiary> SearchList = new List<Beneficiary>();

            foreach (Beneficiary item in BeneficairyList)
            {
                if (item.BeneficairyName.IndexOf(txtBName.Text.Trim(), StringComparison.CurrentCultureIgnoreCase) != -1)
                {
                    SearchList.Add(item);
                }
            }

            BeneficairyList = SearchList;

            FillBeneficiaryDatagrid(SearchList);


        }

        private void dgvBeneficiarys_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            cbBAccType.SelectedIndex = -1;
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            BeneficairyList = BeneficiaryController.GetBeneficiarys(user.RsaID);
            FillBeneficiaryDatagrid(BeneficairyList);
        }
        public void ClearBens()
        {
            txtBName.Text = "";
            cbBAccType.SelectedIndex = -1;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvAddedPayments_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void dgvBeneficiarys_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            cbBAccType.SelectedIndex = -1;
            int index = e.RowIndex;

          
                beneficiary = BeneficairyList[index];
         
            txtBName.Text = beneficiary.BeneficairyName;



            BenPaymentAccountList = PaymentsAccountController.SearchBenPaymentAcount(beneficiary.BeneficairyID);
            BeneficairyCrypoList = CryptoController.GetCrypto(beneficiary.BeneficairyID);
            BenbjectListe = PopSelectedBenAcount(BenPaymentAccountList, BeneficairyCrypoList);
            List<string> remove = new List<string>();
            cbBAccType.Items.Clear();
            foreach (string item in BenbjectListe)
            {
                cbBAccType.Items.Add(item);

            }

            BenbjectListe.Clear();
        }

        private void checkInter_CheckedChanged(object sender, EventArgs e)
        {
            if (checkInter.Checked)
            {
                lblInterval.Visible = true;
                txtInterval.Visible = true;
            }
            else
            {
                lblInterval.Visible = false;
                txtInterval.Visible = false;
            }
        }

        private void btnBatch_Click(object sender, EventArgs e)
        {
            List<Payment> batchlist = new List<Payment>();
            StreamReader reader = new StreamReader("ReadTest.csv");


            
            List<Payment> paylist = new List<Payment>();


            while (!reader.EndOfStream)

            {
                Payment payment = new Payment();
                var line = reader.ReadLine();
                string[] values = null;
                values = line.Split(',');

                payment.ScheduleNr = values[0];
                payment.Description = values[1];
                payment.BeneficairyID = values[2];
                payment.PayDate = Convert.ToDateTime(values[3]).ToString();
                payment.Amount = float.Parse(values[4]);
                payment.Interval = values[5];
                payment.Status = values[6];
                payment.PaymentNumber = values[7];
                payment.TypePayment = PaymentType.Card;
                payment.Recurring = Convert.ToBoolean(values[9]);
                payment.DateCreated = Convert.ToDateTime(values[10]).ToString();
                payment.UserID = values[11];
                payment.BeneficiaryAccount = values[12];


                foreach (Payment item1 in ALLPAY)
                {
                    foreach (Payment item in PaymentList)
                    {
                        if (payment.ScheduleNr == item.PaymentNumber)
                        {
                            payment.ScheduleNr += "9";
                        }

                    }
                }
                paylist.Add(payment);

              
            }
            foreach (var item in paylist)
            {
                PaymentList.Add(item);
            }
            FillPaymentDatagrid(PaymentList);

            // Read sample data from CSV file
        }

        private void dgvAddedPayments_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            payment = PaymentList[index];
        }
    }
}
