using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Controllers
{
    class ControllerHandler<T>
    {

        private static volatile ControllerHandler<T> instance;
        private static object syncRoot = new Object();

        private ControllerHandler() { }

        public static ControllerHandler<T> Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new ControllerHandler<T>();
                    }
                }
                return instance;
            }
        }
        public static string path = Connection.url;
        static HttpClient client;
        public static bool Delete(string control)
        {
            HttpClient _client = new HttpClient();

            HttpResponseMessage someVar = _client.DeleteAsync(path + control).Result;//handle if resonse codes fail
            if (someVar.IsSuccessStatusCode)
            {
                return true;//Deleted successfuly
            }
            return false;//something went wrong
        }

        public static bool Update(T obj, string control)
        {
            HttpClient _client = new HttpClient();
            string jsonString = JsonConvert.SerializeObject(obj);
            var content = new StringContent(jsonString, Encoding.UTF8, "application/json");
            HttpResponseMessage someVar = _client.PutAsync(path + control, content).Result;//handle if resonse codes fail
            if (someVar.IsSuccessStatusCode)
            {
                return true;//Added to DB successfuly
            }
            return false;//something went wrong
        }
        public static bool Insert(T obj, string control)
        {
            HttpClient _client = new HttpClient();
            string jsonString = JsonConvert.SerializeObject(obj);
            var content = new StringContent(jsonString, Encoding.UTF8, "application/json");
            HttpResponseMessage someVar = _client.PostAsync(path + control, content).Result;//handle if resonse codes fail
            if (someVar.IsSuccessStatusCode)
            {
                return true;//Added to DB successfuly
            }
            return false;//something went wrong

        }

        public static List<T> Search(string control)
        {
            List<T> list = new List<T>();
            client = new HttpClient();
            var response = client.GetStringAsync(path + control).Result;
            list = JsonConvert.DeserializeObject<List<T>>(response);

            return list;
        }




    }

}
