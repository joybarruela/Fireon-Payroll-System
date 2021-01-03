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
            this.lblSettings = new System.Windows.Forms.Label();
            this.fbdDefaultFileLocation = new System.Windows.Forms.FolderBrowserDialog();
            this.pnlUserInformation = new System.Windows.Forms.Panel();
            this.txtbxPassword = new System.Windows.Forms.TextBox();
            this.txtbxYourPassword = new System.Windows.Forms.TextBox();
            this.txtbxConfirmPassword = new System.Windows.Forms.TextBox();
            this.txtbxUsername = new System.Windows.Forms.TextBox();
            this.chkbxKeepMeLoggedIn = new System.Windows.Forms.CheckBox();
            this.lblYourPassword = new System.Windows.Forms.Label();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnDefaultFileLocation = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.flpDtgv = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlSeparator1 = new System.Windows.Forms.Panel();
            this.dtgvAccounts = new System.Windows.Forms.DataGridView();
            this.flpBelow = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlSeparator2 = new System.Windows.Forms.Panel();
            this.tblpSettings = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblDefaultFileLocation = new System.Windows.Forms.Label();
            this.pnlUserInformation.SuspendLayout();
            this.flpDtgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccounts)).BeginInit();
            this.flpBelow.SuspendLayout();
            this.tblpSettings.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
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
            // fbdDefaultFileLocation
            // 
            this.fbdDefaultFileLocation.Description = "Choose Default File Directory.";
            // 
            // pnlUserInformation
            // 
            this.pnlUserInformation.Controls.Add(this.txtbxPassword);
            this.pnlUserInformation.Controls.Add(this.txtbxYourPassword);
            this.pnlUserInformation.Controls.Add(this.txtbxConfirmPassword);
            this.pnlUserInformation.Controls.Add(this.txtbxUsername);
            this.pnlUserInformation.Controls.Add(this.chkbxKeepMeLoggedIn);
            this.pnlUserInformation.Controls.Add(this.lblYourPassword);
            this.pnlUserInformation.Controls.Add(this.lblConfirmPassword);
            this.pnlUserInformation.Controls.Add(this.lblPassword);
            this.pnlUserInformation.Controls.Add(this.lblUsername);
            this.pnlUserInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUserInformation.Location = new System.Drawing.Point(3, 205);
            this.pnlUserInformation.Name = "pnlUserInformation";
            this.pnlUserInformation.Size = new System.Drawing.Size(894, 181);
            this.pnlUserInformation.TabIndex = 221;
            // 
            // txtbxPassword
            // 
            this.txtbxPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxPassword.Location = new System.Drawing.Point(381, 47);
            this.txtbxPassword.MaxLength = 32;
            this.txtbxPassword.Name = "txtbxPassword";
            this.txtbxPassword.Size = new System.Drawing.Size(274, 23);
            this.txtbxPassword.TabIndex = 142;
            this.txtbxPassword.UseSystemPasswordChar = true;
            // 
            // txtbxYourPassword
            // 
            this.txtbxYourPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxYourPassword.Location = new System.Drawing.Point(381, 105);
            this.txtbxYourPassword.MaxLength = 32;
            this.txtbxYourPassword.Name = "txtbxYourPassword";
            this.txtbxYourPassword.Size = new System.Drawing.Size(274, 23);
            this.txtbxYourPassword.TabIndex = 142;
            this.txtbxYourPassword.UseSystemPasswordChar = true;
            // 
            // txtbxConfirmPassword
            // 
            this.txtbxConfirmPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxConfirmPassword.Location = new System.Drawing.Point(381, 76);
            this.txtbxConfirmPassword.MaxLength = 32;
            this.txtbxConfirmPassword.Name = "txtbxConfirmPassword";
            this.txtbxConfirmPassword.Size = new System.Drawing.Size(274, 23);
            this.txtbxConfirmPassword.TabIndex = 142;
            this.txtbxConfirmPassword.UseSystemPasswordChar = true;
            // 
            // txtbxUsername
            // 
            this.txtbxUsername.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxUsername.Location = new System.Drawing.Point(381, 18);
            this.txtbxUsername.MaxLength = 32;
            this.txtbxUsername.Name = "txtbxUsername";
            this.txtbxUsername.Size = new System.Drawing.Size(274, 23);
            this.txtbxUsername.TabIndex = 142;
            this.txtbxUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxUpdateUserName_KeyPress);
            this.txtbxUsername.Leave += new System.EventHandler(this.txtbxUpdateUserName_Leave);
            // 
            // chkbxKeepMeLoggedIn
            // 
            this.chkbxKeepMeLoggedIn.AutoSize = true;
            this.chkbxKeepMeLoggedIn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbxKeepMeLoggedIn.Location = new System.Drawing.Point(381, 144);
            this.chkbxKeepMeLoggedIn.Name = "chkbxKeepMeLoggedIn";
            this.chkbxKeepMeLoggedIn.Size = new System.Drawing.Size(155, 21);
            this.chkbxKeepMeLoggedIn.TabIndex = 145;
            this.chkbxKeepMeLoggedIn.Text = "Keep me logged in.";
            this.chkbxKeepMeLoggedIn.UseVisualStyleBackColor = true;
            this.chkbxKeepMeLoggedIn.CheckedChanged += new System.EventHandler(this.chkbxKeepMeLoggedIn_CheckedChanged);
            // 
            // lblYourPassword
            // 
            this.lblYourPassword.AutoSize = true;
            this.lblYourPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYourPassword.Location = new System.Drawing.Point(250, 108);
            this.lblYourPassword.Name = "lblYourPassword";
            this.lblYourPassword.Size = new System.Drawing.Size(101, 17);
            this.lblYourPassword.TabIndex = 143;
            this.lblYourPassword.Text = "Your Password";
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPassword.Location = new System.Drawing.Point(250, 79);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(125, 17);
            this.lblConfirmPassword.TabIndex = 143;
            this.lblConfirmPassword.Text = "Confirm Password";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(251, 50);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(69, 17);
            this.lblPassword.TabIndex = 143;
            this.lblPassword.Text = "Password";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(250, 21);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(71, 17);
            this.lblUsername.TabIndex = 143;
            this.lblUsername.Text = "Username";
            // 
            // btnDefaultFileLocation
            // 
            this.btnDefaultFileLocation.BackgroundImage = global::Fireon.Properties.Resources.btnDefaultFileLocation;
            this.btnDefaultFileLocation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDefaultFileLocation.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDefaultFileLocation.FlatAppearance.BorderSize = 0;
            this.btnDefaultFileLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDefaultFileLocation.Location = new System.Drawing.Point(0, 0);
            this.btnDefaultFileLocation.Margin = new System.Windows.Forms.Padding(0);
            this.btnDefaultFileLocation.Name = "btnDefaultFileLocation";
            this.btnDefaultFileLocation.Size = new System.Drawing.Size(208, 36);
            this.btnDefaultFileLocation.TabIndex = 221;
            this.btnDefaultFileLocation.UseVisualStyleBackColor = true;
            this.btnDefaultFileLocation.Click += new System.EventHandler(this.btnDefaultFileLocation_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = global::Fireon.Properties.Resources.btnAdd;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(768, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(127, 30);
            this.btnAdd.TabIndex = 144;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = global::Fireon.Properties.Resources.btnDelete;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(635, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(127, 30);
            this.btnDelete.TabIndex = 144;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // flpDtgv
            // 
            this.flpDtgv.Controls.Add(this.pnlSeparator1);
            this.flpDtgv.Controls.Add(this.dtgvAccounts);
            this.flpDtgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpDtgv.Location = new System.Drawing.Point(3, 3);
            this.flpDtgv.Name = "flpDtgv";
            this.flpDtgv.Size = new System.Drawing.Size(894, 196);
            this.flpDtgv.TabIndex = 317;
            // 
            // pnlSeparator1
            // 
            this.pnlSeparator1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSeparator1.Location = new System.Drawing.Point(3, 3);
            this.pnlSeparator1.Name = "pnlSeparator1";
            this.pnlSeparator1.Size = new System.Drawing.Size(250, 194);
            this.pnlSeparator1.TabIndex = 146;
            // 
            // dtgvAccounts
            // 
            this.dtgvAccounts.AllowUserToAddRows = false;
            this.dtgvAccounts.AllowUserToDeleteRows = false;
            this.dtgvAccounts.AllowUserToResizeColumns = false;
            this.dtgvAccounts.AllowUserToResizeRows = false;
            this.dtgvAccounts.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvAccounts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvAccounts.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvAccounts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgvAccounts.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dtgvAccounts.Location = new System.Drawing.Point(259, 3);
            this.dtgvAccounts.MultiSelect = false;
            this.dtgvAccounts.Name = "dtgvAccounts";
            this.dtgvAccounts.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvAccounts.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvAccounts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgvAccounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvAccounts.ShowEditingIcon = false;
            this.dtgvAccounts.Size = new System.Drawing.Size(397, 194);
            this.dtgvAccounts.TabIndex = 141;
            // 
            // flpBelow
            // 
            this.flpBelow.Controls.Add(this.btnDefaultFileLocation);
            this.flpBelow.Controls.Add(this.pnlSeparator2);
            this.flpBelow.Controls.Add(this.btnDelete);
            this.flpBelow.Controls.Add(this.btnAdd);
            this.flpBelow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpBelow.Location = new System.Drawing.Point(0, 417);
            this.flpBelow.Margin = new System.Windows.Forms.Padding(0);
            this.flpBelow.Name = "flpBelow";
            this.flpBelow.Size = new System.Drawing.Size(900, 35);
            this.flpBelow.TabIndex = 318;
            // 
            // pnlSeparator2
            // 
            this.pnlSeparator2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSeparator2.Location = new System.Drawing.Point(211, 3);
            this.pnlSeparator2.Name = "pnlSeparator2";
            this.pnlSeparator2.Size = new System.Drawing.Size(418, 30);
            this.pnlSeparator2.TabIndex = 145;
            // 
            // tblpSettings
            // 
            this.tblpSettings.ColumnCount = 1;
            this.tblpSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblpSettings.Controls.Add(this.flpBelow, 0, 3);
            this.tblpSettings.Controls.Add(this.flpDtgv, 0, 0);
            this.tblpSettings.Controls.Add(this.pnlUserInformation, 0, 1);
            this.tblpSettings.Controls.Add(this.flowLayoutPanel1, 0, 2);
            this.tblpSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblpSettings.Location = new System.Drawing.Point(0, 48);
            this.tblpSettings.Name = "tblpSettings";
            this.tblpSettings.RowCount = 4;
            this.tblpSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.9115F));
            this.tblpSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.59292F));
            this.tblpSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.415929F));
            this.tblpSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.522124F));
            this.tblpSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblpSettings.Size = new System.Drawing.Size(900, 452);
            this.tblpSettings.TabIndex = 220;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lblDefaultFileLocation);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 392);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(894, 22);
            this.flowLayoutPanel1.TabIndex = 319;
            // 
            // lblDefaultFileLocation
            // 
            this.lblDefaultFileLocation.AutoSize = true;
            this.lblDefaultFileLocation.BackColor = System.Drawing.Color.Transparent;
            this.lblDefaultFileLocation.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDefaultFileLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(5)))));
            this.lblDefaultFileLocation.Location = new System.Drawing.Point(0, 0);
            this.lblDefaultFileLocation.Margin = new System.Windows.Forms.Padding(0);
            this.lblDefaultFileLocation.Name = "lblDefaultFileLocation";
            this.lblDefaultFileLocation.Size = new System.Drawing.Size(105, 18);
            this.lblDefaultFileLocation.TabIndex = 220;
            this.lblDefaultFileLocation.Text = "File Location:";
            this.lblDefaultFileLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tblpSettings);
            this.Controls.Add(this.lblSettings);
            this.Name = "ucSettings";
            this.Size = new System.Drawing.Size(900, 500);
            this.pnlUserInformation.ResumeLayout(false);
            this.pnlUserInformation.PerformLayout();
            this.flpDtgv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccounts)).EndInit();
            this.flpBelow.ResumeLayout(false);
            this.tblpSettings.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSettings;
        private System.Windows.Forms.FolderBrowserDialog fbdDefaultFileLocation;
        private System.Windows.Forms.Panel pnlUserInformation;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtbxPassword;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtbxYourPassword;
        private System.Windows.Forms.Button btnDefaultFileLocation;
        private System.Windows.Forms.TextBox txtbxConfirmPassword;
        private System.Windows.Forms.TextBox txtbxUsername;
        private System.Windows.Forms.CheckBox chkbxKeepMeLoggedIn;
        private System.Windows.Forms.Label lblYourPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.FlowLayoutPanel flpDtgv;
        private System.Windows.Forms.DataGridView dtgvAccounts;
        private System.Windows.Forms.FlowLayoutPanel flpBelow;
        private System.Windows.Forms.TableLayoutPanel tblpSettings;
        private System.Windows.Forms.Panel pnlSeparator2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblDefaultFileLocation;
        private System.Windows.Forms.Panel pnlSeparator1;


    }
}
