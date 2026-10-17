using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace TestQLCT___Collection___SOLID
{
    internal class NhanVienKinhDoanh : NhanVien
    {
        private double doanhso;
        public double Doanhso
        {
            get { return doanhso; }
            set { if (value >= 0) doanhso = value; }
        }
        public NhanVienKinhDoanh(string manv, string tennv, DateTime ngaysinh, DateTime ngayvaolam, double luongcoban, bool danglamviec, double doanhso)
            : base(manv, tennv, ngaysinh, ngayvaolam, luongcoban, danglamviec)
        {
            this.doanhso = doanhso;
        }
        public override double Tinhluong()
        {
            return luongcoban + doanhso * 0.03;
        }
        public override double Tinhthuong()
        {
            if (doanhso >= 50000000)
            {
                return 1000000;
            }
            return 0;
        }
        public override void Hienthi()
        {
            Console.WriteLine("----------Nhan Vien Kinh Doanh----------");
            base.Hienthi();
            Console.WriteLine("Doanh so: " + doanhso);
        }
    }
}
