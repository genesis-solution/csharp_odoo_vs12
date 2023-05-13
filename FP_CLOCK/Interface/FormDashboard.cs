using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FPClient.Service;
using FPClient.Interface.ticket;
using System.Net;
using System.IO;
using System.Threading.Tasks;
using System.Reflection;
using System.Web.Script.Serialization;
using System.Threading;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Runtime.InteropServices;

namespace FPClient.Interface
{
    public partial class FormDashboard : Form
    {
        private string nickname, strToken;
        private bool isAdmin, isEmployee;
        private Size screenSize;
        
        // Selected User
        private string userName, userEmail;
        private string strFacePicPath, strCardPicPath;

        private int nIndex = 0;// Selected device
        private int Recordnumber = 0;
        private AxFP_CLOCKLib.AxFP_CLOCK pOcxObject;

        JArray devices = new JArray();
        private bool m_bDeviceOpened = false;
        private int m_nSelectedIndex = -1;

        APIService apiService { get; set; }

        public FormDashboard()
        {
            InitializeComponent();
        }

        public FormDashboard(string nickname, bool isAdmin, bool  _isEmployee, string strToken)
        {
            InitializeComponent();

            apiService = new APIService();
            pOcxObject = this.axFP_CLOCK;
            this.nickname = nickname;
            this.isAdmin = isAdmin;
            this.isEmployee = _isEmployee;
            this.strToken = strToken;

            string strRole = "Administrator";
            if (this.isAdmin) strRole = "Administrator";
            else if (this.isEmployee) strRole = "Employee";
            else strRole = "Student";

            this.label_user_name.Text = nickname + "(" + strRole + ")";

            this.listViewUsers.Columns.Add("", 20, HorizontalAlignment.Left);
            this.listViewUsers.Columns.Add("ID", 30, HorizontalAlignment.Left);
            this.listViewUsers.Columns.Add("Login", 80, HorizontalAlignment.Left);
            this.listViewUsers.Columns.Add("Phone", 80, HorizontalAlignment.Left);
            this.listViewUsers.Columns.Add("Email", 90, HorizontalAlignment.Left);
            this.listViewUsers.Columns.Add("Display name", 90, HorizontalAlignment.Left);
            this.listViewUsers.Columns.Add("Role", 70, HorizontalAlignment.Left);
            this.listViewUsers.Columns.Add("Created date", 70, HorizontalAlignment.Left);
            this.listViewUsers.Columns.Add("Status", 60, HorizontalAlignment.Left);

            if (strToken != null && strToken != "")
            {
                this.groupBox1.Visible = false;
                this.pictureBox_loading1.Visible = true;
                Thread thread = new Thread(new ThreadStart(HttpRequestThread));
                thread.Start();
            }


            // Connect to device
            this.connect.Enabled = true;
            this.Disconnect.Enabled = false;

            this.textPort.Text = "7005";

            this.listView_devices.Columns.Add(" ", 40, HorizontalAlignment.Left);          
            this.listView_devices.Columns.Add("EnrollNo", 100, HorizontalAlignment.Left);
            this.listView_devices.Columns.Add("VerifyMode", 100, HorizontalAlignment.Left);
            this.listView_devices.Columns.Add("InOut", 60, HorizontalAlignment.Left);
            this.listView_devices.Columns.Add("DateTime", 140, HorizontalAlignment.Left);
            this.listView_devices.Columns.Add("IP", 130, HorizontalAlignment.Left);
            this.listView_devices.Columns.Add("Port", 60, HorizontalAlignment.Left);
            this.listView_devices.Columns.Add("DevID", 60, HorizontalAlignment.Left);
            this.listView_devices.Columns.Add("SerialNo", 60, HorizontalAlignment.Left);

            if (this.isAdmin) this.pictureBox_deviceSetting.Visible = true;
            else this.pictureBox_deviceSetting.Visible = false;

            this.button_pass.Enabled = false;
            this.button_nopass.Enabled = false;
            this.textBox1.Text = "3";
            if (this.devices.Count > 0) this.devices.Clear();
        }

        private void FormDashboard_Resize(object sender, EventArgs e)
        {
            this.Form_Redraw();
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            this.Resize += new EventHandler(FormDashboard_Resize);
            this.FormClosed += new FormClosedEventHandler(FormDashboard_FormClosed);
        }

