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
    public partial class Payments : MetroFramework.Forms.MetroForm
    {
        Payment payment = new Payment();
        List<Payment> PaymentList = new List<Payment>();
       

        public Payments()
        {
            InitializeComponent();
        }

        private void Payments_Load(object sender, EventArgs e)
        {

        }
      
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            this.Hide();
            main.Show();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            this.Hide();
            profile.Show();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            Payments payments = new Payments();
            this.Hide();
            payments.Show();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            History history = new History();
            this.Hide();
            history.Show();
        }

        private void btnScheduel_Click(object sender, EventArgs e)
        {
            Schedules scheduels = new Schedules();
            this.Hide();
            scheduels.Show();
        }

        private void btnBeneficiary_Click(object sender, EventArgs e)
        {
            Benenficiarys beneficiarys = new Benenficiarys();
            this.Hide();
            beneficiarys.Show();
        }

        private void btnDeletePayment_Click(object sender, EventArgs e)
        {
            //payment= get selected payment from datagrid
            // send payment to delete
            // get new list to fill datagrid
           
            ClearFields();
        }

        private void btnRetryPayment_Click(object sender, EventArgs e)
        {
            //payment= get selected payment from datagrid
            // check for valid
            // send payment to rety
          
            ClearFields();

        }

        private void btnExacutePayment_Click(object sender, EventArgs e)
        {
            //payment= get selected payment from datagrid
            // check for valid
            // send payment to add
           
            ClearFields();
        }

        private void btnDeleteAllPayment_Click(object sender, EventArgs e)
        {
            // clear all datagrids
            ClearFields();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            ClearFields();
        }
        public void ClearFields()
        {
            //clear ben datagrid
            txtAmount.Text = "";
            txtBName.Text = "";
            txtDescription.Text = "";
            txtInterval.Text = "";
            //clear cbBAccType
            //clear cbUPaymentType
            // clear dtpPayDatae
        }

        private void btnRetryAllPayment_Click(object sender, EventArgs e)
        {
            // cehck for valid
            //sent true   PaymentList =     all in datagrid
            // keep the failed ones
           
            ClearFields();
        }

        private void btnExacuteAllPayment_Click(object sender, EventArgs e)
        {
            // check for valid
            //sent true   PaymentList =     all in datagrid
            // keep the failed ones
            ClearFields();
        }

        private void dgvAddedPayments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {// gwet payment SELECTED FROM DATAGRID
            // fill ben 
          //  txtAmount.Text = payment.Amount
            txtBName.Text = payment.BeneficairyID;
            txtDescription.Text = payment.Description;
            txtInterval.Text = payment.Interval;
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
            // caheck valid
            // add ne payment to datagrid payments
            ClearFields();
        }
    }
    }
