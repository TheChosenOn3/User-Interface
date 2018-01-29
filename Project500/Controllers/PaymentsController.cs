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

        static HttpClient client;
        public static string path = Connection.url + "Payment/";
        public static List<Payment> GetPayments(string UserId)
        {
            List<Payment> PaymentList = new List<Payment>();
            client = new HttpClient();
            path += UserId;
            var response = client.GetStringAsync(path).Result;
            PaymentList = JsonConvert.DeserializeObject<List<Payment>>(response);

            return PaymentList;
        }

        public static List<Payment> GetSchedueldPayments(string UserId)
        {
            List<Payment> PaymentList = new List<Payment>();
            client = new HttpClient();
            path += UserId;
            var response = client.GetStringAsync(path).Result;
            PaymentList = JsonConvert.DeserializeObject<List<Payment>>(response);

            return PaymentList;
        }

        public static bool AddPyaments(Payment NewPayments)
        {
            HttpClient _client = new HttpClient();
            string jsonString = JsonConvert.SerializeObject(NewPayments);
            var content = new StringContent(jsonString, Encoding.UTF8, "application/json");
            HttpResponseMessage someVar = _client.PostAsync(path, content).Result;//handle if resonse codes fail
            if (someVar.IsSuccessStatusCode)
            {
                return true;//Beneficiary Added to DB successfuly
            }
            return false;//something went wrong

        }
        public static bool DeletePyaments(Payment NewPayments)
        {
            return true;

        }
        public static bool UpdatePyaments(Payment NewPayments)
        {
            return true;

        }

    }
}
