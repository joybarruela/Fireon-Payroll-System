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
            this.btnAddAllowance = new System.Windows.Forms.Button();
            this.lblAllowanceName = new System.Windows.Forms.Label();
            this.lblAllowanceAmount = new System.Windows.Forms.Label();
            this.txtbxAllowanceName = new System.Windows.Forms.TextBox();
            this.txtbxAllowanceAmount = new System.Windows.Forms.TextBox();
            this.dtgvAllowance = new System.Windows.Forms.DataGridView();
            this.lblAllowance = new System.Windows.Forms.Label();
            this.btnDeleteAllowance = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAllowance)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddAllowance
            // 
            this.btnAddAllowance.Location = new System.Drawing.Point(396, 272);
            this.btnAddAllowance.Name = "btnAddAllowance";
            this.btnAddAllowance.Size = new System.Drawing.Size(75, 23);
            this.btnAddAllowance.TabIndex = 157;
            this.btnAddAllowance.Text = "ADD";
            this.btnAddAllowance.UseVisualStyleBackColor = true;
            this.btnAddAllowance.Click += new System.EventHandler(this.btnAddAllowance_Click);
            // 
            // lblAllowanceName
            // 
            this.lblAllowanceName.AutoSize = true;
            this.lblAllowanceName.Location = new System.Drawing.Point(14, 69);
            this.lblAllowanceName.Name = "lblAllowanceName";
            this.lblAllowanceName.Size = new System.Drawing.Size(87, 13);
            this.lblAllowanceName.TabIndex = 152;
            this.lblAllowanceName.Text = "Allowance Name";
            // 
            // lblAllowanceAmount
            // 
            this.lblAllowanceAmount.AutoSize = true;
            this.lblAllowanceAmount.Location = new System.Drawing.Point(15, 95);
            this.lblAllowanceAmount.Name = "lblAllowanceAmount";
            this.lblAllowanceAmount.Size = new System.Drawing.Size(43, 13);
            this.lblAllowanceAmount.TabIndex = 153;
            this.lblAllowanceAmount.Text = "Amount";
            // 
            // txtbxAllowanceName
            // 
            this.txtbxAllowanceName.Location = new System.Drawing.Point(107, 62);
            this.txtbxAllowanceName.MaxLength = 40;
            this.txtbxAllowanceName.Name = "txtbxAllowanceName";
            this.txtbxAllowanceName.Size = new System.Drawing.Size(274, 20);
            this.txtbxAllowanceName.TabIndex = 148;
            this.txtbxAllowanceName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxAllowanceName_KeyPress);
            this.txtbxAllowanceName.Leave += new System.EventHandler(this.txtbxAllowanceName_Leave);
            // 
            // txtbxAllowanceAmount
            // 
            this.txtbxAllowanceAmount.Location = new System.Drawing.Point(107, 88);
            this.txtbxAllowanceAmount.MaxLength = 4;
            this.txtbxAllowanceAmount.Name = "txtbxAllowanceAmount";
            this.txtbxAllowanceAmount.Size = new System.Drawing.Size(76, 20);
            this.txtbxAllowanceAmount.TabIndex = 149;
            this.txtbxAllowanceAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxAllowanceAmount_KeyPress);
            // 
            // dtgvAllowance
            // 
            this.dtgvAllowance.AllowUserToAddRows = false;
            this.dtgvAllowance.AllowUserToDeleteRows = false;
            this.dtgvAllowance.AllowUserToResizeColumns = false;
            this.dtgvAllowance.AllowUserToResizeRows = false;
            this.dtgvAllowance.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dtgvAllowance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvAllowance.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgvAllowance.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dtgvAllowance.Location = new System.Drawing.Point(13, 124);
            this.dtgvAllowance.MultiSelect = false;
            this.dtgvAllowance.Name = "dtgvAllowance";
            this.dtgvAllowance.ReadOnly = true;
            this.dtgvAllowance.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgvAllowance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvAllowance.ShowEditingIcon = false;
            this.dtgvAllowance.Size = new System.Drawing.Size(458, 121);
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
            this.btnDeleteAllowance.Location = new System.Drawing.Point(315, 272);
            this.btnDeleteAllowance.Name = "btnDeleteAllowance";
            this.btnDeleteAllowance.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteAllowance.TabIndex = 156;
            this.btnDeleteAllowance.Text = "DELETE";
            this.btnDeleteAllowance.UseVisualStyleBackColor = true;
            this.btnDeleteAllowance.Click += new System.EventHandler(this.btnDeleteAllowance_Click);
            // 
            // ucAllowance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDeleteAllowance);
            this.Controls.Add(this.btnAddAllowance);
            this.Controls.Add(this.lblAllowanceName);
            this.Controls.Add(this.lblAllowanceAmount);
            this.Controls.Add(this.txtbxAllowanceName);
            this.Controls.Add(this.txtbxAllowanceAmount);
            this.Controls.Add(this.dtgvAllowance);
            this.Controls.Add(this.lblAllowance);
            this.Name = "ucAllowance";
            this.Size = new System.Drawing.Size(900, 462);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAllowance)).EndInit();
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
    }
}
