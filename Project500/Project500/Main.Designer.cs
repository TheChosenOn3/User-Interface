namespace Project500
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.navpan = new MetroFramework.Controls.MetroPanel();
            this.btnBeneficiary = new MetroFramework.Controls.MetroButton();
            this.metroStyleExtender1 = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.tcNotifications = new MetroFramework.Controls.MetroTabControl();
            this.tabNotifications = new MetroFramework.Controls.MetroTabPage();
            this.btnHome = new MetroFramework.Controls.MetroButton();
            this.btnProfile = new MetroFramework.Controls.MetroButton();
            this.btnPayment = new MetroFramework.Controls.MetroButton();
            this.btnHistory = new MetroFramework.Controls.MetroButton();
            this.btnScheduel = new MetroFramework.Controls.MetroButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHomeNew = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnPaymentNew = new System.Windows.Forms.Button();
            this.btnHistoryNew = new System.Windows.Forms.Button();
            this.btnScheduleNew = new System.Windows.Forms.Button();
            this.btnBeneficiaryNew = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.navpan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.tcNotifications.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.navpan.Location = new System.Drawing.Point(911, 26);
            this.navpan.Name = "navpan";
            this.navpan.Size = new System.Drawing.Size(134, 693);
            this.navpan.TabIndex = 0;
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
            this.btnBeneficiary.UseSelectable = true;
            this.btnBeneficiary.Click += new System.EventHandler(this.btnBeneficiary_Click);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // tcNotifications
            // 
            this.tcNotifications.Controls.Add(this.tabNotifications);
            this.tcNotifications.Location = new System.Drawing.Point(182, 100);
            this.tcNotifications.Name = "tcNotifications";
            this.tcNotifications.SelectedIndex = 0;
            this.tcNotifications.Size = new System.Drawing.Size(897, 438);
            this.tcNotifications.TabIndex = 60;
            this.tcNotifications.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tcNotifications.UseSelectable = true;
            // 
            // tabNotifications
            // 
            this.tabNotifications.HorizontalScrollbarBarColor = true;
            this.tabNotifications.HorizontalScrollbarHighlightOnWheel = false;
            this.tabNotifications.HorizontalScrollbarSize = 10;
            this.tabNotifications.Location = new System.Drawing.Point(4, 38);
            this.tabNotifications.Name = "tabNotifications";
            this.tabNotifications.Size = new System.Drawing.Size(889, 396);
            this.tabNotifications.TabIndex = 0;
            this.tabNotifications.Text = "Yourr Daily Notofications";
            this.tabNotifications.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tabNotifications.VerticalScrollbarBarColor = true;
            this.tabNotifications.VerticalScrollbarHighlightOnWheel = false;
            this.tabNotifications.VerticalScrollbarSize = 10;
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
            this.btnHome.UseSelectable = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
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
            this.btnProfile.UseSelectable = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
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
            this.btnPayment.UseSelectable = true;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
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
            this.btnHistory.UseSelectable = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
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
            this.btnScheduel.UseSelectable = true;
            this.btnScheduel.Click += new System.EventHandler(this.btnScheduel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnBeneficiaryNew);
            this.panel1.Controls.Add(this.btnScheduleNew);
            this.panel1.Controls.Add(this.btnHistoryNew);
            this.panel1.Controls.Add(this.btnPaymentNew);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnHomeNew);
            this.panel1.Location = new System.Drawing.Point(0, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 734);
            this.panel1.TabIndex = 2;
            // 
            // btnHomeNew
            // 
            this.btnHomeNew.FlatAppearance.BorderSize = 0;
            this.btnHomeNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHomeNew.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomeNew.ForeColor = System.Drawing.Color.White;
            this.btnHomeNew.Image = ((System.Drawing.Image)(resources.GetObject("btnHomeNew.Image")));
            this.btnHomeNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHomeNew.Location = new System.Drawing.Point(16, 94);
            this.btnHomeNew.Name = "btnHomeNew";
            this.btnHomeNew.Size = new System.Drawing.Size(164, 71);
            this.btnHomeNew.TabIndex = 0;
            this.btnHomeNew.Text = "  Home";
            this.btnHomeNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHomeNew.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(16, 171);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 61);
            this.button2.TabIndex = 1;
            this.button2.Text = "  Profile";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnPaymentNew
            // 
            this.btnPaymentNew.FlatAppearance.BorderSize = 0;
            this.btnPaymentNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaymentNew.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaymentNew.ForeColor = System.Drawing.Color.Transparent;
            this.btnPaymentNew.Image = ((System.Drawing.Image)(resources.GetObject("btnPaymentNew.Image")));
            this.btnPaymentNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPaymentNew.Location = new System.Drawing.Point(16, 238);
            this.btnPaymentNew.Name = "btnPaymentNew";
            this.btnPaymentNew.Size = new System.Drawing.Size(164, 71);
            this.btnPaymentNew.TabIndex = 2;
            this.btnPaymentNew.Text = "  Payment";
            this.btnPaymentNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPaymentNew.UseVisualStyleBackColor = true;
            // 
            // btnHistoryNew
            // 
            this.btnHistoryNew.FlatAppearance.BorderSize = 0;
            this.btnHistoryNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistoryNew.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistoryNew.ForeColor = System.Drawing.Color.Transparent;
            this.btnHistoryNew.Image = ((System.Drawing.Image)(resources.GetObject("btnHistoryNew.Image")));
            this.btnHistoryNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistoryNew.Location = new System.Drawing.Point(16, 305);
            this.btnHistoryNew.Name = "btnHistoryNew";
            this.btnHistoryNew.Size = new System.Drawing.Size(164, 71);
            this.btnHistoryNew.TabIndex = 3;
            this.btnHistoryNew.Text = "  History";
            this.btnHistoryNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHistoryNew.UseVisualStyleBackColor = true;
            // 
            // btnScheduleNew
            // 
            this.btnScheduleNew.FlatAppearance.BorderSize = 0;
            this.btnScheduleNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScheduleNew.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScheduleNew.ForeColor = System.Drawing.Color.Transparent;
            this.btnScheduleNew.Image = ((System.Drawing.Image)(resources.GetObject("btnScheduleNew.Image")));
            this.btnScheduleNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnScheduleNew.Location = new System.Drawing.Point(16, 373);
            this.btnScheduleNew.Name = "btnScheduleNew";
            this.btnScheduleNew.Size = new System.Drawing.Size(164, 71);
            this.btnScheduleNew.TabIndex = 4;
            this.btnScheduleNew.Text = "  Schedule";
            this.btnScheduleNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnScheduleNew.UseVisualStyleBackColor = true;
            // 
            // btnBeneficiaryNew
            // 
            this.btnBeneficiaryNew.FlatAppearance.BorderSize = 0;
            this.btnBeneficiaryNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBeneficiaryNew.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBeneficiaryNew.ForeColor = System.Drawing.Color.Transparent;
            this.btnBeneficiaryNew.Image = ((System.Drawing.Image)(resources.GetObject("btnBeneficiaryNew.Image")));
            this.btnBeneficiaryNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBeneficiaryNew.Location = new System.Drawing.Point(16, 441);
            this.btnBeneficiaryNew.Name = "btnBeneficiaryNew";
            this.btnBeneficiaryNew.Size = new System.Drawing.Size(164, 71);
            this.btnBeneficiaryNew.TabIndex = 5;
            this.btnBeneficiaryNew.Text = " Beneficiary";
            this.btnBeneficiaryNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBeneficiaryNew.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Transparent;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(16, 642);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(164, 71);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "     Exit";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1093, 742);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tcNotifications);
            this.Controls.Add(this.navpan);
            this.HelpButton = true;
            this.Name = "Main";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Main_Load);
            this.navpan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.tcNotifications.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel navpan;
        private MetroFramework.Controls.MetroButton btnBeneficiary;
        private MetroFramework.Components.MetroStyleExtender metroStyleExtender1;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroTabControl tcNotifications;
        private MetroFramework.Controls.MetroTabPage tabNotifications;
        private MetroFramework.Controls.MetroButton btnScheduel;
        private MetroFramework.Controls.MetroButton btnHistory;
        private MetroFramework.Controls.MetroButton btnPayment;
        private MetroFramework.Controls.MetroButton btnProfile;
        private MetroFramework.Controls.MetroButton btnHome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHomeNew;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBeneficiaryNew;
        private System.Windows.Forms.Button btnScheduleNew;
        private System.Windows.Forms.Button btnHistoryNew;
        private System.Windows.Forms.Button btnPaymentNew;
        private System.Windows.Forms.Button button2;
    }
}