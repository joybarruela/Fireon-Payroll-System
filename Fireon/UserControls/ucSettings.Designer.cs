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
            this.lblSettings = new System.Windows.Forms.Label();
            this.dtgvAccounts = new System.Windows.Forms.DataGridView();
            this.txtbxUsername = new System.Windows.Forms.TextBox();
            this.txtbxPassword = new System.Windows.Forms.TextBox();
            this.txtbxConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.chkbxKeepMeLoggedIn = new System.Windows.Forms.CheckBox();
            this.txtbxYourPassword = new System.Windows.Forms.TextBox();
            this.lblYourPassword = new System.Windows.Forms.Label();
            this.lblDefaultFileLocation = new System.Windows.Forms.Label();
            this.btnDefaultFileLocation = new System.Windows.Forms.Button();
            this.fbdDefaultFileLocation = new System.Windows.Forms.FolderBrowserDialog();
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
            // dtgvAccounts
            // 
            this.dtgvAccounts.AllowUserToAddRows = false;
            this.dtgvAccounts.AllowUserToDeleteRows = false;
            this.dtgvAccounts.AllowUserToResizeColumns = false;
            this.dtgvAccounts.AllowUserToResizeRows = false;
            this.dtgvAccounts.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dtgvAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvAccounts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgvAccounts.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dtgvAccounts.Location = new System.Drawing.Point(3, 238);
            this.dtgvAccounts.MultiSelect = false;
            this.dtgvAccounts.Name = "dtgvAccounts";
            this.dtgvAccounts.ReadOnly = true;
            this.dtgvAccounts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgvAccounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvAccounts.ShowEditingIcon = false;
            this.dtgvAccounts.Size = new System.Drawing.Size(458, 121);
            this.dtgvAccounts.TabIndex = 141;
            // 
            // txtbxUsername
            // 
            this.txtbxUsername.Location = new System.Drawing.Point(187, 113);
            this.txtbxUsername.MaxLength = 32;
            this.txtbxUsername.Name = "txtbxUsername";
            this.txtbxUsername.Size = new System.Drawing.Size(274, 20);
            this.txtbxUsername.TabIndex = 142;
            this.txtbxUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxUpdateUserName_KeyPress);
            this.txtbxUsername.Leave += new System.EventHandler(this.txtbxUpdateUserName_Leave);
            // 
            // txtbxPassword
            // 
            this.txtbxPassword.Location = new System.Drawing.Point(187, 139);
            this.txtbxPassword.MaxLength = 32;
            this.txtbxPassword.Name = "txtbxPassword";
            this.txtbxPassword.Size = new System.Drawing.Size(274, 20);
            this.txtbxPassword.TabIndex = 142;
            this.txtbxPassword.UseSystemPasswordChar = true;
            // 
            // txtbxConfirmPassword
            // 
            this.txtbxConfirmPassword.Location = new System.Drawing.Point(187, 165);
            this.txtbxConfirmPassword.MaxLength = 32;
            this.txtbxConfirmPassword.Name = "txtbxConfirmPassword";
            this.txtbxConfirmPassword.Size = new System.Drawing.Size(274, 20);
            this.txtbxConfirmPassword.TabIndex = 142;
            this.txtbxConfirmPassword.UseSystemPasswordChar = true;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(128, 120);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(53, 13);
            this.lblUsername.TabIndex = 143;
            this.lblUsername.Text = "username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(129, 146);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(52, 13);
            this.lblPassword.TabIndex = 143;
            this.lblPassword.Text = "password";
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Location = new System.Drawing.Point(92, 168);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(89, 13);
            this.lblConfirmPassword.TabIndex = 143;
            this.lblConfirmPassword.Text = "confirm password";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(386, 386);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 144;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(305, 386);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 144;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // chkbxKeepMeLoggedIn
            // 
            this.chkbxKeepMeLoggedIn.AutoSize = true;
            this.chkbxKeepMeLoggedIn.Location = new System.Drawing.Point(187, 76);
            this.chkbxKeepMeLoggedIn.Name = "chkbxKeepMeLoggedIn";
            this.chkbxKeepMeLoggedIn.Size = new System.Drawing.Size(117, 17);
            this.chkbxKeepMeLoggedIn.TabIndex = 145;
            this.chkbxKeepMeLoggedIn.Text = "Keep me logged in.";
            this.chkbxKeepMeLoggedIn.UseVisualStyleBackColor = true;
            this.chkbxKeepMeLoggedIn.CheckedChanged += new System.EventHandler(this.chkbxKeepMeLoggedIn_CheckedChanged);
            // 
            // txtbxYourPassword
            // 
            this.txtbxYourPassword.Location = new System.Drawing.Point(187, 191);
            this.txtbxYourPassword.MaxLength = 32;
            this.txtbxYourPassword.Name = "txtbxYourPassword";
            this.txtbxYourPassword.Size = new System.Drawing.Size(274, 20);
            this.txtbxYourPassword.TabIndex = 142;
            this.txtbxYourPassword.UseSystemPasswordChar = true;
            // 
            // lblYourPassword
            // 
            this.lblYourPassword.AutoSize = true;
            this.lblYourPassword.Location = new System.Drawing.Point(106, 194);
            this.lblYourPassword.Name = "lblYourPassword";
            this.lblYourPassword.Size = new System.Drawing.Size(75, 13);
            this.lblYourPassword.TabIndex = 143;
            this.lblYourPassword.Text = "your password";
            // 
            // lblDefaultFileLocation
            // 
            this.lblDefaultFileLocation.AutoSize = true;
            this.lblDefaultFileLocation.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDefaultFileLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(5)))));
            this.lblDefaultFileLocation.Location = new System.Drawing.Point(88, 458);
            this.lblDefaultFileLocation.Name = "lblDefaultFileLocation";
            this.lblDefaultFileLocation.Padding = new System.Windows.Forms.Padding(0, 10, 10, 0);
            this.lblDefaultFileLocation.Size = new System.Drawing.Size(95, 26);
            this.lblDefaultFileLocation.TabIndex = 219;
            this.lblDefaultFileLocation.Text = "file location";
            this.lblDefaultFileLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDefaultFileLocation
            // 
            this.btnDefaultFileLocation.Location = new System.Drawing.Point(7, 444);
            this.btnDefaultFileLocation.Name = "btnDefaultFileLocation";
            this.btnDefaultFileLocation.Size = new System.Drawing.Size(75, 40);
            this.btnDefaultFileLocation.TabIndex = 218;
            this.btnDefaultFileLocation.Text = "DefaultFileLocation";
            this.btnDefaultFileLocation.UseVisualStyleBackColor = true;
            this.btnDefaultFileLocation.Click += new System.EventHandler(this.btnDefaultFileLocation_Click);
            // 
            // fbdDefaultFileLocation
            // 
            this.fbdDefaultFileLocation.Description = "Choose Default File Directory.";
            // 
            // ucSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblDefaultFileLocation);
            this.Controls.Add(this.btnDefaultFileLocation);
            this.Controls.Add(this.chkbxKeepMeLoggedIn);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.lblYourPassword);
            this.Controls.Add(this.txtbxUsername);
            this.Controls.Add(this.txtbxPassword);
            this.Controls.Add(this.txtbxConfirmPassword);
            this.Controls.Add(this.txtbxYourPassword);
            this.Controls.Add(this.dtgvAccounts);
            this.Controls.Add(this.lblSettings);
            this.Name = "ucSettings";
            this.Size = new System.Drawing.Size(900, 500);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccounts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSettings;
        private System.Windows.Forms.DataGridView dtgvAccounts;
        private System.Windows.Forms.TextBox txtbxUsername;
        private System.Windows.Forms.TextBox txtbxPassword;
        private System.Windows.Forms.TextBox txtbxConfirmPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.CheckBox chkbxKeepMeLoggedIn;
        private System.Windows.Forms.TextBox txtbxYourPassword;
        private System.Windows.Forms.Label lblYourPassword;
        private System.Windows.Forms.Label lblDefaultFileLocation;
        private System.Windows.Forms.Button btnDefaultFileLocation;
        private System.Windows.Forms.FolderBrowserDialog fbdDefaultFileLocation;


    }
}
