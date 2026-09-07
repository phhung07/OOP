using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Specialization__Extension__and_Inheritance
{
 

    class Animal
    {
        public string Name;

        public Animal(string name)
        {
            Console.WriteLine("Animal constructor is running...");
            Name = name;
        }

        public void Eat()
        {
            Console.WriteLine(Name + " is eating.");
        }
    }

    class Dog : Animal
    {
        public Dog(string name) : base(name)
        {
            Console.WriteLine("Dog constructor is running...");
        }

        public void Bark()
        {
            Console.WriteLine(Name + " is barking.");
        }
    }

    class Program
    {
        static void Main()
        {
            Dog d = new Dog("Lucky");

            Console.WriteLine("Dog name: " + d.Name);

            d.Eat();
            d.Bark();
        }
    }
}
