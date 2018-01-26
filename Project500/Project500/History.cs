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
    public partial class History : MetroFramework.Forms.MetroForm
    {
        User user = new User();
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
            BindingSource PayBinding = new BindingSource();
            PayBinding.Add(PaymentDataGridList);
            dgvPayments.DataSource = PayBinding;
        }
        private void History_Load(object sender, EventArgs e)
        {

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
    }
}
