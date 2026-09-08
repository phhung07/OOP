using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N
{
    public class P 
    {
        public static int p = 10;
        internal static int i = 20;
    }
    internal class  I
    {
        public static int p = 30;
        internal static int i = 40;
    }
    public class A
    {
        public static void Test()
        {
            P p = new P();
            I i = new I();
            Console.WriteLine(P.p);
            Console.WriteLine(P.i);

            Console.WriteLine(I.p);
            Console.WriteLine(I.i);
        }
    }
    class Program
    {
        static void Main()
        {
            N.A.Test();
        }
    }
}
