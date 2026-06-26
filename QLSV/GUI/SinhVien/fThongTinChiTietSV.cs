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
    public partial class fThongTinChiTietSV : Form
    {
        public fThongTinChiTietSV(SinhVienDTO sv)
        {
            InitializeComponent();
            LoadSV(sv);
        }

        private void LoadSV(SinhVienDTO sv)
        {
            List<SinhVienDTO> listSV = BLL_SinhVien.Instance.TimKiem(sv.MaSV, sv.TenSV);
            SinhVienDTO SV = listSV[0];
            string maLop = SV.MaLop;
            LopDTO dataLop = BLL_Lop.Instance.TimKiem(maLop,"")[0];
            txbMaSV.Text = SV.MaSV;
            txbTenSV.Text =SV.TenSV;
            txbGioiTinh.Text = SV.GioiTinh;
            txbLop.Text = dataLop.TenLop;
            txbNgaySinh.Text = SV.NgaySinh.ToString("dd/MM/yyyy");
            txbNgayNhapHoc.Text = SV.NgayNhapHoc.ToString("dd/MM/yyyy");

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
