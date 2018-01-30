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
using System.IO;

namespace Project500
{
    public partial class Batch : Form
    {
        public Batch()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Payment> batchlist = new List<Payment>();
            StreamReader reader = new StreamReader(@"../../ReadTest.csv");


            List<string> headerList = null;
            List<Payment> paylist = new List<Payment>();


            while (!reader.EndOfStream)

            {
                Payment payment = new Payment();
                var line = reader.ReadLine();
                string[] values = null;
                values = line.Split(',');

                payment.Amount = float.Parse(values[0]);
                payment.BeneficairyID = values[1];
                payment.DateCreated = Convert.ToDateTime(values[2]);
                payment.Description = values[3];
                payment.Interval = values[4];
                payment.PayDate = Convert.ToDateTime(values[5]);
                payment.PaymentNumber = values[6];
                payment.Recurring = Convert.ToBoolean(values[7]);
                payment.ScheduleNr = values[8];
                payment.Status = values[9];
                paylist.Add(payment);
                MessageBox.Show(payment.Amount.ToString());
                payment.TypePayment = PaymentType.Card;
                payment.UserID = "1";
                batchlist.Add(payment);


            }
            foreach (var item in batchlist)
            {
                //MessageBox.Show(item.BeneficairyID);
                richTextBox1.Text += item.BeneficairyID + "/" + item.Amount + "/" + item.TypePayment + "/" + item.ScheduleNr + "\n";
            }
           

        } }


    }


