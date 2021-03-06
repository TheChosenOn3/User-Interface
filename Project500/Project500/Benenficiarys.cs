﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities1;
using Controllers;
using MetroFramework;

    

namespace Project500
{
    public partial class Benenficiarys : MetroFramework.Forms.MetroForm
    {
     
        
        
        List<Beneficiary> BeneficiaryList = new List<Beneficiary>();
        List<Beneficiary> BeneficiaryListS = new List<Beneficiary>();
        List<Crypto> BenCryptoList = new List<Crypto>();
        List<Crypto> BenCryptoListS = new List<Crypto>();
        Beneficiary ben = new Beneficiary();
        Crypto cryptotemp = new Crypto();
        Crypto crypto = new Crypto();
        List<PaymentAccount> BenEFTList = new List<PaymentAccount>();
        List<PaymentAccount> BenEFTListS = new List<PaymentAccount>();
        PaymentAccount EFTtemp = new PaymentAccount();
        PaymentAccount EFT = new PaymentAccount();
        User user = new User();

        string BenName = "";
        string BenId = "";
        string BenBranchCode = "";



        public Benenficiarys(User _user)
        {
            user = _user;
            InitializeComponent();
            btnProfileImage.Text = " " + user.Name;
        }
        public Benenficiarys()
        {
            InitializeComponent();
           

        }

        private void Benenficiarys_Load(object sender, EventArgs e)
        {
            BeneficiaryList = BeneficiaryController.GetBeneficiarys(user.RsaID);
            FillBeneficiaryDatagrid(BeneficiaryList);
          
        }

   
        public void FillBeneficiaryDatagrid(List<Beneficiary> BenDataGridList) {

            DataTable bentable = ConvertListToDataTable(BenDataGridList);
            dgvBeneficiary.DataSource = bentable;

            DataTable ConvertListToDataTable(List<Beneficiary> benlist)
            {
                DataTable table = new DataTable();
                table.Columns.Add("Beneficairy Nme");
                table.Columns.Add("Beneficiary Branch");

                foreach (Beneficiary item in benlist)
                {
                    table.Rows.Add(item.BeneficairyName, item.BeneficiaryBranch);
                }
                return table;
            }

        }
        
        public void FillCryptoDatagrid(List<Crypto> selectedben)
        {

            BenCryptoListS = BenCryptoList;
        
        
            DataTable Cryptable = ConvertListToDataTable(BenCryptoList);
            dgvCrypto.DataSource = Cryptable;
            DataTable ConvertListToDataTable(List<Crypto> cryplist)
            {
                DataTable table = new DataTable();
                table.Columns.Add("Walet Name");
                table.Columns.Add("Walet Address");
                foreach (Crypto item in cryplist)
                {
                    
                    table.Rows.Add(item.WaletName, item.Waletaddress);
                }
                return table;
            }
        }
        // method to populate eft datagrid of beneficiary
        public void FillEFTDatagrid(List<PaymentAccount> selectedben)
        {


            //  BenEFTListS = PaymentsAccountController.SearchBenPaymentAcount(selectedben.BeneficairyID);
            BenEFTListS = BenEFTList;

            DataTable EFTtable = ConvertListToDataTable(BenEFTList);
            dgvEFT.DataSource = EFTtable;
            DataTable ConvertListToDataTable(List<PaymentAccount> Acclist)
            {
                DataTable table = new DataTable();
                table.Columns.Add("Account Number");
                table.Columns.Add("Account Holder");
                table.Columns.Add("Reference");
                table.Columns.Add("Account Type");
                foreach (PaymentAccount item in Acclist)
                {
                    
                    table.Rows.Add(item.AccountNumber, item.AccountHolder, item.Reference, item.TypeAcc);
                }
                return table;
            }

        }

        public void ClearBens() {
       
            txtBName.Text = "";
            txtBID.Text = "";
            txtBBranchCode.Text = "";
            txtEFTAccNum.Text = "";
            txtEFTRefernce.Text = "";
            txtWaletName.Text = "";
            txtWalletCode.Text = "";
            txtAccHolder.Text = "";
            cbEFTAccType.SelectedIndex = -1;
            ben = null;
            dgvEFT.DataSource = null;
            dgvCrypto.DataSource = null;
            btnUpdateBPI.Visible = false;
            btnUpdateEFT.Visible = false;
            btnUpdateCrypto.Visible = false;
            BtnDeletCrypto.Visible = false;
            btnDeletEFT.Visible = false;
            btnDeleteB.Visible = false;
            lblAdditionalInfo.Visible = false;



        }
        private void txtBID_Click(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
           
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
        }

