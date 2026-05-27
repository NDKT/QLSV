namespace QLSV.GUI.TaiKhoan
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
            txbTenDangNhap = new TextBox();
            label2 = new Label();
            panel5 = new Panel();
            txbMatKhau = new TextBox();
            label3 = new Label();
            panel1 = new Panel();
            txbMatKhau2 = new TextBox();
            label1 = new Label();
            btnThem = new Button();
            btnQuayLai = new Button();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.Controls.Add(txbTenDangNhap);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(12, 12);
            panel4.Name = "panel4";
            panel4.Size = new Size(362, 37);
            panel4.TabIndex = 11;
            // 
            // txbTenDangNhap
            // 
            txbTenDangNhap.Location = new Point(179, 3);
            txbTenDangNhap.MaxLength = 255;
            txbTenDangNhap.Name = "txbTenDangNhap";
            txbTenDangNhap.Size = new Size(180, 30);
            txbTenDangNhap.TabIndex = 1;
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
            // panel5
            // 
            panel5.Controls.Add(txbMatKhau);
            panel5.Controls.Add(label3);
            panel5.Location = new Point(12, 55);
            panel5.Name = "panel5";
            panel5.Size = new Size(362, 37);
            panel5.TabIndex = 12;
            // 
            // txbMatKhau
            // 
            txbMatKhau.Location = new Point(179, 3);
            txbMatKhau.MaxLength = 255;
            txbMatKhau.Name = "txbMatKhau";
            txbMatKhau.Size = new Size(180, 30);
            txbMatKhau.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 7);
            label3.Name = "label3";
            label3.Size = new Size(82, 22);
            label3.TabIndex = 0;
            label3.Text = "Mật khẩu";
            // 
            // panel1
            // 
            panel1.Controls.Add(txbMatKhau2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 98);
            panel1.Name = "panel1";
            panel1.Size = new Size(362, 37);
            panel1.TabIndex = 13;
            // 
            // txbMatKhau2
            // 
            txbMatKhau2.Location = new Point(179, 3);
            txbMatKhau2.MaxLength = 255;
            txbMatKhau2.Name = "txbMatKhau2";
            txbMatKhau2.Size = new Size(180, 30);
            txbMatKhau2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 7);
            label1.Name = "label1";
            label1.Size = new Size(152, 22);
            label1.TabIndex = 0;
            label1.Text = "Nhập lại mật khẩu";
            // 
            // btnThem
            // 
            btnThem.Enabled = false;
            btnThem.Location = new Point(182, 151);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 14;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnQuayLai
            // 
            btnQuayLai.Location = new Point(282, 151);
            btnQuayLai.Name = "btnQuayLai";
            btnQuayLai.Size = new Size(94, 29);
            btnQuayLai.TabIndex = 15;
            btnQuayLai.Text = "Quay lại";
            btnQuayLai.UseVisualStyleBackColor = true;
            btnQuayLai.Click += btnQuayLai_Click;
            // 
            // fThem
            // 
            AcceptButton = btnThem;
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnQuayLai;
            ClientSize = new Size(388, 219);
            Controls.Add(btnQuayLai);
            Controls.Add(btnThem);
            Controls.Add(panel1);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "fThem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thêm tài khoản";
            Load += fThem_Load;
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel4;
        private TextBox txbTenDangNhap;
        private Label label2;
        private Panel panel5;
        private TextBox txbMatKhau;
        private Label label3;
        private Panel panel1;
        private TextBox txbMatKhau2;
        private Label label1;
        private Button btnThem;
        private Button btnQuayLai;
    }
}