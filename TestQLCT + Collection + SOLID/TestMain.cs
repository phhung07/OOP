using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TestQLCT___Collection___SOLID
{
    internal class TestMain
    {
        static void Main(string[] args)
        {
            List<NhanVien> list = new List<NhanVien>();
            list.Add(new NhanVienVanPhong("NV001", "Nguyen Van An", new DateTime(2002, 05, 12), new DateTime(2023, 03, 01), 12000000, true, 26, 1500000));
            list.Add(new NhanVienVanPhong("NV002", "Tran Thi Binh", new DateTime(2001, 11, 20), new DateTime(2024, 01, 15), 10000000, true, 23, 500000));
            list.Add(new NhanVienKinhDoanh("NV003", "Le Quoc Cuong", new DateTime(2000, 02, 03), new DateTime(2022, 06, 10), 7500000, true, 32000000));
            list.Add(new NhanVienKinhDoanh("NV004", "Pham Minh Duc", new DateTime(2002, 08, 16), new DateTime(2024, 07, 01), 8000000, true, 65000000));
            foreach(var nhanvien in list)
            {
                nhanvien.Hienthi();
                Console.WriteLine("Luong: " + nhanvien.Tinhluong());
                Console.WriteLine("Thuong: " + nhanvien.Tinhthuong());
                Console.WriteLine("Tham nien: " + nhanvien.Tinhthamnien());
            }
            Console.WriteLine("----------Tong luong & Tong thuong----------");
            Console.WriteLine("Tong luong: " + Tongluong(list));
            Console.WriteLine("Tong thuong: " + Tongthuong(list));

            Dictionary<string, NhanVien> dic = new Dictionary<string, NhanVien>();
            foreach (var nhanvien in list)
            {
                if (!dic.ContainsKey(nhanvien.Manv))
                {
                    dic.Add(nhanvien.Manv, nhanvien);
                }
            }
            Console.Write("Nhap ma nhan vien can tim: ");
            string macantim = Console.ReadLine().ToUpper();

            if (dic.TryGetValue(macantim, out NhanVien nvcantim))
            {
                nvcantim.Hienthi();
                Console.WriteLine("Luong: " + nvcantim.Tinhluong());
                Console.WriteLine("Thuong: " + nvcantim.Tinhthuong());
            }
            else
            {
                Console.WriteLine("Khong tim thay nhan vien");
            }
        }
        static double Tongluong(List<NhanVien> list)
        {
            double tongluong = 0;
            foreach (var nhanvien in list)
            {
                tongluong += nhanvien.Luongcoban;
            }
            return tongluong;
        }
        static double Tongthuong(List<NhanVien> list)
        {
            double tongthuong = 0;
            foreach (var nhanvien in list)
            {
                tongthuong += nhanvien.Tinhthuong();
            }
            return tongthuong;
        }
    }
}
