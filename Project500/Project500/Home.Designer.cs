namespace Project500
{
    partial class Home
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
            this.lblHeading = new MetroFramework.Controls.MetroLabel();
            this.lblP500 = new MetroFramework.Controls.MetroLabel();
            this.tcWelcome = new MetroFramework.Controls.MetroTabControl();
            this.tabWelcome = new MetroFramework.Controls.MetroTabPage();
            this.btnregister = new MetroFramework.Controls.MetroButton();
            this.btnlogin = new MetroFramework.Controls.MetroButton();
            this.tcWelcome.SuspendLayout();
            this.tabWelcome.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblHeading.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblHeading.Location = new System.Drawing.Point(344, 23);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(93, 25);
            this.lblHeading.TabIndex = 5;
            this.lblHeading.Text = "Welcome";
            this.lblHeading.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblP500
            // 
            this.lblP500.AutoSize = true;
            this.lblP500.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblP500.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblP500.Location = new System.Drawing.Point(170, 23);
            this.lblP500.Name = "lblP500";
            this.lblP500.Size = new System.Drawing.Size(113, 25);
            this.lblP500.TabIndex = 7;
            this.lblP500.Text = "Project 500";
            this.lblP500.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // tcWelcome
            // 
            this.tcWelcome.Controls.Add(this.tabWelcome);
            this.tcWelcome.Location = new System.Drawing.Point(146, 51);
            this.tcWelcome.Name = "tcWelcome";
            this.tcWelcome.SelectedIndex = 0;
            this.tcWelcome.Size = new System.Drawing.Size(482, 136);
            this.tcWelcome.TabIndex = 59;
            this.tcWelcome.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // tabWelcome
            // 
            this.tabWelcome.Controls.Add(this.btnregister);
            this.tabWelcome.Controls.Add(this.btnlogin);
            this.tabWelcome.HorizontalScrollbarBarColor = true;
            this.tabWelcome.Location = new System.Drawing.Point(4, 39);
            this.tabWelcome.Name = "tabWelcome";
            this.tabWelcome.Size = new System.Drawing.Size(474, 93);
            this.tabWelcome.TabIndex = 0;
            this.tabWelcome.Text = "Do You Want To";
            this.tabWelcome.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tabWelcome.VerticalScrollbarBarColor = true;
            // 
            // btnregister
            // 
            this.btnregister.Location = new System.Drawing.Point(270, 24);
            this.btnregister.Name = "btnregister";
            this.btnregister.Size = new System.Drawing.Size(119, 44);
            this.btnregister.TabIndex = 60;
            this.btnregister.Text = "Register";
            this.btnregister.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnregister.Click += new System.EventHandler(this.btnregister_Click);
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(86, 24);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(119, 44);
            this.btnlogin.TabIndex = 59;
            this.btnlogin.Text = "Login";
            this.btnlogin.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 290);
            this.Controls.Add(this.tcWelcome);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.lblP500);
            this.Name = "Home";
            this.Text = "Home";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Home_Load);
            this.tcWelcome.ResumeLayout(false);
            this.tabWelcome.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblHeading;
        private MetroFramework.Controls.MetroLabel lblP500;
        private MetroFramework.Controls.MetroTabControl tcWelcome;
        private MetroFramework.Controls.MetroTabPage tabWelcome;
        private MetroFramework.Controls.MetroButton btnregister;
        private MetroFramework.Controls.MetroButton btnlogin;
    }
}