using System;
using System.Collections.Generic;
using System.Text;

namespace QLSV
{
    public static class NguoiDung
    {
        private static string tenDangNhap = string.Empty;

        public static string TenDangNhap { get => tenDangNhap; set => tenDangNhap = value; }
        private static string matKhau = string.Empty;
        public static string MatKhau { get => matKhau; set => matKhau = value; }

    }
}
