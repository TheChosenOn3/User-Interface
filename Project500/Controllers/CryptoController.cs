using System;
using System.Collections.Generic;
using System.Text;
using Entities1;
using System.Net.Http;
using Newtonsoft.Json;

namespace Controllers
{

    public class CryptoController
    {
        public static string Control = "Crypto/";
        static HttpClient client;
        public static string path = Connection.url + "Crypto/";

        public static List<Crypto> GetCrypto(string Beneficiaryid)
        {
            return ControllerHandler<Crypto>.Search(Control + Beneficiaryid);
        }
        public static Crypto GetUserCrypto(string UserId)
        {// edit shit
            client = new HttpClient();
            Crypto crypt = null; 
            var response = client.GetStringAsync(path + UserId).Result;
            crypt = (Crypto)JsonConvert.DeserializeObject<Crypto>(response);

            return crypt;
        }


        

        public static bool DeleteCrypto(string crypid)
        {
            return ControllerHandler<Crypto>.Delete(Control + crypid);
        }
        public static bool AddCrypto(Crypto newcryp)
        {
            return ControllerHandler<Crypto>.Insert(newcryp, Control);
        }
        public static bool UpateCrypto(Crypto upcryp)
        {
            upcryp.UserId = null;
            return ControllerHandler<Crypto>.Update(upcryp, Control);
        }

        public static bool UpateUserCrypto(Crypto upcryp)
        {
            upcryp.BeneficiaryId = null;
            return ControllerHandler<Crypto>.Update(upcryp, Control);
        }

    }
}
