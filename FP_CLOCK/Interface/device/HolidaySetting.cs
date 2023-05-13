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
    public partial class HolidaySetting : Form
    {
        private int m_nMachineNum;
        private AxFP_CLOCKLib.AxFP_CLOCK pOcxObject;
        public HolidaySetting()
        {
            InitializeComponent();
        }
        public HolidaySetting(int nMachineNum, ref AxFP_CLOCKLib.AxFP_CLOCK ptrObject)
        {
            InitializeComponent();

            this.m_nMachineNum = nMachineNum;
            this.pOcxObject = ptrObject;            
        }
        private unsafe void btnReadSetting_Click(object sender, EventArgs e)
        {
            
            int dwHolidayindex = Convert.ToInt32(cmbItemList.Text);

            int dwSYear = 0;
            int dwSMonth = 0;
            int dwSDay = 0;
            int dwEYear = 0;
            int dwEMonth = 0;
            int dwEDay = 0;
            int accessidcount = 0;

            int* accessidbuf = stackalloc int[3000];
            IntPtr ptr = new IntPtr(accessidbuf);

            string strHolidayname = "";
            object obj = new System.Runtime.InteropServices.VariantWrapper(strHolidayname);
            bool bRet;
            DisableDevice();
            bRet = pOcxObject.GetHoliday(m_nMachineNum, dwHolidayindex, ref obj,
                ref dwSYear,ref dwSMonth,ref dwSDay,
                ref dwEYear,ref dwEMonth,ref dwEDay,
                ref accessidcount, ptr);
            if (!bRet)
            {
                ShowErrorInfo();
                pOcxObject.EnableDevice(m_nMachineNum, 1);
                return;
            }
            tbHolidayname.Text = (string)obj;

            DateTime dtSart = new DateTime(dwSYear, dwSMonth, dwSDay);
            DateTime dtEnd = new DateTime(dwEYear, dwEMonth, dwEDay);

            dateStartTPicker.Value = dtSart;
            dateEndTPicker.Value = dtEnd;

            textaccessidcount.Text = accessidcount.ToString();

            textaccessid0.Text = accessidbuf[0].ToString();
            textaccessid1.Text = accessidbuf[1].ToString();
            textaccessid2.Text = accessidbuf[2].ToString();
            textaccessid3.Text = accessidbuf[3].ToString();
            textaccessid4.Text = accessidbuf[4].ToString();
            textaccessid5.Text = accessidbuf[5].ToString();
            textaccessid6.Text = accessidbuf[6].ToString();
            textaccessid7.Text = accessidbuf[7].ToString();
            textaccessid8.Text = accessidbuf[8].ToString();
            textaccessid9.Text = accessidbuf[9].ToString();
            textaccessid10.Text = accessidbuf[10].ToString();
            textaccessid11.Text = accessidbuf[11].ToString();
            textaccessid12.Text = accessidbuf[12].ToString();
            textaccessid13.Text = accessidbuf[13].ToString();
            textaccessid14.Text = accessidbuf[14].ToString();
            textaccessid15.Text = accessidbuf[15].ToString();
            textaccessid16.Text = accessidbuf[16].ToString();
            textaccessid17.Text = accessidbuf[17].ToString();
            textaccessid18.Text = accessidbuf[18].ToString();
            textaccessid19.Text = accessidbuf[19].ToString();
            pOcxObject.EnableDevice(m_nMachineNum, 1);
            labelInfo.Text = "GetHoliday Success...";

        }

        private unsafe void btnWriteSetting_Click(object sender, EventArgs e)
        {
            int dwHolidayindex = Convert.ToInt32(cmbItemList.Text);

           
            int accessidcount = 0;


            int* accessidbuf = stackalloc int[3000];
            IntPtr ptr = new IntPtr(accessidbuf);
            bool bRet;
            /////

            DateTime dtSart = dateStartTPicker.Value;
            DateTime dtEnd = dateEndTPicker.Value;

            dateStartTPicker.Value = dtSart;
            dateEndTPicker.Value = dtEnd;

            accessidcount = Convert.ToInt32(textaccessidcount.Text);

            accessidbuf[0] = Convert.ToInt32(textaccessid0.Text);
            accessidbuf[1] = Convert.ToInt32(textaccessid1.Text);
            accessidbuf[2] = Convert.ToInt32(textaccessid2.Text);
            accessidbuf[3] = Convert.ToInt32(textaccessid3.Text);
            accessidbuf[4] = Convert.ToInt32(textaccessid4.Text);
            accessidbuf[5] = Convert.ToInt32(textaccessid5.Text);
            accessidbuf[6] = Convert.ToInt32(textaccessid6.Text);
            accessidbuf[7] = Convert.ToInt32(textaccessid7.Text);
            accessidbuf[8] = Convert.ToInt32(textaccessid8.Text);
            accessidbuf[9] = Convert.ToInt32(textaccessid9.Text);
            accessidbuf[10] = Convert.ToInt32(textaccessid10.Text);
            accessidbuf[11] = Convert.ToInt32(textaccessid11.Text);
            accessidbuf[12] = Convert.ToInt32(textaccessid12.Text);
            accessidbuf[13] = Convert.ToInt32(textaccessid13.Text);
            accessidbuf[14] = Convert.ToInt32(textaccessid14.Text);
            accessidbuf[15] = Convert.ToInt32(textaccessid15.Text);
            accessidbuf[16] = Convert.ToInt32(textaccessid16.Text);
            accessidbuf[17] = Convert.ToInt32(textaccessid17.Text);
            accessidbuf[18] = Convert.ToInt32(textaccessid18.Text);
            accessidbuf[19] = Convert.ToInt32(textaccessid19.Text);
            DisableDevice();

            string strHolidayname;


            if (tbHolidayname.TextLength == 0)
            {
                strHolidayname = "";
            }
            else
            {
                strHolidayname = tbHolidayname.Text;

            }
            object obj = new System.Runtime.InteropServices.VariantWrapper(strHolidayname);

            bRet = pOcxObject.SetHoliday(m_nMachineNum, dwHolidayindex, ref obj,
                 dtSart.Year, dtSart.Month, dtSart.Day,
                 dtEnd.Year, dtEnd.Month, dtEnd.Day,
                 accessidcount, ptr);
            if (!bRet)
            {
                ShowErrorInfo();
                pOcxObject.EnableDevice(m_nMachineNum, 1);
                return;
            }
            pOcxObject.EnableDevice(m_nMachineNum, 1);
            labelInfo.Text = "SetHoliday Success...";
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int dwHolidayindex = Convert.ToInt32(cmbItemList.Text);

            if (!DisableDevice())
            {
                return;
            }

            bool bRet;

            bRet = pOcxObject.DeleteHoliday(m_nMachineNum, dwHolidayindex);
            if (bRet)
            {
                labelInfo.Text = "Delete holiday OK...";
            }
            else
            {
                ShowErrorInfo();
            }

            //enable device
            pOcxObject.EnableDevice(m_nMachineNum, 1);
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            if (!DisableDevice())
            {
                return;
            }

            bool bRet;

            bRet = pOcxObject.CleanHoliday(m_nMachineNum);
            if (bRet)
            {
                labelInfo.Text = "CleanHoliday OK...";
            }
            else
            {
                ShowErrorInfo();
            }

            //enable device
            pOcxObject.EnableDevice(m_nMachineNum, 1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Owner.Visible = true;
            this.Close();
        }
    }
}
