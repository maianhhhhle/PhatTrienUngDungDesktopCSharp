using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap3
{
    public   class NhanVien
    {
        public string maNV {  get; set; }
        public string hoTen { get; set; }
        public DateTime ngaySinh { get; set; }
        public double heSoLuong { get; set; }
        public double heSoPhuCap { get; set; }

        public NhanVien(string manv, string hoten, DateTime ngaysinh, double hesoluong, double hesophucap)
        {
            this.maNV = manv;
            this.hoTen = hoten;
            this.ngaySinh = ngaysinh;
            this.heSoLuong  = hesoluong;
            this.heSoPhuCap = hesophucap;
        }

        public double TongLuong()
        {
            return (heSoPhuCap + heSoLuong) * 1150000;
        }

        public string HienThi()
        {
            return string.Format("{0}, {1}, {2}, {3}, {4}", maNV, hoTen, ngaySinh, heSoLuong, heSoPhuCap);
        }
    }
}
