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
            this.chkbx_keep_logged_in = new System.Windows.Forms.CheckBox();
            this.lbl_fireon = new System.Windows.Forms.Label();
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.lbl_terms = new System.Windows.Forms.Label();
            this.pnl_fireon = new System.Windows.Forms.Panel();
            this.picb_fireon = new System.Windows.Forms.PictureBox();
            this.txtbx_username = new System.Windows.Forms.TextBox();
            this.txtbx_pw = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.btn_see_pw = new System.Windows.Forms.Button();
            this.dgv_accounts = new System.Windows.Forms.DataGridView();
            this.pnl_fireon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picb_fireon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_accounts)).BeginInit();
            this.SuspendLayout();
            // 
            // chkbx_keep_logged_in
            // 
            this.chkbx_keep_logged_in.AutoSize = true;
            this.chkbx_keep_logged_in.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkbx_keep_logged_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbx_keep_logged_in.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chkbx_keep_logged_in.Location = new System.Drawing.Point(433, 309);
            this.chkbx_keep_logged_in.Name = "chkbx_keep_logged_in";
            this.chkbx_keep_logged_in.Size = new System.Drawing.Size(141, 20);
            this.chkbx_keep_logged_in.TabIndex = 4;
            this.chkbx_keep_logged_in.Text = "Keep me logged-in.";
            this.chkbx_keep_logged_in.UseVisualStyleBackColor = true;
            // 
            // lbl_fireon
            // 
            this.lbl_fireon.AutoSize = true;
            this.lbl_fireon.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fireon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_fireon.Location = new System.Drawing.Point(497, 54);
            this.lbl_fireon.Name = "lbl_fireon";
            this.lbl_fireon.Size = new System.Drawing.Size(164, 42);
            this.lbl_fireon.TabIndex = 9;
            this.lbl_fireon.Text = "FIREON";
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_welcome.Location = new System.Drawing.Point(457, 105);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(222, 13);
            this.lbl_welcome.TabIndex = 10;
            this.lbl_welcome.Text = "Welcome back! Please login to your account.";
            // 
            // lbl_terms
            // 
            this.lbl_terms.AutoSize = true;
            this.lbl_terms.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_terms.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_terms.Location = new System.Drawing.Point(498, 439);
            this.lbl_terms.Name = "lbl_terms";
            this.lbl_terms.Size = new System.Drawing.Size(145, 13);
            this.lbl_terms.TabIndex = 11;
            this.lbl_terms.Text = "Terms of Use.  Privacy Policy";
            // 
            // pnl_fireon
            // 
            this.pnl_fireon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(5)))));
            this.pnl_fireon.Controls.Add(this.picb_fireon);
            this.pnl_fireon.Location = new System.Drawing.Point(-5, -2);
            this.pnl_fireon.Name = "pnl_fireon";
            this.pnl_fireon.Size = new System.Drawing.Size(340, 596);
            this.pnl_fireon.TabIndex = 7;
            // 
            // picb_fireon
            // 
            this.picb_fireon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(5)))));
            this.picb_fireon.BackgroundImage = global::Fireon.Properties.Resources.miscFireonLogin;
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
            this.txtbx_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_username.Location = new System.Drawing.Point(433, 213);
            this.txtbx_username.MaxLength = 32;
            this.txtbx_username.Name = "txtbx_username";
            this.txtbx_username.Size = new System.Drawing.Size(285, 22);
            this.txtbx_username.TabIndex = 1;
            // 
            // txtbx_pw
            // 
            this.txtbx_pw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbx_pw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_pw.Location = new System.Drawing.Point(433, 267);
            this.txtbx_pw.MaxLength = 32;
            this.txtbx_pw.Name = "txtbx_pw";
            this.txtbx_pw.Size = new System.Drawing.Size(285, 22);
            this.txtbx_pw.TabIndex = 2;
            this.txtbx_pw.Tag = "TRUE";
            this.txtbx_pw.UseSystemPasswordChar = true;
            // 
            // btn_login
            // 
            this.btn_login.BackgroundImage = global::Fireon.Properties.Resources.btnOthersLogin;
            this.btn_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Location = new System.Drawing.Point(433, 389);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(285, 40);
            this.btn_login.TabIndex = 5;
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.ForeColor = System.Drawing.Color.Black;
            this.lbl_username.Location = new System.Drawing.Point(430, 190);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(71, 16);
            this.lbl_username.TabIndex = 10;
            this.lbl_username.Text = "Username";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.ForeColor = System.Drawing.Color.Black;
            this.lbl_password.Location = new System.Drawing.Point(430, 246);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(68, 16);
            this.lbl_password.TabIndex = 10;
            this.lbl_password.Text = "Password";
            // 
            // btn_see_pw
            // 
            this.btn_see_pw.BackColor = System.Drawing.Color.Transparent;
            this.btn_see_pw.BackgroundImage = global::Fireon.Properties.Resources.btnIconEye;
            this.btn_see_pw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_see_pw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_see_pw.FlatAppearance.BorderSize = 0;
            this.btn_see_pw.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_see_pw.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_see_pw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_see_pw.Location = new System.Drawing.Point(724, 261);
            this.btn_see_pw.Name = "btn_see_pw";
            this.btn_see_pw.Size = new System.Drawing.Size(35, 35);
            this.btn_see_pw.TabIndex = 3;
            this.btn_see_pw.Tag = "";
            this.btn_see_pw.UseVisualStyleBackColor = true;
            this.btn_see_pw.Click += new System.EventHandler(this.btn_see_pw_Click);
            this.btn_see_pw.MouseLeave += new System.EventHandler(this.btn_see_pw_MouseLeave);
            this.btn_see_pw.MouseHover += new System.EventHandler(this.btn_see_pw_MouseHover);
            // 
            // dgv_accounts
            // 
            this.dgv_accounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_accounts.Location = new System.Drawing.Point(341, 474);
            this.dgv_accounts.Name = "dgv_accounts";
            this.dgv_accounts.ReadOnly = true;
            this.dgv_accounts.Size = new System.Drawing.Size(455, 103);
            this.dgv_accounts.TabIndex = 0;
            this.dgv_accounts.TabStop = false;
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btn_login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(808, 589);
            this.Controls.Add(this.dgv_accounts);
            this.Controls.Add(this.btn_see_pw);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txtbx_pw);
            this.Controls.Add(this.txtbx_username);
            this.Controls.Add(this.chkbx_keep_logged_in);
            this.Controls.Add(this.lbl_fireon);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.lbl_welcome);
            this.Controls.Add(this.lbl_terms);
            this.Controls.Add(this.pnl_fireon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fireon Payroll System";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.VisibleChanged += new System.EventHandler(this.frmLogin_VisibleChanged);
            this.pnl_fireon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picb_fireon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_accounts)).EndInit();
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
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Button btn_see_pw;
        public System.Windows.Forms.DataGridView dgv_accounts;
    }
}