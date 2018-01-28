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
    public partial class History : MetroFramework.Forms.MetroForm
    {
        List<Payment> PaymentList = new List<Payment>();
        List<Payment> PaymentListS = new List<Payment>();
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

        public History(User _user)
        {
            InitializeComponent();
            user = _user;
        }
        public History()
        {
            InitializeComponent();
        }
        // method to populate datagrid Added payments
        public void FillPaymentsDatagrid(List<Payment> PaymentDataGridList)
        {

            DataTable paytable = ConvertListToDataTable(PaymentDataGridList);
            dgvPayments.DataSource = paytable;
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
        public string getstatus(int statusselect) {

            switch (cmbStaus.SelectedIndex)
            {
                case -1:
                    status = "";
                    break;
                case 0:
                    status = "Approved";
                    break;
                case 1:
                    status = "Declined";
                    break;
                case 2:
                    status = "Pending";
                    break;
            }
            return status;

        }
        private void History_Load(object sender, EventArgs e)
        {
            PaymentList = PaymentsController.GetPayments(user.RsaID);
            FillPaymentsDatagrid(PaymentList);
        
            string BenName = txtBName.Text.Trim();
          
            DateTime EndDate = dtpEnd.Value;
            DateTime StartDate = dtpStart.Value;
          
            
          
        


        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblP500_Click(object sender, EventArgs e)
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

        private void txtStatus_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if(MetroFramework.MetroMessageBox.Show(this, "Are you sure you wish to exit this application?", "Exit Project 500", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void dgvPayments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
          Payment  payment1 = PaymentListS[index];
            foreach (Payment item in PaymentList)
            {
                if (item == payment1)
                {
                    payment = payment1;
                }

            }
            genratedes();
            }

        private void btnRemakePayment_Click(object sender, EventArgs e)
        {
            Payments payments = new Payments(user);
            this.Hide();
            payments.Show();
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            FillPaymentsDatagrid(PaymentsController.GetPayments(user.RsaID));
        }
        public void clearall() {
            txtBName.Text = "";
            cmbStaus.SelectedIndex = -1;
            dtpEnd.Value = DateTime.Now;
            dtpStart.Value = DateTime.Now;
            cbPaymenttype.SelectedIndex =- 1;
        }

        private void btnClearFields_Click(object sender, EventArgs e)
        {
            clearall();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (txtBName.Text.Trim() == "" && cmbStaus.SelectedIndex == -1 && cbPaymenttype.SelectedIndex == -1 && dtpEnd.Value == null && dtpEnd.Value == null )
            {
                MessageBox.Show("No filler set");
            }
            else
            {
              

                if (cbPaymenttype.SelectedIndex == -1)
                {
                    MessageBox.Show("no type");
                    PaymentList = PaymentsController.GetFilterPaymentsNoType("11", getstatus(cmbStaus.SelectedIndex), dtpStart.Value, dtpEnd.Value);
                    FillPaymentsDatagrid(PaymentList);
                }
                else
                {
                    switch (cbPaymenttype.SelectedIndex)
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
                    PaymentList = PaymentsController.GetFilterPayments("11", getstatus(cmbStaus.SelectedIndex), paymentType, dtpStart.Value, dtpEnd.Value);
                    FillPaymentsDatagrid(PaymentList);
                }
                
            

            }
          
        }

        private void BtnRety_Click(object sender, EventArgs e)
        {
            if (PaymentsController.UpdatePyaments(payment))
            {
                foreach (Payment item in PaymentList)
                {
                    if (payment.PaymentNumber == item.PaymentNumber)
                    {
                        item.Status = "Approved";
                    }
                    
                }

            }
            genratedes();
            FillPaymentsDatagrid(PaymentList);
        }
        public void genratedes() {

            rteDecription.Text = string.Format(@" Payment number : {0}        Schedual number : {1}        Username : {2}
                                                  Beneficiary name : {3}      Amount : R{4}      Payment date : {5} 
                                                  Date created : {6}       Description : {7}               
                                                  interval : {8}           Status : {9}          Type : {10}  ", payment.PaymentNumber, payment.ScheduleNr, payment.UserID, payment.BeneficairyID, payment.Amount, payment.PayDate, payment.DateCreated, payment.Description, payment.Interval, payment.Status, payment.TypePayment);


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
