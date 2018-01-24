namespace Project500
{
    partial class Schedules
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
            this.tcFilterScheduel = new MetroFramework.Controls.MetroTabControl();
            this.tabFilterScheduel = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.dtpFEnd = new System.Windows.Forms.DateTimePicker();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.cbFPaymentMethod = new System.Windows.Forms.ComboBox();
            this.btnFilter = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.dtpFStart = new System.Windows.Forms.DateTimePicker();
            this.btnClearFilter = new MetroFramework.Controls.MetroButton();
            this.txtFBName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel29 = new MetroFramework.Controls.MetroLabel();
            this.tcFilteredSchedules = new MetroFramework.Controls.MetroTabControl();
            this.tabFilteredSchedules = new MetroFramework.Controls.MetroTabPage();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.btnDeleteAll = new MetroFramework.Controls.MetroButton();
            this.dgvScheduels = new System.Windows.Forms.DataGridView();
            this.tcCurerntScheduel = new MetroFramework.Controls.MetroTabControl();
            this.tabCurrentScheduel = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtDescription = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtBname = new MetroFramework.Controls.MetroTextBox();
            this.dgvBeneficiary = new System.Windows.Forms.DataGridView();
            this.txtInterval = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.btnSearchBeneficiary = new MetroFramework.Controls.MetroButton();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.cbBAcounType = new System.Windows.Forms.ComboBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.dtpPaymentdate = new System.Windows.Forms.DateTimePicker();
            this.btnUpdatePayment = new MetroFramework.Controls.MetroButton();
            this.btnClearCurentPayment = new MetroFramework.Controls.MetroButton();
            this.txtAmount = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.navpan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.tcFilterScheduel.SuspendLayout();
            this.tabFilterScheduel.SuspendLayout();
            this.tcFilteredSchedules.SuspendLayout();
            this.tabFilteredSchedules.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScheduels)).BeginInit();
            this.tcCurerntScheduel.SuspendLayout();
            this.tabCurrentScheduel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBeneficiary)).BeginInit();
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
            this.navpan.Location = new System.Drawing.Point(6, 122);
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
            this.lblHeading.Location = new System.Drawing.Point(461, 36);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(290, 25);
            this.lblHeading.TabIndex = 6;
            this.lblHeading.Text = "View Your Schedueld Payments";
            this.lblHeading.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblUser.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblUser.Location = new System.Drawing.Point(231, 63);
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
            this.lblP500.Location = new System.Drawing.Point(170, 25);
            this.lblP500.Name = "lblP500";
            this.lblP500.Size = new System.Drawing.Size(113, 25);
            this.lblP500.TabIndex = 9;
            this.lblP500.Text = "Project 500";
            this.lblP500.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // tcFilterScheduel
            // 
            this.tcFilterScheduel.Controls.Add(this.tabFilterScheduel);
            this.tcFilterScheduel.Location = new System.Drawing.Point(146, 84);
            this.tcFilterScheduel.Name = "tcFilterScheduel";
            this.tcFilterScheduel.SelectedIndex = 0;
            this.tcFilterScheduel.Size = new System.Drawing.Size(987, 175);
            this.tcFilterScheduel.TabIndex = 21;
            this.tcFilterScheduel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // tabFilterScheduel
            // 
            this.tabFilterScheduel.Controls.Add(this.metroLabel4);
            this.tabFilterScheduel.Controls.Add(this.dtpFEnd);
            this.tabFilterScheduel.Controls.Add(this.metroLabel6);
            this.tabFilterScheduel.Controls.Add(this.cbFPaymentMethod);
            this.tabFilterScheduel.Controls.Add(this.btnFilter);
            this.tabFilterScheduel.Controls.Add(this.metroLabel1);
            this.tabFilterScheduel.Controls.Add(this.dtpFStart);
            this.tabFilterScheduel.Controls.Add(this.btnClearFilter);
            this.tabFilterScheduel.Controls.Add(this.txtFBName);
            this.tabFilterScheduel.Controls.Add(this.metroLabel29);
            this.tabFilterScheduel.HorizontalScrollbarBarColor = true;
            this.tabFilterScheduel.Location = new System.Drawing.Point(4, 39);
            this.tabFilterScheduel.Name = "tabFilterScheduel";
            this.tabFilterScheduel.Size = new System.Drawing.Size(979, 132);
            this.tabFilterScheduel.TabIndex = 0;
            this.tabFilterScheduel.Text = "Filter Your Schedueld payment";
            this.tabFilterScheduel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tabFilterScheduel.VerticalScrollbarBarColor = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(503, 54);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(66, 20);
            this.metroLabel4.TabIndex = 80;
            this.metroLabel4.Text = "End Date";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // dtpFEnd
            // 
            this.dtpFEnd.Location = new System.Drawing.Point(642, 52);
            this.dtpFEnd.Name = "dtpFEnd";
            this.dtpFEnd.Size = new System.Drawing.Size(225, 22);
            this.dtpFEnd.TabIndex = 79;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(18, 53);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(115, 20);
            this.metroLabel6.TabIndex = 78;
            this.metroLabel6.Text = "payment Method";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // cbFPaymentMethod
            // 
            this.cbFPaymentMethod.FormattingEnabled = true;
            this.cbFPaymentMethod.Location = new System.Drawing.Point(182, 49);
            this.cbFPaymentMethod.Name = "cbFPaymentMethod";
            this.cbFPaymentMethod.Size = new System.Drawing.Size(253, 24);
            this.cbFPaymentMethod.TabIndex = 77;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(471, 95);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(119, 37);
            this.btnFilter.TabIndex = 70;
            this.btnFilter.Text = "Filter";
            this.btnFilter.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(503, 15);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(70, 20);
            this.metroLabel1.TabIndex = 65;
            this.metroLabel1.Text = "Start Date";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // dtpFStart
            // 
            this.dtpFStart.Location = new System.Drawing.Point(642, 13);
            this.dtpFStart.Name = "dtpFStart";
            this.dtpFStart.Size = new System.Drawing.Size(225, 22);
            this.dtpFStart.TabIndex = 64;
            // 
            // btnClearFilter
            // 
            this.btnClearFilter.Location = new System.Drawing.Point(312, 95);
            this.btnClearFilter.Name = "btnClearFilter";
            this.btnClearFilter.Size = new System.Drawing.Size(119, 37);
            this.btnClearFilter.TabIndex = 25;
            this.btnClearFilter.Text = "Clear Fields";
            this.btnClearFilter.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtFBName
            // 
            this.txtFBName.Location = new System.Drawing.Point(207, 15);
            this.txtFBName.Name = "txtFBName";
            this.txtFBName.Size = new System.Drawing.Size(127, 23);
            this.txtFBName.TabIndex = 3;
            this.txtFBName.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel29
            // 
            this.metroLabel29.AutoSize = true;
            this.metroLabel29.Location = new System.Drawing.Point(23, 18);
            this.metroLabel29.Name = "metroLabel29";
            this.metroLabel29.Size = new System.Drawing.Size(120, 20);
            this.metroLabel29.TabIndex = 2;
            this.metroLabel29.Text = "Beneficiary Name";
            this.metroLabel29.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // tcFilteredSchedules
            // 
            this.tcFilteredSchedules.Controls.Add(this.tabFilteredSchedules);
            this.tcFilteredSchedules.Location = new System.Drawing.Point(146, 261);
            this.tcFilteredSchedules.Name = "tcFilteredSchedules";
            this.tcFilteredSchedules.SelectedIndex = 0;
            this.tcFilteredSchedules.Size = new System.Drawing.Size(987, 304);
            this.tcFilteredSchedules.TabIndex = 22;
            this.tcFilteredSchedules.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // tabFilteredSchedules
            // 
            this.tabFilteredSchedules.Controls.Add(this.btnDelete);
            this.tabFilteredSchedules.Controls.Add(this.btnDeleteAll);
            this.tabFilteredSchedules.Controls.Add(this.dgvScheduels);
            this.tabFilteredSchedules.HorizontalScrollbarBarColor = true;
            this.tabFilteredSchedules.Location = new System.Drawing.Point(4, 39);
            this.tabFilteredSchedules.Name = "tabFilteredSchedules";
            this.tabFilteredSchedules.Size = new System.Drawing.Size(979, 261);
            this.tabFilteredSchedules.TabIndex = 0;
            this.tabFilteredSchedules.Text = "Filtered Schedeuld Payments";
            this.tabFilteredSchedules.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tabFilteredSchedules.VerticalScrollbarBarColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(357, 217);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(119, 40);
            this.btnDelete.TabIndex = 79;
            this.btnDelete.Text = "Delete payment";
            this.btnDelete.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.Location = new System.Drawing.Point(482, 217);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(119, 40);
            this.btnDeleteAll.TabIndex = 76;
            this.btnDeleteAll.Text = "Delete All payment";
            this.btnDeleteAll.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // dgvScheduels
            // 
            this.dgvScheduels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvScheduels.Location = new System.Drawing.Point(19, 13);
            this.dgvScheduels.Name = "dgvScheduels";
            this.dgvScheduels.RowTemplate.Height = 24;
            this.dgvScheduels.Size = new System.Drawing.Size(936, 198);
            this.dgvScheduels.TabIndex = 63;
            // 
            // tcCurerntScheduel
            // 
            this.tcCurerntScheduel.Controls.Add(this.tabCurrentScheduel);
            this.tcCurerntScheduel.Location = new System.Drawing.Point(153, 563);
            this.tcCurerntScheduel.Name = "tcCurerntScheduel";
            this.tcCurerntScheduel.SelectedIndex = 0;
            this.tcCurerntScheduel.Size = new System.Drawing.Size(987, 318);
            this.tcCurerntScheduel.TabIndex = 24;
            this.tcCurerntScheduel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // tabCurrentScheduel
            // 
            this.tabCurrentScheduel.Controls.Add(this.metroLabel2);
            this.tabCurrentScheduel.Controls.Add(this.comboBox1);
            this.tabCurrentScheduel.Controls.Add(this.txtDescription);
            this.tabCurrentScheduel.Controls.Add(this.metroLabel5);
            this.tabCurrentScheduel.Controls.Add(this.txtBname);
            this.tabCurrentScheduel.Controls.Add(this.dgvBeneficiary);
            this.tabCurrentScheduel.Controls.Add(this.txtInterval);
            this.tabCurrentScheduel.Controls.Add(this.metroLabel3);
            this.tabCurrentScheduel.Controls.Add(this.btnSearchBeneficiary);
            this.tabCurrentScheduel.Controls.Add(this.metroLabel7);
            this.tabCurrentScheduel.Controls.Add(this.cbBAcounType);
            this.tabCurrentScheduel.Controls.Add(this.metroLabel8);
            this.tabCurrentScheduel.Controls.Add(this.metroLabel9);
            this.tabCurrentScheduel.Controls.Add(this.dtpPaymentdate);
            this.tabCurrentScheduel.Controls.Add(this.btnUpdatePayment);
            this.tabCurrentScheduel.Controls.Add(this.btnClearCurentPayment);
            this.tabCurrentScheduel.Controls.Add(this.txtAmount);
            this.tabCurrentScheduel.Controls.Add(this.metroLabel10);
            this.tabCurrentScheduel.HorizontalScrollbarBarColor = true;
            this.tabCurrentScheduel.Location = new System.Drawing.Point(4, 39);
            this.tabCurrentScheduel.Name = "tabCurrentScheduel";
            this.tabCurrentScheduel.Size = new System.Drawing.Size(979, 275);
            this.tabCurrentScheduel.TabIndex = 0;
            this.tabCurrentScheduel.Text = "Current payment";
            this.tabCurrentScheduel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tabCurrentScheduel.VerticalScrollbarBarColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(27, 179);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(115, 20);
            this.metroLabel2.TabIndex = 78;
            this.metroLabel2.Text = "payment Method";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(191, 179);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(253, 24);
            this.comboBox1.TabIndex = 77;
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
            // txtBname
            // 
            this.txtBname.Location = new System.Drawing.Point(681, 15);
            this.txtBname.Name = "txtBname";
            this.txtBname.Size = new System.Drawing.Size(127, 23);
            this.txtBname.TabIndex = 74;
            this.txtBname.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // dgvBeneficiary
            // 
            this.dgvBeneficiary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBeneficiary.Location = new System.Drawing.Point(582, 49);
            this.dgvBeneficiary.Name = "dgvBeneficiary";
            this.dgvBeneficiary.RowTemplate.Height = 24;
            this.dgvBeneficiary.Size = new System.Drawing.Size(372, 150);
            this.dgvBeneficiary.TabIndex = 73;
            // 
            // txtInterval
            // 
            this.txtInterval.Location = new System.Drawing.Point(207, 99);
            this.txtInterval.Name = "txtInterval";
            this.txtInterval.Size = new System.Drawing.Size(127, 23);
            this.txtInterval.TabIndex = 72;
            this.txtInterval.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 102);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(108, 20);
            this.metroLabel3.TabIndex = 71;
            this.metroLabel3.Text = "interval MM/DD";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // btnSearchBeneficiary
            // 
            this.btnSearchBeneficiary.Location = new System.Drawing.Point(835, 3);
            this.btnSearchBeneficiary.Name = "btnSearchBeneficiary";
            this.btnSearchBeneficiary.Size = new System.Drawing.Size(119, 44);
            this.btnSearchBeneficiary.TabIndex = 70;
            this.btnSearchBeneficiary.Text = "Search Beneficiary";
            this.btnSearchBeneficiary.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(483, 234);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(133, 20);
            this.metroLabel7.TabIndex = 69;
            this.metroLabel7.Text = "Beneficiary Account";
            this.metroLabel7.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // cbBAcounType
            // 
            this.cbBAcounType.FormattingEnabled = true;
            this.cbBAcounType.Location = new System.Drawing.Point(701, 234);
            this.cbBAcounType.Name = "cbBAcounType";
            this.cbBAcounType.Size = new System.Drawing.Size(253, 24);
            this.cbBAcounType.TabIndex = 68;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(483, 18);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(120, 20);
            this.metroLabel8.TabIndex = 66;
            this.metroLabel8.Text = "Beneficiary Name";
            this.metroLabel8.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(20, 59);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(95, 20);
            this.metroLabel9.TabIndex = 65;
            this.metroLabel9.Text = "Payment Date";
            this.metroLabel9.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // dtpPaymentdate
            // 
            this.dtpPaymentdate.Location = new System.Drawing.Point(158, 57);
            this.dtpPaymentdate.Name = "dtpPaymentdate";
            this.dtpPaymentdate.Size = new System.Drawing.Size(225, 22);
            this.dtpPaymentdate.TabIndex = 64;
            // 
            // btnUpdatePayment
            // 
            this.btnUpdatePayment.Location = new System.Drawing.Point(207, 214);
            this.btnUpdatePayment.Name = "btnUpdatePayment";
            this.btnUpdatePayment.Size = new System.Drawing.Size(119, 44);
            this.btnUpdatePayment.TabIndex = 25;
            this.btnUpdatePayment.Text = "Updaet payment";
            this.btnUpdatePayment.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // btnClearCurentPayment
            // 
            this.btnClearCurentPayment.Location = new System.Drawing.Point(23, 214);
            this.btnClearCurentPayment.Name = "btnClearCurentPayment";
            this.btnClearCurentPayment.Size = new System.Drawing.Size(119, 44);
            this.btnClearCurentPayment.TabIndex = 4;
            this.btnClearCurentPayment.Text = "Clear Flields";
            this.btnClearCurentPayment.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(207, 15);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(127, 23);
            this.txtAmount.TabIndex = 3;
            this.txtAmount.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(23, 18);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(58, 20);
            this.metroLabel10.TabIndex = 2;
            this.metroLabel10.Text = "Amount";
            this.metroLabel10.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Schedules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 890);
            this.Controls.Add(this.tcCurerntScheduel);
            this.Controls.Add(this.tcFilteredSchedules);
            this.Controls.Add(this.tcFilterScheduel);
            this.Controls.Add(this.navpan);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblP500);
            this.Name = "Schedules";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Schedules_Load);
            this.navpan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.tcFilterScheduel.ResumeLayout(false);
            this.tabFilterScheduel.ResumeLayout(false);
            this.tabFilterScheduel.PerformLayout();
            this.tcFilteredSchedules.ResumeLayout(false);
            this.tabFilteredSchedules.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvScheduels)).EndInit();
            this.tcCurerntScheduel.ResumeLayout(false);
            this.tabCurrentScheduel.ResumeLayout(false);
            this.tabCurrentScheduel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBeneficiary)).EndInit();
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
        private MetroFramework.Controls.MetroTabControl tcFilterScheduel;
        private MetroFramework.Controls.MetroTabPage tabFilterScheduel;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.DateTimePicker dtpFEnd;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.ComboBox cbFPaymentMethod;
        private MetroFramework.Controls.MetroButton btnFilter;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.DateTimePicker dtpFStart;
        private MetroFramework.Controls.MetroButton btnClearFilter;
        private MetroFramework.Controls.MetroTextBox txtFBName;
        private MetroFramework.Controls.MetroLabel metroLabel29;
        private MetroFramework.Controls.MetroTabControl tcFilteredSchedules;
        private MetroFramework.Controls.MetroTabPage tabFilteredSchedules;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroButton btnDeleteAll;
        private System.Windows.Forms.DataGridView dgvScheduels;
        private MetroFramework.Controls.MetroTabControl tcCurerntScheduel;
        private MetroFramework.Controls.MetroTabPage tabCurrentScheduel;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.ComboBox comboBox1;
        private MetroFramework.Controls.MetroTextBox txtDescription;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtBname;
        private System.Windows.Forms.DataGridView dgvBeneficiary;
        private MetroFramework.Controls.MetroTextBox txtInterval;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton btnSearchBeneficiary;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private System.Windows.Forms.ComboBox cbBAcounType;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private System.Windows.Forms.DateTimePicker dtpPaymentdate;
        private MetroFramework.Controls.MetroButton btnUpdatePayment;
        private MetroFramework.Controls.MetroButton btnClearCurentPayment;
        private MetroFramework.Controls.MetroTextBox txtAmount;
        private MetroFramework.Controls.MetroLabel metroLabel10;
    }
}