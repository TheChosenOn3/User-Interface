using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessEntities
{
   public class Beneficiary
    {
        private string sname;

        public string SName
        {
            get { return sname; }
            set { sname = value; }
        }
        public Beneficiary(string sname)
        {
            this.sname = sname;
        }

    }
}
