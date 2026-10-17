using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;

namespace TestQLCT___Collection___SOLID
{
    internal abstract class NhanVien
    {
        private string manv;
        public string Manv
        {
            get { return manv; }
            set { if (!string.IsNullOrEmpty(value)) manv = value; }
        }
        private string tennv;
        public string Tennv
        {
            get { return tennv; }
            set { if (!string.IsNullOrEmpty(value)) tennv = value; }
        }
        public DateTime ngaysinh;
        private DateTime Ngaysinh
        {
            get { return ngaysinh; }
            set { if (value < DateTime.Now) ngaysinh = value; }
        }
        private DateTime ngayvaolam;
        public DateTime Ngayvaolam
        {
            get { return ngayvaolam; }
            set { if (value < DateTime.Now) ngayvaolam = value; }
        }
        protected double luongcoban;
        public double Luongcoban
        {
            get { return luongcoban; }
            set { if (value > 0) luongcoban = value; }
        }
        private bool danglamviec;
        public bool Danglamviec
        {
            get { return danglamviec; }
            set { danglamviec = value; }
        }
        public NhanVien(string manv, string tennv, DateTime ngaysinh, DateTime ngayvaolam, double luongcoban, bool danglamviec)
        {
            this.manv = manv;
            this.tennv = tennv;
            this.ngaysinh = ngaysinh;
            this.ngayvaolam = ngayvaolam;
            this.luongcoban = luongcoban;
            this.danglamviec = danglamviec;
        }
        public abstract double Tinhluong();
        public abstract double Tinhthuong();
        public int Tinhthamnien()
        {
            if(DateTime.Now.Year - ngayvaolam.Year < 0)
            {
                return 0;
            }
            else
            {
                int nam = DateTime.Now.Year - ngayvaolam.Year;
                return nam;
            }
        }
        public virtual void Hienthi()
        {
            Console.WriteLine("Ma nhan vien: " + manv);
            Console.WriteLine("Ten nhan vien: " + tennv);
            Console.WriteLine("Ngay sinh: " + ngaysinh);
            Console.WriteLine("Ngay vao lam: " + ngayvaolam);
            Console.WriteLine("Luong co ban: " + luongcoban);
            Console.WriteLine("Dang lam viec: " + danglamviec);
        }
    }
}
