namespace Fireon
{
    partial class ucLeave
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucLeave));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblLeave = new System.Windows.Forms.Label();
            this.tblpLeave = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddLeave = new System.Windows.Forms.Button();
            this.pnlFilters = new System.Windows.Forms.Panel();
            this.cmbxYear = new System.Windows.Forms.ComboBox();
            this.cmbxDepartment = new System.Windows.Forms.ComboBox();
            this.cmbxPosition = new System.Windows.Forms.ComboBox();
            this.cmbxMonth = new System.Windows.Forms.ComboBox();
            this.txtbxSearch = new System.Windows.Forms.TextBox();
            this.cmbxRegularContractual = new System.Windows.Forms.ComboBox();
            this.dtgvLeave = new System.Windows.Forms.DataGridView();
            this.tblpLeave.SuspendLayout();
            this.pnlFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLeave)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLeave
            // 
            this.lblLeave.AutoSize = true;
            this.lblLeave.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLeave.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblLeave.Location = new System.Drawing.Point(0, 0);
            this.lblLeave.Margin = new System.Windows.Forms.Padding(0);
            this.lblLeave.Name = "lblLeave";
            this.lblLeave.Size = new System.Drawing.Size(110, 38);
            this.lblLeave.TabIndex = 273;
            this.lblLeave.Text = "Leave";
            // 
            // tblpLeave
            // 
            this.tblpLeave.ColumnCount = 1;
            this.tblpLeave.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblpLeave.Controls.Add(this.btnAddLeave, 0, 2);
            this.tblpLeave.Controls.Add(this.pnlFilters, 0, 0);
            this.tblpLeave.Controls.Add(this.dtgvLeave, 0, 1);
            this.tblpLeave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblpLeave.Location = new System.Drawing.Point(0, 38);
            this.tblpLeave.Name = "tblpLeave";
            this.tblpLeave.RowCount = 3;
            this.tblpLeave.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.20206F));
            this.tblpLeave.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.79794F));
            this.tblpLeave.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tblpLeave.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblpLeave.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblpLeave.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblpLeave.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblpLeave.Size = new System.Drawing.Size(900, 462);
            this.tblpLeave.TabIndex = 274;
            // 
            // btnAddLeave
            // 
            this.btnAddLeave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddLeave.BackgroundImage")));
            this.btnAddLeave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddLeave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAddLeave.FlatAppearance.BorderSize = 0;
            this.btnAddLeave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAddLeave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddLeave.Location = new System.Drawing.Point(773, 428);
            this.btnAddLeave.Name = "btnAddLeave";
            this.btnAddLeave.Size = new System.Drawing.Size(124, 31);
            this.btnAddLeave.TabIndex = 276;
            this.btnAddLeave.TabStop = false;
            this.btnAddLeave.UseVisualStyleBackColor = true;
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
            this.pnlFilters.Size = new System.Drawing.Size(894, 84);
            this.pnlFilters.TabIndex = 274;
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
            // dtgvLeave
            // 
            this.dtgvLeave.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvLeave.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(5)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvLeave.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvLeave.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(5)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvLeave.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvLeave.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dtgvLeave.Location = new System.Drawing.Point(3, 93);
            this.dtgvLeave.Name = "dtgvLeave";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(5)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvLeave.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvLeave.Size = new System.Drawing.Size(894, 329);
            this.dtgvLeave.TabIndex = 275;
            // 
            // ucLeave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tblpLeave);
            this.Controls.Add(this.lblLeave);
            this.Name = "ucLeave";
            this.Size = new System.Drawing.Size(900, 500);
            this.tblpLeave.ResumeLayout(false);
            this.pnlFilters.ResumeLayout(false);
            this.pnlFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLeave)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLeave;
        private System.Windows.Forms.TableLayoutPanel tblpLeave;
        private System.Windows.Forms.Panel pnlFilters;
        private System.Windows.Forms.ComboBox cmbxYear;
        private System.Windows.Forms.ComboBox cmbxDepartment;
        private System.Windows.Forms.ComboBox cmbxPosition;
        private System.Windows.Forms.ComboBox cmbxMonth;
        private System.Windows.Forms.TextBox txtbxSearch;
        private System.Windows.Forms.ComboBox cmbxRegularContractual;
        private System.Windows.Forms.DataGridView dtgvLeave;
        private System.Windows.Forms.Button btnAddLeave;

    }
}
