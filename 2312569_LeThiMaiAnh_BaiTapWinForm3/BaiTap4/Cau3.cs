using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap4
{
    public class Cau3
    {
        public static void ChaoHoi(string hoten, bool gioitinh)
        {
            if (gioitinh)
            {
                MessageBox.Show("Chào Ông " + hoten, "Lời chào");
            }
            else
            {
                MessageBox.Show("Chào Bà " + hoten, "Lời chào");
            }
        }

        public static int USCLN(int m, int n)
        {
            if(m==n) return m;
            if (m < n)
            {
                int temp = m;
                m = n;
                n=temp;
            }

            while (n != 0)
            {
                int r = m % n;
                m = n;
                n = r;
            }
            return m;
        }
    }
}
