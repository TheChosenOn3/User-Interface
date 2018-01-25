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
            this.btnregister = new MetroFramework.Controls.MetroButton();
            this.btnlogin = new MetroFramework.Controls.MetroButton();
            this.lblheader = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // btnregister
            // 
            this.btnregister.Location = new System.Drawing.Point(174, 201);
            this.btnregister.Name = "btnregister";
            this.btnregister.Size = new System.Drawing.Size(182, 50);
            this.btnregister.TabIndex = 62;
            this.btnregister.Text = "Register Account";
            this.btnregister.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnregister.UseSelectable = true;
            this.btnregister.Click += new System.EventHandler(this.btnregister_Click);
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(174, 132);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(182, 49);
            this.btnlogin.TabIndex = 61;
            this.btnlogin.Text = "Go to Login";
            this.btnlogin.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnlogin.UseSelectable = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // lblheader
            // 
            this.lblheader.AutoSize = true;
            this.lblheader.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblheader.Location = new System.Drawing.Point(125, 88);
            this.lblheader.Name = "lblheader";
            this.lblheader.Size = new System.Drawing.Size(231, 25);
            this.lblheader.TabIndex = 1;
            this.lblheader.Text = "What would you like to do?";
            this.lblheader.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 328);
            this.Controls.Add(this.lblheader);
            this.Controls.Add(this.btnregister);
            this.Controls.Add(this.btnlogin);
            this.Name = "Home";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.Text = "Welcome to Project 500";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnregister;
        private MetroFramework.Controls.MetroButton btnlogin;
        private MetroFramework.Controls.MetroLabel lblheader;
    }
}