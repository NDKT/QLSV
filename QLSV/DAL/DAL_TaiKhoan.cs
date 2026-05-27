using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace QLSV.DAL
{
    public class DAL_TaiKhoan
    {
        private static DAL_TaiKhoan? instance = null;

        public static DAL_TaiKhoan Instance { get 
            {
                if (instance == null) instance = new DAL_TaiKhoan();
                return instance;
            } 
            private set => instance = value; 
        }
        private DAL_TaiKhoan() { }
        public bool Them(string ten, string matKhau)
        {
            string query = "insert into TaiKhoan (TenDangNhap, MatKhau) values ( @TenDangNhap , @MatKhau )";
            return DAL.Instance.excuteNonQuery(query, new object[] { ten, matKhau });
        }

        public bool Sua(string matkhau, int id)
        {
            string query = "update TaiKhoan set MatKhau = @MatKhau where ID = @ID";
            return DAL.Instance.excuteNonQuery(query, new object[] { matkhau, id });
        }

        public bool Xoa(int id)
        {
            string query = "delete from TaiKhoan where ID = @ID";
            return DAL.Instance.excuteNonQuery(query, id);
        }

        public DataTable DanhSach()
        {
            DataTable data = new DataTable();
            string query = "Select * from TaiKhoan";
            return DAL.Instance.excuteQuery(query);
        }

        public DataTable Tim(string ten, int id)
        {
            DataTable data = new DataTable();
            string query = string.Empty;
            if(string.IsNullOrEmpty(ten)) query = "Select * from TaiKhoan where ID = @ID";
            else query = "Select * from TaiKhoan where ID = @ID OR TenDangNhap like '%' + @Ten + '%'";
            return DAL.Instance.excuteQuery(query, id, ten);
        }

        public DataTable DangNhap(string ten, string matKhau)
        {
            string query = "select * from TaiKhoan where TenDangNhap = @Ten and MatKhau = @MK";
            return DAL.Instance.excuteQuery(query, ten, matKhau);
        }
        
    }
}
