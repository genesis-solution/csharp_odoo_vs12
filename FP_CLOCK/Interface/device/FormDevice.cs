using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FPClient
{
    public partial class MainForm : Form
    {
        //自定义消息
        public const int USER = 0x500;
        public const int MYMESSAGE = USER + 1;

        private int m_nCurSelID = 1;
        private bool m_bDeviceOpened = false;

        public AxFP_CLOCKLib.AxFP_CLOCK axFP_CLOCK;

        public MainForm(ref AxFP_CLOCKLib.AxFP_CLOCK ptrObject)
        {
            InitializeComponent();

            this.axFP_CLOCK = ptrObject;

            this.cmbInterface.SelectedIndex = 1;
            this.cmbComPort.SelectedIndex = 0;

            this.ipAddressControl1.Text = "192.168.1.28";
            this.textPort.Text = "5005";
            textPassword.Text = "0";

            P2SPort.Text = "0";
            P2STimeOut.Text = "0";

            this.cmbMachineNumber.SelectedIndex = 0;
        }

        private void cmbInterface_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            string selectedConenction = (string)comboBox.SelectedItem;
            int resultIndex = -1;
            resultIndex = comboBox.FindStringExact(selectedConenction);
            
            switch (resultIndex)
            {
                case 0: //COM
                    {
                        this.cmbComPort.Enabled = true;

                        this.ipAddressControl1.Enabled = false;
                        this.textPort.Enabled = false;
                        this.textPassword.Enabled = false;

                        this.P2SPort.Enabled = false;
                        this.P2STimeOut.Enabled = false;
                    }
                    break;
                case 1: //NET
                    {
                        this.cmbComPort.Enabled = false;

                        this.ipAddressControl1.Enabled = true;
                        this.textPort.Enabled = true;
                        this.textPassword.Enabled = true;

                        this.P2SPort.Enabled = false;
                        this.P2STimeOut.Enabled = false;
                        
                    }
                    break;
                case 2: //P2S
                    {
                        this.cmbComPort.Enabled = false;

                        this.ipAddressControl1.Enabled = false;
                        this.textPort.Enabled = false;
                        this.textPassword.Enabled = false;

                        this.P2SPort.Enabled = true;
                        this.P2STimeOut.Enabled = true;
                    }
                    break;
                case 3:   //USB
                    {
                        this.cmbComPort.Enabled = false;

                        this.ipAddressControl1.Enabled = false;
                        this.textPort.Enabled = false;
                        this.textPassword.Enabled = false;

                        this.P2SPort.Enabled = false;
                        this.P2STimeOut.Enabled = false;
                    }
                    break;
            }
        }

        private void cmbMachineNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            m_nCurSelID = comboBox.SelectedIndex + 1;
        }

        private void btnOpenDevice_Click(object sender, EventArgs e)
        {
            bool bRet;

            if (m_bDeviceOpened)
            {
                btnOpenDev.Text = "Open";
                m_bDeviceOpened = false;

                axFP_CLOCK.CloseCommPort();
                return;
            }

            this.axFP_CLOCK.OpenCommPort(m_nCurSelID);
            int nConnecttype = this.cmbInterface.SelectedIndex;

            switch(nConnecttype)
            {
                case (int)CURDEVICETYPE.DEVICE_COM:
                    {
                        this.axFP_CLOCK.CommPort = this.cmbComPort.SelectedIndex + 1;
                        axFP_CLOCK.Baudrate = 38400;

                    }
                    break;
                case (int)CURDEVICETYPE.DEVICE_NET:
                    {
                        int nPort = Convert.ToInt32(textPort.Text);
                        int nPassword = Convert.ToInt32(textPassword.Text);
                        string strIP = ipAddressControl1.IPAddress.ToString();
                        bRet = axFP_CLOCK.SetIPAddress(ref strIP, nPort, nPassword);
                        if(!bRet)
                        {
                            return;
                        }

                    }
                    break;
                case (int)CURDEVICETYPE.DEVICE_USB:
                    {
                        axFP_CLOCK.IsUSB = true;
                       
                    }
                    break;
                case (int)CURDEVICETYPE.DEVICE_P2S:
                    {
                        int nPort = Convert.ToInt32(P2SPort.Text);
                        int nTimeOut = Convert.ToInt32(P2STimeOut.Text);

                        axFP_CLOCK.SetServerPortandtick(nPort, nTimeOut);
                    }
                    break;
            }

            bRet = axFP_CLOCK.OpenCommPort(m_nCurSelID);
            if(bRet)
            {
                m_bDeviceOpened = true;
                btnOpenDev.Text = "Close";
            }
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            //AddOwnedForm(new SysInfo());

        }

