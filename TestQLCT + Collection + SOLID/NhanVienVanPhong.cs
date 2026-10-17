using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestQLCT___Collection___SOLID
{
    internal class NhanVienVanPhong : NhanVien
    {
        private int songaycong;
        public int Songaycong
        {
            get { return songaycong; }
            set { if (value >= 0 && value <= 26) songaycong = value; }
        }
        private double phucap;
        public double Phucap
        {
            get { return phucap; }
            set { if (value >= 0) phucap = value; }
        }
        public NhanVienVanPhong(string manv, string tennv, DateTime ngaysinh, DateTime ngayvaolam, double luongcoban, bool danglamviec, int songaycong, double phucap)
            : base(manv, tennv, ngaysinh, ngayvaolam, luongcoban, danglamviec)
        {
            this.songaycong = songaycong;
            this.phucap = phucap;
        }
        public override double Tinhluong()
        {
            return luongcoban * songaycong / 26 + phucap;
        }
        public override double Tinhthuong()
        {
            if(songaycong >= 26)
            {
                return luongcoban * 0.1;
            }
            return 0;
        }
        public override void Hienthi()
        {
            Console.WriteLine("----------Nhan Vien Van Phong----------");
            base.Hienthi();
            Console.WriteLine("So ngay cong: " + songaycong);
            Console.WriteLine("Phu cap: " + phucap);
        }
    }
}
