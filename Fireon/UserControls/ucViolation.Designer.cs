namespace Fireon.UserControls
{
    partial class ucViolation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucViolation));
            this.txtbxAddViolationCost = new System.Windows.Forms.TextBox();
            this.lblViolation = new System.Windows.Forms.Label();
            this.lblAddViolationCost = new System.Windows.Forms.Label();
            this.dtgvViolation = new System.Windows.Forms.DataGridView();
            this.btnAddViolation = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvViolation)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbxAddViolationCost
            // 
            this.txtbxAddViolationCost.Location = new System.Drawing.Point(471, 103);
            this.txtbxAddViolationCost.MaxLength = 3;
            this.txtbxAddViolationCost.Name = "txtbxAddViolationCost";
            this.txtbxAddViolationCost.Size = new System.Drawing.Size(51, 20);
            this.txtbxAddViolationCost.TabIndex = 283;
            this.txtbxAddViolationCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxAddViolationCost_KeyPress);
            // 
            // lblViolation
            // 
            this.lblViolation.AutoSize = true;
            this.lblViolation.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblViolation.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViolation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblViolation.Location = new System.Drawing.Point(0, 0);
            this.lblViolation.Margin = new System.Windows.Forms.Padding(0);
            this.lblViolation.Name = "lblViolation";
            this.lblViolation.Size = new System.Drawing.Size(153, 38);
            this.lblViolation.TabIndex = 282;
            this.lblViolation.Text = "Violation";
            // 
            // lblAddViolationCost
            // 
            this.lblAddViolationCost.AutoSize = true;
            this.lblAddViolationCost.Location = new System.Drawing.Point(468, 75);
            this.lblAddViolationCost.Name = "lblAddViolationCost";
            this.lblAddViolationCost.Size = new System.Drawing.Size(93, 13);
            this.lblAddViolationCost.TabIndex = 281;
            this.lblAddViolationCost.Text = "Add Violation Cost";
            // 
            // dtgvViolation
            // 
            this.dtgvViolation.AllowUserToAddRows = false;
            this.dtgvViolation.AllowUserToDeleteRows = false;
            this.dtgvViolation.AllowUserToResizeColumns = false;
            this.dtgvViolation.AllowUserToResizeRows = false;
            this.dtgvViolation.BackgroundColor = System.Drawing.Color.White;
            this.dtgvViolation.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(5)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvViolation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvViolation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(5)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvViolation.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvViolation.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgvViolation.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dtgvViolation.Location = new System.Drawing.Point(7, 58);
            this.dtgvViolation.MultiSelect = false;
            this.dtgvViolation.Name = "dtgvViolation";
            this.dtgvViolation.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(5)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvViolation.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvViolation.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgvViolation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvViolation.ShowEditingIcon = false;
            this.dtgvViolation.Size = new System.Drawing.Size(458, 355);
            this.dtgvViolation.TabIndex = 280;
            // 
            // btnAddViolation
            // 
            this.btnAddViolation.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddViolation.BackgroundImage")));
            this.btnAddViolation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddViolation.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAddViolation.FlatAppearance.BorderSize = 0;
            this.btnAddViolation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnAddViolation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddViolation.Location = new System.Drawing.Point(776, 38);
            this.btnAddViolation.Name = "btnAddViolation";
            this.btnAddViolation.Size = new System.Drawing.Size(124, 424);
            this.btnAddViolation.TabIndex = 284;
            this.btnAddViolation.TabStop = false;
            this.btnAddViolation.UseVisualStyleBackColor = true;
            this.btnAddViolation.Click += new System.EventHandler(this.btnAddViolation_Click);
            // 
            // ucViolation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAddViolation);
            this.Controls.Add(this.txtbxAddViolationCost);
            this.Controls.Add(this.lblViolation);
            this.Controls.Add(this.lblAddViolationCost);
            this.Controls.Add(this.dtgvViolation);
            this.Name = "ucViolation";
            this.Size = new System.Drawing.Size(900, 462);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvViolation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbxAddViolationCost;
        private System.Windows.Forms.Label lblViolation;
        private System.Windows.Forms.Label lblAddViolationCost;
        private System.Windows.Forms.DataGridView dtgvViolation;
        private System.Windows.Forms.Button btnAddViolation;
    }
}
