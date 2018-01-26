using System;
using System.Collections.Generic;
using System.Text;
using Entities1;
using System.Net.Http;


namespace Controllers
{
  public  class PaymentsAccountController
    {
        static HttpClient client;
        public static List<PaymentAccount> SearchBenPaymentAcount(string BenId)
        {
            List<PaymentAccount> BenEFTList = new List<PaymentAccount>();
            BenEFTList.Add(new PaymentAccount("09423", "Ethan", "EFTCheck", AccountTypes.Cheque, "12324", "1234"));
            BenEFTList.Add(new PaymentAccount("33333", "Daniel", "EFTCheck", AccountTypes.Cheque, "12324", "1234"));
            BenEFTList.Add(new PaymentAccount("11111", "Daniel", "EFTDebit", AccountTypes.Credit, "12324", "1234"));
            BenEFTList.Add(new PaymentAccount("0934", "Jason", "EFTDebit", AccountTypes.Credit, "1134", "1234"));

            return BenEFTList;
        }
        public static List<PaymentAccount> SearchUserPaymentAcount(string UserId)
        {
            List<PaymentAccount> UserEFTList = new List<PaymentAccount>();
            UserEFTList.Add(new PaymentAccount("09423", "HOH", "EFTCheck", AccountTypes.Cheque, "12324", "1234"));
            UserEFTList.Add(new PaymentAccount("33333", "Cofee", "EFTCheck", AccountTypes.Cheque, "12324", "1234"));
            UserEFTList.Add(new PaymentAccount("11111", "Shahara", "EFTDebit", AccountTypes.Credit, "12324", "1234"));
            UserEFTList.Add(new PaymentAccount("0934", "JasonAA", "EFTDebit", AccountTypes.Credit, "1134", "1234"));
            return UserEFTList;
        }
        public static bool DeleteUserPaymentAcount(string UserAccID)
        {
            return true;

        }
        public static bool UpdateUserPaymentAcount(PaymentAccount userAcount)
        {
            return true;


        }
        public static bool AddUserPaymentAcount(PaymentAccount userAcount)
        {
            return true;


        }
        public static bool DeleteBenPaymentAcount(string BenAccID)
        {
            return true;


        }
        public static bool UpdateBenPaymentAcount(Beneficiary benAcount)
        {
            return true;



        }
        public static bool AddBenPaymentAcount(Beneficiary benAcount)
        {
            return true;


        }

    }
}
