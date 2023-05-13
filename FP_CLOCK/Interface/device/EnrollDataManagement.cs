using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb; 

using System.Runtime.InteropServices;

namespace FPClient
{
   
    public partial class EnrollDataManagement : Form
    {
        private int m_nMachineNum;
        private AxFP_CLOCKLib.AxFP_CLOCK pOcxObject;
        private string mstrPhotoDir = "C:\\PHOTO";
       

        public EnrollDataManagement()
        {
            InitializeComponent();
            
        }

        Byte[] gbytEnrollData;
        Byte[] gbytEnrollDataFace;

        public EnrollDataManagement(int nMachineNum, ref AxFP_CLOCKLib.AxFP_CLOCK ptrObject)
        {
            InitializeComponent();
            this.m_nMachineNum = nMachineNum;
            this.pOcxObject = ptrObject;

            cmbBackupNum.SelectedIndex = 0;
            cmbEMachineNum.SelectedIndex = 0;
            cmbPrivilege.SelectedIndex = 0;
            SetPhotoDir();

//           string strConnection = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=.\EnrollData.mdb";
//             conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=.\EnrollData.mdb");
//             conn.Open();
//             string sql = "SELECT * FROM tblEnroll";
// 
//             OleDbCommand command = new OleDbCommand(sql, conn);
// 
//             OleDbDataReader reader = command.ExecuteReader();
// 
//             reader.Read();            
// 
//             reader.Close(); 
//             conn.Close();
// 
//             adodc1.ConnectionString = strConnection;
//             adodc1.RecordSource = "SELECT * FROM tblEnroll";
//             adodc1.Refresh();
//             int nCount = adodc1.Recordset.RecordCount;

//             DAO.DBEngine DBE;
//             DAO.Database DB;
//             string DBPath = ".\\EnrollData.mdb";
//             DBE = new DAO.DBEngine();
//             DB = DBE.OpenDatabase(DBPath, false, false, "");
//             //MessageBox.Show(DB.Relations.Count.ToString());
//             //MessageBox.Show(DB.Recordsets.Count.ToString());
//             DAO.TableDef daoTable = DB.TableDefs["tblEnroll"];
//             DAO.Field daoField = daoTable.Fields["EnrollNumber"];
            
        }

        private void EnrollDataManagement_FormClosed(object sender, FormClosedEventArgs e)
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


        private void ShowErrorInfo()
        {
            int nErrorValue = 0;
            pOcxObject.GetLastError(ref nErrorValue);
            labelInfo.Text = common.FormErrorStr(nErrorValue);
        }

