using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using Newtonsoft.Json;

namespace Controllers
{
    public class UserController
    {
        public static bool checkLogin(int id)
        {
            HttpClient _client = new HttpClient();
            string url = "http://172.18.12.205/api/User/" + id;
            var returnVal = _client.GetStringAsync(url);

            bool randomnaam = (bool)JsonConvert.DeserializeObject(returnVal.Result);

            

            return randomnaam;
            
        }


    }
}
