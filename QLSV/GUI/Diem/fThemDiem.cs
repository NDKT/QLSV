using QLSV.BLL;
using QLSV.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QLSV.GUI.Diem
{
    public partial class fThemDiem : Form
    {
        private BindingSource dataMon = new BindingSource();
        private BindingSource dataSV = new BindingSource();
        public fThemDiem()
        {
            InitializeComponent();
            DanhSachMon();
            DanhSachSV();
        }

        private void btnThemMon_Click(object sender, EventArgs e)
        {
            QLSV.GUI.MonHoc.fThemMH f = new QLSV.GUI.MonHoc.fThemMH();
            f.ShowDialog();
            DanhSachMon();
        }
        private void DanhSachMon()
        {
            dataMon.DataSource = BLL_MonHoc.Instance.DanhSach();
            cbbMaMonHoc.DisplayMember = "MaMH";
            cbbMaMonHoc.DataSource = dataMon;
            cbbTenMon.DisplayMember = "TenMH";
            cbbTenMon.DataSource = dataMon;
            cbbMaMonHoc.SelectedIndex = 0;
        }


        private void DanhSachSV()
        {
            dataSV.DataSource = BLL_SinhVien.Instance.DanhSach();
            cbbTenSV.DisplayMember = "TenSV";
            cbbTenSV.DataSource = dataSV;
            cbbMaSV.DisplayMember = "MaSV";
            cbbMaSV.DataSource = dataSV;
            cbbMaSV.SelectedIndex = 0;
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nmKetThuc_ValueChanged(object sender, EventArgs e)
        {
            double cc = ((double)nmChuyenCan.Value);
            double tx = ((double)nmThuongXuyen.Value);
            double kt = ((double)nmKetThuc.Value);
            double tk = (cc * 0.1) + (tx * 0.3) + (kt * 0.6);
            txbTongKet.Text = tk.ToString("F4");
        }


        private void nmChuyenCan_Leave(object sender, EventArgs e)
        {
            NumericUpDown? nm = sender as NumericUpDown;
            if (nm == null) return;
            nm.Value = Math.Round(nm.Value * 2, MidpointRounding.AwayFromZero) / 2m;
        }

        private void btnThemSV_Click(object sender, EventArgs e)
        {
            QLSV.GUI.SinhVien.fThemSV f = new SinhVien.fThemSV();
            f.ShowDialog();
            DanhSachSV();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(cbbMaSV.SelectedIndex == -1 || cbbTenSV.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(cbbMaMonHoc.SelectedIndex == -1 || cbbTenMon.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn Môn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DiemDTO diemSV = new DiemDTO()
            {
                ChuyenCan = (double)nmChuyenCan.Value,
                ThuongXuyen = (double)nmThuongXuyen.Value,
                KetThuc = (double)nmKetThuc.Value,
                MaSV = cbbMaSV.Text,
                MaMH = cbbMaMonHoc.Text
            };

            try
            {
                if (BLL_Diem.Instance.Them(diemSV))
                {
                    MessageBox.Show("Thêm thành công", "Thông báo");
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