        private void Form_Redraw()
        {
            screenSize = this.Size; // Screen.PrimaryScreen.WorkingArea.Size;
            this.label_user_name.Location = new Point((int)screenSize.Width - (int)this.label_user_name.Size.Width - 100, 25);

            Point plistUser = this.listViewUsers.Location;
            this.listViewUsers.Size = new Size(650, (int)screenSize.Height - plistUser.Y - 60);

            //this.groupBox1.Location = new Point((int)screenSize.Width - 700 - plistUser.X, plistUser.Y);
            this.groupBox1.Size = new Size((int)screenSize.Width - this.groupBox1.Location.X - 50, this.groupBox1.Size.Height);
            this.groupBox2.Size = new Size((int)screenSize.Width - this.groupBox2.Location.X - 50, (int)screenSize.Height - this.groupBox2.Location.Y - 70);
            this.listView_devices.Size = new Size((int)screenSize.Width - this.groupBox2.Location.X - 80, (int)screenSize.Height - this.groupBox2.Location.Y - 150);
            //this.pictureBox_deviceSetting.Location = new Point(this.pictureBox_deviceSetting.Location.X, (int)screenSize.Height - 100);
            //this.label_host.Location = new Point(this.listViewUsers.Size.Width + 50, (int)this.listView_devices.Location.Y + (int)this.listView_devices.Size.Height - 30);
            //this.textPort.Location = new Point(this.listViewUsers.Size.Width + 130, (int)this.listView_devices.Size.Height - 30);
            //this.button_connect.Location = new Point(this.listViewUsers.Size.Width + 210, (int)this.listView_devices.Size.Height - 30);
            //this.Disconnect.Location = new Point(this.listViewUsers.Size.Width + 350, (int)this.listView_devices.Size.Height - 30);
            //this.clearList.Location = new Point(this.listViewUsers.Size.Width + 470, (int)this.listView_devices.Size.Height - 30);

        }

