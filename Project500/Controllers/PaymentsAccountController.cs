using System;
using System.Collections.Generic;
using System.Text;
using Entities1;
using System.Net.Http;


namespace Controllers
{
    public enum userType
    {
        Client = 1,
        Beneficiary
    }

    public class PaymentsAccountController
    {
        public static string Control = "Account/";
        public static List<PaymentAccount> SearchBenPaymentAcount(string BenId)
        {
            return ControllerHandler<PaymentAccount>.Search(Control + BenId);
        }
        public static List<PaymentAccount> SearchUserPaymentAcount(string UserId)
        {
            return ControllerHandler<PaymentAccount>.Search(Control + UserId + "/" + userType.Client);
        }
        public static bool DeleteUserPaymentAcount(string UserAccID)
        {
            return ControllerHandler<PaymentAccount>.Delete(Control + UserAccID);
        }
        public static bool UpdateUserPaymentAcount(PaymentAccount userAcount)
        {
            return ControllerHandler<PaymentAccount>.Update(userAcount, Control);
        }
        public static bool AddUserPaymentAcount(PaymentAccount userAcount)
        {
            return ControllerHandler<PaymentAccount>.Insert(userAcount, Control);
        }
        public static bool DeleteBenPaymentAcount(string BenAccID)
        {
            return ControllerHandler<PaymentAccount>.Delete(Control + BenAccID);
        }
        public static bool UpdateBenPaymentAcount(PaymentAccount benAcount)
        {
            return ControllerHandler<PaymentAccount>.Update(benAcount, Control);
        }
        public static bool AddBenPaymentAcount(PaymentAccount benAcount)
        {
            return ControllerHandler<PaymentAccount>.Insert(benAcount, Control);
        }

    }
}
