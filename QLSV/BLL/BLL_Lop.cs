using QLSV.DAL;
using QLSV.DAL.Interfaces;
using QLSV.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace QLSV.BLL
{
    public class BLL_Lop
    {
        private static BLL_Lop? instance = null;
        private ILop lopDAL = DAL_Lop.Instance;
        public static BLL_Lop Instance
        {
            get
            {
                if (instance == null) instance = new BLL_Lop();
                return instance;
            }
            private set => instance = value;
        }
        private BLL_Lop() { }

        public bool Them(LopDTO lop)
        {
            if (string.IsNullOrWhiteSpace(lop.MaLop) || string.IsNullOrWhiteSpace(lop.TenLop)) throw new Exception("Tên lớp và mã lớp không được trống!");
            try
            {
                return lopDAL.Them(lop);
            }
            catch
            {
                throw new Exception("Tên lớp bị trùng");
            }
        }

        public bool Sua(LopDTO lop)
        {
            if (string.IsNullOrWhiteSpace(lop.TenLop)) throw new Exception("Tên lớp không được là khoảng trắng");
            try
            {
                return lopDAL.Sua(lop);
            }
            catch
            {
                throw new Exception("Có lỗi xảy ra");
            }
        }

        public bool Xoa(string maLop)
        {
            try
            {
                bool res = lopDAL.Xoa(maLop);
                if (res) return res;
                throw new Exception("Có lỗi xảy ra, không thể xoá");
            }
            catch
            {
                throw new Exception("Có lỗi xảy ra");
            }
        }

        public List<LopDTO> DanhSach()
        {
            return lopDAL.DanhSach();
        }

        public List<LopDTO> TimKiem(string maLop, string tenLop)
        {
            if (string.IsNullOrWhiteSpace(maLop) && string.IsNullOrWhiteSpace(tenLop))
            {
                return lopDAL.DanhSach();
            }
            return lopDAL.TimKiem(maLop.Trim(), tenLop.Trim());
        }
    }
}
