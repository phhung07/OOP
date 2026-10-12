using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOOP
{
    internal abstract class NhanVien
    {
        private string manv;
        public string Manv
        {
            get { return manv; }
            set { if(!string.IsNullOrEmpty(value)) manv = value; }
        }
        private string hoten;
        public string Hoten
        {
            get { return hoten; }
            set { if(!string.IsNullOrEmpty(value)) hoten = value; }
        }
        private DateTime ngaysinh;
        public DateTime Ngaysinh
        {
            get { return ngaysinh; }
            set { if(value < DateTime.Now) ngaysinh = value; }
        }
        private DateTime ngayvaolam;
        public DateTime Ngayvaolam
        {
            get { return ngayvaolam; }
            set { if(value < DateTime.Now) ngayvaolam = value; }
        }
        protected double luongcoban;
        public double Luongcoban
        {
            get { return luongcoban; }
            set { if(value > 0) luongcoban = value; }
        }
        private bool danglamviec;
        public bool Danglamviec
        {
            get { return danglamviec; }
            set { danglamviec = value; }
        }
        public NhanVien(string manv, string hoten, DateTime ngaysinh, DateTime ngayvaolam, double luongcoban, bool danglamviec)
        {
            this.manv = manv;
            this.hoten = hoten;
            this.ngaysinh = ngaysinh;
            this.ngayvaolam = ngayvaolam;
            this.luongcoban = luongcoban;
            this.danglamviec = danglamviec;
        }
        public virtual void Showinfo()
        {
            Console.WriteLine($"Ma nhan vien: {manv}");
            Console.WriteLine($"Ho ten: {hoten}");
            Console.WriteLine($"Ngay sinh: {ngaysinh}");
            Console.WriteLine($"Ngay vao lam: {ngayvaolam}");
            Console.WriteLine($"Luong co ban: {luongcoban}");
            Console.WriteLine($"Dang lam viec: {danglamviec}");
        }
        public abstract double Tinhluong();
        public int Tinhthamnien()
        {
            int nam = DateTime.Now.Year - ngayvaolam.Year;
            return nam;
        }
        public abstract double Tinhthuong();
    }
}
