using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGK2
{
    internal abstract class Device
    {
        protected string matb;
        public string Matb
        {
            get { return matb; }
            set { if (!string.IsNullOrEmpty(value)) matb = value; }
        }
        protected string tentb;
        public string Tentb
        {
            get { return tentb; }
            set { if (!string.IsNullOrEmpty(value)) tentb = value; }
        }
        protected double giaban;
        public double Giaban
        {
            get { return giaban; }
            set { if (value > 0) giaban = value; }
        }
        public Device(string matb, string tentb, double giaban)
        {
            this.matb = matb;
            this.tentb = tentb;
            this.giaban = giaban;
        }
        public abstract void ShowSpec();
    }
}
