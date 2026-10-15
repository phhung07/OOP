using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace TestGK2
{
    internal class SmartWatch : Device, INetworkConnectable
    {
        private int thoiluongpin;
        public int Thoiluongpin
        {
            get { return thoiluongpin; }
            set { if (value > 0) thoiluongpin = value; }
        }
        public SmartWatch(string matb, string tentb, double giaban, int thoiluongpin) : base(matb, tentb, giaban)
        {
            this.thoiluongpin = thoiluongpin;
        }
        public override void ShowSpec()
        {
            Console.WriteLine($"Ma thiet bi: {matb}");
            Console.WriteLine($"Ten thiet bi: {tentb}");
            Console.WriteLine($"Gia ban: {giaban:N0}VNĐ");
            Console.WriteLine($"Thoi luong pin: {thoiluongpin} gio");
        }
        public void ConnectToWifi(string networkName)
        {
            Console.WriteLine($"SmartWatch {tentb} da ket noi vao mang Wifi: {networkName}");
        }
    }
    internal interface INetworkConnectable
    {
        void ConnectToWifi(string networkName);
    }
}
