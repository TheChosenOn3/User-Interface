using Entities1;
using System;
using System.Collections.Generic;
using System.Text;

namespace Controllers
{
   public  class HistoryController
    {
        static string Control = "History/";
        public static List<History> getHistory(string id)
        {
            return ControllerHandler<History>.Search(Control + id);
        }
    }
}
