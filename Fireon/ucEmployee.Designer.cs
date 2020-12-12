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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucEmployee));
            this.lblTotalEmployees = new System.Windows.Forms.Label();
            this.lblTotalEmployeesAmount = new System.Windows.Forms.Label();
            this.cmbxRegularContractual = new System.Windows.Forms.ComboBox();
            this.txtbxSearch = new System.Windows.Forms.TextBox();
            this.cmbxYear = new System.Windows.Forms.ComboBox();
            this.cmbxMonth = new System.Windows.Forms.ComboBox();
            this.cmbxPosition = new System.Windows.Forms.ComboBox();
            this.cmbxDepartment = new System.Windows.Forms.ComboBox();
            this.dtgvEmployee = new System.Windows.Forms.DataGridView();
            this.btnPrintEmployees = new System.Windows.Forms.Button();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.pnlFilters = new System.Windows.Forms.Panel();
            this.tblpEmployee = new System.Windows.Forms.TableLayoutPanel();
            this.pnlBelow = new System.Windows.Forms.Panel();
            this.btnHireEmployees = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEmployee)).BeginInit();
            this.pnlFilters.SuspendLayout();
            this.tblpEmployee.SuspendLayout();
            this.pnlBelow.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTotalEmployees
            // 
            this.lblTotalEmployees.AutoSize = true;
            this.lblTotalEmployees.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTotalEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalEmployees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTotalEmployees.Location = new System.Drawing.Point(174, 0);
            this.lblTotalEmployees.Name = "lblTotalEmployees";
            this.lblTotalEmployees.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblTotalEmployees.Size = new System.Drawing.Size(156, 20);
            this.lblTotalEmployees.TabIndex = 171;
            this.lblTotalEmployees.Text = "Total number of employees";
            this.lblTotalEmployees.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalEmployeesAmount
            // 
            this.lblTotalEmployeesAmount.AutoSize = true;
            this.lblTotalEmployeesAmount.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTotalEmployeesAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalEmployeesAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(5)))));
            this.lblTotalEmployeesAmount.Location = new System.Drawing.Point(0, 0);
            this.lblTotalEmployeesAmount.Name = "lblTotalEmployeesAmount";
            this.lblTotalEmployeesAmount.Size = new System.Drawing.Size(174, 29);
            this.lblTotalEmployeesAmount.TabIndex = 172;
            this.lblTotalEmployeesAmount.Text = "9,000,000,000";
            // 
            // cmbxRegularContractual
            // 
            this.cmbxRegularContractual.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxRegularContractual.FormattingEnabled = true;
            this.cmbxRegularContractual.Items.AddRange(new object[] {
            "Regular",
            "Contractual"});
            this.cmbxRegularContractual.Location = new System.Drawing.Point(4, 41);
            this.cmbxRegularContractual.Margin = new System.Windows.Forms.Padding(10);
            this.cmbxRegularContractual.Name = "cmbxRegularContractual";
            this.cmbxRegularContractual.Size = new System.Drawing.Size(200, 28);
            this.cmbxRegularContractual.TabIndex = 3;
            this.cmbxRegularContractual.TabStop = false;
            this.cmbxRegularContractual.Text = "Regular/Contractual";
            // 
            // txtbxSearch
            // 
            this.txtbxSearch.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxSearch.Location = new System.Drawing.Point(4, 10);
            this.txtbxSearch.Name = "txtbxSearch";
            this.txtbxSearch.Size = new System.Drawing.Size(199, 26);
            this.txtbxSearch.TabIndex = 2;
            this.txtbxSearch.TabStop = false;
            this.txtbxSearch.Text = "Search";
            // 
            // cmbxYear
            // 
            this.cmbxYear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbxYear.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxYear.FormattingEnabled = true;
            this.cmbxYear.Items.AddRange(new object[] {
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025"});
            this.cmbxYear.Location = new System.Drawing.Point(735, 41);
            this.cmbxYear.Margin = new System.Windows.Forms.Padding(10);
            this.cmbxYear.Name = "cmbxYear";
            this.cmbxYear.Size = new System.Drawing.Size(152, 28);
            this.cmbxYear.TabIndex = 7;
            this.cmbxYear.TabStop = false;
            this.cmbxYear.Text = "Year";
            // 
            // cmbxMonth
            // 
            this.cmbxMonth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbxMonth.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxMonth.FormattingEnabled = true;
            this.cmbxMonth.Items.AddRange(new object[] {
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
            this.cmbxMonth.Location = new System.Drawing.Point(735, 10);
            this.cmbxMonth.Margin = new System.Windows.Forms.Padding(10);
            this.cmbxMonth.Name = "cmbxMonth";
            this.cmbxMonth.Size = new System.Drawing.Size(152, 28);
            this.cmbxMonth.TabIndex = 6;
            this.cmbxMonth.TabStop = false;
            this.cmbxMonth.Text = "Month";
            // 
            // cmbxPosition
            // 
            this.cmbxPosition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbxPosition.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxPosition.FormattingEnabled = true;
            this.cmbxPosition.Location = new System.Drawing.Point(496, 41);
            this.cmbxPosition.Margin = new System.Windows.Forms.Padding(10);
            this.cmbxPosition.Name = "cmbxPosition";
            this.cmbxPosition.Size = new System.Drawing.Size(219, 28);
            this.cmbxPosition.TabIndex = 5;
            this.cmbxPosition.TabStop = false;
            this.cmbxPosition.Text = "Position";
            // 
            // cmbxDepartment
            // 
            this.cmbxDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbxDepartment.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxDepartment.FormattingEnabled = true;
            this.cmbxDepartment.Items.AddRange(new object[] {
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
            this.cmbxDepartment.Location = new System.Drawing.Point(496, 10);
            this.cmbxDepartment.Margin = new System.Windows.Forms.Padding(10);
            this.cmbxDepartment.Name = "cmbxDepartment";
            this.cmbxDepartment.Size = new System.Drawing.Size(219, 28);
            this.cmbxDepartment.TabIndex = 4;
            this.cmbxDepartment.TabStop = false;
            this.cmbxDepartment.Text = "Department";
            // 
            // dtgvEmployee
            // 
            this.dtgvEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvEmployee.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(5)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvEmployee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(5)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvEmployee.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvEmployee.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dtgvEmployee.Location = new System.Drawing.Point(3, 92);
            this.dtgvEmployee.Name = "dtgvEmployee";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(5)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvEmployee.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvEmployee.Size = new System.Drawing.Size(894, 330);
            this.dtgvEmployee.TabIndex = 146;
            // 
            // btnPrintEmployees
            // 
            this.btnPrintEmployees.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrintEmployees.BackgroundImage")));
            this.btnPrintEmployees.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPrintEmployees.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnPrintEmployees.FlatAppearance.BorderSize = 0;
            this.btnPrintEmployees.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnPrintEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintEmployees.Location = new System.Drawing.Point(646, 0);
            this.btnPrintEmployees.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.btnPrintEmployees.Name = "btnPrintEmployees";
            this.btnPrintEmployees.Size = new System.Drawing.Size(124, 31);
            this.btnPrintEmployees.TabIndex = 271;
            this.btnPrintEmployees.TabStop = false;
            this.btnPrintEmployees.UseVisualStyleBackColor = true;
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblEmployee.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblEmployee.Location = new System.Drawing.Point(0, 0);
            this.lblEmployee.Margin = new System.Windows.Forms.Padding(0);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(172, 38);
            this.lblEmployee.TabIndex = 272;
            this.lblEmployee.Text = "Employee";
            // 
            // pnlFilters
            // 
            this.pnlFilters.Controls.Add(this.cmbxYear);
            this.pnlFilters.Controls.Add(this.cmbxDepartment);
            this.pnlFilters.Controls.Add(this.cmbxPosition);
            this.pnlFilters.Controls.Add(this.cmbxMonth);
            this.pnlFilters.Controls.Add(this.txtbxSearch);
            this.pnlFilters.Controls.Add(this.cmbxRegularContractual);
            this.pnlFilters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFilters.Location = new System.Drawing.Point(3, 3);
            this.pnlFilters.Name = "pnlFilters";
            this.pnlFilters.Size = new System.Drawing.Size(894, 83);
            this.pnlFilters.TabIndex = 273;
            // 
            // tblpEmployee
            // 
            this.tblpEmployee.ColumnCount = 1;
            this.tblpEmployee.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblpEmployee.Controls.Add(this.pnlFilters, 0, 0);
            this.tblpEmployee.Controls.Add(this.dtgvEmployee, 0, 1);
            this.tblpEmployee.Controls.Add(this.pnlBelow, 0, 2);
            this.tblpEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblpEmployee.Location = new System.Drawing.Point(0, 38);
            this.tblpEmployee.Name = "tblpEmployee";
            this.tblpEmployee.RowCount = 3;
            this.tblpEmployee.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.98093F));
            this.tblpEmployee.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.01907F));
            this.tblpEmployee.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tblpEmployee.Size = new System.Drawing.Size(900, 462);
            this.tblpEmployee.TabIndex = 274;
            // 
            // pnlBelow
            // 
            this.pnlBelow.Controls.Add(this.lblTotalEmployees);
            this.pnlBelow.Controls.Add(this.lblTotalEmployeesAmount);
            this.pnlBelow.Controls.Add(this.btnPrintEmployees);
            this.pnlBelow.Controls.Add(this.btnHireEmployees);
            this.pnlBelow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBelow.Location = new System.Drawing.Point(3, 428);
            this.pnlBelow.Name = "pnlBelow";
            this.pnlBelow.Size = new System.Drawing.Size(894, 31);
            this.pnlBelow.TabIndex = 274;
            // 
            // btnHireEmployees
            // 
            this.btnHireEmployees.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHireEmployees.BackgroundImage")));
            this.btnHireEmployees.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHireEmployees.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnHireEmployees.FlatAppearance.BorderSize = 0;
            this.btnHireEmployees.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnHireEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHireEmployees.Location = new System.Drawing.Point(770, 0);
            this.btnHireEmployees.Name = "btnHireEmployees";
            this.btnHireEmployees.Size = new System.Drawing.Size(124, 31);
            this.btnHireEmployees.TabIndex = 271;
            this.btnHireEmployees.TabStop = false;
            this.btnHireEmployees.UseVisualStyleBackColor = true;
            this.btnHireEmployees.Click += new System.EventHandler(this.btn_hire_employees_Click);
            // 
            // ucEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScrollMargin = new System.Drawing.Size(50, 10);
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tblpEmployee);
            this.Controls.Add(this.lblEmployee);
            this.Name = "ucEmployee";
            this.Size = new System.Drawing.Size(900, 500);
            this.Load += new System.EventHandler(this.ucEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEmployee)).EndInit();
            this.pnlFilters.ResumeLayout(false);
            this.pnlFilters.PerformLayout();
            this.tblpEmployee.ResumeLayout(false);
            this.pnlBelow.ResumeLayout(false);
            this.pnlBelow.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotalEmployees;
        private System.Windows.Forms.Label lblTotalEmployeesAmount;
        private System.Windows.Forms.ComboBox cmbxRegularContractual;
        private System.Windows.Forms.TextBox txtbxSearch;
        private System.Windows.Forms.ComboBox cmbxYear;
        private System.Windows.Forms.ComboBox cmbxMonth;
        private System.Windows.Forms.ComboBox cmbxPosition;
        private System.Windows.Forms.ComboBox cmbxDepartment;
        private System.Windows.Forms.DataGridView dtgvEmployee;
        private System.Windows.Forms.Button btnPrintEmployees;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.Panel pnlFilters;
        private System.Windows.Forms.TableLayoutPanel tblpEmployee;
        private System.Windows.Forms.Panel pnlBelow;
        private System.Windows.Forms.Button btnHireEmployees;
    }
}
