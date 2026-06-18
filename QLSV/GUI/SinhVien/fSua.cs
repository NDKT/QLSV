using QLSV.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using QLSV;

namespace QLSV.GUI.SinhVien
{
    public partial class fSua : Form
    {
        private BindingSource data = new BindingSource();
        private DTO.SinhVienDTO sv;
        public fSua(DTO.SinhVienDTO sv)
        {
            InitializeComponent();
            Init();
            this.sv = sv;
        }

        private void Init()
        {
            data.DataSource = BLL_Lop.Instance.DanhSach();
            cbMaLop.DisplayMember = "MaLop";
            cbMaLop.DataSource = data;
            cbTenLop.DisplayMember = "TenLop";
            cbTenLop.DataSource = data;

            List<DTO.SinhVienDTO> listSV = BLL_SinhVien.Instance.TimKiem(sv);
            txbMaSV.Text = listSV[0].MaSV;
            txbHoTen.Text = listSV[0].TenSV;
            txbQueQuan.Text =listSV[0].QueQuan;
            dtpkNgaySinh.Value = listSV[0].NgaySinh;
            dtpkNgayNhapHoc.Value = listSV[0].NgayNhapHoc;
            if (listSV[0].GioiTinh == "Nam") radioButton1.Checked = true;
            else radioButton2.Checked = true;
            cbMaLop.SelectedItem = listSV[0].MaLop;
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
                if(BLL_SinhVien.Instance.Sua(sv))
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
