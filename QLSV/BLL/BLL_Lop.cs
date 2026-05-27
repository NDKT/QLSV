using QLSV.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace QLSV.BLL
{
    public class BLL_Lop
    {
        private static BLL_Lop? instance = null;

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

        public bool Them(string maLop, string tenLop)
        {
            if (string.IsNullOrWhiteSpace(maLop) || string.IsNullOrWhiteSpace(tenLop)) throw new Exception("Tên lớp và mã lớp không được trống!");
            try
            {
                return DAL_Lop.Instance.Them(maLop.Trim(), tenLop.Trim());
            }
            catch
            {
                throw new Exception("Tên lớp bị trùng");
            }
        }

        public bool Sua(string tenLop, string maLop)
        {
            if (string.IsNullOrWhiteSpace(tenLop)) throw new Exception("Tên lớp không được là khoảng trắng");
            try
            {
                return DAL_Lop.Instance.Sua(maLop.Trim(), tenLop.Trim());
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
                bool res = DAL_Lop.Instance.Xoa(maLop);
                if (res) return res;
                throw new Exception("Có lỗi xảy ra, không thể xoá");
            }
            catch
            {
                throw new Exception("Có lỗi xảy ra");
            }
        }

        public DataTable DanhSach()
        {
            return DAL_Lop.Instance.DanhSach();
        }

        public DataTable TimKiem(string maLop, string tenLop)
        {
            if (string.IsNullOrWhiteSpace(maLop) && string.IsNullOrWhiteSpace(tenLop))
            {
                return DAL_Lop.Instance.DanhSach();
            }
            return DAL_Lop.Instance.TimKiem(maLop.Trim(), tenLop.Trim());
        }
    }
}
