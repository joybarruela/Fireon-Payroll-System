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
            this.rdbtnMaternity = new System.Windows.Forms.RadioButton();
            this.rdbtnVacation = new System.Windows.Forms.RadioButton();
            this.rdbtnSick = new System.Windows.Forms.RadioButton();
            this.lblNumberOfDays = new System.Windows.Forms.Label();
            this.txtbxNumberOfDays = new System.Windows.Forms.TextBox();
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
            this.btnAddLeave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnAddLeave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddLeave.Location = new System.Drawing.Point(773, 428);
            this.btnAddLeave.Name = "btnAddLeave";
            this.btnAddLeave.Size = new System.Drawing.Size(124, 31);
            this.btnAddLeave.TabIndex = 276;
            this.btnAddLeave.TabStop = false;
            this.btnAddLeave.UseVisualStyleBackColor = true;
            this.btnAddLeave.Click += new System.EventHandler(this.btnAddLeave_Click);
            // 
            // pnlFilters
            // 
            this.pnlFilters.Controls.Add(this.rdbtnMaternity);
            this.pnlFilters.Controls.Add(this.rdbtnVacation);
            this.pnlFilters.Controls.Add(this.rdbtnSick);
            this.pnlFilters.Controls.Add(this.lblNumberOfDays);
            this.pnlFilters.Controls.Add(this.txtbxNumberOfDays);
            this.pnlFilters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFilters.Location = new System.Drawing.Point(3, 3);
            this.pnlFilters.Name = "pnlFilters";
            this.pnlFilters.Size = new System.Drawing.Size(894, 84);
            this.pnlFilters.TabIndex = 274;
            // 
            // rdbtnMaternity
            // 
            this.rdbtnMaternity.AutoSize = true;
            this.rdbtnMaternity.Location = new System.Drawing.Point(138, 41);
            this.rdbtnMaternity.Name = "rdbtnMaternity";
            this.rdbtnMaternity.Size = new System.Drawing.Size(68, 17);
            this.rdbtnMaternity.TabIndex = 2;
            this.rdbtnMaternity.TabStop = true;
            this.rdbtnMaternity.Text = "Maternity";
            this.rdbtnMaternity.UseVisualStyleBackColor = true;
            // 
            // rdbtnVacation
            // 
            this.rdbtnVacation.AutoSize = true;
            this.rdbtnVacation.Location = new System.Drawing.Point(65, 41);
            this.rdbtnVacation.Name = "rdbtnVacation";
            this.rdbtnVacation.Size = new System.Drawing.Size(67, 17);
            this.rdbtnVacation.TabIndex = 2;
            this.rdbtnVacation.TabStop = true;
            this.rdbtnVacation.Text = "Vacation";
            this.rdbtnVacation.UseVisualStyleBackColor = true;
            // 
            // rdbtnSick
            // 
            this.rdbtnSick.AutoSize = true;
            this.rdbtnSick.Location = new System.Drawing.Point(13, 41);
            this.rdbtnSick.Name = "rdbtnSick";
            this.rdbtnSick.Size = new System.Drawing.Size(46, 17);
            this.rdbtnSick.TabIndex = 2;
            this.rdbtnSick.TabStop = true;
            this.rdbtnSick.Text = "Sick";
            this.rdbtnSick.UseVisualStyleBackColor = true;
            // 
            // lblNumberOfDays
            // 
            this.lblNumberOfDays.AutoSize = true;
            this.lblNumberOfDays.Location = new System.Drawing.Point(13, 67);
            this.lblNumberOfDays.Name = "lblNumberOfDays";
            this.lblNumberOfDays.Size = new System.Drawing.Size(83, 13);
            this.lblNumberOfDays.TabIndex = 1;
            this.lblNumberOfDays.Text = "Number of Days";
            // 
            // txtbxNumberOfDays
            // 
            this.txtbxNumberOfDays.Location = new System.Drawing.Point(102, 64);
            this.txtbxNumberOfDays.MaxLength = 3;
            this.txtbxNumberOfDays.Name = "txtbxNumberOfDays";
            this.txtbxNumberOfDays.Size = new System.Drawing.Size(51, 20);
            this.txtbxNumberOfDays.TabIndex = 0;
            this.txtbxNumberOfDays.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxNumberOfDays_KeyPress);
            // 
            // dtgvLeave
            // 
            this.dtgvLeave.AllowUserToAddRows = false;
            this.dtgvLeave.AllowUserToDeleteRows = false;
            this.dtgvLeave.AllowUserToResizeColumns = false;
            this.dtgvLeave.AllowUserToResizeRows = false;
            this.dtgvLeave.BackgroundColor = System.Drawing.Color.White;
            this.dtgvLeave.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(5)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvLeave.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvLeave.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(5)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvLeave.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvLeave.Dock = System.Windows.Forms.DockStyle.Left;
            this.dtgvLeave.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgvLeave.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dtgvLeave.Location = new System.Drawing.Point(3, 93);
            this.dtgvLeave.MultiSelect = false;
            this.dtgvLeave.Name = "dtgvLeave";
            this.dtgvLeave.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(5)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvLeave.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvLeave.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgvLeave.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvLeave.ShowEditingIcon = false;
            this.dtgvLeave.Size = new System.Drawing.Size(458, 329);
            this.dtgvLeave.TabIndex = 275;
            // 
            // ucLeave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
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
        private System.Windows.Forms.DataGridView dtgvLeave;
        private System.Windows.Forms.Button btnAddLeave;
        private System.Windows.Forms.RadioButton rdbtnMaternity;
        private System.Windows.Forms.RadioButton rdbtnVacation;
        private System.Windows.Forms.RadioButton rdbtnSick;
        private System.Windows.Forms.TextBox txtbxNumberOfDays;
        private System.Windows.Forms.Label lblNumberOfDays;

    }
}
