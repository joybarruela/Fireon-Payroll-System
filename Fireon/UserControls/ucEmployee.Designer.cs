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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucEmployee));
            this.txtbxSearch = new System.Windows.Forms.TextBox();
            this.cmbxEmployeeStatus = new System.Windows.Forms.ComboBox();
            this.cmbxYear = new System.Windows.Forms.ComboBox();
            this.cmbxMonth = new System.Windows.Forms.ComboBox();
            this.cmbxPosition = new System.Windows.Forms.ComboBox();
            this.cmbxDepartment = new System.Windows.Forms.ComboBox();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.pnlFilters = new System.Windows.Forms.Panel();
            this.tblpEmployee = new System.Windows.Forms.TableLayoutPanel();
            this.pnlBelow = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pnlSeparator2 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlSeparator1 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pnlEmployee = new System.Windows.Forms.Panel();
            this.pnlFilters.SuspendLayout();
            this.tblpEmployee.SuspendLayout();
            this.pnlBelow.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtbxSearch
            // 
            this.txtbxSearch.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxSearch.ForeColor = System.Drawing.Color.Gray;
            this.txtbxSearch.Location = new System.Drawing.Point(4, 10);
            this.txtbxSearch.Name = "txtbxSearch";
            this.txtbxSearch.Size = new System.Drawing.Size(199, 26);
            this.txtbxSearch.TabIndex = 0;
            this.txtbxSearch.TabStop = false;
            this.txtbxSearch.Text = "Search";
            this.txtbxSearch.Enter += new System.EventHandler(this.txtbxSearch_Enter);
            this.txtbxSearch.Leave += new System.EventHandler(this.txtbxSearch_Leave);
            // 
            // cmbxEmployeeStatus
            // 
            this.cmbxEmployeeStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbxEmployeeStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxEmployeeStatus.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxEmployeeStatus.FormattingEnabled = true;
            this.cmbxEmployeeStatus.Location = new System.Drawing.Point(4, 41);
            this.cmbxEmployeeStatus.Margin = new System.Windows.Forms.Padding(10);
            this.cmbxEmployeeStatus.Name = "cmbxEmployeeStatus";
            this.cmbxEmployeeStatus.Size = new System.Drawing.Size(200, 28);
            this.cmbxEmployeeStatus.TabIndex = 1;
            this.cmbxEmployeeStatus.TabStop = false;
            // 
            // cmbxYear
            // 
            this.cmbxYear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbxYear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbxYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxYear.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxYear.FormattingEnabled = true;
            this.cmbxYear.Location = new System.Drawing.Point(735, 41);
            this.cmbxYear.Margin = new System.Windows.Forms.Padding(10);
            this.cmbxYear.Name = "cmbxYear";
            this.cmbxYear.Size = new System.Drawing.Size(152, 28);
            this.cmbxYear.TabIndex = 5;
            this.cmbxYear.TabStop = false;
            // 
            // cmbxMonth
            // 
            this.cmbxMonth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbxMonth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbxMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxMonth.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxMonth.FormattingEnabled = true;
            this.cmbxMonth.Location = new System.Drawing.Point(735, 10);
            this.cmbxMonth.Margin = new System.Windows.Forms.Padding(10);
            this.cmbxMonth.Name = "cmbxMonth";
            this.cmbxMonth.Size = new System.Drawing.Size(152, 28);
            this.cmbxMonth.TabIndex = 4;
            this.cmbxMonth.TabStop = false;
            // 
            // cmbxPosition
            // 
            this.cmbxPosition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbxPosition.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbxPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxPosition.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxPosition.FormattingEnabled = true;
            this.cmbxPosition.Location = new System.Drawing.Point(496, 41);
            this.cmbxPosition.Margin = new System.Windows.Forms.Padding(10);
            this.cmbxPosition.Name = "cmbxPosition";
            this.cmbxPosition.Size = new System.Drawing.Size(219, 28);
            this.cmbxPosition.TabIndex = 3;
            this.cmbxPosition.TabStop = false;
            // 
            // cmbxDepartment
            // 
            this.cmbxDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbxDepartment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbxDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxDepartment.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxDepartment.FormattingEnabled = true;
            this.cmbxDepartment.Location = new System.Drawing.Point(496, 10);
            this.cmbxDepartment.Margin = new System.Windows.Forms.Padding(10);
            this.cmbxDepartment.Name = "cmbxDepartment";
            this.cmbxDepartment.Size = new System.Drawing.Size(219, 28);
            this.cmbxDepartment.TabIndex = 2;
            this.cmbxDepartment.TabStop = false;
            this.cmbxDepartment.SelectedIndexChanged += new System.EventHandler(this.cmbxDepartment_SelectedIndexChanged);
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
            this.lblEmployee.TabIndex = 0;
            this.lblEmployee.Text = "Employee";
            // 
            // pnlFilters
            // 
            this.pnlFilters.Controls.Add(this.cmbxYear);
            this.pnlFilters.Controls.Add(this.cmbxMonth);
            this.pnlFilters.Controls.Add(this.cmbxPosition);
            this.pnlFilters.Controls.Add(this.cmbxDepartment);
            this.pnlFilters.Controls.Add(this.cmbxEmployeeStatus);
            this.pnlFilters.Controls.Add(this.txtbxSearch);
            this.pnlFilters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFilters.Location = new System.Drawing.Point(3, 3);
            this.pnlFilters.Name = "pnlFilters";
            this.pnlFilters.Size = new System.Drawing.Size(894, 79);
            this.pnlFilters.TabIndex = 0;
            // 
            // tblpEmployee
            // 
            this.tblpEmployee.ColumnCount = 1;
            this.tblpEmployee.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblpEmployee.Controls.Add(this.pnlFilters, 0, 0);
            this.tblpEmployee.Controls.Add(this.pnlBelow, 0, 2);
            this.tblpEmployee.Controls.Add(this.pnlEmployee, 0, 1);
            this.tblpEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblpEmployee.Location = new System.Drawing.Point(0, 38);
            this.tblpEmployee.Name = "tblpEmployee";
            this.tblpEmployee.RowCount = 4;
            this.tblpEmployee.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblpEmployee.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblpEmployee.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tblpEmployee.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblpEmployee.Size = new System.Drawing.Size(900, 462);
            this.tblpEmployee.TabIndex = 1;
            // 
            // pnlBelow
            // 
            this.pnlBelow.Controls.Add(this.btnSearch);
            this.pnlBelow.Controls.Add(this.pnlSeparator2);
            this.pnlBelow.Controls.Add(this.btnCancel);
            this.pnlBelow.Controls.Add(this.pnlSeparator1);
            this.pnlBelow.Controls.Add(this.btnAdd);
            this.pnlBelow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBelow.Location = new System.Drawing.Point(3, 409);
            this.pnlBelow.Name = "pnlBelow";
            this.pnlBelow.Size = new System.Drawing.Size(894, 30);
            this.pnlBelow.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::Fireon.Properties.Resources.btnSearch;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(492, 0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(124, 30);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.TabStop = false;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pnlSeparator2
            // 
            this.pnlSeparator2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlSeparator2.Location = new System.Drawing.Point(616, 0);
            this.pnlSeparator2.Name = "pnlSeparator2";
            this.pnlSeparator2.Size = new System.Drawing.Size(15, 30);
            this.pnlSeparator2.TabIndex = 5;
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = global::Fireon.Properties.Resources.btnCancel;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(631, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(124, 30);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.TabStop = false;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pnlSeparator1
            // 
            this.pnlSeparator1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlSeparator1.Location = new System.Drawing.Point(755, 0);
            this.pnlSeparator1.Name = "pnlSeparator1";
            this.pnlSeparator1.Size = new System.Drawing.Size(15, 30);
            this.pnlSeparator1.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(770, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(124, 30);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.TabStop = false;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pnlEmployee
            // 
            this.pnlEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEmployee.Location = new System.Drawing.Point(3, 88);
            this.pnlEmployee.Name = "pnlEmployee";
            this.pnlEmployee.Size = new System.Drawing.Size(894, 315);
            this.pnlEmployee.TabIndex = 1;
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
            this.pnlFilters.ResumeLayout(false);
            this.pnlFilters.PerformLayout();
            this.tblpEmployee.ResumeLayout(false);
            this.pnlBelow.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbxEmployeeStatus;
        private System.Windows.Forms.ComboBox cmbxYear;
        private System.Windows.Forms.ComboBox cmbxMonth;
        private System.Windows.Forms.ComboBox cmbxPosition;
        private System.Windows.Forms.ComboBox cmbxDepartment;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.Panel pnlFilters;
        private System.Windows.Forms.TableLayoutPanel tblpEmployee;
        private System.Windows.Forms.Panel pnlEmployee;
        private System.Windows.Forms.Panel pnlBelow;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel pnlSeparator1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel pnlSeparator2;
        public System.Windows.Forms.TextBox txtbxSearch;
    }
}
