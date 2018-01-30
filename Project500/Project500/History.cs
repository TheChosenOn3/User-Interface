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
using System.IO;

namespace Project500
{
    public partial class History : MetroFramework.Forms.MetroForm
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

        public History(User _user)
        {
            InitializeComponent();
            user = _user;
            btnProfileImage.Text = " " + user.Name;
        }
        public History()
        {
            InitializeComponent();
        }

        //Method to Generate an Extra tab to display linked payments of a recurring Payment.
        public void ShowExtraPayments(string RefenceID)
        {
            tcPayments.TabPages.Add("RecurHistory", "Recurring Payment History");
            
        }

        public void HideExtraPayments(string RefenceID)
        {

        }

        // method to populate datagrid Added payments
        public void FillPaymentsDatagrid(List<Payment> PaymentDataGridList)
        {

            DataTable paytable = ConvertListToDataTable(PaymentDataGridList);
            dgvPayments.DataSource = paytable;
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
                            break;
                        }
                    }
                    
                    table.Rows.Add(item.ScheduleNr, item.PaymentNumber, bennnaem,item.BeneficiaryAccount, item.Description, item.PayDate.ToString(), item.Amount, item.Interval, item.Status, item.TypePayment);

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
            PaymentListF = PaymentsController.GetPayments(user.RsaID);

            BeneficairyList = BeneficiaryController.GetBeneficiarys(user.RsaID);
            foreach (Payment item in PaymentListF)
            {
                    PaymentList.Add(item);
            }
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
                Login LoginForm = new Login();
                LoginForm.Show();
                this.Hide();
            }
        }

        private void dgvPayments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnRemakePayment_Click(object sender, EventArgs e)
        {
            Payments payments = new Payments(user);
            this.Hide();
            payments.Show();
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            FillPaymentsDatagrid(PaymentList);
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
                string benidtosearc = "";

                foreach (Beneficiary item in BeneficairyList)
                {
                    if (item.BeneficairyName.IndexOf(txtBName.Text.Trim(), StringComparison.CurrentCultureIgnoreCase) != -1)
                    {
                        benidtosearc = item.BeneficairyID;
                    }
                    //ewqqwe

                }
                
                PaymentListS = PaymentList;
                // begin
                if (cbPaymenttype.SelectedIndex == -1)
                {
                    if (benidtosearc == "")
                    {
                        if (cmbStaus.SelectedIndex == -1)
                        {
                            foreach (Payment item in PaymentListS)
                            {
                                DateTime payDate = DateTime.ParseExact(item.PayDate, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);

                                if (payDate >= dtpStart.Value && payDate <= dtpEnd.Value)
                                {
                                    PaymentList.Add(item);
                                }

                            }

                        }
                        else
                        {
                            foreach (Payment item in PaymentListS)
                            {
                                DateTime payDate = DateTime.ParseExact(item.PayDate, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);

                                if (payDate >= dtpStart.Value && payDate <= dtpEnd.Value && item.Status ==cmbStaus.SelectedIndex.ToString())
                                {
                                    PaymentList.Add(item);
                                }

                            }


                        }


                    }
                    else
                    {
                        if (cmbStaus.SelectedIndex == -1)
                        {
                            foreach (Payment item in PaymentListS)
                            {
                                DateTime payDate = DateTime.ParseExact(item.PayDate, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);

                                if (payDate >= dtpStart.Value && payDate <= dtpEnd.Value && item.BeneficairyID == benidtosearc)
                                {
                                    PaymentList.Add(item);
                                }

                            }

                        }
                        else
                        {
                            foreach (Payment item in PaymentListS)
                            {
                                DateTime payDate = DateTime.ParseExact(item.PayDate, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);

                                if (payDate >= dtpStart.Value && payDate <= dtpEnd.Value && item.Status == cmbStaus.SelectedIndex.ToString() && item.BeneficairyID == benidtosearc)
                                {
                                    PaymentList.Add(item);
                                }

                            }


                        }

                    }
                    //maby need to make new controller vor scheadualed table
               


                }
                else
                {
                    if (benidtosearc == "")
                    {
                        if (cmbStaus.SelectedIndex == -1)
                        {
                            foreach (Payment item in PaymentListS)
                            {
                                DateTime payDate = DateTime.ParseExact(item.PayDate, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);

                                if (payDate >= dtpStart.Value && payDate <= dtpEnd.Value && cbPaymenttype.SelectedItem.ToString() == item.TypePayment.ToString())
                                {
                                    PaymentList.Add(item);
                                }

                            }

                        }
                        else
                        {
                            foreach (Payment item in PaymentListS)
                            {
                                DateTime payDate = DateTime.ParseExact(item.PayDate, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);

                                if (payDate >= dtpStart.Value && payDate <= dtpEnd.Value && item.Status == cmbStaus.SelectedIndex.ToString() && cbPaymenttype.SelectedItem.ToString() == item.TypePayment.ToString())
                                {
                                    PaymentList.Add(item);
                                }

                            }


                        }


                    }
                    else
                    {
                        if (cmbStaus.SelectedIndex == -1)
                        {
                            foreach (Payment item in PaymentListS)
                            {
                                DateTime payDate = DateTime.ParseExact(item.PayDate, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);

                                if (payDate >= dtpStart.Value && payDate <= dtpEnd.Value && item.BeneficairyID == benidtosearc && cbPaymenttype.SelectedItem.ToString() == item.TypePayment.ToString())
                                {
                                    PaymentList.Add(item);
                                }

                            }

                        }
                        else
                        {
                            foreach (Payment item in PaymentListS)
                            {
                                DateTime payDate = DateTime.ParseExact(item.PayDate, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);

                                if (payDate >= dtpStart.Value && payDate <= dtpEnd.Value && item.Status == cmbStaus.SelectedIndex.ToString() && item.BeneficairyID == benidtosearc && cbPaymenttype.SelectedItem.ToString() == item.TypePayment.ToString())
                                {
                                    PaymentList.Add(item);
                                }

                            }


                        }

                    }
                    //maby need to make new controller vor scheadualed table

                }

                FillPaymentsDatagrid(PaymentList);
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

        private void tcFilterPayments_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabFilterPayments_Click(object sender, EventArgs e)
        {

        }

        private void cmbStaus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void dtpEnd_ValueChanged(object sender, EventArgs e)
        {

        }

        private void metroLabel6_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void dtpStart_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtBName_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel29_Click(object sender, EventArgs e)
        {

        }

        private void tcPayments_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroTabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tcCurrentPayment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabCurrentPayment_Click(object sender, EventArgs e)
        {

        }

        //Generates Report from the Payments on the history datagridview
        public void GenerateReportForPaymentsHistory()
        {
            string DesktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string FinalPath = DesktopPath + "/Payments Report.csv";
            string delimiter = ",";

            int RowCount = int.Parse(dgvPayments.RowCount.ToString());

            List<string[]> Output = new List<string[]>();

            Output.Add(new string[] { "Payment Number", "Beneficiary Name", "Description", "Pay Date", "Amount", "Interval", "Status", "Type" });
            Output.Add(new string[] { "--------------------------------", "--------------------------------", "--------------------------------", "--------------------------------", "--------------------------------", "--------------------------------", "--------------------------------", "--------------------------------" });

            int TotalPayments = 0;
            int SuccessfulPayments = 0;
            int FailedPayments = 0;

            float TotalAmount = 0;
            float TotalSuccessAmount = 0;
            float TotalFailAmount = 0;

            int Counter = 0;

            foreach (DataGridViewRow item in dgvPayments.Rows)
            {
                if (Counter <= RowCount - 2)
                {
                    Output.Add(new string[] { item.Cells[0].Value.ToString(), item.Cells[1].Value.ToString(), item.Cells[2].Value.ToString(), item.Cells[3].Value.ToString(), item.Cells[4].Value.ToString(), item.Cells[5].Value.ToString(), item.Cells[6].Value.ToString(), item.Cells[7].Value.ToString(), });

                    TotalPayments++;
                    TotalAmount += float.Parse(item.Cells[4].Value.ToString());

                    if (item.Cells[6].Value.ToString() == "Success")
                    {
                        SuccessfulPayments++;
                        TotalSuccessAmount += float.Parse(item.Cells[4].Value.ToString());
                    }
                    else if (item.Cells[6].Value.ToString() == "Failed")
                    {
                        FailedPayments++;
                        TotalFailAmount += float.Parse(item.Cells[4].Value.ToString());
                    }

                    Counter++;
                }

            }

            Output.Add(new string[] { "--------------------------------", "--------------------------------", "--------------------------------", "--------------------------------", "--------------------------------", "--------------------------------", "--------------------------------", "--------------------------------" });
            Output.Add(new string[] { "Summary:", "", "", "", "", "", "", "" });
            Output.Add(new string[] { "", "", "", "", "", "", "", "" });
            Output.Add(new string[] { "Total Payments: ", TotalPayments.ToString(), "", "", "", "", "", "" });
            Output.Add(new string[] { "Total Amount: ", TotalAmount.ToString(), "", "", "", "", "", "" });
            Output.Add(new string[] { "", "", "", "", "", "", "", "" });
            Output.Add(new string[] { "Total Successful Payments: ", SuccessfulPayments.ToString(), "", "", "", "", "", "" });
            Output.Add(new string[] { "Total Amount for Successful: ", TotalSuccessAmount.ToString(), "", "", "", "", "", "" });
            Output.Add(new string[] { "", "", "", "", "", "", "", "" });
            Output.Add(new string[] { "Total Failed Payments: ", FailedPayments.ToString(), "", "", "", "", "", "" });
            Output.Add(new string[] { "Total Amount for Failed: ", TotalFailAmount.ToString(), "", "", "", "", "", "" });

            int length = Output.Count();
            StringBuilder sb = new StringBuilder();

            for (int index = 0; index < length; index++)
            {
                sb.AppendLine(string.Join(delimiter, Output[index]));
            }

            File.WriteAllText(FinalPath, sb.ToString());
            MetroMessageBox.Show(this, "Payment has been saved on your desktop!", "Payment Report Saved");
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            GenerateReportForPaymentsHistory();
        }

        private void rteDecription_TextChanged(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblProfile_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnProfileImage_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvPayments_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            Payment payment1 = PaymentList[index];
            foreach (Payment item in PaymentList)
            {
                if (item == payment1)
                {
                    payment = payment1;
                }

            }
            genratedes();
        }
    }
}
