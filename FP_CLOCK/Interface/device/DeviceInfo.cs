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
    public partial class DeviceInfo : Form
    {
        private int m_nMachineNum;
        private AxFP_CLOCKLib.AxFP_CLOCK pOcxObject;

        public DeviceInfo()
        {
            InitializeComponent();
        }

        public DeviceInfo(int nMachineNum, ref AxFP_CLOCKLib.AxFP_CLOCK ptrObject)
        {
            InitializeComponent();

            this.m_nMachineNum = nMachineNum;
            this.pOcxObject = ptrObject;

        }

        private void DeviceInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Visible = true;
        }

        private bool DisableDevice()
        {
            labelInfo.Text = "Working...";
            bool bRet = pOcxObject.EnableDevice(m_nMachineNum, 0);
            if (bRet)
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

        private void btnGetSerialNum_Click(object sender, EventArgs e)
        {
            bool bRet;
            bRet = DisableDevice();
            if(!bRet)
            {
                labelInfo.Text = "No Device...";
                return;
            }

            string str = "";
            bRet = pOcxObject.GetSerialNumber(m_nMachineNum, ref str);
            if(bRet)
            {
                labelSN.Text = str;
                labelInfo.Text = "Success...";
            }
            else
            {
                ShowErrorInfo();
                labelSN.Text = ""; //clear SN

            }

            pOcxObject.EnableDevice(m_nMachineNum, 1);
        }

        private void ShowErrorInfo()
        {
            int nErrorValue = 0;
            pOcxObject.GetLastError(ref nErrorValue);
            labelInfo.Text = common.FormErrorStr(nErrorValue);
        }

                
        private void btnGetBackupNumber_Click(object sender, EventArgs e)
        {
            //NOT IMPLEMENTED
        }

        private void btnGetProductCode_Click(object sender, EventArgs e)
        {
            //NOT IMPLEMENTED

        }
    }
}
