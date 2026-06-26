namespace QLSV.GUI.Lop
{
    partial class fSuaLop
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
            txbTenLop = new TextBox();
            label2 = new Label();
            panel3 = new Panel();
            txbMaLop = new TextBox();
            label1 = new Label();
            btnSua = new Button();
            btnQuayLai = new Button();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.Controls.Add(txbTenLop);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(13, 69);
            panel4.Margin = new Padding(4, 3, 4, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(437, 41);
            panel4.TabIndex = 4;
            // 
            // txbTenLop
            // 
            txbTenLop.Location = new Point(129, 6);
            txbTenLop.Margin = new Padding(4, 3, 4, 3);
            txbTenLop.MaxLength = 255;
            txbTenLop.Name = "txbTenLop";
            txbTenLop.Size = new Size(304, 30);
            txbTenLop.TabIndex = 1;
            txbTenLop.TextChanged += txbTenLop_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 9);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(72, 22);
            label2.TabIndex = 0;
            label2.Text = "Tên lớp";
            // 
            // panel3
            // 
            panel3.Controls.Add(txbMaLop);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(13, 12);
            panel3.Margin = new Padding(4, 3, 4, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(437, 41);
            panel3.TabIndex = 3;
            // 
            // txbMaLop
            // 
            txbMaLop.Location = new Point(129, 6);
            txbMaLop.Margin = new Padding(4, 3, 4, 3);
            txbMaLop.MaxLength = 255;
            txbMaLop.Name = "txbMaLop";
            txbMaLop.ReadOnly = true;
            txbMaLop.Size = new Size(304, 30);
            txbMaLop.TabIndex = 1;
            txbMaLop.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(68, 22);
            label1.TabIndex = 0;
            label1.Text = "Mã lớp";
            // 
            // btnSua
            // 
            btnSua.Location = new Point(256, 130);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 8;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnQuayLai
            // 
            btnQuayLai.Location = new Point(356, 130);
            btnQuayLai.Name = "btnQuayLai";
            btnQuayLai.Size = new Size(94, 29);
            btnQuayLai.TabIndex = 9;
            btnQuayLai.Text = "Quay Lại";
            btnQuayLai.UseVisualStyleBackColor = true;
            btnQuayLai.Click += btnQuayLai_Click;
            // 
            // fSua
            // 
            AcceptButton = btnSua;
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnQuayLai;
            ClientSize = new Size(470, 195);
            Controls.Add(btnQuayLai);
            Controls.Add(btnSua);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "fSua";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sửa thông tin lớp";
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel4;
        private TextBox txbTenLop;
        private Label label2;
        private Panel panel3;
        private TextBox txbMaLop;
        private Label label1;
        private Button btnSua;
        private Button btnQuayLai;
    }
}