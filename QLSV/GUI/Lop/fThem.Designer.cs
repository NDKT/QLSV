namespace QLSV.GUI.Lop
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
            panel3 = new Panel();
            txbMaLop = new TextBox();
            label1 = new Label();
            panel4 = new Panel();
            txbTenLop = new TextBox();
            label2 = new Label();
            btnThem = new Button();
            btnQuayLai = new Button();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Controls.Add(txbMaLop);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(27, 29);
            panel3.Margin = new Padding(4, 3, 4, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(424, 41);
            panel3.TabIndex = 3;
            // 
            // txbMaLop
            // 
            txbMaLop.Location = new Point(129, 6);
            txbMaLop.Margin = new Padding(4, 3, 4, 3);
            txbMaLop.MaxLength = 255;
            txbMaLop.Name = "txbMaLop";
            txbMaLop.Size = new Size(291, 30);
            txbMaLop.TabIndex = 1;
            txbMaLop.TextChanged += fThem_TextChanged;
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
            // panel4
            // 
            panel4.Controls.Add(txbTenLop);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(27, 90);
            panel4.Name = "panel4";
            panel4.Size = new Size(424, 37);
            panel4.TabIndex = 4;
            // 
            // txbTenLop
            // 
            txbTenLop.Location = new Point(129, 5);
            txbTenLop.MaxLength = 255;
            txbTenLop.Name = "txbTenLop";
            txbTenLop.Size = new Size(291, 30);
            txbTenLop.TabIndex = 1;
            txbTenLop.TextChanged += fThem_TextChanged;
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
            // btnThem
            // 
            btnThem.Enabled = false;
            btnThem.Location = new Point(246, 160);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 6;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnQuayLai
            // 
            btnQuayLai.Location = new Point(357, 160);
            btnQuayLai.Name = "btnQuayLai";
            btnQuayLai.Size = new Size(94, 29);
            btnQuayLai.TabIndex = 7;
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
            ClientSize = new Size(480, 222);
            Controls.Add(btnQuayLai);
            Controls.Add(btnThem);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "fThem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thêm lớp";
            TextChanged += fThem_TextChanged;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private TextBox txbMaLop;
        private Label label1;
        private Panel panel4;
        private TextBox txbTenLop;
        private Label label2;
        private Button btnThem;
        private Button btnQuayLai;
    }
}