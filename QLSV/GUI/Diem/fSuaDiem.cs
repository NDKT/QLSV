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
    public partial class fSuaDiem : Form
    {
        private DiemDTO diem;
        public fSuaDiem(DiemDTO diem)
        {
            this.diem = diem;
            InitializeComponent();
            LayDiem();
        }

        private void LayDiem()
        {
            txbMaSV.Text = diem.MaSV;
            txbTenSV.Text = diem.TenSV;
            txbMaMH.Text = diem.MaMH;
            txbTenMH.Text = diem.TenMH;
            nmChuyenCan.Value = (decimal)diem.ChuyenCan;
            nmThuongXuyen.Value = (decimal)diem.ThuongXuyen;
            nmKetThuc.Value = (decimal)diem.KetThuc;
            txbTongKet.Text = diem.TongKet.ToString("F4");
        }


        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            diem.ChuyenCan = (double)nmChuyenCan.Value;
            diem.ThuongXuyen = (double)nmThuongXuyen.Value;
            diem.KetThuc = (double)nmKetThuc.Value;
            try
            {
               if (BLL_Diem.Instance.Sua(diem))
                {
                    MessageBox.Show("Sửa thành công", "Thông báo");
                    this.Close();
                }

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void nmChuyenCan_ValueChanged_1(object sender, EventArgs e)
        {
            double cc = ((double)nmChuyenCan.Value);
            double tx = ((double)nmThuongXuyen.Value);
            double kt = ((double)nmKetThuc.Value);
            double tk = (cc * 0.1) + (tx * 0.3) + (kt * 0.6);
            txbTongKet.Text = tk.ToString("F4");
        }

        private void nmChuyenCan_Leave_1(object sender, EventArgs e)
        {
            NumericUpDown? nm = sender as NumericUpDown;
            if (nm == null) return;
            nm.Value = Math.Round(nm.Value * 2, MidpointRounding.AwayFromZero) / 2m;
        }
    }
}
