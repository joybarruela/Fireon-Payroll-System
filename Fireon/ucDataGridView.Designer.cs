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
            this.theDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.theDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // theDataGridView
            // 
            this.theDataGridView.AllowUserToAddRows = false;
            this.theDataGridView.AllowUserToDeleteRows = false;
            this.theDataGridView.AllowUserToResizeColumns = false;
            this.theDataGridView.AllowUserToResizeRows = false;
            this.theDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.theDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.theDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.theDataGridView.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.theDataGridView.Location = new System.Drawing.Point(0, 0);
            this.theDataGridView.Name = "theDataGridView";
            this.theDataGridView.ReadOnly = true;
            this.theDataGridView.Size = new System.Drawing.Size(526, 312);
            this.theDataGridView.TabIndex = 276;
            this.theDataGridView.TabStop = false;
            // 
            // ucDataGridView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.theDataGridView);
            this.Name = "ucDataGridView";
            this.Size = new System.Drawing.Size(526, 312);
            ((System.ComponentModel.ISupportInitialize)(this.theDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView theDataGridView;
    }
}
