namespace FPClient.Interface
{
    partial class FormDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDashboard));
            this.label_user_name = new System.Windows.Forms.Label();
            this.listViewUsers = new System.Windows.Forms.ListView();
            this.linkLabel_userList = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_deviceOpen = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_machineNumber = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_port = new System.Windows.Forms.TextBox();
            this.ipAddressControl1 = new IPAddressControlLib.IPAddressControl();
            this.pictureBox_plus = new System.Windows.Forms.PictureBox();
            this.labelImage1 = new System.Windows.Forms.Label();
            this.pictureBox_faceImage = new System.Windows.Forms.PictureBox();
            this.pictureBox_minus = new System.Windows.Forms.PictureBox();
            this.pictureBox_printQR = new System.Windows.Forms.PictureBox();
            this.label_paidState = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label_datetime = new System.Windows.Forms.Label();
            this.button_pass = new System.Windows.Forms.Button();
            this.button_nopass = new System.Windows.Forms.Button();
            this.label_memberCount = new System.Windows.Forms.Label();
            this.label_price = new System.Windows.Forms.Label();
            this.label_booking = new System.Windows.Forms.Label();
            this.label_email = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.listView_devices = new System.Windows.Forms.ListView();
            this.textPort = new System.Windows.Forms.TextBox();
            this.label_host = new System.Windows.Forms.Label();
            this.clearList = new System.Windows.Forms.Button();
            this.Disconnect = new System.Windows.Forms.Button();
            this.connect = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_getEnroll = new System.Windows.Forms.Button();
            this.axFPCLOCK_Svr2 = new AxFPCLOCK_SVRLib.AxFPCLOCK_Svr();
            this.pictureBox_deviceSetting = new System.Windows.Forms.PictureBox();
            this.axFPCLOCK_Svr1 = new AxFPCLOCK_SVRLib.AxFPCLOCK_Svr();
            this.axFP_CLOCK = new AxFP_CLOCKLib.AxFP_CLOCK();
            this.pictureBox_loading1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_alarm = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_plus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_faceImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_minus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_printQR)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axFPCLOCK_Svr2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_deviceSetting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axFPCLOCK_Svr1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axFP_CLOCK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_loading1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_user_name
            // 
            this.label_user_name.AutoSize = true;
            this.label_user_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_user_name.Location = new System.Drawing.Point(1129, 21);
            this.label_user_name.Name = "label_user_name";
            this.label_user_name.Size = new System.Drawing.Size(42, 24);
            this.label_user_name.TabIndex = 1;
            this.label_user_name.Text = "role";
            this.label_user_name.Click += new System.EventHandler(this.label_user_name_Click);
            // 
            // listViewUsers
            // 
            this.listViewUsers.FullRowSelect = true;
            this.listViewUsers.GridLines = true;
            this.listViewUsers.Location = new System.Drawing.Point(25, 95);
            this.listViewUsers.Margin = new System.Windows.Forms.Padding(2);
            this.listViewUsers.MinimumSize = new System.Drawing.Size(600, 600);
            this.listViewUsers.MultiSelect = false;
            this.listViewUsers.Name = "listViewUsers";
            this.listViewUsers.ShowItemToolTips = true;
            this.listViewUsers.Size = new System.Drawing.Size(600, 640);
            this.listViewUsers.TabIndex = 2;
            this.listViewUsers.UseCompatibleStateImageBehavior = false;
            this.listViewUsers.View = System.Windows.Forms.View.Details;
            this.listViewUsers.SelectedIndexChanged += new System.EventHandler(this.listViewUsers_SelectedIndexChanged);
            // 
            // linkLabel_userList
            // 
            this.linkLabel_userList.AutoSize = true;
            this.linkLabel_userList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel_userList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_userList.Location = new System.Drawing.Point(21, 66);
            this.linkLabel_userList.Name = "linkLabel_userList";
            this.linkLabel_userList.Size = new System.Drawing.Size(81, 24);
            this.linkLabel_userList.TabIndex = 3;
            this.linkLabel_userList.TabStop = true;
            this.linkLabel_userList.Text = "User List";
            this.linkLabel_userList.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_userList_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_deviceOpen);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_machineNumber);
            this.groupBox1.Controls.Add(this.textPassword);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBox_port);
            this.groupBox1.Controls.Add(this.ipAddressControl1);
            this.groupBox1.Controls.Add(this.pictureBox_plus);
            this.groupBox1.Controls.Add(this.labelImage1);
            this.groupBox1.Controls.Add(this.pictureBox_faceImage);
            this.groupBox1.Controls.Add(this.pictureBox_minus);
            this.groupBox1.Controls.Add(this.pictureBox_printQR);
            this.groupBox1.Controls.Add(this.label_paidState);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label_datetime);
            this.groupBox1.Controls.Add(this.button_pass);
            this.groupBox1.Controls.Add(this.button_nopass);
            this.groupBox1.Controls.Add(this.label_memberCount);
            this.groupBox1.Controls.Add(this.label_price);
            this.groupBox1.Controls.Add(this.label_booking);
            this.groupBox1.Controls.Add(this.label_email);
            this.groupBox1.Controls.Add(this.label_name);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(689, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(650, 285);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selected User";
            // 
            // button_deviceOpen
            // 
            this.button_deviceOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_deviceOpen.Enabled = false;
            this.button_deviceOpen.ForeColor = System.Drawing.Color.Black;
            this.button_deviceOpen.Location = new System.Drawing.Point(509, 153);
            this.button_deviceOpen.Name = "button_deviceOpen";
            this.button_deviceOpen.Size = new System.Drawing.Size(114, 24);
            this.button_deviceOpen.TabIndex = 24;
            this.button_deviceOpen.Text = "OPEN";
            this.button_deviceOpen.UseVisualStyleBackColor = false;
            this.button_deviceOpen.Click += new System.EventHandler(this.button_deviceOpen_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(465, 124);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 18);
            this.label2.TabIndex = 22;
            this.label2.Text = "Num";
            // 
            // textBox_machineNumber
            // 
            this.textBox_machineNumber.Location = new System.Drawing.Point(509, 121);
            this.textBox_machineNumber.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_machineNumber.Name = "textBox_machineNumber";
            this.textBox_machineNumber.Size = new System.Drawing.Size(114, 24);
            this.textBox_machineNumber.TabIndex = 23;
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(339, 180);
            this.textPassword.Margin = new System.Windows.Forms.Padding(2);
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '@';
            this.textPassword.Size = new System.Drawing.Size(114, 24);
            this.textPassword.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(258, 181);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 18);
            this.label4.TabIndex = 19;
            this.label4.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(297, 154);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 18);
            this.label1.TabIndex = 20;
            this.label1.Text = "Port";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(282, 124);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 18);
            this.label8.TabIndex = 19;
            this.label8.Text = "IPAddr";
            // 
            // textBox_port
            // 
            this.textBox_port.Location = new System.Drawing.Point(339, 150);
            this.textBox_port.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_port.Name = "textBox_port";
            this.textBox_port.Size = new System.Drawing.Size(114, 24);
            this.textBox_port.TabIndex = 21;
            // 
            // ipAddressControl1
            // 
            this.ipAddressControl1.AllowInternalTab = false;
            this.ipAddressControl1.AutoHeight = true;
            this.ipAddressControl1.BackColor = System.Drawing.SystemColors.Window;
            this.ipAddressControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ipAddressControl1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ipAddressControl1.Location = new System.Drawing.Point(339, 121);
            this.ipAddressControl1.MinimumSize = new System.Drawing.Size(114, 24);
            this.ipAddressControl1.Name = "ipAddressControl1";
            this.ipAddressControl1.ReadOnly = false;
            this.ipAddressControl1.Size = new System.Drawing.Size(114, 24);
            this.ipAddressControl1.TabIndex = 19;
            this.ipAddressControl1.Text = "...";
            // 
            // pictureBox_plus
            // 
            this.pictureBox_plus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_plus.Image = global::FPClient.Properties.Resources._2795;
            this.pictureBox_plus.InitialImage = global::FPClient.Properties.Resources.@__Iphone_spinner_1;
            this.pictureBox_plus.Location = new System.Drawing.Point(370, 240);
            this.pictureBox_plus.Name = "pictureBox_plus";
            this.pictureBox_plus.Size = new System.Drawing.Size(27, 25);
            this.pictureBox_plus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_plus.TabIndex = 21;
            this.pictureBox_plus.TabStop = false;
            this.pictureBox_plus.Click += new System.EventHandler(this.pictureBox_plus_Click);
            // 
            // labelImage1
            // 
            this.labelImage1.AutoSize = true;
            this.labelImage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImage1.Location = new System.Drawing.Point(77, 231);
            this.labelImage1.Name = "labelImage1";
            this.labelImage1.Size = new System.Drawing.Size(112, 16);
            this.labelImage1.TabIndex = 12;
            this.labelImage1.Text = "Face with ID Card";
            // 
            // pictureBox_faceImage
            // 
            this.pictureBox_faceImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_faceImage.Location = new System.Drawing.Point(82, 121);
            this.pictureBox_faceImage.Name = "pictureBox_faceImage";
            this.pictureBox_faceImage.Size = new System.Drawing.Size(100, 100);
            this.pictureBox_faceImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_faceImage.TabIndex = 11;
            this.pictureBox_faceImage.TabStop = false;
            this.pictureBox_faceImage.Click += new System.EventHandler(this.pictureBox_faceImage_Click);
            // 
            // pictureBox_minus
            // 
            this.pictureBox_minus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_minus.Image = global::FPClient.Properties.Resources._2796;
            this.pictureBox_minus.InitialImage = global::FPClient.Properties.Resources.@__Iphone_spinner_1;
            this.pictureBox_minus.Location = new System.Drawing.Point(305, 240);
            this.pictureBox_minus.Name = "pictureBox_minus";
            this.pictureBox_minus.Size = new System.Drawing.Size(27, 25);
            this.pictureBox_minus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_minus.TabIndex = 20;
            this.pictureBox_minus.TabStop = false;
            this.pictureBox_minus.Click += new System.EventHandler(this.pictureBox_minus_Click);
            // 
            // pictureBox_printQR
            // 
            this.pictureBox_printQR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_printQR.Image = global::FPClient.Properties.Resources.icons8_order_history_480px_1;
            this.pictureBox_printQR.InitialImage = global::FPClient.Properties.Resources.@__Iphone_spinner_1;
            this.pictureBox_printQR.Location = new System.Drawing.Point(596, 59);
            this.pictureBox_printQR.Name = "pictureBox_printQR";
            this.pictureBox_printQR.Size = new System.Drawing.Size(27, 25);
            this.pictureBox_printQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_printQR.TabIndex = 10;
            this.pictureBox_printQR.TabStop = false;
            this.pictureBox_printQR.Click += new System.EventHandler(this.pictureBox_printQR_Click);
            // 
            // label_paidState
            // 
            this.label_paidState.AutoSize = true;
            this.label_paidState.BackColor = System.Drawing.Color.White;
            this.label_paidState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_paidState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label_paidState.Location = new System.Drawing.Point(521, 64);
            this.label_paidState.Name = "label_paidState";
            this.label_paidState.Size = new System.Drawing.Size(36, 16);
            this.label_paidState.TabIndex = 6;
            this.label_paidState.Text = "Paid";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(332, 243);
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox1.Size = new System.Drawing.Size(36, 17);
            this.textBox1.TabIndex = 19;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label_datetime
            // 
            this.label_datetime.AutoSize = true;
            this.label_datetime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_datetime.Location = new System.Drawing.Point(385, 64);
            this.label_datetime.Name = "label_datetime";
            this.label_datetime.Size = new System.Drawing.Size(106, 16);
            this.label_datetime.TabIndex = 5;
            this.label_datetime.Text = "10/05/2023 17:00";
            // 
            // button_pass
            // 
            this.button_pass.Location = new System.Drawing.Point(410, 236);
            this.button_pass.Name = "button_pass";
            this.button_pass.Size = new System.Drawing.Size(95, 33);
            this.button_pass.TabIndex = 15;
            this.button_pass.Text = "Pass";
            this.button_pass.UseVisualStyleBackColor = true;
            this.button_pass.Click += new System.EventHandler(this.button_connect_Click);
            // 
            // button_nopass
            // 
            this.button_nopass.Location = new System.Drawing.Point(519, 236);
            this.button_nopass.Name = "button_nopass";
            this.button_nopass.Size = new System.Drawing.Size(95, 33);
            this.button_nopass.TabIndex = 16;
            this.button_nopass.Text = "No pass";
            this.button_nopass.UseVisualStyleBackColor = true;
            this.button_nopass.Click += new System.EventHandler(this.button_nopass_Click);
            // 
            // label_memberCount
            // 
            this.label_memberCount.AutoSize = true;
            this.label_memberCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_memberCount.Location = new System.Drawing.Point(272, 64);
            this.label_memberCount.Name = "label_memberCount";
            this.label_memberCount.Size = new System.Drawing.Size(71, 16);
            this.label_memberCount.TabIndex = 4;
            this.label_memberCount.Text = "Member: 3";
            // 
            // label_price
            // 
            this.label_price.AutoSize = true;
            this.label_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_price.Location = new System.Drawing.Point(150, 65);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(107, 16);
            this.label_price.TabIndex = 3;
            this.label_price.Text = "Total Price: 120$";
            // 
            // label_booking
            // 
            this.label_booking.AutoSize = true;
            this.label_booking.Location = new System.Drawing.Point(39, 64);
            this.label_booking.Name = "label_booking";
            this.label_booking.Size = new System.Drawing.Size(105, 18);
            this.label_booking.TabIndex = 2;
            this.label_booking.Text = "Booking State:";
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Location = new System.Drawing.Point(298, 31);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(45, 18);
            this.label_email.TabIndex = 1;
            this.label_email.Text = "Email";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(39, 31);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(48, 18);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "Name";
            // 
            // listView_devices
            // 
            this.listView_devices.FullRowSelect = true;
            this.listView_devices.GridLines = true;
            this.listView_devices.Location = new System.Drawing.Point(18, 62);
            this.listView_devices.Margin = new System.Windows.Forms.Padding(2);
            this.listView_devices.MultiSelect = false;
            this.listView_devices.Name = "listView_devices";
            this.listView_devices.ShowItemToolTips = true;
            this.listView_devices.Size = new System.Drawing.Size(614, 278);
            this.listView_devices.TabIndex = 10;
            this.listView_devices.UseCompatibleStateImageBehavior = false;
            this.listView_devices.View = System.Windows.Forms.View.Details;
            this.listView_devices.SelectedIndexChanged += new System.EventHandler(this.listView_devices_SelectedIndexChanged);
            this.listView_devices.DoubleClick += new System.EventHandler(this.listView_devices_DoubleClicked);
            // 
            // textPort
            // 
            this.textPort.Location = new System.Drawing.Point(81, 28);
            this.textPort.Margin = new System.Windows.Forms.Padding(2);
            this.textPort.Name = "textPort";
            this.textPort.Size = new System.Drawing.Size(63, 24);
            this.textPort.TabIndex = 15;
            // 
            // label_host
            // 
            this.label_host.AutoSize = true;
            this.label_host.Location = new System.Drawing.Point(11, 31);
            this.label_host.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_host.Name = "label_host";
            this.label_host.Size = new System.Drawing.Size(68, 18);
            this.label_host.TabIndex = 14;
            this.label_host.Text = "HostPort";
            this.label_host.Click += new System.EventHandler(this.label1_Click);
            // 
            // clearList
            // 
            this.clearList.ForeColor = System.Drawing.Color.SaddleBrown;
            this.clearList.Location = new System.Drawing.Point(370, 22);
            this.clearList.Margin = new System.Windows.Forms.Padding(2);
            this.clearList.Name = "clearList";
            this.clearList.Size = new System.Drawing.Size(91, 36);
            this.clearList.TabIndex = 11;
            this.clearList.Text = "ClearList";
            this.clearList.UseVisualStyleBackColor = true;
            this.clearList.Click += new System.EventHandler(this.clearList_Click);
            // 
            // Disconnect
            // 
            this.Disconnect.Location = new System.Drawing.Point(273, 22);
            this.Disconnect.Margin = new System.Windows.Forms.Padding(2);
            this.Disconnect.Name = "Disconnect";
            this.Disconnect.Size = new System.Drawing.Size(91, 36);
            this.Disconnect.TabIndex = 12;
            this.Disconnect.Text = "Disconnect";
            this.Disconnect.UseVisualStyleBackColor = true;
            this.Disconnect.Click += new System.EventHandler(this.Disconnect_Click);
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(175, 22);
            this.connect.Margin = new System.Windows.Forms.Padding(2);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(91, 36);
            this.connect.TabIndex = 13;
            this.connect.Text = "Connect";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_getEnroll);
            this.groupBox2.Controls.Add(this.axFPCLOCK_Svr2);
            this.groupBox2.Controls.Add(this.pictureBox_deviceSetting);
            this.groupBox2.Controls.Add(this.listView_devices);
            this.groupBox2.Controls.Add(this.axFPCLOCK_Svr1);
            this.groupBox2.Controls.Add(this.label_host);
            this.groupBox2.Controls.Add(this.Disconnect);
            this.groupBox2.Controls.Add(this.connect);
            this.groupBox2.Controls.Add(this.clearList);
            this.groupBox2.Controls.Add(this.textPort);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(689, 377);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(650, 358);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Device";
            // 
            // button_getEnroll
            // 
            this.button_getEnroll.Enabled = false;
            this.button_getEnroll.Location = new System.Drawing.Point(498, 21);
            this.button_getEnroll.Margin = new System.Windows.Forms.Padding(2);
            this.button_getEnroll.Name = "button_getEnroll";
            this.button_getEnroll.Size = new System.Drawing.Size(91, 36);
            this.button_getEnroll.TabIndex = 20;
            this.button_getEnroll.Text = "Get Data";
            this.button_getEnroll.UseVisualStyleBackColor = true;
            this.button_getEnroll.Click += new System.EventHandler(this.button_getEnroll_Click);
            // 
            // axFPCLOCK_Svr2
            // 
            this.axFPCLOCK_Svr2.Enabled = true;
            this.axFPCLOCK_Svr2.Location = new System.Drawing.Point(519, 301);
            this.axFPCLOCK_Svr2.Name = "axFPCLOCK_Svr2";
            this.axFPCLOCK_Svr2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axFPCLOCK_Svr2.OcxState")));
            this.axFPCLOCK_Svr2.Size = new System.Drawing.Size(125, 51);
            this.axFPCLOCK_Svr2.TabIndex = 19;
            this.axFPCLOCK_Svr2.Visible = false;
            // 
            // pictureBox_deviceSetting
            // 
            this.pictureBox_deviceSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_deviceSetting.Image = global::FPClient.Properties.Resources.icons8_settings_480px;
            this.pictureBox_deviceSetting.InitialImage = global::FPClient.Properties.Resources.@__Iphone_spinner_1;
            this.pictureBox_deviceSetting.Location = new System.Drawing.Point(594, 22);
            this.pictureBox_deviceSetting.Name = "pictureBox_deviceSetting";
            this.pictureBox_deviceSetting.Size = new System.Drawing.Size(37, 36);
            this.pictureBox_deviceSetting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_deviceSetting.TabIndex = 18;
            this.pictureBox_deviceSetting.TabStop = false;
            this.pictureBox_deviceSetting.Click += new System.EventHandler(this.pictureBox_deviceSetting_Click_1);
            // 
            // axFPCLOCK_Svr1
            // 
            this.axFPCLOCK_Svr1.Enabled = true;
            this.axFPCLOCK_Svr1.Location = new System.Drawing.Point(652, 305);
            this.axFPCLOCK_Svr1.Name = "axFPCLOCK_Svr1";
            this.axFPCLOCK_Svr1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axFPCLOCK_Svr1.OcxState")));
            this.axFPCLOCK_Svr1.Size = new System.Drawing.Size(125, 51);
            this.axFPCLOCK_Svr1.TabIndex = 4;
            this.axFPCLOCK_Svr1.Visible = false;
            this.axFPCLOCK_Svr1.OnReceiveGLogData += new AxFPCLOCK_SVRLib._DFPCLOCK_SvrEvents_OnReceiveGLogDataEventHandler(this.axFPCLOCK_Svr1_OnReceiveGLogData);
            // 
            // axFP_CLOCK
            // 
            this.axFP_CLOCK.Enabled = true;
            this.axFP_CLOCK.Location = new System.Drawing.Point(1248, 343);
            this.axFP_CLOCK.Name = "axFP_CLOCK";
            this.axFP_CLOCK.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axFP_CLOCK.OcxState")));
            this.axFP_CLOCK.Size = new System.Drawing.Size(100, 50);
            this.axFP_CLOCK.TabIndex = 18;
            this.axFP_CLOCK.Visible = false;
            // 
            // pictureBox_loading1
            // 
            this.pictureBox_loading1.Image = global::FPClient.Properties.Resources.@__Iphone_spinner_1;
            this.pictureBox_loading1.InitialImage = global::FPClient.Properties.Resources.@__Iphone_spinner_1;
            this.pictureBox_loading1.Location = new System.Drawing.Point(142, 58);
            this.pictureBox_loading1.Name = "pictureBox_loading1";
            this.pictureBox_loading1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox_loading1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_loading1.TabIndex = 8;
            this.pictureBox_loading1.TabStop = false;
            this.pictureBox_loading1.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FPClient.Properties.Resources.cropped_24HrFitnessLogoHigh512;
            this.pictureBox1.Location = new System.Drawing.Point(-3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label_alarm
            // 
            this.label_alarm.AutoSize = true;
            this.label_alarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_alarm.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label_alarm.Location = new System.Drawing.Point(480, 35);
            this.label_alarm.Name = "label_alarm";
            this.label_alarm.Size = new System.Drawing.Size(107, 24);
            this.label_alarm.TabIndex = 19;
            this.label_alarm.Text = "Information!";
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1351, 761);
            this.Controls.Add(this.axFP_CLOCK);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox_loading1);
            this.Controls.Add(this.linkLabel_userList);
            this.Controls.Add(this.listViewUsers);
            this.Controls.Add(this.label_user_name);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_alarm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1350, 800);
            this.Name = "FormDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "24hr-fitness.eu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.FormDashboard_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_plus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_faceImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_minus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_printQR)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axFPCLOCK_Svr2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_deviceSetting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axFPCLOCK_Svr1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axFP_CLOCK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_loading1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_user_name;
        private System.Windows.Forms.ListView listViewUsers;
        private System.Windows.Forms.LinkLabel linkLabel_userList;
        private System.Windows.Forms.PictureBox pictureBox_loading1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_paidState;
        private System.Windows.Forms.Label label_datetime;
        private System.Windows.Forms.Label label_memberCount;
        private System.Windows.Forms.Label label_price;
        private System.Windows.Forms.Label label_booking;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.PictureBox pictureBox_printQR;
        private System.Windows.Forms.Label labelImage1;
        private System.Windows.Forms.PictureBox pictureBox_faceImage;
        private System.Windows.Forms.Button button_pass;
        private System.Windows.Forms.ListView listView_devices;
        private AxFPCLOCK_SVRLib.AxFPCLOCK_Svr axFPCLOCK_Svr1;
        private System.Windows.Forms.TextBox textPort;
        private System.Windows.Forms.Label label_host;
        private System.Windows.Forms.Button clearList;
        private System.Windows.Forms.Button Disconnect;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox_deviceSetting;
        public AxFP_CLOCKLib.AxFP_CLOCK axFP_CLOCK;
        private System.Windows.Forms.Button button_nopass;
        private AxFPCLOCK_SVRLib.AxFPCLOCK_Svr axFPCLOCK_Svr2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox_minus;
        private System.Windows.Forms.PictureBox pictureBox_plus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_port;
        private IPAddressControlLib.IPAddressControl ipAddressControl1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_deviceOpen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_machineNumber;
        private System.Windows.Forms.Button button_getEnroll;
        private System.Windows.Forms.Label label_alarm;
    }
}