        private void btnClearAllData_Click(object sender, EventArgs e)
        {
           DialogResult dr = MessageBox.Show("Clear all data on the machine?!!",
                "Warning",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (dr == DialogResult.No)
            {
                return;
            }

            DisableDevice();

            bool bRet = pOcxObject.ClearKeeperData(m_nMachineNum);
            if (bRet)
            {
                labelInfo.Text = "ClearKeeperData ...";
            } 
            else
            {
                labelInfo.Text = "Error";
            }

            pOcxObject.EnableDevice(m_nMachineNum, 1);

        }

        private void btnRmAllManager_Click(object sender, EventArgs e)
        {
            bool bRet;

            DisableDevice();
            bRet = pOcxObject.BenumbAllManager(m_nMachineNum);
            if (bRet)
            {
                labelInfo.Text = "Success...";
            } 
            else
            {
                ShowErrorInfo();
            }

            pOcxObject.EnableDevice(m_nMachineNum, 1);

        }

        //
        // take care of exceptions
        //
        private void btnSetCompanyString_Click(object sender, EventArgs e)
        {
            DisableDevice();

            string str;


            if (tbcompanyString.TextLength == 0)
            {
                str = " ";
            }
            else
            {
                str = tbcompanyString.Text;
            }        
            

            bool bRet;
            
            Object ob = new System.Runtime.InteropServices.VariantWrapper(str);
            
            //
            //
            //SetCompanyName
            bRet = pOcxObject.SetCompanyName(m_nMachineNum,
              1,
              ref ob 
              );

            // or
/*
            bRet = pOcxObject.SetCompanyNameWithString(m_nMachineNum,
                1,
                ref str
                );*/
            if (bRet)
            {
                labelInfo.Text = "Set Company Name OK"; 
            } 
            else
            {
                ShowErrorInfo();
            }

            pOcxObject.EnableDevice(m_nMachineNum, 1);

        }

        private void btnDelCompanyString_Click(object sender, EventArgs e)
        {
            DisableDevice();

            string strName = "";
            Object ob = new System.Runtime.InteropServices.VariantWrapper(strName);

            try
            {
                pOcxObject.SetCompanyName(m_nMachineNum,
                0,   //clean
                ref ob);
            }
            
            catch(Exception ev)
            {
                pOcxObject.EnableDevice(m_nMachineNum, 1);

                common.DebugOut( ev.ToString());
            }
            


        }

        //
        //参数要检查
        //
        private void btnGetUserName_Click(object sender, EventArgs e)
        {
            //clear
            tbEnrollName.Text = "";
            labelInfo.Text = "";

            DisableDevice();

            int dwEnMachineID = cmbEMachineNum.SelectedIndex + 1;
            int dwEnrollNum = Convert.ToInt32(tbEnrollNum.Text);

            string strName = "";
            object obj = new System.Runtime.InteropServices.VariantWrapper(strName);
            object ob = new object();
            ob = strName;

            bool bRet = pOcxObject.GetUserName(0,
                m_nMachineNum,
                dwEnrollNum,
                dwEnMachineID,
                ref obj
                );
            if (bRet)
            {
                labelInfo.Text = "Success...";
                tbEnrollName.Text = (string)obj;
            } 
            else
            {
                ShowErrorInfo();
            }

            EnableDevice();
            
        }

        private void EnableDevice()
        {
            pOcxObject.EnableDevice(m_nMachineNum, 1);
        }

        private void btnSetUserName_Click(object sender, EventArgs e)
        {
            DisableDevice();
            int dwEnMachineID = cmbEMachineNum.SelectedIndex + 1;
            int dwEnrollNum = Convert.ToInt32(tbEnrollNum.Text);
            string strName;

            if (tbEnrollName.TextLength == 0)
            {
                strName = "";
            } 
            else
            {
                strName = tbEnrollName.Text;

            }
            object obj = new System.Runtime.InteropServices.VariantWrapper(strName);

            bool bRet = pOcxObject.SetUserName(0,
              m_nMachineNum,
              dwEnrollNum,
              dwEnMachineID,
              ref obj
              );
            if (bRet)
            {
                labelInfo.Text = "Success...";

            }
            else
            {
                ShowErrorInfo();
            }

            EnableDevice();
            
        }

        private void btnModifyPrivilege_Click(object sender, EventArgs e)
        {
            DisableDevice();
            int dwEnMachineID = cmbEMachineNum.SelectedIndex + 1;
            int dwEnrollNum = Convert.ToInt32(tbEnrollNum.Text);
            int dwBackupNum = cmbBackupNum.SelectedIndex;

            int dwPrivilege = cmbPrivilege.SelectedIndex;
            bool bRet;

            bRet = pOcxObject.ModifyPrivilege(m_nMachineNum,
                dwEnrollNum, 
                dwEnMachineID,
                dwBackupNum, 
                dwPrivilege);
            if (bRet)
            {
                labelInfo.Text = "ModifyPrivilege Success...";
            }
            else
            {
                ShowErrorInfo();
            }

            EnableDevice();
        }




        private void btnGetEnrollInfo_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            if (!DisableDevice())
            {
                return;

            }

            int dwEnrollNumber = 0;
            int dwMachineNumber = 0;
            int dwBackupNumber = 0;
            int dwUserPrivilege = 0;
            int dwAttendenceEnable = 0;
            bool bRet;

            bRet = pOcxObject.ReadAllUserID(m_nMachineNum);
            if (!bRet)
            {
                ShowErrorInfo();
                EnableDevice();

                return;
            }

            labelInfo.Text = "ReadAllUserID OK";
            listBox1.Items.Add("No.       EnNo       EMNo        Fp       Priv    Enable");

            int nIndex = 0;
            string str;
            do 
            {
                bRet = pOcxObject.GetAllUserID(m_nMachineNum,
                ref dwEnrollNumber,
                ref dwMachineNumber,
                ref dwBackupNumber,
                ref dwUserPrivilege,
                ref dwAttendenceEnable);

                str = nIndex.ToString("D3") + "\t" 
                    +dwEnrollNumber.ToString("D8")+"\t"
                    +dwMachineNumber.ToString() + "\t"
                    +dwBackupNumber.ToString()+ "\t"
                    +dwUserPrivilege.ToString()+"\t"
                    +dwAttendenceEnable.ToString();
                
                if (bRet)
                {
                    listBox1.Items.Add(str);
                    nIndex++;
                }

            } while (bRet);
            
            if (nIndex>0)
            {
                labelInfo.Text = "GetAllUserID OK";
            }
            else
            {
                ShowErrorInfo();
            }

            EnableDevice();
        }

        //need check about text box input strings
        private void btnDelEnData_Click(object sender, EventArgs e)
        {
            int dwEnrollNum = Int32.Parse(tbEnrollNum.Text);
            int dwEnMachineID = cmbEMachineNum.SelectedIndex + 1;
            int dwBackupNum = Convert.ToInt32(cmbBackupNum.Text);

            DisableDevice();

            bool bRet = pOcxObject.DeleteEnrollData(
                m_nMachineNum,
                dwEnrollNum,
                dwEnMachineID,
                dwBackupNum);
            if (bRet)
            {
                labelInfo.Text = "DeleteEnrollData OK";	
            } 
            else
            {
                ShowErrorInfo();
            }
            EnableDevice();


        }

