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
        string userId;
        public string Id1 { get => Id; set => Id = value; }
        public string UserId { get => userId; set => userId = value; }

        public Beneficiary(string BeneficairyID, string BeneficairyName, string BeneficiaryBranch,string UserId)
        {
            this.beneficiaryBranch = BeneficiaryBranch;
            this.beneficiaryID = BeneficairyID;
            this.beneficiaryName = BeneficairyName;
            this.userId = UserId;


        }
        public Beneficiary()
        {

        }




    }
}
