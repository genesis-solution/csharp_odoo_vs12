namespace FPClient.Interface.auth
{
    partial class FormRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegister));
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_signup = new System.Windows.Forms.Button();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_userid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox_loading = new System.Windows.Forms.PictureBox();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_confirmpwd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_loading)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(178, 459);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Sign in here";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(90, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(274, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Welcome to 24hr-fitness.eu";
            // 
            // button_signup
            // 
            this.button_signup.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_signup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_signup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_signup.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_signup.Location = new System.Drawing.Point(141, 405);
            this.button_signup.Name = "button_signup";
            this.button_signup.Size = new System.Drawing.Size(147, 38);
            this.button_signup.TabIndex = 14;
            this.button_signup.Text = "Sign up";
            this.button_signup.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button_signup.UseVisualStyleBackColor = false;
            this.button_signup.Click += new System.EventHandler(this.button_signup_Click);
            // 
            // textBox_password
            // 
            this.textBox_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_password.Location = new System.Drawing.Point(84, 294);
            this.textBox_password.Margin = new System.Windows.Forms.Padding(10);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(259, 26);
            this.textBox_password.TabIndex = 13;
            this.textBox_password.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Password";
            // 
            // textBox_userid
            // 
            this.textBox_userid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_userid.Location = new System.Drawing.Point(84, 176);
            this.textBox_userid.Margin = new System.Windows.Forms.Padding(10);
            this.textBox_userid.Name = "textBox_userid";
            this.textBox_userid.Size = new System.Drawing.Size(259, 26);
            this.textBox_userid.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "User ID";
            // 
            // pictureBox_loading
            // 
            this.pictureBox_loading.Image = global::FPClient.Properties.Resources.@__Iphone_spinner_1;
            this.pictureBox_loading.InitialImage = global::FPClient.Properties.Resources.@__Iphone_spinner_1;
            this.pictureBox_loading.Location = new System.Drawing.Point(190, 91);
            this.pictureBox_loading.Name = "pictureBox_loading";
            this.pictureBox_loading.Size = new System.Drawing.Size(64, 64);
            this.pictureBox_loading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_loading.TabIndex = 16;
            this.pictureBox_loading.TabStop = false;
            this.pictureBox_loading.Visible = false;
            // 
            // textBox_email
            // 
            this.textBox_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_email.Location = new System.Drawing.Point(84, 236);
            this.textBox_email.Margin = new System.Windows.Forms.Padding(10);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(259, 26);
            this.textBox_email.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Email";
            // 
            // textBox_confirmpwd
            // 
            this.textBox_confirmpwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_confirmpwd.Location = new System.Drawing.Point(84, 355);
            this.textBox_confirmpwd.Margin = new System.Windows.Forms.Padding(10);
            this.textBox_confirmpwd.Name = "textBox_confirmpwd";
            this.textBox_confirmpwd.Size = new System.Drawing.Size(259, 26);
            this.textBox_confirmpwd.TabIndex = 22;
            this.textBox_confirmpwd.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(81, 333);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Confirm Password";
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(429, 526);
            this.Controls.Add(this.textBox_confirmpwd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox_loading);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_signup);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_userid);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_loading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox_loading;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_signup;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_userid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_confirmpwd;
        private System.Windows.Forms.Label label6;
    }
}