using QLSV.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace QLSV.BLL
{
    public class BLL_Diem
    {
        private static BLL_Diem? instance = null;

        public static BLL_Diem Instance
        {
            get
            {
                if (instance == null) instance = new BLL_Diem();
                return instance;
            }
            private set => instance = value;
        }
        private BLL_Diem() { }

        public bool Them(string maSV, string maMH, string cc, string tx, string kt)
        {
            if (!double.TryParse(cc, out double chuyenCan)) throw new Exception("Điểm chuyên cần phải là số");
            if (!double.TryParse(tx, out double thuongXuyen)) throw new Exception("Điểm thường xuyên phải là số");
            if (!double.TryParse(kt, out double ketThuc)) throw new Exception("Điểm kết thúc phải là số");
            try
            {
                return DAL_Diem.Instance.Them(maSV, maMH, chuyenCan, thuongXuyen, ketThuc);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public DataTable DanhSach()
        {
            return DAL_Diem.Instance.DanhSach();
        }

        public DataTable TraDiem(string maSV, string maMH)
        {
            if ((string.IsNullOrWhiteSpace(maSV) && string.IsNullOrWhiteSpace(maMH)) || string.IsNullOrEmpty(maSV)) return DanhSach();
            return DAL_Diem.Instance.TraDiem(maSV, maMH);
        }

        public bool Sua(string maSV, string maMH, string cc, string tx, string kt)
        {
            if (!double.TryParse(cc, out double chuyenCan)) throw new Exception("Điểm chuyên cần phải là số");
            if (!double.TryParse(tx, out double thuongXuyen)) throw new Exception("Điểm thường xuyên phải là số");
            if (!double.TryParse(kt, out double ketThuc)) throw new Exception("Điểm kết thúc phải là số");
            try
            {
                return DAL_Diem.Instance.Sua(maSV, maMH, chuyenCan, thuongXuyen, ketThuc);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Xoa(string maSV, string maMH)
        {
            try
            {
                return DAL_Diem.Instance.Xoa(maSV, maMH);

            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