        private void FormDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (MessageBox.Show("Do you want to close the application?", "Confirmation", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void SetListViewUsers(JObject objData, int nIndex)
        {
            if (objData == null) return;

            String strKey = Convert.ToString(nIndex);
           // this.listViewUsers.BeginUpdate();

            ListViewItem lvi = new ListViewItem();
            lvi.Text = strKey;

            lvi.SubItems.Add(objData.SelectToken("ID").ToString());
            lvi.SubItems.Add(objData.SelectToken("user_login").ToString());
            lvi.SubItems.Add(objData.SelectToken("phone").ToString());
            lvi.SubItems.Add(objData.SelectToken("user_email").ToString());
            lvi.SubItems.Add(objData.SelectToken("display_name").ToString());

            bool isAdmin = false, isEmployee = false; // administrator, staff_member
            if (objData.SelectToken("cap").ToString().Contains("administrator")) 
            {
                isAdmin = true;
            }
            else if (objData.SelectToken("cap").ToString().Contains("staff_member"))
            {
                isEmployee = true;
            }

            string str = "Member";
            if (isAdmin) str = "Administrator";
            if (isEmployee) str = "Staff";

            lvi.SubItems.Add(str);

            lvi.SubItems.Add(objData.SelectToken("user_registered").ToString());

            if (objData.SelectToken("user_status").ToString() == "0")
            {
                str = "Allow";
            }
            else
            {
                str = "Pending";
            }
            lvi.SubItems.Add(str);

            this.listViewUsers.Items.Add(lvi);

            this.listViewUsers.Update();

            //this.listViewUsers.EnsureVisible(nIndex);
            //this.listViewUsers.EndUpdate();
        }

        public void HttpRequestThread()
        {

            HttpWebRequest request = this.apiService.GetUsers(this.strToken);

            try
            {
                // Send the request and get the response
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                // Get the response stream
                Stream responseStream = response.GetResponseStream();

                // Read the response stream using a StreamReader
                StreamReader reader = new StreamReader(responseStream);
                string responseText = reader.ReadToEnd();

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
                    this.Invoke((MethodInvoker)(() =>
                    {
                        this.pictureBox_loading1.Visible = false;
                        int nIndex = 0;
                        if (this.devices.Count > 0) this.devices.Clear();
                        foreach(JObject obj in jsonObject.SelectToken("data")) {
                            this.SetListViewUsers(obj, ++nIndex);
                        }
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
                    this.pictureBox_loading1.Visible = false;
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

        private void linkLabel_userList_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (strToken != null && strToken != "")
            {
                this.pictureBox_loading1.Visible = true;
                Thread thread = new Thread(new ThreadStart(HttpRequestThread));
                thread.Start();
            }
        }

        private void listViewUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listViewUsers.SelectedItems.Count > 0)
            {
                this.groupBox1.Visible = true;
                ListViewItem selectedItem = this.listViewUsers.SelectedItems[0];
                // Do something with the selected item
                int selectedIndex = this.listViewUsers.SelectedIndices[0];

                this.userName = selectedItem.SubItems[5].Text.ToString();
                this.userEmail = selectedItem.SubItems[4].Text.ToString();
                this.label_name.Text = "Name: " + this.userName;
                this.label_email.Text = "Email: " + this.userEmail;

            }
        }

        private void pictureBox_printQR_Click(object sender, EventArgs e)
        {
            // print QR code
            FormPreviewTicket previewTicket = new FormPreviewTicket(this.userName, 3, 1, "11/05/2023 9:00 ~ 11:00");
            previewTicket.Visible = true;
        }

        private void pictureBox_faceImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = "C:\\";
            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.png, *.gif) | *.jpg; *.jpeg; *.png; *.gif";
            openFileDialog1.Title = "Select your face image, please";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // The user selected a file, so do something with it
                this.strFacePicPath = openFileDialog1.FileName;
                Bitmap image = new Bitmap(this.strFacePicPath);
                this.pictureBox_faceImage.Image = image;
                // ...
                MessageBox.Show("Please select a device to send the data.");
            }
        }

        private void button_connect_Click(object sender, EventArgs e)
        {
            if (this.m_nSelectedIndex < 0)
            {
                MessageBox.Show("Please select a possible device.");
                return;
            }
            // Assume that jArray is an existing JArray
            JObject jObject = (JObject)devices[m_nSelectedIndex];
            AxFPCLOCK_SVRLib._DFPCLOCK_SvrEvents_OnReceiveGLogDataEvent obj = jObject.ToObject<AxFPCLOCK_SVRLib._DFPCLOCK_SvrEvents_OnReceiveGLogDataEvent>();

            int nResult1 = 1;

            int nCnt = Convert.ToInt32(this.textBox1.Text.ToString());

            for (int i = 0; i < nCnt; i++ )
                this.axFPCLOCK_Svr1.SendResultandTime(obj.linkindex, obj.vnDeviceID, obj.anSEnrollNumber, nResult1);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void connect_Click(object sender, EventArgs e)
        {
            String str = this.textPort.Text;
            int nPort = Convert.ToInt32(str);
            this.axFPCLOCK_Svr1.OpenNetwork(nPort);
            this.connect.Enabled = false;
            this.Disconnect.Enabled = true;
        }

        private void Disconnect_Click(object sender, EventArgs e)
        {
            String str = this.textPort.Text;
            int nPort = Convert.ToInt32(str);
            this.axFPCLOCK_Svr1.CloseNetwork(nPort);

            this.connect.Enabled = true;
            this.Disconnect.Enabled = false;
        }

        public String FormString(int nVerify, int nEnrollNum)
        {
            int nAction = nVerify % 8;
            if (nEnrollNum == 0)
            {
                switch (nAction)
                {
                    case 0:
                        return "Closed";
                    //break;
                    case 1:
                        return "Opened";
                    // break;
                    case 2:
                        return "HandOpen";
                    // break;
                    case 3:
                        return "ProcOpen";
                    // break;
                    case 4:
                        return "ProcClose";
                    // break;
                    case 5:
                        return "IllegalOpen";
                    //break;
                    case 6:
                        return "IlleagalRemove";
                    //break;
                    case 7:
                        return "Alarm";
                    //break;
                    case 8:
                        return "--";
                    //break;
                }
            }
            else
            {
                return nVerify.ToString();

            }

            return "Not my fault";
        }

        private void clearList_Click(object sender, EventArgs e)
        {
            this.nIndex = 0;
            this.listView_devices.Items.Clear();
            if (this.devices.Count > 0) this.devices.Clear();
            this.m_nSelectedIndex = -1;
        }

        private void axFPCLOCK_Svr1_OnReceiveGLogData(object sender, AxFPCLOCK_SVRLib._DFPCLOCK_SvrEvents_OnReceiveGLogDataEvent e)
        {
            JObject newObject = JObject.FromObject(e);
            this.devices.Add(newObject);

            String strKey = Convert.ToString(nIndex + 1);
            String str = e.anSEnrollNumber.ToString("D8");
            int imagelen = 0;
            int[] imagebuff = new int[200 * 1024];
            bool bRet;
            double aTemperature;

            IntPtr ptrIndexFacePhoto = Marshal.AllocHGlobal(imagebuff.Length);

            bRet = this.axFPCLOCK_Svr1.GetLogImageCS(e.linkindex, ref imagelen, ptrIndexFacePhoto);
            if (bRet && imagelen > 0)
            {
                byte[] mbytCurEnrollData = new byte[imagelen];
                Marshal.Copy(ptrIndexFacePhoto, mbytCurEnrollData, 0, imagelen);
                System.IO.File.WriteAllBytes(@"C:\\PHOTO\" + e.anSEnrollNumber.ToString() + "_" + e.anLogDate.ToString("yy_MM_dd_HH_mm_ss") + ".jpg", mbytCurEnrollData);
            }

            this.listView_devices.BeginUpdate();

            //this.listView1.Focus();
            ListViewItem lvi = new ListViewItem();
            lvi.Text = strKey;

            lvi.SubItems.Add(str);
            if (e.anVerifyMode > 40)
            {
                aTemperature = e.anVerifyMode;
                aTemperature = (250 + aTemperature) / 10;
                str = aTemperature.ToString("#0.0");
            }
            else
            {
                str = FormString(e.anVerifyMode, e.anSEnrollNumber);
            }
            lvi.SubItems.Add(str);

            if (e.anInOutMode == 1)
            {
                str = "OUT";
            }
            else if (0 == e.anInOutMode)
            {
                str = "IN";
            }
            else
            {
                str = "--";
            }
            lvi.SubItems.Add(str);

            str = Convert.ToString(e.anLogDate.ToString("yyyy/MM/dd HH:mm"));
            lvi.SubItems.Add(str);

            //str = Convert.ToString(e.astrDeviceIP);
            lvi.SubItems.Add(e.astrDeviceIP);

            str = Convert.ToString(e.anDevicePort);
            lvi.SubItems.Add(str);

            str = Convert.ToString(e.vnDeviceID);
            lvi.SubItems.Add(str);

            str = Convert.ToString(e.anSN);
            lvi.SubItems.Add(str);

            this.listView_devices.Items.Add(lvi);
            //this.listView1.Items.(5, str);

            this.listView_devices.Update();

            this.listView_devices.EnsureVisible(nIndex);
            this.listView_devices.EndUpdate(); 

            //int nResult1 = 1;
            //int nResult2 = 3;
            //if (e.anSEnrollNumber == 0)
            //{
            //    this.axFPCLOCK_Svr1.SendResultandTime(e.linkindex, e.vnDeviceID, e.anSEnrollNumber, nResult1);
            //}
            //else
            //{
            //    this.axFPCLOCK_Svr1.SendResultandTime(e.linkindex, e.vnDeviceID, e.anSEnrollNumber, nResult2);
            //}


            nIndex++;
            if (nIndex > 1000)
            {
                this.nIndex = 0;
                this.listView_devices.Items.Clear();
                if (this.devices.Count > 0) this.devices.Clear();
                this.m_nSelectedIndex = -1;
            }

        }

        private void listView_devices_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listView_devices.SelectedItems.Count > 0)
            {
                this.groupBox1.Visible = true;
                ListViewItem selectedItem = this.listView_devices.SelectedItems[0];
                // Do something with the selected item
                m_nSelectedIndex = this.listView_devices.SelectedIndices[0];

                // Assume that jArray is an existing JArray
                JObject jObject = (JObject)devices[m_nSelectedIndex];
                AxFPCLOCK_SVRLib._DFPCLOCK_SvrEvents_OnReceiveGLogDataEvent obj = jObject.ToObject<AxFPCLOCK_SVRLib._DFPCLOCK_SvrEvents_OnReceiveGLogDataEvent>();

                
                bool bRet;
                // 
                if (this.m_bDeviceOpened)
                {
                    this.button_pass.Text = "Open";
                    m_bDeviceOpened = false;

                    axFP_CLOCK.CloseCommPort();
                    return;
                }
                this.axFP_CLOCK.OpenCommPort(obj.vnDeviceID);
                bRet = this.axFP_CLOCK.SetIPAddress(ref obj.astrDeviceIP, obj.anDevicePort, 0);
                if (!bRet)
                {
                    return;
                }
                bRet = this.axFP_CLOCK.OpenCommPort(obj.vnDeviceID);
                if (bRet)
                {
                    m_bDeviceOpened = true;
                    this.button_pass.Text = "Close";
                }

                // Set enroll data
                this.DisableDevice(obj.vnDeviceID);
                int[] indexDataFacePhoto = new int[400800];
                IntPtr ptrIndexFacePhoto = Marshal.AllocHGlobal(indexDataFacePhoto.Length);

                // string path = @"C:\\PHOTO\" + dwEnrollNumber.ToString() + ".jpg";
                bRet = System.IO.File.Exists(this.strFacePicPath);
                if (bRet)
                {
                    byte[] mbytCurEnrollData = System.IO.File.ReadAllBytes(this.strFacePicPath);
                    Marshal.Copy(mbytCurEnrollData, 0, ptrIndexFacePhoto, mbytCurEnrollData.Length);
                    bRet = this.axFP_CLOCK.SetEnrollPhotoCS(obj.vnDeviceID, obj.anSEnrollNumber, mbytCurEnrollData.Length, ptrIndexFacePhoto);
                    MessageBox.Show("Success SetEnrollPhotoCS");

                    this.button_pass.Enabled = true;
                    this.button_nopass.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Picture does not exist");
                }
            }
            
        }

        private void pictureBox_deviceSetting_Click_1(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm(ref this.pOcxObject);
            //mainForm.ShowDialog();
            mainForm.Visible = true;
        }

        private void label_user_name_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (m_bDeviceOpened)
            {
                axFP_CLOCK.CloseCommPort();
            }
        }

