using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities1;

    

namespace Project500
{
    public partial class Benenficiarys : MetroFramework.Forms.MetroForm
    {
     
        
        
        List<Beneficiary> BeneficiaryList = new List<Beneficiary>();
        List<PaymentAccount> BenCryptoList = new List<PaymentAccount>();
        Beneficiary ben = new Beneficiary();
        PaymentAccount Crypto = new PaymentAccount();
        List<PaymentAccount> BenEFTList = new List<PaymentAccount>();
        PaymentAccount EFT = new PaymentAccount();
     
       

        public Benenficiarys()
        {
            InitializeComponent();
            //demo population
            BeneficiaryList.Add(new Beneficiary("12324", "Sybrin", "pretoria"));
            BeneficiaryList.Add(new Beneficiary("1134", "EOH", "pretoria"));
            BeneficiaryList.Add(new Beneficiary("1345", "Emin", "pretoria"));
            BeneficiaryList.Add(new Beneficiary("12345", "Seop", "pretoria"));
            BeneficiaryList.Add(new Beneficiary("23423", "BC", "pretoria"));
            BenEFTList.Add(new PaymentAccount("09423","Ethan","EFTCheck", AccountTypes.Cheque, "12324"));
            BenEFTList.Add(new PaymentAccount("33333", "Daniel", "EFTCheck", AccountTypes.Cheque, "12324"));
            BenEFTList.Add(new PaymentAccount("11111", "Daniel", "EFTDebit", AccountTypes.Credit, "12324"));
            BenEFTList.Add(new PaymentAccount("0934", "Jason", "EFTDebit", AccountTypes.Credit, "1134"));

        }

        private void Benenficiarys_Load(object sender, EventArgs e)
        {
           
            FillBeneficiaryDatagrid(BeneficiaryList);
        }

        // method to populate datagrid beneficharys
        public void FillBeneficiaryDatagrid(List<Beneficiary> BenDataGridList) {
           
            DataTable bentable = ConvertListToDataTable(BeneficiaryList);
            dgvBeneficiary.DataSource = bentable;
             DataTable ConvertListToDataTable(List<Beneficiary> benlist)
            {
                DataTable table = new DataTable();
                table.Columns.Add("Beneficairy Nme");
                table.Columns.Add("Beneficiary Branch");
                foreach (Beneficiary item in benlist)
                { 
                    table.Rows.Add(item.BeneficairyName,item.BeneficiaryBranch);
                }
                  return table;
            }

        }
        // method to populate crypto datagrid of beneficiary
        public void FillCryptoDatagrid(string selectedben, List<PaymentAccount> CryptoList)
        {
            BindingSource CryptoBind = new BindingSource();
            CryptoBind.Add(CryptoList);
            dgvCrypto.DataSource = CryptoBind;
        }
        // method to populate eft datagrid of beneficiary
        public void FillEFTDatagrid(string selectedben, List<PaymentAccount> EFTList)
        {
         
        }
        private void txtBID_Click(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            this.Hide();
            main.Show();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            this.Hide();
            profile.Show();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            Payments payments = new Payments();
            this.Hide();
            payments.Show();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            History history = new History();
            this.Hide();
            history.Show();
        }

        private void btnScheduel_Click(object sender, EventArgs e)
        {
            Schedules scheduels = new Schedules();
            this.Hide();
            scheduels.Show();
        }

        private void btnBeneficiary_Click(object sender, EventArgs e)
        {
            Benenficiarys beneficiarys = new Benenficiarys();
            this.Hide();
            beneficiarys.Show();
        }

        private void btnSeachB_Click(object sender, EventArgs e)
        {

            FillBeneficiaryDatagrid(BeneficiaryList);
            // Clear eft datagrid
            // clear crypto datagrid
        }

        private void dgvBeneficiary_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // get ben
            int index = e.RowIndex;
            ben = BeneficiaryList[index];
            //BenEFTList =
            

