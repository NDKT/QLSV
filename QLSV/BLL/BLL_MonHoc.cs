using QLSV.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace QLSV.BLL
{
    public class BLL_MonHoc
    {
        private static BLL_MonHoc? instance = null;

        public static BLL_MonHoc Instance
        {
            get
            {
                if (instance == null) instance = new BLL_MonHoc();
                return instance;
            }
            private set => instance = value;
        }

        private BLL_MonHoc() { }

        public bool Them(string maMH, string tenMH, string kieuThi, string soTin, string soTiet)
        {
            int tin = Int32.Parse(soTin);
            int tiet = Int32.Parse(soTiet);
            if(string.IsNullOrWhiteSpace(maMH) || string.IsNullOrWhiteSpace(tenMH) || string.IsNullOrWhiteSpace(kieuThi))
            {
                throw new Exception("Vui lòng nhập dữ liêu");
            }
            maMH.Trim(); tenMH.Trim(); kieuThi.Trim();
            try
            {
                return DAL_MonHoc.Instance.Them(maMH, tenMH, kieuThi, tin, tiet);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Sua(string maMH,string tenMH, string kieuThi, string soTin, string soTiet)
        {
            if (!Int32.TryParse(soTin, out int tin)) throw new Exception("Vui lòng nhập số tín");
            if (!Int32.TryParse(soTiet, out int tiet)) throw new Exception("Vui lòng nhập số tín");
            if (string.IsNullOrEmpty(tenMH)) throw new Exception("Tên môn học không được trống");
            try
            {
                return DAL_MonHoc.Instance.Sua(maMH,tenMH, kieuThi, tin, tiet);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable TimKiem(string maMH, string tenMH)
        {
            if (string.IsNullOrEmpty(maMH) && string.IsNullOrWhiteSpace(tenMH))
            {
                return DanhSach();
            }
            try
            {
                return DAL_MonHoc.Instance.TimKiem(maMH.Trim(), tenMH.Trim());
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable DanhSach()
        {
            return DAL_MonHoc.Instance.DanhSach();
        }

        public bool Xoa(string maMH)
        {
            try
            {
                return DAL_MonHoc.Instance.Xoa(maMH);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
