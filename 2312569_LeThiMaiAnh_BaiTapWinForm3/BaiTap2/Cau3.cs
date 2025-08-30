using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap2
{
    public class Cau3
    {
        public static void NoiChuoi(string ho, string ten, ref string s)
        {
            s = ho + " " + ten;
        }

        public static long GiaiThua(long n)
        {
            

            if (n == 0 || n == 1)
            {
                return 1;
            }


            return n * GiaiThua(n - 1);
        }
    }
}
