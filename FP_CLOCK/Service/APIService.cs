using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Reflection;
using System.Web.Script.Serialization;

namespace FPClient.Service
{
    public class MyResponse
    {
        public int nStatusCode { get; set; }
        public string strMessage { get; set; }
        public string strData { get; set; }
        public MyResponse() { }
    }

    public class User
    {
        public User()
        {

        }

        public string ID { get; set; }
        public string user_login { get; set; }

        public string user_pass { get; set; }
        public string user_nickname { get; set; }
        public string user_email { get; set; }
        public string user_url { get; set; }

        public string user_registered { get; set; }

        public string user_status { get; set; }

        public string display_name { get; set; }

        public string user_activation_key { get; set; }

        public override string ToString()
        {
            return display_name + " " + user_activation_key;
        }
    }

    public class APIService
    {
        private Properties.Settings setting = Properties.Settings.Default;
        String strBaseURL = "http://24hr-fitness.eu/wp-json/wp/v2/";
        public APIService() {
            
            strBaseURL = setting.remote_url;
            if (setting.remote_url == null)
            {
                strBaseURL = "http://localhost/wp-json/wp/v2/";
            }

        }

        public HttpWebRequest AuthCheck(string username, string password)
        {
            // Create a new HttpWebRequest object
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(this.strBaseURL + "auth");
            // Set the request method to POST
            request.Method = "POST";
            // Set the request content type
            request.ContentType = "application/json";

            // Create the request body
            var dict = new Dictionary<string, object>();
            dict.Add("username", username);
            dict.Add("password", password);
            // Create a JavaScriptSerializer object
            var serializer = new JavaScriptSerializer();
            string requestBody = serializer.Serialize(dict);

            // Convert the request body to a byte array
            byte[] requestBodyBytes = Encoding.UTF8.GetBytes(requestBody);

            // Set the request content length
            request.ContentLength = requestBodyBytes.Length;
            // Get the request stream
            Stream requestStream = request.GetRequestStream();
            // Write the request body to the request stream
            requestStream.Write(requestBodyBytes, 0, requestBodyBytes.Length);
            // Close the request stream
            requestStream.Close();

            return request;
            
        }

        public HttpWebRequest AuthRegister(string username, string email, string password)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(this.strBaseURL + "register");
            request.Method = "POST";
            request.ContentType = "application/json";
            var dict = new Dictionary<string, object>();
            dict.Add("username", username);
            dict.Add("email", email);
            dict.Add("password", password);
            // Create a JavaScriptSerializer object
            var serializer = new JavaScriptSerializer();
            string requestBody = serializer.Serialize(dict);
            byte[] requestBodyBytes = Encoding.UTF8.GetBytes(requestBody);
            request.ContentLength = requestBodyBytes.Length;
            Stream requestStream = request.GetRequestStream();
            requestStream.Write(requestBodyBytes, 0, requestBodyBytes.Length);
            requestStream.Close();
            
            return request;
        }

        public HttpWebRequest GetUsers(string token)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(this.strBaseURL + "myUsers");
            request.Method = "GET";
            request.Headers.Add("Authorization", "Basic " + token);
            //request.Headers.Add("Content-Type", "application/json");
            return request;
        }

    }
}