        private void btnUDiskDownLoad_Click(object sender, EventArgs e)
        {
            string localFilePath = "";
            if (!GetFileFullPath_SaveFile(ref localFilePath))
            {
                return;
            }           
            
            pOcxObject.UsbEnrollDataStart();

            bool bRet;

            int dwEMachineNumber;
            int dwEnrollNumber;
            int dwFingerNumber;
            int dwPrivilege;
            int dwPassword;
            int[] dwFPData = new int[1420 / 4];
            object objFPData = 0;
            object objStrName = 0;
            string str;

            OleDbConnection myAccessConn;
            string strConnection = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=.\EnrollData.mdb";
            myAccessConn = new OleDbConnection(strConnection);
            myAccessConn.Open();

            if (myAccessConn.State != ConnectionState.Open)
            {                
                MessageBox.Show("Access数据库的连接失败!", "Access数据库的连接");
                return;
            }
            else
            {
            }

            string strAccessSelect = "SELECT * FROM tblEnroll";
            OleDbCommand myAccessCommand = new OleDbCommand(strAccessSelect, myAccessConn);
            OleDbDataAdapter myDataAdapter = new OleDbDataAdapter(myAccessCommand);
            DataSet myDataSet = new DataSet();

            myDataAdapter.Fill(myDataSet, "Categories");

            DataRowCollection dra = myDataSet.Tables["Categories"].Rows;

            if (dra.Count  == 0)
            {
                labelInfo.Text = "btnUDiskDownLoad_Click, DataBase is empty.";

                myAccessConn.Close();
                return;
            }
            
            //DataRow dRow = dra[1];

            foreach (DataRow dr in dra)
            {
                dwEMachineNumber = Int32.Parse(dr["EMachineNumber"].ToString());
                dwEnrollNumber = Int32.Parse(dr["EnrollNumber"].ToString());
                dwFingerNumber = Int32.Parse(dr["FingerNumber"].ToString());
                dwPrivilege = Int32.Parse(dr["Privilige"].ToString());
                dwPassword = Int32.Parse(dr["enPassword"].ToString());
                str = dr["EnrollName"].ToString();

                objStrName = new System.Runtime.InteropServices.VariantWrapper( str );

                if (dwFingerNumber < 10)
                {

                    objFPData = new System.Runtime.InteropServices.VariantWrapper(dr["FPData"]);
                }
                else
                {
                    objFPData = new System.Runtime.InteropServices.VariantWrapper(dwFPData);
                }

                bRet = pOcxObject.SetUsbEnrollData(                    
                    dwEnrollNumber,                    
                    dwFingerNumber,
                    dwPrivilege,
                    ref objFPData,
                    dwPassword,
                    ref objStrName
                    );
                if (!bRet)
                {
                    ShowErrorInfo();

                    myAccessConn.Close();

                    return;
                     
                }

            }//foreach

            bRet = pOcxObject.EnrollDataSaveTOFile(localFilePath);
            if (!bRet)
            {
                ShowErrorInfo();
            }

            labelInfo.Text = "SBWriteAllEnrollDatatoFile OK";

            myAccessConn.Close();

        }

        private bool GetFileFullPath_SaveFile(ref string localFilePath)
        {
            //string localFilePath/*, fileNameExt, newFileName, FilePath*/;

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = " data files(*.dat)|*.dat|All files(*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.FileName = DateTime.Now.ToString("yyyyMMdd") + ".dat";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //获得文件路径
                localFilePath = saveFileDialog1.FileName.ToString();
                //                 //获取文件名，不带路径
                //                 fileNameExt = localFilePath.Substring(localFilePath.LastIndexOf("\\") + 1);
                //                 //获取文件路径，不带文件名
                //                 FilePath = localFilePath.Substring(0, localFilePath.LastIndexOf("\\"));
                //                 //给文件名前加上时间
                //                 newFileName = DateTime.Now.ToString("yyyyMMdd") + fileNameExt;
                return true;
            }
            else
            {
                return false;
            }


        }
        private void btnUDiskUpload_Click(object sender, EventArgs e)
        {
            string localFilePath = "";           

            if (!GetFileFullPath_OpenFile(ref localFilePath))
            {
                return;
            }

            labelInfo.Text = "Working ...";

            pOcxObject.UsbEnrollDataStart();

            bool bRet;
            bRet = pOcxObject.EnrollDataReadFromFile(localFilePath);
            if (!bRet)
            {
                ShowErrorInfo();

            }

            labelInfo.Text = "Working on GetUsbEnrollData ...";
            bool bExitFlag = false;

            OleDbConnection conn;
            string strConnection = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=.\EnrollData.mdb";
            conn = new OleDbConnection(strConnection);
            conn.Open();

            if (conn.State != ConnectionState.Open)
            {                
                MessageBox.Show("Access数据库的连接失败!", "Access数据库的连接");
                return;
            }
            else
            {
            }

            int dwEnrollNumber = 0;
            int dwBackupNumber = 0;
            int dwMachinePrivilege = 0;
            int dwPassWord = 0;
//             int[] dwFPData = new int[1420/4];
//             object obj = new System.Runtime.InteropServices.VariantWrapper(dwFPData);
//             string strName ="";
//             object objName = new System.Runtime.InteropServices.VariantWrapper(strName);

            do 
            {
                int[] dwData = new int[1420 / 4];
                object obj = new System.Runtime.InteropServices.VariantWrapper(dwData);

                string strName = "";
                object objName = new System.Runtime.InteropServices.VariantWrapper(strName);

                bRet = pOcxObject.GetUsbEnrollData(
                ref dwEnrollNumber,
                ref dwBackupNumber,
                ref dwMachinePrivilege,
                ref obj,
                ref dwPassWord,
                ref objName
                );

                if (!bRet)
                {
                    int dwError = 0;
                    pOcxObject.GetLastError(ref dwError);
                    if (dwError == 6)
                    {
                        bExitFlag = true;
                    }

                    break;
                }

                dwData = (int[])obj;

                byte[] _indexData = new byte[1420];
                //分配内存
                IntPtr _ptrIndex = Marshal.AllocHGlobal(_indexData.Length);
                //int[]  转成 byte[]
                Marshal.Copy(dwData, 0, _ptrIndex, 1420 / 4);  //be careful
                Marshal.Copy(_ptrIndex, _indexData, 0, 1420);
                Marshal.FreeHGlobal(_ptrIndex);

                string sql;

                OleDbParameter[] parameters = new OleDbParameter[ 6 ];
                parameters[0] = new OleDbParameter("@EMachineNumber", OleDbType.Integer);
                parameters[0].Value = 1;                

                parameters[1] = new OleDbParameter("@EnrollNumber", OleDbType.Integer);
                parameters[1].Value = dwEnrollNumber;

                parameters[2] = new OleDbParameter("@FingerNumber", OleDbType.Integer);
                parameters[2].Value = dwBackupNumber;

                parameters[3] = new OleDbParameter("@Privilige", OleDbType.Integer);
                parameters[3].Value = dwMachinePrivilege;

                parameters[4] = new OleDbParameter("@EnrollName", OleDbType.BSTR);
                parameters[4].Value = objName;

                if (dwBackupNumber == 10 ||
                     dwBackupNumber == 11)
                {
                    parameters[5] = new OleDbParameter("@enPassword", OleDbType.Integer);
                    parameters[5].Value = dwPassWord;

                    sql = "insert into tblEnroll(EMachineNumber,EnrollNumber,FingerNumber,Privilige,EnrollName,enPassword)" +
                    "values(@EMachineNumber,@EnrollNumber,@FingerNumber,@Privilige,?,@enPassword)";  //values(?,?,?,?,?)

                }
                else
                {
                    parameters[5] = new OleDbParameter("@FPData", OleDbType.Binary);
                    parameters[5].Value = _indexData;   //accept byte[]

                    sql = "insert into tblEnroll(EMachineNumber,EnrollNumber,FingerNumber,Privilige,EnrollName,FPData)" +
                        "values(@EMachineNumber,@EnrollNumber,@FingerNumber,@Privilige,?,@FPData)";

                }

                OleDbCommand cmd = new OleDbCommand(sql, conn);
                try
                {
                    //conn.Open();
                    if (parameters != null) cmd.Parameters.AddRange(parameters);
                    cmd.ExecuteNonQuery();

                }
                catch (Exception ec)
                {
                    throw ec;
                }

               
            } while (bRet);

           if (bExitFlag == true)
           {
               labelInfo.Text = "UdiskUpload OK";
           }
           else
           {
               ShowErrorInfo();
           }

           conn.Close(); 
            
        }

