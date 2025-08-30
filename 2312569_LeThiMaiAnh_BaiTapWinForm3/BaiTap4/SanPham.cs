using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap4
{
    public class SanPham
    {
        public string maSP {  get; set; }
        public string tenSP {  get; set; }
        public string loaiSP {  get; set; }
        public DateTime ngaySX { get; set; }

        public SanPham()
        {
                
        }

        public int NamHetHan()
        {
            return this.ngaySX.Year + 3;
        }

        public string HienThi()
        {
            return string.Format("{0}, {1}, {2}, {3}", maSP,tenSP,loaiSP,ngaySX);
        }

    }
}
