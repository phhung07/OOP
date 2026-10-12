using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOOP
{
    internal class NhanVienKinhDoanh : NhanVien, IThuong
    {
        private double doanhso;
        public double Doanhso
        {
            get { return doanhso; }
            set { if(value >= 0) doanhso = value; }
        }
        public NhanVienKinhDoanh(string manv, string hoten, DateTime ngaysinh, DateTime ngayvaolam, double luongcoban, bool danglamviec, double doanhso)
            : base(manv, hoten, ngaysinh, ngayvaolam, luongcoban, danglamviec)
        {
            this.doanhso = doanhso;
        }
        public override double Tinhluong()
        {
            return luongcoban + doanhso * 0.03;
        }
        public override double Tinhthuong()
        {
            if(doanhso >= 50000000)
            {
                return 1000000;
            }
            return 0;
        }
        public override void Showinfo()
        {
            Console.WriteLine("Nhan vien kinh doanh");
            base.Showinfo();
            Console.WriteLine("Doanh so: " + doanhso);
        }
    }
}
