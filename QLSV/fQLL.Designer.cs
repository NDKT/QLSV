namespace QLSV
{
    partial class fQLL
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
            txbTenLop = new TextBox();
            label2 = new Label();
            panel3 = new Panel();
            txbMaLop = new TextBox();
            label1 = new Label();
            panel10 = new Panel();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
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
            panel1.Name = "panel1";
            panel1.Size = new Size(937, 138);
            panel1.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(label3);
            panel5.Controls.Add(panel4);
            panel5.Controls.Add(panel3);
            panel5.Location = new Point(4, 5);
            panel5.Name = "panel5";
            panel5.Size = new Size(927, 86);
            panel5.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(438, 4);
            label3.Name = "label3";
            label3.Size = new Size(85, 22);
            label3.TabIndex = 4;
            label3.Text = "Tìm kiếm";
            // 
            // panel4
            // 
            panel4.Controls.Add(txbTenLop);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(494, 42);
            panel4.Name = "panel4";
            panel4.Size = new Size(428, 37);
            panel4.TabIndex = 3;
            // 
            // txbTenLop
            // 
            txbTenLop.Location = new Point(94, 5);
            txbTenLop.MaxLength = 255;
            txbTenLop.Name = "txbTenLop";
            txbTenLop.Size = new Size(331, 30);
            txbTenLop.TabIndex = 1;
            txbTenLop.TextChanged += txbTenLop_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 8);
            label2.Name = "label2";
            label2.Size = new Size(72, 22);
            label2.TabIndex = 0;
            label2.Text = "Tên lớp";
            // 
            // panel3
            // 
            panel3.Controls.Add(txbMaLop);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(8, 42);
            panel3.Name = "panel3";
            panel3.Size = new Size(437, 37);
            panel3.TabIndex = 2;
            // 
            // txbMaLop
            // 
            txbMaLop.Location = new Point(94, 5);
            txbMaLop.MaxLength = 255;
            txbMaLop.Name = "txbMaLop";
            txbMaLop.Size = new Size(332, 30);
            txbMaLop.TabIndex = 1;
            txbMaLop.TextChanged += txbTenLop_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 8);
            label1.Name = "label1";
            label1.Size = new Size(68, 22);
            label1.TabIndex = 0;
            label1.Text = "Mã lớp";
            // 
            // panel10
            // 
            panel10.Controls.Add(btnSua);
            panel10.Controls.Add(btnXoa);
            panel10.Controls.Add(btnThem);
            panel10.Location = new Point(628, 98);
            panel10.Name = "panel10";
            panel10.Size = new Size(306, 37);
            panel10.TabIndex = 9;
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
            panel2.Name = "panel2";
            panel2.Size = new Size(937, 390);
            panel2.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ActiveBorder;
            dataGridView1.ColumnHeadersHeight = 29;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(937, 390);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellClick += this.dataGridView1_CellClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "MaLop";
            Column1.HeaderText = "MÃ LỚP";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "TenLop";
            Column2.HeaderText = "TÊN LỚP";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // fQLL
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(937, 528);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "fQLL";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý lớp";
            Load += fQLL_Load;
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
        private Panel panel3;
        private TextBox txbMaLop;
        private Label label1;
        private Panel panel10;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private Panel panel4;
        private TextBox txbTenLop;
        private Label label2;
        private Panel panel5;
        private Label label3;
        private Panel panel2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
    }
}