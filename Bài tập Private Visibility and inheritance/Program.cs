using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_tập_Private_Visibility_and_inheritance
{
    public class A
    {
        private int i = 7;
        protected int F(int j)

        {
            return i + j;
        }
    }
    public class B : A
    {
        public void G()
        {
            Console.WriteLine("i: {0}", i);
            Console.WriteLine("F(5): {0}", F(5));
        }
    }
    public class Client
    {
        static void Main()
        {
            B b = new B();
            b.G();
        }
    }
}
