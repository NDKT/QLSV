using QLSV.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace QLSV.DAL
{
    public class DAL_MonHoc
    {
        private static DAL_MonHoc? instance = null;

        public static DAL_MonHoc Instance
        {
            get
            {
                if (instance == null) instance = new DAL_MonHoc();
                return instance;
            }
            private set => instance = value;
        }

        private DAL_MonHoc() { }

        public bool Them(string maMH, string tenMH, string kieuThi, int soTin, int soTiet)
        {
            string query = "insert into MonHoc ( MaMH , TenMh , TC , KieuThi , Tiet ) values ( @Ma , @Ten ,  @STin , @KT , @STiet )";
            return DAL.Instance.excuteNonQuery(query, maMH, tenMH, soTin , kieuThi, soTiet);
        }
        public DataTable DanhSach()
        {
            string query = "select * from MonHoc";
            return DAL.Instance.excuteQuery(query);
        }

        public bool Sua(string maMH, string tenMH, string kieuThi, int soTin, int soTiet)
        {
            string query = "update MonHoc set TenMH = @ten , TC = @tin , Kieuthi = @kt , Tiet = @t where MaMH = @ma";
            return DAL.Instance.excuteNonQuery(query, tenMH, soTin, kieuThi, soTiet,maMH);
        }
           
        public bool Xoa(string maMH)
        {
            string query = "delete from MonHoc where MaMH = @ma";
            return DAL.Instance.excuteNonQuery(query, maMH);
        }
        public DataTable TimKiem(string maMH, string tenMH)
        {
            string query = string.Empty;
            if (string.IsNullOrWhiteSpace(tenMH)) query = "select * from MonHoc where MaMH = @ma";
            else query = "select * from MonHoc where MaMH = @ma or TenMH like '%' + @ten + '%'";
            return DAL.Instance.excuteQuery(query, maMH, tenMH);
        }
    }
}
