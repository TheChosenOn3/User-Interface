using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Entities1;
using Newtonsoft.Json;

namespace Controllers
{
   public class CardController
    {
        static HttpClient client;
        public static bool AddCard()
        {
            return true;

        }
        public static bool DeleteCard()
        {
            return true;
        }
        public static bool UpdateCard()
        {
            return true;
        }
        public static List<Card> RetrveCards(string userId)
        {
          

            //    string path = "http://localhost:49860/api/Card/";
            //    client = new HttpClient();
            //List<Card> cards = new List<Card>();
            ////string jsonString = JsonConvert.SerializeObject(us);
            //path += userId;
            //    var response = client.GetStringAsync(path).Result;
            //cards = (List<Card>)JsonConvert.DeserializeObject(response);
            //    return cards;
            //    //wegfs
            //    //ewfa
            //wesdf



       






            List<Card> UserCardList = new List<Card>();
            UserCardList.Add(new Card("262464", "EthanKilian", "321", DateTime.Now, "11111"));
            UserCardList.Add(new Card("2222", "EthanKilian", "222", DateTime.Now, "11111"));
            UserCardList.Add(new Card("33123", "EthanKilian", "111", DateTime.Now, "11111"));

            return UserCardList;
        }
    }
}
