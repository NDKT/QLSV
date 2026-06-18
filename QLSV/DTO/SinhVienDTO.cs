using System;
using System.Collections.Generic;
using System.Text;

namespace QLSV.DTO
{
    public class SinhVienDTO
    {
        private string maSV = string.Empty;
        private string tenSV = string.Empty;
        private DateTime ngayNhapHoc;
        private string queQuan = string.Empty;
        private DateTime ngaySinh;
        private string gioiTinh = string.Empty;
        private string maLop = string.Empty;

        public string MaSV { get => maSV; set => maSV = value; }
        public string TenSV { get => tenSV; set => tenSV = value; }
        public DateTime NgayNhapHoc { get => ngayNhapHoc; set => ngayNhapHoc = value; }
        public string QueQuan { get => queQuan; set => queQuan = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string MaLop { get => maLop; set => maLop = value; }
    }
}
