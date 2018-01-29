using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using Entities1;

namespace Entities1
{
   public   class fillData

    {
        public static List<Payment> readCsv()
        {
            List<Payment> paylist = new List<Payment>();
            Payment payment = new Payment(); 
           

            using (var reader = new StreamReader("ReadTest.csv"))
            {
                List<string> headerList = null;


                while (!reader.EndOfStream)

                {
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




                }

                }
          


            return paylist;
        }



    }
}