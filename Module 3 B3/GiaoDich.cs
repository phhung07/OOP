using System;

namespace Module_3_B3
{
    public abstract class GiaoDich
    {
        private string maGiaoDich;
        private DateTime ngayGiaodich;
        private double donGia;
        private int soLuong;
        public string MaGiaoDich
        { 
            get { return maGiaoDich; } 
            set { if(!string.IsNullOrEmpty(value)) maGiaoDich = value; } 
        }
        public DateTime NgayGiaoDich
        {
            get { return ngayGiaodich; }
            set { if(value <= DateTime.Now) ngayGiaodich = value; }
        }       
        public double DonGia
        {
            get { return donGia; }
            set { if (value > 0) donGia = value; }
        }
        public int SoLuong
        {
            get { return soLuong; }
            set { if (value > 0) soLuong = value; }
        }
        public GiaoDich(string maGiaoDich, DateTime ngayGiaodich, double donGia, int soLuong)
        {
            this.maGiaoDich = maGiaoDich;
            this.ngayGiaodich = ngayGiaodich;
            this.donGia = donGia;
            this.soLuong = soLuong;
        }        
    }
}
