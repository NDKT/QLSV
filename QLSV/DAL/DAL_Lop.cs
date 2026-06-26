using QLSV.DAL.Interfaces;
using QLSV.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace QLSV.DAL
{
    public class DAL_Lop : ILop
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

        public bool Them(LopDTO Lop)
        {
            string query = "insert into Lop (MaLop, TenLop) values ( @ML , @TL )";
            return DAL.Instance.excuteNonQuery(query, Lop.MaLop, Lop.TenLop);
        }

        public bool Sua(LopDTO Lop)
        {
            string query = "update Lop set TenLop = @TL where Malop = @ML";
            return DAL.Instance.excuteNonQuery(query, Lop.TenLop, Lop.MaLop);
        }

        public bool Xoa(string maLop)
        {
            string query = "delete from Lop where Malop = @ML";
            return DAL.Instance.excuteNonQuery(query, maLop);
        }

        private List<LopDTO> ConvertToList(DataTable dt)
        {
            List<LopDTO> listL = new List<LopDTO>();
            foreach(DataRow row in dt.Rows)
            {
                listL.Add(new LopDTO()
                {
                    MaLop = row.Field<string>("MaLop")!,
                    TenLop = row.Field<string>("TenLop")!
                });
            }
            return listL;
        }
        public List<LopDTO> DanhSach()
        {
            string query = "Select * from Lop";
            List<LopDTO> listL = ConvertToList(DAL.Instance.excuteQuery(query));
            return listL;
        }

        public List<LopDTO> TimKiem(string maLop, string tenLop)
        {
            string query = "select * from Lop where MaLop = @ML OR TenLop like '%' + @TL + '%'";
            if (string.IsNullOrWhiteSpace(tenLop)) query = "select * from Lop where MaLop = @ML";
            List<LopDTO> listL = ConvertToList(DAL.Instance.excuteQuery(query, maLop, tenLop));
            return listL;
        }

        
    }
}
