using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QLSV
{
    public partial class fThongTinTK : Form
    {
        public fThongTinTK()
        {
            InitializeComponent();
            txbTenDangNhap.Text = QLSV.NguoiDung.TenDangNhap;
            txbMatKhau.Text = QLSV.NguoiDung.MatKhau;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
