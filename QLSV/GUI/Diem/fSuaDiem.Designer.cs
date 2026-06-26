namespace QLSV.GUI.Diem
{
    partial class fSuaDiem
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
            panel2 = new Panel();
            txbTenMH = new TextBox();
            label3 = new Label();
            btnQuayLai = new Button();
            btnSua = new Button();
            panel1 = new Panel();
            txbTongKet = new TextBox();
            label1 = new Label();
            panel10 = new Panel();
            nmKetThuc = new NumericUpDown();
            label7 = new Label();
            panel9 = new Panel();
            nmThuongXuyen = new NumericUpDown();
            label6 = new Label();
            panel8 = new Panel();
            nmChuyenCan = new NumericUpDown();
            label5 = new Label();
            panel7 = new Panel();
            txbMaMH = new TextBox();
            label4 = new Label();
            panel5 = new Panel();
            txbTenSV = new TextBox();
            lb2 = new Label();
            panel4 = new Panel();
            txbMaSV = new TextBox();
            label2 = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmKetThuc).BeginInit();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmThuongXuyen).BeginInit();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmChuyenCan).BeginInit();
            panel7.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(txbTenMH);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(14, 161);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(534, 41);
            panel2.TabIndex = 19;
            // 
            // txbTenMH
            // 
            txbTenMH.Location = new Point(173, 1);
            txbTenMH.Name = "txbTenMH";
            txbTenMH.ReadOnly = true;
            txbTenMH.Size = new Size(350, 30);
            txbTenMH.TabIndex = 3;
            txbTenMH.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 9);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(111, 22);
            label3.TabIndex = 0;
            label3.Text = "Tên môn học";
            // 
            // btnQuayLai
            // 
            btnQuayLai.Location = new Point(419, 331);
            btnQuayLai.Margin = new Padding(4, 3, 4, 3);
            btnQuayLai.Name = "btnQuayLai";
            btnQuayLai.Size = new Size(129, 32);
            btnQuayLai.TabIndex = 26;
            btnQuayLai.Text = "Quay lại";
            btnQuayLai.UseVisualStyleBackColor = true;
            btnQuayLai.Click += btnQuayLai_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(276, 331);
            btnSua.Margin = new Padding(4, 3, 4, 3);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(129, 32);
            btnSua.TabIndex = 25;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(txbTongKet);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(276, 268);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(272, 41);
            panel1.TabIndex = 24;
            // 
            // txbTongKet
            // 
            txbTongKet.Location = new Point(141, 4);
            txbTongKet.Margin = new Padding(4, 3, 4, 3);
            txbTongKet.Name = "txbTongKet";
            txbTongKet.ReadOnly = true;
            txbTongKet.Size = new Size(120, 30);
            txbTongKet.TabIndex = 1;
            txbTongKet.TabStop = false;
            txbTongKet.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(78, 22);
            label1.TabIndex = 0;
            label1.Text = "Tổng kết";
            // 
            // panel10
            // 
            panel10.Controls.Add(nmKetThuc);
            panel10.Controls.Add(label7);
            panel10.Location = new Point(14, 268);
            panel10.Margin = new Padding(4, 3, 4, 3);
            panel10.Name = "panel10";
            panel10.Size = new Size(254, 41);
            panel10.TabIndex = 23;
            // 
            // nmKetThuc
            // 
            nmKetThuc.DecimalPlaces = 1;
            nmKetThuc.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            nmKetThuc.Location = new Point(120, 5);
            nmKetThuc.Margin = new Padding(4, 3, 4, 3);
            nmKetThuc.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nmKetThuc.Name = "nmKetThuc";
            nmKetThuc.Size = new Size(121, 30);
            nmKetThuc.TabIndex = 1;
            nmKetThuc.ValueChanged += nmChuyenCan_ValueChanged_1;
            nmKetThuc.Leave += nmChuyenCan_Leave_1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 9);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(76, 22);
            label7.TabIndex = 0;
            label7.Text = "Kết thúc";
            // 
            // panel9
            // 
            panel9.Controls.Add(nmThuongXuyen);
            panel9.Controls.Add(label6);
            panel9.Location = new Point(276, 221);
            panel9.Margin = new Padding(4, 3, 4, 3);
            panel9.Name = "panel9";
            panel9.Size = new Size(272, 41);
            panel9.TabIndex = 22;
            // 
            // nmThuongXuyen
            // 
            nmThuongXuyen.DecimalPlaces = 1;
            nmThuongXuyen.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            nmThuongXuyen.Location = new Point(141, 5);
            nmThuongXuyen.Margin = new Padding(4, 3, 4, 3);
            nmThuongXuyen.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nmThuongXuyen.Name = "nmThuongXuyen";
            nmThuongXuyen.Size = new Size(121, 30);
            nmThuongXuyen.TabIndex = 1;
            nmThuongXuyen.ValueChanged += nmChuyenCan_ValueChanged_1;
            nmThuongXuyen.Leave += nmChuyenCan_Leave_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 9);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(121, 22);
            label6.TabIndex = 0;
            label6.Text = "Thường xuyên";
            // 
            // panel8
            // 
            panel8.Controls.Add(nmChuyenCan);
            panel8.Controls.Add(label5);
            panel8.Location = new Point(14, 221);
            panel8.Margin = new Padding(4, 3, 4, 3);
            panel8.Name = "panel8";
            panel8.Size = new Size(254, 41);
            panel8.TabIndex = 21;
            // 
            // nmChuyenCan
            // 
            nmChuyenCan.DecimalPlaces = 1;
            nmChuyenCan.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            nmChuyenCan.Location = new Point(120, 5);
            nmChuyenCan.Margin = new Padding(4, 3, 4, 3);
            nmChuyenCan.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nmChuyenCan.Name = "nmChuyenCan";
            nmChuyenCan.Size = new Size(121, 30);
            nmChuyenCan.TabIndex = 1;
            nmChuyenCan.ValueChanged += nmChuyenCan_ValueChanged_1;
            nmChuyenCan.Leave += nmChuyenCan_Leave_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 9);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(100, 22);
            label5.TabIndex = 0;
            label5.Text = "Chuyên cần";
            // 
            // panel7
            // 
            panel7.Controls.Add(txbMaMH);
            panel7.Controls.Add(label4);
            panel7.Location = new Point(14, 114);
            panel7.Margin = new Padding(4, 3, 4, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(534, 41);
            panel7.TabIndex = 18;
            // 
            // txbMaMH
            // 
            txbMaMH.Location = new Point(174, 6);
            txbMaMH.Name = "txbMaMH";
            txbMaMH.ReadOnly = true;
            txbMaMH.Size = new Size(350, 30);
            txbMaMH.TabIndex = 2;
            txbMaMH.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 9);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(107, 22);
            label4.TabIndex = 0;
            label4.Text = "Mã môn học";
            // 
            // panel5
            // 
            panel5.Controls.Add(txbTenSV);
            panel5.Controls.Add(lb2);
            panel5.Location = new Point(15, 64);
            panel5.Margin = new Padding(4, 3, 4, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(533, 41);
            panel5.TabIndex = 17;
            // 
            // txbTenSV
            // 
            txbTenSV.Location = new Point(172, 6);
            txbTenSV.Name = "txbTenSV";
            txbTenSV.ReadOnly = true;
            txbTenSV.Size = new Size(351, 30);
            txbTenSV.TabIndex = 1;
            txbTenSV.TabStop = false;
            // 
            // lb2
            // 
            lb2.AutoSize = true;
            lb2.Location = new Point(12, 9);
            lb2.Margin = new Padding(4, 0, 4, 0);
            lb2.Name = "lb2";
            lb2.Size = new Size(86, 22);
            lb2.TabIndex = 0;
            lb2.Text = "Họ và tên";
            // 
            // panel4
            // 
            panel4.Controls.Add(txbMaSV);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(15, 12);
            panel4.Margin = new Padding(6, 3, 6, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(533, 45);
            panel4.TabIndex = 16;
            // 
            // txbMaSV
            // 
            txbMaSV.Location = new Point(172, 7);
            txbMaSV.Name = "txbMaSV";
            txbMaSV.ReadOnly = true;
            txbMaSV.Size = new Size(351, 30);
            txbMaSV.TabIndex = 1;
            txbMaSV.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 10);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(112, 22);
            label2.TabIndex = 0;
            label2.Text = "Mã sinh viên";
            // 
            // fSua
            // 
            AcceptButton = btnSua;
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnQuayLai;
            ClientSize = new Size(562, 373);
            Controls.Add(panel2);
            Controls.Add(btnQuayLai);
            Controls.Add(btnSua);
            Controls.Add(panel1);
            Controls.Add(panel10);
            Controls.Add(panel9);
            Controls.Add(panel8);
            Controls.Add(panel7);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "fSua";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sửa điểm";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmKetThuc).EndInit();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmThuongXuyen).EndInit();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmChuyenCan).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private ComboBox cbbTenMon;
        private Label label3;
        private Button btnQuayLai;
        private Button btnSua;
        private Panel panel1;
        private TextBox txbTongKet;
        private Label label1;
        private Panel panel10;
        private NumericUpDown nmKetThuc;
        private Label label7;
        private Panel panel9;
        private NumericUpDown nmThuongXuyen;
        private Label label6;
        private Panel panel8;
        private NumericUpDown nmChuyenCan;
        private Label label5;
        private Button btnThemMon;
        private Panel panel7;
        private ComboBox cbbMaMonHoc;
        private Label label4;
        private Panel panel5;
        private Label lb2;
        private Panel panel4;
        private Label label2;
        private TextBox txbTenSV;
        private TextBox txbMaSV;
        private TextBox txbTenMH;
        private TextBox txbMaMH;
    }
}