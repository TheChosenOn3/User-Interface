using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using Entities1;
using Newtonsoft.Json;

namespace Controllers
{

    public class PaymentsController
    {
        public static string Control = "Payment/";

        public static List<Payment> GetPayments(string UserId)
        {
            return ControllerHandler<Payment>.Search(Control + UserId);
        }
        public static bool AddPyaments(Payment NewPayments)
        {
            return ControllerHandler<Payment>.Insert(NewPayments, Control);
        }
        public static bool DeletePyaments(string id)
        {
            return ControllerHandler<Payment>.Delete(Control + id);
        }
        public static bool UpdatePyaments(Payment NewPayments)
        {
            return ControllerHandler<Payment>.Update(NewPayments, Control);
        }
    }
}
