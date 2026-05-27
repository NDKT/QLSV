namespace QLSV
{
    partial class fQLD
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
            panel3 = new Panel();
            btnReset = new Button();
            label1 = new Label();
            panel6 = new Panel();
            cbbMaMH = new ComboBox();
            label3 = new Label();
            panel7 = new Panel();
            cbbTenMH = new ComboBox();
            label4 = new Label();
            panel5 = new Panel();
            cbbTenSV = new ComboBox();
            lb2 = new Label();
            panel4 = new Panel();
            cbbMaSV = new ComboBox();
            label2 = new Label();
            panel11 = new Panel();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel11.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel11);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(980, 239);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(btnReset);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(panel7);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(12, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(950, 181);
            panel3.TabIndex = 11;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(15, 141);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(898, 29);
            btnReset.TabIndex = 8;
            btnReset.Text = "Đặt lại";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(435, 9);
            label1.Name = "label1";
            label1.Size = new Size(85, 22);
            label1.TabIndex = 6;
            label1.Text = "Tìm kiếm";
            // 
            // panel6
            // 
            panel6.Controls.Add(cbbMaMH);
            panel6.Controls.Add(label3);
            panel6.Location = new Point(15, 90);
            panel6.Name = "panel6";
            panel6.Size = new Size(430, 37);
            panel6.TabIndex = 4;
            // 
            // cbbMaMH
            // 
            cbbMaMH.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbbMaMH.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbbMaMH.FormattingEnabled = true;
            cbbMaMH.Location = new Point(127, 4);
            cbbMaMH.Name = "cbbMaMH";
            cbbMaMH.Size = new Size(300, 30);
            cbbMaMH.TabIndex = 4;
            cbbMaMH.SelectedIndexChanged += cbbMaSV_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 8);
            label3.Name = "label3";
            label3.Size = new Size(107, 22);
            label3.TabIndex = 0;
            label3.Text = "Mã môn học";
            // 
            // panel7
            // 
            panel7.Controls.Add(cbbTenMH);
            panel7.Controls.Add(label4);
            panel7.Location = new Point(495, 90);
            panel7.Name = "panel7";
            panel7.Size = new Size(418, 37);
            panel7.TabIndex = 5;
            // 
            // cbbTenMH
            // 
            cbbTenMH.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbbTenMH.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbbTenMH.FormattingEnabled = true;
            cbbTenMH.Location = new Point(139, 4);
            cbbTenMH.Name = "cbbTenMH";
            cbbTenMH.Size = new Size(276, 30);
            cbbTenMH.TabIndex = 2;
            cbbTenMH.SelectedIndexChanged += cbbMaSV_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 8);
            label4.Name = "label4";
            label4.Size = new Size(111, 22);
            label4.TabIndex = 0;
            label4.Text = "Tên môn học";
            // 
            // panel5
            // 
            panel5.Controls.Add(cbbTenSV);
            panel5.Controls.Add(lb2);
            panel5.Location = new Point(495, 43);
            panel5.Name = "panel5";
            panel5.Size = new Size(418, 37);
            panel5.TabIndex = 3;
            // 
            // cbbTenSV
            // 
            cbbTenSV.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbbTenSV.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbbTenSV.FormattingEnabled = true;
            cbbTenSV.Location = new Point(136, 3);
            cbbTenSV.Name = "cbbTenSV";
            cbbTenSV.Size = new Size(279, 30);
            cbbTenSV.TabIndex = 3;
            cbbTenSV.SelectedIndexChanged += cbbMaSV_SelectedIndexChanged;
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
            // panel4
            // 
            panel4.Controls.Add(cbbMaSV);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(15, 43);
            panel4.Name = "panel4";
            panel4.Size = new Size(430, 37);
            panel4.TabIndex = 2;
            // 
            // cbbMaSV
            // 
            cbbMaSV.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbbMaSV.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbbMaSV.FormattingEnabled = true;
            cbbMaSV.Location = new Point(127, 4);
            cbbMaSV.Name = "cbbMaSV";
            cbbMaSV.Size = new Size(300, 30);
            cbbMaSV.TabIndex = 1;
            cbbMaSV.SelectedIndexChanged += cbbMaSV_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 8);
            label2.Name = "label2";
            label2.Size = new Size(112, 22);
            label2.TabIndex = 0;
            label2.Text = "Mã sinh viên";
            // 
            // panel11
            // 
            panel11.Controls.Add(btnSua);
            panel11.Controls.Add(btnXoa);
            panel11.Controls.Add(btnThem);
            panel11.Location = new Point(660, 199);
            panel11.Name = "panel11";
            panel11.Size = new Size(307, 37);
            panel11.TabIndex = 10;
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
            panel2.Location = new Point(0, 239);
            panel2.Name = "panel2";
            panel2.Size = new Size(980, 256);
            panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridView1.BackgroundColor = SystemColors.ActiveBorder;
            dataGridView1.ColumnHeadersHeight = 29;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9 });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(980, 256);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "MaSV";
            Column2.HeaderText = "MÃ SINH VIÊN";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 170;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "TenSV";
            Column3.HeaderText = "HỌ VÀ TÊN";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 142;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "MaMH";
            Column4.HeaderText = "MÃ MÔN HỌC";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 166;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "TenMH";
            Column5.HeaderText = "TÊN MÔN HỌC";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 173;
            // 
            // Column6
            // 
            Column6.DataPropertyName = "ChuyenCan";
            Column6.HeaderText = "CHUYÊN CẦN";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 165;
            // 
            // Column7
            // 
            Column7.DataPropertyName = "ThuongXuyen";
            Column7.HeaderText = "THƯỜNG XUYÊN";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Width = 195;
            // 
            // Column8
            // 
            Column8.DataPropertyName = "KetThuc";
            Column8.HeaderText = "KẾT THÚC";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            Column8.Width = 135;
            // 
            // Column9
            // 
            Column9.DataPropertyName = "TongKet";
            Column9.HeaderText = "TỔNG KẾT";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            Column9.Width = 136;
            // 
            // fQLD
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(980, 495);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "fQLD";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý điểm";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel11.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Panel panel4;
        private Label label2;
        private Panel panel5;
        private Label lb2;
        private Panel panel6;
        private Label label3;
        private Panel panel7;
        private Label label4;
        private Panel panel11;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private Panel panel3;
        private Label label1;
        private ComboBox cbbTenMH;
        private ComboBox cbbMaMH;
        private ComboBox cbbTenSV;
        private ComboBox cbbMaSV;
        private Button btnReset;
    }
}