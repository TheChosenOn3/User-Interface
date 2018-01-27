using System;
using System.Collections.Generic;
using System.Text;
using Entities1;
using System.Net.Http;


namespace Controllers
{
   
    public class BeneficiaryController
    {
        static HttpClient client;

        public static List<Beneficiary> GetBeneficiarys(string UserId)
        {
            List<Beneficiary> BeneficiaryList = new List<Beneficiary>();
            BeneficiaryList.Add(new Beneficiary("12324", "Sybrin", "pretoria", "1234"));
            BeneficiaryList.Add(new Beneficiary("1134", "EOH", "pretoria", "1234"));
            BeneficiaryList.Add(new Beneficiary("1345", "Emin", "pretoria", "1234"));
            BeneficiaryList.Add(new Beneficiary("12345", "Seop", "pretoria", "1234"));
            BeneficiaryList.Add(new Beneficiary("23423", "BC", "pretoria", "1234"));
            return BeneficiaryList;
        }

        public static bool AddBeneficiary(Beneficiary beneficairy) {
            return true;

        }
        public static bool UpdateBeneficiary(Beneficiary beneficairy)
        {
            return true;

        }
        public static bool DeleteBeneficiary(string beneficairyId)
        {
            return true;

        }
    }
}
