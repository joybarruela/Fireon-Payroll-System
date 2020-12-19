namespace Fireon
{
    partial class ucUpdateNotification
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
            this.tblpnlUpdateNotif = new System.Windows.Forms.TableLayoutPanel();
            this.flpnlButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlBlocker = new System.Windows.Forms.Panel();
            this.btnUpdateNotif = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlUpdateNotif = new System.Windows.Forms.Panel();
            this.txtbxDescription = new System.Windows.Forms.TextBox();
            this.dtpTimeDateNotif = new System.Windows.Forms.DateTimePicker();
            this.lblChooseTimeDate = new System.Windows.Forms.Label();
            this.tblpnlUpdateNotif.SuspendLayout();
            this.flpnlButtons.SuspendLayout();
            this.pnlUpdateNotif.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblpnlUpdateNotif
            // 
            this.tblpnlUpdateNotif.ColumnCount = 1;
            this.tblpnlUpdateNotif.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblpnlUpdateNotif.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblpnlUpdateNotif.Controls.Add(this.flpnlButtons, 0, 1);
            this.tblpnlUpdateNotif.Controls.Add(this.pnlUpdateNotif, 0, 0);
            this.tblpnlUpdateNotif.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblpnlUpdateNotif.Location = new System.Drawing.Point(0, 0);
            this.tblpnlUpdateNotif.Name = "tblpnlUpdateNotif";
            this.tblpnlUpdateNotif.RowCount = 3;
            this.tblpnlUpdateNotif.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.78313F));
            this.tblpnlUpdateNotif.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.879519F));
            this.tblpnlUpdateNotif.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.337349F));
            this.tblpnlUpdateNotif.Size = new System.Drawing.Size(886, 416);
            this.tblpnlUpdateNotif.TabIndex = 317;
            // 
            // flpnlButtons
            // 
            this.flpnlButtons.Controls.Add(this.pnlBlocker);
            this.flpnlButtons.Controls.Add(this.btnUpdateNotif);
            this.flpnlButtons.Controls.Add(this.btnCancel);
            this.flpnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpnlButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpnlButtons.Location = new System.Drawing.Point(3, 360);
            this.flpnlButtons.Name = "flpnlButtons";
            this.flpnlButtons.Size = new System.Drawing.Size(880, 34);
            this.flpnlButtons.TabIndex = 315;
            // 
            // pnlBlocker
            // 
            this.pnlBlocker.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlBlocker.Location = new System.Drawing.Point(614, 3);
            this.pnlBlocker.Name = "pnlBlocker";
            this.pnlBlocker.Size = new System.Drawing.Size(263, 30);
            this.pnlBlocker.TabIndex = 321;
            // 
            // btnUpdateNotif
            // 
            this.btnUpdateNotif.BackgroundImage = global::Fireon.Properties.Resources.btnUpdateActive;
            this.btnUpdateNotif.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUpdateNotif.FlatAppearance.BorderSize = 0;
            this.btnUpdateNotif.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnUpdateNotif.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateNotif.Location = new System.Drawing.Point(484, 3);
            this.btnUpdateNotif.Name = "btnUpdateNotif";
            this.btnUpdateNotif.Size = new System.Drawing.Size(124, 30);
            this.btnUpdateNotif.TabIndex = 319;
            this.btnUpdateNotif.TabStop = false;
            this.btnUpdateNotif.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = global::Fireon.Properties.Resources.btnCancel;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(354, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(124, 30);
            this.btnCancel.TabIndex = 320;
            this.btnCancel.TabStop = false;
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // pnlUpdateNotif
            // 
            this.pnlUpdateNotif.Controls.Add(this.txtbxDescription);
            this.pnlUpdateNotif.Controls.Add(this.dtpTimeDateNotif);
            this.pnlUpdateNotif.Controls.Add(this.lblChooseTimeDate);
            this.pnlUpdateNotif.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUpdateNotif.Location = new System.Drawing.Point(3, 3);
            this.pnlUpdateNotif.Name = "pnlUpdateNotif";
            this.pnlUpdateNotif.Size = new System.Drawing.Size(880, 350);
            this.pnlUpdateNotif.TabIndex = 0;
            // 
            // txtbxDescription
            // 
            this.txtbxDescription.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxDescription.Location = new System.Drawing.Point(52, 69);
            this.txtbxDescription.MaxLength = 200;
            this.txtbxDescription.Multiline = true;
            this.txtbxDescription.Name = "txtbxDescription";
            this.txtbxDescription.Size = new System.Drawing.Size(779, 121);
            this.txtbxDescription.TabIndex = 245;
            this.txtbxDescription.TabStop = false;
            this.txtbxDescription.Text = "Description";
            // 
            // dtpTimeDateNotif
            // 
            this.dtpTimeDateNotif.CustomFormat = "MMMM dd, yyy hh:mm tt";
            this.dtpTimeDateNotif.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTimeDateNotif.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTimeDateNotif.Location = new System.Drawing.Point(52, 256);
            this.dtpTimeDateNotif.MaxDate = new System.DateTime(2133, 5, 26, 0, 0, 0, 0);
            this.dtpTimeDateNotif.MinDate = new System.DateTime(2020, 11, 20, 0, 0, 0, 0);
            this.dtpTimeDateNotif.Name = "dtpTimeDateNotif";
            this.dtpTimeDateNotif.Size = new System.Drawing.Size(314, 25);
            this.dtpTimeDateNotif.TabIndex = 247;
            // 
            // lblChooseTimeDate
            // 
            this.lblChooseTimeDate.AutoSize = true;
            this.lblChooseTimeDate.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChooseTimeDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(99)))), ((int)(((byte)(5)))));
            this.lblChooseTimeDate.Location = new System.Drawing.Point(49, 228);
            this.lblChooseTimeDate.Name = "lblChooseTimeDate";
            this.lblChooseTimeDate.Size = new System.Drawing.Size(317, 18);
            this.lblChooseTimeDate.TabIndex = 246;
            this.lblChooseTimeDate.Text = "Choose time and date to schedule your notification.";
            // 
            // ucUpdateNotification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tblpnlUpdateNotif);
            this.Name = "ucUpdateNotification";
            this.Size = new System.Drawing.Size(886, 416);
            this.tblpnlUpdateNotif.ResumeLayout(false);
            this.flpnlButtons.ResumeLayout(false);
            this.pnlUpdateNotif.ResumeLayout(false);
            this.pnlUpdateNotif.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblpnlUpdateNotif;
        private System.Windows.Forms.FlowLayoutPanel flpnlButtons;
        private System.Windows.Forms.Panel pnlBlocker;
        private System.Windows.Forms.Button btnUpdateNotif;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel pnlUpdateNotif;
        private System.Windows.Forms.TextBox txtbxDescription;
        private System.Windows.Forms.DateTimePicker dtpTimeDateNotif;
        private System.Windows.Forms.Label lblChooseTimeDate;

    }
}
