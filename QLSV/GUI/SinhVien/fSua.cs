using QLSV.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace QLSV.GUI.SinhVien
{
    public partial class fSua : Form
    {
        private string maSV = string.Empty;
        private BindingSource data = new BindingSource();
        public fSua(string maSV)
        {
            InitializeComponent();
            this.maSV = maSV;
            Init();
        }

        private void Init()
        {
            data.DataSource = BLL_Lop.Instance.DanhSach();
            cbMaLop.DisplayMember = "MaLop";
            cbMaLop.DataSource = data;
            cbTenLop.DisplayMember = "TenLop";
            cbTenLop.DataSource = data;

            DataTable dtSV = BLL_SinhVien.Instance.TimKiem(maSV, "");
            txbMaSV.Text = dtSV.Rows[0].Field<string>("MaSV");
            txbHoTen.Text = dtSV.Rows[0].Field<string>("TenSV");
            txbQueQuan.Text = dtSV.Rows[0].Field<string>("QueQuan");
            dtpkNgaySinh.Value = dtSV.Rows[0].Field<DateTime>("NgaySinh");
            dtpkNgayNhapHoc.Value = dtSV.Rows[0].Field<DateTime>("NgayNhapHoc");
            if (dtSV.Rows[0]["GioiTinh"].ToString() == "Nam") radioButton1.Checked = true;
            else radioButton2.Checked = true;
            cbMaLop.SelectedItem = dtSV.Rows[0].Field<string>("MaLop")!;
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (cbMaLop.SelectedIndex == -1 || cbTenLop.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn lớp", "Thông báo");
                return;
            }
            string maSV = txbMaSV.Text;
            string hoTen = txbHoTen.Text;
            string maLop = cbMaLop.Text;
            string tenLop = cbTenLop.Text;
            string gioiTinh = radioButton1.Checked == true ? "Nam" : "Nữ";
            string que = txbQueQuan.Text;
            DateTime ngaySinh = dtpkNgaySinh.Value;
            DateTime ngayNhapHoc = dtpkNgayNhapHoc.Value;
            try
            {
                if(BLL_SinhVien.Instance.Sua(maSV, hoTen, maLop, que, gioiTinh, ngaySinh, ngayNhapHoc))
                {
                    MessageBox.Show("Sửa thành công", "Thông báo");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