            //BenCryptoList =
            txtBName.Text = ben.BeneficairyName;
            txtBID.Text = ben.BeneficairyID;
            txtBBranchCode.Text = ben.BeneficiaryBranch;
          

        }

        private void btnDeleteB_Click(object sender, EventArgs e)
        {
            //send benID to detle
            FillBeneficiaryDatagrid(BeneficiaryList);
            txtBName.Text = "";
            txtBID.Text = "";
            txtBBranchCode.Text = "";
            ben = null;
            // Clear eft datagrid
            // clear crypto datagrid
        }

        private void btnAddB_Click(object sender, EventArgs e)
        {
            ben = new Beneficiary(txtBID.Text, txtBName.Text, txtBBranchCode.Text);
            txtBName.Text = "";
            txtBID.Text = "";
            txtBBranchCode.Text = "";
            FillBeneficiaryDatagrid(BeneficiaryList);

        }

        private void btnClearBPI_Click(object sender, EventArgs e)
        {
            txtBName.Text = "";
            txtBID.Text = "";
            txtBBranchCode.Text = "";
        }

        private void btnUpdateBPI_Click(object sender, EventArgs e)
        {
            // cehck if ben alreddy exist then update
            ben = new Beneficiary(txtBID.Text, txtBName.Text, txtBBranchCode.Text);
            txtBName.Text = "";
            txtBID.Text = "";
            txtBBranchCode.Text = "";
            FillBeneficiaryDatagrid(BeneficiaryList);

        }

        private void dgvCrypto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //  Crypto = Selected from datagrid
            
        }

        private void btnAddCrypto_Click(object sender, EventArgs e)
        {
            // add caount type (enum)
            //  EFT = new PaymentAccount(txtEFTAccNum.Text, txtAccHolder.Text, txtEFTRefernce.Text,);
            txtAccHolder.Text = "";
            txtEFTAccNum.Text = "";
            txtEFTRefernce.Text = "";
            // clear eft combobox
            //BenEFTList= get update EFT list
            FillEFTDatagrid(ben.BeneficairyName, BenEFTList);
        }

        private void btnUpdateEFT_Click(object sender, EventArgs e)
        {

        }

        private void btnClearCrypto_Click(object sender, EventArgs e)
        {
            txtWaletName.Text = "";
            txtWalletCode.Text = "";
            // clear combobox

        }

        private void BtnDeletCrypto_Click(object sender, EventArgs e)
        {
            

        }

        private void btnClearEFT_Click(object sender, EventArgs e)
        {
            txtAccHolder.Text = "";
            txtEFTAccNum.Text = "";
            txtEFTRefernce.Text = "";
            // clear eft combobox
        }

        private void dgvEFT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //EFT = select one from datagrid
            txtAccHolder.Text = EFT.AccountHolder;
            txtEFTAccNum.Text = EFT.AccountNumber;
            txtEFTRefernce.Text = EFT.Reference;
            // update combobox


        }

        private void btnAddEFT_Click(object sender, EventArgs e)
        {
            // add caount type (enum)
            //  EFT = new PaymentAccount(txtEFTAccNum.Text, txtAccHolder.Text, txtEFTRefernce.Text,);
            txtAccHolder.Text = "";
            txtEFTAccNum.Text = "";
            txtEFTRefernce.Text = "";
            // clear eft combobox
            //BenEFTList= get update EFT list
            FillEFTDatagrid(ben.BeneficairyName,BenEFTList);
        }

        private void btnDeletEFT_Click(object sender, EventArgs e)
        {
            //  EFT = selected from datagrid
            // send to delte
            txtAccHolder.Text = "";
            txtEFTAccNum.Text = "";
            txtEFTRefernce.Text = "";
            // clear eft combobox
            //BenEFTList= get update EFT list
            FillEFTDatagrid(ben.BeneficairyName, BenEFTList);
        }

        private void tabBeneficiary_Click(object sender, EventArgs e)
        {

        }
    }
}
