using System;

namespace Module_3_B3
{
    public class GiaoDichTienTe : GiaoDich
    {
        public double tiGia { get; }
        public string loaiTienTe { get; }
        public GiaoDichTienTe(string maGiaoDich, DateTime ngayGiaodich, double donGia, int soLuong, double tiGia, string loaiTienTe) : base(maGiaoDich, ngayGiaodich, donGia, soLuong)
        {
            this.tiGia = tiGia;
            this.loaiTienTe = loaiTienTe;
        }
    }
}
