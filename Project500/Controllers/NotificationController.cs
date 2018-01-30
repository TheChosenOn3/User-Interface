using Entities1;
using System;
using System.Collections.Generic;
using System.Text;

namespace Controllers
{
   public class NotificationController
    {
        static string Control = "Notification";
        public static List<Notification> getNotifications(string UserID)
        {
            return ControllerHandler<Notification>.Search(Control + UserID);
        }
    }
}
