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
        public static string Control = "Card/";

        public static bool AddCard(Card newcard)
        {
            return ControllerHandler<Card>.Insert(newcard, Control);
        }
        public static bool DeleteCard(string CardNum)
        {
            return ControllerHandler<Card>.Delete(Control + CardNum);
        }
        public static bool UpdateCard(Card UpCard)
        {
            return ControllerHandler<Card>.Update(UpCard, Control);
        }
        public static List<Card> RetrveCards(string userId)
        {
            return ControllerHandler<Card>.Search(Control + userId);
        }
    }
}