        private void btnScheduel_Click(object sender, EventArgs e)
        {
        
        }

        private void btnBeneficiary_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSeachB_Click(object sender, EventArgs e)
        {
            BeneficiaryList = BeneficiaryController.GetBeneficiarys(user.RsaID);

            List<Beneficiary> SearchList = new List<Beneficiary>();            

            foreach (Beneficiary item in BeneficiaryList)
            {
                if (item.BeneficairyName.IndexOf(txtSearchBName.Text.Trim(), StringComparison.CurrentCultureIgnoreCase) != -1)
                {
                    SearchList.Add(item);
                }
            }

            BeneficiaryList = SearchList;

            FillBeneficiaryDatagrid(SearchList);
            
        }

        private void dgvBeneficiary_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
            int index = e.RowIndex;
            ben = BeneficiaryList[index];
         


       
            txtBName.Text = ben.BeneficairyName;
            txtBID.Text = ben.BeneficairyID;
            txtBBranchCode.Text = ben.BeneficiaryBranch;
          

        }

        private void btnDeleteB_Click(object sender, EventArgs e)
        {
            BeneficiaryController.DeleteBeneficiary(ben.BeneficairyID);
            BeneficiaryList.Remove(ben);
            FillBeneficiaryDatagrid(BeneficiaryList);
            ClearBens();
        }

        private void btnAddB_Click(object sender, EventArgs e)
        {
            bool go = false;

            if (txtBID.Text.Equals(""))
            {
                txtBID.Text = Guid.NewGuid().ToString("N");
            }

            foreach (Beneficiary item in BeneficiaryList)
            {
                if (txtBID.Text.Trim() == item.BeneficairyID)
                {
                    go = true;
                    break;
                }
            }

            if (go == false)
            {
                Beneficiary benAdd = new Beneficiary(txtBID.Text.Trim(), txtBName.Text.Trim(), txtBBranchCode.Text.Trim(), user.RsaID);
                BeneficiaryList.Add(benAdd);
                ClearBens();
                BeneficiaryController.AddBeneficiary(benAdd);
                FillBeneficiaryDatagrid(BeneficiaryList);
                
            }
            else
            {
                MetroMessageBox.Show(this, "Beneficiary With Your Specified ID, Already Exists!", "Beneficiary ID In Use");
            }
        }

       

        

        private void btnClearBPI_Click(object sender, EventArgs e)
        {
            txtBName.Text = "";
            txtBID.Text = "";
            txtBBranchCode.Text = "";
            lblAdditionalInfo.Visible = true;
        }

        private void btnUpdateBPI_Click(object sender, EventArgs e)
        {
            bool go = false;
             Beneficiary Benn = new Beneficiary();
            foreach (Beneficiary item in BeneficiaryList)
            {
                if (item.BeneficairyID == txtBID.Text.Trim())
                {
                    BeneficiaryList.Remove(item);
                    Benn = new Beneficiary(txtBID.Text, txtBName.Text, txtBBranchCode.Text, user.RsaID);
                    BeneficiaryList.Add(Benn);
                    BeneficiaryController.UpdateBeneficiary(Benn);
                    txtBName.Text = "";
                    txtBID.Text = "";
                    txtBBranchCode.Text = "";
                    FillBeneficiaryDatagrid(BeneficiaryList);
                    ClearBens();
                    go = true;
                    break;

                }

            }
            if (go != true)
            {
                MetroMessageBox.Show(this, "The Account You're Trying to Update Does Not Exist!", "Account Does Not Exist");
            }


        }

