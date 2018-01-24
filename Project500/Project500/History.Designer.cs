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
            this.navpan = new MetroFramework.Controls.MetroPanel();
            this.btnBeneficiary = new MetroFramework.Controls.MetroButton();
            this.btnScheduel = new MetroFramework.Controls.MetroButton();
            this.btnHistory = new MetroFramework.Controls.MetroButton();
            this.btnPayment = new MetroFramework.Controls.MetroButton();
            this.btnProfile = new MetroFramework.Controls.MetroButton();
            this.btnHome = new MetroFramework.Controls.MetroButton();
            this.lblHeading = new MetroFramework.Controls.MetroLabel();
            this.lblUser = new MetroFramework.Controls.MetroLabel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            this.dgvPayments = new System.Windows.Forms.DataGridView();
            this.tcCurrentPayment = new MetroFramework.Controls.MetroTabControl();
            this.tabCurrentPayment = new MetroFramework.Controls.MetroTabPage();
            this.btnRemakePayment = new MetroFramework.Controls.MetroButton();
            this.btnGenerateReport = new MetroFramework.Controls.MetroButton();
            this.rteDecription = new System.Windows.Forms.RichTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.navpan.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.tcFilterPayments.SuspendLayout();
            this.tabFilterPayments.SuspendLayout();
            this.tcPayments.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).BeginInit();
            this.tcCurrentPayment.SuspendLayout();
            this.tabCurrentPayment.SuspendLayout();
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
            this.navpan.Location = new System.Drawing.Point(5, 121);
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
            this.lblHeading.Location = new System.Drawing.Point(495, 44);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(264, 25);
            this.lblHeading.TabIndex = 6;
            this.lblHeading.Text = "View Your Payments History";
            this.lblHeading.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblUser.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblUser.Location = new System.Drawing.Point(230, 62);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(52, 25);
            this.lblUser.TabIndex = 8;
            this.lblUser.Text = "User";
            this.lblUser.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroPanel2
            // 
            this.metroPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.metroPanel2.Controls.Add(this.pictureBox1);
            this.metroPanel2.CustomBackground = true;
            this.metroPanel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(5, 12);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(134, 103);
            this.metroPanel2.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroPanel2.TabIndex = 7;
            this.metroPanel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(34, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 84);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
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
            this.lblP500.Location = new System.Drawing.Point(169, 24);
            this.lblP500.Name = "lblP500";
            this.lblP500.Size = new System.Drawing.Size(113, 25);
            this.lblP500.TabIndex = 9;
            this.lblP500.Text = "Project 500";
            this.lblP500.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblP500.Click += new System.EventHandler(this.lblP500_Click);
            // 
            // tcFilterPayments
            // 
            this.tcFilterPayments.Controls.Add(this.tabFilterPayments);
            this.tcFilterPayments.Location = new System.Drawing.Point(145, 90);
            this.tcFilterPayments.Name = "tcFilterPayments";
            this.tcFilterPayments.SelectedIndex = 0;
            this.tcFilterPayments.Size = new System.Drawing.Size(987, 179);
            this.tcFilterPayments.TabIndex = 20;
            this.tcFilterPayments.Theme = MetroFramework.MetroThemeStyle.Dark;
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
            this.tabFilterPayments.Location = new System.Drawing.Point(4, 39);
            this.tabFilterPayments.Name = "tabFilterPayments";
            this.tabFilterPayments.Size = new System.Drawing.Size(979, 136);
            this.tabFilterPayments.TabIndex = 0;
            this.tabFilterPayments.Text = "Filter Your payment";
            this.tabFilterPayments.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tabFilterPayments.VerticalScrollbarBarColor = true;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(207, 91);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(127, 23);
            this.txtStatus.TabIndex = 82;
            this.txtStatus.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(57, 94);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(45, 20);
            this.metroLabel3.TabIndex = 81;
            this.metroLabel3.Text = "Status";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
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
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(642, 52);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(225, 22);
            this.dtpEnd.TabIndex = 79;
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
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(182, 49);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(253, 24);
            this.comboBox2.TabIndex = 77;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(527, 91);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(119, 39);
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
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(642, 13);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(225, 22);
            this.dtpStart.TabIndex = 64;
            // 
            // btnClearFields
            // 
            this.btnClearFields.Location = new System.Drawing.Point(357, 94);
            this.btnClearFields.Name = "btnClearFields";
            this.btnClearFields.Size = new System.Drawing.Size(119, 39);
            this.btnClearFields.TabIndex = 25;
            this.btnClearFields.Text = "Clear Fields";
            this.btnClearFields.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtBName
            // 
            this.txtBName.Location = new System.Drawing.Point(207, 15);
            this.txtBName.Name = "txtBName";
            this.txtBName.Size = new System.Drawing.Size(127, 23);
            this.txtBName.TabIndex = 3;
            this.txtBName.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel29
            // 
            this.metroLabel29.AutoSize = true;
            this.metroLabel29.Location = new System.Drawing.Point(18, 18);
            this.metroLabel29.Name = "metroLabel29";
            this.metroLabel29.Size = new System.Drawing.Size(120, 20);
            this.metroLabel29.TabIndex = 2;
            this.metroLabel29.Text = "Beneficiary Name";
            this.metroLabel29.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // tcPayments
            // 
            this.tcPayments.Controls.Add(this.metroTabPage1);
            this.tcPayments.Location = new System.Drawing.Point(145, 269);
            this.tcPayments.Name = "tcPayments";
            this.tcPayments.SelectedIndex = 0;
            this.tcPayments.Size = new System.Drawing.Size(987, 311);
            this.tcPayments.TabIndex = 21;
            this.tcPayments.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.dgvPayments);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 39);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(979, 268);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Filtered Payments";
            this.metroTabPage1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            // 
            // dgvPayments
            // 
            this.dgvPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayments.Location = new System.Drawing.Point(0, 0);
            this.dgvPayments.Name = "dgvPayments";
            this.dgvPayments.RowTemplate.Height = 24;
            this.dgvPayments.Size = new System.Drawing.Size(974, 260);
            this.dgvPayments.TabIndex = 2;
            // 
            // tcCurrentPayment
            // 
            this.tcCurrentPayment.Controls.Add(this.tabCurrentPayment);
            this.tcCurrentPayment.Location = new System.Drawing.Point(149, 574);
            this.tcCurrentPayment.Name = "tcCurrentPayment";
            this.tcCurrentPayment.SelectedIndex = 0;
            this.tcCurrentPayment.Size = new System.Drawing.Size(987, 165);
            this.tcCurrentPayment.TabIndex = 22;
            this.tcCurrentPayment.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // tabCurrentPayment
            // 
            this.tabCurrentPayment.Controls.Add(this.btnRemakePayment);
            this.tabCurrentPayment.Controls.Add(this.btnGenerateReport);
            this.tabCurrentPayment.Controls.Add(this.rteDecription);
            this.tabCurrentPayment.Controls.Add(this.metroLabel2);
            this.tabCurrentPayment.HorizontalScrollbarBarColor = true;
            this.tabCurrentPayment.Location = new System.Drawing.Point(4, 39);
            this.tabCurrentPayment.Name = "tabCurrentPayment";
            this.tabCurrentPayment.Size = new System.Drawing.Size(979, 122);
            this.tabCurrentPayment.TabIndex = 0;
            this.tabCurrentPayment.Text = "Currenet Payment";
            this.tabCurrentPayment.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tabCurrentPayment.VerticalScrollbarBarColor = true;
            // 
            // btnRemakePayment
            // 
            this.btnRemakePayment.Location = new System.Drawing.Point(836, 63);
            this.btnRemakePayment.Name = "btnRemakePayment";
            this.btnRemakePayment.Size = new System.Drawing.Size(119, 39);
            this.btnRemakePayment.TabIndex = 82;
            this.btnRemakePayment.Text = "Remake payment";
            this.btnRemakePayment.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Location = new System.Drawing.Point(836, 14);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(119, 39);
            this.btnGenerateReport.TabIndex = 81;
            this.btnGenerateReport.Text = "Generate report";
            this.btnGenerateReport.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // rteDecription
            // 
            this.rteDecription.Location = new System.Drawing.Point(139, 13);
            this.rteDecription.Name = "rteDecription";
            this.rteDecription.Size = new System.Drawing.Size(674, 96);
            this.rteDecription.TabIndex = 80;
            this.rteDecription.Text = "";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(3, 47);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(79, 20);
            this.metroLabel2.TabIndex = 79;
            this.metroLabel2.Text = "Description";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 782);
            this.Controls.Add(this.tcCurrentPayment);
            this.Controls.Add(this.tcPayments);
            this.Controls.Add(this.tcFilterPayments);
            this.Controls.Add(this.navpan);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.lblP500);
            this.Name = "History";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.History_Load);
            this.navpan.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.tcFilterPayments.ResumeLayout(false);
            this.tabFilterPayments.ResumeLayout(false);
            this.tabFilterPayments.PerformLayout();
            this.tcPayments.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).EndInit();
            this.tcCurrentPayment.ResumeLayout(false);
            this.tabCurrentPayment.ResumeLayout(false);
            this.tabCurrentPayment.PerformLayout();
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
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private System.Windows.Forms.PictureBox pictureBox1;
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
        private System.Windows.Forms.DataGridView dgvPayments;
        private MetroFramework.Controls.MetroTabControl tcCurrentPayment;
        private MetroFramework.Controls.MetroTabPage tabCurrentPayment;
        private MetroFramework.Controls.MetroButton btnRemakePayment;
        private MetroFramework.Controls.MetroButton btnGenerateReport;
        private System.Windows.Forms.RichTextBox rteDecription;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtStatus;
        private MetroFramework.Controls.MetroLabel metroLabel3;
    }
}