using System;

namespace WindowsFormsApp1
{
    partial class UserLoginForm
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
            this.lbl_usename = new System.Windows.Forms.Label();
            this.lbl_Passworde = new System.Windows.Forms.Label();
            this.txtbox_username = new System.Windows.Forms.TextBox();
            this.txtbox_passworde = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_Signup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_usename
            // 
            this.lbl_usename.AutoSize = true;
            this.lbl_usename.Location = new System.Drawing.Point(59, 51);
            this.lbl_usename.Name = "lbl_usename";
            this.lbl_usename.Size = new System.Drawing.Size(76, 16);
            this.lbl_usename.TabIndex = 0;
            this.lbl_usename.Text = "Username :";
            // 
            // lbl_Passworde
            // 
            this.lbl_Passworde.AutoSize = true;
            this.lbl_Passworde.Location = new System.Drawing.Point(59, 89);
            this.lbl_Passworde.Name = "lbl_Passworde";
            this.lbl_Passworde.Size = new System.Drawing.Size(84, 16);
            this.lbl_Passworde.TabIndex = 1;
            this.lbl_Passworde.Text = "Passworde : ";
            // 
            // txtbox_username
            // 
            this.txtbox_username.Location = new System.Drawing.Point(177, 51);
            this.txtbox_username.Name = "txtbox_username";
            this.txtbox_username.Size = new System.Drawing.Size(230, 22);
            this.txtbox_username.TabIndex = 2;
            // 
            // txtbox_passworde
            // 
            this.txtbox_passworde.Location = new System.Drawing.Point(177, 89);
            this.txtbox_passworde.Name = "txtbox_passworde";
            this.txtbox_passworde.Size = new System.Drawing.Size(230, 22);
            this.txtbox_passworde.TabIndex = 3;
            this.txtbox_passworde.UseSystemPasswordChar = true;
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(177, 159);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 27);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_Signup
            // 
            this.btn_Signup.Location = new System.Drawing.Point(332, 159);
            this.btn_Signup.Name = "btn_Signup";
            this.btn_Signup.Size = new System.Drawing.Size(75, 27);
            this.btn_Signup.TabIndex = 5;
            this.btn_Signup.Text = "Sign up";
            this.btn_Signup.UseVisualStyleBackColor = true;
            this.btn_Signup.Click += new System.EventHandler(this.btn_Signup_Click);
            // 
            // UserLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 292);
            this.Controls.Add(this.btn_Signup);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txtbox_passworde);
            this.Controls.Add(this.txtbox_username);
            this.Controls.Add(this.lbl_Passworde);
            this.Controls.Add(this.lbl_usename);
            this.Name = "UserLoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserLoginForm";
            this.Load += new System.EventHandler(this.UserLoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void UserLoginForm_Load(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label lbl_usename;
        private System.Windows.Forms.Label lbl_Passworde;
        private System.Windows.Forms.TextBox txtbox_username;
        private System.Windows.Forms.TextBox txtbox_passworde;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_Signup;
    }
}