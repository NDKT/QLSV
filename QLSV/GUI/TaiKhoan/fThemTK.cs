using QLSV.BLL;
using QLSV.DAL;
using QLSV.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QLSV.GUI.TaiKhoan
{
    public partial class fThemTK : Form
    {
        public fThemTK()
        {
            InitializeComponent();
        }



        private void btnThem_Click(object sender, EventArgs e)
        {

            if (txbMatKhau.Text != txbMatKhau2.Text)
            {
                MessageBox.Show("Mật khẩu nhập lại không đúng");
                return;
            }
            try
            {
                if (BLL_TaiKhoan.Instance.Them(txbTenDangNhap.Text, txbMatKhau.Text))
                {
                    MessageBox.Show("Thêm tài khoản thành công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra", "Lỗi");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fThem_Load(object sender, EventArgs e)
        {
            FormHelper.BatTatNut(btnThem, txbTenDangNhap, txbMatKhau, txbMatKhau2);
        }
    }
}
