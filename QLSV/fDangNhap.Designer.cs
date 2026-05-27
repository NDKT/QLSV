namespace QLSV
{
    partial class fDangNhap
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            label1 = new Label();
            panel1 = new Panel();
            txbTenDangNhap = new TextBox();
            panel2 = new Panel();
            txbMatKhau = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(165, 191);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(129, 32);
            button1.TabIndex = 0;
            button1.Text = "Đăng nhập";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 14);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(124, 22);
            label1.TabIndex = 1;
            label1.Text = "Tên đăng nhập";
            // 
            // panel1
            // 
            panel1.Controls.Add(txbTenDangNhap);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(13, 40);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(440, 52);
            panel1.TabIndex = 2;
            // 
            // txbTenDangNhap
            // 
            txbTenDangNhap.Location = new Point(169, 10);
            txbTenDangNhap.Margin = new Padding(4);
            txbTenDangNhap.Name = "txbTenDangNhap";
            txbTenDangNhap.Size = new Size(252, 30);
            txbTenDangNhap.TabIndex = 0;
            txbTenDangNhap.Text = "trung10";
            // 
            // panel2
            // 
            panel2.Controls.Add(txbMatKhau);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(13, 100);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(440, 52);
            panel2.TabIndex = 3;
            // 
            // txbMatKhau
            // 
            txbMatKhau.Location = new Point(169, 10);
            txbMatKhau.Margin = new Padding(4);
            txbMatKhau.Name = "txbMatKhau";
            txbMatKhau.Size = new Size(252, 30);
            txbMatKhau.TabIndex = 0;
            txbMatKhau.Text = "1234567";
            txbMatKhau.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 14);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(82, 22);
            label2.TabIndex = 1;
            label2.Text = "Mật khẩu";
            // 
            // fDangNhap
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(481, 268);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(button1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "fDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Label label1;
        private Panel panel1;
        private TextBox txbTenDangNhap;
        private Panel panel2;
        private TextBox txbMatKhau;
        private Label label2;
    }
}
