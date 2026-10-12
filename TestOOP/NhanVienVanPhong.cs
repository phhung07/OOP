using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOOP
{
    internal class NhanVienVanPhong : NhanVien, IThuong
    {
        private int songaycong;
        public int Songaycong
        {
            get { return songaycong; }
            set { if(value >= 0 && value <=26) songaycong = value; }
        }
        private double phucap;
        public double Phucap
        {
            get { return phucap; }
            set { if(value >= 0) phucap = value; }
        }
        public NhanVienVanPhong(string manv, string hoten, DateTime ngaysinh, DateTime ngayvaolam, double luongcoban, bool danglamviec, int songaycong, double phucap)
            : base(manv, hoten, ngaysinh, ngayvaolam, luongcoban, danglamviec)
        {
            this.songaycong = songaycong;
            this.phucap = phucap;
        }
        public override double Tinhluong()
        {
            return luongcoban/26 * songaycong + phucap;
        }
        public override double Tinhthuong()
        {
            if(songaycong >= 26)
            {
              return luongcoban * 0.1;
            }
            return 0;
        }
        public override void Showinfo()
        {          
            Console.WriteLine("Nhan vien van phong");
            base.Showinfo();
            Console.WriteLine("So ngay cong: " + songaycong);
            Console.WriteLine("Phu cap: " + phucap);
        }
    }
}
