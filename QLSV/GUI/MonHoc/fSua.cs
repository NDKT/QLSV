using QLSV.BLL;
using QLSV.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QLSV.GUI.MonHoc
{
    public partial class fSua : Form
    {
        public fSua(string maMH, string tenMH, decimal soTin, decimal soTiet, string kieuThi)
        {
            InitializeComponent();
            btnSua.Enabled = true;
            txbTenMH.Text = tenMH;
            txbMaMH.Text = maMH;
            cbKieuThi.SelectedItem = kieuThi;
            nmSoTiet.Value = soTiet;
            nmTin.Value = soTin;
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string kieuThi = cbKieuThi.SelectedItem?.ToString() ?? "";
            try
            {
                if (BLL_MonHoc.Instance.Sua(txbMaMH.Text, txbTenMH.Text, kieuThi, nmTin.Value.ToString(), nmSoTiet.Value.ToString()))
                {
                    MessageBox.Show("Cập nhật thành công", "Thông báo");
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
