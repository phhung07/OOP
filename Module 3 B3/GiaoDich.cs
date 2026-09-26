using System;

namespace Module_3_B3
{
    public class GiaoDich
    {
        public string maGiaoDich { get; }
        public DateTime ngayGiaodich { get; }
        public double donGia { get; }
        public int soLuong { get; }
        public GiaoDich(string maGiaoDich, DateTime ngayGiaodich, double donGia, int soLuong)
        {
            this.maGiaoDich = maGiaoDich;
            this.ngayGiaodich = ngayGiaodich;
            this.donGia = donGia;
            this.soLuong = soLuong;
        }
    }
}
