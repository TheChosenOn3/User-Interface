using Entities1;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;

namespace Controllers
{
    public class UserController
    {
        public static string Control = "User/";
        static HttpClient client;
        public static string path = Connection.url + "User/";

        public static User CheckLogin(string username, string pass)
        {
            path = Connection.url + "User/";
            client = new HttpClient();
            User _user = null;
            path += username + "/" + pass;
            var response = client.GetStringAsync(path).Result;
            _user = (User)JsonConvert.DeserializeObject<User>(response);

            return _user;
        }


        public static User CheckEmailExist(string username, string pass)
        {
            path = Connection.url + "User/";
            client = new HttpClient();
            User _user = null;
            //path += username;
            var response = client.GetStringAsync(path + username + "/").Result;
            bool Exists = JsonConvert.DeserializeObject<bool>(response);

            if (Exists)
            {
                _user = CheckLogin(username, pass);
                return (_user.RsaID == null) ? new User { Email = username } : _user;
            }
            else
            {
                return new User();
            }

        }


        public static bool registerUser(User newUser)
        {
            return ControllerHandler<User>.Insert(newUser, Control);
        }
        public static bool UpdateUser(User newUser)
        {
            return ControllerHandler<User>.Update(newUser, Control);
        }

    }
}




