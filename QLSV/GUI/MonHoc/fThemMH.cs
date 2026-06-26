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
    public partial class fThemMH : Form
    {
        public fThemMH()
        {
            InitializeComponent();
            cbKieuThi.SelectedIndex = 0;
            FormHelper.BatTatNut(btnThem, txbMaMH, txbTenMH);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            MonHocDTO mon = new MonHocDTO()
            {
                KieuThi = cbKieuThi.SelectedItem?.ToString()!,
                MaMH = txbMaMH.Text,
                TenMH = txbTenMH.Text,
                TC = (int)nmTin.Value,
                Tiet = (int)nmSoTiet.Value
            };
            try
            {
                if (BLL_MonHoc.Instance.Them(mon))
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
