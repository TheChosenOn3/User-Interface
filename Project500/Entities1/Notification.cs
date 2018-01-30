using System;
using System.Collections.Generic;
using System.Text;

namespace Entities1
{
   public class Notification
    {
        public string Id { get; set; }
        private string notID;

        public string NotID
        {
            get { return notID; }
            set { notID = value; }
        }
        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        private string dateChange;

        public string DateChange
        {
            get { return dateChange; }
            set { dateChange = value; }
        }
        private string userID;

        public string UserID
        {
            get { return userID; }
            set { userID = value; }
        }





    }
}
