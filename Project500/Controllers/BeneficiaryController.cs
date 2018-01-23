using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using BusinessEntities;
using Newtonsoft.Json;

namespace Controllers
{
  public  class BeneficiaryController
    {
       public static void addBeneficiary(Beneficiary ben)
        {
            //  HttpClient _client = "localhost"\
            Beneficiary piele = new Beneficiary( "a");
            HttpClient _client = new HttpClient();

            var hjallo = JsonConvert.SerializeObject(ben);
            ///setv as conmtet buddum.......

            var deser = JsonConvert.DeserializeObject<Beneficiary>(hjallo);
            _client.PostAsync("", hjallo);

        }
        public static void addBeneficiary(Beneficiary ben)
        {
          

        }



    }
}
