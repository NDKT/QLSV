using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace QLSV.DAL
{
    public class DAL_SinhVien
    {
        private static DAL_SinhVien? instance = null;

        public static DAL_SinhVien Instance
        {
            get
            {
                if (instance == null) instance = new DAL_SinhVien();
                return instance;
            }
            private set => instance = value;
        }
        private DAL_SinhVien() { }

        public bool Them(string maSV, string tenSv, string maLop,string que, string gioiTinh, DateTime ngaySinh, DateTime ngayNhapHoc)
        {
            string query = "insert into SinhVien (MaSV, TenSv, MaLop, QueQuan, GioiTinh, NgaySinh, NgayNhapHoc) values ( @msv , @tensv , @ml , @que , @gt , @ns , @nnh )";
            return DAL.Instance.excuteNonQuery(query, maSV, tenSv, maLop, que, gioiTinh, ngaySinh, ngayNhapHoc);
        }

        public bool Xoa(string maSV)
        {
            string query = "delete from SinhVien where MaSV = @ma";
            return DAL.Instance.excuteNonQuery(query, maSV);
        }

        public DataTable DanhSach()
        {
            string query = "select * from SinhVien";
            return DAL.Instance.excuteQuery(query);
        }

        public DataTable TimKiem(string maSV, string tenSV)
        {
            if (string.IsNullOrWhiteSpace(maSV) && string.IsNullOrWhiteSpace(tenSV)) return DanhSach();
            string query = "Select * from SinhVien Where MaSV = @ma OR TenSV like '%' + @ten +'%'";
            if (string.IsNullOrWhiteSpace(tenSV)) query = "Select * from SinhVien Where MaSV = @ma";
            return DAL.Instance.excuteQuery(query, maSV, tenSV);
        }

        public bool Sua(string maSV, string tenSv, string maLop, string que, string gioiTinh, DateTime ngaySinh, DateTime ngayNhapHoc)
        {
            string query = "update SinhVien set TenSV = @ten , MaLop = @ma , QueQuan = @que , GioiTinh = @gt , NgaySinh = @ns , NgayNhapHoc = @nnh where MaSV = @masv";
            return DAL.Instance.excuteNonQuery(query, tenSv, maLop, que, gioiTinh, ngaySinh, ngayNhapHoc, maSV);
        }

    }
}
