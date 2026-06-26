namespace QLSV.GUI.MonHoc
{
    partial class fThemMH
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
            panel3 = new Panel();
            txbMaMH = new TextBox();
            label1 = new Label();
            panel4 = new Panel();
            txbTenMH = new TextBox();
            label2 = new Label();
            panel7 = new Panel();
            cbKieuThi = new ComboBox();
            label5 = new Label();
            panel5 = new Panel();
            nmTin = new NumericUpDown();
            label3 = new Label();
            panel6 = new Panel();
            nmSoTiet = new NumericUpDown();
            label4 = new Label();
            btnThem = new Button();
            btnQuaylai = new Button();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel7.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmTin).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmSoTiet).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Controls.Add(txbMaMH);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(13, 12);
            panel3.Margin = new Padding(4, 3, 4, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(473, 41);
            panel3.TabIndex = 2;
            // 
            // txbMaMH
            // 
            txbMaMH.Location = new Point(139, 6);
            txbMaMH.Margin = new Padding(4, 3, 4, 3);
            txbMaMH.MaxLength = 255;
            txbMaMH.Name = "txbMaMH";
            txbMaMH.Size = new Size(330, 30);
            txbMaMH.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(107, 22);
            label1.TabIndex = 0;
            label1.Text = "Mã môn học";
            // 
            // panel4
            // 
            panel4.Controls.Add(txbTenMH);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(13, 59);
            panel4.Name = "panel4";
            panel4.Size = new Size(473, 37);
            panel4.TabIndex = 3;
            // 
            // txbTenMH
            // 
            txbTenMH.Location = new Point(139, 5);
            txbTenMH.MaxLength = 255;
            txbTenMH.Name = "txbTenMH";
            txbTenMH.Size = new Size(330, 30);
            txbTenMH.TabIndex = 2;
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
            // panel7
            // 
            panel7.Controls.Add(cbKieuThi);
            panel7.Controls.Add(label5);
            panel7.Location = new Point(12, 102);
            panel7.Name = "panel7";
            panel7.Size = new Size(474, 37);
            panel7.TabIndex = 4;
            // 
            // cbKieuThi
            // 
            cbKieuThi.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbKieuThi.FormattingEnabled = true;
            cbKieuThi.Items.AddRange(new object[] { "Viết", "Vấn đáp", "Trực tuyến", "Báo cáo" });
            cbKieuThi.Location = new Point(140, 4);
            cbKieuThi.Name = "cbKieuThi";
            cbKieuThi.Size = new Size(330, 30);
            cbKieuThi.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 8);
            label5.Name = "label5";
            label5.Size = new Size(73, 22);
            label5.TabIndex = 0;
            label5.Text = "Kiểu thi";
            // 
            // panel5
            // 
            panel5.Controls.Add(nmTin);
            panel5.Controls.Add(label3);
            panel5.Location = new Point(13, 145);
            panel5.Name = "panel5";
            panel5.Size = new Size(197, 37);
            panel5.TabIndex = 5;
            // 
            // nmTin
            // 
            nmTin.Location = new Point(87, 3);
            nmTin.Name = "nmTin";
            nmTin.Size = new Size(98, 30);
            nmTin.TabIndex = 3;
            nmTin.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 8);
            label3.Name = "label3";
            label3.Size = new Size(56, 22);
            label3.TabIndex = 0;
            label3.Text = "Số tín";
            // 
            // panel6
            // 
            panel6.Controls.Add(nmSoTiet);
            panel6.Controls.Add(label4);
            panel6.Location = new Point(289, 145);
            panel6.Name = "panel6";
            panel6.Size = new Size(197, 37);
            panel6.TabIndex = 5;
            // 
            // nmSoTiet
            // 
            nmSoTiet.Location = new Point(87, 3);
            nmSoTiet.Name = "nmSoTiet";
            nmSoTiet.Size = new Size(98, 30);
            nmSoTiet.TabIndex = 3;
            nmSoTiet.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 8);
            label4.Name = "label4";
            label4.Size = new Size(61, 22);
            label4.TabIndex = 0;
            label4.Text = "Số tiết";
            // 
            // btnThem
            // 
            btnThem.Enabled = false;
            btnThem.Location = new Point(289, 203);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 6;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnQuaylai
            // 
            btnQuaylai.Location = new Point(392, 203);
            btnQuaylai.Name = "btnQuaylai";
            btnQuaylai.Size = new Size(94, 29);
            btnQuaylai.TabIndex = 7;
            btnQuaylai.Text = "Quay lại";
            btnQuaylai.UseVisualStyleBackColor = true;
            btnQuaylai.Click += btnQuaylai_Click;
            // 
            // fThem
            // 
            AcceptButton = btnThem;
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnQuaylai;
            ClientSize = new Size(505, 266);
            Controls.Add(btnQuaylai);
            Controls.Add(btnThem);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel7);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "fThem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thêm môn học";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmTin).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmSoTiet).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private TextBox txbMaMH;
        private Label label1;
        private Panel panel4;
        private TextBox txbTenMH;
        private Label label2;
        private Panel panel7;
        private ComboBox cbKieuThi;
        private Label label5;
        private Panel panel5;
        private NumericUpDown nmTin;
        private Label label3;
        private Panel panel6;
        private NumericUpDown nmSoTiet;
        private Label label4;
        private Button btnThem;
        private Button btnQuaylai;
    }
}