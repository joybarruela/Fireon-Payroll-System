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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblSettings = new System.Windows.Forms.Label();
            this.tctrlAddAccount = new System.Windows.Forms.TabControl();
            this.tabAccount = new System.Windows.Forms.TabPage();
            this.tblpAddAccount = new System.Windows.Forms.TableLayoutPanel();
            this.pnlBelow = new System.Windows.Forms.Panel();
            this.btnUpdateAccount = new System.Windows.Forms.Button();
            this.pnlSeparator1 = new System.Windows.Forms.Panel();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.txtbx_search = new System.Windows.Forms.TextBox();
            this.dtgvAccounts = new System.Windows.Forms.DataGridView();
            this.tabNotification = new System.Windows.Forms.TabPage();
            this.ucAddAccount1 = new Fireon.ucAddAccount();
            this.tctrlAddAccount.SuspendLayout();
            this.tabAccount.SuspendLayout();
            this.tblpAddAccount.SuspendLayout();
            this.pnlBelow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccounts)).BeginInit();
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
            this.tabAccount.Controls.Add(this.ucAddAccount1);
            this.tabAccount.Controls.Add(this.tblpAddAccount);
            this.tabAccount.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabAccount.Location = new System.Drawing.Point(4, 26);
            this.tabAccount.Name = "tabAccount";
            this.tabAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tabAccount.Size = new System.Drawing.Size(892, 422);
            this.tabAccount.TabIndex = 0;
            this.tabAccount.Text = "Account";
            this.tabAccount.UseVisualStyleBackColor = true;
            // 
            // tblpAddAccount
            // 
            this.tblpAddAccount.ColumnCount = 1;
            this.tblpAddAccount.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblpAddAccount.Controls.Add(this.pnlBelow, 0, 2);
            this.tblpAddAccount.Controls.Add(this.txtbx_search, 0, 0);
            this.tblpAddAccount.Controls.Add(this.dtgvAccounts, 0, 1);
            this.tblpAddAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblpAddAccount.Location = new System.Drawing.Point(3, 3);
            this.tblpAddAccount.Name = "tblpAddAccount";
            this.tblpAddAccount.RowCount = 3;
            this.tblpAddAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.962103F));
            this.tblpAddAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.21098F));
            this.tblpAddAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.826909F));
            this.tblpAddAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblpAddAccount.Size = new System.Drawing.Size(886, 416);
            this.tblpAddAccount.TabIndex = 2;
            // 
            // pnlBelow
            // 
            this.pnlBelow.Controls.Add(this.btnUpdateAccount);
            this.pnlBelow.Controls.Add(this.pnlSeparator1);
            this.pnlBelow.Controls.Add(this.btnAddAccount);
            this.pnlBelow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBelow.Location = new System.Drawing.Point(3, 382);
            this.pnlBelow.Name = "pnlBelow";
            this.pnlBelow.Size = new System.Drawing.Size(880, 31);
            this.pnlBelow.TabIndex = 231;
            // 
            // btnUpdateAccount
            // 
            this.btnUpdateAccount.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdateAccount.BackgroundImage")));
            this.btnUpdateAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUpdateAccount.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnUpdateAccount.FlatAppearance.BorderSize = 0;
            this.btnUpdateAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnUpdateAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateAccount.Location = new System.Drawing.Point(617, 0);
            this.btnUpdateAccount.Name = "btnUpdateAccount";
            this.btnUpdateAccount.Size = new System.Drawing.Size(124, 31);
            this.btnUpdateAccount.TabIndex = 2;
            this.btnUpdateAccount.TabStop = false;
            this.btnUpdateAccount.UseVisualStyleBackColor = true;
            // 
            // pnlSeparator1
            // 
            this.pnlSeparator1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlSeparator1.Location = new System.Drawing.Point(741, 0);
            this.pnlSeparator1.Name = "pnlSeparator1";
            this.pnlSeparator1.Size = new System.Drawing.Size(15, 31);
            this.pnlSeparator1.TabIndex = 3;
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddAccount.BackgroundImage")));
            this.btnAddAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddAccount.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAddAccount.FlatAppearance.BorderSize = 0;
            this.btnAddAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnAddAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAccount.Location = new System.Drawing.Point(756, 0);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(124, 31);
            this.btnAddAccount.TabIndex = 4;
            this.btnAddAccount.TabStop = false;
            this.btnAddAccount.UseVisualStyleBackColor = true;
            // 
            // txtbx_search
            // 
            this.txtbx_search.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_search.Location = new System.Drawing.Point(3, 3);
            this.txtbx_search.Name = "txtbx_search";
            this.txtbx_search.Size = new System.Drawing.Size(199, 27);
            this.txtbx_search.TabIndex = 229;
            this.txtbx_search.TabStop = false;
            this.txtbx_search.Text = "Search";
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
            this.dtgvAccounts.Location = new System.Drawing.Point(3, 36);
            this.dtgvAccounts.Name = "dtgvAccounts";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(5)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvAccounts.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvAccounts.Size = new System.Drawing.Size(880, 340);
            this.dtgvAccounts.TabIndex = 230;
            // 
            // tabNotification
            // 
            this.tabNotification.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabNotification.Location = new System.Drawing.Point(4, 26);
            this.tabNotification.Name = "tabNotification";
            this.tabNotification.Padding = new System.Windows.Forms.Padding(3);
            this.tabNotification.Size = new System.Drawing.Size(892, 422);
            this.tabNotification.TabIndex = 1;
            this.tabNotification.Text = "Notification";
            this.tabNotification.UseVisualStyleBackColor = true;
            // 
            // ucAddAccount1
            // 
            this.ucAddAccount1.BackColor = System.Drawing.Color.White;
            this.ucAddAccount1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucAddAccount1.Location = new System.Drawing.Point(3, 3);
            this.ucAddAccount1.Margin = new System.Windows.Forms.Padding(4);
            this.ucAddAccount1.Name = "ucAddAccount1";
            this.ucAddAccount1.Size = new System.Drawing.Size(886, 416);
            this.ucAddAccount1.TabIndex = 3;
            this.ucAddAccount1.Load += new System.EventHandler(this.ucAddAccount1_Load);
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
            this.tblpAddAccount.ResumeLayout(false);
            this.tblpAddAccount.PerformLayout();
            this.pnlBelow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccounts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSettings;
        private System.Windows.Forms.TabControl tctrlAddAccount;
        private System.Windows.Forms.TabPage tabAccount;
        private System.Windows.Forms.TabPage tabNotification;
        private System.Windows.Forms.TableLayoutPanel tblpAddAccount;
        private System.Windows.Forms.TextBox txtbx_search;
        private System.Windows.Forms.DataGridView dtgvAccounts;
        private System.Windows.Forms.Panel pnlBelow;
        private System.Windows.Forms.Button btnUpdateAccount;
        private System.Windows.Forms.Panel pnlSeparator1;
        private System.Windows.Forms.Button btnAddAccount;
        private ucAddAccount ucAddAccount1;


    }
}
