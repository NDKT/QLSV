using System;
using System.Collections.Generic;
using System.Text;

namespace QLSV.DTO
{
    public class LopDTO
    {
        private string maLop = string.Empty;
        private string tenLop = string.Empty;

        public string MaLop { get => maLop; set => maLop = value; }
        public string TenLop { get => tenLop; set => tenLop = value; }
    }
}
