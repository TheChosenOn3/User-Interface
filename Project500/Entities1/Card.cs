using System;
using System.Collections.Generic;
using System.Text;

namespace Entities1
{
  public  class Card
    {
        string Id;
        private string cardNr;
        string userId;
        public string CardNr
        {
            get { return cardNr; }
            set { cardNr = value; }
        }
        private string accountHolder;

        public string AccountHolder
        {
            get { return accountHolder; }
            set { accountHolder = value; }
        }

        private string cvv;

        public string Cvv
        {
            get { return cvv; }
            set { cvv = value; }
        }

        private DateTime expiry;

        public DateTime Expiry
        {

            get { return expiry; }
            set { expiry = value; }
        }

        public string Id1 { get => Id; set => Id = value; }
        public string UserId { get => userId; set => userId = value; }

        public Card(string CardNr, string AccountHolder, string Cvv, DateTime Expiry,string UseId)
        {
            this.cardNr = CardNr;
            this.accountHolder = AccountHolder;
            this.cvv = Cvv;
            this.expiry = Expiry;
            this.userId = UserId;

        }




        public Card()
        {
                
        }





    }
}
