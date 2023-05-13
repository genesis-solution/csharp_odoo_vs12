using System.ComponentModel;
using System.Runtime.InteropServices;
using System;
using System.Diagnostics;


namespace FPClient
{
    public class common
    {

        public static string FormErrorStr(int nErrorCode)
        {
            switch(nErrorCode)
            {
                case 0:
                    {
                        return "SUCCESS";
                        
                    }
                case 1:
                    {
                        return "ERR_COMPORT_ERROR";
                        
                    }
                case 2:
                    {
                        return "ERR_WRITE_FAIL";
                        
                    }
                case 3:
                    {
                        return "ERR_READ_FAIL";

                    }
                case 4:
                    {
                        return "ERR_INVALID_PARAM";                       
                    }
                case 5:
                    {
                        return "ERR_NON_CARRYOUT";

                    }
                case 6:
                    {
                        return "ERR_LOG_END";
                    }
                case 7:
                    return "ERR_MEMORY";
                    
                case 8:
                    return "ERR_MULTIUSER";
                    
            }
            return "Not My Fault";
        }

        public static String FormString(int nVerify, int nEnrollNum)
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
                switch (nAction)
                {
                    case 0:
                        return "Normal";
                    //break;

                    case 1:
                        return "f1";
                    //break;

                    case 2:
                        return "f2";
                    //break;

                    case 3:
                        return "f3";
                    //break;

                    case 4:
                        return "f4";
                    // break;

                    case 5:
                        return "in";
                    // break;

                    case 6:
                        return "out";
                    //break;

                    case 7:
                        return "--";
                    //break;
                }
            }

            return "Not my fault";
        }

        public static string FormSLogStr(int dwIdentify)
        {
            switch (dwIdentify)
            {
                case 3:
                    return "Enroll User";

                case 4:
                    return "Enroll Manager";


                case 5:
                    return "Delete Fp Data";
   

                case 6:
                    return "Delete Password";


                case 7:
                    return "Delete All LogData";
  
                case 8:
                    return "Delete Card Data";

                case 9:
                    return "Modify System Info";
                case 10:
                    return "Modify System Time";

                case 11:
                    return "Modify Log Setting";

                case 12:
                    return "Modify Comm Setting";
 

                default:
                    return "error";



            }

            //return "not my fault...";
        }

        public static void DebugOut(string msg)
        {
            StackTrace st = new StackTrace(false);
            string caller = st.GetFrame(1).GetMethod().Name;
            Debug.WriteLine(caller + ": " + msg);
        }

        public static void OpenFileOrSaveFileReturnPath(bool bOpenorSave, ref string str)
        {
            
        }
    }
    enum CURDEVICETYPE
    {
        [Description("this means connection through COM port")]
        DEVICE_COM,
        [Description("this means connection through net work")]
        DEVICE_NET,
        [Description("this means connection through DEVICE_P2S")]
        DEVICE_P2S,
        [Description("this means connection through USB")]
        DEVICE_USB,

    };

    enum DoorStatus
    {
        FORCEOPEN = 1,
        FORCECLOSE,
        SOFTWAREOPEN,
        RESTORETOAUTO,
        REBOOT_FPA_MACHINE, //Finger printer acquisition
        DEASSERT_ALARM

    };
    public struct TimeInfo
    {
        public int nYear;
        public int nMonth;
        public int nDay;
        public int nHour;
        public int nMinute;
        public int nDayofWeek;
        public TimeInfo(int init)
       {
           nYear =
           nMonth =
           nDay =
           nHour =
           nMinute =
           nDayofWeek = init;
       }
    }

    public struct PasstimeInfo
    {
        public byte bSHour;
        public byte bSMinute;
        public byte bEHour;
        public byte bEMinute;
       
    }

    public unsafe struct BellInfo
    {
        public fixed byte bValid[8];
        public fixed byte bHour[8];
        public fixed byte bMinute[8];     

    }

    public struct GeneralLogInfo
    {
        public int dwTMachineNumber;
        public int dwEnrollNumber;
        public int dwEMachineNumber;
        public int dwVerifyMode;       
        public int dwInout;
        public int dwEvent;
        public int dwYear;
        public int dwMonth;
        public int dwDay;
        public int dwHour;
        public int dwMinute;
        public int dwSecond;  
    }

    public struct SuperLogInfo
    {
        public int dwTMachineNumber;
        public int dwSEnrollNumber;
        public int dwSEMachineNumber;
        public int dwGEnrollNumber;
        public int dwGEMachineNumber;
        public int dwFingerNumber;
        public int dwManipulation;
        public int dwYear;
        public int dwMonth;
        public int dwDay;
        public int dwHour;
        public int dwMinute;

    }



}
