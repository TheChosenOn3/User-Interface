namespace Project500
{
    partial class Login
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
            this.btnHome = new MetroFramework.Controls.MetroButton();
            this.navpan = new MetroFramework.Controls.MetroPanel();
            this.lblHeading = new MetroFramework.Controls.MetroLabel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblP500 = new MetroFramework.Controls.MetroLabel();
            this.tcLogin = new MetroFramework.Controls.MetroTabControl();
            this.tabLogin = new MetroFramework.Controls.MetroTabPage();
            this.btnLogin = new MetroFramework.Controls.MetroButton();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btnClear = new MetroFramework.Controls.MetroButton();
            this.txtUsername = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.navpan.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tcLogin.SuspendLayout();
            this.tabLogin.SuspendLayout();
            this.SuspendLayout();
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
            // 
            // navpan
            // 
            this.navpan.Controls.Add(this.btnHome);
            this.navpan.HorizontalScrollbarBarColor = true;
            this.navpan.HorizontalScrollbarHighlightOnWheel = false;
            this.navpan.HorizontalScrollbarSize = 10;
            this.navpan.Location = new System.Drawing.Point(8, 121);
            this.navpan.Name = "navpan";
            this.navpan.Size = new System.Drawing.Size(134, 107);
            this.navpan.TabIndex = 10;
            this.navpan.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.navpan.VerticalScrollbarBarColor = true;
            this.navpan.VerticalScrollbarHighlightOnWheel = false;
            this.navpan.VerticalScrollbarSize = 10;
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblHeading.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblHeading.Location = new System.Drawing.Point(397, 24);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(215, 25);
            this.lblHeading.TabIndex = 11;
            this.lblHeading.Text = "Login To Your Account";
            this.lblHeading.Theme = MetroFramework.MetroThemeStyle.Dark;
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
            this.metroPanel2.Location = new System.Drawing.Point(8, 12);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(134, 103);
            this.metroPanel2.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroPanel2.TabIndex = 12;
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
            // lblP500
            // 
            this.lblP500.AutoSize = true;
            this.lblP500.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblP500.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblP500.Location = new System.Drawing.Point(172, 24);
            this.lblP500.Name = "lblP500";
            this.lblP500.Size = new System.Drawing.Size(113, 25);
            this.lblP500.TabIndex = 14;
            this.lblP500.Text = "Project 500";
            this.lblP500.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // tcLogin
            // 
            this.tcLogin.Controls.Add(this.tabLogin);
            this.tcLogin.Location = new System.Drawing.Point(161, 63);
            this.tcLogin.Name = "tcLogin";
            this.tcLogin.SelectedIndex = 0;
            this.tcLogin.Size = new System.Drawing.Size(672, 221);
            this.tcLogin.TabIndex = 60;
            this.tcLogin.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // tabLogin
            // 
            this.tabLogin.Controls.Add(this.btnLogin);
            this.tabLogin.Controls.Add(this.txtPassword);
            this.tabLogin.Controls.Add(this.metroLabel2);
            this.tabLogin.Controls.Add(this.btnClear);
            this.tabLogin.Controls.Add(this.txtUsername);
            this.tabLogin.Controls.Add(this.metroLabel1);
            this.tabLogin.HorizontalScrollbarBarColor = true;
            this.tabLogin.Location = new System.Drawing.Point(4, 39);
            this.tabLogin.Name = "tabLogin";
            this.tabLogin.Size = new System.Drawing.Size(664, 178);
            this.tabLogin.TabIndex = 0;
            this.tabLogin.Text = "Enter Login Details";
            this.tabLogin.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tabLogin.VerticalScrollbarBarColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(365, 126);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(119, 44);
            this.btnLogin.TabIndex = 43;
            this.btnLogin.Text = "Login";
            this.btnLogin.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(365, 48);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(127, 23);
            this.txtPassword.TabIndex = 42;
            this.txtPassword.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(181, 51);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(66, 20);
            this.metroLabel2.TabIndex = 41;
            this.metroLabel2.Text = "Password";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(173, 126);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(119, 44);
            this.btnClear.TabIndex = 40;
            this.btnClear.Text = "Clear Flields";
            this.btnClear.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(365, 9);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(127, 23);
            this.txtUsername.TabIndex = 39;
            this.txtUsername.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(181, 12);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(73, 20);
            this.metroLabel1.TabIndex = 38;
            this.metroLabel1.Text = "Username";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 307);
            this.Controls.Add(this.tcLogin);
            this.Controls.Add(this.navpan);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.lblP500);
            this.Name = "Login";
            this.Text = "Login";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Login_Load);
            this.navpan.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tcLogin.ResumeLayout(false);
            this.tabLogin.ResumeLayout(false);
            this.tabLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnHome;
        private MetroFramework.Controls.MetroPanel navpan;
        private MetroFramework.Controls.MetroLabel lblHeading;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel lblP500;
        private MetroFramework.Controls.MetroTabControl tcLogin;
        private MetroFramework.Controls.MetroTabPage tabLogin;
        private MetroFramework.Controls.MetroButton btnLogin;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton btnClear;
        private MetroFramework.Controls.MetroTextBox txtUsername;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}