        private bool GetFileFullPath_OpenFile(ref string strFilePath)
        {
            /*string strFilePath;*/

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = System.Environment.CurrentDirectory;
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                strFilePath = openFileDialog1.FileName;
                return true;
            }
            else
            {
                return false;
            }
        }
        private void btnEmptyEnData_Click(object sender, EventArgs e)
        {
            DisableDevice();

            bool bRet = pOcxObject.EmptyEnrollData(m_nMachineNum);
            if (bRet)
            {
                labelInfo.Text = "EmptyEnrollData Success...";
            } 
            else
            {
                ShowErrorInfo();
            }

            EnableDevice();
        }

        private void btnGetAllEnData_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            DisableDevice();
            OleDbConnection conn;
            string strConnection = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=.\EnrollData.mdb";
            conn = new OleDbConnection(strConnection);
            conn.Open();

            if (conn.State != ConnectionState.Open)
            {
                //MessageBox.Show("Access数据库的连接成功!", "Access数据库的连接");
                MessageBox.Show("Access数据库的连接失败!", "Access数据库的连接");
                return;
            }
            else
            {
            }


            bool bBreakFail = false;
            bool bRet;
            bRet = pOcxObject.ReadAllUserID(m_nMachineNum);
            if (!bRet)
            {
                ShowErrorInfo();
                EnableDevice();

                return;
            }
            
            int dwEnrollNumber = 0;
            int dwEnMachineID = 0;
            int dwBackupNum = 0;
            int dwPrivilegeNum = 0;
            int dwEnable = 0;
            int dwPassWord = 0;
            int vPhotoSize = 0;

