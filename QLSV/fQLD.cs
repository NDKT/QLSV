using QLSV.BLL;
using QLSV.DTO;
using QLSV.GUI.Diem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QLSV
{
    public partial class fQLD : Form
    {
        private string maSV = string.Empty;
        private string maMH = string.Empty;
        private BindingSource dataSV = new BindingSource();
        private BindingSource dataMH = new BindingSource();
        public fQLD()
        {
            InitializeComponent();
            LoadDiem();
            LoadTimKiem();
        }

        private void btnEnabled(bool enabled)
        {
            btnSua.Enabled = enabled;
            btnXoa.Enabled = enabled;
        }
        private void LoadDiem()
        {
            DataTable data = BLL_Diem.Instance.DanhSach();
            dataGridView1.DataSource = data;
        }

        private void LoadTimKiem()
        {
            DataTable dtMH = BLL_MonHoc.Instance.DanhSach();
            DataRow drMH = dtMH.NewRow();
            drMH["TenMH"] = "";
            drMH["MaMH"] = "";
            dtMH.Rows.InsertAt(drMH, 0);
            dataMH.DataSource = dtMH;

            cbbMaMH.DisplayMember = "MaMH";
            cbbMaMH.DataSource = dataMH;
            cbbMaMH.SelectedIndex = 0;

            cbbTenMH.DisplayMember = "TenMH";
            cbbTenMH.DataSource = dataMH;

            List<SinhVienDTO> listSV = BLL_SinhVien.Instance.DanhSach();
            SinhVienDTO svF = new SinhVienDTO() { MaSV = "", TenSV = "" };
            listSV.Insert(0, svF);
            dataSV.DataSource = listSV;



            cbbTenSV.DisplayMember = "TenSV";
            cbbTenSV.DataSource = dataSV;
            cbbTenSV.SelectedIndex = 0;

            cbbMaSV.DisplayMember = "MaSV";
            cbbMaSV.DataSource = dataSV;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            fThem f = new fThem();
            f.ShowDialog();
            LoadDiem();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            DialogResult res = MessageBox.Show("Bạn có chắc chắn muốn xoá?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No) return;
            try
            {
                if (BLL_Diem.Instance.Xoa(maSV, maMH))
                {
                    MessageBox.Show("Xoá Thành công", "Thông báo");
                    btnEnabled(false);
                    LoadDiem();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            fSua f = new fSua(maSV, maMH);
            f.ShowDialog();
            btnEnabled(false);
            LoadDiem();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEnabled(true);
            maSV = dataGridView1.CurrentRow?.Cells[0].Value?.ToString() ?? "";
            maMH = dataGridView1.CurrentRow?.Cells[2].Value?.ToString() ?? "";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cbbMaMH.SelectedIndex = 0;
            cbbMaSV.SelectedIndex = 0;
        }

        private void cbbMaSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL_Diem.Instance.TraDiem(cbbMaSV.Text, cbbMaMH.Text);
        }
    }
}
