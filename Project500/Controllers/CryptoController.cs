using System;
using System.Collections.Generic;
using System.Text;
using Entities1;
using System.Net.Http;


namespace Controllers
{

    public class CryptoController
    {
        public static string Control = "Crypto/";

        public static List<Crypto> GetCrypto(string Beneficiaryid)
        {
            return ControllerHandler<Crypto>.Search(Control + Beneficiaryid);
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
            return ControllerHandler<Crypto>.Update(upcryp, Control);
        }

    }
}