        private void dgvCrypto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
            
        }

        private void btnAddCrypto_Click(object sender, EventArgs e)
        {

            bool go = false;
            foreach (Crypto item in BenCryptoList)
            {
                if (txtWalletCode.Text.Trim() == item.Waletaddress)
                {
                    go = true;
                    break;
                }
            }
            if (go == false)
            {
                Crypto crypto = new Crypto(txtWaletName.Text.Trim(), txtWalletCode.Text.Trim(),0,ben.BeneficairyID,"");
                BenCryptoList.Add(crypto);
                CryptoController.AddCrypto(crypto);
                FillCryptoDatagrid(BenCryptoList);
                txtWaletName.Text = "";
                txtWalletCode.Text = "";
               
            }
            else
            {
                MetroMessageBox.Show(this, "Account Already Exists!", "Account Exists");
            }

        }

        private void btnUpdateEFT_Click(object sender, EventArgs e)
        {
            bool go = false;
            PaymentAccount eftup = new PaymentAccount();
            foreach (PaymentAccount item in BenEFTList)
            {
                if (txtEFTAccNum.Text == item.AccountNumber)
                {
                    BenEFTList.Remove(item);
                    AccountTypes Acounttype = new AccountTypes();
                    switch (cbEFTAccType.SelectedIndex)
                    {
                        case 0:
                            Acounttype = AccountTypes.Savings;
                            break;
                        case 1:
                            Acounttype = AccountTypes.Cheque;
                            break;
                        case 2:
                            Acounttype = AccountTypes.Credit;
                            break;
                        default:
                            break;
                    } PaymentsAccountController.UpdateBenPaymentAcount(new PaymentAccount(txtEFTAccNum.Text.Trim(), txtAccHolder.Text.Trim(), txtEFTRefernce.Text.Trim(), Acounttype, ben.BeneficairyID, ""));
                    BenEFTList.Remove(item);
                    BenEFTList.Add(new PaymentAccount(txtEFTAccNum.Text.Trim(), txtAccHolder.Text.Trim(), txtEFTRefernce.Text.Trim(), Acounttype, ben.BeneficairyID, ""));
                    FillEFTDatagrid(BenEFTList);
                    txtEFTAccNum.Text = "";
                    txtAccHolder.Text = "";
                    txtEFTRefernce.Text = "";
                    cbEFTAccType.SelectedIndex = -1;

                      go = true;
                    break;
                }
            }
            if (go != true)
            {
                MetroMessageBox.Show(this, "The Account You're Trying to Update Does Not Exist!", "Account Does Not Exist");

            }
        }

        private void btnClearCrypto_Click(object sender, EventArgs e)
        {
            txtWaletName.Text = "";
            txtWalletCode.Text = "";
       

        }

        private void BtnDeletCrypto_Click(object sender, EventArgs e)
        {
            
            CryptoController.DeleteCrypto(crypto.BeneficiaryId);
            BenCryptoList.Remove(crypto);
            BenCryptoListS.Remove(crypto);
            FillCryptoDatagrid(BenCryptoList);


        }

        private void btnClearEFT_Click(object sender, EventArgs e)
        {
            txtAccHolder.Text = "";
            txtEFTAccNum.Text = "";
            txtEFTRefernce.Text = "";
            cbEFTAccType.SelectedIndex = -1;
        }

        private void dgvEFT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtAccHolder.Text = EFT.AccountHolder;
            txtEFTAccNum.Text = EFT.AccountNumber;
            txtEFTRefernce.Text = EFT.Reference;
          


        }

        private void btnAddEFT_Click(object sender, EventArgs e)
        {
            bool go = false;
            foreach (PaymentAccount item in BenEFTList)
            {
                if (txtEFTAccNum.Text.Trim() == item.AccountNumber)
                {
                    go = true;
                    break;
                }
            }
            if (go == false)
            {
                AccountTypes Acounttype = new AccountTypes();
                switch (cbEFTAccType.SelectedIndex)
                {
                    case 0:
                        Acounttype = AccountTypes.Savings;
                        break;
                    case 1:
                        Acounttype = AccountTypes.Cheque;
                        break;
                    case 2:
                        Acounttype = AccountTypes.Credit;
                        break;
                    default:
                        break;
                }
                EFT = new PaymentAccount(txtEFTAccNum.Text.Trim(), txtAccHolder.Text.Trim(), txtEFTRefernce.Text.Trim(), Acounttype, ben.BeneficairyID,"");
                
                PaymentsAccountController.AddBenPaymentAcount(EFT);
                BenEFTList.Add(EFT);
                FillEFTDatagrid(BenEFTList);
                txtEFTAccNum.Text = "";
                txtAccHolder.Text = "";
                txtEFTRefernce.Text = "";
                cbEFTAccType.SelectedIndex = -1;
            }
            else
            {
                MetroMessageBox.Show(this, "Account Already Exists!", "Account Exists");
            }

        }

        private void btnDeletEFT_Click(object sender, EventArgs e)
        {
            txtAccHolder.Text = "";
            txtEFTAccNum.Text = "";
            txtEFTRefernce.Text = "";
            cbEFTAccType.SelectedIndex = -1;
            PaymentsAccountController.DeleteBenPaymentAcount(EFT.BeneficiaryID);
            BenEFTList.Remove(EFT);
            BenEFTListS.Remove(EFT);
            FillEFTDatagrid(BenEFTList);
        
        }

        private void tabBeneficiary_Click(object sender, EventArgs e)
        {

        }

        private void lblBeneficiaryDetails_Click(object sender, EventArgs e)
        {

        }

        private void txtAccHolder_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel24_Click(object sender, EventArgs e)
        {

        }

        private void btnHomeNew_Click(object sender, EventArgs e)
        {
            Main main = new Main(user);
            this.Hide();
            main.Show();
        }

        private void btnPaymentNew_Click(object sender, EventArgs e)
        {
            Payments payments = new Payments(user);
            this.Hide();
            payments.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile(user);
            this.Hide();
            profile.Show();
        }

        private void btnHistoryNew_Click(object sender, EventArgs e)
        {
            History history = new History(user);
            this.Hide();
            history.Show();

        }

        private void btnBeneficiaryNew_Click(object sender, EventArgs e)
        {
            Benenficiarys beneficiarys = new Benenficiarys(user);
            this.Hide();
            beneficiarys.Show();
        }

        private void btnScheduleNew_Click(object sender, EventArgs e)
        {
            Schedules scheduels = new Schedules(user);
            this.Hide();
            scheduels.Show();
        }

        private void btnSeAllBeneficairys_Click(object sender, EventArgs e)
        {
            BeneficiaryList = BeneficiaryController.GetBeneficiarys(user.RsaID);
            FillBeneficiaryDatagrid(BeneficiaryList);
            
        }

        private void dgvBeneficiary_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
          

        }

        private void dgvEFT_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void dgvCrypto_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnUpdateCrypto_Click(object sender, EventArgs e)
        {
            bool go = false;
            Crypto crypto = new Crypto();
            foreach (Crypto item in BenCryptoList)
            {
                if (txtWalletCode.Text == item.Waletaddress)
                {
                    BenCryptoList.Remove(item);
                    BenCryptoList.Add(new Crypto(txtWaletName.Text.Trim(), txtWaletName.Text.Trim(),0,ben.BeneficairyID,""));
                    CryptoController.UpateCrypto(crypto);

                    FillCryptoDatagrid(BenCryptoList);
                    txtWaletName.Text = "";
                    txtWalletCode.Text = "";

                      go = true;
                    break;
                }
            }
            if (go != true)
            {
                MetroMessageBox.Show(this, "The Account You're Trying to Update Does Not Exist!", "Account Does Not Exist");

            }
        }

        private void metroLabel28_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you wish to exit this application?", "Exit Project 500", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Login LoginForm = new Login();
                LoginForm.Show();
                this.Hide();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvBeneficiary_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            ben = BeneficiaryList[index];


           

            txtBBranchCode.Text = ben.BeneficiaryBranch;
            txtBID.Text = ben.BeneficairyID;
            txtBName.Text = ben.BeneficairyName;
            BenCryptoList = CryptoController.GetCrypto(ben.BeneficairyID);
            BenEFTList = PaymentsAccountController.SearchBenPaymentAcount(ben.BeneficairyID);

            FillCryptoDatagrid(BenCryptoList);
            FillEFTDatagrid(BenEFTList);
            btnUpdateBPI.Visible = true;
            btnDeleteB.Visible = false;
        }

        private void dgvEFT_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            EFTtemp = BenEFTListS[index];
            foreach (PaymentAccount item in BenEFTList)
            {
                if (EFTtemp == item)
                {
                    EFT = item;
                }

            }
            switch (EFT.TypeAcc)
            {
                case AccountTypes.Savings:
                    cbEFTAccType.SelectedIndex = 0;
                    break;
                case AccountTypes.Cheque:
                    cbEFTAccType.SelectedIndex = 1;
                    break;
                case AccountTypes.Credit:
                    cbEFTAccType.SelectedIndex = 2;
                    break;
                default:
                    break;
            }
            txtAccHolder.Text = EFT.AccountHolder;
            txtEFTAccNum.Text = EFT.AccountNumber;
            txtEFTRefernce.Text = EFT.Reference;
            btnUpdateEFT.Visible = true;
            btnDeletEFT.Visible = true;
        }

        private void dgvCrypto_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            cryptotemp = BenCryptoListS[index];
            foreach (Crypto item in BenCryptoList)
            {
                if (cryptotemp == item)
                {
                    crypto = item;
                }

            }
            txtWaletName.Text = crypto.WaletName;
            txtWalletCode.Text = crypto.Waletaddress;
            BtnDeletCrypto.Visible = true;
            btnUpdateCrypto.Visible = true;
        }
    }
}
