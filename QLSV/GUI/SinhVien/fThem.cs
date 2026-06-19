using QLSV.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QLSV.GUI;
using QLSV.BLL;
using QLSV.DTO;

namespace QLSV.GUI.SinhVien
{
    public partial class fThem : Form
    {
        private DateTime ngaySinh;
        private DateTime ngayNhapHoc;
        private string maSV = string.Empty;
        private string hoTen = string.Empty;
        private string maLop = string.Empty;
        private string que = string.Empty;
        private string gioiTinh = string.Empty;
        private BindingSource data = new BindingSource();
        public fThem()
        {
            InitializeComponent();
            LoadCb();
            FormHelper.BatTatNut(btnThem, txbHoTen, txbMaSV, txbQueQuan);
        }


        private void LoadCb()
        {
            data.DataSource = BLL.BLL_Lop.Instance.DanhSach();
            cbMaLop.DisplayMember = "MaLop";
            cbMaLop.DataSource = data;
            cbTenLop.DisplayMember = "TenLop";
            cbTenLop.DataSource = data;
        }
        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThemLop_Click(object sender, EventArgs e)
        {
            Lop.fThem f = new Lop.fThem();
            f.ShowDialog();
            LoadCb();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(cbMaLop.SelectedIndex == -1 || cbTenLop.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn lớp", "Thông báo");
                return;
            }
            SinhVienDTO svMoi = new SinhVienDTO()
            {
                NgaySinh = dtpkNgaySinh.Value,
                NgayNhapHoc = dtpkNgayNhapHoc.Value,
                MaSV = txbMaSV.Text,
                TenSV = txbHoTen.Text,
                MaLop = cbMaLop.Text,
                QueQuan = txbQueQuan.Text,
                GioiTinh = radioButton1.Checked ? "Nam" : "Nữ"
            };
            try
            {
                if(BLL_SinhVien.Instance.Them(svMoi))
                {
                    MessageBox.Show("Thêm sinh viên thành công!", "Thông báo");
                    this.Close();
                }

            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
