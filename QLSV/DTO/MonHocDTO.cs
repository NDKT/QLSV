using System;
using System.Collections.Generic;
using System.Text;

namespace QLSV.DTO
{
    public class MonHocDTO
    {
        private string maMH = string.Empty;
        private string tenMH = string.Empty;
        private int tC;
        private string kieuThi = string.Empty;
        private int tiet;

        public string MaMH { get => maMH; set => maMH = value; }
        public string TenMH { get => tenMH; set => tenMH = value; }
        public int TC { get => tC; set => tC = value; }
        public string KieuThi { get => kieuThi; set => kieuThi = value; }
        public int Tiet { get => tiet; set => tiet = value; }
    }
}
