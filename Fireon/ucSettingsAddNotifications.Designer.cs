namespace Fireon
{
    partial class Settings_Add_Notifications
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
            this.lbl_choose_time_date = new System.Windows.Forms.Label();
            this.lbl_add_notification = new System.Windows.Forms.Label();
            this.dtp_add_notif = new System.Windows.Forms.DateTimePicker();
            this.txtbx_description = new System.Windows.Forms.TextBox();
            this.btn_add_notif = new System.Windows.Forms.Button();
            this.btn_cancel_add_notif = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_choose_time_date
            // 
            this.lbl_choose_time_date.AutoSize = true;
            this.lbl_choose_time_date.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_choose_time_date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(99)))), ((int)(((byte)(5)))));
            this.lbl_choose_time_date.Location = new System.Drawing.Point(66, 228);
            this.lbl_choose_time_date.Name = "lbl_choose_time_date";
            this.lbl_choose_time_date.Size = new System.Drawing.Size(317, 18);
            this.lbl_choose_time_date.TabIndex = 224;
            this.lbl_choose_time_date.Text = "Choose time and date to schedule your notification.";
            // 
            // lbl_add_notification
            // 
            this.lbl_add_notification.AutoSize = true;
            this.lbl_add_notification.BackColor = System.Drawing.Color.Transparent;
            this.lbl_add_notification.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_add_notification.Font = new System.Drawing.Font("Open Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_add_notification.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_add_notification.Location = new System.Drawing.Point(0, 0);
            this.lbl_add_notification.Name = "lbl_add_notification";
            this.lbl_add_notification.Padding = new System.Windows.Forms.Padding(30, 30, 0, 0);
            this.lbl_add_notification.Size = new System.Drawing.Size(241, 63);
            this.lbl_add_notification.TabIndex = 1;
            this.lbl_add_notification.Text = "Add Notification";
            // 
            // dtp_add_notif
            // 
            this.dtp_add_notif.CustomFormat = "MMMM dd, yyy hh:mm tt";
            this.dtp_add_notif.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_add_notif.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_add_notif.Location = new System.Drawing.Point(69, 256);
            this.dtp_add_notif.MaxDate = new System.DateTime(2133, 5, 26, 0, 0, 0, 0);
            this.dtp_add_notif.MinDate = new System.DateTime(2020, 11, 20, 0, 0, 0, 0);
            this.dtp_add_notif.Name = "dtp_add_notif";
            this.dtp_add_notif.Size = new System.Drawing.Size(314, 25);
            this.dtp_add_notif.TabIndex = 244;
            // 
            // txtbx_description
            // 
            this.txtbx_description.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_description.Location = new System.Drawing.Point(69, 91);
            this.txtbx_description.MaxLength = 200;
            this.txtbx_description.Multiline = true;
            this.txtbx_description.Name = "txtbx_description";
            this.txtbx_description.Size = new System.Drawing.Size(577, 121);
            this.txtbx_description.TabIndex = 1;
            this.txtbx_description.Text = "Description";
            // 
            // btn_add_notif
            // 
            this.btn_add_notif.BackgroundImage = global::Fireon.Properties.Resources.btn_add_active;
            this.btn_add_notif.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_add_notif.FlatAppearance.BorderSize = 0;
            this.btn_add_notif.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_notif.Location = new System.Drawing.Point(532, 349);
            this.btn_add_notif.Name = "btn_add_notif";
            this.btn_add_notif.Size = new System.Drawing.Size(114, 25);
            this.btn_add_notif.TabIndex = 259;
            this.btn_add_notif.TabStop = false;
            this.btn_add_notif.UseVisualStyleBackColor = true;
            // 
            // btn_cancel_add_notif
            // 
            this.btn_cancel_add_notif.BackgroundImage = global::Fireon.Properties.Resources.btn_cancel;
            this.btn_cancel_add_notif.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_cancel_add_notif.FlatAppearance.BorderSize = 0;
            this.btn_cancel_add_notif.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel_add_notif.Location = new System.Drawing.Point(412, 349);
            this.btn_cancel_add_notif.Name = "btn_cancel_add_notif";
            this.btn_cancel_add_notif.Size = new System.Drawing.Size(114, 25);
            this.btn_cancel_add_notif.TabIndex = 260;
            this.btn_cancel_add_notif.TabStop = false;
            this.btn_cancel_add_notif.UseVisualStyleBackColor = true;
            // 
            // Settings_Add_Notifications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.btn_add_notif);
            this.Controls.Add(this.btn_cancel_add_notif);
            this.Controls.Add(this.txtbx_description);
            this.Controls.Add(this.dtp_add_notif);
            this.Controls.Add(this.lbl_add_notification);
            this.Controls.Add(this.lbl_choose_time_date);
            this.DoubleBuffered = true;
            this.Name = "Settings_Add_Notifications";
            this.Size = new System.Drawing.Size(738, 413);
            this.Load += new System.EventHandler(this.Settings_Add_Notifications_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_choose_time_date;
        private System.Windows.Forms.Label lbl_add_notification;
        private System.Windows.Forms.DateTimePicker dtp_add_notif;
        private System.Windows.Forms.TextBox txtbx_description;
        private System.Windows.Forms.Button btn_add_notif;
        private System.Windows.Forms.Button btn_cancel_add_notif;
    }
}
