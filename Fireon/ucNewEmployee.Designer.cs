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
            this.ofdUploadDP = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPersonalInformation = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.txtbxContact = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtbxEmail = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtbxAddress = new System.Windows.Forms.TextBox();
            this.lblJobInformation = new System.Windows.Forms.Label();
            this.cmbxPaymentMode = new System.Windows.Forms.ComboBox();
            this.lblPaymentMode = new System.Windows.Forms.Label();
            this.txtbxContractDuration = new System.Windows.Forms.TextBox();
            this.lblContractDuration = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnUploadDP = new System.Windows.Forms.Button();
            this.picbDP = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbDP)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(5, 46);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(70, 17);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name";
            // 
            // lblMiddleInitial
            // 
            this.lblMiddleInitial.AutoSize = true;
            this.lblMiddleInitial.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiddleInitial.Location = new System.Drawing.Point(6, 93);
            this.lblMiddleInitial.Name = "lblMiddleInitial";
            this.lblMiddleInitial.Size = new System.Drawing.Size(84, 17);
            this.lblMiddleInitial.TabIndex = 2;
            this.lblMiddleInitial.Text = "Middle Initial";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(6, 140);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(71, 17);
            this.lblLastName.TabIndex = 4;
            this.lblLastName.Text = "Last Name";
            // 
            // txtbxFirstName
            // 
            this.txtbxFirstName.BackColor = System.Drawing.Color.White;
            this.txtbxFirstName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtbxFirstName.Location = new System.Drawing.Point(9, 67);
            this.txtbxFirstName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbxFirstName.MaxLength = 120;
            this.txtbxFirstName.Name = "txtbxFirstName";
            this.txtbxFirstName.Size = new System.Drawing.Size(227, 22);
            this.txtbxFirstName.TabIndex = 1;
            this.txtbxFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxFirstName_KeyPress);
            this.txtbxFirstName.Leave += new System.EventHandler(this.txtbxFirstName_Leave);
            // 
            // txtbxMiddleInitial
            // 
            this.txtbxMiddleInitial.BackColor = System.Drawing.Color.White;
            this.txtbxMiddleInitial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtbxMiddleInitial.Location = new System.Drawing.Point(9, 114);
            this.txtbxMiddleInitial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbxMiddleInitial.MaxLength = 3;
            this.txtbxMiddleInitial.Name = "txtbxMiddleInitial";
            this.txtbxMiddleInitial.Size = new System.Drawing.Size(81, 22);
            this.txtbxMiddleInitial.TabIndex = 3;
            this.txtbxMiddleInitial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxMiddleName_KeyPress);
            this.txtbxMiddleInitial.Leave += new System.EventHandler(this.txtbxMiddleInitial_Leave);
            // 
            // txtbxLastName
            // 
            this.txtbxLastName.BackColor = System.Drawing.Color.White;
            this.txtbxLastName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtbxLastName.Location = new System.Drawing.Point(8, 161);
            this.txtbxLastName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbxLastName.MaxLength = 120;
            this.txtbxLastName.Name = "txtbxLastName";
            this.txtbxLastName.Size = new System.Drawing.Size(227, 22);
            this.txtbxLastName.TabIndex = 5;
            this.txtbxLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxLastName_KeyPress);
            this.txtbxLastName.Leave += new System.EventHandler(this.txtbxLastName_Leave);
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSex.Location = new System.Drawing.Point(6, 187);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(29, 17);
            this.lblSex.TabIndex = 6;
            this.lblSex.Text = "Sex";
            // 
            // lblBirthdate
            // 
            this.lblBirthdate.AutoSize = true;
            this.lblBirthdate.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthdate.Location = new System.Drawing.Point(4, 233);
            this.lblBirthdate.Name = "lblBirthdate";
            this.lblBirthdate.Size = new System.Drawing.Size(63, 17);
            this.lblBirthdate.TabIndex = 15;
            this.lblBirthdate.Text = "Birthdate";
            // 
            // lblMaritalStatus
            // 
            this.lblMaritalStatus.AutoSize = true;
            this.lblMaritalStatus.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaritalStatus.Location = new System.Drawing.Point(252, 249);
            this.lblMaritalStatus.Name = "lblMaritalStatus";
            this.lblMaritalStatus.Size = new System.Drawing.Size(90, 17);
            this.lblMaritalStatus.TabIndex = 17;
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
            this.cmbxMaritalStatus.Location = new System.Drawing.Point(255, 270);
            this.cmbxMaritalStatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbxMaritalStatus.Name = "cmbxMaritalStatus";
            this.cmbxMaritalStatus.Size = new System.Drawing.Size(210, 25);
            this.cmbxMaritalStatus.TabIndex = 18;
            // 
            // lblNationality
            // 
            this.lblNationality.AutoSize = true;
            this.lblNationality.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNationality.Location = new System.Drawing.Point(252, 299);
            this.lblNationality.Name = "lblNationality";
            this.lblNationality.Size = new System.Drawing.Size(73, 17);
            this.lblNationality.TabIndex = 19;
            this.lblNationality.Text = "Nationality";
            // 
            // txtbxNationality
            // 
            this.txtbxNationality.BackColor = System.Drawing.Color.White;
            this.txtbxNationality.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtbxNationality.Location = new System.Drawing.Point(255, 320);
            this.txtbxNationality.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbxNationality.MaxLength = 45;
            this.txtbxNationality.Name = "txtbxNationality";
            this.txtbxNationality.Size = new System.Drawing.Size(210, 22);
            this.txtbxNationality.TabIndex = 20;
            this.txtbxNationality.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxNationality_KeyPress);
            this.txtbxNationality.Leave += new System.EventHandler(this.txtbxNationality_Leave);
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartment.Location = new System.Drawing.Point(14, 46);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(81, 17);
            this.lblDepartment.TabIndex = 21;
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
            "Operations",
            "Production",
            "Purchasing",
            "Research and Development",
            "Sales"});
            this.cmbxDepartment.Location = new System.Drawing.Point(15, 67);
            this.cmbxDepartment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbxDepartment.Name = "cmbxDepartment";
            this.cmbxDepartment.Size = new System.Drawing.Size(210, 25);
            this.cmbxDepartment.TabIndex = 22;
            this.cmbxDepartment.SelectedIndexChanged += new System.EventHandler(this.cmbxDepartment_SelectedIndexChanged);
            this.cmbxDepartment.Click += new System.EventHandler(this.cmbxDepartment_SelectedIndexChanged);
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.Location = new System.Drawing.Point(14, 96);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(54, 17);
            this.lblPosition.TabIndex = 23;
            this.lblPosition.Text = "Position";
            // 
            // cmbxPosition
            // 
            this.cmbxPosition.BackColor = System.Drawing.Color.White;
            this.cmbxPosition.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbxPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxPosition.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbxPosition.FormattingEnabled = true;
            this.cmbxPosition.Location = new System.Drawing.Point(15, 117);
            this.cmbxPosition.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbxPosition.Name = "cmbxPosition";
            this.cmbxPosition.Size = new System.Drawing.Size(210, 25);
            this.cmbxPosition.TabIndex = 24;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(14, 146);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(45, 17);
            this.lblStatus.TabIndex = 25;
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
            this.cmbxStatus.Location = new System.Drawing.Point(15, 167);
            this.cmbxStatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbxStatus.Name = "cmbxStatus";
            this.cmbxStatus.Size = new System.Drawing.Size(210, 25);
            this.cmbxStatus.TabIndex = 26;
            this.cmbxStatus.SelectedIndexChanged += new System.EventHandler(this.cmbxStatus_SelectedIndexChanged);
            // 
            // lblWorkingHours
            // 
            this.lblWorkingHours.AutoSize = true;
            this.lblWorkingHours.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkingHours.Location = new System.Drawing.Point(13, 196);
            this.lblWorkingHours.Name = "lblWorkingHours";
            this.lblWorkingHours.Size = new System.Drawing.Size(92, 17);
            this.lblWorkingHours.TabIndex = 27;
            this.lblWorkingHours.Text = "Working Hours";
            // 
            // txtbxWorkingHours
            // 
            this.txtbxWorkingHours.BackColor = System.Drawing.Color.White;
            this.txtbxWorkingHours.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtbxWorkingHours.Location = new System.Drawing.Point(15, 217);
            this.txtbxWorkingHours.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbxWorkingHours.MaxLength = 3;
            this.txtbxWorkingHours.Name = "txtbxWorkingHours";
            this.txtbxWorkingHours.Size = new System.Drawing.Size(210, 22);
            this.txtbxWorkingHours.TabIndex = 28;
            this.txtbxWorkingHours.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxWorkingHours_KeyPress);
            // 
            // lblHourlyRate
            // 
            this.lblHourlyRate.AutoSize = true;
            this.lblHourlyRate.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHourlyRate.Location = new System.Drawing.Point(14, 243);
            this.lblHourlyRate.Name = "lblHourlyRate";
            this.lblHourlyRate.Size = new System.Drawing.Size(75, 17);
            this.lblHourlyRate.TabIndex = 29;
            this.lblHourlyRate.Text = "Hourly Rate";
            // 
            // txtbxHourlyRate
            // 
            this.txtbxHourlyRate.BackColor = System.Drawing.Color.White;
            this.txtbxHourlyRate.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtbxHourlyRate.Location = new System.Drawing.Point(15, 264);
            this.txtbxHourlyRate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbxHourlyRate.MaxLength = 6;
            this.txtbxHourlyRate.Name = "txtbxHourlyRate";
            this.txtbxHourlyRate.Size = new System.Drawing.Size(210, 22);
            this.txtbxHourlyRate.TabIndex = 30;
            this.txtbxHourlyRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxHourlyRate_KeyPress);
            // 
            // mcBirthdate
            // 
            this.mcBirthdate.Location = new System.Drawing.Point(7, 254);
            this.mcBirthdate.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.mcBirthdate.Name = "mcBirthdate";
            this.mcBirthdate.TabIndex = 16;
            // 
            // rdbtnMale
            // 
            this.rdbtnMale.AutoSize = true;
            this.rdbtnMale.Location = new System.Drawing.Point(9, 207);
            this.rdbtnMale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbtnMale.Name = "rdbtnMale";
            this.rdbtnMale.Size = new System.Drawing.Size(56, 21);
            this.rdbtnMale.TabIndex = 7;
            this.rdbtnMale.TabStop = true;
            this.rdbtnMale.Text = "Male";
            this.rdbtnMale.UseVisualStyleBackColor = true;
            // 
            // rdbtnFemale
            // 
            this.rdbtnFemale.AutoSize = true;
            this.rdbtnFemale.Location = new System.Drawing.Point(72, 207);
            this.rdbtnFemale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbtnFemale.Name = "rdbtnFemale";
            this.rdbtnFemale.Size = new System.Drawing.Size(70, 21);
            this.rdbtnFemale.TabIndex = 8;
            this.rdbtnFemale.TabStop = true;
            this.rdbtnFemale.Text = "Female";
            this.rdbtnFemale.UseVisualStyleBackColor = true;
            // 
            // ofdUploadDP
            // 
            this.ofdUploadDP.DefaultExt = "png";
            this.ofdUploadDP.Filter = "PNG files|*.png|JPEG files|*.jpeg";
            this.ofdUploadDP.Title = "Choose Employee Picture";
            this.ofdUploadDP.FileOk += new System.ComponentModel.CancelEventHandler(this.ofdUploadDP_FileOk);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblPersonalInformation);
            this.panel1.Controls.Add(this.lblContact);
            this.panel1.Controls.Add(this.lblFirstName);
            this.panel1.Controls.Add(this.txtbxContact);
            this.panel1.Controls.Add(this.rdbtnFemale);
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.txtbxFirstName);
            this.panel1.Controls.Add(this.txtbxEmail);
            this.panel1.Controls.Add(this.rdbtnMale);
            this.panel1.Controls.Add(this.lblAddress);
            this.panel1.Controls.Add(this.txtbxAddress);
            this.panel1.Controls.Add(this.lblMiddleInitial);
            this.panel1.Controls.Add(this.txtbxMiddleInitial);
            this.panel1.Controls.Add(this.lblLastName);
            this.panel1.Controls.Add(this.txtbxLastName);
            this.panel1.Controls.Add(this.lblSex);
            this.panel1.Controls.Add(this.lblBirthdate);
            this.panel1.Controls.Add(this.mcBirthdate);
            this.panel1.Controls.Add(this.lblMaritalStatus);
            this.panel1.Controls.Add(this.cmbxMaritalStatus);
            this.panel1.Controls.Add(this.txtbxNationality);
            this.panel1.Controls.Add(this.lblNationality);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(514, 431);
            this.panel1.TabIndex = 36;
            // 
            // lblPersonalInformation
            // 
            this.lblPersonalInformation.AutoSize = true;
            this.lblPersonalInformation.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonalInformation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPersonalInformation.Location = new System.Drawing.Point(3, 10);
            this.lblPersonalInformation.Name = "lblPersonalInformation";
            this.lblPersonalInformation.Size = new System.Drawing.Size(197, 23);
            this.lblPersonalInformation.TabIndex = 0;
            this.lblPersonalInformation.Text = "Personal Information";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.Location = new System.Drawing.Point(251, 46);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(58, 17);
            this.lblContact.TabIndex = 37;
            this.lblContact.Text = "Contact";
            // 
            // txtbxContact
            // 
            this.txtbxContact.BackColor = System.Drawing.Color.White;
            this.txtbxContact.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtbxContact.Location = new System.Drawing.Point(255, 67);
            this.txtbxContact.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbxContact.MaxLength = 11;
            this.txtbxContact.Name = "txtbxContact";
            this.txtbxContact.Size = new System.Drawing.Size(239, 22);
            this.txtbxContact.TabIndex = 38;
            this.txtbxContact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxContact_KeyPress);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(252, 93);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(43, 17);
            this.lblEmail.TabIndex = 39;
            this.lblEmail.Text = "E-mail";
            // 
            // txtbxEmail
            // 
            this.txtbxEmail.BackColor = System.Drawing.Color.White;
            this.txtbxEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtbxEmail.Location = new System.Drawing.Point(255, 114);
            this.txtbxEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbxEmail.MaxLength = 120;
            this.txtbxEmail.Name = "txtbxEmail";
            this.txtbxEmail.Size = new System.Drawing.Size(239, 22);
            this.txtbxEmail.TabIndex = 40;
            this.txtbxEmail.Leave += new System.EventHandler(this.txtbxEmail_Leave);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(251, 140);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(55, 17);
            this.lblAddress.TabIndex = 41;
            this.lblAddress.Text = "Address";
            // 
            // txtbxAddress
            // 
            this.txtbxAddress.BackColor = System.Drawing.Color.White;
            this.txtbxAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtbxAddress.Location = new System.Drawing.Point(254, 161);
            this.txtbxAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbxAddress.MaxLength = 200;
            this.txtbxAddress.Multiline = true;
            this.txtbxAddress.Name = "txtbxAddress";
            this.txtbxAddress.Size = new System.Drawing.Size(239, 84);
            this.txtbxAddress.TabIndex = 42;
            this.txtbxAddress.Leave += new System.EventHandler(this.txtbxAddress_Leave);
            // 
            // lblJobInformation
            // 
            this.lblJobInformation.AutoSize = true;
            this.lblJobInformation.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobInformation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblJobInformation.Location = new System.Drawing.Point(13, 10);
            this.lblJobInformation.Name = "lblJobInformation";
            this.lblJobInformation.Size = new System.Drawing.Size(153, 23);
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
            "Telegraphic/Mail Transfer",
            "Bank Draft",
            "Bill of Exchange",
            "Cash Payment",
            "Cheque",
            "Money/Postal Order",
            "Promissory Note",
            "Telegraphic/Mail Transfer"});
            this.cmbxPaymentMode.Location = new System.Drawing.Point(15, 358);
            this.cmbxPaymentMode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbxPaymentMode.Name = "cmbxPaymentMode";
            this.cmbxPaymentMode.Size = new System.Drawing.Size(210, 25);
            this.cmbxPaymentMode.TabIndex = 46;
            // 
            // lblPaymentMode
            // 
            this.lblPaymentMode.AutoSize = true;
            this.lblPaymentMode.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentMode.Location = new System.Drawing.Point(14, 337);
            this.lblPaymentMode.Name = "lblPaymentMode";
            this.lblPaymentMode.Size = new System.Drawing.Size(98, 17);
            this.lblPaymentMode.TabIndex = 45;
            this.lblPaymentMode.Text = "Payment Mode";
            // 
            // txtbxContractDuration
            // 
            this.txtbxContractDuration.BackColor = System.Drawing.Color.White;
            this.txtbxContractDuration.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtbxContractDuration.Location = new System.Drawing.Point(15, 311);
            this.txtbxContractDuration.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbxContractDuration.MaxLength = 3;
            this.txtbxContractDuration.Name = "txtbxContractDuration";
            this.txtbxContractDuration.Size = new System.Drawing.Size(210, 22);
            this.txtbxContractDuration.TabIndex = 44;
            this.txtbxContractDuration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxContractDuration_KeyPress);
            // 
            // lblContractDuration
            // 
            this.lblContractDuration.AutoSize = true;
            this.lblContractDuration.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContractDuration.Location = new System.Drawing.Point(14, 290);
            this.lblContractDuration.Name = "lblContractDuration";
            this.lblContractDuration.Size = new System.Drawing.Size(116, 17);
            this.lblContractDuration.TabIndex = 43;
            this.lblContractDuration.Text = "Contract Duration";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblJobInformation);
            this.panel2.Controls.Add(this.cmbxPaymentMode);
            this.panel2.Controls.Add(this.txtbxHourlyRate);
            this.panel2.Controls.Add(this.lblPaymentMode);
            this.panel2.Controls.Add(this.lblHourlyRate);
            this.panel2.Controls.Add(this.txtbxWorkingHours);
            this.panel2.Controls.Add(this.txtbxContractDuration);
            this.panel2.Controls.Add(this.lblWorkingHours);
            this.panel2.Controls.Add(this.lblContractDuration);
            this.panel2.Controls.Add(this.cmbxStatus);
            this.panel2.Controls.Add(this.lblStatus);
            this.panel2.Controls.Add(this.lblDepartment);
            this.panel2.Controls.Add(this.cmbxPosition);
            this.panel2.Controls.Add(this.cmbxDepartment);
            this.panel2.Controls.Add(this.lblPosition);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(514, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 431);
            this.panel2.TabIndex = 47;
            // 
            // btnUploadDP
            // 
            this.btnUploadDP.BackColor = System.Drawing.Color.White;
            this.btnUploadDP.BackgroundImage = global::Fireon.Properties.Resources.btnUploadImage;
            this.btnUploadDP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUploadDP.FlatAppearance.BorderSize = 0;
            this.btnUploadDP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnUploadDP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnUploadDP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadDP.Location = new System.Drawing.Point(760, 177);
            this.btnUploadDP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUploadDP.Name = "btnUploadDP";
            this.btnUploadDP.Size = new System.Drawing.Size(130, 30);
            this.btnUploadDP.TabIndex = 44;
            this.btnUploadDP.UseVisualStyleBackColor = false;
            this.btnUploadDP.Click += new System.EventHandler(this.btnUploadDP_Click);
            // 
            // picbDP
            // 
            this.picbDP.BackColor = System.Drawing.Color.White;
            this.picbDP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picbDP.Image = global::Fireon.Properties.Resources.miscIconUploadImage;
            this.picbDP.Location = new System.Drawing.Point(760, 46);
            this.picbDP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picbDP.Name = "picbDP";
            this.picbDP.Size = new System.Drawing.Size(130, 130);
            this.picbDP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbDP.TabIndex = 43;
            this.picbDP.TabStop = false;
            // 
            // ucNewEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnUploadDP);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picbDP);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ucNewEmployee";
            this.Size = new System.Drawing.Size(900, 431);
            this.Load += new System.EventHandler(this.ucNewEmployee_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbDP)).EndInit();
            this.ResumeLayout(false);

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
        public System.Windows.Forms.OpenFileDialog ofdUploadDP;
        private System.Windows.Forms.Panel panel1;
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
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Button btnUploadDP;
        public System.Windows.Forms.PictureBox picbDP;
    }
}
