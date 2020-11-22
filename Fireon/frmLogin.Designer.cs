﻿namespace Fireon
{
    partial class frmLogin
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
            this.chkbx_keep_logged_in = new System.Windows.Forms.CheckBox();
            this.lbl_fireon = new System.Windows.Forms.Label();
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.lbl_terms = new System.Windows.Forms.Label();
            this.pnl_fireon = new System.Windows.Forms.Panel();
            this.picb_fireon = new System.Windows.Forms.PictureBox();
            this.txtbx_username = new System.Windows.Forms.TextBox();
            this.txtbx_pw = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.pnl_fireon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picb_fireon)).BeginInit();
            this.SuspendLayout();
            // 
            // chkbx_keep_logged_in
            // 
            this.chkbx_keep_logged_in.AutoSize = true;
            this.chkbx_keep_logged_in.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkbx_keep_logged_in.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbx_keep_logged_in.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chkbx_keep_logged_in.Location = new System.Drawing.Point(426, 336);
            this.chkbx_keep_logged_in.Name = "chkbx_keep_logged_in";
            this.chkbx_keep_logged_in.Size = new System.Drawing.Size(137, 22);
            this.chkbx_keep_logged_in.TabIndex = 3;
            this.chkbx_keep_logged_in.TabStop = false;
            this.chkbx_keep_logged_in.Text = "Keep me logged-in.";
            this.chkbx_keep_logged_in.UseVisualStyleBackColor = true;
            // 
            // lbl_fireon
            // 
            this.lbl_fireon.AutoSize = true;
            this.lbl_fireon.Font = new System.Drawing.Font("Open Sans SemiBold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fireon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_fireon.Location = new System.Drawing.Point(490, 59);
            this.lbl_fireon.Name = "lbl_fireon";
            this.lbl_fireon.Size = new System.Drawing.Size(156, 51);
            this.lbl_fireon.TabIndex = 9;
            this.lbl_fireon.Text = "FIREON";
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_welcome.Location = new System.Drawing.Point(450, 110);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(237, 15);
            this.lbl_welcome.TabIndex = 10;
            this.lbl_welcome.Text = "Welcome back! Please login to your account.";
            // 
            // lbl_terms
            // 
            this.lbl_terms.AutoSize = true;
            this.lbl_terms.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_terms.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_terms.Location = new System.Drawing.Point(492, 444);
            this.lbl_terms.Name = "lbl_terms";
            this.lbl_terms.Size = new System.Drawing.Size(154, 15);
            this.lbl_terms.TabIndex = 11;
            this.lbl_terms.Text = "Terms of Use.  Privacy Policy";
            // 
            // pnl_fireon
            // 
            this.pnl_fireon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(5)))));
            this.pnl_fireon.Controls.Add(this.picb_fireon);
            this.pnl_fireon.Location = new System.Drawing.Point(-5, 5);
            this.pnl_fireon.Name = "pnl_fireon";
            this.pnl_fireon.Size = new System.Drawing.Size(340, 589);
            this.pnl_fireon.TabIndex = 7;
            // 
            // picb_fireon
            // 
            this.picb_fireon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(5)))));
            this.picb_fireon.BackgroundImage = global::Fireon.Properties.Resources.picb_logo_fireon_login;
            this.picb_fireon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picb_fireon.Location = new System.Drawing.Point(57, 205);
            this.picb_fireon.Name = "picb_fireon";
            this.picb_fireon.Size = new System.Drawing.Size(219, 182);
            this.picb_fireon.TabIndex = 0;
            this.picb_fireon.TabStop = false;
            // 
            // txtbx_username
            // 
            this.txtbx_username.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbx_username.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_username.Location = new System.Drawing.Point(426, 231);
            this.txtbx_username.MaxLength = 15;
            this.txtbx_username.Name = "txtbx_username";
            this.txtbx_username.Size = new System.Drawing.Size(285, 25);
            this.txtbx_username.TabIndex = 1;
            this.txtbx_username.TabStop = false;
            this.txtbx_username.Text = "Username";
            // 
            // txtbx_pw
            // 
            this.txtbx_pw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbx_pw.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_pw.Location = new System.Drawing.Point(426, 262);
            this.txtbx_pw.MaxLength = 15;
            this.txtbx_pw.Name = "txtbx_pw";
            this.txtbx_pw.Size = new System.Drawing.Size(285, 25);
            this.txtbx_pw.TabIndex = 2;
            this.txtbx_pw.TabStop = false;
            this.txtbx_pw.Text = "Password";
            // 
            // btn_login
            // 
            this.btn_login.BackgroundImage = global::Fireon.Properties.Resources.btn_login;
            this.btn_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Location = new System.Drawing.Point(426, 364);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(285, 40);
            this.btn_login.TabIndex = 4;
            this.btn_login.TabStop = false;
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click_1);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 589);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txtbx_pw);
            this.Controls.Add(this.txtbx_username);
            this.Controls.Add(this.chkbx_keep_logged_in);
            this.Controls.Add(this.lbl_fireon);
            this.Controls.Add(this.lbl_welcome);
            this.Controls.Add(this.lbl_terms);
            this.Controls.Add(this.pnl_fireon);
            this.DisplayHeader = false;
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.Resizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Load += new System.EventHandler(this.Login_Load);
            this.pnl_fireon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picb_fireon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picb_fireon;
        private System.Windows.Forms.CheckBox chkbx_keep_logged_in;
        private System.Windows.Forms.Label lbl_fireon;
        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.Label lbl_terms;
        private System.Windows.Forms.Panel pnl_fireon;
        private System.Windows.Forms.TextBox txtbx_username;
        private System.Windows.Forms.TextBox txtbx_pw;
        private System.Windows.Forms.Button btn_login;
    }
}