using QLSV.BLL;
using QLSV.DTO;
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
    public partial class fSuaMH : Form
    {
        MonHocDTO mon = new MonHocDTO();
        public fSuaMH(MonHocDTO mon)
        {
            this.mon = mon;
            InitializeComponent();
            btnSua.Enabled = true;
            txbTenMH.Text = mon.TenMH;
            txbMaMH.Text = mon.MaMH;
            cbKieuThi.SelectedItem = mon.KieuThi;
            nmSoTiet.Value = mon.Tiet;
            nmTin.Value = mon.TC;
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
                mon.MaMH = txbMaMH.Text;
                mon.TenMH = txbTenMH.Text;
                mon.KieuThi = kieuThi;
                mon.TC = (int)nmTin.Value;
                mon.Tiet = (int)nmSoTiet.Value;
                if (BLL_MonHoc.Instance.Sua(mon))
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
