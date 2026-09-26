using System;

namespace Module_3_B2
{
    public class SachThamKhao : Sach
    {
        public double thue { get; set; }
        public SachThamKhao(string maSach, DateTime ngayNhap, double donGia, int soLuong, string nhaXuatBan, double thue) : base(maSach, ngayNhap, donGia, soLuong, nhaXuatBan)
        {
            this.thue = thue;
        }
    }
}
