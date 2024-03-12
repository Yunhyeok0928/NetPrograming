using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    public class Dog : Animal
    {
        public Dog(string name, int age) : base(name, age)
        {
        }

        public override void Speak()
        {
            Console.WriteLine("멍멍!");
        }
    }

    public class Cat : Animal
    {
        public Cat(string name, int age) : base(name, age)
        {
        }

        public override void Speak()
        {
            Console.WriteLine("야옹!");
        }
    }

}

