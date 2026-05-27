using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace QLSV.Helper
{
    public class FormHelper
    {
        public static void BatTatNut(Button btn, params TextBox[] txbs)
        {
            btn.Enabled = false;
            foreach (var txb in txbs)
            {
                txb.TextChanged += (object? sender, EventArgs e) =>
                {
                    bool btnState = true;
                    foreach (var item in txbs)
                    {
                        if (string.IsNullOrEmpty(item.Text)) {
                            btnState = false;
                            break;
                        }
                        
                    }
                    btn.Enabled = btnState;
                };

            }
        }
        public static void ThemDuLieu(DataTable data, DataGridView dgv)
        {
            dgv.DataSource = data;
            dgv.ClearSelection();
        }

        
    }
}
