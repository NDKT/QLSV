using QLSV.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLSV.DAL.Interfaces
{
    public interface ISinhVien
    {
        public bool Them(SinhVienDTO sv);
        public bool Xoa(string maSV);
        public List<SinhVienDTO> TimKiem(string maSV, string tenSV);
        public bool Sua(SinhVienDTO sv);
        public List<SinhVienDTO> DanhSach();
    }
}
