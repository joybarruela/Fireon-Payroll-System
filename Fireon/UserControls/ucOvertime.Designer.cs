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
            this.tblpOvertime = new System.Windows.Forms.TableLayoutPanel();
            this.pnlWorkingHours = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvOvertime)).BeginInit();
            this.tblpOvertime.SuspendLayout();
            this.pnlWorkingHours.SuspendLayout();
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
            this.dtgvOvertime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvOvertime.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgvOvertime.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dtgvOvertime.Location = new System.Drawing.Point(3, 48);
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
            this.dtgvOvertime.Size = new System.Drawing.Size(894, 337);
            this.dtgvOvertime.TabIndex = 276;
            // 
            // lblAddWorkingHours
            // 
            this.lblAddWorkingHours.AutoSize = true;
            this.lblAddWorkingHours.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddWorkingHours.Location = new System.Drawing.Point(0, 6);
            this.lblAddWorkingHours.Name = "lblAddWorkingHours";
            this.lblAddWorkingHours.Size = new System.Drawing.Size(148, 20);
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
            this.txtbxAddWorkingHours.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxAddWorkingHours.Location = new System.Drawing.Point(154, 3);
            this.txtbxAddWorkingHours.MaxLength = 3;
            this.txtbxAddWorkingHours.Name = "txtbxAddWorkingHours";
            this.txtbxAddWorkingHours.Size = new System.Drawing.Size(50, 26);
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
            this.btnAddOvertime.Location = new System.Drawing.Point(761, 391);
            this.btnAddOvertime.Name = "btnAddOvertime";
            this.btnAddOvertime.Size = new System.Drawing.Size(136, 30);
            this.btnAddOvertime.TabIndex = 280;
            this.btnAddOvertime.TabStop = false;
            this.btnAddOvertime.UseVisualStyleBackColor = true;
            this.btnAddOvertime.Click += new System.EventHandler(this.btnAddOvertime_Click);
            // 
            // tblpOvertime
            // 
            this.tblpOvertime.ColumnCount = 1;
            this.tblpOvertime.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblpOvertime.Controls.Add(this.btnAddOvertime, 0, 2);
            this.tblpOvertime.Controls.Add(this.pnlWorkingHours, 0, 1);
            this.tblpOvertime.Controls.Add(this.dtgvOvertime, 0, 2);
            this.tblpOvertime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblpOvertime.Location = new System.Drawing.Point(0, 38);
            this.tblpOvertime.Name = "tblpOvertime";
            this.tblpOvertime.RowCount = 4;
            this.tblpOvertime.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.886792F));
            this.tblpOvertime.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.726415F));
            this.tblpOvertime.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.89622F));
            this.tblpOvertime.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.254717F));
            this.tblpOvertime.Size = new System.Drawing.Size(900, 424);
            this.tblpOvertime.TabIndex = 282;
            // 
            // pnlWorkingHours
            // 
            this.pnlWorkingHours.Controls.Add(this.lblAddWorkingHours);
            this.pnlWorkingHours.Controls.Add(this.txtbxAddWorkingHours);
            this.pnlWorkingHours.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlWorkingHours.Location = new System.Drawing.Point(3, 11);
            this.pnlWorkingHours.Name = "pnlWorkingHours";
            this.pnlWorkingHours.Size = new System.Drawing.Size(894, 31);
            this.pnlWorkingHours.TabIndex = 281;
            // 
            // ucOvertime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tblpOvertime);
            this.Controls.Add(this.lblOvertime);
            this.Name = "ucOvertime";
            this.Size = new System.Drawing.Size(900, 462);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvOvertime)).EndInit();
            this.tblpOvertime.ResumeLayout(false);
            this.pnlWorkingHours.ResumeLayout(false);
            this.pnlWorkingHours.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvOvertime;
        private System.Windows.Forms.Label lblAddWorkingHours;
        private System.Windows.Forms.Label lblOvertime;
        private System.Windows.Forms.TextBox txtbxAddWorkingHours;
        private System.Windows.Forms.Button btnAddOvertime;
        private System.Windows.Forms.TableLayoutPanel tblpOvertime;
        private System.Windows.Forms.Panel pnlWorkingHours;
    }
}
