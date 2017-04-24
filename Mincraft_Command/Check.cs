using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mincraft_Command
{
    public class Check
    {
        public static bool Check_V_N(string a)
        {
            return Check_Void(a) && Check_is_Number(a);
        } 

        public static bool Check_Void(string a)
        {
            if (a == "")
            {
                MessageBox.Show("字段值不能为空!");
                return false;
            }
            return true;
        }

        public static bool Check_is_Number(string a)
        {
            int result = 0;
            if (!int.TryParse(a, out result))
            {
                MessageBox.Show("有些字段只能以数字组成!");
                return false;
            }
            return true;
        }
    }
}
