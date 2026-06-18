using QLSV.DAL;
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
                return DAL_SinhVien.Instance.Them(sv);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Xoa(SinhVienDTO sv)
        {
            try
            {
                return DAL_SinhVien.Instance.Xoa(sv);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<SinhVienDTO> DanhSach()
        {
            return DAL_SinhVien.Instance.DanhSach();
        }

        public List<SinhVienDTO> TimKiem(SinhVienDTO sv)
        {
            return DAL_SinhVien.Instance.TimKiem(sv);
        }

        public bool Sua(SinhVienDTO sv)
        {
            if (string.IsNullOrWhiteSpace(sv.TenSV)) throw new Exception("Vui lòng nhập tên");
            if (string.IsNullOrEmpty(sv.QueQuan)) throw new Exception("Vui lòng nhập quê");
            try
            {
               return DAL_SinhVien.Instance.Sua(sv);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
