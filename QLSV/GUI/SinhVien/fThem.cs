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
            ngaySinh = dtpkNgaySinh.Value;
            ngayNhapHoc = dtpkNgayNhapHoc.Value;
            maSV = txbMaSV.Text;
            hoTen = txbHoTen.Text;
            maLop = cbMaLop.Text;
            que = txbQueQuan.Text;
            gioiTinh = radioButton1.Checked ? "Nam" : "Nữ";
            try
            {
                if(BLL_SinhVien.Instance.Them(maSV, hoTen, maLop, que, gioiTinh, ngaySinh, ngayNhapHoc))
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