//             int[] dwData = new int[1420 / 4];
//             object obj = new System.Runtime.InteropServices.VariantWrapper(dwData);

           
            do 
            {

                int[] dwData = new int[1420 / 4];
                //object obj = new System.Runtime.InteropServices.VariantWrapper(dwData);
                int[] FacedwData = new int[1888 / 4];
                int[] indexDataFacePhoto = new int[400800];
                object obj = new System.Runtime.InteropServices.VariantWrapper(FacedwData);

                bRet = pOcxObject.GetAllUserID(
                    m_nMachineNum,
                    ref dwEnrollNumber,
                    ref dwEnMachineID,
                    ref dwBackupNum,
                    ref dwPrivilegeNum,
                    ref dwEnable
                    );

                //read finished
                if (bRet == false)
                {
                    //EnableDevice();
                    bBreakFail = true;
                    //labelInfo.Text = "fail on GetAllUserID";
                    break;
                }

                 if (dwBackupNum==50)
                {
                    IntPtr ptrIndexFacePhoto = Marshal.AllocHGlobal(indexDataFacePhoto.Length);
                    bRet = pOcxObject.GetEnrollPhotoCS(m_nMachineNum, dwEnrollNumber, ref vPhotoSize, ptrIndexFacePhoto);
                    if (bRet)
                    {
                        byte[] mbytCurEnrollData = new byte[vPhotoSize];
                        Marshal.Copy(ptrIndexFacePhoto, mbytCurEnrollData, 0, vPhotoSize);
                        // System.IO.File.WriteAllBytes(@"c:\test.jpg", mbytCurEnrollData);
                        System.IO.File.WriteAllBytes(@"C:\\PHOTO\" + dwEnrollNumber.ToString() + ".jpg", mbytCurEnrollData);
                        labelInfo.Text = "GetEnrollData OK";
                    }
                }
                else 
               { 
                bRet = pOcxObject.GetEnrollData(
                    m_nMachineNum,
                    dwEnrollNumber,
                    dwEnMachineID,
                    dwBackupNum,
                    ref dwPrivilegeNum,
                    ref obj,
                    ref dwPassWord);
               }   
                if (!bRet)
                {
                    ShowErrorInfo();
                    DialogResult dr;
                    dr = MessageBox.Show("Continue?", "GetEnrollData", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        bRet = true;
                    }
                    else
                    {
                        EnableDevice();
                        labelInfo.Text = "fail on GetEnrollData";

                        return; 
                    }

                }

                if (dwBackupNum == 50)
               {
                     vPhotoSize = 0;
               }
                else 
                {
                
                }                                              
                

                string sql;

                OleDbParameter[] parameters = new OleDbParameter[5];
                parameters[0] = new OleDbParameter("@EMachineNumber", OleDbType.Integer);
                parameters[0].Value =dwEnMachineID;

                parameters[1] = new OleDbParameter("@EnrollNumber", OleDbType.Integer);
                parameters[1].Value = dwEnrollNumber;

                parameters[2] = new OleDbParameter("@FingerNumber", OleDbType.Integer);
                parameters[2].Value = dwBackupNum;

                parameters[3] = new OleDbParameter("@Privilige", OleDbType.Integer);
                parameters[3].Value = dwPrivilegeNum;

                if ( dwBackupNum == 10 ||
                     dwBackupNum == 11)
                {
                    parameters[4] = new OleDbParameter("@enPassword", OleDbType.Integer);
                    parameters[4].Value = dwPassWord;

                    sql = "insert into tblEnroll(EMachineNumber,EnrollNumber,FingerNumber,Privilige,enPassword)"+
                    "values(@EMachineNumber,@EnrollNumber,@FingerNumber,@Privilige,@enPassword)";  //values(?,?,?,?,?)

                }
                else if (dwBackupNum ==50)
                {
                   parameters[4] = new OleDbParameter("@enPassword", OleDbType.Integer);
                   parameters[4].Value = dwPassWord;
                    sql = "insert into tblEnroll(EMachineNumber,EnrollNumber,FingerNumber,Privilige,enPassword)" +
                    "values(@EMachineNumber,@EnrollNumber,@FingerNumber,@Privilige,@enPassword)";  //values(?,?,?,?,?)

                }
                else if (dwBackupNum >=20)
                {
                    dwData = (int[])obj;
                    byte[] _indexData = new byte[1420];
                    //分配内存
                    IntPtr _ptrIndex = Marshal.AllocHGlobal(_indexData.Length);
                    //int[]  转成 byte[]
                    Marshal.Copy(dwData, 0, _ptrIndex, 1420 / 4);  //be careful
                    Marshal.Copy(_ptrIndex, _indexData, 0, 1420);
                    Marshal.FreeHGlobal(_ptrIndex);

                    FacedwData = (int[])obj;
                    byte[] _indexDataFace = new byte[1888];
                    //分配内存
                    IntPtr _ptrIndexFace = Marshal.AllocHGlobal(_indexDataFace.Length);
                    //int[]  转成 byte[]
                    Marshal.Copy(FacedwData, 0, _ptrIndexFace, 1888 / 4);  //be careful
                    Marshal.Copy(_ptrIndexFace, _indexDataFace, 0, 1888);
                    Marshal.FreeHGlobal(_ptrIndexFace);
                    parameters[4] = new OleDbParameter("@FPData", OleDbType.Binary);
                    parameters[4].Value = _indexDataFace;   //accept byte[]

                    sql = "insert into tblEnroll(EMachineNumber,EnrollNumber,FingerNumber,Privilige,FPData)" +
                        "values(@EMachineNumber,@EnrollNumber,@FingerNumber,@Privilige,@FPData)";

                }
                else
                {
                    dwData = (int[])obj;
                    byte[] _indexData = new byte[1420];
                    //分配内存
                    IntPtr _ptrIndex = Marshal.AllocHGlobal(_indexData.Length);
                    //int[]  转成 byte[]
                    Marshal.Copy(dwData, 0, _ptrIndex, 1420 / 4);  //be careful
                    Marshal.Copy(_ptrIndex, _indexData, 0, 1420);
                    Marshal.FreeHGlobal(_ptrIndex);

                    FacedwData = (int[])obj;
                    byte[] _indexDataFace = new byte[1888];
                    //分配内存
                    IntPtr _ptrIndexFace = Marshal.AllocHGlobal(_indexDataFace.Length);
                    //int[]  转成 byte[]
                    Marshal.Copy(FacedwData, 0, _ptrIndexFace, 1888 / 4);  //be careful
                    Marshal.Copy(_ptrIndexFace, _indexDataFace, 0, 1888);
                    Marshal.FreeHGlobal(_ptrIndexFace);   
                    parameters[4] = new OleDbParameter("@FPData", OleDbType.Binary);
                    parameters[4].Value = _indexData;   //accept byte[]

                    sql = "insert into tblEnroll(EMachineNumber,EnrollNumber,FingerNumber,Privilige,FPData)"+
                        "values(@EMachineNumber,@EnrollNumber,@FingerNumber,@Privilige,@FPData)";

                }

                OleDbCommand cmd = new OleDbCommand(sql, conn);
                try
                {
                    //conn.Open();
                    if (parameters != null) cmd.Parameters.AddRange(parameters);
                    cmd.ExecuteNonQuery();
                    
                }
                catch (Exception ec)
                {
                    throw ec;
                }

                //reset
                dwPassWord = 0;

            } while (bRet);


            if (bBreakFail)
            {
                labelInfo.Text = "Saved all Enroll Data to database...";
            }

            conn.Close();

            EnableDevice();
        }

        private void btnSetAllEnData_Click(object sender, EventArgs e)
        {
            bool bRet;

            int dwEMachineNumber;
            int dwEnrollNumber;
            int dwFingerNumber;
            int dwPrivilege;
            int dwPassword;
            int[] dwFPData = new int[1420 / 4];
            int[] FacedwFPData = new int[1888 / 4];
            object obj = 0;

            OleDbConnection myAccessConn;
            string strConnection = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=.\EnrollData.mdb";
            myAccessConn = new OleDbConnection(strConnection);
            myAccessConn.Open();

            if (myAccessConn.State != ConnectionState.Open)
            {
                //MessageBox.Show("Access数据库的连接成功!", "Access数据库的连接");
                MessageBox.Show("Access数据库的连接失败!", "Access数据库的连接");
                return;
            }
            else
            {
            }

            string strAccessSelect = "SELECT * FROM tblEnroll";
            OleDbCommand myAccessCommand = new OleDbCommand(strAccessSelect, myAccessConn);
            OleDbDataAdapter myDataAdapter = new OleDbDataAdapter(myAccessCommand);
            DataSet myDataSet = new DataSet();

            myDataAdapter.Fill(myDataSet, "Categories");

            DataRowCollection dra = myDataSet.Tables["Categories"].Rows;

            if (dra.Count == 0)
            {
                labelInfo.Text = "btnUDiskDownLoad_Click, DataBase is empty.";

                myAccessConn.Close();
                return;
            }
            //DataRow dRow = dra[1];

            foreach (DataRow dr in dra)
            {
                dwEMachineNumber = Int32.Parse(dr["EMachineNumber"].ToString());
                dwEnrollNumber = Int32.Parse(dr["EnrollNumber"].ToString());
                dwFingerNumber = Int32.Parse(dr["FingerNumber"].ToString());
                dwPrivilege = Int32.Parse(dr["Privilige"].ToString());
                dwPassword = Int32.Parse(dr["enPassword"].ToString());

                if (dwFingerNumber < 10)
                {
                   obj = new System.Runtime.InteropServices.VariantWrapper(dr["FPData"]);
                }
                else if (dwFingerNumber ==50)
                {
                    obj = new System.Runtime.InteropServices.VariantWrapper(dwFPData);
                }
                else if (dwFingerNumber > 19)
                {
                    obj = new System.Runtime.InteropServices.VariantWrapper(dr["FPData"]);
                }
                else
                {
                    obj = new System.Runtime.InteropServices.VariantWrapper(dwFPData);
                }

                if (dwFingerNumber == 50)
                {
                 
                //int vPhotoSize = 0;
                 int[] indexDataFacePhoto = new int[400800];
                //分配内存
                IntPtr ptrIndexFacePhoto = Marshal.AllocHGlobal(indexDataFacePhoto.Length);
                //string path = @"c:\test.jpg";                     
                string path = @"C:\\PHOTO\" + dwEnrollNumber.ToString() + ".jpg";
                bRet = System.IO.File.Exists(path);
                if (bRet)  
               {
                   byte[] mbytCurEnrollData = System.IO.File.ReadAllBytes(path);
                   Marshal.Copy(mbytCurEnrollData, 0, ptrIndexFacePhoto, mbytCurEnrollData.Length);                
                   bRet = pOcxObject.SetEnrollPhotoCS(m_nMachineNum, dwEnrollNumber, mbytCurEnrollData.Length, ptrIndexFacePhoto);              
                }                  
               else
                 {
                     bRet=true;
                }

                }    
                else
               {
                bRet = pOcxObject.SetEnrollData(
                    m_nMachineNum,
                    dwEnrollNumber,
                    dwEMachineNumber,
                    dwFingerNumber,
                    dwPrivilege,
                    ref obj,
                    dwPassword);
               }    

                if (!bRet)
                {
                    ShowErrorInfo();
                    DialogResult dlgr;
                    dlgr = MessageBox.Show("Continue?", "SetEnrollData", MessageBoxButtons.YesNo);
                    if (dlgr == DialogResult.Yes)
                    {
                        bRet = true;
                    }
                    else
                    {
                        EnableDevice();
                        labelInfo.Text = "fail on SetEnrollData";

                        myAccessConn.Close();
                        return;
                    }
                }

                
               
            }

            myAccessConn.Close();

            labelInfo.Text = "SetEnrollData Success...";
            EnableDevice();

        }

        private void btnSendAllEnrollData_Click(object sender, EventArgs e)
        {
            //no implementation
        }

        private void btnDelDBData_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Continue?", "Delete All data in database? ", MessageBoxButtons.YesNo,  MessageBoxIcon.Asterisk);
            if (dr == DialogResult.No)
            {
                return;
            }

            OleDbConnection conn;
            string strConnection = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=.\EnrollData.mdb";
            conn = new OleDbConnection(strConnection);
            conn.Open();

            if (conn.State != ConnectionState.Open)
            {
                //MessageBox.Show("Access数据库的连接成功!", "Access数据库的连接");
                MessageBox.Show("Access数据库的连接失败!", "Access数据库的连接");
                return;
            }
            else
            {
            }

            OleDbParameter[] parameters = null/*new OleDbParameter[5]*/;

            string sql = "delete * from tblEnroll";
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            try
            {
                //conn.Open();
                if (parameters != null) cmd.Parameters.AddRange(parameters);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ec)
            {
                throw ec;
            }

        }

        private void btnSetEnrollData_Click(object sender, EventArgs e)
        {
            //listBox1.Items.Clear();

            DisableDevice();

            int dwBackupNum = Convert.ToInt32(cmbBackupNum.Text); 
            int dwEnMachineID = cmbEMachineNum.SelectedIndex + 1;
            int dwPrivilegeNum = cmbPrivilege.SelectedIndex;
            int dwEnrollNumber = Convert.ToInt32(tbEnrollNum.Text);

            //int[] dwData = new int[1420 / 4];
            //object obj = new System.Runtime.InteropServices.VariantWrapper(dwData);
            //
            int[] dwData = new int[1420 / 4];
            //object obj = new System.Runtime.InteropServices.VariantWrapper(dwData);
            int[] FacedwData = new int[1888 / 4];
            object obj = new System.Runtime.InteropServices.VariantWrapper(FacedwData);

            int dwPassword = 0;
            int dwPassword1 = 0;
            int dwCardNum = 0;
            long dwCardNum1 = 0;

            //int vPhotoSize = 0;
            int[] indexDataFacePhoto = new int[400800];
            //分配内存
            IntPtr ptrIndexFacePhoto = Marshal.AllocHGlobal(indexDataFacePhoto.Length);
            bool bRet;


            if ( tbPassword.TextLength > 0 )
            {
                dwPassword1 = Int32.Parse(tbPassword.Text);
            }

            if (tbCardNum.TextLength > 0)
            {               
                dwCardNum1 = Int64.Parse(tbCardNum.Text);
                if (dwCardNum1> 2147483647)          
                {
                    dwCardNum1 =dwCardNum1 - 4294967296;                  
                }
                dwCardNum = Convert.ToInt32(dwCardNum1);
            }

            if (dwBackupNum == 10)
            {
                if (dwPassword1 != 0)
                {
                    dwPassword = dwPassword1;
                }
            }

            if (dwBackupNum == 11)
            {
                if (dwCardNum != 0)
                {
                    dwPassword = dwCardNum;
                }
            }
            if (dwBackupNum <10)
            {
                obj = new System.Runtime.InteropServices.VariantWrapper(gbytEnrollData);
            }

            if (dwBackupNum >=20)
            {
                obj = new System.Runtime.InteropServices.VariantWrapper(gbytEnrollDataFace);
            }
           
            DisableDevice();
            if (dwBackupNum ==50)
                 {
                     string path = @"C:\\PHOTO\" + dwEnrollNumber.ToString() + ".jpg";      
                     bRet = System.IO.File.Exists(path);
                     if (bRet)  
                    {
                     byte[] mbytCurEnrollData = System.IO.File.ReadAllBytes(path);
                     Marshal.Copy(mbytCurEnrollData, 0, ptrIndexFacePhoto, mbytCurEnrollData.Length);                  
                     bRet = pOcxObject.SetEnrollPhotoCS(m_nMachineNum, dwEnrollNumber, mbytCurEnrollData.Length, ptrIndexFacePhoto);   
                     }
                     else
                     {
                         labelInfo.Text = "Picture does not exist";
                     }

                 }
            else
              {
                bRet = pOcxObject.SetEnrollData(m_nMachineNum,
                      dwEnrollNumber,
                      dwEnMachineID,
                      dwBackupNum,
                      dwPrivilegeNum,
                      ref obj,
                   dwPassword);
              }          
            
            if (bRet)
            {
                labelInfo.Text = "SetEnrollData OK";
            }
            else
            {
                //ShowErrorInfo();
                labelInfo.Text = "SetEnrollData failure";
            }


            EnableDevice();
        }

        private void btnGetEnrollData_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            DisableDevice();

            bool bRet;

            int dwBackupNum = Convert.ToInt32(cmbBackupNum.Text); 
            int dwEnMachineID = cmbEMachineNum.SelectedIndex + 1;
            //int dwPrivilegeNum = cmbPrivilege.SelectedIndex;
            int dwPrivilegeNum = 0;
            //need check
            int dwEnrollNumber = Convert.ToInt32(tbEnrollNum.Text);

            //int[] dwData = new int[1420 / 4];
            //object obj = new System.Runtime.InteropServices.VariantWrapper(dwData);

            int[] dwData = new int[1420 / 4];
            //object obj = new System.Runtime.InteropServices.VariantWrapper(dwData);
            int[] FacedwData = new int[1888 / 4];
            object obj = new System.Runtime.InteropServices.VariantWrapper(FacedwData);           
            int dwPassword = 0;
            int vPhotoSize = 0;
            int[] indexDataFacePhoto = new int[400800];
            int dwCardNum = 0;
            long dwCardNum1 = 0;
               
          if (dwBackupNum==50) 
            {
                //分配内存
                IntPtr ptrIndexFacePhoto = Marshal.AllocHGlobal(indexDataFacePhoto.Length);
                bRet = pOcxObject.GetEnrollPhotoCS(m_nMachineNum, dwEnrollNumber, ref vPhotoSize, ptrIndexFacePhoto);
               if (bRet)
            {
                byte[] mbytCurEnrollData = new byte[vPhotoSize];
                Marshal.Copy(ptrIndexFacePhoto, mbytCurEnrollData, 0, vPhotoSize);

                //DeleteFile(getPhotoFileName(dwEnrollNumber));
                //if (vPhotoSize > 0) writeFile(getPhotoFileName(dwEnrollNumber), mbytCurEnrollData, vPhotoSize);             
                System.IO.File.WriteAllBytes(@"C:\\PHOTO\" + dwEnrollNumber.ToString() + ".jpg", mbytCurEnrollData);
                labelInfo.Text = "The Photo File is " + @"C:\PHOTO\" + dwEnrollNumber.ToString() + ".jpg";
                MessageBox.Show("GetEnrollData OK", "");                
             }
            }

           else 
            {
            bRet = pOcxObject.GetEnrollData(
                m_nMachineNum,
                dwEnrollNumber,
                dwEnMachineID,
                dwBackupNum,
                ref dwPrivilegeNum,
                ref obj,
                ref dwPassword
                );

            if (bRet)
            {
                label11.Text = "GetEnrollData OK";
                if (dwBackupNum == 10)
                {
                    tbPassword.Text = dwPassword.ToString();
                } 
                else if (dwBackupNum == 11)
                {
                    
                    dwCardNum = dwPassword;
                    tbCardNum.Text = dwCardNum.ToString();
                    if (dwCardNum < 0)
                    {
                        dwCardNum1 = dwCardNum + 4294967296;
                        tbCardNum.Text = dwCardNum1.ToString();
                    }

                }
                else if (dwBackupNum >= 20)
                {
                    int[] intArrar = (int[])obj;

                    int arrayLength = 1888 / 4;
                    if (arrayLength > intArrar.Length)
                    {
                        arrayLength = intArrar.Length;
                    }

                    //for (int i = 0; i < intArrar.Length; i++ )
                    for (int i = 0; i < arrayLength; i++)
                    {
                        listBox1.Items.Add(intArrar[i].ToString("X8"));
                    }

                    FacedwData = (int[])obj;
                    byte[] _indexDataFace = new byte[1888];
                    //分配内存
                    IntPtr _ptrIndexFace = Marshal.AllocHGlobal(_indexDataFace.Length);
                    //int[]  转成 byte[]
                    Marshal.Copy(FacedwData, 0, _ptrIndexFace, 1888 / 4);  //be careful
                    Marshal.Copy(_ptrIndexFace, _indexDataFace, 0, 1888);
                    Marshal.FreeHGlobal(_ptrIndexFace);
                    gbytEnrollDataFace = _indexDataFace;   //accept byte[]
                }
                else
                {
                    int[] intArrar = (int[])obj;

                    int arrayLength = 1420 / 4;
                    if (arrayLength > intArrar.Length)
                    {
                        arrayLength = intArrar.Length;
                    }

                    //for (int i = 0; i < intArrar.Length; i++ )
                    for (int i = 0; i < arrayLength; i++)
                    {
                        listBox1.Items.Add(intArrar[i].ToString("X8"));
                    }

                    dwData = (int[])obj;
                    byte[] _indexData = new byte[1420];
                    //分配内存
                    IntPtr _ptrIndex = Marshal.AllocHGlobal(_indexData.Length);
                    //int[]  转成 byte[]
                    Marshal.Copy(dwData, 0, _ptrIndex, 1420 / 4);  //be careful
                    Marshal.Copy(_ptrIndex, _indexData, 0, 1420);
                    Marshal.FreeHGlobal(_ptrIndex);
                    gbytEnrollData = _indexData;   //accept byte[]                  
                    
                }

            } 
            else
            {
                ShowErrorInfo();
            }
         }
            EnableDevice();
        }

        private void EnrollDataManagement_Load(object sender, EventArgs e)
        {

        }
        private bool DeleteFile(string filename)
        {
            try
            {
                System.IO.File.Delete(filename);
                return true;
            }
            catch (System.IO.IOException)
            {
                return false;
            }
        }
        private string getPhotoFileName(int UserID)
        {
            if (UserID > 0)
            {
                return mstrPhotoDir + "\\" + UserID.ToString() + ".jpg";
            }
            return "";
        }
        private void writeFile(String filename, byte[] buffer, int length)
        {
            using (System.IO.FileStream fsWrite = new System.IO.FileStream(filename, System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.Write))
            {
                fsWrite.Write(buffer, 0, length);
            }

        }
        private byte[] readFile(String filename)
        {
            byte[] bytes = new byte[0];
            try
            {
                using (System.IO.FileStream fsRead = new System.IO.FileStream(filename, System.IO.FileMode.Open, System.IO.FileAccess.Read))
                {
                    bytes = new byte[fsRead.Length];
                    fsRead.Read(bytes, 0, bytes.Length);
                    return bytes;
                }
            }
            catch (Exception)
            {
                return bytes;
            }
        }
        private void SetPhotoDir()
        {
                 
            if (false == System.IO.Directory.Exists(mstrPhotoDir))
            {
                 System.IO.Directory.CreateDirectory(mstrPhotoDir);
            }
            else
            {
                  mstrPhotoDir = "C:\\";
            }      
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {

            DisableDevice();
            int dwEnMachineID = cmbEMachineNum.SelectedIndex + 1;

            int dwBackupNum = Convert.ToInt32(cmbBackupNum.Text);
            int dwPrivilegeNum = cmbPrivilege.SelectedIndex;

            string strEnrollID;
            if (tbEnrollNum.TextLength == 0)
            {
                strEnrollID = "";
            }
            else
            {
                strEnrollID = tbEnrollNum.Text;

            }
            object EnrollIDobj = new System.Runtime.InteropServices.VariantWrapper(strEnrollID);



            string strName;
            if (tbEnrollName.TextLength == 0)
            {
                strName = "";
            }
            else
            {
                strName = tbEnrollName.Text;

            }
            object Usernameobj = new System.Runtime.InteropServices.VariantWrapper(strName);

            bool bRet = pOcxObject.AddUser(m_nMachineNum,
                                            ref EnrollIDobj,
                                            dwBackupNum,
                                            dwPrivilegeNum,
                                            ref Usernameobj
                                            );
            if (bRet)
            {
                labelInfo.Text = "AddUser Success...";

            }
            else
            {
                ShowErrorInfo();
            }

            EnableDevice();
        }
    }
}
