using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap3
{
    public class Cau3
    {
        public static void TachChuoi(string hoten,ref string s1,ref string s2)
        {
            string[] parts = hoten.Split(' ');
            s1 = parts[0];
            s2 = parts[parts.Length - 1];
        }

        public static bool ThuTu(int n1, int n2)
        {
            if(n2==n1+1 || n1==n2+1) return true;
            else return false;
        }
    }
}