        private bool DisableDevice(int nMachineNum)
        {
            bool bRet = pOcxObject.EnableDevice(nMachineNum, 0);
            if (bRet)
            {
                MessageBox.Show("Disable Device Success!");
                return true;
            }
            else
            {
                MessageBox.Show("No Device...");
                return false;
            }
        }

        private void button_nopass_Click(object sender, EventArgs e)
        {
            if (this.m_nSelectedIndex < 0)
            {
                MessageBox.Show("Please select a possible device.");
                return;
            }
            // Assume that jArray is an existing JArray
            JObject jObject = (JObject)devices[m_nSelectedIndex];
            AxFPCLOCK_SVRLib._DFPCLOCK_SvrEvents_OnReceiveGLogDataEvent obj = jObject.ToObject<AxFPCLOCK_SVRLib._DFPCLOCK_SvrEvents_OnReceiveGLogDataEvent>();

            int nResult1 = 3;
            this.axFPCLOCK_Svr1.SendResultandTime(obj.linkindex, obj.vnDeviceID, obj.anSEnrollNumber, nResult1);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int nMaxCnt = 3;
            if (this.textBox1.Text.ToString() == "")
            {
                this.textBox1.Text = "1";
                return;
            }
            if (Convert.ToInt32(this.textBox1.Text.ToString()) > nMaxCnt)
            {
                MessageBox.Show("Max count is 3.");
                this.textBox1.Text = nMaxCnt.ToString();
            }
            else if (Convert.ToInt32(this.textBox1.Text.ToString()) < 1)
            {
                this.textBox1.Text = "1";
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void pictureBox_minus_Click(object sender, EventArgs e)
        {
            int nMaxCnt = 3;
            int nCurrCnt = Convert.ToInt32(this.textBox1.Text.ToString());
            nCurrCnt--;
            if (nCurrCnt > nMaxCnt)
            {
                MessageBox.Show("Max count is 3.");
                this.textBox1.Text = nMaxCnt.ToString();
            }
            else if (nCurrCnt < 1)
            {
                this.textBox1.Text = "1";
            }
            else
            {
                this.textBox1.Text = nCurrCnt.ToString();
            }
        }

        private void pictureBox_plus_Click(object sender, EventArgs e)
        {
            int nMaxCnt = 3;
            int nCurrCnt = Convert.ToInt32(this.textBox1.Text.ToString());
            nCurrCnt++;
            if (nCurrCnt > nMaxCnt)
            {
                MessageBox.Show("Max count is 3.");
                this.textBox1.Text = nMaxCnt.ToString();
            }
            else if (nCurrCnt < 1)
            {
                this.textBox1.Text = "1";
            }
            else
            {
                this.textBox1.Text = nCurrCnt.ToString();
            }
        }
    }
}
