using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FPClient.Service;
using System.Net;
using System.IO;
using System.Threading;

namespace FPClient.Interface.auth
{
    public partial class FormRegister : Form
    {
        APIService apiService { get; set; }
        public FormRegister()
        {
            InitializeComponent();
            
            apiService = new APIService();
        }

        private void button_signup_Click(object sender, EventArgs e)
        {
            string strUserId = this.textBox_userid.Text.ToString();
            string strEmail = this.textBox_email.Text.ToString();
            string strPassword = this.textBox_password.Text.ToString();
            if (strUserId == "" || strPassword == "") { MessageBox.Show("Please input your userid and password."); return; }
            if (strPassword == "" || strPassword != this.textBox_confirmpwd.Text.ToString()) { MessageBox.Show("Please confirm your password."); return; }
            
            Thread thread = new Thread(new ThreadStart(HttpRequestThread));
            thread.Start();

            this.pictureBox_loading.Visible = true;
            this.pictureBox_loading.Enabled = true;
            this.button_signup.Enabled = false;
            this.button_signup.Text = "Signing up...";
            this.button_signup.BackColor = Color.White;
        }

        public void HttpRequestThread()
        {

            HttpWebRequest request = this.apiService.AuthRegister(this.textBox_userid.Text.ToString(), this.textBox_email.Text.ToString(), this.textBox_password.Text.ToString());

            try
            {
                // Send the request and get the response
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                // Get the response stream
                Stream responseStream = response.GetResponseStream();

                // Read the response stream using a StreamReader
                StreamReader reader = new StreamReader(responseStream);
                string responseText = reader.ReadToEnd();

                Console.Write(responseText);

                // Close the response, response stream, and reader objects
                response.Close();
                responseStream.Close();
                reader.Close();

                this.Invoke((MethodInvoker)(() =>
                {
                    this.setEnvHttpRequest();
                    MessageBox.Show("Successfully registered.");

                    Visible = false;
                    this.AddOwnedForm(new FormLogin());
                    //int nCount = this.OwnedForms.Count();   //only one
                    this.OwnedForms[0].Visible = true;
                }
                ));


            }
            catch (WebException ex)
            {
                this.Invoke((MethodInvoker)(() =>
                {
                    this.setEnvHttpRequest();
                }
                ));
                HttpWebResponse response = (HttpWebResponse)ex.Response;
                if (response != null)
                {
                    Console.WriteLine("Error status code: {0}", response.StatusCode);
                    Console.WriteLine("Error message: {0}", response.StatusDescription);

                    MessageBox.Show(response.StatusDescription, "Error");
                }
                else
                {
                    Console.WriteLine("Error: {0}", ex.Message);
                    MessageBox.Show(ex.Message, "Error");
                }
            }
        }

        private void setEnvHttpRequest()
        {
            this.pictureBox_loading.Visible = false;
            this.button_signup.Enabled = true;
            this.button_signup.Text = "Sign up";
            this.button_signup.BackColor = Color.White;
        }


        private void label5_Click(object sender, EventArgs e)
        {
            Visible = false;
            this.AddOwnedForm(new FormLogin());
            //int nCount = this.OwnedForms.Count();   //only one
            this.OwnedForms[0].Visible = true;
        }
    }
}
