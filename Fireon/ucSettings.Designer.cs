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
            this.lbl_settings = new System.Windows.Forms.Label();
            this.btn_accounts = new System.Windows.Forms.Button();
            this.btn_notifications = new System.Windows.Forms.Button();
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
            // btn_accounts
            // 
            this.btn_accounts.BackgroundImage = global::Fireon.Properties.Resources.btn_accounts;
            this.btn_accounts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_accounts.FlatAppearance.BorderSize = 0;
            this.btn_accounts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_accounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_accounts.Location = new System.Drawing.Point(181, 231);
            this.btn_accounts.Name = "btn_accounts";
            this.btn_accounts.Size = new System.Drawing.Size(346, 167);
            this.btn_accounts.TabIndex = 225;
            this.btn_accounts.TabStop = false;
            this.btn_accounts.UseVisualStyleBackColor = true;
            this.btn_accounts.Click += new System.EventHandler(this.btn_accounts_Click);
            // 
            // btn_notifications
            // 
            this.btn_notifications.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_notifications.BackgroundImage = global::Fireon.Properties.Resources.btn_notifications;
            this.btn_notifications.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_notifications.FlatAppearance.BorderSize = 0;
            this.btn_notifications.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_notifications.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_notifications.Location = new System.Drawing.Point(518, 231);
            this.btn_notifications.Name = "btn_notifications";
            this.btn_notifications.Size = new System.Drawing.Size(346, 167);
            this.btn_notifications.TabIndex = 225;
            this.btn_notifications.TabStop = false;
            this.btn_notifications.UseVisualStyleBackColor = true;
            this.btn_notifications.Click += new System.EventHandler(this.btn_notifications_Click);
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
            this.Controls.Add(this.btn_notifications);
            this.Controls.Add(this.btn_accounts);
            this.Controls.Add(this.uc_setting_notifications);
            this.Controls.Add(this.uc_setting_accounts);
            this.Controls.Add(this.lbl_settings);
            this.Name = "ucSettings";
            this.Size = new System.Drawing.Size(1060, 680);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_settings;
        private Setting_Accounts uc_setting_accounts;
        private Setting_Notifications uc_setting_notifications;
        private System.Windows.Forms.Button btn_accounts;
        private System.Windows.Forms.Button btn_notifications;
    }
}
