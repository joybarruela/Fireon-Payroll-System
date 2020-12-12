namespace Fireon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.chkbxKeepLoggedIn = new System.Windows.Forms.CheckBox();
            this.lblFireon = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblTerms = new System.Windows.Forms.Label();
            this.pnlFireon = new System.Windows.Forms.Panel();
            this.picbFireon = new System.Windows.Forms.PictureBox();
            this.txtbxUsername = new System.Windows.Forms.TextBox();
            this.txtbxPw = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnSeePw = new System.Windows.Forms.Button();
            this.dtgvAccounts = new System.Windows.Forms.DataGridView();
            this.pnlFireon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbFireon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccounts)).BeginInit();
            this.SuspendLayout();
            // 
            // chkbxKeepLoggedIn
            // 
            this.chkbxKeepLoggedIn.AutoSize = true;
            this.chkbxKeepLoggedIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkbxKeepLoggedIn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbxKeepLoggedIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chkbxKeepLoggedIn.Location = new System.Drawing.Point(433, 309);
            this.chkbxKeepLoggedIn.Name = "chkbxKeepLoggedIn";
            this.chkbxKeepLoggedIn.Size = new System.Drawing.Size(152, 21);
            this.chkbxKeepLoggedIn.TabIndex = 4;
            this.chkbxKeepLoggedIn.Text = "Keep me logged-in.";
            this.chkbxKeepLoggedIn.UseVisualStyleBackColor = true;
            // 
            // lblFireon
            // 
            this.lblFireon.AutoSize = true;
            this.lblFireon.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFireon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblFireon.Location = new System.Drawing.Point(502, 54);
            this.lblFireon.Name = "lblFireon";
            this.lblFireon.Size = new System.Drawing.Size(146, 44);
            this.lblFireon.TabIndex = 9;
            this.lblFireon.Text = "FIREON";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblWelcome.Location = new System.Drawing.Point(449, 105);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(252, 16);
            this.lblWelcome.TabIndex = 10;
            this.lblWelcome.Text = "Welcome back! Please login to your account.";
            // 
            // lblTerms
            // 
            this.lblTerms.AutoSize = true;
            this.lblTerms.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTerms.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTerms.Location = new System.Drawing.Point(498, 439);
            this.lblTerms.Name = "lblTerms";
            this.lblTerms.Size = new System.Drawing.Size(156, 16);
            this.lblTerms.TabIndex = 11;
            this.lblTerms.Text = "Terms of Use.  Privacy Policy";
            // 
            // pnlFireon
            // 
            this.pnlFireon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(5)))));
            this.pnlFireon.Controls.Add(this.picbFireon);
            this.pnlFireon.Location = new System.Drawing.Point(-5, -2);
            this.pnlFireon.Name = "pnlFireon";
            this.pnlFireon.Size = new System.Drawing.Size(340, 596);
            this.pnlFireon.TabIndex = 7;
            // 
            // picbFireon
            // 
            this.picbFireon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(5)))));
            this.picbFireon.BackgroundImage = global::Fireon.Properties.Resources.miscFireonLogin;
            this.picbFireon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picbFireon.Location = new System.Drawing.Point(57, 205);
            this.picbFireon.Name = "picbFireon";
            this.picbFireon.Size = new System.Drawing.Size(219, 182);
            this.picbFireon.TabIndex = 0;
            this.picbFireon.TabStop = false;
            // 
            // txtbxUsername
            // 
            this.txtbxUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxUsername.Location = new System.Drawing.Point(433, 213);
            this.txtbxUsername.MaxLength = 32;
            this.txtbxUsername.Name = "txtbxUsername";
            this.txtbxUsername.Size = new System.Drawing.Size(285, 22);
            this.txtbxUsername.TabIndex = 1;
            // 
            // txtbxPw
            // 
            this.txtbxPw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbxPw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxPw.Location = new System.Drawing.Point(433, 267);
            this.txtbxPw.MaxLength = 32;
            this.txtbxPw.Name = "txtbxPw";
            this.txtbxPw.Size = new System.Drawing.Size(285, 22);
            this.txtbxPw.TabIndex = 2;
            this.txtbxPw.Tag = "TRUE";
            this.txtbxPw.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            this.btnLogin.BackgroundImage = global::Fireon.Properties.Resources.btnOthersLogin;
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Location = new System.Drawing.Point(433, 389);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(285, 40);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.Black;
            this.lblUsername.Location = new System.Drawing.Point(430, 190);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(71, 17);
            this.lblUsername.TabIndex = 10;
            this.lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.Black;
            this.lblPassword.Location = new System.Drawing.Point(430, 246);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(69, 17);
            this.lblPassword.TabIndex = 10;
            this.lblPassword.Text = "Password";
            // 
            // btnSeePw
            // 
            this.btnSeePw.BackColor = System.Drawing.Color.Transparent;
            this.btnSeePw.BackgroundImage = global::Fireon.Properties.Resources.btnIconEye;
            this.btnSeePw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSeePw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeePw.FlatAppearance.BorderSize = 0;
            this.btnSeePw.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSeePw.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSeePw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeePw.Location = new System.Drawing.Point(724, 261);
            this.btnSeePw.Name = "btnSeePw";
            this.btnSeePw.Size = new System.Drawing.Size(35, 35);
            this.btnSeePw.TabIndex = 3;
            this.btnSeePw.Tag = "";
            this.btnSeePw.UseVisualStyleBackColor = true;
            this.btnSeePw.Click += new System.EventHandler(this.btn_see_pw_Click);
            this.btnSeePw.MouseLeave += new System.EventHandler(this.btn_see_pw_MouseLeave);
            this.btnSeePw.MouseHover += new System.EventHandler(this.btn_see_pw_MouseHover);
            // 
            // dtgvAccounts
            // 
            this.dtgvAccounts.AllowUserToAddRows = false;
            this.dtgvAccounts.AllowUserToDeleteRows = false;
            this.dtgvAccounts.AllowUserToResizeColumns = false;
            this.dtgvAccounts.AllowUserToResizeRows = false;
            this.dtgvAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvAccounts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgvAccounts.Location = new System.Drawing.Point(341, 474);
            this.dtgvAccounts.Name = "dtgvAccounts";
            this.dtgvAccounts.ReadOnly = true;
            this.dtgvAccounts.Size = new System.Drawing.Size(455, 103);
            this.dtgvAccounts.TabIndex = 0;
            this.dtgvAccounts.TabStop = false;
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(808, 589);
            this.Controls.Add(this.dtgvAccounts);
            this.Controls.Add(this.btnSeePw);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtbxPw);
            this.Controls.Add(this.txtbxUsername);
            this.Controls.Add(this.chkbxKeepLoggedIn);
            this.Controls.Add(this.lblFireon);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.lblTerms);
            this.Controls.Add(this.pnlFireon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fireon Payroll System";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.VisibleChanged += new System.EventHandler(this.frmLogin_VisibleChanged);
            this.pnlFireon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picbFireon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccounts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picbFireon;
        private System.Windows.Forms.CheckBox chkbxKeepLoggedIn;
        private System.Windows.Forms.Label lblFireon;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblTerms;
        private System.Windows.Forms.Panel pnlFireon;
        private System.Windows.Forms.TextBox txtbxUsername;
        private System.Windows.Forms.TextBox txtbxPw;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnSeePw;
        public System.Windows.Forms.DataGridView dtgvAccounts;
    }
}