using QLSV.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLSV.DAL.Interfaces
{
    public interface ILop
    {
        bool Them(LopDTO lop);
        bool Sua(LopDTO lop);
        bool Xoa(string maLop);
        List<LopDTO> DanhSach();
        List<LopDTO> TimKiem(string maLop, string tenLop);
    }
}
