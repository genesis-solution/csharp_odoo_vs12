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
    public partial class LockCtrl : Form
    {
        private int m_nMachineNum;
        private AxFP_CLOCKLib.AxFP_CLOCK pOcxObject;
        public LockCtrl()
        {
            InitializeComponent();
        }

        public LockCtrl(int nMachineNum, ref AxFP_CLOCKLib.AxFP_CLOCK ptrObject)
        {
            InitializeComponent();

            this.m_nMachineNum = nMachineNum;
            this.pOcxObject = ptrObject;           

        }

        private void LockCtrl_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Visible = true;
        }

        private void btnGetDoorStatus_Click(object sender, EventArgs e)
        {
            DisableDevice();

            bool bRet;

            int nStatus = 0;
            bRet = pOcxObject.GetDoorStatus(m_nMachineNum, ref nStatus);
            if(bRet)
            {
                switch(nStatus)
                {
                    case (int)DoorStatus.FORCEOPEN:
                        {
                            labelInfo.Text = "Uncond Door Open State!";
                        }
                        break;
                    case (int)DoorStatus.FORCECLOSE:
                        {
                            labelInfo.Text = "Uncond Door Close State!";

                        }
                        break;
                    case (int)DoorStatus.SOFTWAREOPEN:
                        {
                            labelInfo.Text = "Program Door Open State!";

                        }
                        break;
                    case (int)DoorStatus.RESTORETOAUTO:
                        {
                            labelInfo.Text = "Restore to AUTO !";

                        }
                        break;
                    case (int)DoorStatus.REBOOT_FPA_MACHINE:
                        {
                            labelInfo.Text = "Reboot FPA Machine!";

                        }
                        break;
                    case (int)DoorStatus.DEASSERT_ALARM:
                        {
                            labelInfo.Text = "Door Warning Sound Cancel!";

                        }
                        break;
                }
            }
            else
            {
                ShowErrorInfo();
            }

            pOcxObject.EnableDevice(m_nMachineNum, 1);
        }

        private void btnDoorOpen_Click(object sender, EventArgs e)
        {
            DisableDevice();

            bool bRet;            
            bRet = pOcxObject.SetDoorStatus(m_nMachineNum, (int)DoorStatus.SOFTWAREOPEN);
            if (bRet)
            {
                labelInfo.Text = "Door Open Success!";
            }
            else
            {
                ShowErrorInfo();
            }

            pOcxObject.EnableDevice(m_nMachineNum, 1);
        }

        private void btnAutoRecover_Click(object sender, EventArgs e)
        {
            DisableDevice();

            bool bRet;
            bRet = pOcxObject.SetDoorStatus(m_nMachineNum, (int)DoorStatus.RESTORETOAUTO);
            if (bRet)
            {
                labelInfo.Text = "Auto CMD Send Success!";
            }
            else
            {
                ShowErrorInfo();
            }

            pOcxObject.EnableDevice(m_nMachineNum, 1);
        }

        private void btnReboot_Click(object sender, EventArgs e)
        {
            DisableDevice();

            bool bRet;
            bRet = pOcxObject.SetDoorStatus(m_nMachineNum, (int)DoorStatus.REBOOT_FPA_MACHINE);
            if (bRet)
            {
                labelInfo.Text = "Reboot CMD Send Success!";
            }
            else
            {
                ShowErrorInfo();
            }

            pOcxObject.EnableDevice(m_nMachineNum, 1);
        }

        private void btnUncondOpen_Click(object sender, EventArgs e)
        {
            DisableDevice();

            bool bRet;
            bRet = pOcxObject.SetDoorStatus(m_nMachineNum, (int)DoorStatus.FORCEOPEN);
            if (bRet)
            {
                labelInfo.Text = "Uncond Door Open CMD Send Success!";
            }
            else
            {
                ShowErrorInfo();
            }

            pOcxObject.EnableDevice(m_nMachineNum, 1);
        }

        private void btnUncondClose_Click(object sender, EventArgs e)
        {
            DisableDevice();

            bool bRet;
            bRet = pOcxObject.SetDoorStatus(m_nMachineNum, (int)DoorStatus.FORCECLOSE);
            if (bRet)
            {
                labelInfo.Text = "Uncond Door Close CMD Send Success!";
            }
            else
            {
                ShowErrorInfo();
            }

            pOcxObject.EnableDevice(m_nMachineNum, 1);
        }

        private void btnWarnCancel_Click(object sender, EventArgs e)
        {
            DisableDevice();

            bool bRet;
            bRet = pOcxObject.SetDoorStatus(m_nMachineNum, (int)DoorStatus.DEASSERT_ALARM);
            if (bRet)
            {
                labelInfo.Text = "Uncond Door No Sound CMD Send Success!";
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
    }
}
