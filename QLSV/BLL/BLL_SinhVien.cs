using QLSV.DAL;
using QLSV.DAL.Interfaces;
using QLSV.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace QLSV.BLL
{
    public class BLL_SinhVien
    {
        private static BLL_SinhVien? instance = null;
        private ISinhVien _svDAL = DAL_SinhVien.Instance;
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

        public bool Them(SinhVienDTO sv)
        {
            if (sv.NgayNhapHoc <= sv.NgaySinh) throw new Exception("Ngày nhập học không được trước ngày sinh");
            try
            {
                return _svDAL.Them(sv);
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
                return _svDAL.Xoa(maSV);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<SinhVienDTO> DanhSach()
        {
            return _svDAL.DanhSach();
        }

        public List<SinhVienDTO> TimKiem(string maSV, string tenSV)
        {
            return _svDAL.TimKiem(maSV,tenSV);
        }

        public bool Sua(SinhVienDTO sv)
        {
            if (string.IsNullOrWhiteSpace(sv.TenSV)) throw new Exception("Vui lòng nhập tên");
            if (string.IsNullOrEmpty(sv.QueQuan)) throw new Exception("Vui lòng nhập quê");
            try
            {
               return _svDAL.Sua(sv);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
