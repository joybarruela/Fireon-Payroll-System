namespace Fireon
{
    partial class ucOvertime
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
            this.lbl_overtime = new System.Windows.Forms.Label();
            this.cmbx_regular_contractual = new System.Windows.Forms.ComboBox();
            this.txtbx_search = new System.Windows.Forms.TextBox();
            this.cmbx_year = new System.Windows.Forms.ComboBox();
            this.cmbx_month = new System.Windows.Forms.ComboBox();
            this.cmbx_position = new System.Windows.Forms.ComboBox();
            this.cmbx_department = new System.Windows.Forms.ComboBox();
            this.pnl_overtime = new System.Windows.Forms.Panel();
            this.flpnl_overtime = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_employee_id = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_department = new System.Windows.Forms.Label();
            this.lbl_position = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.lbl_rate_per_hour = new System.Windows.Forms.Label();
            this.dtgv_overtime = new System.Windows.Forms.DataGridView();
            this.btn_add_overtime = new System.Windows.Forms.Button();
            this.pnl_del_upd = new System.Windows.Forms.Panel();
            this.btn_delete_8 = new System.Windows.Forms.Button();
            this.btn_delete_7 = new System.Windows.Forms.Button();
            this.btn_delete_6 = new System.Windows.Forms.Button();
            this.btn_delete_5 = new System.Windows.Forms.Button();
            this.btn_delete_4 = new System.Windows.Forms.Button();
            this.btn_delete_3 = new System.Windows.Forms.Button();
            this.btn_delete_2 = new System.Windows.Forms.Button();
            this.btn_delete_1 = new System.Windows.Forms.Button();
            this.btn_update_8 = new System.Windows.Forms.Button();
            this.btn_update_7 = new System.Windows.Forms.Button();
            this.btn_update_6 = new System.Windows.Forms.Button();
            this.btn_update_5 = new System.Windows.Forms.Button();
            this.btn_update_4 = new System.Windows.Forms.Button();
            this.btn_update_3 = new System.Windows.Forms.Button();
            this.btn_update_2 = new System.Windows.Forms.Button();
            this.btn_update_1 = new System.Windows.Forms.Button();
            this.pnl_overtime.SuspendLayout();
            this.flpnl_overtime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_overtime)).BeginInit();
            this.pnl_del_upd.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_overtime
            // 
            this.lbl_overtime.AutoSize = true;
            this.lbl_overtime.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_overtime.Font = new System.Drawing.Font("Open Sans", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_overtime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_overtime.Location = new System.Drawing.Point(0, 0);
            this.lbl_overtime.Name = "lbl_overtime";
            this.lbl_overtime.Padding = new System.Windows.Forms.Padding(30, 30, 0, 10);
            this.lbl_overtime.Size = new System.Drawing.Size(200, 83);
            this.lbl_overtime.TabIndex = 201;
            this.lbl_overtime.Text = "Overtime";
            // 
            // cmbx_regular_contractual
            // 
            this.cmbx_regular_contractual.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbx_regular_contractual.FormattingEnabled = true;
            this.cmbx_regular_contractual.Items.AddRange(new object[] {
            "Regular",
            "Contractual"});
            this.cmbx_regular_contractual.Location = new System.Drawing.Point(39, 115);
            this.cmbx_regular_contractual.Margin = new System.Windows.Forms.Padding(10);
            this.cmbx_regular_contractual.Name = "cmbx_regular_contractual";
            this.cmbx_regular_contractual.Size = new System.Drawing.Size(200, 28);
            this.cmbx_regular_contractual.TabIndex = 3;
            this.cmbx_regular_contractual.TabStop = false;
            this.cmbx_regular_contractual.Text = "Regular/Contractual";
            // 
            // txtbx_search
            // 
            this.txtbx_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_search.Location = new System.Drawing.Point(39, 85);
            this.txtbx_search.Name = "txtbx_search";
            this.txtbx_search.Size = new System.Drawing.Size(199, 26);
            this.txtbx_search.TabIndex = 2;
            this.txtbx_search.TabStop = false;
            this.txtbx_search.Text = "Search";
            // 
            // cmbx_year
            // 
            this.cmbx_year.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbx_year.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbx_year.FormattingEnabled = true;
            this.cmbx_year.Items.AddRange(new object[] {
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025"});
            this.cmbx_year.Location = new System.Drawing.Point(761, 115);
            this.cmbx_year.Margin = new System.Windows.Forms.Padding(10);
            this.cmbx_year.Name = "cmbx_year";
            this.cmbx_year.Size = new System.Drawing.Size(152, 28);
            this.cmbx_year.TabIndex = 7;
            this.cmbx_year.TabStop = false;
            this.cmbx_year.Text = "Year";
            // 
            // cmbx_month
            // 
            this.cmbx_month.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbx_month.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbx_month.FormattingEnabled = true;
            this.cmbx_month.Items.AddRange(new object[] {
            "January ",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July ",
            "August",
            "September",
            "October ",
            "November",
            "December"});
            this.cmbx_month.Location = new System.Drawing.Point(761, 83);
            this.cmbx_month.Margin = new System.Windows.Forms.Padding(10);
            this.cmbx_month.Name = "cmbx_month";
            this.cmbx_month.Size = new System.Drawing.Size(152, 28);
            this.cmbx_month.TabIndex = 6;
            this.cmbx_month.TabStop = false;
            this.cmbx_month.Text = "Month";
            // 
            // cmbx_position
            // 
            this.cmbx_position.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbx_position.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbx_position.FormattingEnabled = true;
            this.cmbx_position.Location = new System.Drawing.Point(532, 115);
            this.cmbx_position.Margin = new System.Windows.Forms.Padding(10);
            this.cmbx_position.Name = "cmbx_position";
            this.cmbx_position.Size = new System.Drawing.Size(219, 28);
            this.cmbx_position.TabIndex = 5;
            this.cmbx_position.TabStop = false;
            this.cmbx_position.Text = "Position";
            // 
            // cmbx_department
            // 
            this.cmbx_department.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbx_department.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbx_department.FormattingEnabled = true;
            this.cmbx_department.Items.AddRange(new object[] {
            "IT Department",
            "Marketing Department",
            "Finance Department",
            "Operations Department",
            "Sales Department",
            "Human Resource Department",
            "Customer Service Department",
            "Research and Development Department",
            "Administrative Department",
            "Purchasing Department",
            "Legal Department",
            "Production Department"});
            this.cmbx_department.Location = new System.Drawing.Point(532, 83);
            this.cmbx_department.Margin = new System.Windows.Forms.Padding(10);
            this.cmbx_department.Name = "cmbx_department";
            this.cmbx_department.Size = new System.Drawing.Size(219, 28);
            this.cmbx_department.TabIndex = 4;
            this.cmbx_department.TabStop = false;
            this.cmbx_department.Text = "Department";
            // 
            // pnl_overtime
            // 
            this.pnl_overtime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_overtime.Controls.Add(this.flpnl_overtime);
            this.pnl_overtime.Controls.Add(this.dtgv_overtime);
            this.pnl_overtime.Location = new System.Drawing.Point(39, 156);
            this.pnl_overtime.Name = "pnl_overtime";
            this.pnl_overtime.Size = new System.Drawing.Size(874, 444);
            this.pnl_overtime.TabIndex = 261;
            // 
            // flpnl_overtime
            // 
            this.flpnl_overtime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(5)))));
            this.flpnl_overtime.Controls.Add(this.lbl_employee_id);
            this.flpnl_overtime.Controls.Add(this.lbl_name);
            this.flpnl_overtime.Controls.Add(this.lbl_department);
            this.flpnl_overtime.Controls.Add(this.lbl_position);
            this.flpnl_overtime.Controls.Add(this.lbl_status);
            this.flpnl_overtime.Controls.Add(this.lbl_rate_per_hour);
            this.flpnl_overtime.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpnl_overtime.Location = new System.Drawing.Point(0, 0);
            this.flpnl_overtime.Name = "flpnl_overtime";
            this.flpnl_overtime.Padding = new System.Windows.Forms.Padding(10);
            this.flpnl_overtime.Size = new System.Drawing.Size(874, 37);
            this.flpnl_overtime.TabIndex = 147;
            // 
            // lbl_employee_id
            // 
            this.lbl_employee_id.AutoSize = true;
            this.lbl_employee_id.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_employee_id.ForeColor = System.Drawing.Color.White;
            this.lbl_employee_id.Location = new System.Drawing.Point(13, 10);
            this.lbl_employee_id.Name = "lbl_employee_id";
            this.lbl_employee_id.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.lbl_employee_id.Size = new System.Drawing.Size(98, 18);
            this.lbl_employee_id.TabIndex = 9;
            this.lbl_employee_id.Text = "Employee ID";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.White;
            this.lbl_name.Location = new System.Drawing.Point(117, 10);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Padding = new System.Windows.Forms.Padding(0, 0, 100, 0);
            this.lbl_name.Size = new System.Drawing.Size(148, 18);
            this.lbl_name.TabIndex = 9;
            this.lbl_name.Text = "Name";
            // 
            // lbl_department
            // 
            this.lbl_department.AutoSize = true;
            this.lbl_department.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_department.ForeColor = System.Drawing.Color.White;
            this.lbl_department.Location = new System.Drawing.Point(271, 10);
            this.lbl_department.Name = "lbl_department";
            this.lbl_department.Padding = new System.Windows.Forms.Padding(0, 0, 80, 0);
            this.lbl_department.Size = new System.Drawing.Size(170, 18);
            this.lbl_department.TabIndex = 9;
            this.lbl_department.Text = "Department";
            // 
            // lbl_position
            // 
            this.lbl_position.AutoSize = true;
            this.lbl_position.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_position.ForeColor = System.Drawing.Color.White;
            this.lbl_position.Location = new System.Drawing.Point(447, 10);
            this.lbl_position.Name = "lbl_position";
            this.lbl_position.Padding = new System.Windows.Forms.Padding(0, 0, 80, 0);
            this.lbl_position.Size = new System.Drawing.Size(141, 18);
            this.lbl_position.TabIndex = 9;
            this.lbl_position.Text = "Position";
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.ForeColor = System.Drawing.Color.White;
            this.lbl_status.Location = new System.Drawing.Point(594, 10);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Padding = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.lbl_status.Size = new System.Drawing.Size(100, 18);
            this.lbl_status.TabIndex = 9;
            this.lbl_status.Text = "Status";
            // 
            // lbl_rate_per_hour
            // 
            this.lbl_rate_per_hour.AutoSize = true;
            this.lbl_rate_per_hour.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rate_per_hour.ForeColor = System.Drawing.Color.White;
            this.lbl_rate_per_hour.Location = new System.Drawing.Point(700, 10);
            this.lbl_rate_per_hour.Name = "lbl_rate_per_hour";
            this.lbl_rate_per_hour.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.lbl_rate_per_hour.Size = new System.Drawing.Size(119, 18);
            this.lbl_rate_per_hour.TabIndex = 9;
            this.lbl_rate_per_hour.Text = "Rate per hour";
            // 
            // dtgv_overtime
            // 
            this.dtgv_overtime.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(5)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv_overtime.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgv_overtime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(5)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgv_overtime.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgv_overtime.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgv_overtime.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dtgv_overtime.Location = new System.Drawing.Point(0, 34);
            this.dtgv_overtime.Name = "dtgv_overtime";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(5)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv_overtime.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgv_overtime.Size = new System.Drawing.Size(874, 410);
            this.dtgv_overtime.TabIndex = 146;
            // 
            // btn_add_overtime
            // 
            this.btn_add_overtime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add_overtime.BackgroundImage = global::Fireon.Properties.Resources.btn_add;
            this.btn_add_overtime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_add_overtime.FlatAppearance.BorderSize = 0;
            this.btn_add_overtime.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_add_overtime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_overtime.Location = new System.Drawing.Point(789, 628);
            this.btn_add_overtime.Name = "btn_add_overtime";
            this.btn_add_overtime.Size = new System.Drawing.Size(124, 29);
            this.btn_add_overtime.TabIndex = 263;
            this.btn_add_overtime.TabStop = false;
            this.btn_add_overtime.UseVisualStyleBackColor = true;
            // 
            // pnl_del_upd
            // 
            this.pnl_del_upd.Controls.Add(this.btn_delete_8);
            this.pnl_del_upd.Controls.Add(this.btn_delete_7);
            this.pnl_del_upd.Controls.Add(this.btn_delete_6);
            this.pnl_del_upd.Controls.Add(this.btn_delete_5);
            this.pnl_del_upd.Controls.Add(this.btn_delete_4);
            this.pnl_del_upd.Controls.Add(this.btn_delete_3);
            this.pnl_del_upd.Controls.Add(this.btn_delete_2);
            this.pnl_del_upd.Controls.Add(this.btn_delete_1);
            this.pnl_del_upd.Controls.Add(this.btn_update_8);
            this.pnl_del_upd.Controls.Add(this.btn_update_7);
            this.pnl_del_upd.Controls.Add(this.btn_update_6);
            this.pnl_del_upd.Controls.Add(this.btn_update_5);
            this.pnl_del_upd.Controls.Add(this.btn_update_4);
            this.pnl_del_upd.Controls.Add(this.btn_update_3);
            this.pnl_del_upd.Controls.Add(this.btn_update_2);
            this.pnl_del_upd.Controls.Add(this.btn_update_1);
            this.pnl_del_upd.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_del_upd.Location = new System.Drawing.Point(914, 83);
            this.pnl_del_upd.Name = "pnl_del_upd";
            this.pnl_del_upd.Size = new System.Drawing.Size(146, 597);
            this.pnl_del_upd.TabIndex = 262;
            // 
            // btn_delete_8
            // 
            this.btn_delete_8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_delete_8.BackgroundImage = global::Fireon.Properties.Resources.btn_delete_db_active;
            this.btn_delete_8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_delete_8.FlatAppearance.BorderSize = 0;
            this.btn_delete_8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(5)))));
            this.btn_delete_8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete_8.Location = new System.Drawing.Point(14, 469);
            this.btn_delete_8.Name = "btn_delete_8";
            this.btn_delete_8.Size = new System.Drawing.Size(27, 25);
            this.btn_delete_8.TabIndex = 222;
            this.btn_delete_8.TabStop = false;
            this.btn_delete_8.UseVisualStyleBackColor = true;
            // 
            // btn_delete_7
            // 
            this.btn_delete_7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_delete_7.BackgroundImage = global::Fireon.Properties.Resources.btn_delete_db_active;
            this.btn_delete_7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_delete_7.FlatAppearance.BorderSize = 0;
            this.btn_delete_7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(5)))));
            this.btn_delete_7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete_7.Location = new System.Drawing.Point(14, 420);
            this.btn_delete_7.Name = "btn_delete_7";
            this.btn_delete_7.Size = new System.Drawing.Size(27, 25);
            this.btn_delete_7.TabIndex = 222;
            this.btn_delete_7.TabStop = false;
            this.btn_delete_7.UseVisualStyleBackColor = true;
            // 
            // btn_delete_6
            // 
            this.btn_delete_6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_delete_6.BackgroundImage = global::Fireon.Properties.Resources.btn_delete_db_active;
            this.btn_delete_6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_delete_6.FlatAppearance.BorderSize = 0;
            this.btn_delete_6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(5)))));
            this.btn_delete_6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete_6.Location = new System.Drawing.Point(14, 371);
            this.btn_delete_6.Name = "btn_delete_6";
            this.btn_delete_6.Size = new System.Drawing.Size(27, 25);
            this.btn_delete_6.TabIndex = 222;
            this.btn_delete_6.TabStop = false;
            this.btn_delete_6.UseVisualStyleBackColor = true;
            // 
            // btn_delete_5
            // 
            this.btn_delete_5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_delete_5.BackgroundImage = global::Fireon.Properties.Resources.btn_delete_db_active;
            this.btn_delete_5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_delete_5.FlatAppearance.BorderSize = 0;
            this.btn_delete_5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(5)))));
            this.btn_delete_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete_5.Location = new System.Drawing.Point(14, 322);
            this.btn_delete_5.Name = "btn_delete_5";
            this.btn_delete_5.Size = new System.Drawing.Size(27, 25);
            this.btn_delete_5.TabIndex = 222;
            this.btn_delete_5.TabStop = false;
            this.btn_delete_5.UseVisualStyleBackColor = true;
            // 
            // btn_delete_4
            // 
            this.btn_delete_4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_delete_4.BackgroundImage = global::Fireon.Properties.Resources.btn_delete_db_active;
            this.btn_delete_4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_delete_4.FlatAppearance.BorderSize = 0;
            this.btn_delete_4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(5)))));
            this.btn_delete_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete_4.Location = new System.Drawing.Point(14, 273);
            this.btn_delete_4.Name = "btn_delete_4";
            this.btn_delete_4.Size = new System.Drawing.Size(27, 25);
            this.btn_delete_4.TabIndex = 222;
            this.btn_delete_4.TabStop = false;
            this.btn_delete_4.UseVisualStyleBackColor = true;
            // 
            // btn_delete_3
            // 
            this.btn_delete_3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_delete_3.BackgroundImage = global::Fireon.Properties.Resources.btn_delete_db_active;
            this.btn_delete_3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_delete_3.FlatAppearance.BorderSize = 0;
            this.btn_delete_3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(5)))));
            this.btn_delete_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete_3.Location = new System.Drawing.Point(14, 224);
            this.btn_delete_3.Name = "btn_delete_3";
            this.btn_delete_3.Size = new System.Drawing.Size(27, 25);
            this.btn_delete_3.TabIndex = 222;
            this.btn_delete_3.TabStop = false;
            this.btn_delete_3.UseVisualStyleBackColor = true;
            // 
            // btn_delete_2
            // 
            this.btn_delete_2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_delete_2.BackgroundImage = global::Fireon.Properties.Resources.btn_delete_db_active;
            this.btn_delete_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_delete_2.FlatAppearance.BorderSize = 0;
            this.btn_delete_2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(5)))));
            this.btn_delete_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete_2.Location = new System.Drawing.Point(14, 175);
            this.btn_delete_2.Name = "btn_delete_2";
            this.btn_delete_2.Size = new System.Drawing.Size(27, 25);
            this.btn_delete_2.TabIndex = 222;
            this.btn_delete_2.TabStop = false;
            this.btn_delete_2.UseVisualStyleBackColor = true;
            // 
            // btn_delete_1
            // 
            this.btn_delete_1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_delete_1.BackgroundImage = global::Fireon.Properties.Resources.btn_delete_db_active;
            this.btn_delete_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_delete_1.FlatAppearance.BorderSize = 0;
            this.btn_delete_1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(5)))));
            this.btn_delete_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete_1.Location = new System.Drawing.Point(14, 126);
            this.btn_delete_1.Name = "btn_delete_1";
            this.btn_delete_1.Size = new System.Drawing.Size(27, 25);
            this.btn_delete_1.TabIndex = 222;
            this.btn_delete_1.TabStop = false;
            this.btn_delete_1.UseVisualStyleBackColor = true;
            // 
            // btn_update_8
            // 
            this.btn_update_8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_update_8.BackgroundImage = global::Fireon.Properties.Resources.btn_update_active;
            this.btn_update_8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_update_8.FlatAppearance.BorderSize = 0;
            this.btn_update_8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(5)))));
            this.btn_update_8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update_8.Location = new System.Drawing.Point(50, 469);
            this.btn_update_8.Name = "btn_update_8";
            this.btn_update_8.Size = new System.Drawing.Size(27, 25);
            this.btn_update_8.TabIndex = 222;
            this.btn_update_8.TabStop = false;
            this.btn_update_8.UseVisualStyleBackColor = true;
            // 
            // btn_update_7
            // 
            this.btn_update_7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_update_7.BackgroundImage = global::Fireon.Properties.Resources.btn_update_active;
            this.btn_update_7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_update_7.FlatAppearance.BorderSize = 0;
            this.btn_update_7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(5)))));
            this.btn_update_7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update_7.Location = new System.Drawing.Point(50, 420);
            this.btn_update_7.Name = "btn_update_7";
            this.btn_update_7.Size = new System.Drawing.Size(27, 25);
            this.btn_update_7.TabIndex = 222;
            this.btn_update_7.TabStop = false;
            this.btn_update_7.UseVisualStyleBackColor = true;
            // 
            // btn_update_6
            // 
            this.btn_update_6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_update_6.BackgroundImage = global::Fireon.Properties.Resources.btn_update_active;
            this.btn_update_6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_update_6.FlatAppearance.BorderSize = 0;
            this.btn_update_6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(5)))));
            this.btn_update_6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update_6.Location = new System.Drawing.Point(50, 371);
            this.btn_update_6.Name = "btn_update_6";
            this.btn_update_6.Size = new System.Drawing.Size(27, 25);
            this.btn_update_6.TabIndex = 222;
            this.btn_update_6.TabStop = false;
            this.btn_update_6.UseVisualStyleBackColor = true;
            // 
            // btn_update_5
            // 
            this.btn_update_5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_update_5.BackgroundImage = global::Fireon.Properties.Resources.btn_update_active;
            this.btn_update_5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_update_5.FlatAppearance.BorderSize = 0;
            this.btn_update_5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(5)))));
            this.btn_update_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update_5.Location = new System.Drawing.Point(50, 322);
            this.btn_update_5.Name = "btn_update_5";
            this.btn_update_5.Size = new System.Drawing.Size(27, 25);
            this.btn_update_5.TabIndex = 222;
            this.btn_update_5.TabStop = false;
            this.btn_update_5.UseVisualStyleBackColor = true;
            // 
            // btn_update_4
            // 
            this.btn_update_4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_update_4.BackgroundImage = global::Fireon.Properties.Resources.btn_update_active;
            this.btn_update_4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_update_4.FlatAppearance.BorderSize = 0;
            this.btn_update_4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(5)))));
            this.btn_update_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update_4.Location = new System.Drawing.Point(50, 273);
            this.btn_update_4.Name = "btn_update_4";
            this.btn_update_4.Size = new System.Drawing.Size(27, 25);
            this.btn_update_4.TabIndex = 222;
            this.btn_update_4.TabStop = false;
            this.btn_update_4.UseVisualStyleBackColor = true;
            // 
            // btn_update_3
            // 
            this.btn_update_3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_update_3.BackgroundImage = global::Fireon.Properties.Resources.btn_update_active;
            this.btn_update_3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_update_3.FlatAppearance.BorderSize = 0;
            this.btn_update_3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(5)))));
            this.btn_update_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update_3.Location = new System.Drawing.Point(50, 224);
            this.btn_update_3.Name = "btn_update_3";
            this.btn_update_3.Size = new System.Drawing.Size(27, 25);
            this.btn_update_3.TabIndex = 222;
            this.btn_update_3.TabStop = false;
            this.btn_update_3.UseVisualStyleBackColor = true;
            // 
            // btn_update_2
            // 
            this.btn_update_2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_update_2.BackgroundImage = global::Fireon.Properties.Resources.btn_update_active;
            this.btn_update_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_update_2.FlatAppearance.BorderSize = 0;
            this.btn_update_2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(5)))));
            this.btn_update_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update_2.Location = new System.Drawing.Point(50, 175);
            this.btn_update_2.Name = "btn_update_2";
            this.btn_update_2.Size = new System.Drawing.Size(27, 25);
            this.btn_update_2.TabIndex = 222;
            this.btn_update_2.TabStop = false;
            this.btn_update_2.UseVisualStyleBackColor = true;
            // 
            // btn_update_1
            // 
            this.btn_update_1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_update_1.BackgroundImage = global::Fireon.Properties.Resources.btn_update_active;
            this.btn_update_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_update_1.FlatAppearance.BorderSize = 0;
            this.btn_update_1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(5)))));
            this.btn_update_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update_1.Location = new System.Drawing.Point(50, 126);
            this.btn_update_1.Name = "btn_update_1";
            this.btn_update_1.Size = new System.Drawing.Size(27, 25);
            this.btn_update_1.TabIndex = 222;
            this.btn_update_1.TabStop = false;
            this.btn_update_1.UseVisualStyleBackColor = true;
            // 
            // ucOvertime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btn_add_overtime);
            this.Controls.Add(this.pnl_del_upd);
            this.Controls.Add(this.pnl_overtime);
            this.Controls.Add(this.cmbx_regular_contractual);
            this.Controls.Add(this.txtbx_search);
            this.Controls.Add(this.cmbx_year);
            this.Controls.Add(this.cmbx_month);
            this.Controls.Add(this.cmbx_position);
            this.Controls.Add(this.cmbx_department);
            this.Controls.Add(this.lbl_overtime);
            this.Name = "ucOvertime";
            this.Size = new System.Drawing.Size(1060, 680);
            this.Load += new System.EventHandler(this.Overtime_Load);
            this.pnl_overtime.ResumeLayout(false);
            this.flpnl_overtime.ResumeLayout(false);
            this.flpnl_overtime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_overtime)).EndInit();
            this.pnl_del_upd.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_overtime;
        private System.Windows.Forms.ComboBox cmbx_regular_contractual;
        private System.Windows.Forms.TextBox txtbx_search;
        private System.Windows.Forms.ComboBox cmbx_year;
        private System.Windows.Forms.ComboBox cmbx_month;
        private System.Windows.Forms.ComboBox cmbx_position;
        private System.Windows.Forms.ComboBox cmbx_department;
        private System.Windows.Forms.Panel pnl_overtime;
        private System.Windows.Forms.FlowLayoutPanel flpnl_overtime;
        private System.Windows.Forms.Label lbl_employee_id;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_department;
        private System.Windows.Forms.Label lbl_position;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Label lbl_rate_per_hour;
        private System.Windows.Forms.DataGridView dtgv_overtime;
        private System.Windows.Forms.Button btn_add_overtime;
        private System.Windows.Forms.Panel pnl_del_upd;
        private System.Windows.Forms.Button btn_delete_8;
        private System.Windows.Forms.Button btn_delete_7;
        private System.Windows.Forms.Button btn_delete_6;
        private System.Windows.Forms.Button btn_delete_5;
        private System.Windows.Forms.Button btn_delete_4;
        private System.Windows.Forms.Button btn_delete_3;
        private System.Windows.Forms.Button btn_delete_2;
        private System.Windows.Forms.Button btn_delete_1;
        private System.Windows.Forms.Button btn_update_8;
        private System.Windows.Forms.Button btn_update_7;
        private System.Windows.Forms.Button btn_update_6;
        private System.Windows.Forms.Button btn_update_5;
        private System.Windows.Forms.Button btn_update_4;
        private System.Windows.Forms.Button btn_update_3;
        private System.Windows.Forms.Button btn_update_2;
        private System.Windows.Forms.Button btn_update_1;
    }
}
