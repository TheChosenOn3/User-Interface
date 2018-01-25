namespace Project500
{
    partial class Payments
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.navpan = new MetroFramework.Controls.MetroPanel();
            this.btnBeneficiary = new MetroFramework.Controls.MetroButton();
            this.btnScheduel = new MetroFramework.Controls.MetroButton();
            this.btnHistory = new MetroFramework.Controls.MetroButton();
            this.btnPayment = new MetroFramework.Controls.MetroButton();
            this.btnProfile = new MetroFramework.Controls.MetroButton();
            this.btnHome = new MetroFramework.Controls.MetroButton();
            this.lblHeading = new MetroFramework.Controls.MetroLabel();
            this.lblUser = new MetroFramework.Controls.MetroLabel();
            this.metroStyleExtender1 = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.lblP500 = new MetroFramework.Controls.MetroLabel();
            this.tcCurrentpayment = new MetroFramework.Controls.MetroTabControl();
            this.tabCurrentPaymnet = new MetroFramework.Controls.MetroTabPage();
            this.btnBatch = new MetroFramework.Controls.MetroButton();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.cbUPaymentType = new System.Windows.Forms.ComboBox();
            this.txtDescription = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtBName = new MetroFramework.Controls.MetroTextBox();
            this.dgvBeneficiarys = new System.Windows.Forms.DataGridView();
            this.txtInterval = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.btnSearchB = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.cbBAccType = new System.Windows.Forms.ComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.dtpPayDatae = new System.Windows.Forms.DateTimePicker();
            this.btnAddPayment = new MetroFramework.Controls.MetroButton();
            this.btnClear = new MetroFramework.Controls.MetroButton();
            this.txtAmount = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel29 = new MetroFramework.Controls.MetroLabel();
            this.tcAddedPayments = new MetroFramework.Controls.MetroTabControl();
            this.tabAddedPayments = new MetroFramework.Controls.MetroTabPage();
            this.btnRetryPayment = new MetroFramework.Controls.MetroButton();
            this.btnExacutePayment = new MetroFramework.Controls.MetroButton();
            this.btnDeletePayment = new MetroFramework.Controls.MetroButton();
            this.btnRetryAllPayment = new MetroFramework.Controls.MetroButton();
            this.btnExacuteAllPayment = new MetroFramework.Controls.MetroButton();
            this.btnDeleteAllPayment = new MetroFramework.Controls.MetroButton();
            this.dgvAddedPayments = new System.Windows.Forms.DataGridView();
            this.navpan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.tcCurrentpayment.SuspendLayout();
            this.tabCurrentPaymnet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBeneficiarys)).BeginInit();
            this.tcAddedPayments.SuspendLayout();
            this.tabAddedPayments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddedPayments)).BeginInit();
            this.SuspendLayout();
            // 
            // navpan
            // 
            this.navpan.Controls.Add(this.btnBeneficiary);
            this.navpan.Controls.Add(this.btnScheduel);
            this.navpan.Controls.Add(this.btnHistory);
            this.navpan.Controls.Add(this.btnPayment);
            this.navpan.Controls.Add(this.btnProfile);
            this.navpan.Controls.Add(this.btnHome);
            this.navpan.HorizontalScrollbarBarColor = true;
            this.navpan.HorizontalScrollbarHighlightOnWheel = false;
            this.navpan.HorizontalScrollbarSize = 10;
            this.navpan.Location = new System.Drawing.Point(6, 120);
            this.navpan.Name = "navpan";
            this.navpan.Size = new System.Drawing.Size(134, 693);
            this.navpan.TabIndex = 5;
            this.navpan.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.navpan.VerticalScrollbarBarColor = true;
            this.navpan.VerticalScrollbarHighlightOnWheel = false;
            this.navpan.VerticalScrollbarSize = 10;
            // 
            // btnBeneficiary
            // 
            this.btnBeneficiary.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBeneficiary.Location = new System.Drawing.Point(0, 515);
            this.btnBeneficiary.Name = "btnBeneficiary";
            this.btnBeneficiary.Size = new System.Drawing.Size(134, 103);
            this.btnBeneficiary.TabIndex = 7;
            this.btnBeneficiary.Text = "Benefchiary";
            this.btnBeneficiary.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnBeneficiary.Click += new System.EventHandler(this.btnBeneficiary_Click);
            // 
            // btnScheduel
            // 
            this.btnScheduel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnScheduel.Location = new System.Drawing.Point(0, 412);
            this.btnScheduel.Name = "btnScheduel";
            this.btnScheduel.Size = new System.Drawing.Size(134, 103);
            this.btnScheduel.TabIndex = 6;
            this.btnScheduel.Text = "View Scheduel";
            this.btnScheduel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnScheduel.Click += new System.EventHandler(this.btnScheduel_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHistory.Location = new System.Drawing.Point(0, 309);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(134, 103);
            this.btnHistory.TabIndex = 5;
            this.btnHistory.Text = "View History";
            this.btnHistory.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPayment.Location = new System.Drawing.Point(0, 206);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(134, 103);
            this.btnPayment.TabIndex = 4;
            this.btnPayment.Text = "Make Payment";
            this.btnPayment.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProfile.Location = new System.Drawing.Point(0, 103);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(134, 103);
            this.btnProfile.TabIndex = 3;
            this.btnProfile.Text = "Profile";
            this.btnProfile.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(134, 103);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "Home";
            this.btnHome.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblHeading.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblHeading.Location = new System.Drawing.Point(571, 23);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(66, 25);
            this.lblHeading.TabIndex = 6;
            this.lblHeading.Text = "Home";
            this.lblHeading.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblUser.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblUser.Location = new System.Drawing.Point(231, 61);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(52, 25);
            this.lblUser.TabIndex = 8;
            this.lblUser.Text = "User";
            this.lblUser.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // lblP500
            // 
            this.lblP500.AutoSize = true;
            this.lblP500.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblP500.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblP500.Location = new System.Drawing.Point(170, 23);
            this.lblP500.Name = "lblP500";
            this.lblP500.Size = new System.Drawing.Size(113, 25);
            this.lblP500.TabIndex = 9;
            this.lblP500.Text = "Project 500";
            this.lblP500.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // tcCurrentpayment
            // 
            this.tcCurrentpayment.Controls.Add(this.tabCurrentPaymnet);
            this.tcCurrentpayment.Location = new System.Drawing.Point(150, 420);
            this.tcCurrentpayment.Name = "tcCurrentpayment";
            this.tcCurrentpayment.SelectedIndex = 0;
            this.tcCurrentpayment.Size = new System.Drawing.Size(987, 367);
            this.tcCurrentpayment.TabIndex = 19;
            this.tcCurrentpayment.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // tabCurrentPaymnet
            // 
            this.tabCurrentPaymnet.Controls.Add(this.btnBatch);
            this.tabCurrentPaymnet.Controls.Add(this.metroLabel6);
            this.tabCurrentPaymnet.Controls.Add(this.cbUPaymentType);
            this.tabCurrentPaymnet.Controls.Add(this.txtDescription);
            this.tabCurrentPaymnet.Controls.Add(this.metroLabel5);
            this.tabCurrentPaymnet.Controls.Add(this.txtBName);
            this.tabCurrentPaymnet.Controls.Add(this.dgvBeneficiarys);
            this.tabCurrentPaymnet.Controls.Add(this.txtInterval);
            this.tabCurrentPaymnet.Controls.Add(this.metroLabel4);
            this.tabCurrentPaymnet.Controls.Add(this.btnSearchB);
            this.tabCurrentPaymnet.Controls.Add(this.metroLabel3);
            this.tabCurrentPaymnet.Controls.Add(this.cbBAccType);
            this.tabCurrentPaymnet.Controls.Add(this.metroLabel2);
            this.tabCurrentPaymnet.Controls.Add(this.metroLabel1);
            this.tabCurrentPaymnet.Controls.Add(this.dtpPayDatae);
            this.tabCurrentPaymnet.Controls.Add(this.btnAddPayment);
            this.tabCurrentPaymnet.Controls.Add(this.btnClear);
            this.tabCurrentPaymnet.Controls.Add(this.txtAmount);
            this.tabCurrentPaymnet.Controls.Add(this.metroLabel29);
            this.tabCurrentPaymnet.HorizontalScrollbarBarColor = true;
            this.tabCurrentPaymnet.Location = new System.Drawing.Point(4, 39);
            this.tabCurrentPaymnet.Name = "tabCurrentPaymnet";
            this.tabCurrentPaymnet.Size = new System.Drawing.Size(979, 324);
            this.tabCurrentPaymnet.TabIndex = 0;
            this.tabCurrentPaymnet.Text = "Current payment";
            this.tabCurrentPaymnet.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tabCurrentPaymnet.VerticalScrollbarBarColor = true;
            // 
            // btnBatch
            // 
            this.btnBatch.Location = new System.Drawing.Point(395, 269);
            this.btnBatch.Name = "btnBatch";
            this.btnBatch.Size = new System.Drawing.Size(119, 44);
            this.btnBatch.TabIndex = 80;
            this.btnBatch.Text = "Import Bach";
            this.btnBatch.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(27, 179);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(115, 20);
            this.metroLabel6.TabIndex = 78;
            this.metroLabel6.Text = "payment Method";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // cbUPaymentType
            // 
            this.cbUPaymentType.FormattingEnabled = true;
            this.cbUPaymentType.Location = new System.Drawing.Point(191, 179);
            this.cbUPaymentType.Name = "cbUPaymentType";
            this.cbUPaymentType.Size = new System.Drawing.Size(253, 24);
            this.cbUPaymentType.TabIndex = 77;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(207, 135);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(127, 23);
            this.txtDescription.TabIndex = 76;
            this.txtDescription.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(23, 138);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(79, 20);
            this.metroLabel5.TabIndex = 75;
            this.metroLabel5.Text = "Description";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtBName
            // 
            this.txtBName.Location = new System.Drawing.Point(681, 15);
            this.txtBName.Name = "txtBName";
            this.txtBName.Size = new System.Drawing.Size(127, 23);
            this.txtBName.TabIndex = 74;
            this.txtBName.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // dgvBeneficiarys
            // 
            this.dgvBeneficiarys.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBeneficiarys.Location = new System.Drawing.Point(582, 49);
            this.dgvBeneficiarys.Name = "dgvBeneficiarys";
            this.dgvBeneficiarys.RowTemplate.Height = 24;
            this.dgvBeneficiarys.Size = new System.Drawing.Size(372, 150);
            this.dgvBeneficiarys.TabIndex = 73;
            this.dgvBeneficiarys.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBeneficiarys_CellContentClick);
            // 
            // txtInterval
            // 
            this.txtInterval.Location = new System.Drawing.Point(207, 99);
            this.txtInterval.Name = "txtInterval";
            this.txtInterval.Size = new System.Drawing.Size(127, 23);
            this.txtInterval.TabIndex = 72;
            this.txtInterval.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(23, 102);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(108, 20);
            this.metroLabel4.TabIndex = 71;
            this.metroLabel4.Text = "interval MM/DD";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // btnSearchB
            // 
            this.btnSearchB.Location = new System.Drawing.Point(835, 3);
            this.btnSearchB.Name = "btnSearchB";
            this.btnSearchB.Size = new System.Drawing.Size(119, 44);
            this.btnSearchB.TabIndex = 70;
            this.btnSearchB.Text = "Search Beneficiary";
            this.btnSearchB.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnSearchB.Click += new System.EventHandler(this.btnSearchB_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(483, 234);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(133, 20);
            this.metroLabel3.TabIndex = 69;
            this.metroLabel3.Text = "Beneficiary Account";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // cbBAccType
            // 
            this.cbBAccType.FormattingEnabled = true;
            this.cbBAccType.Location = new System.Drawing.Point(701, 234);
            this.cbBAccType.Name = "cbBAccType";
            this.cbBAccType.Size = new System.Drawing.Size(253, 24);
            this.cbBAccType.TabIndex = 68;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(483, 18);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(120, 20);
            this.metroLabel2.TabIndex = 66;
            this.metroLabel2.Text = "Beneficiary Name";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(20, 59);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(95, 20);
            this.metroLabel1.TabIndex = 65;
            this.metroLabel1.Text = "Payment Date";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // dtpPayDatae
            // 
            this.dtpPayDatae.Location = new System.Drawing.Point(158, 57);
            this.dtpPayDatae.Name = "dtpPayDatae";
            this.dtpPayDatae.Size = new System.Drawing.Size(225, 22);
            this.dtpPayDatae.TabIndex = 64;
            this.dtpPayDatae.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btnAddPayment
            // 
            this.btnAddPayment.Location = new System.Drawing.Point(153, 214);
            this.btnAddPayment.Name = "btnAddPayment";
            this.btnAddPayment.Size = new System.Drawing.Size(119, 44);
            this.btnAddPayment.TabIndex = 25;
            this.btnAddPayment.Text = "Add payment";
            this.btnAddPayment.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnAddPayment.Click += new System.EventHandler(this.btnAddPayment_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(23, 214);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(119, 44);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear Flields";
            this.btnClear.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(207, 15);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(127, 23);
            this.txtAmount.TabIndex = 3;
            this.txtAmount.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel29
            // 
            this.metroLabel29.AutoSize = true;
            this.metroLabel29.Location = new System.Drawing.Point(23, 18);
            this.metroLabel29.Name = "metroLabel29";
            this.metroLabel29.Size = new System.Drawing.Size(58, 20);
            this.metroLabel29.TabIndex = 2;
            this.metroLabel29.Text = "Amount";
            this.metroLabel29.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // tcAddedPayments
            // 
            this.tcAddedPayments.Controls.Add(this.tabAddedPayments);
            this.tcAddedPayments.Location = new System.Drawing.Point(146, 89);
            this.tcAddedPayments.Name = "tcAddedPayments";
            this.tcAddedPayments.SelectedIndex = 0;
            this.tcAddedPayments.Size = new System.Drawing.Size(987, 340);
            this.tcAddedPayments.TabIndex = 20;
            this.tcAddedPayments.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // tabAddedPayments
            // 
            this.tabAddedPayments.Controls.Add(this.btnRetryPayment);
            this.tabAddedPayments.Controls.Add(this.btnExacutePayment);
            this.tabAddedPayments.Controls.Add(this.btnDeletePayment);
            this.tabAddedPayments.Controls.Add(this.btnRetryAllPayment);
            this.tabAddedPayments.Controls.Add(this.btnExacuteAllPayment);
            this.tabAddedPayments.Controls.Add(this.btnDeleteAllPayment);
            this.tabAddedPayments.Controls.Add(this.dgvAddedPayments);
            this.tabAddedPayments.HorizontalScrollbarBarColor = true;
            this.tabAddedPayments.Location = new System.Drawing.Point(4, 39);
            this.tabAddedPayments.Name = "tabAddedPayments";
            this.tabAddedPayments.Size = new System.Drawing.Size(979, 297);
            this.tabAddedPayments.TabIndex = 0;
            this.tabAddedPayments.Text = "Added Payments";
            this.tabAddedPayments.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tabAddedPayments.VerticalScrollbarBarColor = true;
            // 
            // btnRetryPayment
            // 
            this.btnRetryPayment.Location = new System.Drawing.Point(149, 250);
            this.btnRetryPayment.Name = "btnRetryPayment";
            this.btnRetryPayment.Size = new System.Drawing.Size(127, 44);
            this.btnRetryPayment.TabIndex = 81;
            this.btnRetryPayment.Text = "Retry Payment ";
            this.btnRetryPayment.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnRetryPayment.Click += new System.EventHandler(this.btnRetryPayment_Click);
            // 
            // btnExacutePayment
            // 
            this.btnExacutePayment.Location = new System.Drawing.Point(282, 250);
            this.btnExacutePayment.Name = "btnExacutePayment";
            this.btnExacutePayment.Size = new System.Drawing.Size(124, 44);
            this.btnExacutePayment.TabIndex = 80;
            this.btnExacutePayment.Text = "Execute Payments";
            this.btnExacutePayment.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnExacutePayment.Click += new System.EventHandler(this.btnExacutePayment_Click);
            // 
            // btnDeletePayment
            // 
            this.btnDeletePayment.Location = new System.Drawing.Point(24, 250);
            this.btnDeletePayment.Name = "btnDeletePayment";
            this.btnDeletePayment.Size = new System.Drawing.Size(119, 44);
            this.btnDeletePayment.TabIndex = 79;
            this.btnDeletePayment.Text = "Delete payment";
            this.btnDeletePayment.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnDeletePayment.Click += new System.EventHandler(this.btnDeletePayment_Click);
            // 
            // btnRetryAllPayment
            // 
            this.btnRetryAllPayment.Location = new System.Drawing.Point(613, 250);
            this.btnRetryAllPayment.Name = "btnRetryAllPayment";
            this.btnRetryAllPayment.Size = new System.Drawing.Size(181, 44);
            this.btnRetryAllPayment.TabIndex = 78;
            this.btnRetryAllPayment.Text = "Retry All Payment payment";
            this.btnRetryAllPayment.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnRetryAllPayment.Click += new System.EventHandler(this.btnRetryAllPayment_Click);
            // 
            // btnExacuteAllPayment
            // 
            this.btnExacuteAllPayment.Location = new System.Drawing.Point(800, 250);
            this.btnExacuteAllPayment.Name = "btnExacuteAllPayment";
            this.btnExacuteAllPayment.Size = new System.Drawing.Size(155, 44);
            this.btnExacuteAllPayment.TabIndex = 77;
            this.btnExacuteAllPayment.Text = "Execute All Payments";
            this.btnExacuteAllPayment.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnExacuteAllPayment.Click += new System.EventHandler(this.btnExacuteAllPayment_Click);
            // 
            // btnDeleteAllPayment
            // 
            this.btnDeleteAllPayment.Location = new System.Drawing.Point(488, 250);
            this.btnDeleteAllPayment.Name = "btnDeleteAllPayment";
            this.btnDeleteAllPayment.Size = new System.Drawing.Size(119, 44);
            this.btnDeleteAllPayment.TabIndex = 76;
            this.btnDeleteAllPayment.Text = "Delete All payment";
            this.btnDeleteAllPayment.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnDeleteAllPayment.Click += new System.EventHandler(this.btnDeleteAllPayment_Click);
            // 
            // dgvAddedPayments
            // 
            this.dgvAddedPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddedPayments.Location = new System.Drawing.Point(19, 13);
            this.dgvAddedPayments.Name = "dgvAddedPayments";
            this.dgvAddedPayments.RowTemplate.Height = 24;
            this.dgvAddedPayments.Size = new System.Drawing.Size(936, 231);
            this.dgvAddedPayments.TabIndex = 63;
            this.dgvAddedPayments.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAddedPayments_CellContentClick);
            // 
            // Payments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 795);
            this.Controls.Add(this.tcAddedPayments);
            this.Controls.Add(this.tcCurrentpayment);
            this.Controls.Add(this.navpan);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblP500);
            this.Name = "Payments";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Payments_Load);
            this.navpan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.tcCurrentpayment.ResumeLayout(false);
            this.tabCurrentPaymnet.ResumeLayout(false);
            this.tabCurrentPaymnet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBeneficiarys)).EndInit();
            this.tcAddedPayments.ResumeLayout(false);
            this.tabAddedPayments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddedPayments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel navpan;
        private MetroFramework.Controls.MetroButton btnBeneficiary;
        private MetroFramework.Controls.MetroButton btnScheduel;
        private MetroFramework.Controls.MetroButton btnHistory;
        private MetroFramework.Controls.MetroButton btnPayment;
        private MetroFramework.Controls.MetroButton btnProfile;
        private MetroFramework.Controls.MetroButton btnHome;
        private MetroFramework.Controls.MetroLabel lblHeading;
        private MetroFramework.Controls.MetroLabel lblUser;
        private MetroFramework.Components.MetroStyleExtender metroStyleExtender1;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroLabel lblP500;
        private MetroFramework.Controls.MetroTabControl tcCurrentpayment;
        private MetroFramework.Controls.MetroTabPage tabCurrentPaymnet;
        private System.Windows.Forms.DateTimePicker dtpPayDatae;
        private MetroFramework.Controls.MetroButton btnAddPayment;
        private MetroFramework.Controls.MetroButton btnClear;
        private MetroFramework.Controls.MetroTextBox txtAmount;
        private MetroFramework.Controls.MetroLabel metroLabel29;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.ComboBox cbBAccType;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTabControl tcAddedPayments;
        private MetroFramework.Controls.MetroTabPage tabAddedPayments;
        private System.Windows.Forms.DataGridView dgvAddedPayments;
        private MetroFramework.Controls.MetroTextBox txtDescription;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtBName;
        private System.Windows.Forms.DataGridView dgvBeneficiarys;
        private MetroFramework.Controls.MetroTextBox txtInterval;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton btnSearchB;
        private MetroFramework.Controls.MetroButton btnRetryPayment;
        private MetroFramework.Controls.MetroButton btnExacutePayment;
        private MetroFramework.Controls.MetroButton btnDeletePayment;
        private MetroFramework.Controls.MetroButton btnRetryAllPayment;
        private MetroFramework.Controls.MetroButton btnExacuteAllPayment;
        private MetroFramework.Controls.MetroButton btnDeleteAllPayment;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.ComboBox cbUPaymentType;
        private MetroFramework.Controls.MetroButton btnBatch;
    }
}