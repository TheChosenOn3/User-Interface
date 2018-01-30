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
        

        static HttpClient client;
        public static string path = Connection.url + "Beneficiary/";

        public static List<Beneficiary> GetBeneficiarys(string UserId)
        {
            // putq iff to check if the list is enpty
            // putq iff to check if the list is enpty
            // putq iff to check if the list is enpty
            // putq iff to check if the list is enpty
            // putq iff to check if the list is enpty
            List<Beneficiary> BeneficiaryList = new List<Beneficiary>();
            client = new HttpClient();
           // path += UserId;

            try
            {
                var response = client.GetStringAsync(path+UserId).Result;
                BeneficiaryList = (List<Beneficiary>)JsonConvert.DeserializeObject<List<Beneficiary>>(response);
            }
            catch (Exception)
            {
                BeneficiaryList = new List<Beneficiary>();
            }

            return BeneficiaryList;
        }

        public static bool AddBeneficiary(Beneficiary beneficairy)
        {
            HttpClient _client = new HttpClient();
            string jsonString = JsonConvert.SerializeObject(beneficairy);
            var content = new StringContent(jsonString, Encoding.UTF8, "application/json");
            HttpResponseMessage someVar = _client.PostAsync(path, content).Result;//handle if resonse codes fail
            if (someVar.IsSuccessStatusCode)
            {
                return true;//Beneficiary Added to DB successfuly
            }
            return false;//something went wrong

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
