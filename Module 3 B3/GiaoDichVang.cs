using System;

namespace Module_3_B3
{
    public class GiaoDichVang : GiaoDich
    {
        public string loaiVang { get; }
        public GiaoDichVang(string maGiaoDich, DateTime ngayGiaodich, double donGia, int soLuong, string loaivang) : base(maGiaoDich, ngayGiaodich, donGia, soLuong)
        {
            this.loaiVang = loaiVang;
        }
    }
}
