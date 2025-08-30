using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap2
{
    public class ThietBi
    {
        public string maThietBi { get; set; }
        public string tenThietBi { get; set; }
        public string nuocSanXuat {  get; set; }
        public int donGia { get; set; }
        public int soLuong {  get; set; }

        public ThietBi(string matb, string tentb, string nuocsx, int dongia, int soluong)
        {
            maThietBi = matb;
            tenThietBi = tentb;
            nuocSanXuat = nuocsx;
            donGia = dongia;
            soLuong = soluong;
        }

        public int TinhThanhTien()
        {
            return donGia * soLuong;
        }

        public string HienThi()
        {
            return string.Format("{0} : {1} : {2} : {3} : {4}", maThietBi, tenThietBi, nuocSanXuat, donGia, soLuong);
        }
    }
}
