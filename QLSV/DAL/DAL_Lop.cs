using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace QLSV.DAL
{
    public class DAL_Lop
    {
        private static DAL_Lop? instance = null;

        public static DAL_Lop Instance
        {
            get
            {
                if (instance == null) instance = new DAL_Lop();
                return instance;
            }
            private set => instance = value;
        }
        private DAL_Lop() { }

        public bool Them(string maLop, string tenLop)
        {
            string query = "insert into Lop (MaLop, TenLop) values ( @ML , @TL )";
            return DAL.Instance.excuteNonQuery(query, maLop, tenLop);
        }

        public bool Sua(string maLop, string tenLop)
        {
            string query = "update Lop set TenLop = @TL where Malop = @ML";
            return DAL.Instance.excuteNonQuery(query, tenLop, maLop);
        }

        public bool Xoa(string maLop)
        {
            string query = "delete from Lop where Malop = @ML";
            return DAL.Instance.excuteNonQuery(query, maLop);
        }
        public DataTable DanhSach()
        {
            string query = "Select * from Lop";
            return DAL.Instance.excuteQuery(query);
        }

        public DataTable TimKiem(string maLop, string tenLop)
        {
            string query = "select * from Lop where MaLop = @ML OR TenLop like '%' + @TL + '%'";
            if (string.IsNullOrWhiteSpace(tenLop)) query = "select * from Lop where MaLop = @ML";
            return DAL.Instance.excuteQuery(query, maLop, tenLop);
        }

        
    }
}
