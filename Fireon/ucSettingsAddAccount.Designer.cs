namespace Fireon
{
    partial class Settings_Add_Account
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings_Add_Account));
            this.pnl_add_account = new System.Windows.Forms.Panel();
            this.btn_add_account = new System.Windows.Forms.Button();
            this.btn_cancel_add_account = new System.Windows.Forms.Button();
            this.txtbx_username = new System.Windows.Forms.TextBox();
            this.btn_see_new_pw = new JImageButton.JImageButton();
            this.btn_see_current_pw = new JImageButton.JImageButton();
            this.lbl_add_account = new System.Windows.Forms.Label();
            this.lbl_user_type = new System.Windows.Forms.Label();
            this.lbl_user_name = new System.Windows.Forms.Label();
            this.picb_user_add_account = new System.Windows.Forms.PictureBox();
            this.txtbx_confirm_pw = new System.Windows.Forms.TextBox();
            this.txtbx_pw = new System.Windows.Forms.TextBox();
            this.pnl_add_account.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picb_user_add_account)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_add_account
            // 
            this.pnl_add_account.BackColor = System.Drawing.Color.White;
            this.pnl_add_account.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_add_account.Controls.Add(this.btn_add_account);
            this.pnl_add_account.Controls.Add(this.btn_cancel_add_account);
            this.pnl_add_account.Controls.Add(this.txtbx_username);
            this.pnl_add_account.Controls.Add(this.btn_see_new_pw);
            this.pnl_add_account.Controls.Add(this.btn_see_current_pw);
            this.pnl_add_account.Controls.Add(this.lbl_add_account);
            this.pnl_add_account.Controls.Add(this.lbl_user_type);
            this.pnl_add_account.Controls.Add(this.lbl_user_name);
            this.pnl_add_account.Controls.Add(this.picb_user_add_account);
            this.pnl_add_account.Controls.Add(this.txtbx_confirm_pw);
            this.pnl_add_account.Controls.Add(this.txtbx_pw);
            this.pnl_add_account.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_add_account.Location = new System.Drawing.Point(0, 0);
            this.pnl_add_account.Name = "pnl_add_account";
            this.pnl_add_account.Size = new System.Drawing.Size(1048, 523);
            this.pnl_add_account.TabIndex = 0;
            // 
            // btn_add_account
            // 
            this.btn_add_account.BackgroundImage = global::Fireon.Properties.Resources.btn_add_active;
            this.btn_add_account.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_add_account.FlatAppearance.BorderSize = 0;
            this.btn_add_account.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_account.Location = new System.Drawing.Point(570, 449);
            this.btn_add_account.Name = "btn_add_account";
            this.btn_add_account.Size = new System.Drawing.Size(114, 25);
            this.btn_add_account.TabIndex = 258;
            this.btn_add_account.TabStop = false;
            this.btn_add_account.UseVisualStyleBackColor = true;
            this.btn_add_account.Click += new System.EventHandler(this.btn_cancel_add_account_Click_1);
            // 
            // btn_cancel_add_account
            // 
            this.btn_cancel_add_account.BackgroundImage = global::Fireon.Properties.Resources.btn_cancel;
            this.btn_cancel_add_account.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_cancel_add_account.FlatAppearance.BorderSize = 0;
            this.btn_cancel_add_account.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel_add_account.Location = new System.Drawing.Point(450, 449);
            this.btn_cancel_add_account.Name = "btn_cancel_add_account";
            this.btn_cancel_add_account.Size = new System.Drawing.Size(114, 25);
            this.btn_cancel_add_account.TabIndex = 258;
            this.btn_cancel_add_account.TabStop = false;
            this.btn_cancel_add_account.UseVisualStyleBackColor = true;
            this.btn_cancel_add_account.Click += new System.EventHandler(this.btn_cancel_add_account_Click_1);
            // 
            // txtbx_username
            // 
            this.txtbx_username.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbx_username.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_username.Location = new System.Drawing.Point(340, 235);
            this.txtbx_username.MaxLength = 15;
            this.txtbx_username.Name = "txtbx_username";
            this.txtbx_username.Size = new System.Drawing.Size(344, 25);
            this.txtbx_username.TabIndex = 257;
            this.txtbx_username.Text = "Username";
            // 
            // btn_see_new_pw
            // 
            this.btn_see_new_pw.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_see_new_pw.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_see_new_pw.BackColor = System.Drawing.Color.Transparent;
            this.btn_see_new_pw.CausesValidation = false;
            this.btn_see_new_pw.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_see_new_pw.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btn_see_new_pw.ErrorImage")));
            this.btn_see_new_pw.Image = global::Fireon.Properties.Resources.btn_eye;
            this.btn_see_new_pw.ImageHover = global::Fireon.Properties.Resources.btn_eye_hover;
            this.btn_see_new_pw.InitialImage = null;
            this.btn_see_new_pw.Location = new System.Drawing.Point(657, 341);
            this.btn_see_new_pw.Name = "btn_see_new_pw";
            this.btn_see_new_pw.Size = new System.Drawing.Size(27, 25);
            this.btn_see_new_pw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_see_new_pw.TabIndex = 255;
            this.btn_see_new_pw.Zoom = 0;
            // 
            // btn_see_current_pw
            // 
            this.btn_see_current_pw.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_see_current_pw.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_see_current_pw.BackColor = System.Drawing.Color.Transparent;
            this.btn_see_current_pw.CausesValidation = false;
            this.btn_see_current_pw.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_see_current_pw.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btn_see_current_pw.ErrorImage")));
            this.btn_see_current_pw.Image = global::Fireon.Properties.Resources.btn_eye;
            this.btn_see_current_pw.ImageHover = global::Fireon.Properties.Resources.btn_eye_hover;
            this.btn_see_current_pw.InitialImage = null;
            this.btn_see_current_pw.Location = new System.Drawing.Point(657, 288);
            this.btn_see_current_pw.Name = "btn_see_current_pw";
            this.btn_see_current_pw.Size = new System.Drawing.Size(27, 25);
            this.btn_see_current_pw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_see_current_pw.TabIndex = 256;
            this.btn_see_current_pw.Zoom = 0;
            // 
            // lbl_add_account
            // 
            this.lbl_add_account.AutoSize = true;
            this.lbl_add_account.BackColor = System.Drawing.Color.Transparent;
            this.lbl_add_account.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_add_account.Font = new System.Drawing.Font("Open Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_add_account.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_add_account.Location = new System.Drawing.Point(0, 0);
            this.lbl_add_account.Name = "lbl_add_account";
            this.lbl_add_account.Padding = new System.Windows.Forms.Padding(30, 30, 0, 0);
            this.lbl_add_account.Size = new System.Drawing.Size(196, 63);
            this.lbl_add_account.TabIndex = 251;
            this.lbl_add_account.Text = "Add Account";
            // 
            // lbl_user_type
            // 
            this.lbl_user_type.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_user_type.AutoSize = true;
            this.lbl_user_type.BackColor = System.Drawing.Color.White;
            this.lbl_user_type.Font = new System.Drawing.Font("Open Sans SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user_type.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_user_type.Location = new System.Drawing.Point(456, 180);
            this.lbl_user_type.Name = "lbl_user_type";
            this.lbl_user_type.Size = new System.Drawing.Size(112, 18);
            this.lbl_user_type.TabIndex = 246;
            this.lbl_user_type.Text = "Payroll Manager";
            // 
            // lbl_user_name
            // 
            this.lbl_user_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_user_name.AutoSize = true;
            this.lbl_user_name.BackColor = System.Drawing.Color.White;
            this.lbl_user_name.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_user_name.Location = new System.Drawing.Point(461, 160);
            this.lbl_user_name.Name = "lbl_user_name";
            this.lbl_user_name.Size = new System.Drawing.Size(102, 22);
            this.lbl_user_name.TabIndex = 247;
            this.lbl_user_name.Text = "John B. Doe";
            // 
            // picb_user_add_account
            // 
            this.picb_user_add_account.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picb_user_add_account.BackColor = System.Drawing.Color.White;
            this.picb_user_add_account.BackgroundImage = global::Fireon.Properties.Resources.picb_add_account;
            this.picb_user_add_account.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picb_user_add_account.Location = new System.Drawing.Point(472, 72);
            this.picb_user_add_account.Name = "picb_user_add_account";
            this.picb_user_add_account.Size = new System.Drawing.Size(80, 80);
            this.picb_user_add_account.TabIndex = 240;
            this.picb_user_add_account.TabStop = false;
            // 
            // txtbx_confirm_pw
            // 
            this.txtbx_confirm_pw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbx_confirm_pw.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_confirm_pw.Location = new System.Drawing.Point(340, 341);
            this.txtbx_confirm_pw.MaxLength = 15;
            this.txtbx_confirm_pw.Name = "txtbx_confirm_pw";
            this.txtbx_confirm_pw.Size = new System.Drawing.Size(344, 25);
            this.txtbx_confirm_pw.TabIndex = 257;
            this.txtbx_confirm_pw.Text = "Confirm Password";
            // 
            // txtbx_pw
            // 
            this.txtbx_pw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbx_pw.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_pw.Location = new System.Drawing.Point(340, 288);
            this.txtbx_pw.MaxLength = 15;
            this.txtbx_pw.Name = "txtbx_pw";
            this.txtbx_pw.Size = new System.Drawing.Size(344, 25);
            this.txtbx_pw.TabIndex = 257;
            this.txtbx_pw.Text = "Password";
            // 
            // Settings_Add_Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.pnl_add_account);
            this.DoubleBuffered = true;
            this.Name = "Settings_Add_Account";
            this.Size = new System.Drawing.Size(1048, 523);
            this.pnl_add_account.ResumeLayout(false);
            this.pnl_add_account.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picb_user_add_account)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_add_account;
        private System.Windows.Forms.Label lbl_user_type;
        private System.Windows.Forms.Label lbl_user_name;
        private System.Windows.Forms.PictureBox picb_user_add_account;
        private System.Windows.Forms.Label lbl_add_account;
        private JImageButton.JImageButton btn_see_new_pw;
        private JImageButton.JImageButton btn_see_current_pw;
        private System.Windows.Forms.TextBox txtbx_username;
        private System.Windows.Forms.TextBox txtbx_pw;
        private System.Windows.Forms.TextBox txtbx_confirm_pw;
        private System.Windows.Forms.Button btn_cancel_add_account;
        private System.Windows.Forms.Button btn_add_account;


    }
}