//         ///重写窗体的消息处理函数DefWndProc，从中加入自己定义消息　MYMESSAGE　的检测的处理入口
//         protected override void DefWndProc(ref Message m)
//         {
//             switch (m.Msg)
//             {
//                 //接收自定义消息MYMESSAGE，并显示其参数
//                 case MYMESSAGE:
//                     commonDefine.SENDDATASTRUCT myData = new commonDefine.SENDDATASTRUCT();//这是创建自定义信息的结构
//                     Type mytype = myData.GetType();
//                     myData = (commonDefine.SENDDATASTRUCT)m.GetLParam(mytype);//这里获取的就是作为LParam参数发送来的信息的结构
//                     //textBox1.Text = myData.lpData; //显示收到的自定义信息
//                     break;
//                 default:
//                     base.DefWndProc(ref m);
//                     break;
//             }
//         }

        private void btnLogManagement_Click(object sender, EventArgs e)
        {
            Visible = false;

            this.AddOwnedForm(new LogManagement(m_nCurSelID, ref axFP_CLOCK));

            //int nCount = this.OwnedForms.Count();   //only one
            this.OwnedForms[0].Visible = true;
        }

        private void btnLockCtrl_Click(object sender, EventArgs e)
        {
            Visible = false;

            this.AddOwnedForm(new LockCtrl(m_nCurSelID, ref axFP_CLOCK));

            //int nCount = this.OwnedForms.Count();   //only one
            this.OwnedForms[0].Visible = true;
        }

        private void btnBellSetting_Click(object sender, EventArgs e)
        {
            Visible = false;

            this.AddOwnedForm(new bellTimeSetting(m_nCurSelID, ref axFP_CLOCK));

            //int nCount = this.OwnedForms.Count();   //only one
            this.OwnedForms[0].Visible = true;
        }

        private void btnSetPassTime_Click(object sender, EventArgs e)
        {
            Visible = false;

            this.AddOwnedForm(new SetPassTime(m_nCurSelID, ref axFP_CLOCK));

            //int nCount = this.OwnedForms.Count();   //only one
            this.OwnedForms[0].Visible = true;
        }


        private void btnSysInfo_Click(object sender, EventArgs e)
        {
            Visible = false;

            this.AddOwnedForm(new SysInfo(m_nCurSelID, ref axFP_CLOCK));

            this.OwnedForms[0].Visible = true;


        }

        private void btnDeviceInfo_Click(object sender, EventArgs e)
        {
            Visible = false;

            this.AddOwnedForm(new DeviceInfo(m_nCurSelID, ref axFP_CLOCK));

            //int nCount = this.OwnedForms.Count();   //only one
            this.OwnedForms[0].Visible = true;
        }

        private void btnEnrollManagement_Click(object sender, EventArgs e)
        {
            Visible = false;

            this.AddOwnedForm(new EnrollDataManagement(m_nCurSelID, ref axFP_CLOCK));
            this.OwnedForms[0].Visible = true;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(m_bDeviceOpened)
            {
                axFP_CLOCK.CloseCommPort();
            }
        }

        private void btnHolidaySetting_Click(object sender, EventArgs e)
        {
            Visible = false;

            this.AddOwnedForm(new HolidaySetting(m_nCurSelID, ref axFP_CLOCK));

            //int nCount = this.OwnedForms.Count();   //only one
            this.OwnedForms[0].Visible = true;
        }

//         public void GetDeivceObject( ref AxFP_CLOCKLib.AxFP_CLOCK ptrObject, int nMechineNum)
//         {
//             ptrObject = axFP_CLOCK;    
//         }

    }
}
