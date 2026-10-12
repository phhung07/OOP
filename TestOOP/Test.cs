using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOOP
{
    internal class Test
    {
        static void Main(string[] args)
        {
            List<NhanVien> list = new List<NhanVien>();
            list.Add(new NhanVienVanPhong("NV001", "Nguyen Van An", new DateTime(2002, 5, 12), new DateTime(2023, 3, 1), 12000000, true, 26, 1500000));
            list.Add(new NhanVienVanPhong("NV002", "Tran Thi Binh", new DateTime(2001, 11, 20), new DateTime(2024, 1, 15), 10000000, true, 23, 500000));
            list.Add(new NhanVienKinhDoanh("NV003", "Le Quoc Cuong", new DateTime(2000, 2, 3), new DateTime(2022, 6, 10), 7500000, true, 32000000));
            list.Add(new NhanVienKinhDoanh("NV004", "Pham Minh Duc", new DateTime(2002, 8, 16), new DateTime(2024, 7, 1), 8000000, true, 65000000));
            foreach (var NhanVien in list)
            {
                Console.WriteLine("--------------------------------------------------");
                NhanVien.Showinfo();
                Console.WriteLine("Luong: " + NhanVien.Tinhluong());
                Console.WriteLine("Thuong: " + NhanVien.Tinhthuong());
                Console.WriteLine("Tham nien: " + NhanVien.Tinhthamnien() + " nam");
            }
        }
    }
}
