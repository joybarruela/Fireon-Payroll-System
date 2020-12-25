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
            this.lblDeductionAmount = new System.Windows.Forms.Label();
            this.txtbxDeductionName = new System.Windows.Forms.TextBox();
            this.txtbxDeductionAmount = new System.Windows.Forms.TextBox();
            this.dtgvDeduction = new System.Windows.Forms.DataGridView();
            this.lblDeduction = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDeduction)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleteDeduction
            // 
            this.btnDeleteDeduction.Location = new System.Drawing.Point(314, 281);
            this.btnDeleteDeduction.Name = "btnDeleteDeduction";
            this.btnDeleteDeduction.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteDeduction.TabIndex = 164;
            this.btnDeleteDeduction.Text = "DELETE";
            this.btnDeleteDeduction.UseVisualStyleBackColor = true;
            this.btnDeleteDeduction.Click += new System.EventHandler(this.btnDeleteDeduction_Click);
            // 
            // btnAddDeduction
            // 
            this.btnAddDeduction.Location = new System.Drawing.Point(395, 281);
            this.btnAddDeduction.Name = "btnAddDeduction";
            this.btnAddDeduction.Size = new System.Drawing.Size(75, 23);
            this.btnAddDeduction.TabIndex = 165;
            this.btnAddDeduction.Text = "ADD";
            this.btnAddDeduction.UseVisualStyleBackColor = true;
            this.btnAddDeduction.Click += new System.EventHandler(this.btnAddDeduction_Click);
            // 
            // lblDeductionName
            // 
            this.lblDeductionName.AutoSize = true;
            this.lblDeductionName.Location = new System.Drawing.Point(13, 78);
            this.lblDeductionName.Name = "lblDeductionName";
            this.lblDeductionName.Size = new System.Drawing.Size(87, 13);
            this.lblDeductionName.TabIndex = 162;
            this.lblDeductionName.Text = "Deduction Name";
            // 
            // lblDeductionAmount
            // 
            this.lblDeductionAmount.AutoSize = true;
            this.lblDeductionAmount.Location = new System.Drawing.Point(14, 104);
            this.lblDeductionAmount.Name = "lblDeductionAmount";
            this.lblDeductionAmount.Size = new System.Drawing.Size(43, 13);
            this.lblDeductionAmount.TabIndex = 163;
            this.lblDeductionAmount.Text = "Amount";
            // 
            // txtbxDeductionName
            // 
            this.txtbxDeductionName.Location = new System.Drawing.Point(106, 71);
            this.txtbxDeductionName.MaxLength = 40;
            this.txtbxDeductionName.Name = "txtbxDeductionName";
            this.txtbxDeductionName.Size = new System.Drawing.Size(274, 20);
            this.txtbxDeductionName.TabIndex = 160;
            this.txtbxDeductionName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxDeductionName_KeyPress);
            this.txtbxDeductionName.Leave += new System.EventHandler(this.txtbxDeductionName_Leave);
            // 
            // txtbxDeductionAmount
            // 
            this.txtbxDeductionAmount.Location = new System.Drawing.Point(106, 97);
            this.txtbxDeductionAmount.MaxLength = 4;
            this.txtbxDeductionAmount.Name = "txtbxDeductionAmount";
            this.txtbxDeductionAmount.Size = new System.Drawing.Size(76, 20);
            this.txtbxDeductionAmount.TabIndex = 161;
            this.txtbxDeductionAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxDeductionAmount_KeyPress);
            // 
            // dtgvDeduction
            // 
            this.dtgvDeduction.AllowUserToAddRows = false;
            this.dtgvDeduction.AllowUserToDeleteRows = false;
            this.dtgvDeduction.AllowUserToResizeColumns = false;
            this.dtgvDeduction.AllowUserToResizeRows = false;
            this.dtgvDeduction.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dtgvDeduction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvDeduction.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgvDeduction.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dtgvDeduction.Location = new System.Drawing.Point(12, 133);
            this.dtgvDeduction.MultiSelect = false;
            this.dtgvDeduction.Name = "dtgvDeduction";
            this.dtgvDeduction.ReadOnly = true;
            this.dtgvDeduction.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgvDeduction.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvDeduction.ShowEditingIcon = false;
            this.dtgvDeduction.Size = new System.Drawing.Size(458, 121);
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
            // ucDeduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDeleteDeduction);
            this.Controls.Add(this.btnAddDeduction);
            this.Controls.Add(this.lblDeductionName);
            this.Controls.Add(this.lblDeductionAmount);
            this.Controls.Add(this.txtbxDeductionName);
            this.Controls.Add(this.txtbxDeductionAmount);
            this.Controls.Add(this.dtgvDeduction);
            this.Controls.Add(this.lblDeduction);
            this.Name = "ucDeduction";
            this.Size = new System.Drawing.Size(900, 462);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDeduction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteDeduction;
        private System.Windows.Forms.Button btnAddDeduction;
        private System.Windows.Forms.Label lblDeductionName;
        private System.Windows.Forms.Label lblDeductionAmount;
        private System.Windows.Forms.TextBox txtbxDeductionName;
        private System.Windows.Forms.TextBox txtbxDeductionAmount;
        private System.Windows.Forms.DataGridView dtgvDeduction;
        private System.Windows.Forms.Label lblDeduction;
    }
}
