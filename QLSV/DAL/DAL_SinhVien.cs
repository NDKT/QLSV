using QLSV.DAL.Interfaces;
using QLSV.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;


namespace QLSV.DAL
{
    public class DAL_SinhVien: ISinhVien
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

        public bool Them(SinhVienDTO sv)
        {
            string query = "insert into SinhVien (MaSV, TenSv, MaLop, QueQuan, GioiTinh, NgaySinh, NgayNhapHoc) values ( @msv , @tensv , @ml , @que , @gt , @ns , @nnh )";
            return DAL.Instance.excuteNonQuery(query, sv.MaSV, sv.TenSV, sv.MaLop, sv.QueQuan, sv.GioiTinh, sv.NgaySinh, sv.NgayNhapHoc);
        }

        public bool Xoa(string maSV)
        {
            string query = "delete from SinhVien where MaSV = @ma";
            return DAL.Instance.excuteNonQuery(query, maSV);
        }

        private List<SinhVienDTO> ConvertToList(DataTable dt)
        {
            List<SinhVienDTO> list = new List<SinhVienDTO>();
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new SinhVienDTO()
                {
                    GioiTinh = row.Field<string>("GioiTinh")!,
                    TenSV = row.Field<string>("TenSV")!,
                    MaLop = row.Field<string>("MaLop")!,
                    MaSV = row.Field<string>("MaSV")!,
                    NgayNhapHoc = row.Field<DateTime>("NgayNhapHoc"),
                    NgaySinh = row.Field<DateTime>("NgaySinh"),
                    QueQuan = row.Field<string>("QueQuan")!
                });
            }
            return list;
        }

        public List<SinhVienDTO> DanhSach()
        {
            string query = "select * from SinhVien";
            DataTable dt = DAL.Instance.excuteQuery(query);
            return ConvertToList(dt);
        }

        public List<SinhVienDTO> TimKiem(string maSV, string tenSV)
        {
            if (string.IsNullOrWhiteSpace(maSV) && string.IsNullOrWhiteSpace(tenSV)) return DanhSach();
            string query = "Select * from SinhVien Where MaSV = @ma OR TenSV like '%' + @ten +'%'";
            if (string.IsNullOrWhiteSpace(tenSV)) query = "Select * from SinhVien Where MaSV = @ma";
            DataTable dt = DAL.Instance.excuteQuery(query, maSV, tenSV);
            return ConvertToList(dt);
        }

        public bool Sua(SinhVienDTO sv)
        {
            string query = "update SinhVien set TenSV = @ten , MaLop = @ma , QueQuan = @que , GioiTinh = @gt , NgaySinh = @ns , NgayNhapHoc = @nnh where MaSV = @masv";
            return DAL.Instance.excuteNonQuery(query, sv.TenSV, sv.MaLop, sv.QueQuan, sv.GioiTinh, sv.NgaySinh, sv.NgayNhapHoc, sv.MaSV);
        }

    }
}
