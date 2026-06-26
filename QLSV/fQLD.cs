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
        private DiemDTO diem = new DiemDTO();
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
            List<DiemDTO> ListD = BLL_Diem.Instance.DanhSach();
            dataGridView1.DataSource = ListD;
        }

        private void LoadTimKiem()
        {
            

            List<MonHocDTO> listM = BLL_MonHoc.Instance.DanhSach();
            MonHocDTO nMon = new MonHocDTO() { TenMH = "", MaMH = "" };
            listM.Insert(0, nMon);
            dataMH.DataSource = listM;

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
            fThemDiem f = new fThemDiem();
            f.ShowDialog();
            LoadDiem();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            DialogResult res = MessageBox.Show("Bạn có chắc chắn muốn xoá?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No) return;
            try
            {
                if (BLL_Diem.Instance.Xoa(diem))
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
            fSuaDiem f = new fSuaDiem(diem);
            f.ShowDialog();
            btnEnabled(false);
            LoadDiem();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            this.diem = (dataGridView1.Rows[e.RowIndex].DataBoundItem as DiemDTO)!;
            if (this.diem == null) return;
            btnEnabled(true);
            
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
