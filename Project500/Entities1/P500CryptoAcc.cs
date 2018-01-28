using System;
using System.Collections.Generic;
using System.Text;

namespace Entities1
{
    class P500CryptoAcc
    {
        string Waletname = "BTCACC";
        float Waletammount = 1234;
        string WalletID = "234567890";

        public string Waletname1 { get => Waletname; set => Waletname = value; }
        public float Waletammount1 { get => Waletammount; set => Waletammount = value; }
        public string WalletID1 { get => WalletID; set => WalletID = value; }
        public P500CryptoAcc(string Waletname1, float Waletammount1, string WalletID1)
        {
            this.WalletID = WalletID1;
            this.Waletammount = Waletammount1;
            this.Waletname = Waletname1;
        }
        public P500CryptoAcc()
        {

        }
    

    }
}
