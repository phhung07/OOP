using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Module_3_B2
{
    class program
    {
        static void Main(string[] args)
        {
            Sach[] danhSach = new Sach[6];
            danhSach[0] = new SachGiaoKhoa("SGK01", new DateTime(2026, 9, 1), 50000, 10, "K", "moi");
            danhSach[1] = new SachGiaoKhoa("SGK02", new DateTime(2026, 9, 2), 60000, 5, "A", "cu");
            danhSach[2] = new SachGiaoKhoa("SGK03", new DateTime(2026, 9, 3), 70000, 8, "K", "moi");
            danhSach[3] = new SachThamKhao("STK01", new DateTime(2026, 9, 1), 80000, 5, "B", 10000);
            danhSach[4] = new SachThamKhao("STK02", new DateTime(2026, 9, 2), 90000, 10, "C", 20000);
            danhSach[5] = new SachThamKhao("STK03", new DateTime(2026, 9, 3), 100000, 6, "D", 15000);
            double tongtienSGK = 0;
            double tongtienSTK = 0;           
            foreach(Sach sach in danhSach)
            {
                if(sach is SachGiaoKhoa sgk && sgk.tinhTrang == "cu")
                {
                    tongtienSGK += sach.donGia * sach.soLuong * 0.5;
                }
                if (sach is SachGiaoKhoa sgk2 && sgk2.tinhTrang == "moi")
                {
                    tongtienSGK += sach.donGia * sach.soLuong;
                }
                if(sach is SachThamKhao stk)
                {
                    tongtienSTK += sach.donGia * sach.soLuong + stk.thue;
                }
            }
            Console.WriteLine("Tong tien sach giao khoa: " + tongtienSGK);
            Console.WriteLine("Tong tien sach tham khao: " + tongtienSTK);
            Console.Write("Nhap nha xuat ban: ");
            string nhaXuatBan = Console.ReadLine();
            foreach(Sach sach in danhSach)
            {
                if(sach.nhaXuatBan == nhaXuatBan && sach is SachGiaoKhoa)
                {
                    Console.WriteLine("Ma sach: " + sach.maSach + ",ngay nhap: " + sach.ngayNhap + ",don gia: " + sach.donGia + ",so luong: " + sach.soLuong + ",nha xuat ban: " + sach.nhaXuatBan);
                }
            }
            double thanhtiencaonhat = 0;
            foreach (Sach sach in danhSach)
            {
                double thanhtien = 0;
                if (sach is SachGiaoKhoa sgk && sgk.tinhTrang == "cu")
                {
                    thanhtien = sach.donGia * sach.soLuong * 0.5;
                }
                if (sach is SachGiaoKhoa sgk2 && sgk2.tinhTrang == "moi")
                {
                   thanhtien= sach.donGia * sach.soLuong;
                }
                if (sach is SachThamKhao stk)
                {
                  thanhtien= sach.donGia * sach.soLuong + stk.thue;
                }
                if(thanhtien>thanhtiencaonhat)
                {
                    thanhtiencaonhat = thanhtien;
                }
            }
            Console.WriteLine("Thanh tien cao nhat: " + thanhtiencaonhat);
        }
    }
}
