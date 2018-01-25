using System;
using System.Collections.Generic;
using System.Text;

namespace Entities1
{
   public enum AccountTypes
    {
        Savings=1,Cheque,Credit
    }
    public class PaymentAccount
    {
        private string accountNumber;

        public string AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }

        private string accountHolder;

        public string AccountHolder
        {
            get { return accountHolder; }
            set { accountHolder = value; }
        }
        private string reference;

        public string Reference
        {
            get { return reference; }
            set { reference = value; }
        }
        private AccountTypes typeAcc;

      

        public AccountTypes TypeAcc
        {
            get { return typeAcc; }
            set { typeAcc = value; }
        }

        string beneficiaryID;
        public string BeneficiaryID { get => beneficiaryID; set => beneficiaryID = value; }

        

        public PaymentAccount(string AccountNumber, string AccountHolder, string Reference, AccountTypes TypeAcc,string BeneficiaryID)
        {
            this.accountNumber = AccountNumber;
            this.accountHolder = AccountHolder;
            this.reference = Reference;
            this.typeAcc = TypeAcc;
            this.beneficiaryID = BeneficiaryID;
        }

        public PaymentAccount()
        {

        }





    }
}
