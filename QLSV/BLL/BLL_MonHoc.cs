using QLSV.DAL;
using QLSV.DAL.Interfaces;
using QLSV.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace QLSV.BLL
{
    public class BLL_MonHoc
    {
        private static BLL_MonHoc? instance = null;
        private IMonHoc monDAL = DAL_MonHoc.Instance;
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

        public bool Them(MonHocDTO mon)
        {
            if(string.IsNullOrWhiteSpace(mon.MaMH) || string.IsNullOrWhiteSpace(mon.TenMH) || string.IsNullOrWhiteSpace(mon.KieuThi))
            {
                throw new Exception("Vui lòng nhập dữ liêu");
            }
            try
            {
                return monDAL.Them(mon);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Sua(MonHocDTO mon)
        {
            if (mon.Tiet <= 0) throw new Exception("Vui lòng nhập số tín");
            if (mon.TC <= 0) throw new Exception("Vui lòng nhập số tín");
            if (string.IsNullOrEmpty(mon.TenMH)) throw new Exception("Tên môn học không được trống");
            try
            {
                return monDAL.Sua(mon);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<MonHocDTO> TimKiem(string maMH, string tenMH)
        {
            if (string.IsNullOrEmpty(maMH) && string.IsNullOrWhiteSpace(tenMH))
            {
                return DanhSach();
            }
            try
            {
                return monDAL.TimKiem(maMH.Trim(), tenMH.Trim());
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<MonHocDTO> DanhSach()
        {
            return monDAL.DanhSach();
        }

        public bool Xoa(string maMH)
        {
            try
            {
                return monDAL.Xoa(maMH);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
