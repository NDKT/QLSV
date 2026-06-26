using QLSV.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLSV.DAL.Interfaces
{
    public interface IMonHoc
    {
        bool Them(MonHocDTO mon);
        bool Sua(MonHocDTO mon);
        bool Xoa(string maMH);
        List<MonHocDTO> DanhSach();
        List<MonHocDTO> TimKiem(string maMH, string tenMH);
    }
}
