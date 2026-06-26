using System;
using System.Collections.Generic;
using System.Text;

namespace QLSV.DTO
{
    public class DiemDTO
    {
        private string maSV = string.Empty;
        private string maMH = string.Empty;
        private double chuyenCan;
        private double thuongXuyen;
        private double ketThuc;
        private double tongKet;
        private string tenSV = string.Empty;
        private string tenMH = string.Empty;

        public string MaSV { get => maSV; set => maSV = value; }
        public string MaMH { get => maMH; set => maMH = value; }
        public double ChuyenCan { get => chuyenCan; set => chuyenCan = value; }
        public double ThuongXuyen { get => thuongXuyen; set => thuongXuyen = value; }
        public double KetThuc { get => ketThuc; set => ketThuc = value; }
        public double TongKet { get => tongKet; set => tongKet = value; }
        public string TenSV { get => tenSV; set => tenSV = value; }
        public string TenMH { get => tenMH; set => tenMH = value; }
    }
}
