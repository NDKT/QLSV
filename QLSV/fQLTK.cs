using QLSV.BLL;
using QLSV.GUI.TaiKhoan;
using QLSV.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QLSV
{
    public partial class fQLTK : Form
    {
        public fQLTK()
        {
            InitializeComponent();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            fThemTK f = new fThemTK();
            f.ShowDialog();
            LoadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string id = dataGridView1.CurrentRow?.Cells[0].Value?.ToString() ?? "";
            string ten = dataGridView1.CurrentRow?.Cells[1].Value?.ToString() ?? "";
            ToolHelper.DisableBtn(btnSua, btnXoa);
            fSuaTK f = new fSuaTK(id, ten);
            f.ShowDialog();
            LoadData();
        }

        private void fQLTK_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            FormHelper.ThemDuLieu(BLL_TaiKhoan.Instance.DanhSach(), dataGridView1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có chắc chắn muốn xoá", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No) return;
            try
            {
                string? id = dataGridView1.CurrentRow?.Cells[0].Value?.ToString() ?? "";
                if (BLL_TaiKhoan.Instance.Xoa(id))
                {
                    MessageBox.Show("Xoá thành công", "Thông báo");
                    ToolHelper.DisableBtn(btnSua, btnXoa);
                    LoadData();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }

        private void txbTenDangNhap_TextChanged(object sender, EventArgs e)
        {
            DataTable data = BLL_TaiKhoan.Instance.TimKiem(txbID.Text, txbTenDangNhap.Text);
            dataGridView1.DataSource = data;
        }
    }
}
