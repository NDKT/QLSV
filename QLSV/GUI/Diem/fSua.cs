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
    public partial class fSua : Form
    {
        private string maSV = string.Empty;
        private string maMH = string.Empty;
        public fSua(string maSV, string maMH)
        {
            InitializeComponent();
            this.maMH = maMH;
            this.maSV = maSV;
            LayDiem();
        }

        private void LayDiem()
        {
            DataTable data = BLL_Diem.Instance.TraDiem(maSV, maMH);
            txbMaSV.Text = data.Rows[0].Field<string>("MaSV");
            txbTenSV.Text = data.Rows[0].Field<string>("TenSv");
            txbMaMH.Text = data.Rows[0].Field<string>("MaMH");
            txbTenMH.Text = data.Rows[0].Field<string>("TenMH");
            nmChuyenCan.Value = (decimal)data.Rows[0].Field<double>("ChuyenCan");
            nmThuongXuyen.Value = (decimal)data.Rows[0].Field<double>("ThuongXuyen");
            nmKetThuc.Value = (decimal)data.Rows[0].Field<double>("KetThuc");
            txbTongKet.Text = data.Rows[0].Field<double>("TongKet").ToString("F4");
        }


        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string cc = nmChuyenCan.Value.ToString();
            string tx = nmThuongXuyen.Value.ToString();
            string kt = nmKetThuc.Value.ToString();
            try
            {
               if (BLL_Diem.Instance.Sua(this.maSV, this.maMH, cc, tx, kt))
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
