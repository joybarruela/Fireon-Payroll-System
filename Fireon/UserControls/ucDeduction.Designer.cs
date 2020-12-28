namespace Fireon.UserControls
{
    partial class ucDeduction
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
            this.btnDeleteDeduction = new System.Windows.Forms.Button();
            this.btnAddDeduction = new System.Windows.Forms.Button();
            this.lblDeductionName = new System.Windows.Forms.Label();
            this.lbldeductionPercentage = new System.Windows.Forms.Label();
            this.txtbxDeductionName = new System.Windows.Forms.TextBox();
            this.txtbxdeductionPercentage = new System.Windows.Forms.TextBox();
            this.dtgvDeduction = new System.Windows.Forms.DataGridView();
            this.lblDeduction = new System.Windows.Forms.Label();
            this.tblpDeduction = new System.Windows.Forms.TableLayoutPanel();
            this.flpBelow = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlDeduction = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDeduction)).BeginInit();
            this.tblpDeduction.SuspendLayout();
            this.flpBelow.SuspendLayout();
            this.pnlDeduction.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDeleteDeduction
            // 
            this.btnDeleteDeduction.BackgroundImage = global::Fireon.Properties.Resources.btnDelete;
            this.btnDeleteDeduction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDeleteDeduction.FlatAppearance.BorderSize = 0;
            this.btnDeleteDeduction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteDeduction.Location = new System.Drawing.Point(631, 3);
            this.btnDeleteDeduction.Name = "btnDeleteDeduction";
            this.btnDeleteDeduction.Size = new System.Drawing.Size(127, 30);
            this.btnDeleteDeduction.TabIndex = 164;
            this.btnDeleteDeduction.UseVisualStyleBackColor = true;
            this.btnDeleteDeduction.Click += new System.EventHandler(this.btnDeleteDeduction_Click);
            // 
            // btnAddDeduction
            // 
            this.btnAddDeduction.BackgroundImage = global::Fireon.Properties.Resources.btnAdd;
            this.btnAddDeduction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddDeduction.FlatAppearance.BorderSize = 0;
            this.btnAddDeduction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDeduction.Location = new System.Drawing.Point(764, 3);
            this.btnAddDeduction.Name = "btnAddDeduction";
            this.btnAddDeduction.Size = new System.Drawing.Size(127, 30);
            this.btnAddDeduction.TabIndex = 165;
            this.btnAddDeduction.UseVisualStyleBackColor = true;
            this.btnAddDeduction.Click += new System.EventHandler(this.btnAddDeduction_Click);
            // 
            // lblDeductionName
            // 
            this.lblDeductionName.AutoSize = true;
            this.lblDeductionName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeductionName.Location = new System.Drawing.Point(2, 5);
            this.lblDeductionName.Name = "lblDeductionName";
            this.lblDeductionName.Size = new System.Drawing.Size(134, 20);
            this.lblDeductionName.TabIndex = 162;
            this.lblDeductionName.Text = "Deduction Name";
            // 
            // lbldeductionPercentage
            // 
            this.lbldeductionPercentage.AutoSize = true;
            this.lbldeductionPercentage.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldeductionPercentage.Location = new System.Drawing.Point(39, 34);
            this.lbldeductionPercentage.Name = "lbldeductionPercentage";
            this.lbldeductionPercentage.Size = new System.Drawing.Size(97, 20);
            this.lbldeductionPercentage.TabIndex = 163;
            this.lbldeductionPercentage.Text = "Percentage";
            // 
            // txtbxDeductionName
            // 
            this.txtbxDeductionName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxDeductionName.Location = new System.Drawing.Point(142, 2);
            this.txtbxDeductionName.MaxLength = 40;
            this.txtbxDeductionName.Name = "txtbxDeductionName";
            this.txtbxDeductionName.Size = new System.Drawing.Size(274, 26);
            this.txtbxDeductionName.TabIndex = 160;
            this.txtbxDeductionName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxDeductionName_KeyPress);
            this.txtbxDeductionName.Leave += new System.EventHandler(this.txtbxDeductionName_Leave);
            // 
            // txtbxdeductionPercentage
            // 
            this.txtbxdeductionPercentage.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxdeductionPercentage.Location = new System.Drawing.Point(142, 31);
            this.txtbxdeductionPercentage.MaxLength = 4;
            this.txtbxdeductionPercentage.Name = "txtbxdeductionPercentage";
            this.txtbxdeductionPercentage.Size = new System.Drawing.Size(130, 26);
            this.txtbxdeductionPercentage.TabIndex = 161;
            this.txtbxdeductionPercentage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxdeductionPercentage_KeyPress);
            // 
            // dtgvDeduction
            // 
            this.dtgvDeduction.AllowUserToAddRows = false;
            this.dtgvDeduction.AllowUserToDeleteRows = false;
            this.dtgvDeduction.AllowUserToResizeColumns = false;
            this.dtgvDeduction.AllowUserToResizeRows = false;
            this.dtgvDeduction.BackgroundColor = System.Drawing.Color.White;
            this.dtgvDeduction.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dtgvDeduction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvDeduction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvDeduction.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgvDeduction.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dtgvDeduction.Location = new System.Drawing.Point(3, 75);
            this.dtgvDeduction.MultiSelect = false;
            this.dtgvDeduction.Name = "dtgvDeduction";
            this.dtgvDeduction.ReadOnly = true;
            this.dtgvDeduction.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgvDeduction.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvDeduction.ShowEditingIcon = false;
            this.dtgvDeduction.Size = new System.Drawing.Size(894, 295);
            this.dtgvDeduction.TabIndex = 159;
            // 
            // lblDeduction
            // 
            this.lblDeduction.AutoSize = true;
            this.lblDeduction.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDeduction.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeduction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDeduction.Location = new System.Drawing.Point(0, 0);
            this.lblDeduction.Margin = new System.Windows.Forms.Padding(0);
            this.lblDeduction.Name = "lblDeduction";
            this.lblDeduction.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lblDeduction.Size = new System.Drawing.Size(176, 48);
            this.lblDeduction.TabIndex = 158;
            this.lblDeduction.Text = "Deduction";
            // 
            // tblpDeduction
            // 
            this.tblpDeduction.ColumnCount = 1;
            this.tblpDeduction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblpDeduction.Controls.Add(this.flpBelow, 0, 2);
            this.tblpDeduction.Controls.Add(this.pnlDeduction, 0, 1);
            this.tblpDeduction.Controls.Add(this.dtgvDeduction, 0, 2);
            this.tblpDeduction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblpDeduction.Location = new System.Drawing.Point(0, 48);
            this.tblpDeduction.Name = "tblpDeduction";
            this.tblpDeduction.RowCount = 4;
            this.tblpDeduction.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.886792F));
            this.tblpDeduction.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.83924F));
            this.tblpDeduction.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.04964F));
            this.tblpDeduction.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.456264F));
            this.tblpDeduction.Size = new System.Drawing.Size(900, 414);
            this.tblpDeduction.TabIndex = 284;
            // 
            // flpBelow
            // 
            this.flpBelow.Controls.Add(this.btnAddDeduction);
            this.flpBelow.Controls.Add(this.btnDeleteDeduction);
            this.flpBelow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpBelow.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpBelow.Location = new System.Drawing.Point(3, 376);
            this.flpBelow.Name = "flpBelow";
            this.flpBelow.Size = new System.Drawing.Size(894, 35);
            this.flpBelow.TabIndex = 282;
            // 
            // pnlDeduction
            // 
            this.pnlDeduction.Controls.Add(this.txtbxdeductionPercentage);
            this.pnlDeduction.Controls.Add(this.txtbxDeductionName);
            this.pnlDeduction.Controls.Add(this.lbldeductionPercentage);
            this.pnlDeduction.Controls.Add(this.lblDeductionName);
            this.pnlDeduction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDeduction.Location = new System.Drawing.Point(3, 10);
            this.pnlDeduction.Name = "pnlDeduction";
            this.pnlDeduction.Size = new System.Drawing.Size(894, 59);
            this.pnlDeduction.TabIndex = 281;
            // 
            // ucDeduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tblpDeduction);
            this.Controls.Add(this.lblDeduction);
            this.Name = "ucDeduction";
            this.Size = new System.Drawing.Size(900, 462);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDeduction)).EndInit();
            this.tblpDeduction.ResumeLayout(false);
            this.flpBelow.ResumeLayout(false);
            this.pnlDeduction.ResumeLayout(false);
            this.pnlDeduction.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteDeduction;
        private System.Windows.Forms.Button btnAddDeduction;
        private System.Windows.Forms.Label lblDeductionName;
        private System.Windows.Forms.Label lbldeductionPercentage;
        private System.Windows.Forms.TextBox txtbxDeductionName;
        private System.Windows.Forms.TextBox txtbxdeductionPercentage;
        private System.Windows.Forms.DataGridView dtgvDeduction;
        private System.Windows.Forms.Label lblDeduction;
        private System.Windows.Forms.TableLayoutPanel tblpDeduction;
        private System.Windows.Forms.Panel pnlDeduction;
        private System.Windows.Forms.FlowLayoutPanel flpBelow;
    }
}
