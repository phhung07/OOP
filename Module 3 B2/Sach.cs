using System;

namespace Module_3_B2
{
    public class Sach
    {
        public string maSach { get; set; }
        public DateTime ngayNhap { get; set; }
        public double donGia { get; set; }
        public int soLuong { get; set; }
        public string nhaXuatBan { get; set; } 
        public Sach(string maSach, DateTime ngayNhap, double donGia, int soLuong, string nhaXuatBan)
        {
            this.maSach = maSach;
            this.ngayNhap = ngayNhap;
            this.donGia = donGia;
            this.soLuong = soLuong;
            this.nhaXuatBan = nhaXuatBan;
        }
    }
}
