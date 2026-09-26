using System;

namespace Module_3_B2
{
    public class SachGiaoKhoa : Sach
    {
        public string tinhTrang { get; set; }
        public SachGiaoKhoa(string maSach, DateTime ngayNhap, double donGia, int soLuong, string nhaXuatBan, string tinhTrang) : base(maSach, ngayNhap, donGia, soLuong, nhaXuatBan)
        {
            this.tinhTrang = tinhTrang;
        }
    }
}
