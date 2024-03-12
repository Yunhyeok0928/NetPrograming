using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {

            Animal[] animals = new Animal[2];
            animals[0] = new Dog("바둑이", 3);
            animals[1] = new Cat("나비", 2);

            foreach ( var animal in animals)
            {
                Console.WriteLine($"{animal.Name}는 / 은 이렇게 말합니다.");
                animal.Speak();
            }
        }
    }
}
