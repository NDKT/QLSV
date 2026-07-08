using QLSV.DAL;
using QLSV.DAL.Interfaces;
using QLSV.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace QLSV.BLL
{
    public class BLL_Diem
    {
        private static BLL_Diem? instance = null;
        private IDiem diemDAL = DAL_Diem.Instance;
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

        public bool Them(DiemDTO diem)
        {
            try
            {
                return diemDAL.Them(diem);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public List<DiemDTO> DanhSach()
        {
            return diemDAL.DanhSach();
        }

        public List<DiemDTO> TraDiem(string maSV, string maMH)
        {
            if ((string.IsNullOrWhiteSpace(maSV) && string.IsNullOrWhiteSpace(maMH))) return DanhSach();
            return diemDAL.TraDiem(maSV, maMH);
        }

        public bool Sua(DiemDTO diem)
        {
           
            try
            {
                return diemDAL.Sua(diem);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Xoa(DiemDTO diem)
        {
            try
            {
                return DAL_Diem.Instance.Xoa(diem);

            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
