namespace Fireon.UserControls
{
    partial class ucHoliday
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucHoliday));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAddHoliday = new System.Windows.Forms.Button();
            this.lblHoliday = new System.Windows.Forms.Label();
            this.dtgvHoliday = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHoliday)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddHoliday
            // 
            this.btnAddHoliday.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddHoliday.BackgroundImage")));
            this.btnAddHoliday.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddHoliday.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAddHoliday.FlatAppearance.BorderSize = 0;
            this.btnAddHoliday.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnAddHoliday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddHoliday.Location = new System.Drawing.Point(776, 38);
            this.btnAddHoliday.Name = "btnAddHoliday";
            this.btnAddHoliday.Size = new System.Drawing.Size(124, 424);
            this.btnAddHoliday.TabIndex = 283;
            this.btnAddHoliday.TabStop = false;
            this.btnAddHoliday.UseVisualStyleBackColor = true;
            this.btnAddHoliday.Click += new System.EventHandler(this.btnAddHoliday_Click);
            // 
            // lblHoliday
            // 
            this.lblHoliday.AutoSize = true;
            this.lblHoliday.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHoliday.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoliday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblHoliday.Location = new System.Drawing.Point(0, 0);
            this.lblHoliday.Margin = new System.Windows.Forms.Padding(0);
            this.lblHoliday.Name = "lblHoliday";
            this.lblHoliday.Size = new System.Drawing.Size(136, 38);
            this.lblHoliday.TabIndex = 282;
            this.lblHoliday.Text = "Holiday";
            // 
            // dtgvHoliday
            // 
            this.dtgvHoliday.AllowUserToAddRows = false;
            this.dtgvHoliday.AllowUserToDeleteRows = false;
            this.dtgvHoliday.AllowUserToResizeColumns = false;
            this.dtgvHoliday.AllowUserToResizeRows = false;
            this.dtgvHoliday.BackgroundColor = System.Drawing.Color.White;
            this.dtgvHoliday.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(5)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvHoliday.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvHoliday.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(5)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvHoliday.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvHoliday.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgvHoliday.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dtgvHoliday.Location = new System.Drawing.Point(16, 71);
            this.dtgvHoliday.MultiSelect = false;
            this.dtgvHoliday.Name = "dtgvHoliday";
            this.dtgvHoliday.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(5)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvHoliday.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvHoliday.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgvHoliday.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvHoliday.ShowEditingIcon = false;
            this.dtgvHoliday.Size = new System.Drawing.Size(458, 355);
            this.dtgvHoliday.TabIndex = 281;
            // 
            // ucHoliday
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAddHoliday);
            this.Controls.Add(this.lblHoliday);
            this.Controls.Add(this.dtgvHoliday);
            this.Name = "ucHoliday";
            this.Size = new System.Drawing.Size(900, 462);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHoliday)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddHoliday;
        private System.Windows.Forms.Label lblHoliday;
        private System.Windows.Forms.DataGridView dtgvHoliday;
    }
}
