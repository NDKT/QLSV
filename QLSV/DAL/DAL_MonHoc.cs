using QLSV.BLL;
using QLSV.DAL.Interfaces;
using QLSV.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace QLSV.DAL
{
    public class DAL_MonHoc : IMonHoc
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

        public bool Them(MonHocDTO mon)
        {
            string query = "insert into MonHoc ( MaMH , TenMh , TC , KieuThi , Tiet ) values ( @Ma , @Ten ,  @STin , @KT , @STiet )";
            return DAL.Instance.excuteNonQuery(query, mon.MaMH, mon.TenMH, mon.TC , mon.KieuThi, mon.Tiet);
        }

        private List<MonHocDTO> ConvertToList(DataTable dt)
        {
            List<MonHocDTO> listM = new List<MonHocDTO>();
            foreach(DataRow row in dt.Rows)
            {
                listM.Add(new MonHocDTO()
                {
                    KieuThi = row.Field<string>("KieuThi")!,
                    MaMH = row.Field<string>("MaMH")!,
                    Tiet = row.Field<int>("Tiet"),
                    TC = row.Field<int>("TC"),
                    TenMH = row.Field<string>("TenMH")!
                });   
            }
            return listM;
        }
        public List<MonHocDTO> DanhSach()
        {
            string query = "select * from MonHoc";
            return ConvertToList(DAL.Instance.excuteQuery(query));
        }

        public bool Sua(MonHocDTO mon)
        {
            string query = "update MonHoc set TenMH = @ten , TC = @tin , Kieuthi = @kt , Tiet = @t where MaMH = @ma";
            return DAL.Instance.excuteNonQuery(query, mon.TenMH, mon.TC, mon.KieuThi, mon.Tiet,mon.MaMH);
        }
           
        public bool Xoa(string maMH)
        {
            string query = "delete from MonHoc where MaMH = @ma";
            return DAL.Instance.excuteNonQuery(query, maMH);
        }
        public List<MonHocDTO> TimKiem(string maMH, string tenMH)
        {
            string query = string.Empty;
            if (string.IsNullOrWhiteSpace(tenMH)) query = "select * from MonHoc where MaMH = @ma";
            else query = "select * from MonHoc where MaMH = @ma or TenMH like '%' + @ten + '%'";
            return ConvertToList(DAL.Instance.excuteQuery(query, maMH, tenMH));
        }
    }
}
