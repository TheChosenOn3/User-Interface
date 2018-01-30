using System;
using System.Collections.Generic;
using System.Text;
using Entities1;
using System.Net.Http;
using Controllers;
using Newtonsoft.Json;

namespace Controllers
{

    public class BeneficiaryController
    {
        public static string Control = "Beneficiary/";

        public static List<Beneficiary> GetBeneficiarys(string UserId)
        {
            return ControllerHandler<Beneficiary>.Search(Control + UserId);
        }

        public static bool AddBeneficiary(Beneficiary beneficairy)
        {
            return ControllerHandler<Beneficiary>.Insert(beneficairy, Control);
        }

        public static bool UpdateBeneficiary(Beneficiary beneficairy)
        {
            return ControllerHandler<Beneficiary>.Update(beneficairy, Control);
        }

        public static bool DeleteBeneficiary(string beneficairyId)
        {
            return ControllerHandler<Beneficiary>.Delete(Control + beneficairyId);
        }
    }




}
