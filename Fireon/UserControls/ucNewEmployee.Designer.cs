namespace Fireon
{
    partial class ucNewEmployee
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
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblMiddleInitial = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtbxFirstName = new System.Windows.Forms.TextBox();
            this.txtbxMiddleInitial = new System.Windows.Forms.TextBox();
            this.txtbxLastName = new System.Windows.Forms.TextBox();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblBirthdate = new System.Windows.Forms.Label();
            this.lblMaritalStatus = new System.Windows.Forms.Label();
            this.cmbxMaritalStatus = new System.Windows.Forms.ComboBox();
            this.lblNationality = new System.Windows.Forms.Label();
            this.txtbxNationality = new System.Windows.Forms.TextBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.cmbxDepartment = new System.Windows.Forms.ComboBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.cmbxPosition = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbxStatus = new System.Windows.Forms.ComboBox();
            this.lblWorkingHours = new System.Windows.Forms.Label();
            this.txtbxWorkingHours = new System.Windows.Forms.TextBox();
            this.lblHourlyRate = new System.Windows.Forms.Label();
            this.txtbxHourlyRate = new System.Windows.Forms.TextBox();
            this.mcBirthdate = new System.Windows.Forms.MonthCalendar();
            this.rdbtnMale = new System.Windows.Forms.RadioButton();
            this.rdbtnFemale = new System.Windows.Forms.RadioButton();
            this.ofdUploadFile = new System.Windows.Forms.OpenFileDialog();
            this.pnlPersonalInfo = new System.Windows.Forms.Panel();
            this.lblPersonalInformation = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.txtbxContact = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtbxEmail = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtbxAddress = new System.Windows.Forms.TextBox();
            this.lblSelectedBirthdate = new System.Windows.Forms.Label();
            this.lblJobInformation = new System.Windows.Forms.Label();
            this.cmbxPaymentMode = new System.Windows.Forms.ComboBox();
            this.lblPaymentMode = new System.Windows.Forms.Label();
            this.txtbxContractDuration = new System.Windows.Forms.TextBox();
            this.lblContractDuration = new System.Windows.Forms.Label();
            this.pnlJobInfo = new System.Windows.Forms.Panel();
            this.lblWorkingHoursPerMonth = new System.Windows.Forms.Label();
            this.lblHourlyRatePerHour = new System.Windows.Forms.Label();
            this.lblContractDurationMonths = new System.Windows.Forms.Label();
            this.btnUploadImage = new System.Windows.Forms.Button();
            this.picbDP = new System.Windows.Forms.PictureBox();
            this.lblFiles = new System.Windows.Forms.Label();
            this.btnUploadFile = new System.Windows.Forms.Button();
            this.lsbxFileList = new System.Windows.Forms.ListBox();
            this.pnlPersonalInfo.SuspendLayout();
            this.pnlJobInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbDP)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(6, 132);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(70, 17);
            this.lblFirstName.TabIndex = 5;
            this.lblFirstName.Text = "First Name";
            // 
            // lblMiddleInitial
            // 
            this.lblMiddleInitial.AutoSize = true;
            this.lblMiddleInitial.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiddleInitial.Location = new System.Drawing.Point(6, 83);
            this.lblMiddleInitial.Name = "lblMiddleInitial";
            this.lblMiddleInitial.Size = new System.Drawing.Size(84, 17);
            this.lblMiddleInitial.TabIndex = 3;
            this.lblMiddleInitial.Text = "Middle Initial";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(6, 36);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(71, 17);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Last Name";
            // 
            // txtbxFirstName
            // 
            this.txtbxFirstName.BackColor = System.Drawing.Color.White;
            this.txtbxFirstName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtbxFirstName.Location = new System.Drawing.Point(8, 153);
            this.txtbxFirstName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbxFirstName.MaxLength = 120;
            this.txtbxFirstName.Name = "txtbxFirstName";
            this.txtbxFirstName.Size = new System.Drawing.Size(227, 22);
            this.txtbxFirstName.TabIndex = 6;
            this.txtbxFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxFirstName_KeyPress);
            this.txtbxFirstName.Leave += new System.EventHandler(this.txtbxFirstName_Leave);
            // 
            // txtbxMiddleInitial
            // 
            this.txtbxMiddleInitial.BackColor = System.Drawing.Color.White;
            this.txtbxMiddleInitial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtbxMiddleInitial.Location = new System.Drawing.Point(9, 104);
            this.txtbxMiddleInitial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbxMiddleInitial.MaxLength = 3;
            this.txtbxMiddleInitial.Name = "txtbxMiddleInitial";
            this.txtbxMiddleInitial.Size = new System.Drawing.Size(81, 22);
            this.txtbxMiddleInitial.TabIndex = 4;
            this.txtbxMiddleInitial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxMiddleName_KeyPress);
            this.txtbxMiddleInitial.Leave += new System.EventHandler(this.txtbxMiddleInitial_Leave);
            // 
            // txtbxLastName
            // 
            this.txtbxLastName.BackColor = System.Drawing.Color.White;
            this.txtbxLastName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtbxLastName.Location = new System.Drawing.Point(8, 57);
            this.txtbxLastName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbxLastName.MaxLength = 120;
            this.txtbxLastName.Name = "txtbxLastName";
            this.txtbxLastName.Size = new System.Drawing.Size(227, 22);
            this.txtbxLastName.TabIndex = 2;
            this.txtbxLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxLastName_KeyPress);
            this.txtbxLastName.Leave += new System.EventHandler(this.txtbxLastName_Leave);
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSex.Location = new System.Drawing.Point(6, 177);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(29, 17);
            this.lblSex.TabIndex = 7;
            this.lblSex.Text = "Sex";
            // 
            // lblBirthdate
            // 
            this.lblBirthdate.AutoSize = true;
            this.lblBirthdate.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthdate.Location = new System.Drawing.Point(6, 223);
            this.lblBirthdate.Name = "lblBirthdate";
            this.lblBirthdate.Size = new System.Drawing.Size(69, 17);
            this.lblBirthdate.TabIndex = 10;
            this.lblBirthdate.Text = "Birthdate: ";
            // 
            // lblMaritalStatus
            // 
            this.lblMaritalStatus.AutoSize = true;
            this.lblMaritalStatus.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaritalStatus.Location = new System.Drawing.Point(251, 312);
            this.lblMaritalStatus.Name = "lblMaritalStatus";
            this.lblMaritalStatus.Size = new System.Drawing.Size(90, 17);
            this.lblMaritalStatus.TabIndex = 19;
            this.lblMaritalStatus.Text = "Marital Status";
            // 
            // cmbxMaritalStatus
            // 
            this.cmbxMaritalStatus.BackColor = System.Drawing.Color.White;
            this.cmbxMaritalStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxMaritalStatus.FormattingEnabled = true;
            this.cmbxMaritalStatus.Items.AddRange(new object[] {
            "Married",
            "Widowed",
            "Separated",
            "Divorced",
            "Single"});
            this.cmbxMaritalStatus.Location = new System.Drawing.Point(254, 333);
            this.cmbxMaritalStatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbxMaritalStatus.Name = "cmbxMaritalStatus";
            this.cmbxMaritalStatus.Size = new System.Drawing.Size(238, 25);
            this.cmbxMaritalStatus.TabIndex = 20;
            // 
            // lblNationality
            // 
            this.lblNationality.AutoSize = true;
            this.lblNationality.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNationality.Location = new System.Drawing.Point(251, 362);
            this.lblNationality.Name = "lblNationality";
            this.lblNationality.Size = new System.Drawing.Size(73, 17);
            this.lblNationality.TabIndex = 21;
            this.lblNationality.Text = "Nationality";
            // 
            // txtbxNationality
            // 
            this.txtbxNationality.BackColor = System.Drawing.Color.White;
            this.txtbxNationality.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtbxNationality.Location = new System.Drawing.Point(254, 383);
            this.txtbxNationality.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbxNationality.MaxLength = 45;
            this.txtbxNationality.Name = "txtbxNationality";
            this.txtbxNationality.Size = new System.Drawing.Size(238, 22);
            this.txtbxNationality.TabIndex = 22;
            this.txtbxNationality.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxNationality_KeyPress);
            this.txtbxNationality.Leave += new System.EventHandler(this.txtbxNationality_Leave);
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartment.Location = new System.Drawing.Point(10, 36);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(81, 17);
            this.lblDepartment.TabIndex = 1;
            this.lblDepartment.Text = "Department";
            // 
            // cmbxDepartment
            // 
            this.cmbxDepartment.BackColor = System.Drawing.Color.White;
            this.cmbxDepartment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbxDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxDepartment.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbxDepartment.FormattingEnabled = true;
            this.cmbxDepartment.Items.AddRange(new object[] {
            "Administrative",
            "Customer Service",
            "Finance",
            "Human Resource",
            "Information Technology",
            "Legal",
            "Marketing",
            "Operation",
            "Production",
            "Purchasing",
            "Research and Development",
            "Sales"});
            this.cmbxDepartment.Location = new System.Drawing.Point(11, 57);
            this.cmbxDepartment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbxDepartment.Name = "cmbxDepartment";
            this.cmbxDepartment.Size = new System.Drawing.Size(210, 25);
            this.cmbxDepartment.TabIndex = 2;
            this.cmbxDepartment.SelectedIndexChanged += new System.EventHandler(this.cmbxDepartment_SelectedIndexChanged);
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.Location = new System.Drawing.Point(10, 86);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(54, 17);
            this.lblPosition.TabIndex = 3;
            this.lblPosition.Text = "Position";
            // 
            // cmbxPosition
            // 
            this.cmbxPosition.BackColor = System.Drawing.Color.White;
            this.cmbxPosition.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbxPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxPosition.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbxPosition.FormattingEnabled = true;
            this.cmbxPosition.Location = new System.Drawing.Point(11, 107);
            this.cmbxPosition.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbxPosition.Name = "cmbxPosition";
            this.cmbxPosition.Size = new System.Drawing.Size(210, 25);
            this.cmbxPosition.TabIndex = 4;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(10, 136);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(45, 17);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Status";
            // 
            // cmbxStatus
            // 
            this.cmbxStatus.BackColor = System.Drawing.Color.White;
            this.cmbxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxStatus.FormattingEnabled = true;
            this.cmbxStatus.Items.AddRange(new object[] {
            "Contractual",
            "Regular"});
            this.cmbxStatus.Location = new System.Drawing.Point(11, 157);
            this.cmbxStatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbxStatus.Name = "cmbxStatus";
            this.cmbxStatus.Size = new System.Drawing.Size(210, 25);
            this.cmbxStatus.TabIndex = 6;
            this.cmbxStatus.SelectedIndexChanged += new System.EventHandler(this.cmbxStatus_SelectedIndexChanged);
            // 
            // lblWorkingHours
            // 
            this.lblWorkingHours.AutoSize = true;
            this.lblWorkingHours.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkingHours.Location = new System.Drawing.Point(9, 218);
            this.lblWorkingHours.Name = "lblWorkingHours";
            this.lblWorkingHours.Size = new System.Drawing.Size(92, 17);
            this.lblWorkingHours.TabIndex = 7;
            this.lblWorkingHours.Text = "Working Hours";
            // 
            // txtbxWorkingHours
            // 
            this.txtbxWorkingHours.BackColor = System.Drawing.Color.White;
            this.txtbxWorkingHours.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtbxWorkingHours.Location = new System.Drawing.Point(11, 239);
            this.txtbxWorkingHours.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbxWorkingHours.MaxLength = 3;
            this.txtbxWorkingHours.Name = "txtbxWorkingHours";
            this.txtbxWorkingHours.Size = new System.Drawing.Size(153, 22);
            this.txtbxWorkingHours.TabIndex = 8;
            this.txtbxWorkingHours.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxWorkingHours_KeyPress);
            // 
            // lblHourlyRate
            // 
            this.lblHourlyRate.AutoSize = true;
            this.lblHourlyRate.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHourlyRate.Location = new System.Drawing.Point(10, 265);
            this.lblHourlyRate.Name = "lblHourlyRate";
            this.lblHourlyRate.Size = new System.Drawing.Size(75, 17);
            this.lblHourlyRate.TabIndex = 10;
            this.lblHourlyRate.Text = "Hourly Rate";
            // 
            // txtbxHourlyRate
            // 
            this.txtbxHourlyRate.BackColor = System.Drawing.Color.White;
            this.txtbxHourlyRate.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtbxHourlyRate.Location = new System.Drawing.Point(11, 286);
            this.txtbxHourlyRate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbxHourlyRate.MaxLength = 6;
            this.txtbxHourlyRate.Name = "txtbxHourlyRate";
            this.txtbxHourlyRate.Size = new System.Drawing.Size(153, 22);
            this.txtbxHourlyRate.TabIndex = 11;
            this.txtbxHourlyRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxHourlyRate_KeyPress);
            // 
            // mcBirthdate
            // 
            this.mcBirthdate.Location = new System.Drawing.Point(8, 243);
            this.mcBirthdate.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.mcBirthdate.MaxSelectionCount = 1;
            this.mcBirthdate.MinDate = new System.DateTime(1800, 1, 1, 0, 0, 0, 0);
            this.mcBirthdate.Name = "mcBirthdate";
            this.mcBirthdate.TabIndex = 12;
            this.mcBirthdate.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.mcBirthdate_DateSelected);
            // 
            // rdbtnMale
            // 
            this.rdbtnMale.AutoSize = true;
            this.rdbtnMale.Location = new System.Drawing.Point(9, 197);
            this.rdbtnMale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbtnMale.Name = "rdbtnMale";
            this.rdbtnMale.Size = new System.Drawing.Size(56, 21);
            this.rdbtnMale.TabIndex = 8;
            this.rdbtnMale.TabStop = true;
            this.rdbtnMale.Text = "Male";
            this.rdbtnMale.UseVisualStyleBackColor = true;
            // 
            // rdbtnFemale
            // 
            this.rdbtnFemale.AutoSize = true;
            this.rdbtnFemale.Location = new System.Drawing.Point(72, 197);
            this.rdbtnFemale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbtnFemale.Name = "rdbtnFemale";
            this.rdbtnFemale.Size = new System.Drawing.Size(70, 21);
            this.rdbtnFemale.TabIndex = 9;
            this.rdbtnFemale.TabStop = true;
            this.rdbtnFemale.Text = "Female";
            this.rdbtnFemale.UseVisualStyleBackColor = true;
            // 
            // ofdUploadFile
            // 
            this.ofdUploadFile.DefaultExt = "png";
            this.ofdUploadFile.Title = "Choose Employee Picture";
            this.ofdUploadFile.FileOk += new System.ComponentModel.CancelEventHandler(this.ofdUploadDP_FileOk);
            // 
            // pnlPersonalInfo
            // 
            this.pnlPersonalInfo.BackColor = System.Drawing.Color.White;
            this.pnlPersonalInfo.Controls.Add(this.lblPersonalInformation);
            this.pnlPersonalInfo.Controls.Add(this.lblContact);
            this.pnlPersonalInfo.Controls.Add(this.lblFirstName);
            this.pnlPersonalInfo.Controls.Add(this.txtbxContact);
            this.pnlPersonalInfo.Controls.Add(this.rdbtnFemale);
            this.pnlPersonalInfo.Controls.Add(this.lblEmail);
            this.pnlPersonalInfo.Controls.Add(this.txtbxFirstName);
            this.pnlPersonalInfo.Controls.Add(this.txtbxEmail);
            this.pnlPersonalInfo.Controls.Add(this.rdbtnMale);
            this.pnlPersonalInfo.Controls.Add(this.lblAddress);
            this.pnlPersonalInfo.Controls.Add(this.txtbxAddress);
            this.pnlPersonalInfo.Controls.Add(this.lblMiddleInitial);
            this.pnlPersonalInfo.Controls.Add(this.txtbxMiddleInitial);
            this.pnlPersonalInfo.Controls.Add(this.lblLastName);
            this.pnlPersonalInfo.Controls.Add(this.txtbxLastName);
            this.pnlPersonalInfo.Controls.Add(this.lblSex);
            this.pnlPersonalInfo.Controls.Add(this.lblSelectedBirthdate);
            this.pnlPersonalInfo.Controls.Add(this.lblBirthdate);
            this.pnlPersonalInfo.Controls.Add(this.mcBirthdate);
            this.pnlPersonalInfo.Controls.Add(this.lblMaritalStatus);
            this.pnlPersonalInfo.Controls.Add(this.cmbxMaritalStatus);
            this.pnlPersonalInfo.Controls.Add(this.txtbxNationality);
            this.pnlPersonalInfo.Controls.Add(this.lblNationality);
            this.pnlPersonalInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlPersonalInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlPersonalInfo.Name = "pnlPersonalInfo";
            this.pnlPersonalInfo.Size = new System.Drawing.Size(514, 431);
            this.pnlPersonalInfo.TabIndex = 0;
            // 
            // lblPersonalInformation
            // 
            this.lblPersonalInformation.AutoSize = true;
            this.lblPersonalInformation.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPersonalInformation.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonalInformation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPersonalInformation.Location = new System.Drawing.Point(0, 0);
            this.lblPersonalInformation.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lblPersonalInformation.Name = "lblPersonalInformation";
            this.lblPersonalInformation.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblPersonalInformation.Size = new System.Drawing.Size(202, 23);
            this.lblPersonalInformation.TabIndex = 0;
            this.lblPersonalInformation.Text = "Personal Information";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.Location = new System.Drawing.Point(251, 36);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(108, 17);
            this.lblContact.TabIndex = 13;
            this.lblContact.Text = "Contact Number";
            // 
            // txtbxContact
            // 
            this.txtbxContact.BackColor = System.Drawing.Color.White;
            this.txtbxContact.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtbxContact.Location = new System.Drawing.Point(255, 57);
            this.txtbxContact.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbxContact.MaxLength = 11;
            this.txtbxContact.Name = "txtbxContact";
            this.txtbxContact.Size = new System.Drawing.Size(239, 22);
            this.txtbxContact.TabIndex = 14;
            this.txtbxContact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxContact_KeyPress);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(252, 83);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(43, 17);
            this.lblEmail.TabIndex = 15;
            this.lblEmail.Text = "E-mail";
            // 
            // txtbxEmail
            // 
            this.txtbxEmail.BackColor = System.Drawing.Color.White;
            this.txtbxEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtbxEmail.Location = new System.Drawing.Point(255, 104);
            this.txtbxEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbxEmail.MaxLength = 120;
            this.txtbxEmail.Name = "txtbxEmail";
            this.txtbxEmail.Size = new System.Drawing.Size(239, 22);
            this.txtbxEmail.TabIndex = 16;
            this.txtbxEmail.Leave += new System.EventHandler(this.txtbxEmail_Leave);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(251, 130);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(55, 17);
            this.lblAddress.TabIndex = 17;
            this.lblAddress.Text = "Address";
            // 
            // txtbxAddress
            // 
            this.txtbxAddress.BackColor = System.Drawing.Color.White;
            this.txtbxAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtbxAddress.Location = new System.Drawing.Point(254, 151);
            this.txtbxAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbxAddress.MaxLength = 200;
            this.txtbxAddress.Multiline = true;
            this.txtbxAddress.Name = "txtbxAddress";
            this.txtbxAddress.Size = new System.Drawing.Size(239, 157);
            this.txtbxAddress.TabIndex = 18;
            this.txtbxAddress.Leave += new System.EventHandler(this.txtbxAddress_Leave);
            // 
            // lblSelectedBirthdate
            // 
            this.lblSelectedBirthdate.AutoSize = true;
            this.lblSelectedBirthdate.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedBirthdate.Location = new System.Drawing.Point(69, 223);
            this.lblSelectedBirthdate.Name = "lblSelectedBirthdate";
            this.lblSelectedBirthdate.Size = new System.Drawing.Size(78, 17);
            this.lblSelectedBirthdate.TabIndex = 11;
            this.lblSelectedBirthdate.Text = "mm-dd-yyyy";
            this.lblSelectedBirthdate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblJobInformation
            // 
            this.lblJobInformation.AutoSize = true;
            this.lblJobInformation.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblJobInformation.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobInformation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblJobInformation.Location = new System.Drawing.Point(0, 0);
            this.lblJobInformation.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lblJobInformation.Name = "lblJobInformation";
            this.lblJobInformation.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblJobInformation.Size = new System.Drawing.Size(158, 23);
            this.lblJobInformation.TabIndex = 0;
            this.lblJobInformation.Text = "Job Information";
            // 
            // cmbxPaymentMode
            // 
            this.cmbxPaymentMode.BackColor = System.Drawing.Color.White;
            this.cmbxPaymentMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxPaymentMode.FormattingEnabled = true;
            this.cmbxPaymentMode.Items.AddRange(new object[] {
            "Bank Draft",
            "Bill of Exchange",
            "Cash Payment",
            "Cheque",
            "Money/Postal Order",
            "Promissory Note",
            "Telegraphic/Mail Transfer"});
            this.cmbxPaymentMode.Location = new System.Drawing.Point(11, 380);
            this.cmbxPaymentMode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbxPaymentMode.Name = "cmbxPaymentMode";
            this.cmbxPaymentMode.Size = new System.Drawing.Size(210, 25);
            this.cmbxPaymentMode.TabIndex = 17;
            // 
            // lblPaymentMode
            // 
            this.lblPaymentMode.AutoSize = true;
            this.lblPaymentMode.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentMode.Location = new System.Drawing.Point(10, 359);
            this.lblPaymentMode.Name = "lblPaymentMode";
            this.lblPaymentMode.Size = new System.Drawing.Size(98, 17);
            this.lblPaymentMode.TabIndex = 16;
            this.lblPaymentMode.Text = "Payment Mode";
            // 
            // txtbxContractDuration
            // 
            this.txtbxContractDuration.BackColor = System.Drawing.Color.White;
            this.txtbxContractDuration.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtbxContractDuration.Location = new System.Drawing.Point(11, 333);
            this.txtbxContractDuration.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbxContractDuration.MaxLength = 3;
            this.txtbxContractDuration.Name = "txtbxContractDuration";
            this.txtbxContractDuration.Size = new System.Drawing.Size(153, 22);
            this.txtbxContractDuration.TabIndex = 14;
            this.txtbxContractDuration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxContractDuration_KeyPress);
            // 
            // lblContractDuration
            // 
            this.lblContractDuration.AutoSize = true;
            this.lblContractDuration.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContractDuration.Location = new System.Drawing.Point(10, 312);
            this.lblContractDuration.Name = "lblContractDuration";
            this.lblContractDuration.Size = new System.Drawing.Size(116, 17);
            this.lblContractDuration.TabIndex = 13;
            this.lblContractDuration.Text = "Contract Duration";
            // 
            // pnlJobInfo
            // 
            this.pnlJobInfo.BackColor = System.Drawing.Color.White;
            this.pnlJobInfo.Controls.Add(this.lblJobInformation);
            this.pnlJobInfo.Controls.Add(this.cmbxPaymentMode);
            this.pnlJobInfo.Controls.Add(this.txtbxHourlyRate);
            this.pnlJobInfo.Controls.Add(this.lblPaymentMode);
            this.pnlJobInfo.Controls.Add(this.lblHourlyRate);
            this.pnlJobInfo.Controls.Add(this.txtbxWorkingHours);
            this.pnlJobInfo.Controls.Add(this.txtbxContractDuration);
            this.pnlJobInfo.Controls.Add(this.lblWorkingHours);
            this.pnlJobInfo.Controls.Add(this.lblWorkingHoursPerMonth);
            this.pnlJobInfo.Controls.Add(this.lblHourlyRatePerHour);
            this.pnlJobInfo.Controls.Add(this.lblContractDurationMonths);
            this.pnlJobInfo.Controls.Add(this.lblContractDuration);
            this.pnlJobInfo.Controls.Add(this.cmbxStatus);
            this.pnlJobInfo.Controls.Add(this.lblStatus);
            this.pnlJobInfo.Controls.Add(this.lblDepartment);
            this.pnlJobInfo.Controls.Add(this.cmbxPosition);
            this.pnlJobInfo.Controls.Add(this.cmbxDepartment);
            this.pnlJobInfo.Controls.Add(this.lblPosition);
            this.pnlJobInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlJobInfo.Location = new System.Drawing.Point(514, 0);
            this.pnlJobInfo.Name = "pnlJobInfo";
            this.pnlJobInfo.Size = new System.Drawing.Size(240, 431);
            this.pnlJobInfo.TabIndex = 1;
            // 
            // lblWorkingHoursPerMonth
            // 
            this.lblWorkingHoursPerMonth.AutoSize = true;
            this.lblWorkingHoursPerMonth.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkingHoursPerMonth.Location = new System.Drawing.Point(170, 242);
            this.lblWorkingHoursPerMonth.Name = "lblWorkingHoursPerMonth";
            this.lblWorkingHoursPerMonth.Size = new System.Drawing.Size(51, 17);
            this.lblWorkingHoursPerMonth.TabIndex = 9;
            this.lblWorkingHoursPerMonth.Text = "/month";
            // 
            // lblHourlyRatePerHour
            // 
            this.lblHourlyRatePerHour.AutoSize = true;
            this.lblHourlyRatePerHour.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHourlyRatePerHour.Location = new System.Drawing.Point(170, 289);
            this.lblHourlyRatePerHour.Name = "lblHourlyRatePerHour";
            this.lblHourlyRatePerHour.Size = new System.Drawing.Size(47, 17);
            this.lblHourlyRatePerHour.TabIndex = 12;
            this.lblHourlyRatePerHour.Text = "₱/hour";
            // 
            // lblContractDurationMonths
            // 
            this.lblContractDurationMonths.AutoSize = true;
            this.lblContractDurationMonths.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContractDurationMonths.Location = new System.Drawing.Point(170, 336);
            this.lblContractDurationMonths.Name = "lblContractDurationMonths";
            this.lblContractDurationMonths.Size = new System.Drawing.Size(51, 17);
            this.lblContractDurationMonths.TabIndex = 15;
            this.lblContractDurationMonths.Text = "months";
            // 
            // btnUploadImage
            // 
            this.btnUploadImage.BackColor = System.Drawing.Color.White;
            this.btnUploadImage.BackgroundImage = global::Fireon.Properties.Resources.btnUploadImage;
            this.btnUploadImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUploadImage.FlatAppearance.BorderSize = 0;
            this.btnUploadImage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnUploadImage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnUploadImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadImage.Location = new System.Drawing.Point(762, 169);
            this.btnUploadImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUploadImage.Name = "btnUploadImage";
            this.btnUploadImage.Size = new System.Drawing.Size(130, 25);
            this.btnUploadImage.TabIndex = 3;
            this.btnUploadImage.UseVisualStyleBackColor = false;
            this.btnUploadImage.Click += new System.EventHandler(this.btnUploadDP_Click);
            // 
            // picbDP
            // 
            this.picbDP.BackColor = System.Drawing.Color.White;
            this.picbDP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picbDP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picbDP.Image = global::Fireon.Properties.Resources.miscIconUploadImage;
            this.picbDP.Location = new System.Drawing.Point(762, 36);
            this.picbDP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picbDP.Name = "picbDP";
            this.picbDP.Size = new System.Drawing.Size(130, 125);
            this.picbDP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbDP.TabIndex = 43;
            this.picbDP.TabStop = false;
            // 
            // lblFiles
            // 
            this.lblFiles.AutoSize = true;
            this.lblFiles.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFiles.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblFiles.Location = new System.Drawing.Point(754, 0);
            this.lblFiles.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lblFiles.Name = "lblFiles";
            this.lblFiles.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblFiles.Size = new System.Drawing.Size(54, 23);
            this.lblFiles.TabIndex = 2;
            this.lblFiles.Text = "Files";
            // 
            // btnUploadFile
            // 
            this.btnUploadFile.BackColor = System.Drawing.Color.White;
            this.btnUploadFile.BackgroundImage = global::Fireon.Properties.Resources.btnUploadDocument;
            this.btnUploadFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUploadFile.FlatAppearance.BorderSize = 0;
            this.btnUploadFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnUploadFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnUploadFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadFile.Location = new System.Drawing.Point(759, 380);
            this.btnUploadFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUploadFile.Name = "btnUploadFile";
            this.btnUploadFile.Size = new System.Drawing.Size(137, 25);
            this.btnUploadFile.TabIndex = 5;
            this.btnUploadFile.UseVisualStyleBackColor = false;
            this.btnUploadFile.Click += new System.EventHandler(this.btnUploadDP_Click);
            // 
            // lsbxFileList
            // 
            this.lsbxFileList.FormattingEnabled = true;
            this.lsbxFileList.HorizontalScrollbar = true;
            this.lsbxFileList.ItemHeight = 17;
            this.lsbxFileList.Location = new System.Drawing.Point(762, 206);
            this.lsbxFileList.Name = "lsbxFileList";
            this.lsbxFileList.Size = new System.Drawing.Size(130, 157);
            this.lsbxFileList.TabIndex = 4;
            this.lsbxFileList.Click += new System.EventHandler(this.lsbxFileList_Click);
            // 
            // ucNewEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lsbxFileList);
            this.Controls.Add(this.lblFiles);
            this.Controls.Add(this.btnUploadFile);
            this.Controls.Add(this.btnUploadImage);
            this.Controls.Add(this.pnlJobInfo);
            this.Controls.Add(this.pnlPersonalInfo);
            this.Controls.Add(this.picbDP);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ucNewEmployee";
            this.Size = new System.Drawing.Size(900, 431);
            this.Load += new System.EventHandler(this.ucNewEmployee_Load);
            this.pnlPersonalInfo.ResumeLayout(false);
            this.pnlPersonalInfo.PerformLayout();
            this.pnlJobInfo.ResumeLayout(false);
            this.pnlJobInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbDP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblFirstName;
        public System.Windows.Forms.Label lblMiddleInitial;
        public System.Windows.Forms.Label lblLastName;
        public System.Windows.Forms.TextBox txtbxFirstName;
        public System.Windows.Forms.TextBox txtbxMiddleInitial;
        public System.Windows.Forms.TextBox txtbxLastName;
        public System.Windows.Forms.Label lblSex;
        public System.Windows.Forms.Label lblBirthdate;
        public System.Windows.Forms.Label lblMaritalStatus;
        public System.Windows.Forms.ComboBox cmbxMaritalStatus;
        public System.Windows.Forms.Label lblNationality;
        public System.Windows.Forms.TextBox txtbxNationality;
        public System.Windows.Forms.Label lblDepartment;
        public System.Windows.Forms.ComboBox cmbxDepartment;
        public System.Windows.Forms.Label lblPosition;
        public System.Windows.Forms.ComboBox cmbxPosition;
        public System.Windows.Forms.Label lblStatus;
        public System.Windows.Forms.ComboBox cmbxStatus;
        public System.Windows.Forms.Label lblWorkingHours;
        public System.Windows.Forms.TextBox txtbxWorkingHours;
        public System.Windows.Forms.Label lblHourlyRate;
        public System.Windows.Forms.TextBox txtbxHourlyRate;
        public System.Windows.Forms.MonthCalendar mcBirthdate;
        public System.Windows.Forms.RadioButton rdbtnMale;
        public System.Windows.Forms.RadioButton rdbtnFemale;
        public System.Windows.Forms.OpenFileDialog ofdUploadFile;
        private System.Windows.Forms.Panel pnlPersonalInfo;
        public System.Windows.Forms.Label lblPersonalInformation;
        public System.Windows.Forms.Label lblJobInformation;
        public System.Windows.Forms.ComboBox cmbxPaymentMode;
        public System.Windows.Forms.Label lblPaymentMode;
        public System.Windows.Forms.TextBox txtbxContractDuration;
        public System.Windows.Forms.Label lblContractDuration;
        public System.Windows.Forms.Label lblContact;
        public System.Windows.Forms.TextBox txtbxContact;
        public System.Windows.Forms.Label lblEmail;
        public System.Windows.Forms.TextBox txtbxEmail;
        public System.Windows.Forms.Label lblAddress;
        public System.Windows.Forms.TextBox txtbxAddress;
        private System.Windows.Forms.Panel pnlJobInfo;
        public System.Windows.Forms.Button btnUploadImage;
        public System.Windows.Forms.PictureBox picbDP;
        public System.Windows.Forms.Label lblSelectedBirthdate;
        public System.Windows.Forms.Label lblHourlyRatePerHour;
        public System.Windows.Forms.Label lblContractDurationMonths;
        public System.Windows.Forms.Label lblWorkingHoursPerMonth;
        public System.Windows.Forms.Label lblFiles;
        public System.Windows.Forms.Button btnUploadFile;
        public System.Windows.Forms.ListBox lsbxFileList;
    }
}
