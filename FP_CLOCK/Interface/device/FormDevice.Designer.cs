namespace FPClient
{
    partial class MainForm
    {
        /// <summary>
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOpenDev = new System.Windows.Forms.Button();
            this.cmbInterface = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ipAddressControl1 = new IPAddressControlLib.IPAddressControl();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.P2STimeOut = new System.Windows.Forms.TextBox();
            this.P2SPort = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.textPort = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbComPort = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEnrollMangement = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnHolidaySetting = new System.Windows.Forms.Button();
            this.btnDeviceInfo = new System.Windows.Forms.Button();
            this.btnSetPassTime = new System.Windows.Forms.Button();
            this.btnBellSetting = new System.Windows.Forms.Button();
            this.btnLockCtrl = new System.Windows.Forms.Button();
            this.btnSysInfo = new System.Windows.Forms.Button();
            this.btnLogManagement = new System.Windows.Forms.Button();
            this.cmbMachineNumber = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOpenDev
            // 
            this.btnOpenDev.Location = new System.Drawing.Point(272, 412);
            this.btnOpenDev.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpenDev.Name = "btnOpenDev";
            this.btnOpenDev.Size = new System.Drawing.Size(62, 23);
            this.btnOpenDev.TabIndex = 0;
            this.btnOpenDev.Text = "Open";
            this.btnOpenDev.UseVisualStyleBackColor = true;
            this.btnOpenDev.Click += new System.EventHandler(this.btnOpenDevice_Click);
            // 
            // cmbInterface
            // 
            this.cmbInterface.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInterface.FormattingEnabled = true;
            this.cmbInterface.Items.AddRange(new object[] {
            "COM",
            "NET",
            "P2S",
            "USB"});
            this.cmbInterface.Location = new System.Drawing.Point(160, 33);
            this.cmbInterface.Margin = new System.Windows.Forms.Padding(2);
            this.cmbInterface.Name = "cmbInterface";
            this.cmbInterface.Size = new System.Drawing.Size(102, 21);
            this.cmbInterface.TabIndex = 1;
            this.cmbInterface.SelectedIndexChanged += new System.EventHandler(this.cmbInterface_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Set Interface";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ipAddressControl1);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.P2STimeOut);
            this.groupBox1.Controls.Add(this.P2SPort);
            this.groupBox1.Controls.Add(this.textPassword);
            this.groupBox1.Controls.Add(this.textPort);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbComPort);
            this.groupBox1.Controls.Add(this.cmbInterface);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(26, 28);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(322, 345);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuration";
            // 
            // ipAddressControl1
            // 
            this.ipAddressControl1.AllowInternalTab = false;
            this.ipAddressControl1.AutoHeight = true;
            this.ipAddressControl1.BackColor = System.Drawing.SystemColors.Window;
            this.ipAddressControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ipAddressControl1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ipAddressControl1.Location = new System.Drawing.Point(161, 125);
            this.ipAddressControl1.MinimumSize = new System.Drawing.Size(87, 20);
            this.ipAddressControl1.Name = "ipAddressControl1";
            this.ipAddressControl1.ReadOnly = false;
            this.ipAddressControl1.Size = new System.Drawing.Size(100, 20);
            this.ipAddressControl1.TabIndex = 11;
            this.ipAddressControl1.Text = "...";
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(6, 234);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = " P2S Cfg";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(5, 111);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "NET Cfg";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(5, 54);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "COM Cfg";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(88, 307);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "TimeOut";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(70, 262);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "ServerPort";
            // 
            // P2STimeOut
            // 
            this.P2STimeOut.Location = new System.Drawing.Point(158, 298);
            this.P2STimeOut.Margin = new System.Windows.Forms.Padding(2);
            this.P2STimeOut.Name = "P2STimeOut";
            this.P2STimeOut.Size = new System.Drawing.Size(103, 20);
            this.P2STimeOut.TabIndex = 9;
            // 
            // P2SPort
            // 
            this.P2SPort.Location = new System.Drawing.Point(158, 254);
            this.P2SPort.Margin = new System.Windows.Forms.Padding(2);
            this.P2SPort.Name = "P2SPort";
            this.P2SPort.Size = new System.Drawing.Size(103, 20);
            this.P2SPort.TabIndex = 9;
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(159, 194);
            this.textPassword.Margin = new System.Windows.Forms.Padding(2);
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '@';
            this.textPassword.Size = new System.Drawing.Size(103, 20);
            this.textPassword.TabIndex = 9;
            // 
            // textPort
            // 
            this.textPort.Location = new System.Drawing.Point(159, 161);
            this.textPort.Margin = new System.Windows.Forms.Padding(2);
            this.textPort.Name = "textPort";
            this.textPort.Size = new System.Drawing.Size(103, 20);
            this.textPort.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(95, 132);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "IPAddr";
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(0, 239);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(322, 2);
            this.label7.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(1, 117);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(322, 2);
            this.label6.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(-1, 55);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(322, 2);
            this.label5.TabIndex = 5;
            // 
            // cmbComPort
            // 
            this.cmbComPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbComPort.FormattingEnabled = true;
            this.cmbComPort.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cmbComPort.Location = new System.Drawing.Point(160, 83);
            this.cmbComPort.Margin = new System.Windows.Forms.Padding(2);
            this.cmbComPort.Name = "cmbComPort";
            this.cmbComPort.Size = new System.Drawing.Size(102, 21);
            this.cmbComPort.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 194);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 167);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "COM Port";
            // 
            // btnEnrollMangement
            // 
            this.btnEnrollMangement.Location = new System.Drawing.Point(33, 39);
            this.btnEnrollMangement.Margin = new System.Windows.Forms.Padding(2);
            this.btnEnrollMangement.Name = "btnEnrollMangement";
            this.btnEnrollMangement.Size = new System.Drawing.Size(166, 38);
            this.btnEnrollMangement.TabIndex = 3;
            this.btnEnrollMangement.Text = "Enroll Data Management";
            this.btnEnrollMangement.UseVisualStyleBackColor = true;
            this.btnEnrollMangement.Click += new System.EventHandler(this.btnEnrollManagement_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnHolidaySetting);
            this.groupBox2.Controls.Add(this.btnDeviceInfo);
            this.groupBox2.Controls.Add(this.btnSetPassTime);
            this.groupBox2.Controls.Add(this.btnBellSetting);
            this.groupBox2.Controls.Add(this.btnLockCtrl);
            this.groupBox2.Controls.Add(this.btnSysInfo);
            this.groupBox2.Controls.Add(this.btnLogManagement);
            this.groupBox2.Controls.Add(this.btnEnrollMangement);
            this.groupBox2.Location = new System.Drawing.Point(419, 28);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(221, 380);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Function Set";
            // 
            // btnHolidaySetting
            // 
            this.btnHolidaySetting.Location = new System.Drawing.Point(33, 341);
            this.btnHolidaySetting.Margin = new System.Windows.Forms.Padding(2);
            this.btnHolidaySetting.Name = "btnHolidaySetting";
            this.btnHolidaySetting.Size = new System.Drawing.Size(166, 38);
            this.btnHolidaySetting.TabIndex = 4;
            this.btnHolidaySetting.Text = "Holiday Setting";
            this.btnHolidaySetting.UseVisualStyleBackColor = true;
            this.btnHolidaySetting.Click += new System.EventHandler(this.btnHolidaySetting_Click);
            // 
            // btnDeviceInfo
            // 
            this.btnDeviceInfo.Location = new System.Drawing.Point(33, 299);
            this.btnDeviceInfo.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeviceInfo.Name = "btnDeviceInfo";
            this.btnDeviceInfo.Size = new System.Drawing.Size(166, 38);
            this.btnDeviceInfo.TabIndex = 3;
            this.btnDeviceInfo.Text = "Device Serial Number";
            this.btnDeviceInfo.UseVisualStyleBackColor = true;
            this.btnDeviceInfo.Click += new System.EventHandler(this.btnDeviceInfo_Click);
            // 
            // btnSetPassTime
            // 
            this.btnSetPassTime.Location = new System.Drawing.Point(33, 256);
            this.btnSetPassTime.Margin = new System.Windows.Forms.Padding(2);
            this.btnSetPassTime.Name = "btnSetPassTime";
            this.btnSetPassTime.Size = new System.Drawing.Size(166, 38);
            this.btnSetPassTime.TabIndex = 3;
            this.btnSetPassTime.Text = "Setting Pass Time";
            this.btnSetPassTime.UseVisualStyleBackColor = true;
            this.btnSetPassTime.Click += new System.EventHandler(this.btnSetPassTime_Click);
            // 
            // btnBellSetting
            // 
            this.btnBellSetting.Location = new System.Drawing.Point(33, 212);
            this.btnBellSetting.Margin = new System.Windows.Forms.Padding(2);
            this.btnBellSetting.Name = "btnBellSetting";
            this.btnBellSetting.Size = new System.Drawing.Size(166, 38);
            this.btnBellSetting.TabIndex = 3;
            this.btnBellSetting.Text = "Bell Time Setting";
            this.btnBellSetting.UseVisualStyleBackColor = true;
            this.btnBellSetting.Click += new System.EventHandler(this.btnBellSetting_Click);
            // 
            // btnLockCtrl
            // 
            this.btnLockCtrl.Location = new System.Drawing.Point(33, 169);
            this.btnLockCtrl.Margin = new System.Windows.Forms.Padding(2);
            this.btnLockCtrl.Name = "btnLockCtrl";
            this.btnLockCtrl.Size = new System.Drawing.Size(166, 38);
            this.btnLockCtrl.TabIndex = 3;
            this.btnLockCtrl.Text = "Lock Control";
            this.btnLockCtrl.UseVisualStyleBackColor = true;
            this.btnLockCtrl.Click += new System.EventHandler(this.btnLockCtrl_Click);
            // 
            // btnSysInfo
            // 
            this.btnSysInfo.Location = new System.Drawing.Point(33, 126);
            this.btnSysInfo.Margin = new System.Windows.Forms.Padding(2);
            this.btnSysInfo.Name = "btnSysInfo";
            this.btnSysInfo.Size = new System.Drawing.Size(166, 38);
            this.btnSysInfo.TabIndex = 3;
            this.btnSysInfo.Text = "System Info";
            this.btnSysInfo.UseVisualStyleBackColor = true;
            this.btnSysInfo.Click += new System.EventHandler(this.btnSysInfo_Click);
            // 
            // btnLogManagement
            // 
            this.btnLogManagement.Location = new System.Drawing.Point(33, 82);
            this.btnLogManagement.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogManagement.Name = "btnLogManagement";
            this.btnLogManagement.Size = new System.Drawing.Size(166, 38);
            this.btnLogManagement.TabIndex = 3;
            this.btnLogManagement.Text = "Log Data Management";
            this.btnLogManagement.UseVisualStyleBackColor = true;
            this.btnLogManagement.Click += new System.EventHandler(this.btnLogManagement_Click);
            // 
            // cmbMachineNumber
            // 
            this.cmbMachineNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMachineNumber.FormattingEnabled = true;
            this.cmbMachineNumber.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cmbMachineNumber.Location = new System.Drawing.Point(187, 414);
            this.cmbMachineNumber.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMachineNumber.Name = "cmbMachineNumber";
            this.cmbMachineNumber.Size = new System.Drawing.Size(54, 21);
            this.cmbMachineNumber.TabIndex = 6;
            this.cmbMachineNumber.SelectedIndexChanged += new System.EventHandler(this.cmbMachineNumber_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(73, 417);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 13);
            this.label14.TabIndex = 10;
            this.label14.Text = "Machine Number";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 470);
            this.Controls.Add(this.cmbMachineNumber);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOpenDev);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FP_Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenDev;
        private System.Windows.Forms.ComboBox cmbInterface;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbComPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEnrollMangement;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.TextBox textPort;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox P2STimeOut;
        private System.Windows.Forms.TextBox P2SPort;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbMachineNumber;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnSetPassTime;
        private System.Windows.Forms.Button btnBellSetting;
        private System.Windows.Forms.Button btnLockCtrl;
        private System.Windows.Forms.Button btnSysInfo;
        private System.Windows.Forms.Button btnLogManagement;
        private System.Windows.Forms.Button btnDeviceInfo;
        private IPAddressControlLib.IPAddressControl ipAddressControl1;
        private System.Windows.Forms.Button btnHolidaySetting;
        
    }
}

