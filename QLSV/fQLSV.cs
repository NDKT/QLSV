using QLSV.BLL;
using QLSV.GUI.SinhVien;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QLSV
{
    public partial class fQLSV : Form
    {
        private bool thoat = true;
        private string maSV = string.Empty;

        public bool Thoat { get => thoat; private set => thoat = value; }

        public fQLSV()
        {
            InitializeComponent();
            LoadSV();
        }

        private void QLTKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fQLTK f = new fQLTK();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void QLMHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fQLMH f = new fQLMH();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void QLLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fQLL f = new fQLL();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void QLDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fQLD f = new fQLD();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void TTTKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fThongTinTK f = new fThongTinTK();
            f.ShowDialog();
        }

        private void LogOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thoat = false;
            this.Close();
        }

        private void fQLSV_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Thoat)
            {
                DialogResult res = MessageBox.Show("Bạn có chắc chắn muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }


        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            fThem f = new fThem();
            f.ShowDialog();
            LoadSV();
        }


        private void LoadSV()
        {
            dataGridView1.DataSource = BLL_SinhVien.Instance.DanhSach();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            maSV = dataGridView1.CurrentRow?.Cells[0].Value?.ToString() ?? "";

            btnChiTiet.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            fSua f = new fSua(maSV);
            btnChiTiet.Enabled = false;
            btnSua.Enabled = false;
            btnThem.Enabled = false;
            f.ShowDialog();
            LoadSV();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có chắc chắn muốn xoá ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No) return;
            try
            {
                if (BLL_SinhVien.Instance.Xoa(maSV))
                {
                    MessageBox.Show("Xoá thành công");
                    btnChiTiet.Enabled = false;
                    btnSua.Enabled = false;
                    btnThem.Enabled = false;
                    LoadSV();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txbMaSV_TextChanged(object sender, EventArgs e)
        {

            DataTable data = BLL_SinhVien.Instance.TimKiem(txbMaSV.Text, txbHoTen.Text);
            dataGridView1.DataSource = data;
        }

        private void fQLSV_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible != true) return;
            LoadSV();
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            fThongTinChiTiet f = new fThongTinChiTiet(maSV);
            f.ShowDialog();
        }
    }
}
