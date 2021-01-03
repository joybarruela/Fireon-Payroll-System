namespace Fireon.UserControls
{
    partial class ucAllowance
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
            this.btnAddAllowance = new System.Windows.Forms.Button();
            this.lblAllowanceName = new System.Windows.Forms.Label();
            this.lblAllowanceAmount = new System.Windows.Forms.Label();
            this.txtbxAllowanceName = new System.Windows.Forms.TextBox();
            this.txtbxAllowanceAmount = new System.Windows.Forms.TextBox();
            this.dtgvAllowance = new System.Windows.Forms.DataGridView();
            this.lblAllowance = new System.Windows.Forms.Label();
            this.btnDeleteAllowance = new System.Windows.Forms.Button();
            this.tblpAllowance = new System.Windows.Forms.TableLayoutPanel();
            this.flpBelow = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlAllowance = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAllowance)).BeginInit();
            this.tblpAllowance.SuspendLayout();
            this.flpBelow.SuspendLayout();
            this.pnlAllowance.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddAllowance
            // 
            this.btnAddAllowance.BackgroundImage = global::Fireon.Properties.Resources.btnAdd;
            this.btnAddAllowance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddAllowance.FlatAppearance.BorderSize = 0;
            this.btnAddAllowance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAllowance.Location = new System.Drawing.Point(764, 3);
            this.btnAddAllowance.Name = "btnAddAllowance";
            this.btnAddAllowance.Size = new System.Drawing.Size(127, 30);
            this.btnAddAllowance.TabIndex = 157;
            this.btnAddAllowance.UseVisualStyleBackColor = true;
            this.btnAddAllowance.Click += new System.EventHandler(this.btnAddAllowance_Click);
            // 
            // lblAllowanceName
            // 
            this.lblAllowanceName.AutoSize = true;
            this.lblAllowanceName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllowanceName.Location = new System.Drawing.Point(3, 6);
            this.lblAllowanceName.Name = "lblAllowanceName";
            this.lblAllowanceName.Size = new System.Drawing.Size(137, 20);
            this.lblAllowanceName.TabIndex = 152;
            this.lblAllowanceName.Text = "Allowance Name";
            // 
            // lblAllowanceAmount
            // 
            this.lblAllowanceAmount.AutoSize = true;
            this.lblAllowanceAmount.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllowanceAmount.Location = new System.Drawing.Point(74, 36);
            this.lblAllowanceAmount.Name = "lblAllowanceAmount";
            this.lblAllowanceAmount.Size = new System.Drawing.Size(66, 20);
            this.lblAllowanceAmount.TabIndex = 153;
            this.lblAllowanceAmount.Text = "Amount";
            // 
            // txtbxAllowanceName
            // 
            this.txtbxAllowanceName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxAllowanceName.Location = new System.Drawing.Point(146, 3);
            this.txtbxAllowanceName.MaxLength = 40;
            this.txtbxAllowanceName.Name = "txtbxAllowanceName";
            this.txtbxAllowanceName.Size = new System.Drawing.Size(274, 26);
            this.txtbxAllowanceName.TabIndex = 148;
            this.txtbxAllowanceName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxAllowanceName_KeyPress);
            this.txtbxAllowanceName.Leave += new System.EventHandler(this.txtbxAllowanceName_Leave);
            // 
            // txtbxAllowanceAmount
            // 
            this.txtbxAllowanceAmount.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxAllowanceAmount.Location = new System.Drawing.Point(146, 33);
            this.txtbxAllowanceAmount.MaxLength = 4;
            this.txtbxAllowanceAmount.Name = "txtbxAllowanceAmount";
            this.txtbxAllowanceAmount.Size = new System.Drawing.Size(102, 26);
            this.txtbxAllowanceAmount.TabIndex = 149;
            this.txtbxAllowanceAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxAllowanceAmount_KeyPress);
            // 
            // dtgvAllowance
            // 
            this.dtgvAllowance.AllowUserToAddRows = false;
            this.dtgvAllowance.AllowUserToDeleteRows = false;
            this.dtgvAllowance.AllowUserToResizeColumns = false;
            this.dtgvAllowance.AllowUserToResizeRows = false;
            this.dtgvAllowance.BackgroundColor = System.Drawing.Color.White;
            this.dtgvAllowance.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvAllowance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvAllowance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvAllowance.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvAllowance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvAllowance.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgvAllowance.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dtgvAllowance.Location = new System.Drawing.Point(3, 80);
            this.dtgvAllowance.MultiSelect = false;
            this.dtgvAllowance.Name = "dtgvAllowance";
            this.dtgvAllowance.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvAllowance.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvAllowance.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgvAllowance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvAllowance.ShowEditingIcon = false;
            this.dtgvAllowance.Size = new System.Drawing.Size(894, 325);
            this.dtgvAllowance.TabIndex = 147;
            // 
            // lblAllowance
            // 
            this.lblAllowance.AutoSize = true;
            this.lblAllowance.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAllowance.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllowance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblAllowance.Location = new System.Drawing.Point(0, 0);
            this.lblAllowance.Margin = new System.Windows.Forms.Padding(0);
            this.lblAllowance.Name = "lblAllowance";
            this.lblAllowance.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lblAllowance.Size = new System.Drawing.Size(183, 48);
            this.lblAllowance.TabIndex = 146;
            this.lblAllowance.Text = "Allowance";
            // 
            // btnDeleteAllowance
            // 
            this.btnDeleteAllowance.BackgroundImage = global::Fireon.Properties.Resources.btnDelete;
            this.btnDeleteAllowance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDeleteAllowance.FlatAppearance.BorderSize = 0;
            this.btnDeleteAllowance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteAllowance.Location = new System.Drawing.Point(631, 3);
            this.btnDeleteAllowance.Name = "btnDeleteAllowance";
            this.btnDeleteAllowance.Size = new System.Drawing.Size(127, 30);
            this.btnDeleteAllowance.TabIndex = 156;
            this.btnDeleteAllowance.UseVisualStyleBackColor = true;
            this.btnDeleteAllowance.Click += new System.EventHandler(this.btnDeleteAllowance_Click);
            // 
            // tblpAllowance
            // 
            this.tblpAllowance.ColumnCount = 1;
            this.tblpAllowance.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblpAllowance.Controls.Add(this.dtgvAllowance, 0, 2);
            this.tblpAllowance.Controls.Add(this.flpBelow, 0, 3);
            this.tblpAllowance.Controls.Add(this.pnlAllowance, 0, 1);
            this.tblpAllowance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblpAllowance.Location = new System.Drawing.Point(0, 48);
            this.tblpAllowance.Name = "tblpAllowance";
            this.tblpAllowance.RowCount = 4;
            this.tblpAllowance.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.886792F));
            this.tblpAllowance.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.26549F));
            this.tblpAllowance.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.23009F));
            this.tblpAllowance.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.456264F));
            this.tblpAllowance.Size = new System.Drawing.Size(900, 452);
            this.tblpAllowance.TabIndex = 285;
            // 
            // flpBelow
            // 
            this.flpBelow.Controls.Add(this.btnAddAllowance);
            this.flpBelow.Controls.Add(this.btnDeleteAllowance);
            this.flpBelow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpBelow.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpBelow.Location = new System.Drawing.Point(3, 411);
            this.flpBelow.Name = "flpBelow";
            this.flpBelow.Size = new System.Drawing.Size(894, 38);
            this.flpBelow.TabIndex = 282;
            // 
            // pnlAllowance
            // 
            this.pnlAllowance.Controls.Add(this.txtbxAllowanceName);
            this.pnlAllowance.Controls.Add(this.txtbxAllowanceAmount);
            this.pnlAllowance.Controls.Add(this.lblAllowanceAmount);
            this.pnlAllowance.Controls.Add(this.lblAllowanceName);
            this.pnlAllowance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAllowance.Location = new System.Drawing.Point(3, 11);
            this.pnlAllowance.Name = "pnlAllowance";
            this.pnlAllowance.Size = new System.Drawing.Size(894, 63);
            this.pnlAllowance.TabIndex = 281;
            // 
            // ucAllowance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tblpAllowance);
            this.Controls.Add(this.lblAllowance);
            this.Name = "ucAllowance";
            this.Size = new System.Drawing.Size(900, 500);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAllowance)).EndInit();
            this.tblpAllowance.ResumeLayout(false);
            this.flpBelow.ResumeLayout(false);
            this.pnlAllowance.ResumeLayout(false);
            this.pnlAllowance.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddAllowance;
        private System.Windows.Forms.Label lblAllowanceName;
        private System.Windows.Forms.Label lblAllowanceAmount;
        private System.Windows.Forms.TextBox txtbxAllowanceName;
        private System.Windows.Forms.TextBox txtbxAllowanceAmount;
        private System.Windows.Forms.DataGridView dtgvAllowance;
        private System.Windows.Forms.Label lblAllowance;
        private System.Windows.Forms.Button btnDeleteAllowance;
        private System.Windows.Forms.TableLayoutPanel tblpAllowance;
        private System.Windows.Forms.FlowLayoutPanel flpBelow;
        private System.Windows.Forms.Panel pnlAllowance;
    }
}
