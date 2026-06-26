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
    public partial class fThemLop : Form
    {
        public fThemLop()
        {
            InitializeComponent();
        }

        private void fThem_TextChanged(object sender, EventArgs e)
        {
            FormHelper.BatTatNut(btnThem, txbMaLop, txbTenLop);
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (BLL_Lop.Instance.Them(txbMaLop.Text, txbTenLop.Text))
                {
                    MessageBox.Show("Thêm lớp thành công", "Thông báo");
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
