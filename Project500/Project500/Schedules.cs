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

        List<String> UobjectListe = new List<String>();
        List<String> BenbjectListe = new List<String>();

        public void FillPaymentsDatagrid(List<Payment> PaymentDataGridList)
        {

            DataTable paytable = ConvertListToDataTable(PaymentDataGridList);
            dgvScheduels.DataSource = paytable;
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

                    table.Rows.Add(item.PaymentNumber, item.BeneficairyID, item.Description, item.PayDate.ToString(), item.Amount, item.Interval, item.Status, item.TypePayment);

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
                BenbjectListe.Add("Crypto " + item.WaletName);

            }
            foreach (PaymentAccount item in beneftlist)
            {
                BenbjectListe.Add("EFT " + item.Reference);
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
        }
        private void Schedules_Load(object sender, EventArgs e)
        {
            BeneficairyList = BeneficiaryController.GetBeneficiarys(user.RsaID);
            PaymentListF = PaymentsController.GetPayments(user.RsaID);
            foreach (Payment   item in PaymentListF)
            {
                if (item.PayDate > DateTime.Now)
                {
                    PaymentList.Add(item);
                }
              
            }
            UserPaymentAccountList = PaymentsAccountController.SearchUserPaymentAcount(user.RsaID);
            UserCardList = CardController.RetrveCards(user.RsaID);
            FillPaymentsDatagrid(PaymentList);
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

            }
            if (recur == true && txtInterval.Text == "")
            {
                MessageBox.Show("please fill in a interval if you want payment to be recuuring otherwize untick the box ");
            }
            else if (txtAmount.Text == "" || cbBAcounType.SelectedIndex == -1 || cbuserpaymentmethod.SelectedIndex == -1 || txtDescription.Text == "" || txtBname.Text == "")
            {
                MessageBox.Show("please fill in all fields and select a beneficairy");
            }
            else if (checkInter.Checked == true && txtInterval.Text == "")
            {
                MessageBox.Show("please select a interval if you want payment to be recuring");
            }
            else if (cbBAcounType.SelectedIndex != -1 && cbuserpaymentmethod.SelectedIndex != -1)
            {

                string benected = cbBAcounType.SelectedItem.ToString();
                string userlected = cbuserpaymentmethod.SelectedItem.ToString();
                string usertype = userlected.Substring(0, 3);
                string bentype = benected.Substring(0, 3);
                if (usertype != bentype)
                {
                    MessageBox.Show("your selected payment type needs to corispond with the beneficiarys type");
                }
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

                Payment newPayment = new Payment("12", txtDescription.Text.Trim(), beneficiary.BeneficairyID, dtpPaymentdate.Value, float.Parse(txtAmount.Text.Trim()), txtInterval.Text.Trim(), payment.Status, payment.PaymentNumber, typepay, recur, DateTime.Now, user.RsaID);
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

            // add ne payment to datagrid payments

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you wish to exit this application?", "Exit Project 500", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void dgvScheduels_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            payment = PaymentList[index];
            txtAmount.Text = payment.Amount.ToString();
            txtDescription.Text = payment.Description;
            txtInterval.Text = payment.Interval;
            dtpPaymentdate.Value = payment.PayDate;
            FillBeneficiaryDatagrid(BeneficairyList);
            FillBeneficiaryDatagrid(BeneficairyList);
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (txtFBName.Text.Trim() == "" && cbFPaymentMethod.SelectedIndex == -1  && dtpFStart.Value == null && dtpFEnd.Value == null)
            {
                MessageBox.Show("No filler set");
            }
            else
            {
                if (cbFPaymentMethod.SelectedIndex == -1)
                {
                    MessageBox.Show("no type");
                    PaymentListS = PaymentsController.GetFilterPaymentsNoType("11","Schedueld", dtpFStart.Value, dtpFEnd.Value);
                    FillPaymentsDatagrid(PaymentListS);
                }
                else
                {
                    switch (cbFPaymentMethod.SelectedIndex)
                    {
                        case 0:
                            paymentType = PaymentType.Crypto;
                            break;
                        case 1:
                            paymentType = PaymentType.EFT;
                            break;
                        case 2:
                            paymentType = PaymentType.Card;
                            break;
                    }

                    MessageBox.Show("typ");
                    PaymentListS = PaymentsController.GetFilterPayments("11", "Schedueld", paymentType, dtpFStart.Value, dtpFEnd.Value);
                    FillPaymentsDatagrid(PaymentListS);
                }



            }

        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            txtFBName.Text = "";
            cbFPaymentMethod.SelectedIndex = -1;
            dtpFEnd.Value = DateTime.Now;
            dtpFStart.Value = DateTime.Now;
          
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           
            if (PaymentsController.DeletePyaments(payment))
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
            {
                if (PaymentsController.DeletePyaments(payment))
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


            BenbjectListe = PopSelectedBenAcount(PaymentsAccountController.SearchBenPaymentAcount(beneficiary.BeneficairyID), CryptoController.GetCrypto(beneficiary.BeneficairyID));
            List<string> remove = new List<string>();
            cbBAcounType.Items.Clear();
            foreach (string item in BenbjectListe)
            {
                cbBAcounType.Items.Add(item);

            }

            BenbjectListe.Clear();
        }

        private void btnSearchBeneficiary_Click(object sender, EventArgs e)
        {
            
            BeneficiaryListS.Clear();
            foreach (Beneficiary item in BeneficairyList)
            {
                if (item.BeneficairyName == txtBname.Text.Trim())
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
    }
}
