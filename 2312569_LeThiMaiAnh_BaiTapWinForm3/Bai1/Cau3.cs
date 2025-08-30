using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    public class Cau3
    {
        public static void CongHaiSo(int a, int b, ref int s)
        {
            s = a + b;
            
        }

        public static int TongDaySo(int n)
        {
            int tong = 0;
            int i = 1;
            while (i <= n)
            {
                tong += i;
                i++;
            }
            return tong;
        }
    }
}
