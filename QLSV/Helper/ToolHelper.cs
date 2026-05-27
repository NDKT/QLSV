using System;
using System.Collections.Generic;
using System.Text;

namespace QLSV.Helper
{
    public class ToolHelper
    {
        public static void DisableBtn(params Button[] btns)
        {
            foreach (var btn in btns)
            {
                btn.Enabled = false;
            }
        }
    }
}
