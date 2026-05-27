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
    public partial class fThem : Form
    {
        public fThem()
        {
            InitializeComponent();
            cbKieuThi.SelectedIndex = 0;
            FormHelper.BatTatNut(btnThem, txbMaMH, txbTenMH);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string kieuThi = cbKieuThi.SelectedItem?.ToString() ?? "";
            try
            {
                if (BLL_MonHoc.Instance.Them(txbMaMH.Text, txbTenMH.Text,kieuThi  ,nmTin.Value.ToString(), nmSoTiet.Value.ToString()))
                {
                    MessageBox.Show("Thêm môn học thành công", "Thông báo");
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnQuaylai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
