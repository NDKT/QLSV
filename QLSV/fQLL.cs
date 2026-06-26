using QLSV.BLL;
using QLSV.GUI.Lop;
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
    public partial class fQLL : Form
    {
        private string tenLop = string.Empty;
        private string maLop = string.Empty;


        public fQLL()
        {
            InitializeComponent();
            enableBtn(false);
            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            fThemLop f = new fThemLop();
            f.ShowDialog();
            LoadData();
        }

        private void enableBtn(bool state)
        {
            btnSua.Enabled = state;
            btnXoa.Enabled = state;
        }
        private void LoadData()
        {
            FormHelper.ThemDuLieu(BLL_Lop.Instance.DanhSach(), dataGridView1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.maLop = dataGridView1.CurrentRow?.Cells[0].Value?.ToString() ?? "";
            this.tenLop = dataGridView1.CurrentRow?.Cells[1].Value?.ToString() ?? "";
            enableBtn(true);
        }



        private void btnSua_Click(object sender, EventArgs e)
        {
            fSuaLop f = new fSuaLop(maLop, tenLop);
            f.ShowDialog();
            LoadData();
            enableBtn(false);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có chắc chắn muốn xoá ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.No == res) return;
            try
            {
                BLL_Lop.Instance.Xoa(maLop);
                ToolHelper.DisableBtn(btnSua, btnXoa);
                MessageBox.Show("Xoá thành công", "Thông báo");
                LoadData();
                enableBtn(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void fQLL_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void txbTenLop_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL_Lop.Instance.TimKiem(txbMaLop.Text, txbTenLop.Text);
        }
    }
}
