﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controllers;
using Entities1;
namespace Project500
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        public Login()
        {
            InitializeComponent();
            
        }

        private void Login_Load(object sender, EventArgs e)
        {

         
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string passworrd = txtPassword.Text.Trim();
            
            if (username == "" || passworrd == "")
            {
                MessageBox.Show("enter all the fields");

            }
            else {
                User user = UserController.CheckLogin(username, passworrd);
                if (user.RsaID != null)
                {//dummy user to use for now
                    
                    Main main = new Main(user);
                    this.Hide();
                    main.Show();

                }
                else
                {
                    MessageBox.Show("Credentials are wrong");
                }
            }

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "";
            txtUsername.Text = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Home main = new Home();
            this.Hide();
            main.Show();
        }

        private void txtUsername_Click(object sender, EventArgs e)
        {

        }
    }
}
