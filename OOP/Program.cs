using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            student student1 = new student();
            student1.name = "Hung";
            student1.age = 19;
            student1.score = 9;
            student1.study();
            student1.takeExam();
            student1.Ispassed();
        }
    }
    class student
    {
        public string name;
        public int age;
        public double score;
        public void study()
        {
            Console.WriteLine("sinh vien dang hoc");
        }
        public void takeExam()
        {
            Console.WriteLine("sinh vien dang thi");
        }
        public void Ispassed()
        { 
            if (score >= 5)
            {
                Console.WriteLine("sinh vien da qua mon");
            }
            else
            {
                Console.WriteLine("sinh vien chua qua mon");
            }
        }
    }
}
