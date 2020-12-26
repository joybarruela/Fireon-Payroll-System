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
            this.fbdDefaultFileLocation = new System.Windows.Forms.FolderBrowserDialog();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlUserInformation = new System.Windows.Forms.Panel();
            this.dtgvAccounts = new System.Windows.Forms.DataGridView();
            this.flpnlDtgv = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlSeparator1 = new System.Windows.Forms.Panel();
            this.lblDefaultFileLocation = new System.Windows.Forms.Label();
            this.btnDefaultFileLocation = new System.Windows.Forms.Button();
            this.pnlBelow = new System.Windows.Forms.Panel();
            this.pnlSeparator2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlUserInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccounts)).BeginInit();
            this.flpnlDtgv.SuspendLayout();
            this.pnlBelow.SuspendLayout();
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
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = global::Fireon.Properties.Resources.btnAdd;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(759, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(135, 29);
            this.btnAdd.TabIndex = 144;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = global::Fireon.Properties.Resources.btnDelete;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(612, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(132, 29);
            this.btnDelete.TabIndex = 144;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            // fbdDefaultFileLocation
            // 
            this.fbdDefaultFileLocation.Description = "Choose Default File Directory.";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.pnlBelow, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.flpnlDtgv, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pnlUserInformation, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 48);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.03139F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.54867F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.522124F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(900, 452);
            this.tableLayoutPanel1.TabIndex = 220;
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
            this.pnlUserInformation.Location = new System.Drawing.Point(3, 3);
            this.pnlUserInformation.Name = "pnlUserInformation";
            this.pnlUserInformation.Size = new System.Drawing.Size(894, 179);
            this.pnlUserInformation.TabIndex = 221;
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
            this.dtgvAccounts.Location = new System.Drawing.Point(233, 3);
            this.dtgvAccounts.MultiSelect = false;
            this.dtgvAccounts.Name = "dtgvAccounts";
            this.dtgvAccounts.ReadOnly = true;
            this.dtgvAccounts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgvAccounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvAccounts.ShowEditingIcon = false;
            this.dtgvAccounts.Size = new System.Drawing.Size(397, 219);
            this.dtgvAccounts.TabIndex = 141;
            // 
            // flpnlDtgv
            // 
            this.flpnlDtgv.Controls.Add(this.pnlSeparator1);
            this.flpnlDtgv.Controls.Add(this.dtgvAccounts);
            this.flpnlDtgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpnlDtgv.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpnlDtgv.Location = new System.Drawing.Point(3, 188);
            this.flpnlDtgv.Name = "flpnlDtgv";
            this.flpnlDtgv.Size = new System.Drawing.Size(894, 226);
            this.flpnlDtgv.TabIndex = 317;
            // 
            // pnlSeparator1
            // 
            this.pnlSeparator1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlSeparator1.Location = new System.Drawing.Point(636, 3);
            this.pnlSeparator1.Name = "pnlSeparator1";
            this.pnlSeparator1.Size = new System.Drawing.Size(255, 219);
            this.pnlSeparator1.TabIndex = 146;
            // 
            // lblDefaultFileLocation
            // 
            this.lblDefaultFileLocation.AutoSize = true;
            this.lblDefaultFileLocation.BackColor = System.Drawing.Color.Transparent;
            this.lblDefaultFileLocation.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblDefaultFileLocation.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDefaultFileLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(5)))));
            this.lblDefaultFileLocation.Location = new System.Drawing.Point(0, 0);
            this.lblDefaultFileLocation.Name = "lblDefaultFileLocation";
            this.lblDefaultFileLocation.Size = new System.Drawing.Size(105, 18);
            this.lblDefaultFileLocation.TabIndex = 220;
            this.lblDefaultFileLocation.Text = "File Location:";
            this.lblDefaultFileLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDefaultFileLocation
            // 
            this.btnDefaultFileLocation.BackgroundImage = global::Fireon.Properties.Resources.btnDefaultFileLocation;
            this.btnDefaultFileLocation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDefaultFileLocation.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDefaultFileLocation.FlatAppearance.BorderSize = 0;
            this.btnDefaultFileLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDefaultFileLocation.Location = new System.Drawing.Point(105, 0);
            this.btnDefaultFileLocation.Name = "btnDefaultFileLocation";
            this.btnDefaultFileLocation.Size = new System.Drawing.Size(221, 29);
            this.btnDefaultFileLocation.TabIndex = 221;
            this.btnDefaultFileLocation.UseVisualStyleBackColor = true;
            this.btnDefaultFileLocation.Click += new System.EventHandler(this.btnDefaultFileLocation_Click);
            // 
            // pnlBelow
            // 
            this.pnlBelow.Controls.Add(this.btnDelete);
            this.pnlBelow.Controls.Add(this.pnlSeparator2);
            this.pnlBelow.Controls.Add(this.btnAdd);
            this.pnlBelow.Controls.Add(this.btnDefaultFileLocation);
            this.pnlBelow.Controls.Add(this.lblDefaultFileLocation);
            this.pnlBelow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBelow.Location = new System.Drawing.Point(3, 420);
            this.pnlBelow.Name = "pnlBelow";
            this.pnlBelow.Size = new System.Drawing.Size(894, 29);
            this.pnlBelow.TabIndex = 318;
            // 
            // pnlSeparator2
            // 
            this.pnlSeparator2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlSeparator2.Location = new System.Drawing.Point(744, 0);
            this.pnlSeparator2.Name = "pnlSeparator2";
            this.pnlSeparator2.Size = new System.Drawing.Size(15, 29);
            this.pnlSeparator2.TabIndex = 222;
            // 
            // ucSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lblSettings);
            this.Name = "ucSettings";
            this.Size = new System.Drawing.Size(900, 500);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlUserInformation.ResumeLayout(false);
            this.pnlUserInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccounts)).EndInit();
            this.flpnlDtgv.ResumeLayout(false);
            this.pnlBelow.ResumeLayout(false);
            this.pnlBelow.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSettings;
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
        private System.Windows.Forms.FolderBrowserDialog fbdDefaultFileLocation;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnlUserInformation;
        private System.Windows.Forms.FlowLayoutPanel flpnlDtgv;
        private System.Windows.Forms.Panel pnlSeparator1;
        private System.Windows.Forms.DataGridView dtgvAccounts;
        private System.Windows.Forms.Label lblDefaultFileLocation;
        private System.Windows.Forms.Button btnDefaultFileLocation;
        private System.Windows.Forms.Panel pnlBelow;
        private System.Windows.Forms.Panel pnlSeparator2;


    }
}
