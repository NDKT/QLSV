namespace QLSV.GUI.Diem
{
    partial class fThem
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
            panel4 = new Panel();
            cbbMaSV = new ComboBox();
            label2 = new Label();
            panel5 = new Panel();
            cbbTenSV = new ComboBox();
            lb2 = new Label();
            panel7 = new Panel();
            cbbMaMonHoc = new ComboBox();
            label4 = new Label();
            btnThemMon = new Button();
            panel8 = new Panel();
            nmChuyenCan = new NumericUpDown();
            label5 = new Label();
            panel9 = new Panel();
            nmThuongXuyen = new NumericUpDown();
            label6 = new Label();
            panel10 = new Panel();
            nmKetThuc = new NumericUpDown();
            label7 = new Label();
            panel1 = new Panel();
            txbTongKet = new TextBox();
            label1 = new Label();
            btnThem = new Button();
            btnQuayLai = new Button();
            panel2 = new Panel();
            cbbTenMon = new ComboBox();
            label3 = new Label();
            btnThemSV = new Button();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmChuyenCan).BeginInit();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmThuongXuyen).BeginInit();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmKetThuc).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.Controls.Add(cbbMaSV);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(13, 12);
            panel4.Margin = new Padding(4, 3, 4, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(336, 41);
            panel4.TabIndex = 3;
            // 
            // cbbMaSV
            // 
            cbbMaSV.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbbMaSV.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbbMaSV.FormattingEnabled = true;
            cbbMaSV.Location = new Point(125, 3);
            cbbMaSV.Name = "cbbMaSV";
            cbbMaSV.Size = new Size(203, 30);
            cbbMaSV.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 9);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(112, 22);
            label2.TabIndex = 0;
            label2.Text = "Mã sinh viên";
            // 
            // panel5
            // 
            panel5.Controls.Add(cbbTenSV);
            panel5.Controls.Add(lb2);
            panel5.Location = new Point(13, 60);
            panel5.Name = "panel5";
            panel5.Size = new Size(481, 37);
            panel5.TabIndex = 4;
            // 
            // cbbTenSV
            // 
            cbbTenSV.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbbTenSV.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbbTenSV.FormattingEnabled = true;
            cbbTenSV.Location = new Point(125, 0);
            cbbTenSV.Name = "cbbTenSV";
            cbbTenSV.Size = new Size(347, 30);
            cbbTenSV.TabIndex = 2;
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
            // panel7
            // 
            panel7.Controls.Add(cbbMaMonHoc);
            panel7.Controls.Add(label4);
            panel7.Location = new Point(12, 105);
            panel7.Name = "panel7";
            panel7.Size = new Size(337, 37);
            panel7.TabIndex = 6;
            // 
            // cbbMaMonHoc
            // 
            cbbMaMonHoc.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbbMaMonHoc.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbbMaMonHoc.FormattingEnabled = true;
            cbbMaMonHoc.Location = new Point(126, 5);
            cbbMaMonHoc.Name = "cbbMaMonHoc";
            cbbMaMonHoc.Size = new Size(203, 30);
            cbbMaMonHoc.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 8);
            label4.Name = "label4";
            label4.Size = new Size(107, 22);
            label4.TabIndex = 0;
            label4.Text = "Mã môn học";
            // 
            // btnThemMon
            // 
            btnThemMon.Location = new Point(355, 105);
            btnThemMon.Name = "btnThemMon";
            btnThemMon.Size = new Size(139, 37);
            btnThemMon.TabIndex = 7;
            btnThemMon.Text = "Thêm môn học";
            btnThemMon.UseVisualStyleBackColor = true;
            btnThemMon.Click += btnThemMon_Click;
            // 
            // panel8
            // 
            panel8.Controls.Add(nmChuyenCan);
            panel8.Controls.Add(label5);
            panel8.Location = new Point(12, 202);
            panel8.Name = "panel8";
            panel8.Size = new Size(233, 37);
            panel8.TabIndex = 8;
            // 
            // nmChuyenCan
            // 
            nmChuyenCan.DecimalPlaces = 1;
            nmChuyenCan.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            nmChuyenCan.Location = new Point(115, 3);
            nmChuyenCan.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nmChuyenCan.Name = "nmChuyenCan";
            nmChuyenCan.Size = new Size(88, 30);
            nmChuyenCan.TabIndex = 1;
            nmChuyenCan.ValueChanged += nmKetThuc_ValueChanged;
            nmChuyenCan.Leave += nmChuyenCan_Leave;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 8);
            label5.Name = "label5";
            label5.Size = new Size(100, 22);
            label5.TabIndex = 0;
            label5.Text = "Chuyên cần";
            // 
            // panel9
            // 
            panel9.Controls.Add(nmThuongXuyen);
            panel9.Controls.Add(label6);
            panel9.Location = new Point(251, 203);
            panel9.Name = "panel9";
            panel9.Size = new Size(243, 37);
            panel9.TabIndex = 9;
            // 
            // nmThuongXuyen
            // 
            nmThuongXuyen.DecimalPlaces = 1;
            nmThuongXuyen.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            nmThuongXuyen.Location = new Point(146, 4);
            nmThuongXuyen.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nmThuongXuyen.Name = "nmThuongXuyen";
            nmThuongXuyen.Size = new Size(88, 30);
            nmThuongXuyen.TabIndex = 1;
            nmThuongXuyen.ValueChanged += nmKetThuc_ValueChanged;
            nmThuongXuyen.Leave += nmChuyenCan_Leave;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 8);
            label6.Name = "label6";
            label6.Size = new Size(121, 22);
            label6.TabIndex = 0;
            label6.Text = "Thường xuyên";
            // 
            // panel10
            // 
            panel10.Controls.Add(nmKetThuc);
            panel10.Controls.Add(label7);
            panel10.Location = new Point(12, 245);
            panel10.Name = "panel10";
            panel10.Size = new Size(226, 37);
            panel10.TabIndex = 10;
            // 
            // nmKetThuc
            // 
            nmKetThuc.DecimalPlaces = 1;
            nmKetThuc.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            nmKetThuc.Location = new Point(115, 3);
            nmKetThuc.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nmKetThuc.Name = "nmKetThuc";
            nmKetThuc.Size = new Size(88, 30);
            nmKetThuc.TabIndex = 1;
            nmKetThuc.ValueChanged += nmKetThuc_ValueChanged;
            nmKetThuc.Leave += nmChuyenCan_Leave;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(9, 8);
            label7.Name = "label7";
            label7.Size = new Size(76, 22);
            label7.TabIndex = 0;
            label7.Text = "Kết thúc";
            // 
            // panel1
            // 
            panel1.Controls.Add(txbTongKet);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(251, 246);
            panel1.Name = "panel1";
            panel1.Size = new Size(243, 37);
            panel1.TabIndex = 11;
            // 
            // txbTongKet
            // 
            txbTongKet.Location = new Point(146, 3);
            txbTongKet.Name = "txbTongKet";
            txbTongKet.ReadOnly = true;
            txbTongKet.Size = new Size(88, 30);
            txbTongKet.TabIndex = 1;
            txbTongKet.TabStop = false;
            txbTongKet.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 8);
            label1.Name = "label1";
            label1.Size = new Size(78, 22);
            label1.TabIndex = 0;
            label1.Text = "Tổng kết";
            // 
            // btnThem
            // 
            btnThem.Location = new Point(287, 302);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 12;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnQuayLai
            // 
            btnQuayLai.Location = new Point(397, 302);
            btnQuayLai.Name = "btnQuayLai";
            btnQuayLai.Size = new Size(94, 29);
            btnQuayLai.TabIndex = 13;
            btnQuayLai.Text = "Quay lại";
            btnQuayLai.UseVisualStyleBackColor = true;
            btnQuayLai.Click += btnQuayLai_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(cbbTenMon);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(12, 148);
            panel2.Name = "panel2";
            panel2.Size = new Size(473, 37);
            panel2.TabIndex = 7;
            // 
            // cbbTenMon
            // 
            cbbTenMon.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbbTenMon.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbbTenMon.FormattingEnabled = true;
            cbbTenMon.Location = new Point(126, 5);
            cbbTenMon.Name = "cbbTenMon";
            cbbTenMon.Size = new Size(344, 30);
            cbbTenMon.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 8);
            label3.Name = "label3";
            label3.Size = new Size(111, 22);
            label3.TabIndex = 0;
            label3.Text = "Tên môn học";
            // 
            // btnThemSV
            // 
            btnThemSV.Location = new Point(355, 14);
            btnThemSV.Name = "btnThemSV";
            btnThemSV.Size = new Size(139, 37);
            btnThemSV.TabIndex = 15;
            btnThemSV.Text = "Thêm sinh viên";
            btnThemSV.UseVisualStyleBackColor = true;
            btnThemSV.Click += btnThemSV_Click;
            // 
            // fThem
            // 
            AcceptButton = btnThem;
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnQuayLai;
            ClientSize = new Size(509, 364);
            Controls.Add(btnThemSV);
            Controls.Add(panel2);
            Controls.Add(btnQuayLai);
            Controls.Add(btnThem);
            Controls.Add(panel1);
            Controls.Add(panel10);
            Controls.Add(panel9);
            Controls.Add(panel8);
            Controls.Add(btnThemMon);
            Controls.Add(panel7);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "fThem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thêm điểm";
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmChuyenCan).EndInit();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmThuongXuyen).EndInit();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmKetThuc).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel4;
        private Label label2;
        private Panel panel5;
        private Label lb2;
        private Panel panel7;
        private ComboBox cbbMaMonHoc;
        private Label label4;
        private Button btnThemMon;
        private Panel panel8;
        private NumericUpDown nmChuyenCan;
        private Label label5;
        private Panel panel9;
        private NumericUpDown nmThuongXuyen;
        private Label label6;
        private Panel panel10;
        private NumericUpDown nmKetThuc;
        private Label label7;
        private Panel panel1;
        private TextBox txbTongKet;
        private Label label1;
        private Button btnThem;
        private Button btnQuayLai;
        private Panel panel2;
        private ComboBox cbbTenMon;
        private Label label3;
        private ComboBox cbbMaSV;
        private ComboBox cbbTenSV;
        private Button btnThemSV;
    }
}