using QLSV.BLL;
using QLSV.GUI.MonHoc;
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
    public partial class fQLMH : Form
    {
        public fQLMH()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            FormHelper.ThemDuLieu(BLL_MonHoc.Instance.DanhSach(), dataGridView1);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            fThemMH f = new fThemMH();
            f.ShowDialog();
            LoadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maMH = dataGridView1.CurrentRow?.Cells[0].Value?.ToString() ?? "";
            string tenMH = dataGridView1.CurrentRow?.Cells[1].Value?.ToString() ?? "";
            decimal soTin = Decimal.Parse(dataGridView1.CurrentRow?.Cells[2].Value?.ToString() ?? "0");
            decimal soTiet = Decimal.Parse(dataGridView1.CurrentRow?.Cells[4].Value?.ToString() ?? "0");
            string kieuThi = dataGridView1.CurrentRow?.Cells[3].Value?.ToString() ?? "";
            fSuaMH f = new fSuaMH(maMH, tenMH, soTin, soTiet, kieuThi);
            ToolHelper.DisableBtn(btnXoa, btnSua);
            f.ShowDialog();
            LoadData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có chắc chắn muốn xoá", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (res == DialogResult.Cancel) return;
            string maMH = dataGridView1.CurrentRow?.Cells[0].Value?.ToString() ?? "";
            try
            {
                if (BLL_MonHoc.Instance.Xoa(maMH))
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

        private void txbMaMH_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL_MonHoc.Instance.TimKiem(txbMaMH.Text, txbTenMH.Text);
        }
    }
}
