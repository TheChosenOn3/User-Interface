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
        string BenName = "";
        string Discription = "";
        float Amount1 = 0;
        string interval = "";
        DateTime paymentdate = DateTime.Now;
        Random rnd = new Random();
        Random rnd1 = new Random();
        Random rnd2 = new Random();
     


        string Waletname = "BTCACC";
        float Waletammount = 11234;
        string WalletID = "234567890";


        //hier kom die SEOP nou   fill combo box met die # lists
        List<String> UobjectListe = new List<String>();
        List<String> BenbjectListe = new List<String>();


        User user = new User();
        public Payments(User _user)
        {
            InitializeComponent();
            user = _user;
        }
        public Payments()
        {
            InitializeComponent();
        }

        private void Payments_Load(object sender, EventArgs e)
        {
          

            BeneficairyList = BeneficiaryController.GetBeneficiarys(user.RsaID);
            UserPaymentAccountList = PaymentsAccountController.SearchUserPaymentAcount(user.RsaID);
            UserCardList = CardController.RetrveCards(user.RsaID);
            FillBeneficiaryDatagrid(BeneficairyList);
           
            popUcb();

        }

        public void popUcb()
        {

            // fill object list
            UobjectListe.Add("Crypto");
            foreach (PaymentAccount item in UserPaymentAccountList)
            {
                UobjectListe.Add("EFT " + item.AccountNumber);
            }
            foreach (Card item in UserCardList)
            {
                UobjectListe.Add("Card " + item.CardNr);
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
                BenbjectListe.Add("Crypto " + item.WaletName);

            }
            foreach (PaymentAccount item in beneftlist)
            {
                BenbjectListe.Add("EFT " + item.Reference);
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
                table.Columns.Add("payment number");
                table.Columns.Add("Beneficairy Name");

                table.Columns.Add("Description");
                table.Columns.Add("paydate");
                table.Columns.Add("Amont");
                table.Columns.Add("Interval");
                table.Columns.Add("Status");
                table.Columns.Add("type");
               

                foreach (Payment item in list)
                {
                  
                    table.Rows.Add(item.PaymentNumber,item.BeneficairyID,item.Description,item.PayDate.ToString(),item.Amount,item.Interval,item.Status,item.TypePayment);

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
        {
            if (PaymentsController.UpdatePyaments(payment))
            {
                foreach (Payment item in PaymentList)
                {
                    if (payment.PaymentNumber == item.PaymentNumber)
                    {
                        item.Status = "Submitted";
                        MessageBox.Show("payment exacuted sucsessfully");
                    }
                    else
                    {
                        item.Status = "Failed";
                    }
                }

            }
            else
            {
                MessageBox.Show("could not connect to server");
            }
            FillPaymentDatagrid(PaymentList);

          }

        private void btnExacutePayment_Click(object sender, EventArgs e)
        {
            if (payment.Recurring == true)
            {
                if (recuringControllercs.AddPyaments(payment))
                {
                    foreach (Payment item in PaymentList)
                    {
                        if (payment.PaymentNumber == item.PaymentNumber)
                        {
                            item.Status = "Submitted";
                            MessageBox.Show("payment exacuted sucsessfully");
                        }
                        else
                        {
                            item.Status = "Failed";
                        }
                    }
                }
                else
                {
                    MessageBox.Show("could not connect to server");
                }

            }
            else
            {
                if (PaymentsController.AddPyaments(payment))
                {
                    foreach (Payment item in PaymentList)
                    {
                        if (payment.PaymentNumber == item.PaymentNumber)
                        {
                            item.Status = "Submitted";
                        }
                        else
                        {
                            item.Status = "Failed";
                        }
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
                            item1.Status = "Submitted";
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
                
                    MessageBox.Show("could not connect to server");
                
            }
            else
            {
                MessageBox.Show("All payments exacuted sucsessfully");
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
                            item1.Status = "Submitted";
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

                MessageBox.Show("could not connect to server");

            }
            else
            {
                MessageBox.Show("All payments exacuted sucsessfully");
            }

            FillPaymentDatagrid(PaymentList);
        }

        private void dgvAddedPayments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {// gwet payment SELECTED FROM DATAGRID
            // fill ben 
          //  txtAmount.Text = payment.Amount
            txtBName.Text = payment.BeneficairyID;
            txtDescription.Text = payment.Description;
            //txtInterval.Text = payment.Interval;
            //set cbBAccType
            //set cbUPaymentType
            // set dtpPayDatae
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
                MessageBox.Show("please fill in a interval if you want payment to be recuuring otherwize untick the box ");
            }
            else if(txtInterval.Text.Length != 5)
            {
                MessageBox.Show("your interval must be int he correct format ");

            }
            else if (txtAmount.Text == "" || cbBAccType.SelectedIndex == -1 || cbxPaymentType.SelectedIndex == -1 || txtDescription.Text == "" || txtBName.Text == "")
            {
                MessageBox.Show("please fill in all fields and select a beneficairy");
            }
            else if (checkInter.Checked == true && txtInterval.Text == "")
            {
                MessageBox.Show("please select a interval if you want payment to be recuring");
            }
            else if (cbBAccType.SelectedIndex != -1 && cbxPaymentType.SelectedIndex != -1)
            {
                
                string benected = cbBAccType.SelectedItem.ToString();
                string userlected = cbxPaymentType.SelectedItem.ToString();
                string usertype = userlected.Substring(0, 3);
                string bentype = benected.Substring(0, 3);
                if (usertype != bentype)
                {
                    MessageBox.Show("your selected payment type needs to corispond with the beneficiarys type");
                }
                else
                {
                    if (usertype == "Cry")
                    {
                        typepay = PaymentType.Crypto;
                    }
                    else if (usertype == "Car")
                    {
                        typepay = PaymentType.Card;
                    }
                    else
                    {
                        typepay = PaymentType.EFT;
                    }
                    int PaymentNum1 = rnd.Next(1, 1000);
                    int PaymentNum2 = rnd.Next(1, 1000);
                    int SchedueldNum = rnd.Next(1, 1000);
                    string paynum = PaymentNum1.ToString() + PaymentNum2.ToString();

                    PaymentList.Add(new Payment(SchedueldNum.ToString(), txtDescription.Text.Trim(), beneficiary.BeneficairyID, dtpPayDate.Value, float.Parse(txtAmount.Text.Trim()), txtInterval.Text.Trim(), "Pending", paynum, typepay, recur, DateTime.Now, user.RsaID));
                    //add payment
                    FillPaymentDatagrid(PaymentList);
                    ClearFields();
                    
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
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you wish to exit this application?", "Exit Project 500", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnSearchB_Click_1(object sender, EventArgs e)
        {
            BenName = txtBName.Text.Trim();
            BeneficiaryListS.Clear();
            foreach (Beneficiary item in BeneficairyList)
            {
                if (item.BeneficairyName == txtBName.Text.Trim())
                {
                    BeneficiaryListS.Add(item);
                }
            }

            FillBeneficiaryDatagrid(BeneficiaryListS);
          

        }

        private void dgvBeneficiarys_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
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
            txtBName.Text = beneficiary.BeneficairyName;
           
           
             BenbjectListe = PopSelectedBenAcount(PaymentsAccountController.SearchBenPaymentAcount(beneficiary.BeneficairyID), CryptoController.GetCrypto(beneficiary.BeneficairyID));
            List<string> remove = new List<string>();
            cbBAccType.Items.Clear();
            foreach (string item in BenbjectListe)
            {
                cbBAccType.Items.Add(item);

            }
          
            BenbjectListe.Clear();

        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
           FillBeneficiaryDatagrid(BeneficairyList);
             ClearBens();
        }
        public void ClearBens() {
            txtBName.Text = "";
            cbBAccType.SelectedIndex = -1;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvAddedPayments_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            payment = PaymentList[index];
          
        }
    }
    }
