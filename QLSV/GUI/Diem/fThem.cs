using QLSV.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QLSV.GUI.Diem
{
    public partial class fThem : Form
    {
        private BindingSource dataMon = new BindingSource();
        private BindingSource dataSV = new BindingSource();
        public fThem()
        {
            InitializeComponent();
            DanhSachMon();
            DanhSachSV();
        }

        private void btnThemMon_Click(object sender, EventArgs e)
        {
            QLSV.GUI.MonHoc.fThem f = new QLSV.GUI.MonHoc.fThem();
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
            QLSV.GUI.SinhVien.fThem f = new SinhVien.fThem();
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

            string cc = nmChuyenCan.Value.ToString();
            string tx = nmThuongXuyen.Value.ToString();
            string kt = nmKetThuc.Value.ToString();
            try
            {
                if (BLL_Diem.Instance.Them(cbbMaSV.Text, cbbMaMonHoc.Text, cc, tx, kt))
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
