using QLSV.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace QLSV.BLL
{
    public class BLL_SinhVien
    {
        private static BLL_SinhVien? instance = null;

        public static BLL_SinhVien Instance
        {
            get
            {
                if (instance == null) instance = new BLL_SinhVien();
                return instance;
            }
            private set => instance = value;
        }
        private BLL_SinhVien() { }

        public bool Them(string maSV, string tenSv, string maLop, string que, string gioiTinh, DateTime ngaySinh, DateTime ngayNhapHoc)
        {
            if (ngayNhapHoc <= ngaySinh) throw new Exception("Ngày nhập học không được trước ngày sinh");
            try
            {
                return DAL_SinhVien.Instance.Them(maSV, tenSv, maLop, que, gioiTinh, ngaySinh, ngayNhapHoc);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Xoa(string maSV)
        {
            try
            {
                return DAL_SinhVien.Instance.Xoa(maSV);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable DanhSach()
        {
            return DAL_SinhVien.Instance.DanhSach();
        }

        public DataTable TimKiem(string maSV, string tenSV)
        {
            return DAL_SinhVien.Instance.TimKiem(maSV, tenSV);
        }

        public bool Sua(string maSV, string tenSv, string maLop, string que, string gioiTinh, DateTime ngaySinh, DateTime ngayNhapHoc)
        {
            if (string.IsNullOrWhiteSpace(tenSv)) throw new Exception("Vui lòng nhập tên");
            if (string.IsNullOrEmpty(que)) throw new Exception("Vui lòng nhập quê");
            try
            {
               return DAL_SinhVien.Instance.Sua(maSV, tenSv, maLop, que, gioiTinh, ngaySinh, ngayNhapHoc);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
