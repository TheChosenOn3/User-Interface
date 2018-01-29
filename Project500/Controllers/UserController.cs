﻿using Entities1;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;

namespace Controllers
{
   public  class UserController
    {
        static HttpClient client;
        public static string path = Connection.url + "User/";
        public static User CheckLogin(string username, string pass)
        {
            client = new HttpClient();
            User _user = null;
            path += username + "/" + pass;
            var response = client.GetStringAsync(path).Result;
            _user = (User)JsonConvert.DeserializeObject<User>(response);

            return _user;

        }

        public static bool registerUser(User newUser)
        {
            HttpClient _client = new HttpClient();
            string jsonString = JsonConvert.SerializeObject(newUser);
            var content = new StringContent(jsonString, Encoding.UTF8, "application/json");
            HttpResponseMessage someVar = _client.PostAsync(path, content).Result;//handle if resonse codes fail
            if (someVar.IsSuccessStatusCode)
            {
                return true;//User Added to DB successfuly
            }
            return false;//something went wrong
        }
        public static bool UpdateUser(User newUser)
        {

            return true;//something went wrong
            //awe
        }
        
       public static List<User> GetUser()
        {
            List<User> a = new List<User>();

            return a;//something went wrong
            //awe
        }











    }
}
