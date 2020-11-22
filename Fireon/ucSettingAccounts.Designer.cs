namespace Fireon
{
    partial class Setting_Accounts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setting_Accounts));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtbx_search = new System.Windows.Forms.TextBox();
            this.lbl_setting_accounts = new System.Windows.Forms.Label();
            this.btn_back = new JImageButton.JImageButton();
            this.pnl_setting_accounts = new System.Windows.Forms.Panel();
            this.flpnl_setting_accounts = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_user_type = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.dtgv_setting_accounts = new System.Windows.Forms.DataGridView();
            this.uc_add_account = new Fireon.Settings_Add_Account();
            this.uc_update_account = new Fireon.Settings_Update_Account();
            this.btn_add_account = new System.Windows.Forms.Button();
            this.pnl_del_upd = new System.Windows.Forms.Panel();
            this.btn_delete_8 = new System.Windows.Forms.Button();
            this.btn_delete_7 = new System.Windows.Forms.Button();
            this.btn_delete_6 = new System.Windows.Forms.Button();
            this.btn_delete_5 = new System.Windows.Forms.Button();
            this.btn_delete_4 = new System.Windows.Forms.Button();
            this.btn_delete_3 = new System.Windows.Forms.Button();
            this.btn_delete_2 = new System.Windows.Forms.Button();
            this.btn_delete_1 = new System.Windows.Forms.Button();
            this.btn_update_8 = new System.Windows.Forms.Button();
            this.btn_update_7 = new System.Windows.Forms.Button();
            this.btn_update_6 = new System.Windows.Forms.Button();
            this.btn_update_5 = new System.Windows.Forms.Button();
            this.btn_update_4 = new System.Windows.Forms.Button();
            this.btn_update_3 = new System.Windows.Forms.Button();
            this.btn_update_2 = new System.Windows.Forms.Button();
            this.btn_update_1 = new System.Windows.Forms.Button();
            this.pnl_setting_accounts.SuspendLayout();
            this.flpnl_setting_accounts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_setting_accounts)).BeginInit();
            this.pnl_del_upd.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtbx_search
            // 
            this.txtbx_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_search.Location = new System.Drawing.Point(39, 86);
            this.txtbx_search.Name = "txtbx_search";
            this.txtbx_search.Size = new System.Drawing.Size(199, 26);
            this.txtbx_search.TabIndex = 228;
            this.txtbx_search.TabStop = false;
            this.txtbx_search.Text = "Search";
            // 
            // lbl_setting_accounts
            // 
            this.lbl_setting_accounts.AutoSize = true;
            this.lbl_setting_accounts.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_setting_accounts.Font = new System.Drawing.Font("Open Sans", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_setting_accounts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_setting_accounts.Location = new System.Drawing.Point(0, 0);
            this.lbl_setting_accounts.Name = "lbl_setting_accounts";
            this.lbl_setting_accounts.Padding = new System.Windows.Forms.Padding(70, 30, 0, 10);
            this.lbl_setting_accounts.Size = new System.Drawing.Size(357, 83);
            this.lbl_setting_accounts.TabIndex = 229;
            this.lbl_setting_accounts.Text = "Setting Accounts";
            // 
            // btn_back
            // 
            this.btn_back.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_back.BackColor = System.Drawing.Color.Transparent;
            this.btn_back.CausesValidation = false;
            this.btn_back.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_back.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btn_back.ErrorImage")));
            this.btn_back.Image = global::Fireon.Properties.Resources.btn_back;
            this.btn_back.ImageHover = global::Fireon.Properties.Resources.btn_back_hover;
            this.btn_back.InitialImage = null;
            this.btn_back.Location = new System.Drawing.Point(0, 33);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(76, 41);
            this.btn_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_back.TabIndex = 256;
            this.btn_back.Zoom = 0;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // pnl_setting_accounts
            // 
            this.pnl_setting_accounts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_setting_accounts.Controls.Add(this.flpnl_setting_accounts);
            this.pnl_setting_accounts.Controls.Add(this.dtgv_setting_accounts);
            this.pnl_setting_accounts.Location = new System.Drawing.Point(39, 132);
            this.pnl_setting_accounts.Name = "pnl_setting_accounts";
            this.pnl_setting_accounts.Size = new System.Drawing.Size(874, 444);
            this.pnl_setting_accounts.TabIndex = 257;
            // 
            // flpnl_setting_accounts
            // 
            this.flpnl_setting_accounts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(5)))));
            this.flpnl_setting_accounts.Controls.Add(this.lbl_user_type);
            this.flpnl_setting_accounts.Controls.Add(this.lbl_username);
            this.flpnl_setting_accounts.Controls.Add(this.lbl_password);
            this.flpnl_setting_accounts.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpnl_setting_accounts.Location = new System.Drawing.Point(0, 0);
            this.flpnl_setting_accounts.Name = "flpnl_setting_accounts";
            this.flpnl_setting_accounts.Padding = new System.Windows.Forms.Padding(10);
            this.flpnl_setting_accounts.Size = new System.Drawing.Size(874, 37);
            this.flpnl_setting_accounts.TabIndex = 147;
            // 
            // lbl_user_type
            // 
            this.lbl_user_type.AutoSize = true;
            this.lbl_user_type.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user_type.ForeColor = System.Drawing.Color.White;
            this.lbl_user_type.Location = new System.Drawing.Point(13, 10);
            this.lbl_user_type.Name = "lbl_user_type";
            this.lbl_user_type.Padding = new System.Windows.Forms.Padding(0, 0, 150, 0);
            this.lbl_user_type.Size = new System.Drawing.Size(222, 18);
            this.lbl_user_type.TabIndex = 9;
            this.lbl_user_type.Text = "User Type";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.ForeColor = System.Drawing.Color.White;
            this.lbl_username.Location = new System.Drawing.Point(241, 10);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Padding = new System.Windows.Forms.Padding(0, 0, 200, 0);
            this.lbl_username.Size = new System.Drawing.Size(276, 18);
            this.lbl_username.TabIndex = 9;
            this.lbl_username.Text = "Username";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.ForeColor = System.Drawing.Color.White;
            this.lbl_password.Location = new System.Drawing.Point(523, 10);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.lbl_password.Size = new System.Drawing.Size(89, 18);
            this.lbl_password.TabIndex = 10;
            this.lbl_password.Text = "Password";
            // 
            // dtgv_setting_accounts
            // 
            this.dtgv_setting_accounts.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(5)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv_setting_accounts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dtgv_setting_accounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(5)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgv_setting_accounts.DefaultCellStyle = dataGridViewCellStyle11;
            this.dtgv_setting_accounts.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgv_setting_accounts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dtgv_setting_accounts.Location = new System.Drawing.Point(0, 34);
            this.dtgv_setting_accounts.Name = "dtgv_setting_accounts";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(5)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv_setting_accounts.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dtgv_setting_accounts.Size = new System.Drawing.Size(874, 410);
            this.dtgv_setting_accounts.TabIndex = 146;
            // 
            // uc_add_account
            // 
            this.uc_add_account.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.uc_add_account.BackColor = System.Drawing.Color.Transparent;
            this.uc_add_account.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.uc_add_account.Location = new System.Drawing.Point(29, 628);
            this.uc_add_account.Name = "uc_add_account";
            this.uc_add_account.Size = new System.Drawing.Size(1048, 523);
            this.uc_add_account.TabIndex = 148;
            this.uc_add_account.Visible = false;
            // 
            // uc_update_account
            // 
            this.uc_update_account.BackColor = System.Drawing.Color.Transparent;
            this.uc_update_account.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uc_update_account.BackgroundImage")));
            this.uc_update_account.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uc_update_account.Location = new System.Drawing.Point(39, 583);
            this.uc_update_account.Name = "uc_update_account";
            this.uc_update_account.Size = new System.Drawing.Size(1048, 523);
            this.uc_update_account.TabIndex = 148;
            this.uc_update_account.Visible = false;
            // 
            // btn_add_account
            // 
            this.btn_add_account.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add_account.BackgroundImage = global::Fireon.Properties.Resources.btn_add;
            this.btn_add_account.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_add_account.FlatAppearance.BorderSize = 0;
            this.btn_add_account.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_add_account.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_account.Location = new System.Drawing.Point(789, 628);
            this.btn_add_account.Name = "btn_add_account";
            this.btn_add_account.Size = new System.Drawing.Size(124, 29);
            this.btn_add_account.TabIndex = 265;
            this.btn_add_account.TabStop = false;
            this.btn_add_account.UseVisualStyleBackColor = true;
            // 
            // pnl_del_upd
            // 
            this.pnl_del_upd.Controls.Add(this.btn_delete_8);
            this.pnl_del_upd.Controls.Add(this.btn_delete_7);
            this.pnl_del_upd.Controls.Add(this.btn_delete_6);
            this.pnl_del_upd.Controls.Add(this.btn_delete_5);
            this.pnl_del_upd.Controls.Add(this.btn_delete_4);
            this.pnl_del_upd.Controls.Add(this.btn_delete_3);
            this.pnl_del_upd.Controls.Add(this.btn_delete_2);
            this.pnl_del_upd.Controls.Add(this.btn_delete_1);
            this.pnl_del_upd.Controls.Add(this.btn_update_8);
            this.pnl_del_upd.Controls.Add(this.btn_update_7);
            this.pnl_del_upd.Controls.Add(this.btn_update_6);
            this.pnl_del_upd.Controls.Add(this.btn_update_5);
            this.pnl_del_upd.Controls.Add(this.btn_update_4);
            this.pnl_del_upd.Controls.Add(this.btn_update_3);
            this.pnl_del_upd.Controls.Add(this.btn_update_2);
            this.pnl_del_upd.Controls.Add(this.btn_update_1);
            this.pnl_del_upd.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_del_upd.Location = new System.Drawing.Point(914, 83);
            this.pnl_del_upd.Name = "pnl_del_upd";
            this.pnl_del_upd.Size = new System.Drawing.Size(146, 597);
            this.pnl_del_upd.TabIndex = 264;
            // 
            // btn_delete_8
            // 
            this.btn_delete_8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_delete_8.BackgroundImage = global::Fireon.Properties.Resources.btn_delete_db_active;
            this.btn_delete_8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_delete_8.FlatAppearance.BorderSize = 0;
            this.btn_delete_8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(5)))));
            this.btn_delete_8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete_8.Location = new System.Drawing.Point(14, 469);
            this.btn_delete_8.Name = "btn_delete_8";
            this.btn_delete_8.Size = new System.Drawing.Size(27, 25);
            this.btn_delete_8.TabIndex = 222;
            this.btn_delete_8.TabStop = false;
            this.btn_delete_8.UseVisualStyleBackColor = true;
            // 
            // btn_delete_7
            // 
            this.btn_delete_7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_delete_7.BackgroundImage = global::Fireon.Properties.Resources.btn_delete_db_active;
            this.btn_delete_7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_delete_7.FlatAppearance.BorderSize = 0;
            this.btn_delete_7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(5)))));
            this.btn_delete_7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete_7.Location = new System.Drawing.Point(14, 420);
            this.btn_delete_7.Name = "btn_delete_7";
            this.btn_delete_7.Size = new System.Drawing.Size(27, 25);
            this.btn_delete_7.TabIndex = 222;
            this.btn_delete_7.TabStop = false;
            this.btn_delete_7.UseVisualStyleBackColor = true;
            // 
            // btn_delete_6
            // 
            this.btn_delete_6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_delete_6.BackgroundImage = global::Fireon.Properties.Resources.btn_delete_db_active;
            this.btn_delete_6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_delete_6.FlatAppearance.BorderSize = 0;
            this.btn_delete_6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(5)))));
            this.btn_delete_6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete_6.Location = new System.Drawing.Point(14, 371);
            this.btn_delete_6.Name = "btn_delete_6";
            this.btn_delete_6.Size = new System.Drawing.Size(27, 25);
            this.btn_delete_6.TabIndex = 222;
            this.btn_delete_6.TabStop = false;
            this.btn_delete_6.UseVisualStyleBackColor = true;
            // 
            // btn_delete_5
            // 
            this.btn_delete_5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_delete_5.BackgroundImage = global::Fireon.Properties.Resources.btn_delete_db_active;
            this.btn_delete_5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_delete_5.FlatAppearance.BorderSize = 0;
            this.btn_delete_5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(5)))));
            this.btn_delete_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete_5.Location = new System.Drawing.Point(14, 322);
            this.btn_delete_5.Name = "btn_delete_5";
            this.btn_delete_5.Size = new System.Drawing.Size(27, 25);
            this.btn_delete_5.TabIndex = 222;
            this.btn_delete_5.TabStop = false;
            this.btn_delete_5.UseVisualStyleBackColor = true;
            // 
            // btn_delete_4
            // 
            this.btn_delete_4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_delete_4.BackgroundImage = global::Fireon.Properties.Resources.btn_delete_db_active;
            this.btn_delete_4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_delete_4.FlatAppearance.BorderSize = 0;
            this.btn_delete_4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(5)))));
            this.btn_delete_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete_4.Location = new System.Drawing.Point(14, 273);
            this.btn_delete_4.Name = "btn_delete_4";
            this.btn_delete_4.Size = new System.Drawing.Size(27, 25);
            this.btn_delete_4.TabIndex = 222;
            this.btn_delete_4.TabStop = false;
            this.btn_delete_4.UseVisualStyleBackColor = true;
            // 
            // btn_delete_3
            // 
            this.btn_delete_3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_delete_3.BackgroundImage = global::Fireon.Properties.Resources.btn_delete_db_active;
            this.btn_delete_3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_delete_3.FlatAppearance.BorderSize = 0;
            this.btn_delete_3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(5)))));
            this.btn_delete_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete_3.Location = new System.Drawing.Point(14, 224);
            this.btn_delete_3.Name = "btn_delete_3";
            this.btn_delete_3.Size = new System.Drawing.Size(27, 25);
            this.btn_delete_3.TabIndex = 222;
            this.btn_delete_3.TabStop = false;
            this.btn_delete_3.UseVisualStyleBackColor = true;
            // 
            // btn_delete_2
            // 
            this.btn_delete_2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_delete_2.BackgroundImage = global::Fireon.Properties.Resources.btn_delete_db_active;
            this.btn_delete_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_delete_2.FlatAppearance.BorderSize = 0;
            this.btn_delete_2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(5)))));
            this.btn_delete_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete_2.Location = new System.Drawing.Point(14, 175);
            this.btn_delete_2.Name = "btn_delete_2";
            this.btn_delete_2.Size = new System.Drawing.Size(27, 25);
            this.btn_delete_2.TabIndex = 222;
            this.btn_delete_2.TabStop = false;
            this.btn_delete_2.UseVisualStyleBackColor = true;
            // 
            // btn_delete_1
            // 
            this.btn_delete_1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_delete_1.BackgroundImage = global::Fireon.Properties.Resources.btn_delete_db_active;
            this.btn_delete_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_delete_1.FlatAppearance.BorderSize = 0;
            this.btn_delete_1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(5)))));
            this.btn_delete_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete_1.Location = new System.Drawing.Point(14, 126);
            this.btn_delete_1.Name = "btn_delete_1";
            this.btn_delete_1.Size = new System.Drawing.Size(27, 25);
            this.btn_delete_1.TabIndex = 222;
            this.btn_delete_1.TabStop = false;
            this.btn_delete_1.UseVisualStyleBackColor = true;
            // 
            // btn_update_8
            // 
            this.btn_update_8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_update_8.BackgroundImage = global::Fireon.Properties.Resources.btn_update_active;
            this.btn_update_8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_update_8.FlatAppearance.BorderSize = 0;
            this.btn_update_8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(5)))));
            this.btn_update_8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update_8.Location = new System.Drawing.Point(50, 469);
            this.btn_update_8.Name = "btn_update_8";
            this.btn_update_8.Size = new System.Drawing.Size(27, 25);
            this.btn_update_8.TabIndex = 222;
            this.btn_update_8.TabStop = false;
            this.btn_update_8.UseVisualStyleBackColor = true;
            // 
            // btn_update_7
            // 
            this.btn_update_7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_update_7.BackgroundImage = global::Fireon.Properties.Resources.btn_update_active;
            this.btn_update_7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_update_7.FlatAppearance.BorderSize = 0;
            this.btn_update_7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(5)))));
            this.btn_update_7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update_7.Location = new System.Drawing.Point(50, 420);
            this.btn_update_7.Name = "btn_update_7";
            this.btn_update_7.Size = new System.Drawing.Size(27, 25);
            this.btn_update_7.TabIndex = 222;
            this.btn_update_7.TabStop = false;
            this.btn_update_7.UseVisualStyleBackColor = true;
            // 
            // btn_update_6
            // 
            this.btn_update_6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_update_6.BackgroundImage = global::Fireon.Properties.Resources.btn_update_active;
            this.btn_update_6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_update_6.FlatAppearance.BorderSize = 0;
            this.btn_update_6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(5)))));
            this.btn_update_6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update_6.Location = new System.Drawing.Point(50, 371);
            this.btn_update_6.Name = "btn_update_6";
            this.btn_update_6.Size = new System.Drawing.Size(27, 25);
            this.btn_update_6.TabIndex = 222;
            this.btn_update_6.TabStop = false;
            this.btn_update_6.UseVisualStyleBackColor = true;
            // 
            // btn_update_5
            // 
            this.btn_update_5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_update_5.BackgroundImage = global::Fireon.Properties.Resources.btn_update_active;
            this.btn_update_5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_update_5.FlatAppearance.BorderSize = 0;
            this.btn_update_5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(5)))));
            this.btn_update_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update_5.Location = new System.Drawing.Point(50, 322);
            this.btn_update_5.Name = "btn_update_5";
            this.btn_update_5.Size = new System.Drawing.Size(27, 25);
            this.btn_update_5.TabIndex = 222;
            this.btn_update_5.TabStop = false;
            this.btn_update_5.UseVisualStyleBackColor = true;
            // 
            // btn_update_4
            // 
            this.btn_update_4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_update_4.BackgroundImage = global::Fireon.Properties.Resources.btn_update_active;
            this.btn_update_4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_update_4.FlatAppearance.BorderSize = 0;
            this.btn_update_4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(5)))));
            this.btn_update_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update_4.Location = new System.Drawing.Point(50, 273);
            this.btn_update_4.Name = "btn_update_4";
            this.btn_update_4.Size = new System.Drawing.Size(27, 25);
            this.btn_update_4.TabIndex = 222;
            this.btn_update_4.TabStop = false;
            this.btn_update_4.UseVisualStyleBackColor = true;
            // 
            // btn_update_3
            // 
            this.btn_update_3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_update_3.BackgroundImage = global::Fireon.Properties.Resources.btn_update_active;
            this.btn_update_3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_update_3.FlatAppearance.BorderSize = 0;
            this.btn_update_3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(5)))));
            this.btn_update_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update_3.Location = new System.Drawing.Point(50, 224);
            this.btn_update_3.Name = "btn_update_3";
            this.btn_update_3.Size = new System.Drawing.Size(27, 25);
            this.btn_update_3.TabIndex = 222;
            this.btn_update_3.TabStop = false;
            this.btn_update_3.UseVisualStyleBackColor = true;
            // 
            // btn_update_2
            // 
            this.btn_update_2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_update_2.BackgroundImage = global::Fireon.Properties.Resources.btn_update_active;
            this.btn_update_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_update_2.FlatAppearance.BorderSize = 0;
            this.btn_update_2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(5)))));
            this.btn_update_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update_2.Location = new System.Drawing.Point(50, 175);
            this.btn_update_2.Name = "btn_update_2";
            this.btn_update_2.Size = new System.Drawing.Size(27, 25);
            this.btn_update_2.TabIndex = 222;
            this.btn_update_2.TabStop = false;
            this.btn_update_2.UseVisualStyleBackColor = true;
            // 
            // btn_update_1
            // 
            this.btn_update_1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_update_1.BackgroundImage = global::Fireon.Properties.Resources.btn_update_active;
            this.btn_update_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_update_1.FlatAppearance.BorderSize = 0;
            this.btn_update_1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(5)))));
            this.btn_update_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update_1.Location = new System.Drawing.Point(50, 126);
            this.btn_update_1.Name = "btn_update_1";
            this.btn_update_1.Size = new System.Drawing.Size(27, 25);
            this.btn_update_1.TabIndex = 222;
            this.btn_update_1.TabStop = false;
            this.btn_update_1.UseVisualStyleBackColor = true;
            // 
            // Setting_Accounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.uc_add_account);
            this.Controls.Add(this.btn_add_account);
            this.Controls.Add(this.pnl_del_upd);
            this.Controls.Add(this.uc_update_account);
            this.Controls.Add(this.pnl_setting_accounts);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.lbl_setting_accounts);
            this.Controls.Add(this.txtbx_search);
            this.Name = "Setting_Accounts";
            this.Size = new System.Drawing.Size(1060, 680);
            this.pnl_setting_accounts.ResumeLayout(false);
            this.flpnl_setting_accounts.ResumeLayout(false);
            this.flpnl_setting_accounts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_setting_accounts)).EndInit();
            this.pnl_del_upd.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbx_search;
        private System.Windows.Forms.Label lbl_setting_accounts;
        private JImageButton.JImageButton btn_back;
        private System.Windows.Forms.Panel pnl_setting_accounts;
        private System.Windows.Forms.FlowLayoutPanel flpnl_setting_accounts;
        private System.Windows.Forms.Label lbl_user_type;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.DataGridView dtgv_setting_accounts;
        private Settings_Add_Account uc_add_account;
        private Settings_Update_Account uc_update_account;
        private System.Windows.Forms.Button btn_add_account;
        private System.Windows.Forms.Panel pnl_del_upd;
        private System.Windows.Forms.Button btn_delete_8;
        private System.Windows.Forms.Button btn_delete_7;
        private System.Windows.Forms.Button btn_delete_6;
        private System.Windows.Forms.Button btn_delete_5;
        private System.Windows.Forms.Button btn_delete_4;
        private System.Windows.Forms.Button btn_delete_3;
        private System.Windows.Forms.Button btn_delete_2;
        private System.Windows.Forms.Button btn_delete_1;
        private System.Windows.Forms.Button btn_update_8;
        private System.Windows.Forms.Button btn_update_7;
        private System.Windows.Forms.Button btn_update_6;
        private System.Windows.Forms.Button btn_update_5;
        private System.Windows.Forms.Button btn_update_4;
        private System.Windows.Forms.Button btn_update_3;
        private System.Windows.Forms.Button btn_update_2;
        private System.Windows.Forms.Button btn_update_1;
    }
}
