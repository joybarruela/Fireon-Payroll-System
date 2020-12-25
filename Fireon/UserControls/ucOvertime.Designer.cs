namespace Fireon.UserControls
{
    partial class ucOvertime
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucOvertime));
            this.dtgvOvertime = new System.Windows.Forms.DataGridView();
            this.lblAddWorkingHours = new System.Windows.Forms.Label();
            this.lblOvertime = new System.Windows.Forms.Label();
            this.txtbxAddWorkingHours = new System.Windows.Forms.TextBox();
            this.btnAddOvertime = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvOvertime)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvOvertime
            // 
            this.dtgvOvertime.AllowUserToAddRows = false;
            this.dtgvOvertime.AllowUserToDeleteRows = false;
            this.dtgvOvertime.AllowUserToResizeColumns = false;
            this.dtgvOvertime.AllowUserToResizeRows = false;
            this.dtgvOvertime.BackgroundColor = System.Drawing.Color.White;
            this.dtgvOvertime.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(5)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvOvertime.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvOvertime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(5)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvOvertime.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvOvertime.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgvOvertime.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dtgvOvertime.Location = new System.Drawing.Point(16, 71);
            this.dtgvOvertime.MultiSelect = false;
            this.dtgvOvertime.Name = "dtgvOvertime";
            this.dtgvOvertime.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(5)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvOvertime.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvOvertime.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgvOvertime.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvOvertime.ShowEditingIcon = false;
            this.dtgvOvertime.Size = new System.Drawing.Size(458, 355);
            this.dtgvOvertime.TabIndex = 276;
            // 
            // lblAddWorkingHours
            // 
            this.lblAddWorkingHours.AutoSize = true;
            this.lblAddWorkingHours.Location = new System.Drawing.Point(497, 130);
            this.lblAddWorkingHours.Name = "lblAddWorkingHours";
            this.lblAddWorkingHours.Size = new System.Drawing.Size(100, 13);
            this.lblAddWorkingHours.TabIndex = 277;
            this.lblAddWorkingHours.Text = "Add Working Hours";
            // 
            // lblOvertime
            // 
            this.lblOvertime.AutoSize = true;
            this.lblOvertime.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblOvertime.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOvertime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblOvertime.Location = new System.Drawing.Point(0, 0);
            this.lblOvertime.Margin = new System.Windows.Forms.Padding(0);
            this.lblOvertime.Name = "lblOvertime";
            this.lblOvertime.Size = new System.Drawing.Size(160, 38);
            this.lblOvertime.TabIndex = 278;
            this.lblOvertime.Text = "Overtime";
            // 
            // txtbxAddWorkingHours
            // 
            this.txtbxAddWorkingHours.Location = new System.Drawing.Point(500, 158);
            this.txtbxAddWorkingHours.MaxLength = 3;
            this.txtbxAddWorkingHours.Name = "txtbxAddWorkingHours";
            this.txtbxAddWorkingHours.Size = new System.Drawing.Size(51, 20);
            this.txtbxAddWorkingHours.TabIndex = 279;
            this.txtbxAddWorkingHours.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxAddWorkingHours_KeyPress);
            // 
            // btnAddOvertime
            // 
            this.btnAddOvertime.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddOvertime.BackgroundImage")));
            this.btnAddOvertime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddOvertime.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAddOvertime.FlatAppearance.BorderSize = 0;
            this.btnAddOvertime.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnAddOvertime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddOvertime.Location = new System.Drawing.Point(776, 38);
            this.btnAddOvertime.Name = "btnAddOvertime";
            this.btnAddOvertime.Size = new System.Drawing.Size(124, 424);
            this.btnAddOvertime.TabIndex = 280;
            this.btnAddOvertime.TabStop = false;
            this.btnAddOvertime.UseVisualStyleBackColor = true;
            this.btnAddOvertime.Click += new System.EventHandler(this.btnAddOvertime_Click);
            // 
            // ucOvertime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAddOvertime);
            this.Controls.Add(this.txtbxAddWorkingHours);
            this.Controls.Add(this.lblOvertime);
            this.Controls.Add(this.lblAddWorkingHours);
            this.Controls.Add(this.dtgvOvertime);
            this.Name = "ucOvertime";
            this.Size = new System.Drawing.Size(900, 462);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvOvertime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvOvertime;
        private System.Windows.Forms.Label lblAddWorkingHours;
        private System.Windows.Forms.Label lblOvertime;
        private System.Windows.Forms.TextBox txtbxAddWorkingHours;
        private System.Windows.Forms.Button btnAddOvertime;
    }
}
