using QLSV.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLSV.DAL.Interfaces
{
    public interface ISinhVien
    {
        public bool Them(SinhVienDTO sv);
        public bool Xoa(SinhVienDTO sv);
        public List<SinhVienDTO> TimKiem(SinhVienDTO sv);
        public bool Sua(SinhVienDTO sv);
        public List<SinhVienDTO> DanhSach();
    }
}
