namespace Fireon
{
    partial class ucDataGridView
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
            this.dgvTheDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTheDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTheDataGridView
            // 
            this.dgvTheDataGridView.AllowUserToAddRows = false;
            this.dgvTheDataGridView.AllowUserToDeleteRows = false;
            this.dgvTheDataGridView.AllowUserToResizeColumns = false;
            this.dgvTheDataGridView.AllowUserToResizeRows = false;
            this.dgvTheDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTheDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTheDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvTheDataGridView.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.dgvTheDataGridView.Location = new System.Drawing.Point(0, 0);
            this.dgvTheDataGridView.Name = "dgvTheDataGridView";
            this.dgvTheDataGridView.ReadOnly = true;
            this.dgvTheDataGridView.Size = new System.Drawing.Size(526, 312);
            this.dgvTheDataGridView.TabIndex = 276;
            this.dgvTheDataGridView.TabStop = false;
            // 
            // ucDataGridView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvTheDataGridView);
            this.Name = "ucDataGridView";
            this.Size = new System.Drawing.Size(526, 312);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTheDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvTheDataGridView;
    }
}
