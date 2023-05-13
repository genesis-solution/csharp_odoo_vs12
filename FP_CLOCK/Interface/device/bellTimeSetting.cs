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
    public partial class bellTimeSetting : Form
    {
        private int m_nMachineNum;
        private AxFP_CLOCKLib.AxFP_CLOCK pOcxObject;

        public bellTimeSetting()
        {
            InitializeComponent();
        }
        public bellTimeSetting(int nMachineNum, ref AxFP_CLOCKLib.AxFP_CLOCK ptrObject)
        {
            InitializeComponent();

            this.m_nMachineNum = nMachineNum;
            this.pOcxObject = ptrObject;
            
        }

        private void bellTimeSetting_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Visible = true;

        }

        private unsafe void btnReadSetting_Click(object sender, EventArgs e)
        {
            DisableDevice();
            int nBellCount = 0;

            BellInfo *pBellInfo = stackalloc BellInfo [1];
            IntPtr ptr = new IntPtr(pBellInfo);

            bool bRet;
            bRet = pOcxObject.GetBellTime(m_nMachineNum, ref nBellCount, ptr);
            if(!bRet)
            {
                ShowErrorInfo();
                pOcxObject.EnableDevice(m_nMachineNum, 1);
                return;
            }
            checkBox1.Checked = pBellInfo->bValid[0] == 1 ? true : false;
            checkBox2.Checked = pBellInfo->bValid[1] == 1 ? true : false;
            checkBox3.Checked = pBellInfo->bValid[2] == 1 ? true : false;
            checkBox4.Checked = pBellInfo->bValid[3] == 1 ? true : false;
            checkBox5.Checked = pBellInfo->bValid[4] == 1 ? true : false;
            checkBox6.Checked = pBellInfo->bValid[5] == 1 ? true : false;
            checkBox7.Checked = pBellInfo->bValid[6] == 1 ? true : false;
            checkBox8.Checked = pBellInfo->bValid[7] == 1 ? true : false;

            textHour1.Text = pBellInfo->bHour[0].ToString();
            textHour2.Text = pBellInfo->bHour[1].ToString();
            textHour3.Text = pBellInfo->bHour[2].ToString();
            textHour4.Text = pBellInfo->bHour[3].ToString();
            textHour5.Text = pBellInfo->bHour[4].ToString();
            textHour6.Text = pBellInfo->bHour[5].ToString();
            textHour7.Text = pBellInfo->bHour[6].ToString();
            textHour8.Text = pBellInfo->bHour[7].ToString();

            textMinute1.Text = pBellInfo->bMinute[0].ToString();
            textMinute2.Text = pBellInfo->bMinute[1].ToString();
            textMinute3.Text = pBellInfo->bMinute[2].ToString();
            textMinute4.Text = pBellInfo->bMinute[3].ToString();
            textMinute5.Text = pBellInfo->bMinute[4].ToString();
            textMinute6.Text = pBellInfo->bMinute[5].ToString();
            textMinute7.Text = pBellInfo->bMinute[6].ToString();
            textMinute8.Text = pBellInfo->bMinute[7].ToString();

            textBellCount.Text = nBellCount.ToString();

            pOcxObject.EnableDevice(m_nMachineNum, 1);
            labelInfo.Text = "Success...";



        }

        private unsafe void btnWriteSetting_Click(object sender, EventArgs e)
        {
            BellInfo* pBellInfo = stackalloc BellInfo[1];

            pBellInfo->bValid[0] = checkBox1.Checked == true ? (byte)1 : (byte)0;
            pBellInfo->bValid[1] = checkBox2.Checked == true ? (byte)1 : (byte)0;
            pBellInfo->bValid[2] = checkBox3.Checked == true ? (byte)1 : (byte)0;
            pBellInfo->bValid[3] = checkBox4.Checked == true ? (byte)1 : (byte)0;
            pBellInfo->bValid[4] = checkBox5.Checked == true ? (byte)1 : (byte)0;
            pBellInfo->bValid[5] = checkBox6.Checked == true ? (byte)1 : (byte)0;
            pBellInfo->bValid[6] = checkBox7.Checked == true ? (byte)1 : (byte)0;
            pBellInfo->bValid[7] = checkBox8.Checked == true ? (byte)1 : (byte)0;           

            pBellInfo->bHour[0] = Convert.ToByte(textHour1.Text);
            pBellInfo->bHour[1] = Convert.ToByte(textHour2.Text);
            pBellInfo->bHour[2] = Convert.ToByte(textHour3.Text);
            pBellInfo->bHour[3] = Convert.ToByte(textHour4.Text);
            pBellInfo->bHour[4] = Convert.ToByte(textHour5.Text);
            pBellInfo->bHour[5] = Convert.ToByte(textHour6.Text);
            pBellInfo->bHour[6] = Convert.ToByte(textHour7.Text);
            pBellInfo->bHour[7] = Convert.ToByte(textHour8.Text);

            pBellInfo->bMinute[0] = Convert.ToByte(textMinute1.Text);
            pBellInfo->bMinute[1] = Convert.ToByte(textMinute2.Text);
            pBellInfo->bMinute[2] = Convert.ToByte(textMinute3.Text);
            pBellInfo->bMinute[3] = Convert.ToByte(textMinute4.Text);
            pBellInfo->bMinute[4] = Convert.ToByte(textMinute5.Text);
            pBellInfo->bMinute[5] = Convert.ToByte(textMinute6.Text);
            pBellInfo->bMinute[6] = Convert.ToByte(textMinute7.Text);
            pBellInfo->bMinute[7] = Convert.ToByte(textMinute8.Text);

            int nBellCount = Convert.ToInt32(textBellCount.Text);


            DisableDevice();

            IntPtr ptr = new IntPtr(pBellInfo);

            bool bRet;
            bRet = pOcxObject.SetBellTime(m_nMachineNum, nBellCount, ptr);
            if (!bRet)
            {
                ShowErrorInfo();
                pOcxObject.EnableDevice(m_nMachineNum, 1);
                return;
            }
            
            pOcxObject.EnableDevice(m_nMachineNum, 1);
            labelInfo.Text = "Success...";
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
    }
}
