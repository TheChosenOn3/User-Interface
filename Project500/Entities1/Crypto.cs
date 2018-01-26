using System;
using System.Collections.Generic;
using System.Text;

namespace Entities1
{
    public class Crypto
    {
        string Id;
        string waletaddress;
        string waletName;
        string amount;
        string beneficiaryId;
        string userId;

     
        public string WaletName { get => waletName; set => waletName = value; }
        public string Amount { get => amount; set => amount = value; }
        public string BeneficiaryId { get => beneficiaryId; set => beneficiaryId = value; }
        public string UserId { get => userId; set => userId = value; }
        public string Waletaddress { get => waletaddress; set => waletaddress = value; }
        public string Id1 { get => Id; set => Id = value; }

        public Crypto()
        {
                
        }
        public Crypto(string WaletName, string Waletaddress, string BeneficiaryId)
        {
            this.waletaddress = WaletName;
            this.waletaddress = Waletaddress;
            this.amount = Amount;
            this.userId = UserId;
            this.beneficiaryId = BeneficiaryId;
        }
    }
}
