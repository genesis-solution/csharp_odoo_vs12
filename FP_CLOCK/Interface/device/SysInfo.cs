using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace FPClient
{
    public unsafe partial class SysInfo : Form
    {
        private int m_nMachineNum;
        private AxFP_CLOCKLib.AxFP_CLOCK pOcxObject;
        public SysInfo()
        {
            InitializeComponent();
        }

        public SysInfo(int nMachineNum, ref AxFP_CLOCKLib.AxFP_CLOCK ptrObject)
        {
            InitializeComponent();

            this.m_nMachineNum = nMachineNum;
            this.pOcxObject = ptrObject;
            cmbItemList.SelectedIndex = 0;

        }
        private void SysInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Visible = true;
            
        }

        private void btnGetDeviceTime_Click(object sender, EventArgs e)
        {
            bool bRet;
            TimeInfo tTimeInfo = new TimeInfo(2); //test value 

            bRet = pOcxObject.EnableDevice(m_nMachineNum, 0);

            if(bRet)
            {
                labelInfo.Text = "Disable Device Success!";

                pOcxObject.GetDeviceTime(
                    m_nMachineNum,
                   ref tTimeInfo.nYear,
                   ref tTimeInfo.nMonth,
                   ref tTimeInfo.nDay,
                   ref tTimeInfo.nHour,
                   ref tTimeInfo.nMinute,
                   ref tTimeInfo.nDayofWeek
                    );
                if(tTimeInfo.nDayofWeek == 0)
                {
                    tTimeInfo.nDayofWeek = 7;
                }

                DateTime dateTime = new DateTime( 
                    tTimeInfo.nYear,
                    tTimeInfo.nMonth,
                    tTimeInfo.nDay,
                    tTimeInfo.nHour,
                    tTimeInfo.nMinute,
                    0
                    );
                CultureInfo enUS = new CultureInfo("en-US");

                //labelInfo.Text = dateTime.ToString("R", enUS);
                labelInfo.Text = dateTime.ToString("f", enUS);

                          

            }
            else
            {
                labelInfo.Text = "N0 Device ...";
                
            }

            pOcxObject.EnableDevice(m_nMachineNum, 1);

        }

        private void SysInfo_Load(object sender, EventArgs e)
        {
            
        }
        private bool DisableDevice()
        {
            labelInfo.Text = "Working...";
            bool bRet = pOcxObject.EnableDevice(m_nMachineNum, 0);
            if(bRet)
            {
                labelInfo.Text = "Disable Device Success!";
                return true;
            }
            else
            {
                labelInfo.Text = "No Device...";
                return false;
            }
        }

        private void btnSetDeviceTime_Click(object sender, EventArgs e)
        {
            bool bRet;

            bRet = DisableDevice();
            if(bRet == false)
            {
                return;
            }

            bRet = pOcxObject.SetDeviceTime(m_nMachineNum);
            if(bRet)
            {
                labelInfo.Text = "Success...";
            }
            else
            {
                ShowErrorInfo();
                
            }

            pOcxObject.EnableDevice(m_nMachineNum, 1);

        }

        private void ShowErrorInfo()
        {
            int nErrorValue = 0;
            pOcxObject.GetLastError(ref nErrorValue);
            labelInfo.Text = common.FormErrorStr(nErrorValue);
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            Owner.Visible = true;
            this.Close();
        }

        private void btnPowerOnDev_Click(object sender, EventArgs e)
        {
            pOcxObject.PowerOnAllDevice();
        }

        private void btnPowerOffDev_Click(object sender, EventArgs e)
        {
            labelInfo.Text = "";
            bool bRet;

            bRet = pOcxObject.PowerOffDevice(m_nMachineNum);
            if (bRet)
            {
                labelInfo.Text = "Success...";
            }
            else
            {
                ShowErrorInfo();
            }
        }

        void btnDisableDevice_Click(object sender, EventArgs e)
        {
            //enable device
            if (checkBox1.Checked == true)
            {
                labelInfo.Text = "Enable Device Success!";

                pOcxObject.EnableDevice(m_nMachineNum, 1);
                checkBox1.Checked = false;
                btnDisableDevice.Text = "Disable Device";
                return;
            }

            labelInfo.Text = "Disable Device Success!";
            pOcxObject.EnableDevice(m_nMachineNum, 0);
            checkBox1.Checked = true;
            btnDisableDevice.Text = "Enable Device";

        }

        private void btnGetDevInfo_Click(object sender, EventArgs e)
        {
            bool bRet;

            if (!DisableDevice())
            {
                return;
            }

            int nValue = 0;
            int nInfoNum = cmbItemList.SelectedIndex + 1;
            bRet = pOcxObject.GetDeviceInfo(m_nMachineNum, nInfoNum, ref nValue);
            if(bRet)
            {
                switch(nInfoNum)
                {
                    case 1:
                        {
                            //use string.format()
                           // labelInfo.Text = nValue.ToString("(1) = ManagerCount = 0"); //? What ??!! 
                            //labelInfo.Text = string.Format("(1) = ManagerCount = {0:D4}", nValue);
                            labelInfo.Text = string.Format("(1) = ManagerCount = {0}", nValue);

                        }
                        break;
                    case 2:
                        {
                            labelInfo.Text = nValue.ToString("(2) = Device ID = 0");
                        }
                        break;
                    case 3:
                        {
                            labelInfo.Text = nValue.ToString("(3) = Language = 0");
                        }
                        break;
                    case 4:
                        {
                            labelInfo.Text = nValue.ToString("(4) = PowerOffTime = 0");
                        }
                        break;
                    case 5:
                        {
                            labelInfo.Text = nValue.ToString("(5) = LockOperate = 0");
                        }
                        break;
                    case 6:
                        {
                            labelInfo.Text = nValue.ToString("(6) = GlogWarning = 0");
                        }
                        break;
                    case 7:
                        {
                            labelInfo.Text = nValue.ToString("(7) = SlogWarning = 0");
                        }
                        break;
                    case 8:
                        {
                            labelInfo.Text = nValue.ToString("(8) = ReVerifyTime = 0");
                        }
                        break;
                    case 9:
                        {
                            labelInfo.Text = nValue.ToString("(9) = Baudrate ID = 0");
                        }
                        break;
                    case 10:
                        {
                            labelInfo.Text = nValue.ToString("(10) = DateSeperate = 0");
                        }
                        break;
                }

                textStatusInfo.Text = nValue.ToString();
            }
            else
            {
                ShowErrorInfo();
            }
            pOcxObject.EnableDevice(m_nMachineNum, 1);
        }

        private void btnSetDevInfo_Click(object sender, EventArgs e)
        {
            if (!DisableDevice())
            {
                return;
            }

            bool bRet;

            int nStatusNum = cmbItemList.SelectedIndex + 1;
            int nStatusValue = Convert.ToInt32(textStatusInfo.Text);

            bRet = pOcxObject.SetDeviceInfo(m_nMachineNum, nStatusNum, nStatusValue);
            if(!bRet)
            {
                ShowErrorInfo();
            }

            //machine number 
            // if change this, need to reopen device
            if(nStatusNum == 2) 
            {
                System.Threading.Thread.Sleep(1000); //1 second
            }

            labelInfo.Text = string.Format("set index:{0} to value:{1}", nStatusNum, nStatusValue);

            pOcxObject.EnableDevice(m_nMachineNum, 1);
        }

        private void btnGetDevStatus_Click(object sender, EventArgs e)
        {
            bool bRet;

            if (!DisableDevice())
            {
                return;
            }

            int nValue = 0;
            int nStatusNum = cmbItemList.SelectedIndex + 1;

            if(nStatusNum > 9)
            {
                labelInfo.Text = "Invalid Parameter";
                return;
            }
            bRet = pOcxObject.GetDeviceStatus(m_nMachineNum, nStatusNum, ref nValue);
            if(bRet)
            {
                switch (nStatusNum)
                {
                    case 1:
                        {

                            labelInfo.Text = string.Format("(1) = Manager Count = {0}", nValue);

                        }
                        break;
                    case 2:
                        {
                            labelInfo.Text = nValue.ToString("(2) = User Count = 0");
                        }
                        break;
                    case 3:
                        {
                            labelInfo.Text = nValue.ToString("(3) = FP Count = 0");
                        }
                        break;
                    case 4:
                        {
                            labelInfo.Text = nValue.ToString("(4) = Password Count = 0");
                        }
                        break;
                    case 5:
                        {
                            labelInfo.Text = nValue.ToString("(5) = SLog Count = 0");
                        }
                        break;
                    case 6:
                        {
                            labelInfo.Text = nValue.ToString("(6) = Glog Count = 0");
                        }
                        break;
                    case 9:
                        {
                            labelInfo.Text = nValue.ToString("(9) = Face Count = 0");
                        }
                        break;    
            
                    default:
                        labelInfo.Text = string.Format("{0} What count = {1}", nStatusNum, nValue);
                        break;
                
                }

                textStatusInfo.Text = nValue.ToString();
            }
            else
            {
                ShowErrorInfo();
            }

            pOcxObject.EnableDevice(m_nMachineNum, 1);
        }

        
    }
}
