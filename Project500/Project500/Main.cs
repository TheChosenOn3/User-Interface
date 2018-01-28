using Entities1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Project500
{
    public partial class Main : MetroFramework.Forms.MetroForm
    {
        User user = new User();
        public Main(User _user)
        {
            InitializeComponent();
            user = _user;
        }
       
        public Main()
        {
            InitializeComponent();
        }


        private void Main_Load(object sender, EventArgs e)
        {
           
            
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile(user);
            this.Hide();
            profile.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you wish to exit this application?", "Exit Project 500", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnRucuring_Click(object sender, EventArgs e)
        {
            Recuring Recur = new Recuring(user);
            this.Hide();
            Recur.Show();
        }
    }
}
