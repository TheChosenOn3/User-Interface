using System;
using System.Collections.Generic;
using System.Text;
using Entities1;
using System.Net.Http;


namespace Controllers
{
  
   public class CryptoController
    {
        static HttpClient client;

        public static List<Crypto> GetCrypto(string Beneficiaryid) {
            List<Crypto> BenCryptoList = new List<Crypto>();
            BenCryptoList.Add(new Crypto("BenCrypto1", "34567898765", "12324"));
            BenCryptoList.Add(new Crypto("BenCrypto2", "456787568", "12324"));
            BenCryptoList.Add(new Crypto("BenCrypto3", "876e5748545", "1134"));
            BenCryptoList.Add(new Crypto("BenCrypto4", "768r6587997", "12324"));
            BenCryptoList.Add(new Crypto("BenCrypto4", "768r6587997", "12324"));
            return BenCryptoList;
        }
        public static bool DeleteCrypto(string crypid) {
            return true;

        }
        public static bool AddCrypto(Crypto newcryp)
        {
            return true;

        }
        public static bool UpateCrypto(Crypto upcryp)
        {
            return true;

        }

    }
}
