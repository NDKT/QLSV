namespace QLSV
{
    partial class fQLSV
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
            label2 = new Label();
            panel4 = new Panel();
            txbHoTen = new TextBox();
            lb2 = new Label();
            panel3 = new Panel();
            txbMaSV = new TextBox();
            label1 = new Label();
            panel10 = new Panel();
            btnChiTiet = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            menuStrip1 = new MenuStrip();
            quảnLýToolStripMenuItem = new ToolStripMenuItem();
            QLTKToolStripMenuItem = new ToolStripMenuItem();
            QLMHToolStripMenuItem = new ToolStripMenuItem();
            QLLToolStripMenuItem = new ToolStripMenuItem();
            QLDToolStripMenuItem = new ToolStripMenuItem();
            thôngTinToolStripMenuItem = new ToolStripMenuItem();
            TTTKToolStripMenuItem = new ToolStripMenuItem();
            LogOutToolStripMenuItem = new ToolStripMenuItem();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel10.SuspendLayout();
            menuStrip1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel10);
            panel1.Controls.Add(menuStrip1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1275, 211);
            panel1.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(label2);
            panel5.Controls.Add(panel4);
            panel5.Controls.Add(panel3);
            panel5.Location = new Point(12, 35);
            panel5.Name = "panel5";
            panel5.Size = new Size(885, 122);
            panel5.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(409, 15);
            label2.Name = "label2";
            label2.Size = new Size(85, 22);
            label2.TabIndex = 3;
            label2.Text = "Tìm kiếm";
            // 
            // panel4
            // 
            panel4.Controls.Add(txbHoTen);
            panel4.Controls.Add(lb2);
            panel4.Location = new Point(465, 70);
            panel4.Name = "panel4";
            panel4.Size = new Size(409, 37);
            panel4.TabIndex = 2;
            // 
            // txbHoTen
            // 
            txbHoTen.Location = new Point(101, 3);
            txbHoTen.MaxLength = 255;
            txbHoTen.Name = "txbHoTen";
            txbHoTen.Size = new Size(298, 30);
            txbHoTen.TabIndex = 1;
            txbHoTen.TextChanged += txbMaSV_TextChanged;
            // 
            // lb2
            // 
            lb2.AutoSize = true;
            lb2.Location = new Point(9, 8);
            lb2.Name = "lb2";
            lb2.Size = new Size(86, 22);
            lb2.TabIndex = 0;
            lb2.Text = "Họ và tên";
            // 
            // panel3
            // 
            panel3.Controls.Add(txbMaSV);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(26, 70);
            panel3.Name = "panel3";
            panel3.Size = new Size(412, 37);
            panel3.TabIndex = 0;
            // 
            // txbMaSV
            // 
            txbMaSV.Location = new Point(124, 5);
            txbMaSV.MaxLength = 255;
            txbMaSV.Name = "txbMaSV";
            txbMaSV.Size = new Size(282, 30);
            txbMaSV.TabIndex = 1;
            txbMaSV.TextChanged += txbMaSV_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 8);
            label1.Name = "label1";
            label1.Size = new Size(112, 22);
            label1.TabIndex = 0;
            label1.Text = "Mã sinh viên";
            // 
            // panel10
            // 
            panel10.Controls.Add(btnChiTiet);
            panel10.Controls.Add(btnSua);
            panel10.Controls.Add(btnXoa);
            panel10.Controls.Add(btnThem);
            panel10.Location = new Point(477, 171);
            panel10.Name = "panel10";
            panel10.Size = new Size(409, 37);
            panel10.TabIndex = 7;
            // 
            // btnChiTiet
            // 
            btnChiTiet.Enabled = false;
            btnChiTiet.Location = new Point(308, 3);
            btnChiTiet.Name = "btnChiTiet";
            btnChiTiet.Size = new Size(94, 29);
            btnChiTiet.TabIndex = 9;
            btnChiTiet.Text = "Chi tiết";
            btnChiTiet.UseVisualStyleBackColor = true;
            btnChiTiet.Click += btnChiTiet_Click;
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
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { quảnLýToolStripMenuItem, thôngTinToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1275, 28);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýToolStripMenuItem
            // 
            quảnLýToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { QLTKToolStripMenuItem, QLMHToolStripMenuItem, QLLToolStripMenuItem, QLDToolStripMenuItem });
            quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            quảnLýToolStripMenuItem.Size = new Size(73, 24);
            quảnLýToolStripMenuItem.Text = "Quản lý";
            // 
            // QLTKToolStripMenuItem
            // 
            QLTKToolStripMenuItem.Name = "QLTKToolStripMenuItem";
            QLTKToolStripMenuItem.Size = new Size(207, 26);
            QLTKToolStripMenuItem.Text = "Quản lý tài khoản";
            QLTKToolStripMenuItem.Click += QLTKToolStripMenuItem_Click;
            // 
            // QLMHToolStripMenuItem
            // 
            QLMHToolStripMenuItem.Name = "QLMHToolStripMenuItem";
            QLMHToolStripMenuItem.Size = new Size(207, 26);
            QLMHToolStripMenuItem.Text = "Quản lý môn học";
            QLMHToolStripMenuItem.Click += QLMHToolStripMenuItem_Click;
            // 
            // QLLToolStripMenuItem
            // 
            QLLToolStripMenuItem.Name = "QLLToolStripMenuItem";
            QLLToolStripMenuItem.Size = new Size(207, 26);
            QLLToolStripMenuItem.Text = "Quản lý lớp";
            QLLToolStripMenuItem.Click += QLLToolStripMenuItem_Click;
            // 
            // QLDToolStripMenuItem
            // 
            QLDToolStripMenuItem.Name = "QLDToolStripMenuItem";
            QLDToolStripMenuItem.Size = new Size(207, 26);
            QLDToolStripMenuItem.Text = "Quản lý điểm";
            QLDToolStripMenuItem.Click += QLDToolStripMenuItem_Click;
            // 
            // thôngTinToolStripMenuItem
            // 
            thôngTinToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { TTTKToolStripMenuItem, LogOutToolStripMenuItem });
            thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
            thôngTinToolStripMenuItem.Size = new Size(86, 24);
            thôngTinToolStripMenuItem.Text = "Thông tin";
            // 
            // TTTKToolStripMenuItem
            // 
            TTTKToolStripMenuItem.Name = "TTTKToolStripMenuItem";
            TTTKToolStripMenuItem.Size = new Size(220, 26);
            TTTKToolStripMenuItem.Text = "Thông tin tài khoản";
            TTTKToolStripMenuItem.Click += TTTKToolStripMenuItem_Click;
            // 
            // LogOutToolStripMenuItem
            // 
            LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem";
            LogOutToolStripMenuItem.Size = new Size(220, 26);
            LogOutToolStripMenuItem.Text = "Đăng xuất";
            LogOutToolStripMenuItem.Click += LogOutToolStripMenuItem_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 211);
            panel2.Name = "panel2";
            panel2.Size = new Size(1275, 355);
            panel2.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ActiveBorder;
            dataGridView1.ColumnHeadersHeight = 29;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column6, Column7, Column5 });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1275, 355);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "MaSV";
            Column1.HeaderText = "MÃ SINH VIÊN";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "TenSV";
            Column2.HeaderText = "HỌ VÀ TÊN";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "NgaySinh";
            Column3.HeaderText = "NGÀY SINH";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "GioiTinh";
            Column4.HeaderText = "GIỚI TÍNH";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.DataPropertyName = "QueQuan";
            Column6.HeaderText = "QUÊ QUÁN";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column7
            // 
            Column7.DataPropertyName = "NgayNhapHoc";
            Column7.HeaderText = "NGÀY NHẬP HỌC";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "MaLop";
            Column5.HeaderText = "MÃ LỚP";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // fQLSV
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1275, 566);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "fQLSV";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý sinh viên";
            FormClosing += fQLSV_FormClosing;
            VisibleChanged += fQLSV_VisibleChanged;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel10.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem quảnLýToolStripMenuItem;
        private ToolStripMenuItem QLTKToolStripMenuItem;
        private ToolStripMenuItem QLMHToolStripMenuItem;
        private ToolStripMenuItem QLLToolStripMenuItem;
        private ToolStripMenuItem QLDToolStripMenuItem;
        private ToolStripMenuItem thôngTinToolStripMenuItem;
        private ToolStripMenuItem TTTKToolStripMenuItem;
        private ToolStripMenuItem LogOutToolStripMenuItem;
        private Panel panel3;
        private TextBox txbMaSV;
        private Label label1;
        private Panel panel4;
        private TextBox txbHoTen;
        private Label lb2;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Panel panel10;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private Button btnChiTiet;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column5;
        private Panel panel5;
        private Label label2;
    }
}