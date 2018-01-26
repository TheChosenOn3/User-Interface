using System;
using System.Collections.Generic;
using System.Text;
using Entities1;

namespace Controllers
{
   public class BeneficiaryController
    {
        public void benben() {
            List<Beneficiary> BeneficiaryList = new List<Beneficiary>();
            List<PaymentAccount> BenCryptoList = new List<PaymentAccount>();
            List<PaymentAccount> BenEFTList = new List<PaymentAccount>();
            BeneficiaryList.Add(new Beneficiary("12324", "Sybrin", "pretoria"));
            BeneficiaryList.Add(new Beneficiary("1134", "EOH", "pretoria"));
            BeneficiaryList.Add(new Beneficiary("1345", "Emin", "pretoria"));
            BeneficiaryList.Add(new Beneficiary("12345", "Seop", "pretoria"));
            BeneficiaryList.Add(new Beneficiary("23423", "BC", "pretoria"));
            BenEFTList.Add(new PaymentAccount("09423", "Ethan", "EFTCheck", AccountTypes.Cheque, "12324", "12324"));
            BenEFTList.Add(new PaymentAccount("33333", "Daniel", "EFTCheck", AccountTypes.Cheque, "12324", "12324"));
            BenEFTList.Add(new PaymentAccount("11111", "Daniel", "EFTDebit", AccountTypes.Credit, "12324", "12324"));
            BenEFTList.Add(new PaymentAccount("0934", "Jason", "EFTDebit", AccountTypes.Credit, "1134", "12324"));
        }
    }
}
