namespace FPClient.Interface.auth
{
	partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_userid = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_signin = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox_loading = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_loading)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "User ID";
            // 
            // textBox_userid
            // 
            this.textBox_userid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_userid.Location = new System.Drawing.Point(79, 164);
            this.textBox_userid.Margin = new System.Windows.Forms.Padding(10);
            this.textBox_userid.Name = "textBox_userid";
            this.textBox_userid.Size = new System.Drawing.Size(259, 26);
            this.textBox_userid.TabIndex = 1;
            // 
            // textBox_password
            // 
            this.textBox_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_password.Location = new System.Drawing.Point(79, 236);
            this.textBox_password.Margin = new System.Windows.Forms.Padding(10);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(259, 26);
            this.textBox_password.TabIndex = 3;
            this.textBox_password.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // button_signin
            // 
            this.button_signin.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_signin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_signin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_signin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_signin.Location = new System.Drawing.Point(140, 294);
            this.button_signin.Name = "button_signin";
            this.button_signin.Size = new System.Drawing.Size(147, 38);
            this.button_signin.TabIndex = 4;
            this.button_signin.Text = "Sign in";
            this.button_signin.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button_signin.UseVisualStyleBackColor = false;
            this.button_signin.Click += new System.EventHandler(this.button_signin_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(78, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(274, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Welcome to 24hr-fitness.eu";
            // 
            // pictureBox_loading
            // 
            this.pictureBox_loading.Image = global::FPClient.Properties.Resources.@__Iphone_spinner_1;
            this.pictureBox_loading.InitialImage = global::FPClient.Properties.Resources.@__Iphone_spinner_1;
            this.pictureBox_loading.Location = new System.Drawing.Point(185, 83);
            this.pictureBox_loading.Name = "pictureBox_loading";
            this.pictureBox_loading.Size = new System.Drawing.Size(64, 64);
            this.pictureBox_loading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_loading.TabIndex = 7;
            this.pictureBox_loading.TabStop = false;
            this.pictureBox_loading.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(97, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Net to 24hr-fitness.eu?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(217, 346);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Create an account.";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(425, 412);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox_loading);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_signin);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_userid);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_loading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_userid;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_signin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox_loading;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
	}
}