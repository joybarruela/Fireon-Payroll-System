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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucSettings));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblSettings = new System.Windows.Forms.Label();
            this.tctrlAddAccount = new System.Windows.Forms.TabControl();
            this.tabAccount = new System.Windows.Forms.TabPage();
            this.tblpAccount = new System.Windows.Forms.TableLayoutPanel();
            this.txtbxSearchAccount = new System.Windows.Forms.TextBox();
            this.dtgvAccounts = new System.Windows.Forms.DataGridView();
            this.flpnlButtonsAccount = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.btnUpdateAccount = new System.Windows.Forms.Button();
            this.tabNotification = new System.Windows.Forms.TabPage();
            this.tblpNotification = new System.Windows.Forms.TableLayoutPanel();
            this.txtbxSearchNotification = new System.Windows.Forms.TextBox();
            this.dtgvNotifications = new System.Windows.Forms.DataGridView();
            this.flpnlButtonsNotification = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddNotification = new System.Windows.Forms.Button();
            this.btnUpdateNotification = new System.Windows.Forms.Button();
            this.tctrlAddAccount.SuspendLayout();
            this.tabAccount.SuspendLayout();
            this.tblpAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccounts)).BeginInit();
            this.flpnlButtonsAccount.SuspendLayout();
            this.tabNotification.SuspendLayout();
            this.tblpNotification.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNotifications)).BeginInit();
            this.flpnlButtonsNotification.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSettings
            // 
            this.lblSettings.AutoSize = true;
            this.lblSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSettings.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSettings.Location = new System.Drawing.Point(0, 0);
            this.lblSettings.Margin = new System.Windows.Forms.Padding(0);
            this.lblSettings.Name = "lblSettings";
            this.lblSettings.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lblSettings.Size = new System.Drawing.Size(136, 48);
            this.lblSettings.TabIndex = 140;
            this.lblSettings.Text = "Settings";
            // 
            // tctrlAddAccount
            // 
            this.tctrlAddAccount.Controls.Add(this.tabAccount);
            this.tctrlAddAccount.Controls.Add(this.tabNotification);
            this.tctrlAddAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tctrlAddAccount.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tctrlAddAccount.Location = new System.Drawing.Point(0, 48);
            this.tctrlAddAccount.Name = "tctrlAddAccount";
            this.tctrlAddAccount.SelectedIndex = 0;
            this.tctrlAddAccount.Size = new System.Drawing.Size(900, 452);
            this.tctrlAddAccount.TabIndex = 141;
            // 
            // tabAccount
            // 
            this.tabAccount.Controls.Add(this.tblpAccount);
            this.tabAccount.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabAccount.Location = new System.Drawing.Point(4, 26);
            this.tabAccount.Name = "tabAccount";
            this.tabAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tabAccount.Size = new System.Drawing.Size(892, 422);
            this.tabAccount.TabIndex = 0;
            this.tabAccount.Text = "Account";
            this.tabAccount.UseVisualStyleBackColor = true;
            // 
            // tblpAccount
            // 
            this.tblpAccount.ColumnCount = 1;
            this.tblpAccount.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblpAccount.Controls.Add(this.txtbxSearchAccount, 0, 0);
            this.tblpAccount.Controls.Add(this.dtgvAccounts, 0, 1);
            this.tblpAccount.Controls.Add(this.flpnlButtonsAccount, 0, 2);
            this.tblpAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblpAccount.Location = new System.Drawing.Point(3, 3);
            this.tblpAccount.Name = "tblpAccount";
            this.tblpAccount.RowCount = 4;
            this.tblpAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.962103F));
            this.tblpAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.23351F));
            this.tblpAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.898478F));
            this.tblpAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tblpAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblpAccount.Size = new System.Drawing.Size(886, 416);
            this.tblpAccount.TabIndex = 2;
            // 
            // txtbxSearchAccount
            // 
            this.txtbxSearchAccount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxSearchAccount.Location = new System.Drawing.Point(3, 3);
            this.txtbxSearchAccount.Name = "txtbxSearchAccount";
            this.txtbxSearchAccount.Size = new System.Drawing.Size(199, 27);
            this.txtbxSearchAccount.TabIndex = 229;
            this.txtbxSearchAccount.TabStop = false;
            this.txtbxSearchAccount.Text = "Search";
            // 
            // dtgvAccounts
            // 
            this.dtgvAccounts.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(5)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvAccounts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(5)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvAccounts.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvAccounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvAccounts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dtgvAccounts.Location = new System.Drawing.Point(3, 34);
            this.dtgvAccounts.Name = "dtgvAccounts";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(5)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvAccounts.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvAccounts.Size = new System.Drawing.Size(880, 318);
            this.dtgvAccounts.TabIndex = 230;
            // 
            // flpnlButtonsAccount
            // 
            this.flpnlButtonsAccount.Controls.Add(this.btnAddAccount);
            this.flpnlButtonsAccount.Controls.Add(this.btnUpdateAccount);
            this.flpnlButtonsAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpnlButtonsAccount.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpnlButtonsAccount.Location = new System.Drawing.Point(3, 358);
            this.flpnlButtonsAccount.Name = "flpnlButtonsAccount";
            this.flpnlButtonsAccount.Size = new System.Drawing.Size(880, 33);
            this.flpnlButtonsAccount.TabIndex = 231;
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddAccount.BackgroundImage")));
            this.btnAddAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddAccount.FlatAppearance.BorderSize = 0;
            this.btnAddAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnAddAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAccount.Location = new System.Drawing.Point(753, 3);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(124, 28);
            this.btnAddAccount.TabIndex = 6;
            this.btnAddAccount.TabStop = false;
            this.btnAddAccount.UseVisualStyleBackColor = true;
            // 
            // btnUpdateAccount
            // 
            this.btnUpdateAccount.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdateAccount.BackgroundImage")));
            this.btnUpdateAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUpdateAccount.FlatAppearance.BorderSize = 0;
            this.btnUpdateAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnUpdateAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateAccount.Location = new System.Drawing.Point(623, 3);
            this.btnUpdateAccount.Name = "btnUpdateAccount";
            this.btnUpdateAccount.Size = new System.Drawing.Size(124, 28);
            this.btnUpdateAccount.TabIndex = 7;
            this.btnUpdateAccount.TabStop = false;
            this.btnUpdateAccount.UseVisualStyleBackColor = true;
            // 
            // tabNotification
            // 
            this.tabNotification.Controls.Add(this.tblpNotification);
            this.tabNotification.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabNotification.Location = new System.Drawing.Point(4, 26);
            this.tabNotification.Name = "tabNotification";
            this.tabNotification.Padding = new System.Windows.Forms.Padding(3);
            this.tabNotification.Size = new System.Drawing.Size(892, 422);
            this.tabNotification.TabIndex = 1;
            this.tabNotification.Text = "Notification";
            this.tabNotification.UseVisualStyleBackColor = true;
            // 
            // tblpNotification
            // 
            this.tblpNotification.ColumnCount = 1;
            this.tblpNotification.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblpNotification.Controls.Add(this.txtbxSearchNotification, 0, 0);
            this.tblpNotification.Controls.Add(this.dtgvNotifications, 0, 1);
            this.tblpNotification.Controls.Add(this.flpnlButtonsNotification, 0, 2);
            this.tblpNotification.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblpNotification.Location = new System.Drawing.Point(3, 3);
            this.tblpNotification.Name = "tblpNotification";
            this.tblpNotification.RowCount = 4;
            this.tblpNotification.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.962103F));
            this.tblpNotification.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.23351F));
            this.tblpNotification.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.898478F));
            this.tblpNotification.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tblpNotification.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblpNotification.Size = new System.Drawing.Size(886, 416);
            this.tblpNotification.TabIndex = 3;
            // 
            // txtbxSearchNotification
            // 
            this.txtbxSearchNotification.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxSearchNotification.Location = new System.Drawing.Point(3, 3);
            this.txtbxSearchNotification.Name = "txtbxSearchNotification";
            this.txtbxSearchNotification.Size = new System.Drawing.Size(199, 27);
            this.txtbxSearchNotification.TabIndex = 229;
            this.txtbxSearchNotification.TabStop = false;
            this.txtbxSearchNotification.Text = "Search";
            // 
            // dtgvNotifications
            // 
            this.dtgvNotifications.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(5)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvNotifications.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgvNotifications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(5)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvNotifications.DefaultCellStyle = dataGridViewCellStyle5;
            this.dtgvNotifications.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvNotifications.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dtgvNotifications.Location = new System.Drawing.Point(3, 34);
            this.dtgvNotifications.Name = "dtgvNotifications";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(5)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvNotifications.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgvNotifications.Size = new System.Drawing.Size(880, 318);
            this.dtgvNotifications.TabIndex = 230;
            // 
            // flpnlButtonsNotification
            // 
            this.flpnlButtonsNotification.Controls.Add(this.btnAddNotification);
            this.flpnlButtonsNotification.Controls.Add(this.btnUpdateNotification);
            this.flpnlButtonsNotification.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpnlButtonsNotification.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpnlButtonsNotification.Location = new System.Drawing.Point(3, 358);
            this.flpnlButtonsNotification.Name = "flpnlButtonsNotification";
            this.flpnlButtonsNotification.Size = new System.Drawing.Size(880, 33);
            this.flpnlButtonsNotification.TabIndex = 231;
            // 
            // btnAddNotification
            // 
            this.btnAddNotification.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddNotification.BackgroundImage")));
            this.btnAddNotification.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddNotification.FlatAppearance.BorderSize = 0;
            this.btnAddNotification.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnAddNotification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNotification.Location = new System.Drawing.Point(753, 3);
            this.btnAddNotification.Name = "btnAddNotification";
            this.btnAddNotification.Size = new System.Drawing.Size(124, 28);
            this.btnAddNotification.TabIndex = 6;
            this.btnAddNotification.TabStop = false;
            this.btnAddNotification.UseVisualStyleBackColor = true;
            // 
            // btnUpdateNotification
            // 
            this.btnUpdateNotification.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdateNotification.BackgroundImage")));
            this.btnUpdateNotification.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUpdateNotification.FlatAppearance.BorderSize = 0;
            this.btnUpdateNotification.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnUpdateNotification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateNotification.Location = new System.Drawing.Point(623, 3);
            this.btnUpdateNotification.Name = "btnUpdateNotification";
            this.btnUpdateNotification.Size = new System.Drawing.Size(124, 28);
            this.btnUpdateNotification.TabIndex = 7;
            this.btnUpdateNotification.TabStop = false;
            this.btnUpdateNotification.UseVisualStyleBackColor = true;
            // 
            // ucSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tctrlAddAccount);
            this.Controls.Add(this.lblSettings);
            this.Name = "ucSettings";
            this.Size = new System.Drawing.Size(900, 500);
            this.tctrlAddAccount.ResumeLayout(false);
            this.tabAccount.ResumeLayout(false);
            this.tblpAccount.ResumeLayout(false);
            this.tblpAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccounts)).EndInit();
            this.flpnlButtonsAccount.ResumeLayout(false);
            this.tabNotification.ResumeLayout(false);
            this.tblpNotification.ResumeLayout(false);
            this.tblpNotification.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNotifications)).EndInit();
            this.flpnlButtonsNotification.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSettings;
        private System.Windows.Forms.TabControl tctrlAddAccount;
        private System.Windows.Forms.TabPage tabAccount;
        private System.Windows.Forms.TabPage tabNotification;
        private System.Windows.Forms.TableLayoutPanel tblpAccount;
        private System.Windows.Forms.TextBox txtbxSearchAccount;
        private System.Windows.Forms.DataGridView dtgvAccounts;
        private System.Windows.Forms.FlowLayoutPanel flpnlButtonsAccount;
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.Button btnUpdateAccount;
        private System.Windows.Forms.TableLayoutPanel tblpNotification;
        private System.Windows.Forms.TextBox txtbxSearchNotification;
        private System.Windows.Forms.DataGridView dtgvNotifications;
        private System.Windows.Forms.FlowLayoutPanel flpnlButtonsNotification;
        private System.Windows.Forms.Button btnAddNotification;
        private System.Windows.Forms.Button btnUpdateNotification;


    }
}
