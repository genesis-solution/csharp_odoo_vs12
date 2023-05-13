namespace FPClient
{
    partial class LogManagement
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.labelTotal = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnReadSLogData = new System.Windows.Forms.Button();
            this.btnReadAllSLogData = new System.Windows.Forms.Button();
            this.btnEmptySLogData = new System.Windows.Forms.Button();
            this.btnReadGLogData = new System.Windows.Forms.Button();
            this.btnEmptyGLogData = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnReadAllGLogData = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelInfo
            // 
            this.labelInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelInfo.Location = new System.Drawing.Point(112, 16);
            this.labelInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(872, 40);
            this.labelInfo.TabIndex = 0;
            this.labelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(16, 130);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1089, 393);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(17, 108);
            this.labelTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(55, 15);
            this.labelTotal.TabIndex = 2;
            this.labelTotal.Text = "Total:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(979, 108);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(125, 19);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "ReadOnceMark";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnReadSLogData
            // 
            this.btnReadSLogData.Location = new System.Drawing.Point(16, 566);
            this.btnReadSLogData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReadSLogData.Name = "btnReadSLogData";
            this.btnReadSLogData.Size = new System.Drawing.Size(163, 29);
            this.btnReadSLogData.TabIndex = 4;
            this.btnReadSLogData.Text = "Read SLogData";
            this.btnReadSLogData.UseVisualStyleBackColor = true;
            this.btnReadSLogData.Click += new System.EventHandler(this.btnReadSLogData_Click);
            // 
            // btnReadAllSLogData
            // 
            this.btnReadAllSLogData.Location = new System.Drawing.Point(16, 602);
            this.btnReadAllSLogData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReadAllSLogData.Name = "btnReadAllSLogData";
            this.btnReadAllSLogData.Size = new System.Drawing.Size(163, 29);
            this.btnReadAllSLogData.TabIndex = 4;
            this.btnReadAllSLogData.Text = "Read All SLogData";
            this.btnReadAllSLogData.UseVisualStyleBackColor = true;
            this.btnReadAllSLogData.Click += new System.EventHandler(this.btnReadAllSLogData_Click);
            // 
            // btnEmptySLogData
            // 
            this.btnEmptySLogData.Location = new System.Drawing.Point(16, 639);
            this.btnEmptySLogData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEmptySLogData.Name = "btnEmptySLogData";
            this.btnEmptySLogData.Size = new System.Drawing.Size(163, 29);
            this.btnEmptySLogData.TabIndex = 4;
            this.btnEmptySLogData.Text = "Empty SLogData";
            this.btnEmptySLogData.UseVisualStyleBackColor = true;
            this.btnEmptySLogData.Click += new System.EventHandler(this.btnEmptySLogData_Click);
            // 
            // btnReadGLogData
            // 
            this.btnReadGLogData.Location = new System.Drawing.Point(32, 26);
            this.btnReadGLogData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReadGLogData.Name = "btnReadGLogData";
            this.btnReadGLogData.Size = new System.Drawing.Size(173, 29);
            this.btnReadGLogData.TabIndex = 4;
            this.btnReadGLogData.Text = "Read";
            this.btnReadGLogData.UseVisualStyleBackColor = true;
            this.btnReadGLogData.Click += new System.EventHandler(this.btnReadGLogData_Click);
            // 
            // btnEmptyGLogData
            // 
            this.btnEmptyGLogData.Location = new System.Drawing.Point(32, 62);
            this.btnEmptyGLogData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEmptyGLogData.Name = "btnEmptyGLogData";
            this.btnEmptyGLogData.Size = new System.Drawing.Size(173, 29);
            this.btnEmptyGLogData.TabIndex = 4;
            this.btnEmptyGLogData.Text = "Empty";
            this.btnEmptyGLogData.UseVisualStyleBackColor = true;
            this.btnEmptyGLogData.Click += new System.EventHandler(this.btnEmptyGLogData_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(853, 639);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(131, 29);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnReadAllGLogData
            // 
            this.btnReadAllGLogData.Location = new System.Drawing.Point(32, 99);
            this.btnReadAllGLogData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReadAllGLogData.Name = "btnReadAllGLogData";
            this.btnReadAllGLogData.Size = new System.Drawing.Size(173, 38);
            this.btnReadAllGLogData.TabIndex = 5;
            this.btnReadAllGLogData.Text = "Read All";
            this.btnReadAllGLogData.UseVisualStyleBackColor = true;
            this.btnReadAllGLogData.Click += new System.EventHandler(this.btnReadAllGLogData_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(331, 566);
            this.button8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(200, 39);
            this.button8.TabIndex = 4;
            this.button8.Text = "Udisk Read SLogData";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(331, 612);
            this.button9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(200, 38);
            this.button9.TabIndex = 4;
            this.button9.Text = "Udisk Read GLogData";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.UDGLogRead_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReadGLogData);
            this.groupBox1.Controls.Add(this.btnReadAllGLogData);
            this.groupBox1.Controls.Add(this.btnEmptyGLogData);
            this.groupBox1.Location = new System.Drawing.Point(565, 542);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(267, 142);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " GLogData";
            // 
            // LogManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 700);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnEmptySLogData);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.btnReadAllSLogData);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.btnReadSLogData);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.labelInfo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LogManagement";
            this.Text = "LogManagement";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LogManagement_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnReadSLogData;
        private System.Windows.Forms.Button btnReadAllSLogData;
        private System.Windows.Forms.Button btnEmptySLogData;
        private System.Windows.Forms.Button btnReadGLogData;
        private System.Windows.Forms.Button btnEmptyGLogData;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnReadAllGLogData;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}