using QLSV.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLSV.DAL.Interfaces
{
    public interface IDiem
    {
        bool Them(DiemDTO diem);
        List<DiemDTO> DanhSach();
        List<DiemDTO> TraDiem(string maSV, string maMH);
        bool Sua(DiemDTO diem);
        bool Xoa(DiemDTO diem);
    }
}
