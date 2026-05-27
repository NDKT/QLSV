using QLSV.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace QLSV.BLL
{
    public class BLL_TaiKhoan
    {
        private static BLL_TaiKhoan? instance = null;

        public static BLL_TaiKhoan Instance
        {
            get
            {
                if (instance == null) instance = new BLL_TaiKhoan();
                return instance;
            }
            private set => instance = value;
        }

        private BLL_TaiKhoan() { }

        public bool Them(string ten, string matKhau)
        {
            if (ten.Contains(' ') || matKhau.Contains(' ')) throw new Exception("Tài khoản và mật khẩu không được chứa dấu cách");
            if (matKhau.Length <= 6) throw new Exception("Mật khẩu không được quá ngắn. (Trên 6 ký tự");
            try
            {
                return DAL_TaiKhoan.Instance.Them(ten, matKhau);
            }
            catch
            {
                throw new Exception("Tên tài khoản đã tồn tại");
            }
             
        }

        public bool Sua(string matKhau, string ID)
        {
            if(!Int32.TryParse(ID, out int id)) throw new Exception("ID phải là số");   
            if (matKhau.Length <= 6) throw new Exception("Mật khẩu phải dài hơn 6 ký tự");
            if (matKhau.Contains(' ')) throw new Exception("Mật khẩu không được chứa khoảng trắng");
            try
            {
                return DAL_TaiKhoan.Instance.Sua(matKhau, id);
            }
            catch
            {
                throw new Exception("Có lỗi xảy ra");
            }
            
        }

        public bool Xoa(string ID)
        {
            if (!Int32.TryParse(ID, out int id)) throw new Exception("ID phải là số");
            try
            {
                return DAL_TaiKhoan.Instance.Xoa(id);
            }
            catch
            {
                throw new Exception("Không tìm thấy tài khoản");
            }
        }

        public DataTable DanhSach()
        {
            return DAL_TaiKhoan.Instance.DanhSach();
        }
        public DataTable TimKiem(string ID, string ten)
        {
            if(string.IsNullOrWhiteSpace(ID) && string.IsNullOrWhiteSpace(ten))
            {
                return DAL_TaiKhoan.Instance.DanhSach();
            }
            Int32.TryParse(ID, out int id);
            return DAL_TaiKhoan.Instance.Tim(ten, id);
        }

        public bool DangNhap(string ten, string matKhau)
        {
            if(string.IsNullOrEmpty(ten) || string.IsNullOrEmpty(matKhau))
            {
                throw new Exception("Tài Khoản và mật khẩu không được để trống");
            }
            DataTable data = DAL_TaiKhoan.Instance.DangNhap(ten.Trim(), matKhau.Trim());
            return data.Rows.Count > 0;
        }
    }
}
