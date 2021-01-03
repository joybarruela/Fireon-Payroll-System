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
            this.flpBelow = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddLeave = new System.Windows.Forms.Button();
            this.flpNumberOfDays = new System.Windows.Forms.FlowLayoutPanel();
            this.lblNumberOfDays = new System.Windows.Forms.Label();
            this.txtbxNumberOfDays = new System.Windows.Forms.TextBox();
            this.flpLeaveType = new System.Windows.Forms.FlowLayoutPanel();
            this.rdbtnSick = new System.Windows.Forms.RadioButton();
            this.rdbtnVacation = new System.Windows.Forms.RadioButton();
            this.rdbtnMaternity = new System.Windows.Forms.RadioButton();
            this.dtgvLeave = new System.Windows.Forms.DataGridView();
            this.tblpLeave.SuspendLayout();
            this.flpBelow.SuspendLayout();
            this.flpNumberOfDays.SuspendLayout();
            this.flpLeaveType.SuspendLayout();
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
            this.tblpLeave.Controls.Add(this.flpBelow, 0, 2);
            this.tblpLeave.Controls.Add(this.flpNumberOfDays, 0, 1);
            this.tblpLeave.Controls.Add(this.flpLeaveType, 0, 0);
            this.tblpLeave.Controls.Add(this.dtgvLeave, 0, 2);
            this.tblpLeave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblpLeave.Location = new System.Drawing.Point(0, 38);
            this.tblpLeave.Name = "tblpLeave";
            this.tblpLeave.RowCount = 4;
            this.tblpLeave.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.874459F));
            this.tblpLeave.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.658009F));
            this.tblpLeave.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74.89178F));
            this.tblpLeave.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.359307F));
            this.tblpLeave.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblpLeave.Size = new System.Drawing.Size(900, 462);
            this.tblpLeave.TabIndex = 274;
            // 
            // flpBelow
            // 
            this.flpBelow.Controls.Add(this.btnAddLeave);
            this.flpBelow.Controls.Add(this.flowLayoutPanel1);
            this.flpBelow.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpBelow.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpBelow.Location = new System.Drawing.Point(0, 427);
            this.flpBelow.Margin = new System.Windows.Forms.Padding(0);
            this.flpBelow.Name = "flpBelow";
            this.flpBelow.Size = new System.Drawing.Size(900, 35);
            this.flpBelow.TabIndex = 284;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 33);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(894, 0);
            this.flowLayoutPanel1.TabIndex = 284;
            // 
            // btnAddLeave
            // 
            this.btnAddLeave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddLeave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddLeave.BackgroundImage")));
            this.btnAddLeave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddLeave.FlatAppearance.BorderSize = 0;
            this.btnAddLeave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnAddLeave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddLeave.Location = new System.Drawing.Point(773, 0);
            this.btnAddLeave.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddLeave.Name = "btnAddLeave";
            this.btnAddLeave.Size = new System.Drawing.Size(127, 30);
            this.btnAddLeave.TabIndex = 276;
            this.btnAddLeave.TabStop = false;
            this.btnAddLeave.UseVisualStyleBackColor = true;
            this.btnAddLeave.Click += new System.EventHandler(this.btnAddLeave_Click);
            // 
            // flpNumberOfDays
            // 
            this.flpNumberOfDays.Controls.Add(this.lblNumberOfDays);
            this.flpNumberOfDays.Controls.Add(this.txtbxNumberOfDays);
            this.flpNumberOfDays.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpNumberOfDays.Location = new System.Drawing.Point(3, 44);
            this.flpNumberOfDays.Name = "flpNumberOfDays";
            this.flpNumberOfDays.Size = new System.Drawing.Size(894, 34);
            this.flpNumberOfDays.TabIndex = 278;
            // 
            // lblNumberOfDays
            // 
            this.lblNumberOfDays.AutoSize = true;
            this.lblNumberOfDays.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfDays.Location = new System.Drawing.Point(0, 0);
            this.lblNumberOfDays.Margin = new System.Windows.Forms.Padding(0);
            this.lblNumberOfDays.Name = "lblNumberOfDays";
            this.lblNumberOfDays.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblNumberOfDays.Size = new System.Drawing.Size(125, 25);
            this.lblNumberOfDays.TabIndex = 1;
            this.lblNumberOfDays.Text = "Number of Days";
            // 
            // txtbxNumberOfDays
            // 
            this.txtbxNumberOfDays.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxNumberOfDays.Location = new System.Drawing.Point(128, 3);
            this.txtbxNumberOfDays.MaxLength = 3;
            this.txtbxNumberOfDays.Name = "txtbxNumberOfDays";
            this.txtbxNumberOfDays.Size = new System.Drawing.Size(50, 26);
            this.txtbxNumberOfDays.TabIndex = 0;
            this.txtbxNumberOfDays.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxNumberOfDays_KeyPress);
            // 
            // flpLeaveType
            // 
            this.flpLeaveType.Controls.Add(this.rdbtnSick);
            this.flpLeaveType.Controls.Add(this.rdbtnVacation);
            this.flpLeaveType.Controls.Add(this.rdbtnMaternity);
            this.flpLeaveType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpLeaveType.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.flpLeaveType.Location = new System.Drawing.Point(3, 3);
            this.flpLeaveType.Name = "flpLeaveType";
            this.flpLeaveType.Size = new System.Drawing.Size(894, 35);
            this.flpLeaveType.TabIndex = 277;
            // 
            // rdbtnSick
            // 
            this.rdbtnSick.AutoSize = true;
            this.rdbtnSick.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnSick.Location = new System.Drawing.Point(3, 8);
            this.rdbtnSick.Name = "rdbtnSick";
            this.rdbtnSick.Size = new System.Drawing.Size(55, 24);
            this.rdbtnSick.TabIndex = 2;
            this.rdbtnSick.TabStop = true;
            this.rdbtnSick.Text = "Sick";
            this.rdbtnSick.UseVisualStyleBackColor = true;
            // 
            // rdbtnVacation
            // 
            this.rdbtnVacation.AutoSize = true;
            this.rdbtnVacation.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnVacation.Location = new System.Drawing.Point(64, 8);
            this.rdbtnVacation.Name = "rdbtnVacation";
            this.rdbtnVacation.Size = new System.Drawing.Size(95, 24);
            this.rdbtnVacation.TabIndex = 2;
            this.rdbtnVacation.TabStop = true;
            this.rdbtnVacation.Text = "Vacation";
            this.rdbtnVacation.UseVisualStyleBackColor = true;
            // 
            // rdbtnMaternity
            // 
            this.rdbtnMaternity.AutoSize = true;
            this.rdbtnMaternity.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnMaternity.Location = new System.Drawing.Point(165, 8);
            this.rdbtnMaternity.Name = "rdbtnMaternity";
            this.rdbtnMaternity.Size = new System.Drawing.Size(97, 24);
            this.rdbtnMaternity.TabIndex = 2;
            this.rdbtnMaternity.TabStop = true;
            this.rdbtnMaternity.Text = "Maternity";
            this.rdbtnMaternity.UseVisualStyleBackColor = true;
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvLeave.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvLeave.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(5)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvLeave.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvLeave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvLeave.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgvLeave.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dtgvLeave.Location = new System.Drawing.Point(3, 84);
            this.dtgvLeave.MultiSelect = false;
            this.dtgvLeave.Name = "dtgvLeave";
            this.dtgvLeave.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(5)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvLeave.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvLeave.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgvLeave.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvLeave.ShowEditingIcon = false;
            this.dtgvLeave.Size = new System.Drawing.Size(894, 340);
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
            this.flpBelow.ResumeLayout(false);
            this.flpNumberOfDays.ResumeLayout(false);
            this.flpNumberOfDays.PerformLayout();
            this.flpLeaveType.ResumeLayout(false);
            this.flpLeaveType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLeave)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLeave;
        private System.Windows.Forms.TableLayoutPanel tblpLeave;
        private System.Windows.Forms.DataGridView dtgvLeave;
        private System.Windows.Forms.Button btnAddLeave;
        private System.Windows.Forms.RadioButton rdbtnMaternity;
        private System.Windows.Forms.RadioButton rdbtnVacation;
        private System.Windows.Forms.RadioButton rdbtnSick;
        private System.Windows.Forms.TextBox txtbxNumberOfDays;
        private System.Windows.Forms.Label lblNumberOfDays;
        private System.Windows.Forms.FlowLayoutPanel flpLeaveType;
        private System.Windows.Forms.FlowLayoutPanel flpNumberOfDays;
        private System.Windows.Forms.FlowLayoutPanel flpBelow;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;

    }
}
