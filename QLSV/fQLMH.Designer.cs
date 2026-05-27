namespace QLSV
{
    partial class fQLMH
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
            panel10 = new Panel();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            panel4 = new Panel();
            txbTenMH = new TextBox();
            label2 = new Label();
            panel3 = new Panel();
            txbMaMH = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            panel5 = new Panel();
            label3 = new Label();
            panel1.SuspendLayout();
            panel10.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel10);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(784, 216);
            panel1.TabIndex = 0;
            // 
            // panel10
            // 
            panel10.Controls.Add(btnSua);
            panel10.Controls.Add(btnXoa);
            panel10.Controls.Add(btnThem);
            panel10.Location = new Point(473, 178);
            panel10.Name = "panel10";
            panel10.Size = new Size(311, 35);
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
            // panel4
            // 
            panel4.Controls.Add(txbTenMH);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(396, 91);
            panel4.Name = "panel4";
            panel4.Size = new Size(368, 37);
            panel4.TabIndex = 2;
            // 
            // txbTenMH
            // 
            txbTenMH.Location = new Point(127, 5);
            txbTenMH.MaxLength = 255;
            txbTenMH.Name = "txbTenMH";
            txbTenMH.Size = new Size(238, 30);
            txbTenMH.TabIndex = 2;
            txbTenMH.TextChanged += txbMaMH_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 8);
            label2.Name = "label2";
            label2.Size = new Size(111, 22);
            label2.TabIndex = 0;
            label2.Text = "Tên môn học";
            // 
            // panel3
            // 
            panel3.Controls.Add(txbMaMH);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(1, 91);
            panel3.Name = "panel3";
            panel3.Size = new Size(371, 37);
            panel3.TabIndex = 1;
            // 
            // txbMaMH
            // 
            txbMaMH.Location = new Point(122, 5);
            txbMaMH.MaxLength = 255;
            txbMaMH.Name = "txbMaMH";
            txbMaMH.Size = new Size(245, 30);
            txbMaMH.TabIndex = 1;
            txbMaMH.TextChanged += txbMaMH_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 8);
            label1.Name = "label1";
            label1.Size = new Size(107, 22);
            label1.TabIndex = 0;
            label1.Text = "Mã môn học";
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 216);
            panel2.Name = "panel2";
            panel2.Size = new Size(784, 279);
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(784, 279);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "MaMH";
            Column1.HeaderText = "MÃ MÔN HỌC";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "TenMH";
            Column2.HeaderText = "TÊN MÔN HỌC";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "TC";
            Column3.HeaderText = "SỐ TÍN";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "KieuThi";
            Column4.HeaderText = "KIỂU THI";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "Tiet";
            Column5.HeaderText = "SỐ TIẾT";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(label3);
            panel5.Controls.Add(panel4);
            panel5.Controls.Add(panel3);
            panel5.Location = new Point(8, 11);
            panel5.Name = "panel5";
            panel5.Size = new Size(772, 146);
            panel5.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(344, 20);
            label3.Name = "label3";
            label3.Size = new Size(85, 22);
            label3.TabIndex = 3;
            label3.Text = "Tìm kiếm";
            // 
            // fQLMH
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 495);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "fQLMH";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý môn học";
            panel1.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Panel panel3;
        private TextBox txbMaMH;
        private Label label1;
        private Panel panel4;
        private TextBox txbTenMH;
        private Label label2;
        private Panel panel10;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Panel panel5;
        private Label label3;
    }
}