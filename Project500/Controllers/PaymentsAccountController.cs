using System;
using System.Collections.Generic;
using System.Text;
using Entities1;

namespace Controllers
{
  public  class PaymentsAccountController
    {
        public  static bool AddAcount() {
            return true;

        }
        public static bool DeleteAcount()
        {
            return true;
        }
        public static bool UpdateAcount()
        {
            return true;
        }
        public static List<PaymentAccount> RetrveAcounts(string userId)
        {
            List<PaymentAccount> UserEFTList = new List<PaymentAccount>();
            UserEFTList.Add(new PaymentAccount("09423", "Ethan", "EFTCheck", AccountTypes.Cheque, "11111", "11111"));
            UserEFTList.Add(new PaymentAccount("33333", "Ethan", "EFTCheck", AccountTypes.Cheque, "11111", "11111"));
            UserEFTList.Add(new PaymentAccount("11111", "Ethan", "EFTDebit", AccountTypes.Credit, "11111", "11111"));
            UserEFTList.Add(new PaymentAccount("0934", "Ethan", "EFTDebit", AccountTypes.Credit, "11111", "11111"));
            return UserEFTList;
        }
        
    }
}
