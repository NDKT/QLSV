namespace QLSV.GUI.SinhVien
{
    partial class fSuaSV
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
            cbTenLop = new ComboBox();
            label7 = new Label();
            panel7 = new Panel();
            cbMaLop = new ComboBox();
            label4 = new Label();
            btnQuayLai = new Button();
            btnSua = new Button();
            panel6 = new Panel();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label3 = new Label();
            panel9 = new Panel();
            txbQueQuan = new TextBox();
            label6 = new Label();
            panel8 = new Panel();
            dtpkNgayNhapHoc = new DateTimePicker();
            label5 = new Label();
            panel5 = new Panel();
            dtpkNgaySinh = new DateTimePicker();
            label2 = new Label();
            panel4 = new Panel();
            txbHoTen = new TextBox();
            lb2 = new Label();
            panel3 = new Panel();
            txbMaSV = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(cbTenLop);
            panel1.Controls.Add(label7);
            panel1.Location = new Point(13, 146);
            panel1.Name = "panel1";
            panel1.Size = new Size(494, 37);
            panel1.TabIndex = 12;
            // 
            // cbTenLop
            // 
            cbTenLop.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbTenLop.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbTenLop.FormattingEnabled = true;
            cbTenLop.Location = new Point(144, 3);
            cbTenLop.Name = "cbTenLop";
            cbTenLop.Size = new Size(338, 30);
            cbTenLop.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(9, 8);
            label7.Name = "label7";
            label7.Size = new Size(72, 22);
            label7.TabIndex = 0;
            label7.Text = "Tên lớp";
            // 
            // panel7
            // 
            panel7.Controls.Add(cbMaLop);
            panel7.Controls.Add(label4);
            panel7.Location = new Point(13, 103);
            panel7.Name = "panel7";
            panel7.Size = new Size(494, 37);
            panel7.TabIndex = 19;
            // 
            // cbMaLop
            // 
            cbMaLop.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbMaLop.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbMaLop.FormattingEnabled = true;
            cbMaLop.Location = new Point(142, 3);
            cbMaLop.Name = "cbMaLop";
            cbMaLop.Size = new Size(340, 30);
            cbMaLop.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 8);
            label4.Name = "label4";
            label4.Size = new Size(68, 22);
            label4.TabIndex = 0;
            label4.Text = "Mã lớp";
            // 
            // btnQuayLai
            // 
            btnQuayLai.Location = new Point(415, 384);
            btnQuayLai.Name = "btnQuayLai";
            btnQuayLai.Size = new Size(94, 29);
            btnQuayLai.TabIndex = 18;
            btnQuayLai.Text = "Quay lại";
            btnQuayLai.UseVisualStyleBackColor = true;
            btnQuayLai.Click += btnQuayLai_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(305, 384);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 16;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(radioButton2);
            panel6.Controls.Add(radioButton1);
            panel6.Controls.Add(label3);
            panel6.Location = new Point(173, 328);
            panel6.Name = "panel6";
            panel6.Size = new Size(332, 37);
            panel6.TabIndex = 13;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(226, 6);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(56, 26);
            radioButton2.TabIndex = 2;
            radioButton2.Text = "Nữ";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(143, 6);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(68, 26);
            radioButton1.TabIndex = 1;
            radioButton1.TabStop = true;
            radioButton1.Text = "Nam";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 8);
            label3.Name = "label3";
            label3.Size = new Size(81, 22);
            label3.TabIndex = 0;
            label3.Text = "Giới tính";
            // 
            // panel9
            // 
            panel9.Controls.Add(txbQueQuan);
            panel9.Controls.Add(label6);
            panel9.Location = new Point(174, 285);
            panel9.Name = "panel9";
            panel9.Size = new Size(331, 37);
            panel9.TabIndex = 17;
            // 
            // txbQueQuan
            // 
            txbQueQuan.Location = new Point(140, 3);
            txbQueQuan.MaxLength = 255;
            txbQueQuan.Name = "txbQueQuan";
            txbQueQuan.Size = new Size(179, 30);
            txbQueQuan.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 8);
            label6.Name = "label6";
            label6.Size = new Size(84, 22);
            label6.TabIndex = 0;
            label6.Text = "Quê quán";
            // 
            // panel8
            // 
            panel8.Controls.Add(dtpkNgayNhapHoc);
            panel8.Controls.Add(label5);
            panel8.Location = new Point(173, 242);
            panel8.Name = "panel8";
            panel8.Size = new Size(332, 37);
            panel8.TabIndex = 15;
            // 
            // dtpkNgayNhapHoc
            // 
            dtpkNgayNhapHoc.CustomFormat = "dd/MM/yyyy";
            dtpkNgayNhapHoc.Format = DateTimePickerFormat.Custom;
            dtpkNgayNhapHoc.Location = new Point(141, 4);
            dtpkNgayNhapHoc.Name = "dtpkNgayNhapHoc";
            dtpkNgayNhapHoc.Size = new Size(179, 30);
            dtpkNgayNhapHoc.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 8);
            label5.Name = "label5";
            label5.Size = new Size(126, 22);
            label5.TabIndex = 0;
            label5.Text = "Ngày nhập học";
            // 
            // panel5
            // 
            panel5.Controls.Add(dtpkNgaySinh);
            panel5.Controls.Add(label2);
            panel5.Location = new Point(174, 199);
            panel5.Name = "panel5";
            panel5.Size = new Size(331, 37);
            panel5.TabIndex = 14;
            // 
            // dtpkNgaySinh
            // 
            dtpkNgaySinh.CustomFormat = "dd/MM/yyyy";
            dtpkNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpkNgaySinh.Location = new Point(140, 2);
            dtpkNgaySinh.Name = "dtpkNgaySinh";
            dtpkNgaySinh.Size = new Size(179, 30);
            dtpkNgaySinh.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 8);
            label2.Name = "label2";
            label2.Size = new Size(88, 22);
            label2.TabIndex = 0;
            label2.Text = "Ngày sinh";
            // 
            // panel4
            // 
            panel4.Controls.Add(txbHoTen);
            panel4.Controls.Add(lb2);
            panel4.Location = new Point(13, 59);
            panel4.Name = "panel4";
            panel4.Size = new Size(494, 37);
            panel4.TabIndex = 11;
            // 
            // txbHoTen
            // 
            txbHoTen.Location = new Point(142, 3);
            txbHoTen.MaxLength = 255;
            txbHoTen.Name = "txbHoTen";
            txbHoTen.Size = new Size(340, 30);
            txbHoTen.TabIndex = 1;
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
            panel3.Location = new Point(13, 12);
            panel3.Margin = new Padding(4, 3, 4, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(494, 41);
            panel3.TabIndex = 10;
            // 
            // txbMaSV
            // 
            txbMaSV.Location = new Point(142, 6);
            txbMaSV.Margin = new Padding(4, 3, 4, 3);
            txbMaSV.MaxLength = 255;
            txbMaSV.Name = "txbMaSV";
            txbMaSV.ReadOnly = true;
            txbMaSV.Size = new Size(340, 30);
            txbMaSV.TabIndex = 1;
            txbMaSV.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(112, 22);
            label1.TabIndex = 0;
            label1.Text = "Mã sinh viên";
            // 
            // fSua
            // 
            AcceptButton = btnSua;
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnQuayLai;
            ClientSize = new Size(528, 443);
            Controls.Add(panel1);
            Controls.Add(panel7);
            Controls.Add(btnQuayLai);
            Controls.Add(btnSua);
            Controls.Add(panel6);
            Controls.Add(panel9);
            Controls.Add(panel8);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "fSua";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sửa thông tin sinh viên";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComboBox cbTenLop;
        private Label label7;
        private Panel panel7;
        private ComboBox cbMaLop;
        private Label label4;
        private Button btnQuayLai;
        private Button btnSua;
        private Panel panel6;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label3;
        private Panel panel9;
        private TextBox txbQueQuan;
        private Label label6;
        private Panel panel8;
        private DateTimePicker dtpkNgayNhapHoc;
        private Label label5;
        private Panel panel5;
        private DateTimePicker dtpkNgaySinh;
        private Label label2;
        private Panel panel4;
        private TextBox txbHoTen;
        private Label lb2;
        private Panel panel3;
        private TextBox txbMaSV;
        private Label label1;
    }
}