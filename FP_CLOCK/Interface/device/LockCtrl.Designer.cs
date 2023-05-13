namespace FPClient
{
    partial class LockCtrl
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
            this.labelInfo = new System.Windows.Forms.Label();
            this.btnGetDoorStatus = new System.Windows.Forms.Button();
            this.btnDoorOpen = new System.Windows.Forms.Button();
            this.btnUncondOpen = new System.Windows.Forms.Button();
            this.btnAutoRecover = new System.Windows.Forms.Button();
            this.btnReboot = new System.Windows.Forms.Button();
            this.btnUncondClose = new System.Windows.Forms.Button();
            this.btnWarnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelInfo
            // 
            this.labelInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelInfo.Location = new System.Drawing.Point(12, 9);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(628, 35);
            this.labelInfo.TabIndex = 0;
            this.labelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGetDoorStatus
            // 
            this.btnGetDoorStatus.Location = new System.Drawing.Point(72, 124);
            this.btnGetDoorStatus.Name = "btnGetDoorStatus";
            this.btnGetDoorStatus.Size = new System.Drawing.Size(125, 43);
            this.btnGetDoorStatus.TabIndex = 1;
            this.btnGetDoorStatus.Text = "GetDoorStatus";
            this.btnGetDoorStatus.UseVisualStyleBackColor = true;
            this.btnGetDoorStatus.Click += new System.EventHandler(this.btnGetDoorStatus_Click);
            // 
            // btnDoorOpen
            // 
            this.btnDoorOpen.Location = new System.Drawing.Point(231, 124);
            this.btnDoorOpen.Name = "btnDoorOpen";
            this.btnDoorOpen.Size = new System.Drawing.Size(125, 23);
            this.btnDoorOpen.TabIndex = 1;
            this.btnDoorOpen.Text = "Door Open";
            this.btnDoorOpen.UseVisualStyleBackColor = true;
            this.btnDoorOpen.Click += new System.EventHandler(this.btnDoorOpen_Click);
            // 
            // btnUncondOpen
            // 
            this.btnUncondOpen.Location = new System.Drawing.Point(396, 124);
            this.btnUncondOpen.Name = "btnUncondOpen";
            this.btnUncondOpen.Size = new System.Drawing.Size(127, 23);
            this.btnUncondOpen.TabIndex = 1;
            this.btnUncondOpen.Text = "Uncond Open";
            this.btnUncondOpen.UseVisualStyleBackColor = true;
            this.btnUncondOpen.Click += new System.EventHandler(this.btnUncondOpen_Click);
            // 
            // btnAutoRecover
            // 
            this.btnAutoRecover.Location = new System.Drawing.Point(231, 170);
            this.btnAutoRecover.Name = "btnAutoRecover";
            this.btnAutoRecover.Size = new System.Drawing.Size(125, 23);
            this.btnAutoRecover.TabIndex = 1;
            this.btnAutoRecover.Text = "AutoRecover";
            this.btnAutoRecover.UseVisualStyleBackColor = true;
            this.btnAutoRecover.Click += new System.EventHandler(this.btnAutoRecover_Click);
            // 
            // btnReboot
            // 
            this.btnReboot.Location = new System.Drawing.Point(231, 222);
            this.btnReboot.Name = "btnReboot";
            this.btnReboot.Size = new System.Drawing.Size(125, 23);
            this.btnReboot.TabIndex = 1;
            this.btnReboot.Text = "Reboot";
            this.btnReboot.UseVisualStyleBackColor = true;
            this.btnReboot.Click += new System.EventHandler(this.btnReboot_Click);
            // 
            // btnUncondClose
            // 
            this.btnUncondClose.Location = new System.Drawing.Point(396, 170);
            this.btnUncondClose.Name = "btnUncondClose";
            this.btnUncondClose.Size = new System.Drawing.Size(127, 23);
            this.btnUncondClose.TabIndex = 1;
            this.btnUncondClose.Text = "Uncond Close";
            this.btnUncondClose.UseVisualStyleBackColor = true;
            this.btnUncondClose.Click += new System.EventHandler(this.btnUncondClose_Click);
            // 
            // btnWarnCancel
            // 
            this.btnWarnCancel.Location = new System.Drawing.Point(396, 222);
            this.btnWarnCancel.Name = "btnWarnCancel";
            this.btnWarnCancel.Size = new System.Drawing.Size(127, 23);
            this.btnWarnCancel.TabIndex = 1;
            this.btnWarnCancel.Text = "Warn Cancel";
            this.btnWarnCancel.UseVisualStyleBackColor = true;
            this.btnWarnCancel.Click += new System.EventHandler(this.btnWarnCancel_Click);
            // 
            // LockCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 295);
            this.Controls.Add(this.btnWarnCancel);
            this.Controls.Add(this.btnUncondClose);
            this.Controls.Add(this.btnUncondOpen);
            this.Controls.Add(this.btnReboot);
            this.Controls.Add(this.btnAutoRecover);
            this.Controls.Add(this.btnDoorOpen);
            this.Controls.Add(this.btnGetDoorStatus);
            this.Controls.Add(this.labelInfo);
            this.MaximizeBox = false;
            this.Name = "LockCtrl";
            this.Text = "LockCtrl";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LockCtrl_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Button btnGetDoorStatus;
        private System.Windows.Forms.Button btnDoorOpen;
        private System.Windows.Forms.Button btnUncondOpen;
        private System.Windows.Forms.Button btnAutoRecover;
        private System.Windows.Forms.Button btnReboot;
        private System.Windows.Forms.Button btnUncondClose;
        private System.Windows.Forms.Button btnWarnCancel;
    }
}