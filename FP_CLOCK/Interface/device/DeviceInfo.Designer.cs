namespace FPClient
{
    partial class DeviceInfo
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
            this.labelSN = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGetSerialNumber = new System.Windows.Forms.Button();
            this.btnGetBackupNumber = new System.Windows.Forms.Button();
            this.btnGetProductCode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelInfo
            // 
            this.labelInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelInfo.Location = new System.Drawing.Point(12, 9);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(729, 44);
            this.labelInfo.TabIndex = 0;
            this.labelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSN
            // 
            this.labelSN.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelSN.Location = new System.Drawing.Point(127, 76);
            this.labelSN.Name = "labelSN";
            this.labelSN.Size = new System.Drawing.Size(614, 44);
            this.labelSN.TabIndex = 0;
            this.labelSN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(127, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(614, 44);
            this.label3.TabIndex = 0;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(127, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(614, 44);
            this.label4.TabIndex = 0;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Serial Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Backup Number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "Product Code";
            // 
            // btnGetSerialNumber
            // 
            this.btnGetSerialNumber.Location = new System.Drawing.Point(78, 277);
            this.btnGetSerialNumber.Name = "btnGetSerialNumber";
            this.btnGetSerialNumber.Size = new System.Drawing.Size(129, 44);
            this.btnGetSerialNumber.TabIndex = 2;
            this.btnGetSerialNumber.Text = "Serial Number";
            this.btnGetSerialNumber.UseVisualStyleBackColor = true;
            this.btnGetSerialNumber.Click += new System.EventHandler(this.btnGetSerialNum_Click);
            // 
            // btnGetBackupNumber
            // 
            this.btnGetBackupNumber.Location = new System.Drawing.Point(304, 277);
            this.btnGetBackupNumber.Name = "btnGetBackupNumber";
            this.btnGetBackupNumber.Size = new System.Drawing.Size(129, 44);
            this.btnGetBackupNumber.TabIndex = 2;
            this.btnGetBackupNumber.Text = "Backup Number";
            this.btnGetBackupNumber.UseVisualStyleBackColor = true;
            this.btnGetBackupNumber.Click += new System.EventHandler(this.btnGetBackupNumber_Click);
            // 
            // btnGetProductCode
            // 
            this.btnGetProductCode.Location = new System.Drawing.Point(509, 277);
            this.btnGetProductCode.Name = "btnGetProductCode";
            this.btnGetProductCode.Size = new System.Drawing.Size(129, 44);
            this.btnGetProductCode.TabIndex = 2;
            this.btnGetProductCode.Text = "Product Code";
            this.btnGetProductCode.UseVisualStyleBackColor = true;
            this.btnGetProductCode.Click += new System.EventHandler(this.btnGetProductCode_Click);
            // 
            // DeviceInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 333);
            this.Controls.Add(this.btnGetProductCode);
            this.Controls.Add(this.btnGetBackupNumber);
            this.Controls.Add(this.btnGetSerialNumber);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelSN);
            this.Controls.Add(this.labelInfo);
            this.Name = "DeviceInfo";
            this.Text = "DeviceInfo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DeviceInfo_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Label labelSN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnGetSerialNumber;
        private System.Windows.Forms.Button btnGetBackupNumber;
        private System.Windows.Forms.Button btnGetProductCode;
    }
}