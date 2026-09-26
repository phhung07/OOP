using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_3_B3
{
    class program
    {
        static void Main(string[] args)
        {
            GiaoDich[] danhsach = new GiaoDich[6];
            danhsach[0] = new GiaoDichVang("GDV01", new DateTime(2026, 07, 29), 5000000000, 2, "9999");
            danhsach[1] = new GiaoDichVang("GDV02", new DateTime(2026, 06, 23), 900000000, 3, "24K");
            danhsach[2] = new GiaoDichVang("GDV03", new DateTime(2026, 07, 26), 700000000, 1, "9999");
            danhsach[3] = new GiaoDichTienTe("GDT01", new DateTime(2026, 01, 01), 10000, 5, 2, "VN");
            danhsach[4] = new GiaoDichTienTe("GDT02", new DateTime(2026, 02, 02), 20000, 10, 1, "USD");
            danhsach[5] = new GiaoDichTienTe("GDT03", new DateTime(2026, 03, 03), 30000, 15, 3, "Euro");
          
            double tongtienvang = 0;
            double tongtientiente = 0;
            int tongluongvang = 0;
            int tongluongtienvn = 0;
            int tongluongtienusd = 0;
            int tongluongtieneuro = 0;
            foreach (GiaoDich gd in danhsach)
            {
                if(gd is GiaoDichVang gdv)
                {
                    tongluongvang += gdv.soLuong;
                }
                if(gd is GiaoDichTienTe gdtt)
                {
                    if(gdtt.loaiTienTe == "USD")
                    {
                        tongluongtienusd += gdtt.soLuong;
                    }
                    if(gdtt.loaiTienTe == "Euro")
                    {
                        tongluongtieneuro += gdtt.soLuong;
                    }
                    if (gdtt.loaiTienTe == "VN")
                    {
                        tongluongtienvn += gdtt.soLuong;
                    }
                }
            }
            foreach (GiaoDich gd in danhsach)
            {
                if (gd is GiaoDichVang gdv)
                {
                    tongtienvang += gdv.soLuong * gdv.donGia;
                }

                if (gd is GiaoDichTienTe gdtt)
                {
                    if (gdtt.loaiTienTe == "USD" || gdtt.loaiTienTe == "Euro")
                    {
                        tongtientiente += gdtt.soLuong * gdtt.donGia * gdtt.tiGia;
                    }

                    if (gdtt.loaiTienTe == "VN")
                    {
                        tongtientiente += gdtt.soLuong * gdtt.donGia;
                    }
                }
            }
            Console.WriteLine("Tong luong vang: " + tongluongvang);
            Console.WriteLine("Tong tien USD: " + tongluongtienusd);
            Console.WriteLine("Tong tien Euro: " + tongluongtieneuro);
            Console.WriteLine("Tong tien VN: " + tongluongtienvn);
            Console.WriteLine("Tong tien giao dich vang: " + tongtienvang);
            Console.WriteLine("Tong tien giao dich tien te: " + tongtientiente);
            double trungbinh = tongtientiente / 3;
            Console.WriteLine("Trung binh thanh tien cua giao dich tien te: " + trungbinh);
            Console.WriteLine("Cac giao dich co don gia > 1 ty:");
            foreach (GiaoDich gd in danhsach)
            {
                if (gd.donGia > 1000000000)
                {
                    Console.WriteLine("Ma giao dich: " + gd.maGiaoDich);
                    Console.WriteLine("Ngay giao dich: " + gd.ngayGiaodich);
                    Console.WriteLine("Don gia: " + gd.donGia);
                    Console.WriteLine("So luong: " + gd.soLuong);
                }
            }
        }
    }
}
