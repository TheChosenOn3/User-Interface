using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using Entities1;

namespace Controllers
{
    public class recuringControllercs
    {
        static HttpClient client;
        public static List<Payment> GetPayments(string UserId)
        {
            List<Payment> PaymentList = new List<Payment>();
            PaymentList.Add(new Payment("1", "payment1", "12324", DateTime.Now, 100, "0", "pending", "111", PaymentType.Card, false, DateTime.Now, "1234"));
            PaymentList.Add(new Payment("2", "payment2", "12324", DateTime.Now, 100, "0", "Declined", "222", PaymentType.Card, false, DateTime.Now, "1234"));
            PaymentList.Add(new Payment("3", "payment3", "12324", DateTime.Now, 100, "1", "Schedueld", "333", PaymentType.Card, true, DateTime.Now, "1234"));
            PaymentList.Add(new Payment("4", "payment4", "12324", DateTime.Now, 100, "1", "Schedueld", "444", PaymentType.Card, true, DateTime.Now, "1234"));
            PaymentList.Add(new Payment("5", "payment5", "12324", DateTime.Now, 100, "0", "pending", "555", PaymentType.Card, false, DateTime.Now, "1234"));
            // mision "n if statement vir as danielo net vir history moet search of net vir scheaduel
            return PaymentList;
        }
        public static List<Payment> GetFilterPayments(string BenId, string Status, PaymentType Type, DateTime Begin, DateTime End)
        {
            List<Payment> PaymentList = new List<Payment>();
            PaymentList.Add(new Payment("1", "payment1", "12324", DateTime.Now, 100, "0", "pending", "111", PaymentType.Card, false, DateTime.Now, "1234"));
            PaymentList.Add(new Payment("2", "payment2", "12324", DateTime.Now, 100, "0", "Declined", "222", PaymentType.Card, false, DateTime.Now, "1234"));
            PaymentList.Add(new Payment("3", "payment3", "12324", DateTime.Now, 100, "1", "Schedueld", "333", PaymentType.Card, true, DateTime.Now, "1234"));
            PaymentList.Add(new Payment("4", "payment4", "12324", DateTime.Now, 100, "1", "Schedueld", "444", PaymentType.Card, true, DateTime.Now, "1234"));
            PaymentList.Add(new Payment("5", "payment5", "12324", DateTime.Now, 100, "0", "pending", "555", PaymentType.Card, false, DateTime.Now, "1234"));
            // mision "n if statement vir as danielo net vir history moet search of net vir scheaduel

            return PaymentList;
        }
        public static List<Payment> GetFilterPaymentsNoType(string BenId, string Status, DateTime Begin, DateTime End)
        {
            List<Payment> PaymentList = new List<Payment>();
            PaymentList.Add(new Payment("1", "payment1", "12324", DateTime.Now, 100, "0", "pending", "111", PaymentType.Card, false, DateTime.Now, "1234"));
            PaymentList.Add(new Payment("2", "payment2", "12324", DateTime.Now, 100, "0", "Declined", "222", PaymentType.Card, false, DateTime.Now, "1234"));
            PaymentList.Add(new Payment("3", "payment3", "12324", DateTime.Now, 100, "1", "Schedueld", "333", PaymentType.Card, true, DateTime.Now, "1234"));
            PaymentList.Add(new Payment("4", "payment4", "12324", DateTime.Now, 100, "1", "Schedueld", "444", PaymentType.Card, true, DateTime.Now, "1234"));
            PaymentList.Add(new Payment("5", "payment5", "12324", DateTime.Now, 100, "0", "pending", "555", PaymentType.Card, false, DateTime.Now, "1234"));
            // mision "n if statement vir as danielo net vir history moet search of net vir scheaduel
            return PaymentList;
        }
        public static bool UpdatePyaments(Payment NewPayments)
        {
            return true;

        }

    }
}
