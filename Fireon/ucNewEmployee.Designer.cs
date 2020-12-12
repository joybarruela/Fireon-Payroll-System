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
            this.picbDP = new System.Windows.Forms.PictureBox();
            this.btnUploadDP = new System.Windows.Forms.Button();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblMiddleInitial = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtbxFirstName = new System.Windows.Forms.TextBox();
            this.txtbxMiddleInitial = new System.Windows.Forms.TextBox();
            this.txtbxLastName = new System.Windows.Forms.TextBox();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.txtbxContact = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtbxEmail = new System.Windows.Forms.TextBox();
            this.lblBirthdate = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtbxAddress = new System.Windows.Forms.TextBox();
            this.lblMaritalStatus = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
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
            this.lblContractDuration = new System.Windows.Forms.Label();
            this.txtbxContractDuration = new System.Windows.Forms.TextBox();
            this.lblPaymentMode = new System.Windows.Forms.Label();
            this.cmbxPaymentMode = new System.Windows.Forms.ComboBox();
            this.mcBirthdate = new System.Windows.Forms.MonthCalendar();
            this.rdbtnMale = new System.Windows.Forms.RadioButton();
            this.rdbtnFemale = new System.Windows.Forms.RadioButton();
            this.ofdUploadDP = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picbDP)).BeginInit();
            this.SuspendLayout();
            // 
            // picbDP
            // 
            this.picbDP.BackColor = System.Drawing.Color.LightGray;
            this.picbDP.Image = global::Fireon.Properties.Resources.btnIconAdd;
            this.picbDP.Location = new System.Drawing.Point(668, 17);
            this.picbDP.Name = "picbDP";
            this.picbDP.Size = new System.Drawing.Size(200, 200);
            this.picbDP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbDP.TabIndex = 0;
            this.picbDP.TabStop = false;
            // 
            // btnUploadDP
            // 
            this.btnUploadDP.Location = new System.Drawing.Point(668, 239);
            this.btnUploadDP.Name = "btnUploadDP";
            this.btnUploadDP.Size = new System.Drawing.Size(200, 23);
            this.btnUploadDP.TabIndex = 35;
            this.btnUploadDP.Text = "Upload Image";
            this.btnUploadDP.UseVisualStyleBackColor = true;
            this.btnUploadDP.Click += new System.EventHandler(this.btnUploadDP_Click);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(35, 21);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(49, 13);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "firstname";
            // 
            // lblMiddleInitial
            // 
            this.lblMiddleInitial.AutoSize = true;
            this.lblMiddleInitial.Location = new System.Drawing.Point(24, 53);
            this.lblMiddleInitial.Name = "lblMiddleInitial";
            this.lblMiddleInitial.Size = new System.Drawing.Size(60, 13);
            this.lblMiddleInitial.TabIndex = 2;
            this.lblMiddleInitial.Text = "middleinitial";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(35, 85);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(49, 13);
            this.lblLastName.TabIndex = 4;
            this.lblLastName.Text = "lastname";
            // 
            // txtbxFirstName
            // 
            this.txtbxFirstName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtbxFirstName.Location = new System.Drawing.Point(90, 18);
            this.txtbxFirstName.MaxLength = 120;
            this.txtbxFirstName.Name = "txtbxFirstName";
            this.txtbxFirstName.Size = new System.Drawing.Size(227, 20);
            this.txtbxFirstName.TabIndex = 1;
            this.txtbxFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxFirstName_KeyPress);
            this.txtbxFirstName.Leave += new System.EventHandler(this.txtbxFirstName_Leave);
            // 
            // txtbxMiddleInitial
            // 
            this.txtbxMiddleInitial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtbxMiddleInitial.Location = new System.Drawing.Point(90, 50);
            this.txtbxMiddleInitial.MaxLength = 3;
            this.txtbxMiddleInitial.Name = "txtbxMiddleInitial";
            this.txtbxMiddleInitial.Size = new System.Drawing.Size(71, 20);
            this.txtbxMiddleInitial.TabIndex = 3;
            this.txtbxMiddleInitial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxMiddleName_KeyPress);
            this.txtbxMiddleInitial.Leave += new System.EventHandler(this.txtbxMiddleInitial_Leave);
            // 
            // txtbxLastName
            // 
            this.txtbxLastName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtbxLastName.Location = new System.Drawing.Point(90, 82);
            this.txtbxLastName.MaxLength = 120;
            this.txtbxLastName.Name = "txtbxLastName";
            this.txtbxLastName.Size = new System.Drawing.Size(227, 20);
            this.txtbxLastName.TabIndex = 5;
            this.txtbxLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxLastName_KeyPress);
            this.txtbxLastName.Leave += new System.EventHandler(this.txtbxLastName_Leave);
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(61, 116);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(23, 13);
            this.lblSex.TabIndex = 6;
            this.lblSex.Text = "sex";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(41, 146);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(43, 13);
            this.lblContact.TabIndex = 9;
            this.lblContact.Text = "contact";
            // 
            // txtbxContact
            // 
            this.txtbxContact.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtbxContact.Location = new System.Drawing.Point(90, 143);
            this.txtbxContact.MaxLength = 11;
            this.txtbxContact.Name = "txtbxContact";
            this.txtbxContact.Size = new System.Drawing.Size(227, 20);
            this.txtbxContact.TabIndex = 10;
            this.txtbxContact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxContact_KeyPress);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(53, 178);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(31, 13);
            this.lblEmail.TabIndex = 11;
            this.lblEmail.Text = "email";
            // 
            // txtbxEmail
            // 
            this.txtbxEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtbxEmail.Location = new System.Drawing.Point(90, 175);
            this.txtbxEmail.MaxLength = 120;
            this.txtbxEmail.Name = "txtbxEmail";
            this.txtbxEmail.Size = new System.Drawing.Size(227, 20);
            this.txtbxEmail.TabIndex = 12;
            this.txtbxEmail.Leave += new System.EventHandler(this.txtbxEmail_Leave);
            // 
            // lblBirthdate
            // 
            this.lblBirthdate.AutoSize = true;
            this.lblBirthdate.Location = new System.Drawing.Point(36, 273);
            this.lblBirthdate.Name = "lblBirthdate";
            this.lblBirthdate.Size = new System.Drawing.Size(48, 13);
            this.lblBirthdate.TabIndex = 15;
            this.lblBirthdate.Text = "birthdate";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(41, 210);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(44, 13);
            this.lblAddress.TabIndex = 13;
            this.lblAddress.Text = "address";
            // 
            // txtbxAddress
            // 
            this.txtbxAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtbxAddress.Location = new System.Drawing.Point(90, 207);
            this.txtbxAddress.Multiline = true;
            this.txtbxAddress.Name = "txtbxAddress";
            this.txtbxAddress.Size = new System.Drawing.Size(227, 44);
            this.txtbxAddress.TabIndex = 14;
            this.txtbxAddress.Leave += new System.EventHandler(this.txtbxAddress_Leave);
            // 
            // lblMaritalStatus
            // 
            this.lblMaritalStatus.AutoSize = true;
            this.lblMaritalStatus.Location = new System.Drawing.Point(355, 25);
            this.lblMaritalStatus.Name = "lblMaritalStatus";
            this.lblMaritalStatus.Size = new System.Drawing.Size(68, 13);
            this.lblMaritalStatus.TabIndex = 17;
            this.lblMaritalStatus.Text = "marital status";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Married",
            "Widowed",
            "Separated",
            "Divorced",
            "Single"});
            this.comboBox1.Location = new System.Drawing.Point(429, 17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(181, 21);
            this.comboBox1.TabIndex = 18;
            // 
            // lblNationality
            // 
            this.lblNationality.AutoSize = true;
            this.lblNationality.Location = new System.Drawing.Point(369, 57);
            this.lblNationality.Name = "lblNationality";
            this.lblNationality.Size = new System.Drawing.Size(54, 13);
            this.lblNationality.TabIndex = 19;
            this.lblNationality.Text = "nationality";
            // 
            // txtbxNationality
            // 
            this.txtbxNationality.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtbxNationality.Location = new System.Drawing.Point(429, 50);
            this.txtbxNationality.Name = "txtbxNationality";
            this.txtbxNationality.Size = new System.Drawing.Size(181, 20);
            this.txtbxNationality.TabIndex = 20;
            this.txtbxNationality.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxNationality_KeyPress);
            this.txtbxNationality.Leave += new System.EventHandler(this.txtbxNationality_Leave);
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(363, 85);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(60, 13);
            this.lblDepartment.TabIndex = 21;
            this.lblDepartment.Text = "department";
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
            this.cmbxDepartment.Location = new System.Drawing.Point(429, 81);
            this.cmbxDepartment.Name = "cmbxDepartment";
            this.cmbxDepartment.Size = new System.Drawing.Size(181, 21);
            this.cmbxDepartment.TabIndex = 22;
            this.cmbxDepartment.SelectedIndexChanged += new System.EventHandler(this.cmbxDepartment_SelectedIndexChanged);
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(380, 249);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(43, 13);
            this.lblPosition.TabIndex = 23;
            this.lblPosition.Text = "position";
            // 
            // cmbxPosition
            // 
            this.cmbxPosition.BackColor = System.Drawing.Color.White;
            this.cmbxPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxPosition.FormattingEnabled = true;
            this.cmbxPosition.Items.AddRange(new object[] {
            "Position 1",
            "Position 2",
            "Position 3",
            "Position 4",
            "Position 5"});
            this.cmbxPosition.Location = new System.Drawing.Point(429, 241);
            this.cmbxPosition.Name = "cmbxPosition";
            this.cmbxPosition.Size = new System.Drawing.Size(181, 21);
            this.cmbxPosition.TabIndex = 24;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(388, 277);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(35, 13);
            this.lblStatus.TabIndex = 25;
            this.lblStatus.Text = "status";
            // 
            // cmbxStatus
            // 
            this.cmbxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxStatus.FormattingEnabled = true;
            this.cmbxStatus.Items.AddRange(new object[] {
            "Contractual",
            "Regular"});
            this.cmbxStatus.Location = new System.Drawing.Point(429, 273);
            this.cmbxStatus.Name = "cmbxStatus";
            this.cmbxStatus.Size = new System.Drawing.Size(181, 21);
            this.cmbxStatus.TabIndex = 26;
            this.cmbxStatus.SelectedIndexChanged += new System.EventHandler(this.cmbxStatus_SelectedIndexChanged);
            // 
            // lblWorkingHours
            // 
            this.lblWorkingHours.AutoSize = true;
            this.lblWorkingHours.Location = new System.Drawing.Point(350, 309);
            this.lblWorkingHours.Name = "lblWorkingHours";
            this.lblWorkingHours.Size = new System.Drawing.Size(73, 13);
            this.lblWorkingHours.TabIndex = 27;
            this.lblWorkingHours.Text = "working hours";
            // 
            // txtbxWorkingHours
            // 
            this.txtbxWorkingHours.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtbxWorkingHours.Location = new System.Drawing.Point(429, 306);
            this.txtbxWorkingHours.MaxLength = 3;
            this.txtbxWorkingHours.Name = "txtbxWorkingHours";
            this.txtbxWorkingHours.Size = new System.Drawing.Size(181, 20);
            this.txtbxWorkingHours.TabIndex = 28;
            this.txtbxWorkingHours.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxWorkingHours_KeyPress);
            // 
            // lblHourlyRate
            // 
            this.lblHourlyRate.AutoSize = true;
            this.lblHourlyRate.Location = new System.Drawing.Point(369, 340);
            this.lblHourlyRate.Name = "lblHourlyRate";
            this.lblHourlyRate.Size = new System.Drawing.Size(56, 13);
            this.lblHourlyRate.TabIndex = 29;
            this.lblHourlyRate.Text = "hourly rate";
            // 
            // txtbxHourlyRate
            // 
            this.txtbxHourlyRate.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtbxHourlyRate.Location = new System.Drawing.Point(429, 337);
            this.txtbxHourlyRate.Name = "txtbxHourlyRate";
            this.txtbxHourlyRate.Size = new System.Drawing.Size(181, 20);
            this.txtbxHourlyRate.TabIndex = 30;
            this.txtbxHourlyRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxHourlyRate_KeyPress);
            // 
            // lblContractDuration
            // 
            this.lblContractDuration.AutoSize = true;
            this.lblContractDuration.Location = new System.Drawing.Point(338, 372);
            this.lblContractDuration.Name = "lblContractDuration";
            this.lblContractDuration.Size = new System.Drawing.Size(87, 13);
            this.lblContractDuration.TabIndex = 31;
            this.lblContractDuration.Text = "contract duration";
            // 
            // txtbxContractDuration
            // 
            this.txtbxContractDuration.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtbxContractDuration.Location = new System.Drawing.Point(429, 369);
            this.txtbxContractDuration.Name = "txtbxContractDuration";
            this.txtbxContractDuration.Size = new System.Drawing.Size(181, 20);
            this.txtbxContractDuration.TabIndex = 32;
            this.txtbxContractDuration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxContractDuration_KeyPress);
            // 
            // lblPaymentMode
            // 
            this.lblPaymentMode.AutoSize = true;
            this.lblPaymentMode.Location = new System.Drawing.Point(347, 407);
            this.lblPaymentMode.Name = "lblPaymentMode";
            this.lblPaymentMode.Size = new System.Drawing.Size(76, 13);
            this.lblPaymentMode.TabIndex = 33;
            this.lblPaymentMode.Text = "payment mode";
            // 
            // cmbxPaymentMode
            // 
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
            this.cmbxPaymentMode.Location = new System.Drawing.Point(429, 404);
            this.cmbxPaymentMode.Name = "cmbxPaymentMode";
            this.cmbxPaymentMode.Size = new System.Drawing.Size(181, 21);
            this.cmbxPaymentMode.TabIndex = 34;
            // 
            // mcBirthdate
            // 
            this.mcBirthdate.Location = new System.Drawing.Point(90, 263);
            this.mcBirthdate.Name = "mcBirthdate";
            this.mcBirthdate.TabIndex = 16;
            // 
            // rdbtnMale
            // 
            this.rdbtnMale.AutoSize = true;
            this.rdbtnMale.Location = new System.Drawing.Point(90, 114);
            this.rdbtnMale.Name = "rdbtnMale";
            this.rdbtnMale.Size = new System.Drawing.Size(48, 17);
            this.rdbtnMale.TabIndex = 7;
            this.rdbtnMale.TabStop = true;
            this.rdbtnMale.Text = "Male";
            this.rdbtnMale.UseVisualStyleBackColor = true;
            // 
            // rdbtnFemale
            // 
            this.rdbtnFemale.AutoSize = true;
            this.rdbtnFemale.Location = new System.Drawing.Point(144, 114);
            this.rdbtnFemale.Name = "rdbtnFemale";
            this.rdbtnFemale.Size = new System.Drawing.Size(59, 17);
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
            // ucNewEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rdbtnFemale);
            this.Controls.Add(this.rdbtnMale);
            this.Controls.Add(this.cmbxPaymentMode);
            this.Controls.Add(this.lblPaymentMode);
            this.Controls.Add(this.txtbxContractDuration);
            this.Controls.Add(this.lblContractDuration);
            this.Controls.Add(this.txtbxHourlyRate);
            this.Controls.Add(this.lblHourlyRate);
            this.Controls.Add(this.txtbxWorkingHours);
            this.Controls.Add(this.lblWorkingHours);
            this.Controls.Add(this.cmbxStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.cmbxPosition);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.cmbxDepartment);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.txtbxNationality);
            this.Controls.Add(this.lblNationality);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblMaritalStatus);
            this.Controls.Add(this.txtbxAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.mcBirthdate);
            this.Controls.Add(this.lblBirthdate);
            this.Controls.Add(this.txtbxEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtbxContact);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.lblSex);
            this.Controls.Add(this.txtbxLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtbxMiddleInitial);
            this.Controls.Add(this.lblMiddleInitial);
            this.Controls.Add(this.txtbxFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.btnUploadDP);
            this.Controls.Add(this.picbDP);
            this.Name = "ucNewEmployee";
            this.Size = new System.Drawing.Size(900, 500);
            this.Load += new System.EventHandler(this.ucNewEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbDP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picbDP;
        private System.Windows.Forms.Button btnUploadDP;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblMiddleInitial;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtbxFirstName;
        private System.Windows.Forms.TextBox txtbxMiddleInitial;
        private System.Windows.Forms.TextBox txtbxLastName;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.TextBox txtbxContact;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtbxEmail;
        private System.Windows.Forms.Label lblBirthdate;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtbxAddress;
        private System.Windows.Forms.Label lblMaritalStatus;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblNationality;
        private System.Windows.Forms.TextBox txtbxNationality;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.ComboBox cmbxDepartment;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.ComboBox cmbxPosition;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbxStatus;
        private System.Windows.Forms.Label lblWorkingHours;
        private System.Windows.Forms.TextBox txtbxWorkingHours;
        private System.Windows.Forms.Label lblHourlyRate;
        private System.Windows.Forms.TextBox txtbxHourlyRate;
        private System.Windows.Forms.Label lblContractDuration;
        private System.Windows.Forms.TextBox txtbxContractDuration;
        private System.Windows.Forms.Label lblPaymentMode;
        private System.Windows.Forms.ComboBox cmbxPaymentMode;
        private System.Windows.Forms.MonthCalendar mcBirthdate;
        private System.Windows.Forms.RadioButton rdbtnMale;
        private System.Windows.Forms.RadioButton rdbtnFemale;
        private System.Windows.Forms.OpenFileDialog ofdUploadDP;
    }
}
