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
            this.btn_menu = new System.Windows.Forms.Button();
            this.btn_notification = new System.Windows.Forms.Button();
            this.lbl_user = new System.Windows.Forms.Label();
            this.lbl_greeting = new System.Windows.Forms.Label();
            this.picb_user = new System.Windows.Forms.PictureBox();
            this.pnl_menu = new System.Windows.Forms.Panel();
            this.btn_logout = new System.Windows.Forms.Button();
            this.pnl_sidebar = new System.Windows.Forms.Panel();
            this.lbl_date_today = new System.Windows.Forms.Label();
            this.lbl_version = new System.Windows.Forms.Label();
            this.btn_settings = new System.Windows.Forms.Button();
            this.pnl_separator_11 = new System.Windows.Forms.Panel();
            this.btn_single_posting = new System.Windows.Forms.Button();
            this.pnl_separator_10 = new System.Windows.Forms.Panel();
            this.btn_department = new System.Windows.Forms.Button();
            this.pnl_separator_9 = new System.Windows.Forms.Panel();
            this.btn_all = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_allowances = new System.Windows.Forms.Button();
            this.pnl_separator_8 = new System.Windows.Forms.Panel();
            this.btn_deductions = new System.Windows.Forms.Button();
            this.pnl_separator_7 = new System.Windows.Forms.Panel();
            this.btn_cash_advance = new System.Windows.Forms.Button();
            this.pnl_separator_6 = new System.Windows.Forms.Panel();
            this.btn_violations = new System.Windows.Forms.Button();
            this.pnl_separator_5 = new System.Windows.Forms.Panel();
            this.btn_holiday = new System.Windows.Forms.Button();
            this.pnl_separator_4 = new System.Windows.Forms.Panel();
            this.btn_overtime = new System.Windows.Forms.Button();
            this.pnl_separator_3 = new System.Windows.Forms.Panel();
            this.btn_leave = new System.Windows.Forms.Button();
            this.pnl_separator_2 = new System.Windows.Forms.Panel();
            this.btn_employee = new System.Windows.Forms.Button();
            this.lbl_manage_employee = new System.Windows.Forms.Label();
            this.btn_dashboard = new System.Windows.Forms.Button();
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
            this.pnl_header.Location = new System.Drawing.Point(252, 0);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Size = new System.Drawing.Size(1068, 55);
            this.pnl_header.TabIndex = 16;
            // 
            // btn_menu
            // 
            this.btn_menu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_menu.BackColor = System.Drawing.Color.Transparent;
            this.btn_menu.BackgroundImage = global::Fireon.Properties.Resources.btn_menu;
            this.btn_menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_menu.FlatAppearance.BorderSize = 0;
            this.btn_menu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menu.Location = new System.Drawing.Point(1028, 4);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(18, 48);
            this.btn_menu.TabIndex = 213;
            this.btn_menu.TabStop = false;
            this.btn_menu.UseVisualStyleBackColor = false;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // btn_notification
            // 
            this.btn_notification.BackColor = System.Drawing.Color.Transparent;
            this.btn_notification.BackgroundImage = global::Fireon.Properties.Resources.btn_icon_notification;
            this.btn_notification.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_notification.FlatAppearance.BorderSize = 0;
            this.btn_notification.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_notification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_notification.Location = new System.Drawing.Point(754, 17);
            this.btn_notification.Name = "btn_notification";
            this.btn_notification.Size = new System.Drawing.Size(28, 27);
            this.btn_notification.TabIndex = 213;
            this.btn_notification.TabStop = false;
            this.btn_notification.UseVisualStyleBackColor = false;
            // 
            // lbl_user
            // 
            this.lbl_user.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(5)))));
            this.lbl_user.Location = new System.Drawing.Point(937, 22);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(109, 24);
            this.lbl_user.TabIndex = 0;
            this.lbl_user.Text = "John Doe";
            // 
            // lbl_greeting
            // 
            this.lbl_greeting.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_greeting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(5)))));
            this.lbl_greeting.Location = new System.Drawing.Point(836, 22);
            this.lbl_greeting.Name = "lbl_greeting";
            this.lbl_greeting.Size = new System.Drawing.Size(109, 24);
            this.lbl_greeting.TabIndex = 0;
            this.lbl_greeting.Text = "Good morning,";
            // 
            // picb_user
            // 
            this.picb_user.BackColor = System.Drawing.Color.Transparent;
            this.picb_user.BackgroundImage = global::Fireon.Properties.Resources.picb_admin_dp;
            this.picb_user.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picb_user.Location = new System.Drawing.Point(788, 9);
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
            this.pnl_menu.Location = new System.Drawing.Point(1082, 57);
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
            this.pnl_sidebar.Controls.Add(this.lbl_version);
            this.pnl_sidebar.Controls.Add(this.btn_settings);
            this.pnl_sidebar.Controls.Add(this.pnl_separator_11);
            this.pnl_sidebar.Controls.Add(this.btn_single_posting);
            this.pnl_sidebar.Controls.Add(this.pnl_separator_10);
            this.pnl_sidebar.Controls.Add(this.btn_department);
            this.pnl_sidebar.Controls.Add(this.pnl_separator_9);
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
            this.pnl_sidebar.Controls.Add(this.btn_dashboard);
            this.pnl_sidebar.Controls.Add(this.pnl_separator_1);
            this.pnl_sidebar.Controls.Add(this.picb_fireon);
            this.pnl_sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_sidebar.Location = new System.Drawing.Point(0, 0);
            this.pnl_sidebar.Name = "pnl_sidebar";
            this.pnl_sidebar.Size = new System.Drawing.Size(252, 729);
            this.pnl_sidebar.TabIndex = 30;
            // 
            // lbl_date_today
            // 
            this.lbl_date_today.BackColor = System.Drawing.Color.Transparent;
            this.lbl_date_today.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_date_today.Font = new System.Drawing.Font("Open Sans", 9F);
            this.lbl_date_today.ForeColor = System.Drawing.Color.Black;
            this.lbl_date_today.Location = new System.Drawing.Point(0, 682);
            this.lbl_date_today.Name = "lbl_date_today";
            this.lbl_date_today.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.lbl_date_today.Size = new System.Drawing.Size(252, 20);
            this.lbl_date_today.TabIndex = 100;
            this.lbl_date_today.Text = "Date Today: November 20, 20xx";
            // 
            // lbl_version
            // 
            this.lbl_version.BackColor = System.Drawing.Color.Transparent;
            this.lbl_version.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_version.Font = new System.Drawing.Font("Open Sans", 9F);
            this.lbl_version.ForeColor = System.Drawing.Color.Black;
            this.lbl_version.Location = new System.Drawing.Point(0, 702);
            this.lbl_version.Name = "lbl_version";
            this.lbl_version.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.lbl_version.Size = new System.Drawing.Size(252, 27);
            this.lbl_version.TabIndex = 101;
            this.lbl_version.Text = "Version 1.0";
            // 
            // btn_settings
            // 
            this.btn_settings.BackColor = System.Drawing.Color.Transparent;
            this.btn_settings.BackgroundImage = global::Fireon.Properties.Resources.btn_settings;
            this.btn_settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_settings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_settings.FlatAppearance.BorderSize = 0;
            this.btn_settings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_settings.Location = new System.Drawing.Point(0, 623);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(252, 31);
            this.btn_settings.TabIndex = 99;
            this.btn_settings.TabStop = false;
            this.btn_settings.UseVisualStyleBackColor = false;
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click);
            // 
            // pnl_separator_11
            // 
            this.pnl_separator_11.BackColor = System.Drawing.Color.Transparent;
            this.pnl_separator_11.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_separator_11.Location = new System.Drawing.Point(0, 609);
            this.pnl_separator_11.Name = "pnl_separator_11";
            this.pnl_separator_11.Size = new System.Drawing.Size(252, 14);
            this.pnl_separator_11.TabIndex = 98;
            // 
            // btn_single_posting
            // 
            this.btn_single_posting.BackColor = System.Drawing.Color.Transparent;
            this.btn_single_posting.BackgroundImage = global::Fireon.Properties.Resources.btn_single_posting;
            this.btn_single_posting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_single_posting.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_single_posting.FlatAppearance.BorderSize = 0;
            this.btn_single_posting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_single_posting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_single_posting.Location = new System.Drawing.Point(0, 578);
            this.btn_single_posting.Name = "btn_single_posting";
            this.btn_single_posting.Size = new System.Drawing.Size(252, 31);
            this.btn_single_posting.TabIndex = 97;
            this.btn_single_posting.TabStop = false;
            this.btn_single_posting.UseVisualStyleBackColor = false;
            this.btn_single_posting.Click += new System.EventHandler(this.btn_single_posting_Click);
            // 
            // pnl_separator_10
            // 
            this.pnl_separator_10.BackColor = System.Drawing.Color.Transparent;
            this.pnl_separator_10.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_separator_10.Location = new System.Drawing.Point(0, 568);
            this.pnl_separator_10.Name = "pnl_separator_10";
            this.pnl_separator_10.Size = new System.Drawing.Size(252, 10);
            this.pnl_separator_10.TabIndex = 96;
            // 
            // btn_department
            // 
            this.btn_department.BackColor = System.Drawing.Color.Transparent;
            this.btn_department.BackgroundImage = global::Fireon.Properties.Resources.btn_department;
            this.btn_department.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_department.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_department.FlatAppearance.BorderSize = 0;
            this.btn_department.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_department.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_department.Location = new System.Drawing.Point(0, 537);
            this.btn_department.Name = "btn_department";
            this.btn_department.Size = new System.Drawing.Size(252, 31);
            this.btn_department.TabIndex = 95;
            this.btn_department.TabStop = false;
            this.btn_department.UseVisualStyleBackColor = false;
            this.btn_department.Click += new System.EventHandler(this.btn_department_Click);
            // 
            // pnl_separator_9
            // 
            this.pnl_separator_9.BackColor = System.Drawing.Color.Transparent;
            this.pnl_separator_9.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_separator_9.Location = new System.Drawing.Point(0, 527);
            this.pnl_separator_9.Name = "pnl_separator_9";
            this.pnl_separator_9.Size = new System.Drawing.Size(252, 10);
            this.pnl_separator_9.TabIndex = 94;
            // 
            // btn_all
            // 
            this.btn_all.BackColor = System.Drawing.Color.Transparent;
            this.btn_all.BackgroundImage = global::Fireon.Properties.Resources.btn_all;
            this.btn_all.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_all.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_all.FlatAppearance.BorderSize = 0;
            this.btn_all.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_all.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_all.Location = new System.Drawing.Point(0, 496);
            this.btn_all.Name = "btn_all";
            this.btn_all.Size = new System.Drawing.Size(252, 31);
            this.btn_all.TabIndex = 50;
            this.btn_all.TabStop = false;
            this.btn_all.UseVisualStyleBackColor = false;
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
            this.label9.TabIndex = 93;
            this.label9.Text = "PAYROLL";
            // 
            // btn_allowances
            // 
            this.btn_allowances.BackColor = System.Drawing.Color.Transparent;
            this.btn_allowances.BackgroundImage = global::Fireon.Properties.Resources.btn_allowances;
            this.btn_allowances.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_allowances.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_allowances.FlatAppearance.BorderSize = 0;
            this.btn_allowances.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_allowances.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_allowances.Location = new System.Drawing.Point(0, 436);
            this.btn_allowances.Name = "btn_allowances";
            this.btn_allowances.Size = new System.Drawing.Size(252, 31);
            this.btn_allowances.TabIndex = 92;
            this.btn_allowances.TabStop = false;
            this.btn_allowances.UseVisualStyleBackColor = false;
            this.btn_allowances.Click += new System.EventHandler(this.btn_allowances_Click);
            // 
            // pnl_separator_8
            // 
            this.pnl_separator_8.BackColor = System.Drawing.Color.Transparent;
            this.pnl_separator_8.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_separator_8.Location = new System.Drawing.Point(0, 426);
            this.pnl_separator_8.Name = "pnl_separator_8";
            this.pnl_separator_8.Size = new System.Drawing.Size(252, 10);
            this.pnl_separator_8.TabIndex = 91;
            // 
            // btn_deductions
            // 
            this.btn_deductions.BackColor = System.Drawing.Color.Transparent;
            this.btn_deductions.BackgroundImage = global::Fireon.Properties.Resources.btn_deductions;
            this.btn_deductions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_deductions.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_deductions.FlatAppearance.BorderSize = 0;
            this.btn_deductions.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_deductions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deductions.Location = new System.Drawing.Point(0, 395);
            this.btn_deductions.Name = "btn_deductions";
            this.btn_deductions.Size = new System.Drawing.Size(252, 31);
            this.btn_deductions.TabIndex = 90;
            this.btn_deductions.TabStop = false;
            this.btn_deductions.UseVisualStyleBackColor = false;
            this.btn_deductions.Click += new System.EventHandler(this.btn_deductions_Click);
            // 
            // pnl_separator_7
            // 
            this.pnl_separator_7.BackColor = System.Drawing.Color.Transparent;
            this.pnl_separator_7.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_separator_7.Location = new System.Drawing.Point(0, 385);
            this.pnl_separator_7.Name = "pnl_separator_7";
            this.pnl_separator_7.Size = new System.Drawing.Size(252, 10);
            this.pnl_separator_7.TabIndex = 89;
            // 
            // btn_cash_advance
            // 
            this.btn_cash_advance.BackColor = System.Drawing.Color.Transparent;
            this.btn_cash_advance.BackgroundImage = global::Fireon.Properties.Resources.btn_cash_advance;
            this.btn_cash_advance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_cash_advance.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_cash_advance.FlatAppearance.BorderSize = 0;
            this.btn_cash_advance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_cash_advance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cash_advance.Location = new System.Drawing.Point(0, 354);
            this.btn_cash_advance.Name = "btn_cash_advance";
            this.btn_cash_advance.Size = new System.Drawing.Size(252, 31);
            this.btn_cash_advance.TabIndex = 88;
            this.btn_cash_advance.TabStop = false;
            this.btn_cash_advance.UseVisualStyleBackColor = false;
            this.btn_cash_advance.Click += new System.EventHandler(this.btn_cash_advance_Click);
            // 
            // pnl_separator_6
            // 
            this.pnl_separator_6.BackColor = System.Drawing.Color.Transparent;
            this.pnl_separator_6.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_separator_6.Location = new System.Drawing.Point(0, 344);
            this.pnl_separator_6.Name = "pnl_separator_6";
            this.pnl_separator_6.Size = new System.Drawing.Size(252, 10);
            this.pnl_separator_6.TabIndex = 87;
            // 
            // btn_violations
            // 
            this.btn_violations.BackColor = System.Drawing.Color.Transparent;
            this.btn_violations.BackgroundImage = global::Fireon.Properties.Resources.btn_violation;
            this.btn_violations.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_violations.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_violations.FlatAppearance.BorderSize = 0;
            this.btn_violations.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_violations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_violations.Location = new System.Drawing.Point(0, 313);
            this.btn_violations.Name = "btn_violations";
            this.btn_violations.Size = new System.Drawing.Size(252, 31);
            this.btn_violations.TabIndex = 86;
            this.btn_violations.TabStop = false;
            this.btn_violations.UseVisualStyleBackColor = false;
            this.btn_violations.Click += new System.EventHandler(this.btn_violations_Click);
            // 
            // pnl_separator_5
            // 
            this.pnl_separator_5.BackColor = System.Drawing.Color.Transparent;
            this.pnl_separator_5.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_separator_5.Location = new System.Drawing.Point(0, 303);
            this.pnl_separator_5.Name = "pnl_separator_5";
            this.pnl_separator_5.Size = new System.Drawing.Size(252, 10);
            this.pnl_separator_5.TabIndex = 85;
            // 
            // btn_holiday
            // 
            this.btn_holiday.BackColor = System.Drawing.Color.Transparent;
            this.btn_holiday.BackgroundImage = global::Fireon.Properties.Resources.btn_holiday;
            this.btn_holiday.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_holiday.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_holiday.FlatAppearance.BorderSize = 0;
            this.btn_holiday.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_holiday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_holiday.Location = new System.Drawing.Point(0, 272);
            this.btn_holiday.Name = "btn_holiday";
            this.btn_holiday.Size = new System.Drawing.Size(252, 31);
            this.btn_holiday.TabIndex = 84;
            this.btn_holiday.TabStop = false;
            this.btn_holiday.UseVisualStyleBackColor = false;
            this.btn_holiday.Click += new System.EventHandler(this.btn_holiday_Click);
            // 
            // pnl_separator_4
            // 
            this.pnl_separator_4.BackColor = System.Drawing.Color.Transparent;
            this.pnl_separator_4.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_separator_4.Location = new System.Drawing.Point(0, 262);
            this.pnl_separator_4.Name = "pnl_separator_4";
            this.pnl_separator_4.Size = new System.Drawing.Size(252, 10);
            this.pnl_separator_4.TabIndex = 83;
            // 
            // btn_overtime
            // 
            this.btn_overtime.BackColor = System.Drawing.Color.Transparent;
            this.btn_overtime.BackgroundImage = global::Fireon.Properties.Resources.btn_overtime;
            this.btn_overtime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_overtime.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_overtime.FlatAppearance.BorderSize = 0;
            this.btn_overtime.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_overtime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_overtime.Location = new System.Drawing.Point(0, 231);
            this.btn_overtime.Name = "btn_overtime";
            this.btn_overtime.Size = new System.Drawing.Size(252, 31);
            this.btn_overtime.TabIndex = 82;
            this.btn_overtime.TabStop = false;
            this.btn_overtime.UseVisualStyleBackColor = false;
            this.btn_overtime.Click += new System.EventHandler(this.btn_overtime_Click);
            // 
            // pnl_separator_3
            // 
            this.pnl_separator_3.BackColor = System.Drawing.Color.Transparent;
            this.pnl_separator_3.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_separator_3.Location = new System.Drawing.Point(0, 221);
            this.pnl_separator_3.Name = "pnl_separator_3";
            this.pnl_separator_3.Size = new System.Drawing.Size(252, 10);
            this.pnl_separator_3.TabIndex = 81;
            // 
            // btn_leave
            // 
            this.btn_leave.BackColor = System.Drawing.Color.Transparent;
            this.btn_leave.BackgroundImage = global::Fireon.Properties.Resources.btn_leave;
            this.btn_leave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_leave.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_leave.FlatAppearance.BorderSize = 0;
            this.btn_leave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_leave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_leave.Location = new System.Drawing.Point(0, 190);
            this.btn_leave.Name = "btn_leave";
            this.btn_leave.Size = new System.Drawing.Size(252, 31);
            this.btn_leave.TabIndex = 80;
            this.btn_leave.TabStop = false;
            this.btn_leave.UseVisualStyleBackColor = false;
            this.btn_leave.Click += new System.EventHandler(this.btn_leave_Click);
            // 
            // pnl_separator_2
            // 
            this.pnl_separator_2.BackColor = System.Drawing.Color.Transparent;
            this.pnl_separator_2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_separator_2.Location = new System.Drawing.Point(0, 180);
            this.pnl_separator_2.Name = "pnl_separator_2";
            this.pnl_separator_2.Size = new System.Drawing.Size(252, 10);
            this.pnl_separator_2.TabIndex = 79;
            // 
            // btn_employee
            // 
            this.btn_employee.BackColor = System.Drawing.Color.Transparent;
            this.btn_employee.BackgroundImage = global::Fireon.Properties.Resources.btn_employee;
            this.btn_employee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_employee.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_employee.FlatAppearance.BorderSize = 0;
            this.btn_employee.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_employee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_employee.Location = new System.Drawing.Point(0, 149);
            this.btn_employee.Name = "btn_employee";
            this.btn_employee.Size = new System.Drawing.Size(252, 31);
            this.btn_employee.TabIndex = 78;
            this.btn_employee.TabStop = false;
            this.btn_employee.UseVisualStyleBackColor = false;
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
            this.lbl_manage_employee.TabIndex = 51;
            this.lbl_manage_employee.Text = "MANAGE EMPLOYEES";
            // 
            // btn_dashboard
            // 
            this.btn_dashboard.BackColor = System.Drawing.Color.Transparent;
            this.btn_dashboard.BackgroundImage = global::Fireon.Properties.Resources.btn_dashboard;
            this.btn_dashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_dashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_dashboard.FlatAppearance.BorderSize = 0;
            this.btn_dashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dashboard.Location = new System.Drawing.Point(0, 89);
            this.btn_dashboard.Name = "btn_dashboard";
            this.btn_dashboard.Size = new System.Drawing.Size(252, 31);
            this.btn_dashboard.TabIndex = 50;
            this.btn_dashboard.TabStop = false;
            this.btn_dashboard.UseVisualStyleBackColor = false;
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
            this.uc_deductions.Location = new System.Drawing.Point(255, 400);
            this.uc_deductions.Name = "uc_deductions";
            this.uc_deductions.Size = new System.Drawing.Size(1068, 658);
            this.uc_deductions.TabIndex = 23;
            this.uc_deductions.Visible = false;
            // 
            // uc_cash_advance
            // 
            this.uc_cash_advance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uc_cash_advance.BackColor = System.Drawing.Color.White;
            this.uc_cash_advance.Location = new System.Drawing.Point(255, 346);
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
            this.uc_holiday.Location = new System.Drawing.Point(255, 246);
            this.uc_holiday.Name = "uc_holiday";
            this.uc_holiday.Size = new System.Drawing.Size(1068, 658);
            this.uc_holiday.TabIndex = 20;
            this.uc_holiday.Visible = false;
            // 
            // uc_overtime
            // 
            this.uc_overtime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uc_overtime.BackColor = System.Drawing.Color.White;
            this.uc_overtime.Location = new System.Drawing.Point(258, 195);
            this.uc_overtime.Name = "uc_overtime";
            this.uc_overtime.Size = new System.Drawing.Size(1068, 658);
            this.uc_overtime.TabIndex = 19;
            this.uc_overtime.Visible = false;
            // 
            // uc_leave
            // 
            this.uc_leave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uc_leave.BackColor = System.Drawing.Color.White;
            this.uc_leave.Location = new System.Drawing.Point(255, 164);
            this.uc_leave.Name = "uc_leave";
            this.uc_leave.Size = new System.Drawing.Size(1068, 658);
            this.uc_leave.TabIndex = 18;
            this.uc_leave.Visible = false;
            // 
            // uc_employee
            // 
            this.uc_employee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uc_employee.BackColor = System.Drawing.Color.White;
            this.uc_employee.Location = new System.Drawing.Point(255, 113);
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
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1320, 729);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1366, 768);
            this.Name = "frmFireonPayroll";
            this.TopMost = true;
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
        
        private System.Windows.Forms.Label lbl_user;
        private ucSettings uc_settings;
        private ucViolations uc_violations;
        private System.Windows.Forms.Panel pnl_sidebar;
        private System.Windows.Forms.Panel pnl_separator_1;
        private System.Windows.Forms.PictureBox picb_fireon;
        private System.Windows.Forms.Panel pnl_menu;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btn_dashboard;
        private System.Windows.Forms.Label lbl_manage_employee;
        private System.Windows.Forms.Button btn_deductions;
        private System.Windows.Forms.Panel pnl_separator_7;
        private System.Windows.Forms.Button btn_cash_advance;
        private System.Windows.Forms.Panel pnl_separator_6;
        private System.Windows.Forms.Button btn_violations;
        private System.Windows.Forms.Panel pnl_separator_5;
        private System.Windows.Forms.Button btn_holiday;
        private System.Windows.Forms.Panel pnl_separator_4;
        private System.Windows.Forms.Button btn_overtime;
        private System.Windows.Forms.Panel pnl_separator_3;
        private System.Windows.Forms.Button btn_leave;
        private System.Windows.Forms.Panel pnl_separator_2;
        private System.Windows.Forms.Button btn_employee;
        private System.Windows.Forms.Panel pnl_separator_8;
        private System.Windows.Forms.Button btn_allowances;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_all;
        private System.Windows.Forms.Panel pnl_separator_9;
        private System.Windows.Forms.Button btn_department;
        private System.Windows.Forms.Panel pnl_separator_10;
        private System.Windows.Forms.Button btn_single_posting;
        private System.Windows.Forms.Panel pnl_separator_11;
        private System.Windows.Forms.Button btn_settings;
        private System.Windows.Forms.Label lbl_date_today;
        private System.Windows.Forms.Label lbl_version;
        private System.Windows.Forms.Button btn_notification;
        private System.Windows.Forms.Button btn_menu;
    }
}