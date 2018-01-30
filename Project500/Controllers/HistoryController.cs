using Entities1;
using System;
using System.Collections.Generic;
using System.Text;

namespace Controllers
{
   public  class HistoryController
    {
        static string Control = "History/";
        public static List<Payment> getHistory(string id)
        {
            List<History> histList = ControllerHandler<History>.Search(Control + id);
            List<Payment> payList = new List<Payment>();
            foreach (History item in histList)
            {
                payList.Add(new Payment(item.ScheduleNr, item.Description, item.BeneficairyID, item.PayDate, item.Amount, item.Interval, item.Status, item.PaymentNumber, item.TypePayment, item.Recurring, item.DateCreated, item.UserID, item.BeneficairyID));
                
            }
            return payList;
        }
    }
}
