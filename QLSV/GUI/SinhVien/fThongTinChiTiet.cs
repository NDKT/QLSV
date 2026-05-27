using QLSV.BLL;
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
        public fThongTinChiTiet(string maSV)
        {
            InitializeComponent();
            LoadSV(maSV);
        }

        private void LoadSV(string maSV)
        {
            DataTable dataSV = BLL_SinhVien.Instance.TimKiem(maSV, "");
            string maLop = dataSV.Rows[0].Field<string>("MaLop")!;
            DataTable dataLop = BLL_Lop.Instance.TimKiem(maLop,"");
            txbMaSV.Text = dataSV.Rows[0].Field<string>("MaSV");
            txbTenSV.Text = dataSV.Rows[0].Field<string>("TenSV");
            txbGioiTinh.Text = dataSV.Rows[0].Field<string>("GioiTinh");
            txbLop.Text = dataLop.Rows[0].Field<string>("TenLop");
            txbNgaySinh.Text = dataSV.Rows[0].Field<DateTime>("NgaySinh").ToString("dd/MM/yyyy");
            txbNgayNhapHoc.Text = dataSV.Rows[0].Field<DateTime>("NgayNhapHoc").ToString("dd/MM/yyyy");

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
