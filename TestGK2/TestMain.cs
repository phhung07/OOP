using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGK2
{
    internal class TestMain
    {
        static void Main(string[] args)
        {
            SmartWatch sw = new SmartWatch("SW001", "Apple Watch", 10000000, 18);
            Console.WriteLine("Thong tin thiet bi:");
            sw.ShowSpec();
            Console.WriteLine("Ket noi thiet bi");
            sw.ConnectToWifi("MyHomeWifi");
        }
    }
}
