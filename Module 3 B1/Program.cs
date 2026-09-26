using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_3_B1
{
    class program
    {
        static void Main(string[] args)
        {
            ChuyenXe[] danhSach = new ChuyenXe[4];
            danhSach[0] = new ChuyenXeNoiThanh("NT01", "Nguyen Van A", "59A-12345", 5, 100, 500000);
            danhSach[1] = new ChuyenXeNoiThanh("NT02", "Nguyen Van B", "59B-67890", 8, 150, 700000);
            danhSach[2] = new ChuyenXeNgoaiThanh("NT03", "Nguyen Van C", "59C-11111", "Da Lat", 3, 2000000);
            danhSach[3] = new ChuyenXeNgoaiThanh("NT04", "Nguyen Van D", "59D-22222", "Vung Tau", 2, 1500000);
            double doanhThuNoiThanh = 0;
            double doanhThuNgoaiThanh = 0;
            foreach (ChuyenXe xe in danhSach)
            {
                if (xe is ChuyenXeNoiThanh)
                {
                    doanhThuNoiThanh += xe.doanhThu;
                }
                if (xe is ChuyenXeNgoaiThanh)
                {
                    doanhThuNgoaiThanh += xe.doanhThu;
                }
            }
            double tongDoanhThu = doanhThuNoiThanh + doanhThuNgoaiThanh;
            Console.WriteLine("Doanh thu xe noi thanh : " + doanhThuNoiThanh);
            Console.WriteLine("Doanh thu xe ngoai thanh : " + doanhThuNgoaiThanh);
            Console.WriteLine("Tong doanh thu: " + tongDoanhThu);
        }
    }
}
