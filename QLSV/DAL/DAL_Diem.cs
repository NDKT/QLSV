using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace QLSV.DAL
{
    public class DAL_Diem
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

        public bool Them(string maSV, string maMH, double cc, double tx, double kt)
        {
            string query = "insert into Diem (MaSV, MaMH, ChuyenCan, ThuongXuyen, KetThuc) values ( @masv , @mamh , @cc , @tx , @kt )";
            return DAL.Instance.excuteNonQuery(query, maSV, maMH, cc, tx, kt);
        }

        public DataTable DanhSach()
        {
            string query = "Select sv.MaSV, sv.TenSV, d.MaMH, m.TenMH, d.ChuyenCan, d.ThuongXuyen, d.KetThuc, d.TongKet  from Diem d join SinhVien sv on d.MaSV = sv.MaSV join MonHoc m on d.MaMH = m.MaMH";
            return DAL.Instance.excuteQuery(query);
        }

        public DataTable TraDiem(string maSV, string maMH)
        {
            string query = "Select sv.MaSV, sv.TenSV, d.MaMH, m.TenMH, d.ChuyenCan, d.ThuongXuyen, d.KetThuc, d.TongKet  from Diem d join SinhVien sv on d.MaSV = sv.MaSV join MonHoc m on d.MaMH = m.MaMH where d.MaSV = @masv and d.MaMH = @mamh";
            if (string.IsNullOrWhiteSpace(maMH)) query = "Select sv.MaSV, sv.TenSV, d.MaMH, m.TenMH, d.ChuyenCan, d.ThuongXuyen, d.KetThuc, d.TongKet  from Diem d join SinhVien sv on d.MaSV = sv.MaSV join MonHoc m on d.MaMH = m.MaMH where d.MaSV = @masv";
            return DAL.Instance.excuteQuery(query, maSV, maMH);
        }

        public bool Sua(string maSV, string maMH, double cc, double tx, double kt)
        {
            string query = "update Diem set ChuyenCan = @cc , ThuongXuyen = @tx , KetThuc = @kt where MaSV = @masv and MaMH = @mamh";
            return DAL.Instance.excuteNonQuery(query, cc, tx, kt, maSV, maMH);
        }

        public bool Xoa(string maSV, string maMH)
        {
            string query = "delete from Diem where MaSV = @msv and MaMH = @mmh";
            return DAL.Instance.excuteNonQuery(query, maSV, maMH);
        }
    }
}