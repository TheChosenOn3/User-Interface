using System;
using System.Collections.Generic;
using System.Text;

namespace Entities1
{
   public class Beneficiary
    {
        string Id;
        private string beneficiaryID;

        public string BeneficairyID
        {
            get { return beneficiaryID; }
            set { beneficiaryID = value; }
        }
        private string beneficiaryName;

        public string BeneficairyName
        {
            get { return beneficiaryName; }
            set { beneficiaryName = value; }
        }
        private string beneficiaryBranch;

        public string BeneficiaryBranch
        {
            get { return beneficiaryBranch; }
            set { beneficiaryBranch = value; }
        }

        public string Id1 { get => Id; set => Id = value; }

        public Beneficiary(string BeneficairyID, string BeneficairyName, string BeneficiaryBranch)
        {
            this.beneficiaryBranch = BeneficiaryBranch;
            this.beneficiaryID = BeneficairyID;
            this.beneficiaryName = BeneficairyName;


        }
        public Beneficiary()
        {

        }




    }
}
