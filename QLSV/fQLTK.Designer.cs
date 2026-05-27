namespace QLSV
{
    partial class fQLTK
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
            panel1 = new Panel();
            panel5 = new Panel();
            label3 = new Label();
            panel4 = new Panel();
            txbTenDangNhap = new TextBox();
            label2 = new Label();
            panel3 = new Panel();
            txbID = new TextBox();
            label1 = new Label();
            panel10 = new Panel();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            TenDangNhap = new DataGridViewTextBoxColumn();
            MatKhau = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel10.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel10);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(887, 138);
            panel1.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(label3);
            panel5.Controls.Add(panel4);
            panel5.Controls.Add(panel3);
            panel5.Location = new Point(12, 5);
            panel5.Name = "panel5";
            panel5.Size = new Size(863, 90);
            panel5.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(373, 6);
            label3.Name = "label3";
            label3.Size = new Size(90, 22);
            label3.TabIndex = 11;
            label3.Text = "Tìm Kiếm";
            // 
            // panel4
            // 
            panel4.AutoSize = true;
            panel4.Controls.Add(txbTenDangNhap);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(415, 42);
            panel4.Name = "panel4";
            panel4.Size = new Size(440, 37);
            panel4.TabIndex = 10;
            // 
            // txbTenDangNhap
            // 
            txbTenDangNhap.Location = new Point(139, 3);
            txbTenDangNhap.MaxLength = 255;
            txbTenDangNhap.Name = "txbTenDangNhap";
            txbTenDangNhap.Size = new Size(296, 30);
            txbTenDangNhap.TabIndex = 1;
            txbTenDangNhap.TextChanged += txbTenDangNhap_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 7);
            label2.Name = "label2";
            label2.Size = new Size(124, 22);
            label2.TabIndex = 0;
            label2.Text = "Tên đăng nhập";
            // 
            // panel3
            // 
            panel3.AutoSize = true;
            panel3.Controls.Add(txbID);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(2, 42);
            panel3.Name = "panel3";
            panel3.Size = new Size(400, 37);
            panel3.TabIndex = 9;
            // 
            // txbID
            // 
            txbID.Location = new Point(45, 3);
            txbID.MaxLength = 255;
            txbID.Name = "txbID";
            txbID.Size = new Size(351, 30);
            txbID.TabIndex = 1;
            txbID.TabStop = false;
            txbID.TextChanged += txbTenDangNhap_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 7);
            label1.Name = "label1";
            label1.Size = new Size(30, 22);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // panel10
            // 
            panel10.Controls.Add(btnSua);
            panel10.Controls.Add(btnXoa);
            panel10.Controls.Add(btnThem);
            panel10.Location = new Point(563, 98);
            panel10.Name = "panel10";
            panel10.Size = new Size(312, 37);
            panel10.TabIndex = 8;
            // 
            // btnSua
            // 
            btnSua.Enabled = false;
            btnSua.Location = new Point(208, 3);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 7;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Enabled = false;
            btnXoa.Location = new Point(108, 3);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 6;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(8, 3);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 5;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 138);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(887, 438);
            panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ActiveBorder;
            dataGridView1.ColumnHeadersHeight = 29;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, TenDangNhap, MatKhau });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(887, 438);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // TenDangNhap
            // 
            TenDangNhap.DataPropertyName = "TenDangNhap";
            TenDangNhap.HeaderText = "TÊN ĐĂNG NHẬP";
            TenDangNhap.MinimumWidth = 6;
            TenDangNhap.Name = "TenDangNhap";
            TenDangNhap.ReadOnly = true;
            // 
            // MatKhau
            // 
            MatKhau.DataPropertyName = "MatKhau";
            MatKhau.HeaderText = "MẬT KHẨU";
            MatKhau.MinimumWidth = 6;
            MatKhau.Name = "MatKhau";
            MatKhau.ReadOnly = true;
            // 
            // fQLTK
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(887, 576);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "fQLTK";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý tài khoản";
            Load += fQLTK_Load;
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel10.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Panel panel10;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private Panel panel3;
        private TextBox txbID;
        private Label label1;
        private Panel panel4;
        private TextBox txbTenDangNhap;
        private Label label2;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn TenDangNhap;
        private DataGridViewTextBoxColumn MatKhau;
        private Panel panel5;
        private Label label3;
    }
}