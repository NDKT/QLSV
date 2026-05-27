namespace QLSV.GUI.TaiKhoan
{
    partial class fSua
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
            txbID = new TextBox();
            label1 = new Label();
            panel4 = new Panel();
            txbTenDangNhap = new TextBox();
            label2 = new Label();
            panel5 = new Panel();
            txbMatKhau = new TextBox();
            label3 = new Label();
            btnQuayLai = new Button();
            btnSua = new Button();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Controls.Add(txbID);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(13, 12);
            panel3.Margin = new Padding(4, 3, 4, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(463, 41);
            panel3.TabIndex = 10;
            // 
            // txbID
            // 
            txbID.Location = new Point(139, 3);
            txbID.Margin = new Padding(4, 3, 4, 3);
            txbID.MaxLength = 255;
            txbID.Name = "txbID";
            txbID.ReadOnly = true;
            txbID.Size = new Size(320, 30);
            txbID.TabIndex = 1;
            txbID.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 8);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(30, 22);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // panel4
            // 
            panel4.Controls.Add(txbTenDangNhap);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(13, 68);
            panel4.Name = "panel4";
            panel4.Size = new Size(463, 37);
            panel4.TabIndex = 11;
            // 
            // txbTenDangNhap
            // 
            txbTenDangNhap.Location = new Point(139, 3);
            txbTenDangNhap.MaxLength = 255;
            txbTenDangNhap.Name = "txbTenDangNhap";
            txbTenDangNhap.ReadOnly = true;
            txbTenDangNhap.Size = new Size(321, 30);
            txbTenDangNhap.TabIndex = 1;
            txbTenDangNhap.TabStop = false;
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
            panel5.Location = new Point(13, 121);
            panel5.Name = "panel5";
            panel5.Size = new Size(463, 37);
            panel5.TabIndex = 12;
            // 
            // txbMatKhau
            // 
            txbMatKhau.Location = new Point(139, 3);
            txbMatKhau.MaxLength = 255;
            txbMatKhau.Name = "txbMatKhau";
            txbMatKhau.Size = new Size(320, 30);
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
            // btnQuayLai
            // 
            btnQuayLai.Location = new Point(382, 185);
            btnQuayLai.Name = "btnQuayLai";
            btnQuayLai.Size = new Size(94, 29);
            btnQuayLai.TabIndex = 16;
            btnQuayLai.TabStop = false;
            btnQuayLai.Text = "Quay lại";
            btnQuayLai.UseVisualStyleBackColor = true;
            btnQuayLai.Click += btnQuayLai_Click;
            // 
            // btnSua
            // 
            btnSua.Enabled = false;
            btnSua.Location = new Point(282, 185);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 17;
            btnSua.TabStop = false;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // fSua
            // 
            AcceptButton = btnSua;
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnQuayLai;
            ClientSize = new Size(502, 264);
            Controls.Add(btnSua);
            Controls.Add(btnQuayLai);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "fSua";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sửa thông tin";
            Load += fSua_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private TextBox txbID;
        private Label label1;
        private Panel panel4;
        private TextBox txbTenDangNhap;
        private Label label2;
        private Panel panel5;
        private TextBox txbMatKhau;
        private Label label3;
        private Button btnQuayLai;
        private Button btnSua;
    }
}