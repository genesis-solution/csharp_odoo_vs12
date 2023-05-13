using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace FPClient
{
    public partial class SetPassTime : Form
    {
        private int m_nMachineNum;
        private AxFP_CLOCKLib.AxFP_CLOCK pOcxObject;

        public SetPassTime()
        {
            InitializeComponent();
        }

        public SetPassTime(int nMachineNum, ref AxFP_CLOCKLib.AxFP_CLOCK ptrObject)
        {
            InitializeComponent();

            this.m_nMachineNum = nMachineNum;
            this.pOcxObject = ptrObject;
            cmbPasstimeDayList.SelectedIndex = 0;
            cmbGroupDayList.SelectedIndex = 0;
            cmbWeekList.SelectedIndex = 0;
            labelInfo.Select();
        }

        private void SetPassTime_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Visible = true;

        }

        private void btnGetUserCtrl_Click(object sender, EventArgs e)
        {
            bool bRet;

            if (!DisableDevice())
            {
                return;
            }

            int dwEnrollNum = Convert.ToInt32(textUserID.Text);
            int dwWeekTimeID = 0;
            int dwGroupID = 0;

            int dwSYear = 0;
            int dwSMonth = 0;
            int dwSDay = 0;
            int dwEYear = 0;
            int dwEMonth = 0;
            int dwEDay = 0;

            bRet = pOcxObject.GetUserCtrl(
                m_nMachineNum,
                dwEnrollNum,
                ref dwWeekTimeID,
                ref dwGroupID,
                ref dwSYear,
                ref dwSMonth,
                ref dwSDay,
                ref dwEYear,
                ref dwEMonth,
                ref dwEDay
                );
            if (bRet)
            {
                DateTime dtSart = new DateTime(dwSYear, dwSMonth, dwSDay);
                DateTime dtEnd = new DateTime(dwEYear, dwEMonth, dwEDay);

                dateStartTPicker.Value = dtSart;
                dateEndTPicker.Value = dtEnd;

                textWeekID.Text = dwWeekTimeID.ToString();
                textGroupID.Text = dwGroupID.ToString();

                labelInfo.Text = "Success...";
            }
            else
            {
                ShowErrorInfo();
            }

            //enable device
            pOcxObject.EnableDevice(m_nMachineNum, 1);

        }

        private void btnSetUserCtrl_Click(object sender, EventArgs e)
        {
            bool bRet;

            if (!DisableDevice())
            {
                return;
            }

            int dwEnrollNum = Convert.ToInt32(textUserID.Text);
            int dwWeekTimeID = Convert.ToInt32(textWeekID.Text);
            int dwGroupID = Convert.ToInt32(textGroupID.Text);

           DateTime dtSart = dateStartTPicker.Value;
           DateTime dtEnd = dateEndTPicker.Value;


            bRet = pOcxObject.SetUserCtrl(
                m_nMachineNum,
                dwEnrollNum,
                dwWeekTimeID,
                dwGroupID,
                dtSart.Year,
                dtSart.Month,
                dtSart.Day,
                dtEnd.Year,
                dtEnd.Month,
                dtEnd.Day);
            if (bRet)
            {
                labelInfo.Text = "SetUserctrl OK...";
            }
            else
            {
                ShowErrorInfo();
            }

            //enable device
            pOcxObject.EnableDevice(m_nMachineNum, 1);
        }

        private void btnDelUserCtrl_Click(object sender, EventArgs e)
        {
            if (!DisableDevice())
            {
                return;
            }

            bool bRet;
            int dwEnrollNum = Convert.ToInt32(textUserID.Text);

            bRet = pOcxObject.DeleteUserCtrl(m_nMachineNum, dwEnrollNum);
            if (bRet)
            {
                labelInfo.Text = "DeleteUserCtrl OK...";
            }
            else
            {
                ShowErrorInfo();
            }

            //enable device
            pOcxObject.EnableDevice(m_nMachineNum, 1);
        }

        private void btnClearAllUserCtrl_Click(object sender, EventArgs e)
        {
            if (!DisableDevice())
            {
                return;
            }

            bool bRet;         

            bRet = pOcxObject.ClearUserCtrl(m_nMachineNum);
            if (bRet)
            {
                labelInfo.Text = "ClearUserCtrl OK...";
            }
            else
            {
                ShowErrorInfo();
            }

            //enable device
            pOcxObject.EnableDevice(m_nMachineNum, 1);
        }

        private void btnReadSet_Click(object sender, EventArgs e)
        {
            bool bRet;

            if (!DisableDevice())
            {
                return;
            }
            int nDay = cmbGroupDayList.SelectedIndex + 1;
            int nGroupValue = 0;

            bRet = pOcxObject.GetLockGroup(m_nMachineNum, nDay, ref nGroupValue );
            if (bRet)
            {
                labelInfo.Text = "Success...";
                textGroupValue.Text = nGroupValue.ToString();
            }
            else
            {
                ShowErrorInfo();
            }

            pOcxObject.EnableDevice(m_nMachineNum, 1);

        }

        private void btnWriteSet_Click(object sender, EventArgs e)
        {
            bool bRet;

            if (!DisableDevice())
            {
                return;
            }
            int nDay = cmbGroupDayList.SelectedIndex + 1;
            int nGroupValue = Convert.ToInt32(textGroupValue.Text);

            bRet = pOcxObject.SetLockGroup(m_nMachineNum, nDay, nGroupValue);
            if (bRet)
            {
                labelInfo.Text = "Success...";
                //textGroupValue.Text = nGroupValue.ToString();
            }
            else
            {
                ShowErrorInfo();
            }

            pOcxObject.EnableDevice(m_nMachineNum, 1);
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

        private unsafe void btnPasstimeReadSet_Click(object sender, EventArgs e)
        {
            bool bRet;

            if (!DisableDevice())
            {
                return;
            }

            int nDay = cmbPasstimeDayList.SelectedIndex + 1;

            PasstimeInfo *dwTimeInfo = stackalloc PasstimeInfo [5];               
              

            IntPtr ptr = new IntPtr(dwTimeInfo);

           
            bRet = this.pOcxObject.GetDayPassTime(m_nMachineNum, nDay, ptr);            
            if (bRet)
            {
                textStartTime_Hour1.Text = dwTimeInfo->bSHour.ToString();
                textStartTime_Minute1.Text = dwTimeInfo->bSMinute.ToString();
                textEndTime_Hour1.Text = dwTimeInfo->bEHour.ToString();
                textEndTime_Minute1.Text = dwTimeInfo->bEMinute.ToString();

                dwTimeInfo++;

                textStartTime_Hour2.Text = dwTimeInfo->bSHour.ToString();
                textStartTime_Minute2.Text = dwTimeInfo->bSMinute.ToString();
                textEndTime_Hour2.Text = dwTimeInfo->bEHour.ToString();
                textEndTime_Minute2.Text = dwTimeInfo->bEMinute.ToString();

                dwTimeInfo++;

                textStartTime_Hour3.Text = dwTimeInfo->bSHour.ToString();
                textStartTime_Minute3.Text = dwTimeInfo->bSMinute.ToString();
                textEndTime_Hour3.Text = dwTimeInfo->bEHour.ToString();
                textEndTime_Minute3.Text = dwTimeInfo->bEMinute.ToString();

                dwTimeInfo++;

                textStartTime_Hour4.Text = dwTimeInfo->bSHour.ToString();
                textStartTime_Minute4.Text = dwTimeInfo->bSMinute.ToString();
                textEndTime_Hour4.Text = dwTimeInfo->bEHour.ToString();
                textEndTime_Minute4.Text = dwTimeInfo->bEMinute.ToString();

                dwTimeInfo++;

                textStartTime_Hour5.Text = dwTimeInfo->bSHour.ToString();
                textStartTime_Minute5.Text = dwTimeInfo->bSMinute.ToString();
                textEndTime_Hour5.Text = dwTimeInfo->bEHour.ToString();
                textEndTime_Minute5.Text = dwTimeInfo->bEMinute.ToString();    
            }
            else
            {
                ShowErrorInfo();
            }  

            pOcxObject.EnableDevice(m_nMachineNum, 1);

        }

        private unsafe void btnPasstimeWriteSet_Click(object sender, EventArgs e)
        {
            bool bRet;

            if (!DisableDevice())
            {
                return;
            }

            int nDay = cmbPasstimeDayList.SelectedIndex + 1;

            PasstimeInfo* dwTimeInfo = stackalloc PasstimeInfo[5];

            IntPtr ptr = new IntPtr(dwTimeInfo);

            dwTimeInfo->bSHour = Convert.ToByte(textStartTime_Hour1.Text);
            dwTimeInfo->bSMinute = Convert.ToByte(textStartTime_Minute1.Text);
            dwTimeInfo->bEHour = Convert.ToByte(textEndTime_Hour1.Text);
            dwTimeInfo->bEMinute = Convert.ToByte(textEndTime_Minute1.Text);

            dwTimeInfo++;

            dwTimeInfo->bSHour = Convert.ToByte(textStartTime_Hour2.Text);
            dwTimeInfo->bSMinute = Convert.ToByte(textStartTime_Minute2.Text);
            dwTimeInfo->bEHour = Convert.ToByte(textEndTime_Hour2.Text);
            dwTimeInfo->bEMinute = Convert.ToByte(textEndTime_Minute2.Text);

            dwTimeInfo++;
            dwTimeInfo->bSHour = Convert.ToByte(textStartTime_Hour3.Text);
            dwTimeInfo->bSMinute = Convert.ToByte(textStartTime_Minute3.Text);
            dwTimeInfo->bEHour = Convert.ToByte(textEndTime_Hour3.Text);
            dwTimeInfo->bEMinute = Convert.ToByte(textEndTime_Minute3.Text);

            dwTimeInfo++;
            dwTimeInfo->bSHour = Convert.ToByte(textStartTime_Hour4.Text);
            dwTimeInfo->bSMinute = Convert.ToByte(textStartTime_Minute4.Text);
            dwTimeInfo->bEHour = Convert.ToByte(textEndTime_Hour4.Text);
            dwTimeInfo->bEMinute = Convert.ToByte(textEndTime_Minute4.Text);

            dwTimeInfo++;
            dwTimeInfo->bSHour = Convert.ToByte(textStartTime_Hour5.Text);
            dwTimeInfo->bSMinute = Convert.ToByte(textStartTime_Minute5.Text);
            dwTimeInfo->bEHour = Convert.ToByte(textEndTime_Hour5.Text);
            dwTimeInfo->bEMinute = Convert.ToByte(textEndTime_Minute5.Text);

            bRet = pOcxObject.SetDayPassTime(m_nMachineNum, nDay, ptr);

            if (bRet)
            {
                labelInfo.Text = "SetDayPassTime Success...";
            }
            else
            {
                ShowErrorInfo();
            }

            pOcxObject.EnableDevice(m_nMachineNum, 1);

        }

        private unsafe void btnWeekReadSet_Click(object sender, EventArgs e)
        {
            bool bRet;

            if (!DisableDevice())
            {
                return;
            }

            int nWeek = cmbWeekList.SelectedIndex + 1;

            byte * byteInfo= stackalloc byte[7];

            IntPtr ptr = new IntPtr(byteInfo);

            bRet = pOcxObject.GetWeekPassTime(m_nMachineNum, nWeek, ptr);
            if (!bRet)
            {
                ShowErrorInfo();
                pOcxObject.EnableDevice(m_nMachineNum, 1);

                return;
            }

            textSunday.Text = (*byteInfo++).ToString();

            textMonday.Text = (*byteInfo++).ToString();
            textTuesday.Text = (*byteInfo++).ToString();
            textWednesday.Text = (*byteInfo++).ToString();
            textThursday.Text = (*byteInfo++).ToString();
            textFriday.Text = (*byteInfo++).ToString();

            textSataday.Text = (*byteInfo).ToString();

            labelInfo.Text = "GetWeekPassTime ok...";

            pOcxObject.EnableDevice(m_nMachineNum, 1);

        }

        private unsafe void btnWeekWriteSet_Click(object sender, EventArgs e)
        {
            bool bRet;

            if (!DisableDevice())
            {
                return;
            }

            int nWeek = cmbWeekList.SelectedIndex + 1;

            byte* byteInfo = stackalloc byte[7];

            IntPtr ptrAddr = new IntPtr(byteInfo);

            *byteInfo++ = Convert.ToByte(textSunday.Text);
            *byteInfo++ = Convert.ToByte(textMonday.Text);
            *byteInfo++ = Convert.ToByte(textTuesday.Text);
            *byteInfo++ = Convert.ToByte(textWednesday.Text);
            *byteInfo++ = Convert.ToByte(textThursday.Text);
            *byteInfo++ = Convert.ToByte(textFriday.Text);
            *byteInfo = Convert.ToByte(textSataday.Text);

            bRet = pOcxObject.SetWeekPassTime(m_nMachineNum, nWeek, ptrAddr);
            if (bRet)
            {
                labelInfo.Text = "SetWeekPassTime ok...";

            } 
            else
            {
                ShowErrorInfo();

            }

            pOcxObject.EnableDevice(m_nMachineNum, 1);

        }
    }
}
