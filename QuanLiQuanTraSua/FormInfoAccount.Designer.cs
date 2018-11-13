namespace QuanLiQuanTraSua
{
    partial class FormInfoAccount
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelFormInfoAccount = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgvInfoAccount = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btAddAccount = new System.Windows.Forms.Button();
            this.txtDisplayName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DisplayName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Yesterday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panelFormInfoAccount.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvInfoAccount)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFormInfoAccount
            // 
            this.panelFormInfoAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelFormInfoAccount.Controls.Add(this.panel3);
            this.panelFormInfoAccount.Controls.Add(this.panel1);
            this.panelFormInfoAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormInfoAccount.Location = new System.Drawing.Point(0, 0);
            this.panelFormInfoAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelFormInfoAccount.Name = "panelFormInfoAccount";
            this.panelFormInfoAccount.Size = new System.Drawing.Size(1583, 763);
            this.panelFormInfoAccount.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.splitContainer1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 82);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1583, 681);
            this.panel3.TabIndex = 2;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel4);
            this.splitContainer1.Size = new System.Drawing.Size(1583, 681);
            this.splitContainer1.SplitterDistance = 319;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgvInfoAccount);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1583, 319);
            this.panel2.TabIndex = 0;
            // 
            // dtgvInfoAccount
            // 
            this.dtgvInfoAccount.AllowUserToAddRows = false;
            this.dtgvInfoAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvInfoAccount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.UserName,
            this.Password,
            this.DisplayName,
            this.CountDay,
            this.CountMonth,
            this.TotalDay,
            this.TotalMonth,
            this.Yesterday,
            this.Edit,
            this.Delete});
            this.dtgvInfoAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvInfoAccount.Location = new System.Drawing.Point(0, 0);
            this.dtgvInfoAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvInfoAccount.Name = "dtgvInfoAccount";
            this.dtgvInfoAccount.RowTemplate.Height = 24;
            this.dtgvInfoAccount.Size = new System.Drawing.Size(1583, 319);
            this.dtgvInfoAccount.TabIndex = 0;
            this.dtgvInfoAccount.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvInfoAccount_CellClick);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1583, 357);
            this.panel4.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btAddAccount);
            this.panel5.Controls.Add(this.txtDisplayName);
            this.panel5.Controls.Add(this.txtPassword);
            this.panel5.Controls.Add(this.txtUserName);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1583, 357);
            this.panel5.TabIndex = 3;
            // 
            // btAddAccount
            // 
            this.btAddAccount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btAddAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddAccount.Location = new System.Drawing.Point(568, 58);
            this.btAddAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btAddAccount.Name = "btAddAccount";
            this.btAddAccount.Size = new System.Drawing.Size(173, 105);
            this.btAddAccount.TabIndex = 8;
            this.btAddAccount.Text = "Thêm";
            this.btAddAccount.UseVisualStyleBackColor = true;
            this.btAddAccount.Click += new System.EventHandler(this.btAddAccount_Click);
            // 
            // txtDisplayName
            // 
            this.txtDisplayName.Location = new System.Drawing.Point(215, 210);
            this.txtDisplayName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDisplayName.Name = "txtDisplayName";
            this.txtDisplayName.Size = new System.Drawing.Size(203, 22);
            this.txtDisplayName.TabIndex = 7;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(215, 135);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(203, 22);
            this.txtPassword.TabIndex = 6;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(215, 58);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(203, 22);
            this.txtUserName.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(75, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tên hiển thị:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(79, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mật khẩu:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tài khoản:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1583, 82);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1583, 82);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông Tin Tài Khoản";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "Tên Tài Khoản";
            this.UserName.Name = "UserName";
            this.UserName.Width = 150;
            // 
            // Password
            // 
            this.Password.DataPropertyName = "Password";
            this.Password.HeaderText = "Mật Khẩu";
            this.Password.Name = "Password";
            this.Password.Width = 150;
            // 
            // DisplayName
            // 
            this.DisplayName.DataPropertyName = "DisplayName";
            this.DisplayName.HeaderText = "Tên Nhân Viên";
            this.DisplayName.Name = "DisplayName";
            this.DisplayName.Width = 200;
            // 
            // CountDay
            // 
            this.CountDay.DataPropertyName = "CountDay";
            this.CountDay.HeaderText = "Số Hóa Đơn Trong Ngày";
            this.CountDay.Name = "CountDay";
            this.CountDay.ReadOnly = true;
            // 
            // CountMonth
            // 
            this.CountMonth.DataPropertyName = "CountMonth";
            this.CountMonth.HeaderText = "Số Hóa Đơn Trong Tháng";
            this.CountMonth.Name = "CountMonth";
            this.CountMonth.ReadOnly = true;
            // 
            // TotalDay
            // 
            this.TotalDay.DataPropertyName = "TotalDay";
            this.TotalDay.HeaderText = "Tổng Ngày";
            this.TotalDay.Name = "TotalDay";
            this.TotalDay.ReadOnly = true;
            // 
            // TotalMonth
            // 
            this.TotalMonth.DataPropertyName = "TotalMonth";
            this.TotalMonth.HeaderText = "Tổng Tháng";
            this.TotalMonth.Name = "TotalMonth";
            this.TotalMonth.ReadOnly = true;
            // 
            // Yesterday
            // 
            this.Yesterday.DataPropertyName = "Yesterday";
            this.Yesterday.HeaderText = "Yesterday";
            this.Yesterday.Name = "Yesterday";
            this.Yesterday.ReadOnly = true;
            this.Yesterday.Visible = false;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Sửa";
            this.Edit.Name = "Edit";
            this.Edit.Text = "Edit";
            this.Edit.Width = 50;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Xóa";
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.Width = 60;
            // 
            // FormInfoAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1583, 763);
            this.Controls.Add(this.panelFormInfoAccount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormInfoAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông Tin Tài Khoản";
            this.Load += new System.EventHandler(this.FormInfoAccount_Load);
            this.panelFormInfoAccount.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvInfoAccount)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFormInfoAccount;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtgvInfoAccount;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btAddAccount;
        private System.Windows.Forms.TextBox txtDisplayName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn DisplayName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Yesterday;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}