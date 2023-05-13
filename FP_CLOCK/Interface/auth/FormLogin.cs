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
using System.Threading.Tasks;
using System.Reflection;
using System.Web.Script.Serialization;
using System.Threading;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace FPClient.Interface.auth
{
	public partial class FormLogin: Form
	{
        APIService apiService { get; set; }
		public FormLogin()
		{
			InitializeComponent();
            this.label5.BackColor = Color.White;
            apiService = new APIService();
		}

        private void button_signin_Click(object sender, EventArgs e)
        {
            string strUserId = this.textBox_userid.Text.ToString();
            string strPassword = this.textBox_password.Text.ToString();
            if (strUserId == "" || strPassword == "") { MessageBox.Show("Please input your userid and password."); return; }
            Thread thread = new Thread(new ThreadStart(HttpRequestThread));
            thread.Start();

            this.pictureBox_loading.Visible = true;
            this.pictureBox_loading.Enabled = true;
            this.button_signin.Enabled = false;
            this.button_signin.Text = "Signing in...";
            this.button_signin.BackColor = Color.White;
            
        }

        public void HttpRequestThread()
        {

            HttpWebRequest request = this.apiService.AuthCheck(this.textBox_userid.Text.ToString(), this.textBox_password.Text.ToString());

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

                dynamic resJson = JsonConvert.DeserializeObject(responseText);

                JObject jsonObject = JObject.Parse(responseText);

                int nStatus = 0;
                string strStatusCode = "";

                if ((jsonObject.SelectToken("status") != null))
                    strStatusCode = jsonObject.SelectToken("status").ToString();
                else
                    strStatusCode = jsonObject.SelectToken("code").ToString();

                Int32.TryParse(strStatusCode, out nStatus);

                if (nStatus == 200)
                {
                    string strToken = jsonObject.SelectToken("data").SelectToken("token").ToString(); // resJson["data"]["token"];
                    string nickName = jsonObject.SelectToken("data").SelectToken("user").SelectToken("data").SelectToken("display_name").ToString(); // resJson["data"]["user"]["data"]["display_name"];

                    bool isAdmin = false, isEmployee = false;
                    if (jsonObject.SelectToken("data").SelectToken("user").SelectToken("caps").SelectToken("administrator") != null) // resJson["data"]["user"]["caps"].ContainsKey("administrator")
                    {
                        isAdmin = jsonObject.SelectToken("data").SelectToken("user").SelectToken("caps").SelectToken("administrator").ToObject<bool>();
                    }
                    else if (jsonObject.SelectToken("data").SelectToken("user").SelectToken("caps").SelectToken("staff_member") != null)
                    {
                        isEmployee = jsonObject.SelectToken("data").SelectToken("user").SelectToken("caps").SelectToken("staff_member").ToObject<bool>();
                    }

                    this.Invoke((MethodInvoker)(() =>
                        {
                            this.setEnvHttpRequest();
                            Visible = false;
                            this.AddOwnedForm(new FormDashboard(nickName, isAdmin, isEmployee, strToken));
                            //int nCount = this.OwnedForms.Count();   //only one
                            this.OwnedForms[0].Visible = true;
                        }
                   ));
                }
                else
                {
                    MessageBox.Show("Error: " + nStatus.ToString() + ", Error : " + resJson["message"]);
                }
               
                

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
            this.button_signin.Enabled = true;
            this.button_signin.Text = "Sign in";
            this.button_signin.BackColor = Color.LightBlue;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Visible = false;
            this.AddOwnedForm(new FormRegister());
            //int nCount = this.OwnedForms.Count();   //only one
            this.OwnedForms[0].Visible = true;
        }
	}
}
