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
    public partial class fSuaSV : Form
    {
        private BindingSource data = new BindingSource();
        private DTO.SinhVienDTO sv;
        public fSuaSV(DTO.SinhVienDTO sv)
        {
            this.sv = sv;

            InitializeComponent();
            Init();
        }

        private void Init()
        {
            data.DataSource = BLL_Lop.Instance.DanhSach();
            cbMaLop.DisplayMember = "MaLop";
            cbMaLop.DataSource = data;
            cbTenLop.DisplayMember = "TenLop";
            cbTenLop.DataSource = data;

            txbMaSV.Text = sv.MaSV;
            txbHoTen.Text = sv.TenSV;
            txbQueQuan.Text =sv.QueQuan;
            dtpkNgaySinh.Value = sv.NgaySinh;
            dtpkNgayNhapHoc.Value = sv.NgayNhapHoc;
            if (sv.GioiTinh == "Nam") radioButton1.Checked = true;
            else radioButton2.Checked = true;
            cbMaLop.SelectedItem = sv.MaLop;
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
            sv.TenSV = txbHoTen.Text;
            sv.MaLop = cbMaLop.Text;
            sv.GioiTinh = radioButton1.Checked == true ? "Nam" : "Nữ";
            sv.QueQuan = txbQueQuan.Text;
            sv.NgaySinh = dtpkNgaySinh.Value;
            sv.NgayNhapHoc = dtpkNgayNhapHoc.Value;
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
