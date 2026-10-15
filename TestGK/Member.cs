using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace TestGK
{
    internal class Member
    {
        private string matv;
        public string Matv
        {
            get { return matv; }
            set { if (!string.IsNullOrEmpty(value)) matv = value; }
        }
        private string tentv;
        public string Tentv
        {
            get { return tentv; }
            set { if (!string.IsNullOrEmpty(value)) tentv = value; }
        }
        private string vaitro;
        public string Vaitro
        {
            get { return vaitro; }
            set { if (!string.IsNullOrEmpty(value) && (value == "Developer" || value == "Tester")) vaitro = value; }
        }
        public Member(string matv, string tentv, string vaitro)
        {
            this.matv = matv;
            this.tentv = tentv;
            this.vaitro = vaitro;
        }
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Ma thanh vien: {Matv}");
            Console.WriteLine($"Ten thanh vien: {Tentv}");
            Console.WriteLine($"Vai tro: {Vaitro}");
        }
    }
}
