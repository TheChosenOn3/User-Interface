using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controllers;
using MetroFramework;
using Newtonsoft.Json;

namespace Project500
{
    public partial class Splash : MetroFramework.Forms.MetroForm
    {
        //Global Variables
        //Value from API, True = Maintenance, False = Normal - Server Online
        public bool MaintenanceStatus = true;
        //Value determined if successfully connecting to API, if crashes = false, and server = offline.
        public bool ConnectSuccess = false;
        //Used by Main Thread to determin if checkconnection is done.
        public bool Finish = false;

        public Splash()
        {
            InitializeComponent();
            Main();
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            
        }

        public void Main()
        {
            //Setting Local Variables
            MaintenanceStatus = true;
            ConnectSuccess = false;
            Finish = false;

            //thread to check whether API Server is running
            ThreadStart ConnectionMethod = new ThreadStart(CheckConnection);
            Thread ConnectionCheckThread = new Thread(ConnectionMethod);

            //Start Threads to begin multiple Processes
            ConnectionCheckThread.Start();

            //Waiting for Connection Thread to Finish.
            while (!Finish)
            {
                lblLoading.Text.Equals("Loading");
                Thread.Sleep(200);
                lblLoading.Text.Equals("Loading.");
                Thread.Sleep(200);
                lblLoading.Text.Equals("Loading..");
                Thread.Sleep(200);
                lblLoading.Text.Equals("Loading...");
            }

            //Ending Threads
            ConnectionCheckThread.Join();

            //If Connection to API server is successful
            if (ConnectSuccess)
            {
                //Check whether API Server is in Maintenance or normal login mode
                if (!MaintenanceStatus)
                {
                    //Take user to normal Login Form
                    Login LoginForm = new Login();
                    LoginForm.Show();
                    this.Hide();
                }
                else
                {
                    //Take User to Maintenance Login form with locked controls
                    Login LoginForm = new Login(true);
                    LoginForm.Show();
                    this.Hide();
                }
            }
            else
            {
                //Take user to Login form, but notificy user of offline server, and lock controls
                Login LoginForm = new Login(false);
                LoginForm.Show();
                this.Hide();
            }
        }

        //Thread Connection Method
        public void CheckConnection()
        {
            Connection Con = new Connection();
            string Path = Connection.url + "/Connection";
            HttpClient client = new HttpClient();
            bool ServerResponse;

            try
            {
                var response = client.GetStringAsync(Path).Result;
                ServerResponse = JsonConvert.DeserializeObject<bool>(response);
                MaintenanceStatus = ServerResponse;
                ConnectSuccess = true;
            }
            catch (Exception)
            {
                ConnectSuccess = false;
            }


            Finish = true;
        }

        private void Splash_Shown(object sender, EventArgs e)
        {
            
        }
    }
}
