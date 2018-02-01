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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payments));
            this.metroStyleExtender1 = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.tcCurrentpayment = new MetroFramework.Controls.MetroTabControl();
            this.tabCurrentPaymnet = new MetroFramework.Controls.MetroTabPage();
            this.checkInter = new MetroFramework.Controls.MetroCheckBox();
            this.txtInterval = new MetroFramework.Controls.MetroTextBox();
            this.cbxPaymentType = new MetroFramework.Controls.MetroComboBox();
            this.dtpPayDate = new MetroFramework.Controls.MetroDateTime();
            this.btnBatch = new MetroFramework.Controls.MetroButton();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtDescription = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.lblInterval = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnAddPayment = new MetroFramework.Controls.MetroButton();
            this.btnClear = new MetroFramework.Controls.MetroButton();
            this.txtAmount = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel29 = new MetroFramework.Controls.MetroLabel();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.btnShowAll = new MetroFramework.Controls.MetroButton();
            this.dgvBeneficiarys = new MetroFramework.Controls.MetroGrid();
            this.txtBName = new MetroFramework.Controls.MetroTextBox();
            this.btnSearchB = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.cbBAccType = new System.Windows.Forms.ComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.tcAddedPayments = new MetroFramework.Controls.MetroTabControl();
            this.tabAddedPayments = new MetroFramework.Controls.MetroTabPage();
            this.panel11 = new System.Windows.Forms.Panel();
            this.dgvAddedPayments = new MetroFramework.Controls.MetroGrid();
            this.btnRetryPayment = new MetroFramework.Controls.MetroButton();
            this.btnExacutePayment = new MetroFramework.Controls.MetroButton();
            this.btnDeletePayment = new MetroFramework.Controls.MetroButton();
            this.btnRetryAllPayment = new MetroFramework.Controls.MetroButton();
            this.btnExacuteAllPayment = new MetroFramework.Controls.MetroButton();
            this.btnDeleteAllPayment = new MetroFramework.Controls.MetroButton();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lblProfile = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnProfileImage = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBeneficiaryNew = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnScheduleNew = new System.Windows.Forms.Button();
            this.btnHistoryNew = new System.Windows.Forms.Button();
            this.btnPaymentNew = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnHomeNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.tcCurrentpayment.SuspendLayout();
            this.tabCurrentPaymnet.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBeneficiarys)).BeginInit();
            this.tcAddedPayments.SuspendLayout();
            this.tabAddedPayments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddedPayments)).BeginInit();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroStyleExtender1
            // 
            this.metroStyleExtender1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // tcCurrentpayment
            // 
            this.tcCurrentpayment.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tcCurrentpayment.Controls.Add(this.tabCurrentPaymnet);
            this.tcCurrentpayment.Controls.Add(this.metroTabPage1);
            this.tcCurrentpayment.Location = new System.Drawing.Point(186, 431);
            this.tcCurrentpayment.Name = "tcCurrentpayment";
            this.tcCurrentpayment.SelectedIndex = 0;
            this.tcCurrentpayment.Size = new System.Drawing.Size(906, 307);
            this.tcCurrentpayment.TabIndex = 19;
            this.tcCurrentpayment.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tcCurrentpayment.UseSelectable = true;
            // 
            // tabCurrentPaymnet
            // 
            this.tabCurrentPaymnet.Controls.Add(this.checkInter);
            this.tabCurrentPaymnet.Controls.Add(this.txtInterval);
            this.tabCurrentPaymnet.Controls.Add(this.cbxPaymentType);
            this.tabCurrentPaymnet.Controls.Add(this.dtpPayDate);
            this.tabCurrentPaymnet.Controls.Add(this.btnBatch);
            this.tabCurrentPaymnet.Controls.Add(this.metroLabel6);
            this.tabCurrentPaymnet.Controls.Add(this.txtDescription);
            this.tabCurrentPaymnet.Controls.Add(this.metroLabel5);
            this.tabCurrentPaymnet.Controls.Add(this.lblInterval);
            this.tabCurrentPaymnet.Controls.Add(this.metroLabel1);
            this.tabCurrentPaymnet.Controls.Add(this.btnAddPayment);
            this.tabCurrentPaymnet.Controls.Add(this.btnClear);
            this.tabCurrentPaymnet.Controls.Add(this.txtAmount);
            this.tabCurrentPaymnet.Controls.Add(this.metroLabel29);
            this.tabCurrentPaymnet.HorizontalScrollbarBarColor = true;
            this.tabCurrentPaymnet.HorizontalScrollbarHighlightOnWheel = false;
            this.tabCurrentPaymnet.HorizontalScrollbarSize = 10;
            this.tabCurrentPaymnet.Location = new System.Drawing.Point(4, 41);
            this.tabCurrentPaymnet.Name = "tabCurrentPaymnet";
            this.tabCurrentPaymnet.Size = new System.Drawing.Size(898, 262);
            this.tabCurrentPaymnet.TabIndex = 0;
            this.tabCurrentPaymnet.Text = "Current payment";
            this.tabCurrentPaymnet.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tabCurrentPaymnet.VerticalScrollbarBarColor = true;
            this.tabCurrentPaymnet.VerticalScrollbarHighlightOnWheel = false;
            this.tabCurrentPaymnet.VerticalScrollbarSize = 10;
            // 
            // checkInter
            // 
            this.checkInter.AutoSize = true;
            this.checkInter.BackColor = System.Drawing.Color.Transparent;
            this.checkInter.ForeColor = System.Drawing.Color.Transparent;
            this.checkInter.Location = new System.Drawing.Point(585, 94);
            this.checkInter.Name = "checkInter";
            this.checkInter.Size = new System.Drawing.Size(133, 17);
            this.checkInter.TabIndex = 5;
            this.checkInter.Text = "Recurring Payment";
            this.checkInter.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.checkInter.UseSelectable = true;
            this.checkInter.CheckedChanged += new System.EventHandler(this.checkInter_CheckedChanged);
            // 
            // txtInterval
            // 
            // 
            // 
            // 
            this.txtInterval.CustomButton.Image = null;
            this.txtInterval.CustomButton.Location = new System.Drawing.Point(232, 1);
            this.txtInterval.CustomButton.Name = "";
            this.txtInterval.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtInterval.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtInterval.CustomButton.TabIndex = 1;
            this.txtInterval.CustomButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtInterval.CustomButton.UseSelectable = true;
            this.txtInterval.CustomButton.Visible = false;
            this.txtInterval.Lines = new string[0];
            this.txtInterval.Location = new System.Drawing.Point(522, 149);
            this.txtInterval.MaxLength = 32767;
            this.txtInterval.Name = "txtInterval";
            this.txtInterval.PasswordChar = '\0';
            this.txtInterval.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtInterval.SelectedText = "";
            this.txtInterval.SelectionLength = 0;
            this.txtInterval.SelectionStart = 0;
            this.txtInterval.ShortcutsEnabled = true;
            this.txtInterval.Size = new System.Drawing.Size(254, 23);
            this.txtInterval.TabIndex = 6;
            this.txtInterval.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtInterval.UseSelectable = true;
            this.txtInterval.Visible = false;
            this.txtInterval.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtInterval.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cbxPaymentType
            // 
            this.cbxPaymentType.FormattingEnabled = true;
            this.cbxPaymentType.ItemHeight = 24;
            this.cbxPaymentType.Location = new System.Drawing.Point(14, 143);
            this.cbxPaymentType.Name = "cbxPaymentType";
            this.cbxPaymentType.Size = new System.Drawing.Size(215, 30);
            this.cbxPaymentType.TabIndex = 3;
            this.cbxPaymentType.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbxPaymentType.UseSelectable = true;
            // 
            // dtpPayDate
            // 
            this.dtpPayDate.Location = new System.Drawing.Point(511, 45);
            this.dtpPayDate.MinimumSize = new System.Drawing.Size(0, 30);
            this.dtpPayDate.Name = "dtpPayDate";
            this.dtpPayDate.Size = new System.Drawing.Size(299, 30);
            this.dtpPayDate.TabIndex = 4;
            this.dtpPayDate.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // btnBatch
            // 
            this.btnBatch.Highlight = true;
            this.btnBatch.Location = new System.Drawing.Point(761, 196);
            this.btnBatch.Name = "btnBatch";
            this.btnBatch.Size = new System.Drawing.Size(119, 44);
            this.btnBatch.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnBatch.TabIndex = 80;
            this.btnBatch.Text = "Load Batch File";
            this.btnBatch.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnBatch.UseSelectable = true;
            this.btnBatch.Visible = false;
            this.btnBatch.Click += new System.EventHandler(this.btnBatch_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(14, 120);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(114, 20);
            this.metroLabel6.TabIndex = 78;
            this.metroLabel6.Text = "Payment Method";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtDescription
            // 
            // 
            // 
            // 
            this.txtDescription.CustomButton.Image = null;
            this.txtDescription.CustomButton.Location = new System.Drawing.Point(363, 1);
            this.txtDescription.CustomButton.Name = "";
            this.txtDescription.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDescription.CustomButton.TabIndex = 1;
            this.txtDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtDescription.CustomButton.UseSelectable = true;
            this.txtDescription.CustomButton.Visible = false;
            this.txtDescription.Lines = new string[0];
            this.txtDescription.Location = new System.Drawing.Point(14, 45);
            this.txtDescription.MaxLength = 32767;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PasswordChar = '\0';
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescription.SelectedText = "";
            this.txtDescription.SelectionLength = 0;
            this.txtDescription.SelectionStart = 0;
            this.txtDescription.ShortcutsEnabled = true;
            this.txtDescription.Size = new System.Drawing.Size(385, 23);
            this.txtDescription.TabIndex = 1;
            this.txtDescription.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtDescription.UseSelectable = true;
            this.txtDescription.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDescription.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(14, 22);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(79, 20);
            this.metroLabel5.TabIndex = 75;
            this.metroLabel5.Text = "Description";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblInterval
            // 
            this.lblInterval.AutoSize = true;
            this.lblInterval.Location = new System.Drawing.Point(510, 120);
            this.lblInterval.Name = "lblInterval";
            this.lblInterval.Size = new System.Drawing.Size(96, 20);
            this.lblInterval.TabIndex = 71;
            this.lblInterval.Text = "Select Interval";
            this.lblInterval.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblInterval.Visible = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(510, 22);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(95, 20);
            this.metroLabel1.TabIndex = 65;
            this.metroLabel1.Text = "Payment Date";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // btnAddPayment
            // 
            this.btnAddPayment.Highlight = true;
            this.btnAddPayment.Location = new System.Drawing.Point(14, 196);
            this.btnAddPayment.Name = "btnAddPayment";
            this.btnAddPayment.Size = new System.Drawing.Size(119, 44);
            this.btnAddPayment.Style = MetroFramework.MetroColorStyle.Green;
            this.btnAddPayment.TabIndex = 9;
            this.btnAddPayment.Text = "Add Payment";
            this.btnAddPayment.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnAddPayment.UseSelectable = true;
            this.btnAddPayment.Click += new System.EventHandler(this.btnAddPayment_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(139, 196);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(119, 44);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Reset Fields";
            this.btnClear.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnClear.UseSelectable = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtAmount
            // 
            // 
            // 
            // 
            this.txtAmount.CustomButton.Image = null;
            this.txtAmount.CustomButton.Location = new System.Drawing.Point(157, 1);
            this.txtAmount.CustomButton.Name = "";
            this.txtAmount.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAmount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAmount.CustomButton.TabIndex = 1;
            this.txtAmount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtAmount.CustomButton.UseSelectable = true;
            this.txtAmount.CustomButton.Visible = false;
            this.txtAmount.Lines = new string[0];
            this.txtAmount.Location = new System.Drawing.Point(14, 94);
            this.txtAmount.MaxLength = 32767;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.PasswordChar = '\0';
            this.txtAmount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAmount.SelectedText = "";
            this.txtAmount.SelectionLength = 0;
            this.txtAmount.SelectionStart = 0;
            this.txtAmount.ShortcutsEnabled = true;
            this.txtAmount.Size = new System.Drawing.Size(179, 23);
            this.txtAmount.TabIndex = 2;
            this.txtAmount.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtAmount.UseSelectable = true;
            this.txtAmount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAmount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel29
            // 
            this.metroLabel29.AutoSize = true;
            this.metroLabel29.Location = new System.Drawing.Point(14, 71);
            this.metroLabel29.Name = "metroLabel29";
            this.metroLabel29.Size = new System.Drawing.Size(58, 20);
            this.metroLabel29.TabIndex = 2;
            this.metroLabel29.Text = "Amount";
            this.metroLabel29.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.btnShowAll);
            this.metroTabPage1.Controls.Add(this.dgvBeneficiarys);
            this.metroTabPage1.Controls.Add(this.txtBName);
            this.metroTabPage1.Controls.Add(this.btnSearchB);
            this.metroTabPage1.Controls.Add(this.metroLabel3);
            this.metroTabPage1.Controls.Add(this.cbBAccType);
            this.metroTabPage1.Controls.Add(this.metroLabel2);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 42);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(898, 261);
            this.metroTabPage1.TabIndex = 1;
            this.metroTabPage1.Text = "Associate Beneficiaries";
            this.metroTabPage1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(697, 160);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(119, 44);
            this.btnShowAll.TabIndex = 84;
            this.btnShowAll.Text = "Show all";
            this.btnShowAll.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnShowAll.UseSelectable = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // dgvBeneficiarys
            // 
            this.dgvBeneficiarys.AllowUserToAddRows = false;
            this.dgvBeneficiarys.AllowUserToDeleteRows = false;
            this.dgvBeneficiarys.AllowUserToResizeColumns = false;
            this.dgvBeneficiarys.AllowUserToResizeRows = false;
            this.dgvBeneficiarys.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBeneficiarys.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dgvBeneficiarys.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBeneficiarys.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvBeneficiarys.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBeneficiarys.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBeneficiarys.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBeneficiarys.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvBeneficiarys.EnableHeadersVisualStyles = false;
            this.dgvBeneficiarys.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvBeneficiarys.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dgvBeneficiarys.Location = new System.Drawing.Point(3, 9);
            this.dgvBeneficiarys.Name = "dgvBeneficiarys";
            this.dgvBeneficiarys.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBeneficiarys.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvBeneficiarys.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvBeneficiarys.RowTemplate.Height = 24;
            this.dgvBeneficiarys.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBeneficiarys.Size = new System.Drawing.Size(420, 256);
            this.dgvBeneficiarys.TabIndex = 83;
            this.dgvBeneficiarys.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.dgvBeneficiarys.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBeneficiarys_CellContentClick_1);
            this.dgvBeneficiarys.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBeneficiarys_RowEnter);
            // 
            // txtBName
            // 
            // 
            // 
            // 
            this.txtBName.CustomButton.Image = null;
            this.txtBName.CustomButton.Location = new System.Drawing.Point(231, 1);
            this.txtBName.CustomButton.Name = "";
            this.txtBName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBName.CustomButton.TabIndex = 1;
            this.txtBName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtBName.CustomButton.UseSelectable = true;
            this.txtBName.CustomButton.Visible = false;
            this.txtBName.Lines = new string[0];
            this.txtBName.Location = new System.Drawing.Point(537, 43);
            this.txtBName.MaxLength = 32767;
            this.txtBName.Name = "txtBName";
            this.txtBName.PasswordChar = '\0';
            this.txtBName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBName.SelectedText = "";
            this.txtBName.SelectionLength = 0;
            this.txtBName.SelectionStart = 0;
            this.txtBName.ShortcutsEnabled = true;
            this.txtBName.Size = new System.Drawing.Size(253, 23);
            this.txtBName.TabIndex = 7;
            this.txtBName.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtBName.UseSelectable = true;
            this.txtBName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnSearchB
            // 
            this.btnSearchB.Location = new System.Drawing.Point(522, 160);
            this.btnSearchB.Name = "btnSearchB";
            this.btnSearchB.Size = new System.Drawing.Size(119, 44);
            this.btnSearchB.TabIndex = 78;
            this.btnSearchB.Text = "Search Beneficiary";
            this.btnSearchB.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnSearchB.UseSelectable = true;
            this.btnSearchB.Click += new System.EventHandler(this.btnSearchB_Click_1);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(537, 79);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(174, 20);
            this.metroLabel3.TabIndex = 77;
            this.metroLabel3.Text = "Select Beneficiary Account";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // cbBAccType
            // 
            this.cbBAccType.FormattingEnabled = true;
            this.cbBAccType.Location = new System.Drawing.Point(537, 102);
            this.cbBAccType.Name = "cbBAccType";
            this.cbBAccType.Size = new System.Drawing.Size(253, 24);
            this.cbBAccType.TabIndex = 8;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(537, 20);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(120, 20);
            this.metroLabel2.TabIndex = 75;
            this.metroLabel2.Text = "Beneficiary Name";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // tcAddedPayments
            // 
            this.tcAddedPayments.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tcAddedPayments.Controls.Add(this.tabAddedPayments);
            this.tcAddedPayments.Location = new System.Drawing.Point(181, 98);
            this.tcAddedPayments.Name = "tcAddedPayments";
            this.tcAddedPayments.SelectedIndex = 0;
            this.tcAddedPayments.Size = new System.Drawing.Size(911, 331);
            this.tcAddedPayments.TabIndex = 20;
            this.tcAddedPayments.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tcAddedPayments.UseSelectable = true;
            // 
            // tabAddedPayments
            // 
            this.tabAddedPayments.Controls.Add(this.panel11);
            this.tabAddedPayments.Controls.Add(this.dgvAddedPayments);
            this.tabAddedPayments.Controls.Add(this.btnRetryPayment);
            this.tabAddedPayments.Controls.Add(this.btnExacutePayment);
            this.tabAddedPayments.Controls.Add(this.btnDeletePayment);
            this.tabAddedPayments.Controls.Add(this.btnRetryAllPayment);
            this.tabAddedPayments.Controls.Add(this.btnExacuteAllPayment);
            this.tabAddedPayments.Controls.Add(this.btnDeleteAllPayment);
            this.tabAddedPayments.HorizontalScrollbarBarColor = true;
            this.tabAddedPayments.HorizontalScrollbarHighlightOnWheel = false;
            this.tabAddedPayments.HorizontalScrollbarSize = 10;
            this.tabAddedPayments.Location = new System.Drawing.Point(4, 41);
            this.tabAddedPayments.Name = "tabAddedPayments";
            this.tabAddedPayments.Size = new System.Drawing.Size(903, 286);
            this.tabAddedPayments.TabIndex = 0;
            this.tabAddedPayments.Text = "Added Payments";
            this.tabAddedPayments.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tabAddedPayments.VerticalScrollbarBarColor = true;
            this.tabAddedPayments.VerticalScrollbarHighlightOnWheel = false;
            this.tabAddedPayments.VerticalScrollbarSize = 10;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.DimGray;
            this.panel11.Location = new System.Drawing.Point(16, 273);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(869, 10);
            this.panel11.TabIndex = 83;
            // 
            // dgvAddedPayments
            // 
            this.dgvAddedPayments.AllowUserToAddRows = false;
            this.dgvAddedPayments.AllowUserToDeleteRows = false;
            this.dgvAddedPayments.AllowUserToResizeColumns = false;
            this.dgvAddedPayments.AllowUserToResizeRows = false;
            this.dgvAddedPayments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAddedPayments.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dgvAddedPayments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAddedPayments.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvAddedPayments.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAddedPayments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAddedPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAddedPayments.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAddedPayments.EnableHeadersVisualStyles = false;
            this.dgvAddedPayments.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvAddedPayments.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dgvAddedPayments.Location = new System.Drawing.Point(1, 3);
            this.dgvAddedPayments.Name = "dgvAddedPayments";
            this.dgvAddedPayments.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAddedPayments.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAddedPayments.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvAddedPayments.RowTemplate.Height = 24;
            this.dgvAddedPayments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAddedPayments.Size = new System.Drawing.Size(899, 183);
            this.dgvAddedPayments.TabIndex = 82;
            this.dgvAddedPayments.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.dgvAddedPayments.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBeneficiarys_CellContentClick_1);
            this.dgvAddedPayments.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAddedPayments_RowEnter);
            // 
            // btnRetryPayment
            // 
            this.btnRetryPayment.Location = new System.Drawing.Point(161, 214);
            this.btnRetryPayment.Name = "btnRetryPayment";
            this.btnRetryPayment.Size = new System.Drawing.Size(119, 36);
            this.btnRetryPayment.TabIndex = 81;
            this.btnRetryPayment.Text = "Retry Payment ";
            this.btnRetryPayment.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnRetryPayment.UseSelectable = true;
            this.btnRetryPayment.Click += new System.EventHandler(this.btnRetryPayment_Click);
            // 
            // btnExacutePayment
            // 
            this.btnExacutePayment.Location = new System.Drawing.Point(286, 214);
            this.btnExacutePayment.Name = "btnExacutePayment";
            this.btnExacutePayment.Size = new System.Drawing.Size(119, 36);
            this.btnExacutePayment.TabIndex = 80;
            this.btnExacutePayment.Text = "Execute Payments";
            this.btnExacutePayment.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnExacutePayment.UseSelectable = true;
            this.btnExacutePayment.Click += new System.EventHandler(this.btnExacutePayment_Click);
            // 
            // btnDeletePayment
            // 
            this.btnDeletePayment.Location = new System.Drawing.Point(36, 214);
            this.btnDeletePayment.Name = "btnDeletePayment";
            this.btnDeletePayment.Size = new System.Drawing.Size(119, 36);
            this.btnDeletePayment.TabIndex = 79;
            this.btnDeletePayment.Text = "Delete Payment";
            this.btnDeletePayment.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnDeletePayment.UseSelectable = true;
            this.btnDeletePayment.Click += new System.EventHandler(this.btnDeletePayment_Click);
            // 
            // btnRetryAllPayment
            // 
            this.btnRetryAllPayment.Location = new System.Drawing.Point(578, 214);
            this.btnRetryAllPayment.Name = "btnRetryAllPayment";
            this.btnRetryAllPayment.Size = new System.Drawing.Size(119, 36);
            this.btnRetryAllPayment.TabIndex = 78;
            this.btnRetryAllPayment.Text = "Retry All Payments";
            this.btnRetryAllPayment.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnRetryAllPayment.UseSelectable = true;
            this.btnRetryAllPayment.Click += new System.EventHandler(this.btnRetryAllPayment_Click);
            // 
            // btnExacuteAllPayment
            // 
            this.btnExacuteAllPayment.Location = new System.Drawing.Point(703, 214);
            this.btnExacuteAllPayment.Name = "btnExacuteAllPayment";
            this.btnExacuteAllPayment.Size = new System.Drawing.Size(136, 36);
            this.btnExacuteAllPayment.TabIndex = 77;
            this.btnExacuteAllPayment.Text = "Execute All Payments";
            this.btnExacuteAllPayment.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnExacuteAllPayment.UseSelectable = true;
            this.btnExacuteAllPayment.Click += new System.EventHandler(this.btnExacuteAllPayment_Click);
            // 
            // btnDeleteAllPayment
            // 
            this.btnDeleteAllPayment.Location = new System.Drawing.Point(453, 214);
            this.btnDeleteAllPayment.Name = "btnDeleteAllPayment";
            this.btnDeleteAllPayment.Size = new System.Drawing.Size(119, 36);
            this.btnDeleteAllPayment.TabIndex = 76;
            this.btnDeleteAllPayment.Text = "Delete All payment";
            this.btnDeleteAllPayment.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnDeleteAllPayment.UseSelectable = true;
            this.btnDeleteAllPayment.Click += new System.EventHandler(this.btnDeleteAllPayment_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel8.Controls.Add(this.lblProfile);
            this.panel8.Controls.Add(this.pictureBox1);
            this.panel8.ForeColor = System.Drawing.Color.White;
            this.panel8.Location = new System.Drawing.Point(186, 4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(906, 100);
            this.panel8.TabIndex = 65;
            // 
            // lblProfile
            // 
            this.lblProfile.AutoSize = true;
            this.lblProfile.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfile.Location = new System.Drawing.Point(430, 31);
            this.lblProfile.Name = "lblProfile";
            this.lblProfile.Size = new System.Drawing.Size(129, 30);
            this.lblProfile.TabIndex = 1;
            this.lblProfile.Text = "Payments";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.btnProfileImage);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnBeneficiaryNew);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnScheduleNew);
            this.panel1.Controls.Add(this.btnHistoryNew);
            this.panel1.Controls.Add(this.btnPaymentNew);
            this.panel1.Controls.Add(this.btnProfile);
            this.panel1.Controls.Add(this.btnHomeNew);
            this.panel1.Location = new System.Drawing.Point(0, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 734);
            this.panel1.TabIndex = 64;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Red;
            this.panel9.Location = new System.Drawing.Point(0, 642);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(10, 66);
            this.panel9.TabIndex = 8;
            // 
            // btnProfileImage
            // 
            this.btnProfileImage.FlatAppearance.BorderSize = 0;
            this.btnProfileImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfileImage.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfileImage.ForeColor = System.Drawing.Color.White;
            this.btnProfileImage.Image = ((System.Drawing.Image)(resources.GetObject("btnProfileImage.Image")));
            this.btnProfileImage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfileImage.Location = new System.Drawing.Point(13, 3);
            this.btnProfileImage.Name = "btnProfileImage";
            this.btnProfileImage.Size = new System.Drawing.Size(164, 71);
            this.btnProfileImage.TabIndex = 8;
            this.btnProfileImage.Text = " Username";
            this.btnProfileImage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProfileImage.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel7.Location = new System.Drawing.Point(0, 441);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(10, 66);
            this.panel7.TabIndex = 7;
            this.panel7.Visible = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel6.Location = new System.Drawing.Point(0, 373);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(10, 66);
            this.panel6.TabIndex = 5;
            this.panel6.Visible = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel5.Location = new System.Drawing.Point(0, 305);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 66);
            this.panel5.TabIndex = 4;
            this.panel5.Visible = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel4.Location = new System.Drawing.Point(0, 238);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 65);
            this.panel4.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel3.Location = new System.Drawing.Point(0, 171);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 60);
            this.panel3.TabIndex = 3;
            this.panel3.Visible = false;
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
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
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
            this.btnBeneficiaryNew.Click += new System.EventHandler(this.btnBeneficiary_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel2.Location = new System.Drawing.Point(0, 94);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 71);
            this.panel2.TabIndex = 2;
            this.panel2.Visible = false;
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
            this.btnScheduleNew.Click += new System.EventHandler(this.btnScheduel_Click);
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
            this.btnHistoryNew.Click += new System.EventHandler(this.btnHistory_Click);
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
            this.btnPaymentNew.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.ForeColor = System.Drawing.Color.Transparent;
            this.btnProfile.Image = ((System.Drawing.Image)(resources.GetObject("btnProfile.Image")));
            this.btnProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfile.Location = new System.Drawing.Point(16, 171);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(164, 61);
            this.btnProfile.TabIndex = 1;
            this.btnProfile.Text = "  Profile";
            this.btnProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
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
            this.btnHomeNew.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // Payments
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1093, 742);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tcAddedPayments);
            this.Controls.Add(this.tcCurrentpayment);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Payments";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Payments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.tcCurrentpayment.ResumeLayout(false);
            this.tabCurrentPaymnet.ResumeLayout(false);
            this.tabCurrentPaymnet.PerformLayout();
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBeneficiarys)).EndInit();
            this.tcAddedPayments.ResumeLayout(false);
            this.tabAddedPayments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddedPayments)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Components.MetroStyleExtender metroStyleExtender1;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroTabControl tcCurrentpayment;
        private MetroFramework.Controls.MetroTabPage tabCurrentPaymnet;
        private MetroFramework.Controls.MetroButton btnAddPayment;
        private MetroFramework.Controls.MetroButton btnClear;
        private MetroFramework.Controls.MetroTextBox txtAmount;
        private MetroFramework.Controls.MetroLabel metroLabel29;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTabControl tcAddedPayments;
        private MetroFramework.Controls.MetroTabPage tabAddedPayments;
        private MetroFramework.Controls.MetroTextBox txtDescription;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel lblInterval;
        private MetroFramework.Controls.MetroButton btnRetryPayment;
        private MetroFramework.Controls.MetroButton btnExacutePayment;
        private MetroFramework.Controls.MetroButton btnDeletePayment;
        private MetroFramework.Controls.MetroButton btnRetryAllPayment;
        private MetroFramework.Controls.MetroButton btnExacuteAllPayment;
        private MetroFramework.Controls.MetroButton btnDeleteAllPayment;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroButton btnBatch;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lblProfile;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnProfileImage;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBeneficiaryNew;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnScheduleNew;
        private System.Windows.Forms.Button btnHistoryNew;
        private System.Windows.Forms.Button btnPaymentNew;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnHomeNew;
        private MetroFramework.Controls.MetroComboBox cbxPaymentType;
        private MetroFramework.Controls.MetroDateTime dtpPayDate;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTextBox txtBName;
        private MetroFramework.Controls.MetroButton btnSearchB;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.ComboBox cbBAccType;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroGrid dgvAddedPayments;
        private MetroFramework.Controls.MetroGrid dgvBeneficiarys;
        private MetroFramework.Controls.MetroTextBox txtInterval;
        private MetroFramework.Controls.MetroCheckBox checkInter;
        private MetroFramework.Controls.MetroButton btnShowAll;
        private System.Windows.Forms.Panel panel11;
    }
}