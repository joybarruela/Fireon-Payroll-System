namespace Fireon
{
    partial class ucSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucSettings));
            this.lbl_settings = new System.Windows.Forms.Label();
            this.btn_notifications = new JImageButton.JImageButton();
            this.btn_accounts = new JImageButton.JImageButton();
            this.uc_setting_notifications = new Fireon.Setting_Notifications();
            this.uc_setting_accounts = new Fireon.Setting_Accounts();
            this.SuspendLayout();
            // 
            // lbl_settings
            // 
            this.lbl_settings.AutoSize = true;
            this.lbl_settings.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_settings.Font = new System.Drawing.Font("Open Sans", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_settings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_settings.Location = new System.Drawing.Point(0, 0);
            this.lbl_settings.Name = "lbl_settings";
            this.lbl_settings.Padding = new System.Windows.Forms.Padding(30, 30, 0, 10);
            this.lbl_settings.Size = new System.Drawing.Size(179, 83);
            this.lbl_settings.TabIndex = 205;
            this.lbl_settings.Text = "Settings";
            // 
            // btn_notifications
            // 
            this.btn_notifications.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_notifications.BackColor = System.Drawing.Color.Transparent;
            this.btn_notifications.CausesValidation = false;
            this.btn_notifications.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_notifications.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btn_notifications.ErrorImage")));
            this.btn_notifications.Image = global::Fireon.Properties.Resources.btn_notifications;
            this.btn_notifications.ImageHover = global::Fireon.Properties.Resources.btn_notifications_hover;
            this.btn_notifications.InitialImage = null;
            this.btn_notifications.Location = new System.Drawing.Point(523, 231);
            this.btn_notifications.Name = "btn_notifications";
            this.btn_notifications.Size = new System.Drawing.Size(346, 167);
            this.btn_notifications.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_notifications.TabIndex = 221;
            this.btn_notifications.Zoom = 0;
            this.btn_notifications.Click += new System.EventHandler(this.btn_notifications_Click);
            // 
            // btn_accounts
            // 
            this.btn_accounts.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_accounts.BackColor = System.Drawing.Color.Transparent;
            this.btn_accounts.CausesValidation = false;
            this.btn_accounts.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_accounts.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btn_accounts.ErrorImage")));
            this.btn_accounts.Image = global::Fireon.Properties.Resources.btn_accounts;
            this.btn_accounts.ImageHover = global::Fireon.Properties.Resources.btn_accounts_hover;
            this.btn_accounts.InitialImage = null;
            this.btn_accounts.Location = new System.Drawing.Point(180, 231);
            this.btn_accounts.Name = "btn_accounts";
            this.btn_accounts.Size = new System.Drawing.Size(346, 167);
            this.btn_accounts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_accounts.TabIndex = 222;
            this.btn_accounts.Zoom = 0;
            this.btn_accounts.Click += new System.EventHandler(this.btn_accounts_Click);
            // 
            // uc_setting_notifications
            // 
            this.uc_setting_notifications.BackColor = System.Drawing.Color.White;
            this.uc_setting_notifications.Location = new System.Drawing.Point(19, 546);
            this.uc_setting_notifications.Name = "uc_setting_notifications";
            this.uc_setting_notifications.Size = new System.Drawing.Size(1060, 680);
            this.uc_setting_notifications.TabIndex = 224;
            this.uc_setting_notifications.Visible = false;
            // 
            // uc_setting_accounts
            // 
            this.uc_setting_accounts.BackColor = System.Drawing.Color.White;
            this.uc_setting_accounts.Location = new System.Drawing.Point(0, 480);
            this.uc_setting_accounts.Name = "uc_setting_accounts";
            this.uc_setting_accounts.Size = new System.Drawing.Size(1060, 680);
            this.uc_setting_accounts.TabIndex = 223;
            this.uc_setting_accounts.Visible = false;
            // 
            // ucSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.uc_setting_notifications);
            this.Controls.Add(this.uc_setting_accounts);
            this.Controls.Add(this.btn_notifications);
            this.Controls.Add(this.btn_accounts);
            this.Controls.Add(this.lbl_settings);
            this.Name = "ucSettings";
            this.Size = new System.Drawing.Size(1060, 680);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_settings;
        private JImageButton.JImageButton btn_notifications;
        private JImageButton.JImageButton btn_accounts;
        private Setting_Accounts uc_setting_accounts;
        private Setting_Notifications uc_setting_notifications;
    }
}
