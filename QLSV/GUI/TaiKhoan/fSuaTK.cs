using QLSV.BLL;
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
    public partial class fSuaTK : Form
    {
        public fSuaTK(string id, string ten)
        {
            InitializeComponent();
            txbID.Text = id;
            txbTenDangNhap.Text = ten;
        }

        private void fSua_Load(object sender, EventArgs e)
        {
            FormHelper.BatTatNut(btnSua, txbMatKhau);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if(!BLL_TaiKhoan.Instance.Sua(txbMatKhau.Text, txbID.Text))
                {
                    MessageBox.Show("Có lỗi xảy ra");
                    return;
                }
                MessageBox.Show("Đổi thông tin thành công", "Thông báo");
                this.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
