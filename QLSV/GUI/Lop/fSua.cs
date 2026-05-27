using QLSV.BLL;
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
    public partial class fSua : Form
    {
        public fSua(string maLop, string tenLop)
        {
            InitializeComponent();
            txbMaLop.Text = maLop;
            txbTenLop.Text = tenLop;
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maLop = txbMaLop.Text;
            string tenLop = txbTenLop.Text;
            try
            {
                if(BLL_Lop.Instance.Sua(tenLop, maLop))
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
