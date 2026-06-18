using QLSV.BLL;
using QLSV.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QLSV.GUI.SinhVien
{
    public partial class fThongTinChiTiet : Form
    {
        public fThongTinChiTiet(SinhVienDTO sv)
        {
            InitializeComponent();
            LoadSV(sv);
        }

        private void LoadSV(SinhVienDTO sv)
        {
            List<SinhVienDTO> listSV = BLL_SinhVien.Instance.TimKiem(sv);
            SinhVienDTO SV = listSV[0];
            string maLop = SV.MaLop;
            DataTable dataLop = BLL_Lop.Instance.TimKiem(maLop,"");
            txbMaSV.Text = SV.MaSV;
            txbTenSV.Text =SV.TenSV;
            txbGioiTinh.Text = SV.GioiTinh;
            txbLop.Text = dataLop.Rows[0].Field<string>("TenLop");
            txbNgaySinh.Text = SV.NgaySinh.ToString("dd/MM/yyyy");
            txbNgayNhapHoc.Text = SV.NgayNhapHoc.ToString("dd/MM/yyyy");

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
