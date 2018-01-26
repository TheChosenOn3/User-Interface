namespace Project500
{
    partial class History
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.tcFilterPayments = new MetroFramework.Controls.MetroTabControl();
            this.tabFilterPayments = new MetroFramework.Controls.MetroTabPage();
            this.txtStatus = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btnFilter = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.btnClearFields = new MetroFramework.Controls.MetroButton();
            this.txtBName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel29 = new MetroFramework.Controls.MetroLabel();
            this.tcPayments = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.tcCurrentPayment = new MetroFramework.Controls.MetroTabControl();
            this.tabCurrentPayment = new MetroFramework.Controls.MetroTabPage();
            this.btnRemakePayment = new MetroFramework.Controls.MetroButton();
            this.btnGenerateReport = new MetroFramework.Controls.MetroButton();
            this.rteDecription = new System.Windows.Forms.RichTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.dgvPayments = new MetroFramework.Controls.MetroGrid();
            this.navpan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.tcFilterPayments.SuspendLayout();
            this.tabFilterPayments.SuspendLayout();
            this.tcPayments.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.tcCurrentPayment.SuspendLayout();
            this.tabCurrentPayment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).BeginInit();
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
            this.navpan.HorizontalScrollbarSize = 8;
            this.navpan.Location = new System.Drawing.Point(4, 98);
            this.navpan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.navpan.Name = "navpan";
            this.navpan.Size = new System.Drawing.Size(100, 563);
            this.navpan.TabIndex = 5;
            this.navpan.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.navpan.VerticalScrollbarBarColor = true;
            this.navpan.VerticalScrollbarHighlightOnWheel = false;
            this.navpan.VerticalScrollbarSize = 8;
            // 
            // btnBeneficiary
            // 
            this.btnBeneficiary.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBeneficiary.Location = new System.Drawing.Point(0, 420);
            this.btnBeneficiary.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBeneficiary.Name = "btnBeneficiary";
            this.btnBeneficiary.Size = new System.Drawing.Size(100, 84);
            this.btnBeneficiary.TabIndex = 7;
            this.btnBeneficiary.Text = "Benefchiary";
            this.btnBeneficiary.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnBeneficiary.UseSelectable = true;
            this.btnBeneficiary.Click += new System.EventHandler(this.btnBeneficiary_Click);
            // 
            // btnScheduel
            // 
            this.btnScheduel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnScheduel.Location = new System.Drawing.Point(0, 336);
            this.btnScheduel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnScheduel.Name = "btnScheduel";
            this.btnScheduel.Size = new System.Drawing.Size(100, 84);
            this.btnScheduel.TabIndex = 6;
            this.btnScheduel.Text = "View Scheduel";
            this.btnScheduel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnScheduel.UseSelectable = true;
            this.btnScheduel.Click += new System.EventHandler(this.btnScheduel_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHistory.Location = new System.Drawing.Point(0, 252);
            this.btnHistory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(100, 84);
            this.btnHistory.TabIndex = 5;
            this.btnHistory.Text = "View History";
            this.btnHistory.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnHistory.UseSelectable = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPayment.Location = new System.Drawing.Point(0, 168);
            this.btnPayment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(100, 84);
            this.btnPayment.TabIndex = 4;
            this.btnPayment.Text = "Make Payment";
            this.btnPayment.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnPayment.UseSelectable = true;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProfile.Location = new System.Drawing.Point(0, 84);
            this.btnProfile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(100, 84);
            this.btnProfile.TabIndex = 3;
            this.btnProfile.Text = "Profile";
            this.btnProfile.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnProfile.UseSelectable = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(100, 84);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "Home";
            this.btnHome.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnHome.UseSelectable = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblHeading.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblHeading.Location = new System.Drawing.Point(371, 36);
            this.lblHeading.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(252, 25);
            this.lblHeading.TabIndex = 6;
            this.lblHeading.Text = "View Your Payments History";
            this.lblHeading.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblUser.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblUser.Location = new System.Drawing.Point(172, 50);
            this.lblUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(50, 25);
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
            this.lblP500.Location = new System.Drawing.Point(127, 20);
            this.lblP500.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblP500.Name = "lblP500";
            this.lblP500.Size = new System.Drawing.Size(107, 25);
            this.lblP500.TabIndex = 9;
            this.lblP500.Text = "Project 500";
            this.lblP500.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblP500.Click += new System.EventHandler(this.lblP500_Click);
            // 
            // tcFilterPayments
            // 
            this.tcFilterPayments.Controls.Add(this.tabFilterPayments);
            this.tcFilterPayments.Location = new System.Drawing.Point(109, 73);
            this.tcFilterPayments.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tcFilterPayments.Name = "tcFilterPayments";
            this.tcFilterPayments.SelectedIndex = 0;
            this.tcFilterPayments.Size = new System.Drawing.Size(740, 145);
            this.tcFilterPayments.TabIndex = 20;
            this.tcFilterPayments.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tcFilterPayments.UseSelectable = true;
            // 
            // tabFilterPayments
            // 
            this.tabFilterPayments.Controls.Add(this.txtStatus);
            this.tabFilterPayments.Controls.Add(this.metroLabel3);
            this.tabFilterPayments.Controls.Add(this.metroLabel4);
            this.tabFilterPayments.Controls.Add(this.dtpEnd);
            this.tabFilterPayments.Controls.Add(this.metroLabel6);
            this.tabFilterPayments.Controls.Add(this.comboBox2);
            this.tabFilterPayments.Controls.Add(this.btnFilter);
            this.tabFilterPayments.Controls.Add(this.metroLabel1);
            this.tabFilterPayments.Controls.Add(this.dtpStart);
            this.tabFilterPayments.Controls.Add(this.btnClearFields);
            this.tabFilterPayments.Controls.Add(this.txtBName);
            this.tabFilterPayments.Controls.Add(this.metroLabel29);
            this.tabFilterPayments.HorizontalScrollbarBarColor = true;
            this.tabFilterPayments.HorizontalScrollbarHighlightOnWheel = false;
            this.tabFilterPayments.HorizontalScrollbarSize = 8;
            this.tabFilterPayments.Location = new System.Drawing.Point(4, 38);
            this.tabFilterPayments.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabFilterPayments.Name = "tabFilterPayments";
            this.tabFilterPayments.Size = new System.Drawing.Size(732, 103);
            this.tabFilterPayments.TabIndex = 0;
            this.tabFilterPayments.Text = "Filter Your payment";
            this.tabFilterPayments.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tabFilterPayments.VerticalScrollbarBarColor = true;
            this.tabFilterPayments.VerticalScrollbarHighlightOnWheel = false;
            this.tabFilterPayments.VerticalScrollbarSize = 8;
            // 
            // txtStatus
            // 
            // 
            // 
            // 
            this.txtStatus.CustomButton.Image = null;
            this.txtStatus.CustomButton.Location = new System.Drawing.Point(58, 1);
            this.txtStatus.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtStatus.CustomButton.Name = "";
            this.txtStatus.CustomButton.Size = new System.Drawing.Size(13, 14);
            this.txtStatus.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtStatus.CustomButton.TabIndex = 1;
            this.txtStatus.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtStatus.CustomButton.UseSelectable = true;
            this.txtStatus.CustomButton.Visible = false;
            this.txtStatus.Lines = new string[0];
            this.txtStatus.Location = new System.Drawing.Point(155, 74);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtStatus.MaxLength = 32767;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.PasswordChar = '\0';
            this.txtStatus.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtStatus.SelectedText = "";
            this.txtStatus.SelectionLength = 0;
            this.txtStatus.SelectionStart = 0;
            this.txtStatus.ShortcutsEnabled = true;
            this.txtStatus.Size = new System.Drawing.Size(95, 19);
            this.txtStatus.TabIndex = 82;
            this.txtStatus.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtStatus.UseSelectable = true;
            this.txtStatus.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtStatus.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(43, 76);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(43, 19);
            this.metroLabel3.TabIndex = 81;
            this.metroLabel3.Text = "Status";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(377, 44);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(62, 19);
            this.metroLabel4.TabIndex = 80;
            this.metroLabel4.Text = "End Date";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(482, 42);
            this.dtpEnd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(170, 20);
            this.dtpEnd.TabIndex = 79;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(14, 43);
            this.metroLabel6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(110, 19);
            this.metroLabel6.TabIndex = 78;
            this.metroLabel6.Text = "payment Method";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(136, 40);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(191, 21);
            this.comboBox2.TabIndex = 77;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(395, 74);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(89, 32);
            this.btnFilter.TabIndex = 70;
            this.btnFilter.Text = "Filter";
            this.btnFilter.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnFilter.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(377, 12);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(68, 19);
            this.metroLabel1.TabIndex = 65;
            this.metroLabel1.Text = "Start Date";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(482, 11);
            this.dtpStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(170, 20);
            this.dtpStart.TabIndex = 64;
            // 
            // btnClearFields
            // 
            this.btnClearFields.Location = new System.Drawing.Point(268, 76);
            this.btnClearFields.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClearFields.Name = "btnClearFields";
            this.btnClearFields.Size = new System.Drawing.Size(89, 32);
            this.btnClearFields.TabIndex = 25;
            this.btnClearFields.Text = "Clear Fields";
            this.btnClearFields.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnClearFields.UseSelectable = true;
            // 
            // txtBName
            // 
            // 
            // 
            // 
            this.txtBName.CustomButton.Image = null;
            this.txtBName.CustomButton.Location = new System.Drawing.Point(58, 1);
            this.txtBName.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBName.CustomButton.Name = "";
            this.txtBName.CustomButton.Size = new System.Drawing.Size(13, 14);
            this.txtBName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBName.CustomButton.TabIndex = 1;
            this.txtBName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBName.CustomButton.UseSelectable = true;
            this.txtBName.CustomButton.Visible = false;
            this.txtBName.Lines = new string[0];
            this.txtBName.Location = new System.Drawing.Point(155, 12);
            this.txtBName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBName.MaxLength = 32767;
            this.txtBName.Name = "txtBName";
            this.txtBName.PasswordChar = '\0';
            this.txtBName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBName.SelectedText = "";
            this.txtBName.SelectionLength = 0;
            this.txtBName.SelectionStart = 0;
            this.txtBName.ShortcutsEnabled = true;
            this.txtBName.Size = new System.Drawing.Size(95, 19);
            this.txtBName.TabIndex = 3;
            this.txtBName.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtBName.UseSelectable = true;
            this.txtBName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel29
            // 
            this.metroLabel29.AutoSize = true;
            this.metroLabel29.Location = new System.Drawing.Point(14, 15);
            this.metroLabel29.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel29.Name = "metroLabel29";
            this.metroLabel29.Size = new System.Drawing.Size(113, 19);
            this.metroLabel29.TabIndex = 2;
            this.metroLabel29.Text = "Beneficiary Name";
            this.metroLabel29.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // tcPayments
            // 
            this.tcPayments.Controls.Add(this.metroTabPage1);
            this.tcPayments.Location = new System.Drawing.Point(109, 219);
            this.tcPayments.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tcPayments.Name = "tcPayments";
            this.tcPayments.SelectedIndex = 0;
            this.tcPayments.Size = new System.Drawing.Size(740, 253);
            this.tcPayments.TabIndex = 21;
            this.tcPayments.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tcPayments.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.dgvPayments);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 8;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(732, 211);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Filtered Payments";
            this.metroTabPage1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 8;
            // 
            // tcCurrentPayment
            // 
            this.tcCurrentPayment.Controls.Add(this.tabCurrentPayment);
            this.tcCurrentPayment.Location = new System.Drawing.Point(112, 466);
            this.tcCurrentPayment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tcCurrentPayment.Name = "tcCurrentPayment";
            this.tcCurrentPayment.SelectedIndex = 0;
            this.tcCurrentPayment.Size = new System.Drawing.Size(740, 134);
            this.tcCurrentPayment.TabIndex = 22;
            this.tcCurrentPayment.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tcCurrentPayment.UseSelectable = true;
            // 
            // tabCurrentPayment
            // 
            this.tabCurrentPayment.Controls.Add(this.btnRemakePayment);
            this.tabCurrentPayment.Controls.Add(this.btnGenerateReport);
            this.tabCurrentPayment.Controls.Add(this.rteDecription);
            this.tabCurrentPayment.Controls.Add(this.metroLabel2);
            this.tabCurrentPayment.HorizontalScrollbarBarColor = true;
            this.tabCurrentPayment.HorizontalScrollbarHighlightOnWheel = false;
            this.tabCurrentPayment.HorizontalScrollbarSize = 8;
            this.tabCurrentPayment.Location = new System.Drawing.Point(4, 38);
            this.tabCurrentPayment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabCurrentPayment.Name = "tabCurrentPayment";
            this.tabCurrentPayment.Size = new System.Drawing.Size(732, 92);
            this.tabCurrentPayment.TabIndex = 0;
            this.tabCurrentPayment.Text = "Currenet Payment";
            this.tabCurrentPayment.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tabCurrentPayment.VerticalScrollbarBarColor = true;
            this.tabCurrentPayment.VerticalScrollbarHighlightOnWheel = false;
            this.tabCurrentPayment.VerticalScrollbarSize = 8;
            // 
            // btnRemakePayment
            // 
            this.btnRemakePayment.Location = new System.Drawing.Point(627, 51);
            this.btnRemakePayment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRemakePayment.Name = "btnRemakePayment";
            this.btnRemakePayment.Size = new System.Drawing.Size(89, 32);
            this.btnRemakePayment.TabIndex = 82;
            this.btnRemakePayment.Text = "Remake payment";
            this.btnRemakePayment.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnRemakePayment.UseSelectable = true;
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Location = new System.Drawing.Point(627, 11);
            this.btnGenerateReport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(89, 32);
            this.btnGenerateReport.TabIndex = 81;
            this.btnGenerateReport.Text = "Generate report";
            this.btnGenerateReport.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnGenerateReport.UseSelectable = true;
            // 
            // rteDecription
            // 
            this.rteDecription.Location = new System.Drawing.Point(104, 11);
            this.rteDecription.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rteDecription.Name = "rteDecription";
            this.rteDecription.Size = new System.Drawing.Size(506, 79);
            this.rteDecription.TabIndex = 80;
            this.rteDecription.Text = "";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(2, 38);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(74, 19);
            this.metroLabel2.TabIndex = 79;
            this.metroLabel2.Text = "Description";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // dgvPayments
            // 
            this.dgvPayments.AllowUserToResizeRows = false;
            this.dgvPayments.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvPayments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPayments.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvPayments.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPayments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPayments.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPayments.EnableHeadersVisualStyles = false;
            this.dgvPayments.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvPayments.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvPayments.Location = new System.Drawing.Point(3, 9);
            this.dgvPayments.Name = "dgvPayments";
            this.dgvPayments.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPayments.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPayments.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPayments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPayments.Size = new System.Drawing.Size(726, 224);
            this.dgvPayments.TabIndex = 2;
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 635);
            this.Controls.Add(this.tcCurrentPayment);
            this.Controls.Add(this.tcPayments);
            this.Controls.Add(this.tcFilterPayments);
            this.Controls.Add(this.navpan);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblP500);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "History";
            this.Padding = new System.Windows.Forms.Padding(15, 49, 15, 16);
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.History_Load);
            this.navpan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.tcFilterPayments.ResumeLayout(false);
            this.tabFilterPayments.ResumeLayout(false);
            this.tabFilterPayments.PerformLayout();
            this.tcPayments.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.tcCurrentPayment.ResumeLayout(false);
            this.tabCurrentPayment.ResumeLayout(false);
            this.tabCurrentPayment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).EndInit();
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
        private MetroFramework.Controls.MetroTabControl tcFilterPayments;
        private MetroFramework.Controls.MetroTabPage tabFilterPayments;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.ComboBox comboBox2;
        private MetroFramework.Controls.MetroButton btnFilter;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private MetroFramework.Controls.MetroButton btnClearFields;
        private MetroFramework.Controls.MetroTextBox txtBName;
        private MetroFramework.Controls.MetroLabel metroLabel29;
        private MetroFramework.Controls.MetroTabControl tcPayments;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabControl tcCurrentPayment;
        private MetroFramework.Controls.MetroTabPage tabCurrentPayment;
        private MetroFramework.Controls.MetroButton btnRemakePayment;
        private MetroFramework.Controls.MetroButton btnGenerateReport;
        private System.Windows.Forms.RichTextBox rteDecription;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtStatus;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroGrid dgvPayments;
    }
}