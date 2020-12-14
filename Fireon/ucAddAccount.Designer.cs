namespace Fireon
{
    partial class ucAddAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucAddAccount));
            this.pnlBelow = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pnlSeparator1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbxUserType = new System.Windows.Forms.ComboBox();
            this.lblNewUserName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picbUserAddAccount = new System.Windows.Forms.PictureBox();
            this.lbl_username = new System.Windows.Forms.Label();
            this.txtbx_username = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.txtbx_password = new System.Windows.Forms.TextBox();
            this.lbl_confirm_pw = new System.Windows.Forms.Label();
            this.txtbx_confirm_pw = new System.Windows.Forms.TextBox();
            this.btn_see_current_pw = new System.Windows.Forms.Button();
            this.btn_see_new_pw = new System.Windows.Forms.Button();
            this.pnlBelow.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbUserAddAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBelow
            // 
            this.pnlBelow.Controls.Add(this.btnCancel);
            this.pnlBelow.Controls.Add(this.pnlSeparator1);
            this.pnlBelow.Controls.Add(this.btnAdd);
            this.pnlBelow.Controls.Add(this.panel1);
            this.pnlBelow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBelow.Location = new System.Drawing.Point(3, 383);
            this.pnlBelow.Name = "pnlBelow";
            this.pnlBelow.Size = new System.Drawing.Size(880, 30);
            this.pnlBelow.TabIndex = 286;
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(488, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(124, 30);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.TabStop = false;
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // pnlSeparator1
            // 
            this.pnlSeparator1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlSeparator1.Location = new System.Drawing.Point(473, 0);
            this.pnlSeparator1.Name = "pnlSeparator1";
            this.pnlSeparator1.Size = new System.Drawing.Size(15, 30);
            this.pnlSeparator1.TabIndex = 8;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlBelow, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.44042F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.559578F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(886, 416);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = global::Fireon.Properties.Resources.btnCancel;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(349, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(124, 30);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.TabStop = false;
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(612, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 30);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_see_new_pw);
            this.panel2.Controls.Add(this.btn_see_current_pw);
            this.panel2.Controls.Add(this.txtbx_confirm_pw);
            this.panel2.Controls.Add(this.lbl_confirm_pw);
            this.panel2.Controls.Add(this.txtbx_password);
            this.panel2.Controls.Add(this.lbl_password);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.txtbx_username);
            this.panel2.Controls.Add(this.lbl_username);
            this.panel2.Controls.Add(this.picbUserAddAccount);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblNewUserName);
            this.panel2.Controls.Add(this.cmbxUserType);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(880, 374);
            this.panel2.TabIndex = 287;
            // 
            // cmbxUserType
            // 
            this.cmbxUserType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbxUserType.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxUserType.FormattingEnabled = true;
            this.cmbxUserType.Items.AddRange(new object[] {
            "Admin",
            "Manager"});
            this.cmbxUserType.Location = new System.Drawing.Point(285, 152);
            this.cmbxUserType.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.cmbxUserType.Name = "cmbxUserType";
            this.cmbxUserType.Size = new System.Drawing.Size(327, 25);
            this.cmbxUserType.TabIndex = 285;
            this.cmbxUserType.TabStop = false;
            // 
            // lblNewUserName
            // 
            this.lblNewUserName.AutoSize = true;
            this.lblNewUserName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewUserName.ForeColor = System.Drawing.Color.Black;
            this.lblNewUserName.Location = new System.Drawing.Point(281, 76);
            this.lblNewUserName.Name = "lblNewUserName";
            this.lblNewUserName.Size = new System.Drawing.Size(44, 17);
            this.lblNewUserName.TabIndex = 289;
            this.lblNewUserName.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(281, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 288;
            this.label1.Text = "User Type";
            // 
            // picbUserAddAccount
            // 
            this.picbUserAddAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picbUserAddAccount.BackColor = System.Drawing.Color.White;
            this.picbUserAddAccount.BackgroundImage = global::Fireon.Properties.Resources.miscEmployeeDP;
            this.picbUserAddAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picbUserAddAccount.Location = new System.Drawing.Point(408, 3);
            this.picbUserAddAccount.Name = "picbUserAddAccount";
            this.picbUserAddAccount.Size = new System.Drawing.Size(80, 80);
            this.picbUserAddAccount.TabIndex = 286;
            this.picbUserAddAccount.TabStop = false;
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.ForeColor = System.Drawing.Color.Black;
            this.lbl_username.Location = new System.Drawing.Point(281, 184);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(67, 17);
            this.lbl_username.TabIndex = 287;
            this.lbl_username.Text = "Username";
            // 
            // txtbx_username
            // 
            this.txtbx_username.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbx_username.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_username.Location = new System.Drawing.Point(284, 207);
            this.txtbx_username.Margin = new System.Windows.Forms.Padding(4, 3, 3, 3);
            this.txtbx_username.MaxLength = 15;
            this.txtbx_username.Name = "txtbx_username";
            this.txtbx_username.Size = new System.Drawing.Size(329, 25);
            this.txtbx_username.TabIndex = 291;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(284, 99);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 3, 3);
            this.textBox1.MaxLength = 15;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(329, 25);
            this.textBox1.TabIndex = 290;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.ForeColor = System.Drawing.Color.Black;
            this.lbl_password.Location = new System.Drawing.Point(281, 238);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(63, 17);
            this.lbl_password.TabIndex = 292;
            this.lbl_password.Text = "Password";
            // 
            // txtbx_password
            // 
            this.txtbx_password.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbx_password.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_password.Location = new System.Drawing.Point(284, 261);
            this.txtbx_password.Margin = new System.Windows.Forms.Padding(4, 3, 3, 3);
            this.txtbx_password.MaxLength = 15;
            this.txtbx_password.Name = "txtbx_password";
            this.txtbx_password.Size = new System.Drawing.Size(329, 25);
            this.txtbx_password.TabIndex = 293;
            // 
            // lbl_confirm_pw
            // 
            this.lbl_confirm_pw.AutoSize = true;
            this.lbl_confirm_pw.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_confirm_pw.ForeColor = System.Drawing.Color.Black;
            this.lbl_confirm_pw.Location = new System.Drawing.Point(281, 292);
            this.lbl_confirm_pw.Name = "lbl_confirm_pw";
            this.lbl_confirm_pw.Size = new System.Drawing.Size(112, 17);
            this.lbl_confirm_pw.TabIndex = 294;
            this.lbl_confirm_pw.Text = "Confirm Password";
            // 
            // txtbx_confirm_pw
            // 
            this.txtbx_confirm_pw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbx_confirm_pw.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_confirm_pw.Location = new System.Drawing.Point(284, 315);
            this.txtbx_confirm_pw.Margin = new System.Windows.Forms.Padding(4, 3, 3, 3);
            this.txtbx_confirm_pw.MaxLength = 15;
            this.txtbx_confirm_pw.Name = "txtbx_confirm_pw";
            this.txtbx_confirm_pw.Size = new System.Drawing.Size(329, 25);
            this.txtbx_confirm_pw.TabIndex = 295;
            // 
            // btn_see_current_pw
            // 
            this.btn_see_current_pw.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_see_current_pw.BackColor = System.Drawing.Color.White;
            this.btn_see_current_pw.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_see_current_pw.BackgroundImage")));
            this.btn_see_current_pw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_see_current_pw.FlatAppearance.BorderSize = 0;
            this.btn_see_current_pw.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PeachPuff;
            this.btn_see_current_pw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_see_current_pw.Location = new System.Drawing.Point(619, 261);
            this.btn_see_current_pw.Name = "btn_see_current_pw";
            this.btn_see_current_pw.Size = new System.Drawing.Size(27, 25);
            this.btn_see_current_pw.TabIndex = 297;
            this.btn_see_current_pw.TabStop = false;
            this.btn_see_current_pw.UseVisualStyleBackColor = false;
            // 
            // btn_see_new_pw
            // 
            this.btn_see_new_pw.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_see_new_pw.BackColor = System.Drawing.Color.White;
            this.btn_see_new_pw.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_see_new_pw.BackgroundImage")));
            this.btn_see_new_pw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_see_new_pw.FlatAppearance.BorderSize = 0;
            this.btn_see_new_pw.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PeachPuff;
            this.btn_see_new_pw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_see_new_pw.Location = new System.Drawing.Point(619, 315);
            this.btn_see_new_pw.Name = "btn_see_new_pw";
            this.btn_see_new_pw.Size = new System.Drawing.Size(27, 25);
            this.btn_see_new_pw.TabIndex = 296;
            this.btn_see_new_pw.TabStop = false;
            this.btn_see_new_pw.UseVisualStyleBackColor = false;
            // 
            // ucAddAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucAddAccount";
            this.Size = new System.Drawing.Size(886, 416);
            this.pnlBelow.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbUserAddAccount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBelow;
        private System.Windows.Forms.Panel pnlSeparator1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_see_new_pw;
        private System.Windows.Forms.Button btn_see_current_pw;
        private System.Windows.Forms.TextBox txtbx_confirm_pw;
        private System.Windows.Forms.Label lbl_confirm_pw;
        private System.Windows.Forms.TextBox txtbx_password;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtbx_username;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.PictureBox picbUserAddAccount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNewUserName;
        private System.Windows.Forms.ComboBox cmbxUserType;





    }
}
