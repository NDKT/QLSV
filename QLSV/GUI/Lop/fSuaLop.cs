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

namespace QLSV.GUI.Lop
{
    public partial class fSuaLop : Form
    {
        private LopDTO lop;
        public fSuaLop(LopDTO lop)
        {
            this.lop = lop;
            InitializeComponent();
            txbMaLop.Text = lop.MaLop;
            txbTenLop.Text = lop.TenLop;
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            lop.MaLop = txbMaLop.Text;
            lop.TenLop = txbTenLop.Text;
            try
            {
                if(BLL_Lop.Instance.Sua(lop))
                {
                    MessageBox.Show("Cập nhật thành công", "Thông báo");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txbTenLop_TextChanged(object sender, EventArgs e)
        {
            FormHelper.BatTatNut(btnSua, txbTenLop);
        }
    }
}
