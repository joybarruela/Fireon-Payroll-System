namespace Fireon.UserControls
{
    partial class ucPrint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucPrint));
            this.pnlPrint = new System.Windows.Forms.Panel();
            this.cmbxYear = new System.Windows.Forms.ComboBox();
            this.cmbxMonth = new System.Windows.Forms.ComboBox();
            this.cmbxPosition = new System.Windows.Forms.ComboBox();
            this.cmbxDepartment = new System.Windows.Forms.ComboBox();
            this.cmbxEmployeeStatus = new System.Windows.Forms.ComboBox();
            this.txtbxSearch = new System.Windows.Forms.TextBox();
            this.lblPrint = new System.Windows.Forms.Label();
            this.pnlFilters = new System.Windows.Forms.Panel();
            this.tblpPrint = new System.Windows.Forms.TableLayoutPanel();
            this.pnlBelow = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pnlSeparator1 = new System.Windows.Forms.Panel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.pnlFilters.SuspendLayout();
            this.tblpPrint.SuspendLayout();
            this.pnlBelow.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPrint
            // 
            this.pnlPrint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrint.Location = new System.Drawing.Point(3, 88);
            this.pnlPrint.Name = "pnlPrint";
            this.pnlPrint.Size = new System.Drawing.Size(894, 315);
            this.pnlPrint.TabIndex = 1;
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
            // lblPrint
            // 
            this.lblPrint.AutoSize = true;
            this.lblPrint.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPrint.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPrint.Location = new System.Drawing.Point(0, 0);
            this.lblPrint.Margin = new System.Windows.Forms.Padding(0);
            this.lblPrint.Name = "lblPrint";
            this.lblPrint.Size = new System.Drawing.Size(82, 38);
            this.lblPrint.TabIndex = 2;
            this.lblPrint.Text = "Print";
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
            // tblpPrint
            // 
            this.tblpPrint.ColumnCount = 1;
            this.tblpPrint.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblpPrint.Controls.Add(this.pnlFilters, 0, 0);
            this.tblpPrint.Controls.Add(this.pnlBelow, 0, 2);
            this.tblpPrint.Controls.Add(this.pnlPrint, 0, 1);
            this.tblpPrint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblpPrint.Location = new System.Drawing.Point(0, 38);
            this.tblpPrint.Name = "tblpPrint";
            this.tblpPrint.RowCount = 4;
            this.tblpPrint.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblpPrint.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblpPrint.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tblpPrint.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblpPrint.Size = new System.Drawing.Size(900, 462);
            this.tblpPrint.TabIndex = 3;
            // 
            // pnlBelow
            // 
            this.pnlBelow.Controls.Add(this.btnSearch);
            this.pnlBelow.Controls.Add(this.pnlSeparator1);
            this.pnlBelow.Controls.Add(this.btnPrint);
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
            this.btnSearch.Location = new System.Drawing.Point(631, 0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(124, 30);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.TabStop = false;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pnlSeparator1
            // 
            this.pnlSeparator1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlSeparator1.Location = new System.Drawing.Point(755, 0);
            this.pnlSeparator1.Name = "pnlSeparator1";
            this.pnlSeparator1.Size = new System.Drawing.Size(15, 30);
            this.pnlSeparator1.TabIndex = 3;
            // 
            // btnPrint
            // 
            this.btnPrint.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrint.BackgroundImage")));
            this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPrint.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Location = new System.Drawing.Point(770, 0);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(124, 30);
            this.btnPrint.TabIndex = 4;
            this.btnPrint.TabStop = false;
            this.btnPrint.Text = "PRINT";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // ucPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tblpPrint);
            this.Controls.Add(this.lblPrint);
            this.Name = "ucPrint";
            this.Size = new System.Drawing.Size(900, 500);
            this.Load += new System.EventHandler(this.ucPrint_Load);
            this.pnlFilters.ResumeLayout(false);
            this.pnlFilters.PerformLayout();
            this.tblpPrint.ResumeLayout(false);
            this.pnlBelow.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlPrint;
        private System.Windows.Forms.ComboBox cmbxYear;
        private System.Windows.Forms.ComboBox cmbxMonth;
        private System.Windows.Forms.ComboBox cmbxPosition;
        private System.Windows.Forms.ComboBox cmbxDepartment;
        private System.Windows.Forms.ComboBox cmbxEmployeeStatus;
        public System.Windows.Forms.TextBox txtbxSearch;
        private System.Windows.Forms.Label lblPrint;
        private System.Windows.Forms.Panel pnlFilters;
        private System.Windows.Forms.TableLayoutPanel tblpPrint;
        private System.Windows.Forms.Panel pnlBelow;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel pnlSeparator1;
        private System.Windows.Forms.Button btnPrint;

    }
}
