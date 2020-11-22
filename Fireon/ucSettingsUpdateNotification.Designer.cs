namespace Fireon
{
    partial class Settings_Update_Notification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings_Update_Notification));
            this.lbl_update_notification = new System.Windows.Forms.Label();
            this.lbl_choose_time_date = new System.Windows.Forms.Label();
            this.dtp_update_notif = new System.Windows.Forms.DateTimePicker();
            this.txtbx_description = new System.Windows.Forms.TextBox();
            this.btn_update_notif = new System.Windows.Forms.Button();
            this.btn_cancel_update_notif = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_update_notification
            // 
            this.lbl_update_notification.AutoSize = true;
            this.lbl_update_notification.BackColor = System.Drawing.Color.Transparent;
            this.lbl_update_notification.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_update_notification.Font = new System.Drawing.Font("Open Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_update_notification.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_update_notification.Location = new System.Drawing.Point(0, 0);
            this.lbl_update_notification.Name = "lbl_update_notification";
            this.lbl_update_notification.Padding = new System.Windows.Forms.Padding(30, 30, 0, 0);
            this.lbl_update_notification.Size = new System.Drawing.Size(280, 63);
            this.lbl_update_notification.TabIndex = 237;
            this.lbl_update_notification.Text = "Update Notification";
            // 
            // lbl_choose_time_date
            // 
            this.lbl_choose_time_date.AutoSize = true;
            this.lbl_choose_time_date.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_choose_time_date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(99)))), ((int)(((byte)(5)))));
            this.lbl_choose_time_date.Location = new System.Drawing.Point(66, 228);
            this.lbl_choose_time_date.Name = "lbl_choose_time_date";
            this.lbl_choose_time_date.Size = new System.Drawing.Size(317, 18);
            this.lbl_choose_time_date.TabIndex = 242;
            this.lbl_choose_time_date.Text = "Choose time and date to schedule your notification.";
            // 
            // dtp_update_notif
            // 
            this.dtp_update_notif.CustomFormat = "MMMM dd, yyy hh:mm tt";
            this.dtp_update_notif.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_update_notif.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_update_notif.Location = new System.Drawing.Point(69, 256);
            this.dtp_update_notif.MaxDate = new System.DateTime(2133, 5, 26, 0, 0, 0, 0);
            this.dtp_update_notif.MinDate = new System.DateTime(2020, 11, 20, 0, 0, 0, 0);
            this.dtp_update_notif.Name = "dtp_update_notif";
            this.dtp_update_notif.Size = new System.Drawing.Size(314, 25);
            this.dtp_update_notif.TabIndex = 245;
            // 
            // txtbx_description
            // 
            this.txtbx_description.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_description.Location = new System.Drawing.Point(69, 91);
            this.txtbx_description.MaxLength = 200;
            this.txtbx_description.Multiline = true;
            this.txtbx_description.Name = "txtbx_description";
            this.txtbx_description.Size = new System.Drawing.Size(577, 121);
            this.txtbx_description.TabIndex = 246;
            this.txtbx_description.Text = "Description";
            // 
            // btn_update_notif
            // 
            this.btn_update_notif.BackgroundImage = global::Fireon.Properties.Resources.btn_update_notif;
            this.btn_update_notif.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_update_notif.FlatAppearance.BorderSize = 0;
            this.btn_update_notif.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update_notif.Location = new System.Drawing.Point(541, 349);
            this.btn_update_notif.Name = "btn_update_notif";
            this.btn_update_notif.Size = new System.Drawing.Size(114, 25);
            this.btn_update_notif.TabIndex = 263;
            this.btn_update_notif.TabStop = false;
            this.btn_update_notif.UseVisualStyleBackColor = true;
            // 
            // btn_cancel_update_notif
            // 
            this.btn_cancel_update_notif.BackgroundImage = global::Fireon.Properties.Resources.btn_cancel;
            this.btn_cancel_update_notif.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_cancel_update_notif.FlatAppearance.BorderSize = 0;
            this.btn_cancel_update_notif.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel_update_notif.Location = new System.Drawing.Point(424, 349);
            this.btn_cancel_update_notif.Name = "btn_cancel_update_notif";
            this.btn_cancel_update_notif.Size = new System.Drawing.Size(114, 25);
            this.btn_cancel_update_notif.TabIndex = 264;
            this.btn_cancel_update_notif.TabStop = false;
            this.btn_cancel_update_notif.UseVisualStyleBackColor = true;
            // 
            // Settings_Update_Notification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Controls.Add(this.btn_update_notif);
            this.Controls.Add(this.btn_cancel_update_notif);
            this.Controls.Add(this.txtbx_description);
            this.Controls.Add(this.dtp_update_notif);
            this.Controls.Add(this.lbl_choose_time_date);
            this.Controls.Add(this.lbl_update_notification);
            this.DoubleBuffered = true;
            this.Name = "Settings_Update_Notification";
            this.Size = new System.Drawing.Size(738, 413);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_update_notification;
        private System.Windows.Forms.Label lbl_choose_time_date;
        private System.Windows.Forms.DateTimePicker dtp_update_notif;
        private System.Windows.Forms.TextBox txtbx_description;
        private System.Windows.Forms.Button btn_update_notif;
        private System.Windows.Forms.Button btn_cancel_update_notif;
    }
}
