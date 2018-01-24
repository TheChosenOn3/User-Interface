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
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tcWelcome = new MetroFramework.Controls.MetroTabControl();
            this.tabWelcome = new MetroFramework.Controls.MetroTabPage();
            this.btnregister = new MetroFramework.Controls.MetroButton();
            this.btnlogin = new MetroFramework.Controls.MetroButton();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // metroPanel2
            // 
            this.metroPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.metroPanel2.Controls.Add(this.pictureBox1);
            this.metroPanel2.CustomBackground = true;
            this.metroPanel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(6, 11);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(134, 103);
            this.metroPanel2.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroPanel2.TabIndex = 6;
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
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 290);
            this.Controls.Add(this.tcWelcome);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.lblP500);
            this.Controls.Add(this.metroPanel2);
            this.Name = "Main";
            this.Text = "Home";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Home_Load);
            this.metroPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tcWelcome.ResumeLayout(false);
            this.tabWelcome.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblHeading;
        private MetroFramework.Controls.MetroLabel lblP500;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTabControl tcWelcome;
        private MetroFramework.Controls.MetroTabPage tabWelcome;
        private MetroFramework.Controls.MetroButton btnregister;
        private MetroFramework.Controls.MetroButton btnlogin;
    }
}