namespace QLSV
{
    partial class fThongTinTK
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
            txbTenDangNhap = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            txbMatKhau = new TextBox();
            label2 = new Label();
            btnClose = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txbTenDangNhap);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(15, 13);
            panel1.Margin = new Padding(6, 4, 6, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(605, 57);
            panel1.TabIndex = 3;
            // 
            // txbTenDangNhap
            // 
            txbTenDangNhap.Location = new Point(232, 11);
            txbTenDangNhap.Margin = new Padding(6, 4, 6, 4);
            txbTenDangNhap.Name = "txbTenDangNhap";
            txbTenDangNhap.ReadOnly = true;
            txbTenDangNhap.Size = new Size(345, 30);
            txbTenDangNhap.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 15);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(124, 22);
            label1.TabIndex = 1;
            label1.Text = "Tên đăng nhập";
            // 
            // panel2
            // 
            panel2.Controls.Add(txbMatKhau);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(15, 78);
            panel2.Margin = new Padding(6, 4, 6, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(605, 57);
            panel2.TabIndex = 4;
            // 
            // txbMatKhau
            // 
            txbMatKhau.Location = new Point(232, 11);
            txbMatKhau.Margin = new Padding(6, 4, 6, 4);
            txbMatKhau.Name = "txbMatKhau";
            txbMatKhau.ReadOnly = true;
            txbMatKhau.Size = new Size(345, 30);
            txbMatKhau.TabIndex = 0;
            txbMatKhau.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 15);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(82, 22);
            label2.TabIndex = 1;
            label2.Text = "Mật khẩu";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(271, 152);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 5;
            btnClose.Text = "Đóng";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // fThongTinTK
            // 
            AcceptButton = btnClose;
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new Size(640, 206);
            Controls.Add(btnClose);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "fThongTinTK";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thông tin tài khoản";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txbTenDangNhap;
        private Label label1;
        private Panel panel2;
        private TextBox txbMatKhau;
        private Label label2;
        private Button btnClose;
    }
}