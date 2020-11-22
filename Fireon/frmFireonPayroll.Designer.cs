namespace Fireon
{
    partial class frmFireonPayroll
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFireonPayroll));
            this.pnl_header = new System.Windows.Forms.Panel();
            this.btn_menu = new JImageButton.JImageButton();
            this.btn_notification = new JImageButton.JImageButton();
            this.lbl_user = new System.Windows.Forms.Label();
            this.lbl_greeting = new System.Windows.Forms.Label();
            this.picb_user = new System.Windows.Forms.PictureBox();
            this.pnl_menu = new System.Windows.Forms.Panel();
            this.btn_logout = new System.Windows.Forms.Button();
            this.pnl_sidebar = new System.Windows.Forms.Panel();
            this.lbl_date_today = new System.Windows.Forms.Label();
            this.btn_settings = new JImageButton.JImageButton();
            this.pnl_separator_11 = new System.Windows.Forms.Panel();
            this.lbl_version = new System.Windows.Forms.Label();
            this.btn_single_posting = new JImageButton.JImageButton();
            this.pnl_separator_10 = new System.Windows.Forms.Panel();
            this.btn_department = new JImageButton.JImageButton();
            this.panel12 = new System.Windows.Forms.Panel();
            this.btn_all = new JImageButton.JImageButton();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_allowances = new JImageButton.JImageButton();
            this.pnl_separator_8 = new System.Windows.Forms.Panel();
            this.btn_deductions = new JImageButton.JImageButton();
            this.pnl_separator_7 = new System.Windows.Forms.Panel();
            this.btn_cash_advance = new JImageButton.JImageButton();
            this.pnl_separator_6 = new System.Windows.Forms.Panel();
            this.btn_violations = new JImageButton.JImageButton();
            this.pnl_separator_5 = new System.Windows.Forms.Panel();
            this.btn_holiday = new JImageButton.JImageButton();
            this.pnl_separator_4 = new System.Windows.Forms.Panel();
            this.btn_overtime = new JImageButton.JImageButton();
            this.pnl_separator_3 = new System.Windows.Forms.Panel();
            this.btn_leave = new JImageButton.JImageButton();
            this.pnl_separator_2 = new System.Windows.Forms.Panel();
            this.btn_employee = new JImageButton.JImageButton();
            this.lbl_manage_employee = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_dashboard = new JImageButton.JImageButton();
            this.pnl_separator_1 = new System.Windows.Forms.Panel();
            this.picb_fireon = new System.Windows.Forms.PictureBox();
            this.uc_settings = new Fireon.ucSettings();
            this.uc_single_posting = new Fireon.Single_Posting();
            this.uc_all = new Fireon.ucAll();
            this.uc_department = new Fireon.ucDepartment();
            this.uc_deductions = new Fireon.ucDeductions();
            this.uc_cash_advance = new Fireon.Cash_Advance();
            this.uc_violations = new Fireon.ucViolations();
            this.uc_allowances = new Fireon.ucAllowances();
            this.uc_holiday = new Fireon.ucHoliday();
            this.uc_overtime = new Fireon.ucOvertime();
            this.uc_leave = new Fireon.ucLeave();
            this.uc_employee = new Fireon.ucEmployee();
            this.uc_dashboard = new Fireon.ucDashboard();
            this.pnl_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picb_user)).BeginInit();
            this.pnl_menu.SuspendLayout();
            this.pnl_sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picb_fireon)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_header
            // 
            this.pnl_header.BackColor = System.Drawing.Color.Transparent;
            this.pnl_header.Controls.Add(this.btn_menu);
            this.pnl_header.Controls.Add(this.btn_notification);
            this.pnl_header.Controls.Add(this.lbl_user);
            this.pnl_header.Controls.Add(this.lbl_greeting);
            this.pnl_header.Controls.Add(this.picb_user);
            this.pnl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_header.Location = new System.Drawing.Point(252, 30);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Size = new System.Drawing.Size(1068, 55);
            this.pnl_header.TabIndex = 16;
            // 
            // btn_menu
            // 
            this.btn_menu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_menu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_menu.BackColor = System.Drawing.Color.Transparent;
            this.btn_menu.CausesValidation = false;
            this.btn_menu.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_menu.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btn_menu.ErrorImage")));
            this.btn_menu.Image = global::Fireon.Properties.Resources.btn_menu;
            this.btn_menu.ImageHover = global::Fireon.Properties.Resources.btn_menu_hover;
            this.btn_menu.InitialImage = null;
            this.btn_menu.Location = new System.Drawing.Point(1028, 3);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(18, 48);
            this.btn_menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_menu.TabIndex = 212;
            this.btn_menu.Zoom = 0;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // btn_notification
            // 
            this.btn_notification.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_notification.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_notification.BackColor = System.Drawing.Color.Transparent;
            this.btn_notification.CausesValidation = false;
            this.btn_notification.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_notification.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btn_notification.ErrorImage")));
            this.btn_notification.Image = global::Fireon.Properties.Resources.btn_icon_notification;
            this.btn_notification.ImageHover = global::Fireon.Properties.Resources.btn_notification_hover;
            this.btn_notification.InitialImage = null;
            this.btn_notification.Location = new System.Drawing.Point(752, 12);
            this.btn_notification.Name = "btn_notification";
            this.btn_notification.Size = new System.Drawing.Size(28, 27);
            this.btn_notification.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_notification.TabIndex = 212;
            this.btn_notification.Zoom = 0;
            // 
            // lbl_user
            // 
            this.lbl_user.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_user.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(5)))));
            this.lbl_user.Location = new System.Drawing.Point(937, 17);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(109, 24);
            this.lbl_user.TabIndex = 0;
            this.lbl_user.Text = "John Doe";
            // 
            // lbl_greeting
            // 
            this.lbl_greeting.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_greeting.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_greeting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(5)))));
            this.lbl_greeting.Location = new System.Drawing.Point(836, 17);
            this.lbl_greeting.Name = "lbl_greeting";
            this.lbl_greeting.Size = new System.Drawing.Size(109, 24);
            this.lbl_greeting.TabIndex = 0;
            this.lbl_greeting.Text = "Good morning,";
            // 
            // picb_user
            // 
            this.picb_user.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_user.BackColor = System.Drawing.Color.Transparent;
            this.picb_user.BackgroundImage = global::Fireon.Properties.Resources.picb_admin_dp;
            this.picb_user.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picb_user.Location = new System.Drawing.Point(788, 4);
            this.picb_user.Name = "picb_user";
            this.picb_user.Size = new System.Drawing.Size(42, 42);
            this.picb_user.TabIndex = 1;
            this.picb_user.TabStop = false;
            // 
            // pnl_menu
            // 
            this.pnl_menu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_menu.BackColor = System.Drawing.Color.Transparent;
            this.pnl_menu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_menu.BackgroundImage")));
            this.pnl_menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_menu.Controls.Add(this.btn_logout);
            this.pnl_menu.Location = new System.Drawing.Point(1082, 87);
            this.pnl_menu.Name = "pnl_menu";
            this.pnl_menu.Size = new System.Drawing.Size(216, 51);
            this.pnl_menu.TabIndex = 31;
            this.pnl_menu.Visible = false;
            // 
            // btn_logout
            // 
            this.btn_logout.BackgroundImage = global::Fireon.Properties.Resources.btn_logout;
            this.btn_logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_logout.FlatAppearance.BorderSize = 0;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Location = new System.Drawing.Point(9, 10);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(195, 31);
            this.btn_logout.TabIndex = 0;
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // pnl_sidebar
            // 
            this.pnl_sidebar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_sidebar.BackgroundImage")));
            this.pnl_sidebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_sidebar.Controls.Add(this.lbl_date_today);
            this.pnl_sidebar.Controls.Add(this.btn_settings);
            this.pnl_sidebar.Controls.Add(this.pnl_separator_11);
            this.pnl_sidebar.Controls.Add(this.lbl_version);
            this.pnl_sidebar.Controls.Add(this.btn_single_posting);
            this.pnl_sidebar.Controls.Add(this.pnl_separator_10);
            this.pnl_sidebar.Controls.Add(this.btn_department);
            this.pnl_sidebar.Controls.Add(this.panel12);
            this.pnl_sidebar.Controls.Add(this.btn_all);
            this.pnl_sidebar.Controls.Add(this.label9);
            this.pnl_sidebar.Controls.Add(this.btn_allowances);
            this.pnl_sidebar.Controls.Add(this.pnl_separator_8);
            this.pnl_sidebar.Controls.Add(this.btn_deductions);
            this.pnl_sidebar.Controls.Add(this.pnl_separator_7);
            this.pnl_sidebar.Controls.Add(this.btn_cash_advance);
            this.pnl_sidebar.Controls.Add(this.pnl_separator_6);
            this.pnl_sidebar.Controls.Add(this.btn_violations);
            this.pnl_sidebar.Controls.Add(this.pnl_separator_5);
            this.pnl_sidebar.Controls.Add(this.btn_holiday);
            this.pnl_sidebar.Controls.Add(this.pnl_separator_4);
            this.pnl_sidebar.Controls.Add(this.btn_overtime);
            this.pnl_sidebar.Controls.Add(this.pnl_separator_3);
            this.pnl_sidebar.Controls.Add(this.btn_leave);
            this.pnl_sidebar.Controls.Add(this.pnl_separator_2);
            this.pnl_sidebar.Controls.Add(this.btn_employee);
            this.pnl_sidebar.Controls.Add(this.lbl_manage_employee);
            this.pnl_sidebar.Controls.Add(this.panel1);
            this.pnl_sidebar.Controls.Add(this.btn_dashboard);
            this.pnl_sidebar.Controls.Add(this.pnl_separator_1);
            this.pnl_sidebar.Controls.Add(this.picb_fireon);
            this.pnl_sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_sidebar.Location = new System.Drawing.Point(0, 30);
            this.pnl_sidebar.Name = "pnl_sidebar";
            this.pnl_sidebar.Size = new System.Drawing.Size(252, 713);
            this.pnl_sidebar.TabIndex = 30;
            // 
            // lbl_date_today
            // 
            this.lbl_date_today.BackColor = System.Drawing.Color.Transparent;
            this.lbl_date_today.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_date_today.Font = new System.Drawing.Font("Open Sans", 9F);
            this.lbl_date_today.ForeColor = System.Drawing.Color.Black;
            this.lbl_date_today.Location = new System.Drawing.Point(0, 666);
            this.lbl_date_today.Name = "lbl_date_today";
            this.lbl_date_today.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.lbl_date_today.Size = new System.Drawing.Size(252, 20);
            this.lbl_date_today.TabIndex = 0;
            this.lbl_date_today.Text = "Date Today: November 20, 20xx";
            // 
            // btn_settings
            // 
            this.btn_settings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_settings.BackColor = System.Drawing.Color.Transparent;
            this.btn_settings.CausesValidation = false;
            this.btn_settings.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_settings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_settings.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btn_settings.ErrorImage")));
            this.btn_settings.Image = global::Fireon.Properties.Resources.btn_settings;
            this.btn_settings.ImageHover = global::Fireon.Properties.Resources.btn_settings_hover;
            this.btn_settings.InitialImage = null;
            this.btn_settings.Location = new System.Drawing.Point(0, 623);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(252, 31);
            this.btn_settings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_settings.TabIndex = 48;
            this.btn_settings.Zoom = 0;
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click);
            // 
            // pnl_separator_11
            // 
            this.pnl_separator_11.BackColor = System.Drawing.Color.Transparent;
            this.pnl_separator_11.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_separator_11.Location = new System.Drawing.Point(0, 609);
            this.pnl_separator_11.Name = "pnl_separator_11";
            this.pnl_separator_11.Size = new System.Drawing.Size(252, 14);
            this.pnl_separator_11.TabIndex = 5;
            // 
            // lbl_version
            // 
            this.lbl_version.BackColor = System.Drawing.Color.Transparent;
            this.lbl_version.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_version.Font = new System.Drawing.Font("Open Sans", 9F);
            this.lbl_version.ForeColor = System.Drawing.Color.Black;
            this.lbl_version.Location = new System.Drawing.Point(0, 686);
            this.lbl_version.Name = "lbl_version";
            this.lbl_version.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.lbl_version.Size = new System.Drawing.Size(252, 27);
            this.lbl_version.TabIndex = 0;
            this.lbl_version.Text = "Version 1.0";
            // 
            // btn_single_posting
            // 
            this.btn_single_posting.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_single_posting.BackColor = System.Drawing.Color.Transparent;
            this.btn_single_posting.CausesValidation = false;
            this.btn_single_posting.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_single_posting.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_single_posting.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btn_single_posting.ErrorImage")));
            this.btn_single_posting.Image = global::Fireon.Properties.Resources.btn_single_posting;
            this.btn_single_posting.ImageHover = global::Fireon.Properties.Resources.btn_single_posting_hover;
            this.btn_single_posting.InitialImage = null;
            this.btn_single_posting.Location = new System.Drawing.Point(0, 578);
            this.btn_single_posting.Name = "btn_single_posting";
            this.btn_single_posting.Size = new System.Drawing.Size(252, 31);
            this.btn_single_posting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_single_posting.TabIndex = 47;
            this.btn_single_posting.Zoom = 0;
            this.btn_single_posting.Click += new System.EventHandler(this.btn_single_posting_Click);
            // 
            // pnl_separator_10
            // 
            this.pnl_separator_10.BackColor = System.Drawing.Color.Transparent;
            this.pnl_separator_10.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_separator_10.Location = new System.Drawing.Point(0, 568);
            this.pnl_separator_10.Name = "pnl_separator_10";
            this.pnl_separator_10.Size = new System.Drawing.Size(252, 10);
            this.pnl_separator_10.TabIndex = 42;
            // 
            // btn_department
            // 
            this.btn_department.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_department.BackColor = System.Drawing.Color.Transparent;
            this.btn_department.CausesValidation = false;
            this.btn_department.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_department.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_department.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btn_department.ErrorImage")));
            this.btn_department.Image = global::Fireon.Properties.Resources.btn_department;
            this.btn_department.ImageHover = global::Fireon.Properties.Resources.btn_department_hover;
            this.btn_department.InitialImage = null;
            this.btn_department.Location = new System.Drawing.Point(0, 537);
            this.btn_department.Name = "btn_department";
            this.btn_department.Size = new System.Drawing.Size(252, 31);
            this.btn_department.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_department.TabIndex = 46;
            this.btn_department.Zoom = 0;
            this.btn_department.Click += new System.EventHandler(this.btn_department_Click);
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.Transparent;
            this.panel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel12.Location = new System.Drawing.Point(0, 527);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(252, 10);
            this.panel12.TabIndex = 43;
            // 
            // btn_all
            // 
            this.btn_all.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_all.BackColor = System.Drawing.Color.Transparent;
            this.btn_all.CausesValidation = false;
            this.btn_all.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_all.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_all.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btn_all.ErrorImage")));
            this.btn_all.Image = global::Fireon.Properties.Resources.btn_all;
            this.btn_all.ImageHover = global::Fireon.Properties.Resources.btn_all_hover;
            this.btn_all.InitialImage = null;
            this.btn_all.Location = new System.Drawing.Point(0, 496);
            this.btn_all.Name = "btn_all";
            this.btn_all.Size = new System.Drawing.Size(252, 31);
            this.btn_all.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_all.TabIndex = 45;
            this.btn_all.Zoom = 0;
            this.btn_all.Click += new System.EventHandler(this.btn_all_Click);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(5)))));
            this.label9.Location = new System.Drawing.Point(0, 467);
            this.label9.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(25, 6, 0, 2);
            this.label9.Size = new System.Drawing.Size(252, 29);
            this.label9.TabIndex = 41;
            this.label9.Text = "PAYROLL";
            // 
            // btn_allowances
            // 
            this.btn_allowances.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_allowances.BackColor = System.Drawing.Color.Transparent;
            this.btn_allowances.CausesValidation = false;
            this.btn_allowances.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_allowances.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_allowances.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btn_allowances.ErrorImage")));
            this.btn_allowances.Image = global::Fireon.Properties.Resources.btn_allowances;
            this.btn_allowances.ImageHover = global::Fireon.Properties.Resources.btn_allowances_hover;
            this.btn_allowances.InitialImage = null;
            this.btn_allowances.Location = new System.Drawing.Point(0, 436);
            this.btn_allowances.Name = "btn_allowances";
            this.btn_allowances.Size = new System.Drawing.Size(252, 31);
            this.btn_allowances.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_allowances.TabIndex = 37;
            this.btn_allowances.Zoom = 0;
            this.btn_allowances.Click += new System.EventHandler(this.btn_allowances_Click);
            // 
            // pnl_separator_8
            // 
            this.pnl_separator_8.BackColor = System.Drawing.Color.Transparent;
            this.pnl_separator_8.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_separator_8.Location = new System.Drawing.Point(0, 426);
            this.pnl_separator_8.Name = "pnl_separator_8";
            this.pnl_separator_8.Size = new System.Drawing.Size(252, 10);
            this.pnl_separator_8.TabIndex = 23;
            // 
            // btn_deductions
            // 
            this.btn_deductions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_deductions.BackColor = System.Drawing.Color.Transparent;
            this.btn_deductions.CausesValidation = false;
            this.btn_deductions.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_deductions.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_deductions.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btn_deductions.ErrorImage")));
            this.btn_deductions.Image = global::Fireon.Properties.Resources.btn_deductions;
            this.btn_deductions.ImageHover = global::Fireon.Properties.Resources.btn_deductions_hover;
            this.btn_deductions.InitialImage = null;
            this.btn_deductions.Location = new System.Drawing.Point(0, 395);
            this.btn_deductions.Name = "btn_deductions";
            this.btn_deductions.Size = new System.Drawing.Size(252, 31);
            this.btn_deductions.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_deductions.TabIndex = 36;
            this.btn_deductions.Zoom = 0;
            this.btn_deductions.Click += new System.EventHandler(this.btn_deductions_Click);
            // 
            // pnl_separator_7
            // 
            this.pnl_separator_7.BackColor = System.Drawing.Color.Transparent;
            this.pnl_separator_7.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_separator_7.Location = new System.Drawing.Point(0, 385);
            this.pnl_separator_7.Name = "pnl_separator_7";
            this.pnl_separator_7.Size = new System.Drawing.Size(252, 10);
            this.pnl_separator_7.TabIndex = 25;
            // 
            // btn_cash_advance
            // 
            this.btn_cash_advance.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_cash_advance.BackColor = System.Drawing.Color.Transparent;
            this.btn_cash_advance.CausesValidation = false;
            this.btn_cash_advance.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_cash_advance.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_cash_advance.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btn_cash_advance.ErrorImage")));
            this.btn_cash_advance.Image = global::Fireon.Properties.Resources.btn_cash_advance;
            this.btn_cash_advance.ImageHover = global::Fireon.Properties.Resources.btn_cash_advance_hover;
            this.btn_cash_advance.InitialImage = null;
            this.btn_cash_advance.Location = new System.Drawing.Point(0, 354);
            this.btn_cash_advance.Name = "btn_cash_advance";
            this.btn_cash_advance.Size = new System.Drawing.Size(252, 31);
            this.btn_cash_advance.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_cash_advance.TabIndex = 35;
            this.btn_cash_advance.Zoom = 0;
            this.btn_cash_advance.Click += new System.EventHandler(this.btn_cash_advance_Click);
            // 
            // pnl_separator_6
            // 
            this.pnl_separator_6.BackColor = System.Drawing.Color.Transparent;
            this.pnl_separator_6.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_separator_6.Location = new System.Drawing.Point(0, 344);
            this.pnl_separator_6.Name = "pnl_separator_6";
            this.pnl_separator_6.Size = new System.Drawing.Size(252, 10);
            this.pnl_separator_6.TabIndex = 26;
            // 
            // btn_violations
            // 
            this.btn_violations.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_violations.BackColor = System.Drawing.Color.Transparent;
            this.btn_violations.CausesValidation = false;
            this.btn_violations.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_violations.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_violations.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btn_violations.ErrorImage")));
            this.btn_violations.Image = global::Fireon.Properties.Resources.btn_violation;
            this.btn_violations.ImageHover = global::Fireon.Properties.Resources.btn_violations_hover;
            this.btn_violations.InitialImage = null;
            this.btn_violations.Location = new System.Drawing.Point(0, 313);
            this.btn_violations.Name = "btn_violations";
            this.btn_violations.Size = new System.Drawing.Size(252, 31);
            this.btn_violations.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_violations.TabIndex = 34;
            this.btn_violations.Zoom = 0;
            this.btn_violations.Click += new System.EventHandler(this.btn_violations_Click);
            // 
            // pnl_separator_5
            // 
            this.pnl_separator_5.BackColor = System.Drawing.Color.Transparent;
            this.pnl_separator_5.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_separator_5.Location = new System.Drawing.Point(0, 303);
            this.pnl_separator_5.Name = "pnl_separator_5";
            this.pnl_separator_5.Size = new System.Drawing.Size(252, 10);
            this.pnl_separator_5.TabIndex = 27;
            // 
            // btn_holiday
            // 
            this.btn_holiday.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_holiday.BackColor = System.Drawing.Color.Transparent;
            this.btn_holiday.CausesValidation = false;
            this.btn_holiday.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_holiday.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_holiday.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btn_holiday.ErrorImage")));
            this.btn_holiday.Image = global::Fireon.Properties.Resources.btn_holiday;
            this.btn_holiday.ImageHover = global::Fireon.Properties.Resources.btn_holiday_hover;
            this.btn_holiday.InitialImage = null;
            this.btn_holiday.Location = new System.Drawing.Point(0, 272);
            this.btn_holiday.Name = "btn_holiday";
            this.btn_holiday.Size = new System.Drawing.Size(252, 31);
            this.btn_holiday.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_holiday.TabIndex = 33;
            this.btn_holiday.Zoom = 0;
            this.btn_holiday.Click += new System.EventHandler(this.btn_holiday_Click);
            // 
            // pnl_separator_4
            // 
            this.pnl_separator_4.BackColor = System.Drawing.Color.Transparent;
            this.pnl_separator_4.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_separator_4.Location = new System.Drawing.Point(0, 262);
            this.pnl_separator_4.Name = "pnl_separator_4";
            this.pnl_separator_4.Size = new System.Drawing.Size(252, 10);
            this.pnl_separator_4.TabIndex = 24;
            // 
            // btn_overtime
            // 
            this.btn_overtime.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_overtime.BackColor = System.Drawing.Color.Transparent;
            this.btn_overtime.CausesValidation = false;
            this.btn_overtime.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_overtime.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_overtime.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btn_overtime.ErrorImage")));
            this.btn_overtime.Image = global::Fireon.Properties.Resources.btn_overtime;
            this.btn_overtime.ImageHover = global::Fireon.Properties.Resources.btn_overtime_hover;
            this.btn_overtime.InitialImage = null;
            this.btn_overtime.Location = new System.Drawing.Point(0, 231);
            this.btn_overtime.Name = "btn_overtime";
            this.btn_overtime.Size = new System.Drawing.Size(252, 31);
            this.btn_overtime.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_overtime.TabIndex = 32;
            this.btn_overtime.Zoom = 0;
            this.btn_overtime.Click += new System.EventHandler(this.btn_overtime_Click);
            // 
            // pnl_separator_3
            // 
            this.pnl_separator_3.BackColor = System.Drawing.Color.Transparent;
            this.pnl_separator_3.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_separator_3.Location = new System.Drawing.Point(0, 221);
            this.pnl_separator_3.Name = "pnl_separator_3";
            this.pnl_separator_3.Size = new System.Drawing.Size(252, 10);
            this.pnl_separator_3.TabIndex = 30;
            // 
            // btn_leave
            // 
            this.btn_leave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_leave.BackColor = System.Drawing.Color.Transparent;
            this.btn_leave.CausesValidation = false;
            this.btn_leave.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_leave.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_leave.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btn_leave.ErrorImage")));
            this.btn_leave.Image = global::Fireon.Properties.Resources.btn_leave;
            this.btn_leave.ImageHover = global::Fireon.Properties.Resources.btn_leave_hover;
            this.btn_leave.InitialImage = null;
            this.btn_leave.Location = new System.Drawing.Point(0, 190);
            this.btn_leave.Name = "btn_leave";
            this.btn_leave.Size = new System.Drawing.Size(252, 31);
            this.btn_leave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_leave.TabIndex = 31;
            this.btn_leave.Zoom = 0;
            this.btn_leave.Click += new System.EventHandler(this.btn_leave_Click);
            // 
            // pnl_separator_2
            // 
            this.pnl_separator_2.BackColor = System.Drawing.Color.Transparent;
            this.pnl_separator_2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_separator_2.Location = new System.Drawing.Point(0, 180);
            this.pnl_separator_2.Name = "pnl_separator_2";
            this.pnl_separator_2.Size = new System.Drawing.Size(252, 10);
            this.pnl_separator_2.TabIndex = 28;
            // 
            // btn_employee
            // 
            this.btn_employee.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_employee.BackColor = System.Drawing.Color.Transparent;
            this.btn_employee.CausesValidation = false;
            this.btn_employee.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_employee.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_employee.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btn_employee.ErrorImage")));
            this.btn_employee.Image = global::Fireon.Properties.Resources.btn_employee;
            this.btn_employee.ImageHover = global::Fireon.Properties.Resources.btn_employee_hover;
            this.btn_employee.InitialImage = null;
            this.btn_employee.Location = new System.Drawing.Point(0, 149);
            this.btn_employee.Name = "btn_employee";
            this.btn_employee.Size = new System.Drawing.Size(252, 31);
            this.btn_employee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_employee.TabIndex = 29;
            this.btn_employee.Zoom = 0;
            this.btn_employee.Click += new System.EventHandler(this.btn_employee_Click);
            // 
            // lbl_manage_employee
            // 
            this.lbl_manage_employee.BackColor = System.Drawing.Color.Transparent;
            this.lbl_manage_employee.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_manage_employee.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_manage_employee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(5)))));
            this.lbl_manage_employee.Location = new System.Drawing.Point(0, 120);
            this.lbl_manage_employee.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lbl_manage_employee.Name = "lbl_manage_employee";
            this.lbl_manage_employee.Padding = new System.Windows.Forms.Padding(25, 6, 0, 2);
            this.lbl_manage_employee.Size = new System.Drawing.Size(252, 29);
            this.lbl_manage_employee.TabIndex = 5;
            this.lbl_manage_employee.Text = "MANAGE EMPLOYEES";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(0, 126);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 10);
            this.panel1.TabIndex = 5;
            // 
            // btn_dashboard
            // 
            this.btn_dashboard.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_dashboard.BackColor = System.Drawing.Color.Transparent;
            this.btn_dashboard.CausesValidation = false;
            this.btn_dashboard.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_dashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_dashboard.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btn_dashboard.ErrorImage")));
            this.btn_dashboard.Image = global::Fireon.Properties.Resources.btn_dashboard;
            this.btn_dashboard.ImageHover = global::Fireon.Properties.Resources.btn_dashboard_hover;
            this.btn_dashboard.InitialImage = null;
            this.btn_dashboard.Location = new System.Drawing.Point(0, 89);
            this.btn_dashboard.Name = "btn_dashboard";
            this.btn_dashboard.Size = new System.Drawing.Size(252, 31);
            this.btn_dashboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_dashboard.TabIndex = 6;
            this.btn_dashboard.Zoom = 0;
            this.btn_dashboard.Click += new System.EventHandler(this.btn_dashboard_Click);
            // 
            // pnl_separator_1
            // 
            this.pnl_separator_1.BackColor = System.Drawing.Color.Transparent;
            this.pnl_separator_1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_separator_1.Location = new System.Drawing.Point(0, 72);
            this.pnl_separator_1.Name = "pnl_separator_1";
            this.pnl_separator_1.Size = new System.Drawing.Size(252, 17);
            this.pnl_separator_1.TabIndex = 5;
            // 
            // picb_fireon
            // 
            this.picb_fireon.BackColor = System.Drawing.Color.Transparent;
            this.picb_fireon.BackgroundImage = global::Fireon.Properties.Resources.picb_logo_fireon;
            this.picb_fireon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picb_fireon.Dock = System.Windows.Forms.DockStyle.Top;
            this.picb_fireon.Location = new System.Drawing.Point(0, 0);
            this.picb_fireon.Name = "picb_fireon";
            this.picb_fireon.Size = new System.Drawing.Size(252, 72);
            this.picb_fireon.TabIndex = 1;
            this.picb_fireon.TabStop = false;
            // 
            // uc_settings
            // 
            this.uc_settings.BackColor = System.Drawing.Color.White;
            this.uc_settings.Location = new System.Drawing.Point(255, 567);
            this.uc_settings.Name = "uc_settings";
            this.uc_settings.Size = new System.Drawing.Size(1060, 680);
            this.uc_settings.TabIndex = 28;
            this.uc_settings.Visible = false;
            // 
            // uc_single_posting
            // 
            this.uc_single_posting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.uc_single_posting.AutoScroll = true;
            this.uc_single_posting.AutoScrollMargin = new System.Drawing.Size(50, 10);
            this.uc_single_posting.BackColor = System.Drawing.Color.White;
            this.uc_single_posting.Location = new System.Drawing.Point(255, 512);
            this.uc_single_posting.Name = "uc_single_posting";
            this.uc_single_posting.Size = new System.Drawing.Size(1068, 658);
            this.uc_single_posting.TabIndex = 27;
            this.uc_single_posting.Visible = false;
            // 
            // uc_all
            // 
            this.uc_all.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.uc_all.AutoScroll = true;
            this.uc_all.AutoScrollMargin = new System.Drawing.Size(50, 34);
            this.uc_all.AutoScrollMinSize = new System.Drawing.Size(0, 540);
            this.uc_all.BackColor = System.Drawing.Color.White;
            this.uc_all.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uc_all.Location = new System.Drawing.Point(255, 466);
            this.uc_all.Name = "uc_all";
            this.uc_all.Size = new System.Drawing.Size(1068, 658);
            this.uc_all.TabIndex = 25;
            this.uc_all.Visible = false;
            // 
            // uc_department
            // 
            this.uc_department.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.uc_department.AutoScroll = true;
            this.uc_department.AutoScrollMargin = new System.Drawing.Size(50, 10);
            this.uc_department.BackColor = System.Drawing.Color.White;
            this.uc_department.Location = new System.Drawing.Point(252, 535);
            this.uc_department.Name = "uc_department";
            this.uc_department.Size = new System.Drawing.Size(1068, 658);
            this.uc_department.TabIndex = 26;
            this.uc_department.Visible = false;
            // 
            // uc_deductions
            // 
            this.uc_deductions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uc_deductions.BackColor = System.Drawing.Color.White;
            this.uc_deductions.Location = new System.Drawing.Point(255, 415);
            this.uc_deductions.Name = "uc_deductions";
            this.uc_deductions.Size = new System.Drawing.Size(1068, 658);
            this.uc_deductions.TabIndex = 23;
            this.uc_deductions.Visible = false;
            // 
            // uc_cash_advance
            // 
            this.uc_cash_advance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uc_cash_advance.BackColor = System.Drawing.Color.White;
            this.uc_cash_advance.Location = new System.Drawing.Point(255, 361);
            this.uc_cash_advance.Name = "uc_cash_advance";
            this.uc_cash_advance.Size = new System.Drawing.Size(1068, 658);
            this.uc_cash_advance.TabIndex = 22;
            this.uc_cash_advance.Visible = false;
            // 
            // uc_violations
            // 
            this.uc_violations.BackColor = System.Drawing.Color.White;
            this.uc_violations.Location = new System.Drawing.Point(255, 312);
            this.uc_violations.Name = "uc_violations";
            this.uc_violations.Size = new System.Drawing.Size(1060, 680);
            this.uc_violations.TabIndex = 29;
            this.uc_violations.Visible = false;
            // 
            // uc_allowances
            // 
            this.uc_allowances.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.uc_allowances.BackColor = System.Drawing.Color.White;
            this.uc_allowances.Location = new System.Drawing.Point(252, 438);
            this.uc_allowances.Name = "uc_allowances";
            this.uc_allowances.Size = new System.Drawing.Size(1068, 658);
            this.uc_allowances.TabIndex = 24;
            this.uc_allowances.Visible = false;
            // 
            // uc_holiday
            // 
            this.uc_holiday.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uc_holiday.BackColor = System.Drawing.Color.White;
            this.uc_holiday.Location = new System.Drawing.Point(255, 261);
            this.uc_holiday.Name = "uc_holiday";
            this.uc_holiday.Size = new System.Drawing.Size(1068, 658);
            this.uc_holiday.TabIndex = 20;
            this.uc_holiday.Visible = false;
            // 
            // uc_overtime
            // 
            this.uc_overtime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uc_overtime.BackColor = System.Drawing.Color.White;
            this.uc_overtime.Location = new System.Drawing.Point(258, 210);
            this.uc_overtime.Name = "uc_overtime";
            this.uc_overtime.Size = new System.Drawing.Size(1068, 658);
            this.uc_overtime.TabIndex = 19;
            this.uc_overtime.Visible = false;
            // 
            // uc_leave
            // 
            this.uc_leave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uc_leave.BackColor = System.Drawing.Color.White;
            this.uc_leave.Location = new System.Drawing.Point(255, 179);
            this.uc_leave.Name = "uc_leave";
            this.uc_leave.Size = new System.Drawing.Size(1068, 658);
            this.uc_leave.TabIndex = 18;
            this.uc_leave.Visible = false;
            // 
            // uc_employee
            // 
            this.uc_employee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uc_employee.BackColor = System.Drawing.Color.White;
            this.uc_employee.Location = new System.Drawing.Point(255, 128);
            this.uc_employee.Name = "uc_employee";
            this.uc_employee.Size = new System.Drawing.Size(1068, 658);
            this.uc_employee.TabIndex = 17;
            this.uc_employee.Visible = false;
            // 
            // uc_dashboard
            // 
            this.uc_dashboard.AutoScroll = true;
            this.uc_dashboard.AutoScrollMargin = new System.Drawing.Size(50, 10);
            this.uc_dashboard.BackColor = System.Drawing.Color.White;
            this.uc_dashboard.Location = new System.Drawing.Point(252, 87);
            this.uc_dashboard.Name = "uc_dashboard";
            this.uc_dashboard.Size = new System.Drawing.Size(1068, 713);
            this.uc_dashboard.TabIndex = 5;
            // 
            // frmFireonPayroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 743);
            this.Controls.Add(this.pnl_menu);
            this.Controls.Add(this.pnl_header);
            this.Controls.Add(this.pnl_sidebar);
            this.Controls.Add(this.uc_settings);
            this.Controls.Add(this.uc_single_posting);
            this.Controls.Add(this.uc_all);
            this.Controls.Add(this.uc_department);
            this.Controls.Add(this.uc_deductions);
            this.Controls.Add(this.uc_cash_advance);
            this.Controls.Add(this.uc_violations);
            this.Controls.Add(this.uc_allowances);
            this.Controls.Add(this.uc_holiday);
            this.Controls.Add(this.uc_overtime);
            this.Controls.Add(this.uc_leave);
            this.Controls.Add(this.uc_employee);
            this.Controls.Add(this.uc_dashboard);
            this.DisplayHeader = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1366, 768);
            this.Name = "frmFireonPayroll";
            this.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.TransparencyKey = System.Drawing.Color.DarkRed;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Fireon_Load);
            this.pnl_header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picb_user)).EndInit();
            this.pnl_menu.ResumeLayout(false);
            this.pnl_sidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picb_fireon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
      
        private ucDashboard uc_dashboard;
        private System.Windows.Forms.Panel pnl_header;
        private System.Windows.Forms.Label lbl_greeting;
        private System.Windows.Forms.PictureBox picb_user;
        private ucEmployee uc_employee;
        private ucLeave uc_leave;
        private ucOvertime uc_overtime;
        private ucHoliday uc_holiday;
        private Cash_Advance uc_cash_advance;
        private ucDeductions uc_deductions;
        private ucAllowances uc_allowances;
        private ucAll uc_all;
        private ucDepartment uc_department;
        private Single_Posting uc_single_posting;
        private JImageButton.JImageButton btn_notification;
        
        private System.Windows.Forms.Label lbl_user;
        private ucSettings uc_settings;
        private ucViolations uc_violations;
        private System.Windows.Forms.Panel pnl_sidebar;
        private System.Windows.Forms.Label lbl_date_today;
        private JImageButton.JImageButton btn_settings;
        private System.Windows.Forms.Panel pnl_separator_11;
        private System.Windows.Forms.Label lbl_version;
        private JImageButton.JImageButton btn_single_posting;
        private System.Windows.Forms.Panel pnl_separator_10;
        private JImageButton.JImageButton btn_department;
        private System.Windows.Forms.Panel panel12;
        private JImageButton.JImageButton btn_all;
        private System.Windows.Forms.Label label9;
        private JImageButton.JImageButton btn_allowances;
        private System.Windows.Forms.Panel pnl_separator_8;
        private JImageButton.JImageButton btn_deductions;
        private System.Windows.Forms.Panel pnl_separator_7;
        private JImageButton.JImageButton btn_cash_advance;
        private System.Windows.Forms.Panel pnl_separator_6;
        private JImageButton.JImageButton btn_violations;
        private System.Windows.Forms.Panel pnl_separator_5;
        private JImageButton.JImageButton btn_holiday;
        private System.Windows.Forms.Panel pnl_separator_4;
        private JImageButton.JImageButton btn_overtime;
        private System.Windows.Forms.Panel pnl_separator_3;
        private JImageButton.JImageButton btn_leave;
        private System.Windows.Forms.Panel pnl_separator_2;
        private JImageButton.JImageButton btn_employee;
        private System.Windows.Forms.Label lbl_manage_employee;
        private System.Windows.Forms.Panel panel1;
        private JImageButton.JImageButton btn_dashboard;
        private System.Windows.Forms.Panel pnl_separator_1;
        private System.Windows.Forms.PictureBox picb_fireon;
        private JImageButton.JImageButton btn_menu;
        private System.Windows.Forms.Panel pnl_menu;
        private System.Windows.Forms.Button btn_logout;
    }
}