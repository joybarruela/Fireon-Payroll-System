namespace Fireon
{
    partial class ucEmployee
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
            this.lbl_total_employees = new System.Windows.Forms.Label();
            this.lbl_total_employees_amount = new System.Windows.Forms.Label();
            this.cmbx_regular_contractual = new System.Windows.Forms.ComboBox();
            this.txtbx_search = new System.Windows.Forms.TextBox();
            this.cmbx_year = new System.Windows.Forms.ComboBox();
            this.cmbx_month = new System.Windows.Forms.ComboBox();
            this.cmbx_position = new System.Windows.Forms.ComboBox();
            this.cmbx_department = new System.Windows.Forms.ComboBox();
            this.dtgv_employee = new System.Windows.Forms.DataGridView();
            this.btn_print_employees = new System.Windows.Forms.Button();
            this.lbl_employee = new System.Windows.Forms.Label();
            this.pnl_filters = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_hire_employees = new System.Windows.Forms.Button();
            this.pnl_below = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_employee)).BeginInit();
            this.pnl_filters.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnl_below.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_total_employees
            // 
            this.lbl_total_employees.AutoSize = true;
            this.lbl_total_employees.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_total_employees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total_employees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_total_employees.Location = new System.Drawing.Point(174, 0);
            this.lbl_total_employees.Name = "lbl_total_employees";
            this.lbl_total_employees.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lbl_total_employees.Size = new System.Drawing.Size(156, 20);
            this.lbl_total_employees.TabIndex = 171;
            this.lbl_total_employees.Text = "Total number of employees";
            this.lbl_total_employees.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_total_employees_amount
            // 
            this.lbl_total_employees_amount.AutoSize = true;
            this.lbl_total_employees_amount.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_total_employees_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total_employees_amount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(5)))));
            this.lbl_total_employees_amount.Location = new System.Drawing.Point(0, 0);
            this.lbl_total_employees_amount.Name = "lbl_total_employees_amount";
            this.lbl_total_employees_amount.Size = new System.Drawing.Size(174, 29);
            this.lbl_total_employees_amount.TabIndex = 172;
            this.lbl_total_employees_amount.Text = "9,000,000,000";
            // 
            // cmbx_regular_contractual
            // 
            this.cmbx_regular_contractual.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbx_regular_contractual.FormattingEnabled = true;
            this.cmbx_regular_contractual.Items.AddRange(new object[] {
            "Regular",
            "Contractual"});
            this.cmbx_regular_contractual.Location = new System.Drawing.Point(4, 41);
            this.cmbx_regular_contractual.Margin = new System.Windows.Forms.Padding(10);
            this.cmbx_regular_contractual.Name = "cmbx_regular_contractual";
            this.cmbx_regular_contractual.Size = new System.Drawing.Size(200, 26);
            this.cmbx_regular_contractual.TabIndex = 3;
            this.cmbx_regular_contractual.TabStop = false;
            this.cmbx_regular_contractual.Text = "Regular/Contractual";
            // 
            // txtbx_search
            // 
            this.txtbx_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_search.Location = new System.Drawing.Point(4, 10);
            this.txtbx_search.Name = "txtbx_search";
            this.txtbx_search.Size = new System.Drawing.Size(199, 26);
            this.txtbx_search.TabIndex = 2;
            this.txtbx_search.TabStop = false;
            this.txtbx_search.Text = "Search";
            // 
            // cmbx_year
            // 
            this.cmbx_year.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbx_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbx_year.FormattingEnabled = true;
            this.cmbx_year.Items.AddRange(new object[] {
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025"});
            this.cmbx_year.Location = new System.Drawing.Point(735, 41);
            this.cmbx_year.Margin = new System.Windows.Forms.Padding(10);
            this.cmbx_year.Name = "cmbx_year";
            this.cmbx_year.Size = new System.Drawing.Size(152, 26);
            this.cmbx_year.TabIndex = 7;
            this.cmbx_year.TabStop = false;
            this.cmbx_year.Text = "Year";
            // 
            // cmbx_month
            // 
            this.cmbx_month.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbx_month.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.cmbx_month.Location = new System.Drawing.Point(735, 10);
            this.cmbx_month.Margin = new System.Windows.Forms.Padding(10);
            this.cmbx_month.Name = "cmbx_month";
            this.cmbx_month.Size = new System.Drawing.Size(152, 26);
            this.cmbx_month.TabIndex = 6;
            this.cmbx_month.TabStop = false;
            this.cmbx_month.Text = "Month";
            // 
            // cmbx_position
            // 
            this.cmbx_position.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbx_position.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbx_position.FormattingEnabled = true;
            this.cmbx_position.Location = new System.Drawing.Point(496, 41);
            this.cmbx_position.Margin = new System.Windows.Forms.Padding(10);
            this.cmbx_position.Name = "cmbx_position";
            this.cmbx_position.Size = new System.Drawing.Size(219, 26);
            this.cmbx_position.TabIndex = 5;
            this.cmbx_position.TabStop = false;
            this.cmbx_position.Text = "Position";
            // 
            // cmbx_department
            // 
            this.cmbx_department.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbx_department.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.cmbx_department.Location = new System.Drawing.Point(496, 10);
            this.cmbx_department.Margin = new System.Windows.Forms.Padding(10);
            this.cmbx_department.Name = "cmbx_department";
            this.cmbx_department.Size = new System.Drawing.Size(219, 26);
            this.cmbx_department.TabIndex = 4;
            this.cmbx_department.TabStop = false;
            this.cmbx_department.Text = "Department";
            // 
            // dtgv_employee
            // 
            this.dtgv_employee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgv_employee.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(5)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv_employee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgv_employee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(5)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgv_employee.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgv_employee.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dtgv_employee.Location = new System.Drawing.Point(3, 92);
            this.dtgv_employee.Name = "dtgv_employee";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(5)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv_employee.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgv_employee.Size = new System.Drawing.Size(894, 330);
            this.dtgv_employee.TabIndex = 146;
            // 
            // btn_print_employees
            // 
            this.btn_print_employees.BackgroundImage = global::Fireon.Properties.Resources.btnOthersLogin;
            this.btn_print_employees.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_print_employees.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_print_employees.FlatAppearance.BorderSize = 0;
            this.btn_print_employees.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btn_print_employees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_print_employees.Location = new System.Drawing.Point(646, 0);
            this.btn_print_employees.Name = "btn_print_employees";
            this.btn_print_employees.Size = new System.Drawing.Size(124, 31);
            this.btn_print_employees.TabIndex = 271;
            this.btn_print_employees.TabStop = false;
            this.btn_print_employees.Text = "PRINT";
            this.btn_print_employees.UseVisualStyleBackColor = true;
            // 
            // lbl_employee
            // 
            this.lbl_employee.AutoSize = true;
            this.lbl_employee.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_employee.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_employee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_employee.Location = new System.Drawing.Point(0, 0);
            this.lbl_employee.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_employee.Name = "lbl_employee";
            this.lbl_employee.Size = new System.Drawing.Size(172, 38);
            this.lbl_employee.TabIndex = 272;
            this.lbl_employee.Text = "Employee";
            // 
            // pnl_filters
            // 
            this.pnl_filters.Controls.Add(this.cmbx_year);
            this.pnl_filters.Controls.Add(this.cmbx_department);
            this.pnl_filters.Controls.Add(this.cmbx_position);
            this.pnl_filters.Controls.Add(this.cmbx_month);
            this.pnl_filters.Controls.Add(this.txtbx_search);
            this.pnl_filters.Controls.Add(this.cmbx_regular_contractual);
            this.pnl_filters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_filters.Location = new System.Drawing.Point(3, 3);
            this.pnl_filters.Name = "pnl_filters";
            this.pnl_filters.Size = new System.Drawing.Size(894, 83);
            this.pnl_filters.TabIndex = 273;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pnl_filters, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtgv_employee, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pnl_below, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 38);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.98093F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.01907F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(900, 462);
            this.tableLayoutPanel1.TabIndex = 274;
            // 
            // btn_hire_employees
            // 
            this.btn_hire_employees.BackgroundImage = global::Fireon.Properties.Resources.btnOthersLogin;
            this.btn_hire_employees.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_hire_employees.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_hire_employees.FlatAppearance.BorderSize = 0;
            this.btn_hire_employees.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_hire_employees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hire_employees.Location = new System.Drawing.Point(770, 0);
            this.btn_hire_employees.Name = "btn_hire_employees";
            this.btn_hire_employees.Size = new System.Drawing.Size(124, 31);
            this.btn_hire_employees.TabIndex = 271;
            this.btn_hire_employees.TabStop = false;
            this.btn_hire_employees.Text = "ADD";
            this.btn_hire_employees.UseVisualStyleBackColor = true;
            this.btn_hire_employees.Click += new System.EventHandler(this.btn_hire_employees_Click);
            // 
            // pnl_below
            // 
            this.pnl_below.Controls.Add(this.lbl_total_employees);
            this.pnl_below.Controls.Add(this.lbl_total_employees_amount);
            this.pnl_below.Controls.Add(this.btn_print_employees);
            this.pnl_below.Controls.Add(this.btn_hire_employees);
            this.pnl_below.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_below.Location = new System.Drawing.Point(3, 428);
            this.pnl_below.Name = "pnl_below";
            this.pnl_below.Size = new System.Drawing.Size(894, 31);
            this.pnl_below.TabIndex = 274;
            // 
            // ucEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScrollMargin = new System.Drawing.Size(50, 10);
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lbl_employee);
            this.Name = "ucEmployee";
            this.Size = new System.Drawing.Size(900, 500);
            this.Load += new System.EventHandler(this.ucEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_employee)).EndInit();
            this.pnl_filters.ResumeLayout(false);
            this.pnl_filters.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnl_below.ResumeLayout(false);
            this.pnl_below.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_total_employees;
        private System.Windows.Forms.Label lbl_total_employees_amount;
        private System.Windows.Forms.ComboBox cmbx_regular_contractual;
        private System.Windows.Forms.TextBox txtbx_search;
        private System.Windows.Forms.ComboBox cmbx_year;
        private System.Windows.Forms.ComboBox cmbx_month;
        private System.Windows.Forms.ComboBox cmbx_position;
        private System.Windows.Forms.ComboBox cmbx_department;
        private System.Windows.Forms.DataGridView dtgv_employee;
        private System.Windows.Forms.Button btn_print_employees;
        private System.Windows.Forms.Label lbl_employee;
        private System.Windows.Forms.Panel pnl_filters;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnl_below;
        private System.Windows.Forms.Button btn_hire_employees;
    }
}
