using QLSV.BLL;

namespace QLSV
{
    public partial class fDangNhap : Form
    {
        public fDangNhap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!BLL_TaiKhoan.Instance.DangNhap(txbTenDangNhap.Text, txbMatKhau.Text)){
                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác");
                    return;
                }
                QLSV.NguoiDung.TenDangNhap = txbTenDangNhap.Text;
                QLSV.NguoiDung.MatKhau = txbMatKhau.Text;
                fQLSV f = new fQLSV();
                this.Hide();
                f.ShowDialog();
                if (f.Thoat) Application.Exit();
                txbMatKhau.Text = string.Empty;
                this.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
            
        }
    }
}
