using QLSV.DAL.Interfaces;
using QLSV.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace QLSV.DAL
{
    public class DAL_Diem : IDiem
    {
        private static DAL_Diem? instance = null;

        public static DAL_Diem Instance
        {
            get
            {
                if (instance == null) instance = new DAL_Diem();
                return instance;
            }
            private set => instance = value;
        }
        private DAL_Diem() { }

        public bool Them(DiemDTO diem)
        {
            string query = "insert into Diem (MaSV, MaMH, ChuyenCan, ThuongXuyen, KetThuc) values ( @masv , @mamh , @cc , @tx , @kt )";
            return DAL.Instance.excuteNonQuery(query, diem.MaSV, diem.MaMH, diem.ChuyenCan, diem.ThuongXuyen, diem.KetThuc);
        }

        private List<DiemDTO> ConvertToList(DataTable dt)
        {
            List<DiemDTO> listD = new List<DiemDTO>();
            foreach(DataRow row in dt.Rows)
            {
                listD.Add(new DiemDTO()
                {
                    ChuyenCan = row.Field<double>("ChuyenCan"),
                    KetThuc = row.Field<double>("KetThuc"),
                    ThuongXuyen = row.Field<double>("ThuongXuyen"),
                    MaMH = row.Field<string>("MaMH")!,
                    MaSV = row.Field<string>("MaSV")!,
                    TongKet = row.Field<double>("TongKet"),
                    TenMH = row.Field<string>("TenMH")!,
                    TenSV = row.Field<string>("TenSV")!
                });
            }
            return listD;
        }

        public List<DiemDTO> DanhSach()
        {
            string query = "Select sv.MaSV, sv.TenSV, d.MaMH, m.TenMH, d.ChuyenCan, d.ThuongXuyen, d.KetThuc, d.TongKet  from Diem d join SinhVien sv on d.MaSV = sv.MaSV join MonHoc m on d.MaMH = m.MaMH";
            return ConvertToList(DAL.Instance.excuteQuery(query));
        }

        public List<DiemDTO> TraDiem(string maSV, string maMH)
        {
            string query;
            if (!string.IsNullOrWhiteSpace(maMH) && !string.IsNullOrWhiteSpace(maSV))
            {
                query = "Select sv.MaSV, sv.TenSV, d.MaMH, m.TenMH, d.ChuyenCan, d.ThuongXuyen, d.KetThuc, d.TongKet  from Diem d join SinhVien sv on d.MaSV = sv.MaSV join MonHoc m on d.MaMH = m.MaMH where d.MaSV = @masv and d.MaMH = @mamh";
                return ConvertToList(DAL.Instance.excuteQuery(query, maSV, maMH));
            }

            else if (!string.IsNullOrWhiteSpace(maMH))
            {
                query = "Select sv.MaSV, sv.TenSV, d.MaMH, m.TenMH, d.ChuyenCan, d.ThuongXuyen, d.KetThuc, d.TongKet  from Diem d join SinhVien sv on d.MaSV = sv.MaSV join MonHoc m on d.MaMH = m.MaMH where d.MaMH = @mamh";
                return ConvertToList(DAL.Instance.excuteQuery(query, maMH));
            }
            else 
            {
                query = "Select sv.MaSV, sv.TenSV, d.MaMH, m.TenMH, d.ChuyenCan, d.ThuongXuyen, d.KetThuc, d.TongKet  from Diem d join SinhVien sv on d.MaSV = sv.MaSV join MonHoc m on d.MaMH = m.MaMH where d.MaSV = @masv";
                return ConvertToList(DAL.Instance.excuteQuery(query, maSV));
            }
        }

        public bool Sua(DiemDTO diem)
        {
            string query = "update Diem set ChuyenCan = @cc , ThuongXuyen = @tx , KetThuc = @kt where MaSV = @masv and MaMH = @mamh";
            return DAL.Instance.excuteNonQuery(query, diem.ChuyenCan, diem.ThuongXuyen, diem.KetThuc, diem.MaSV, diem.MaMH);
        }

        public bool Xoa(DiemDTO diem)
        {
            string query = "delete from Diem where MaSV = @msv and MaMH = @mmh";
            return DAL.Instance.excuteNonQuery(query, diem.MaSV, diem.MaMH);
        }
    }
}