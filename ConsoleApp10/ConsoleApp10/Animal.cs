using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    //동물들이 공통적으로 가지고 있는 특징을 정의함

    public class Animal
    {
        public String Name { get; set;  }
        public int Age { get; set; }


        // 초기화 -> 초기화를 꼭 해야하는 이유? -> 일관성있는 코드를 유지하기 위해서 ,
        // ex) 많은 곳에서 참조가 일어날 경우에 일관성이 있게 값을 참조시키기 위해
        public Animal(String name, int age)
        {
            Name = name;
            Age = age;
        }

        // virtual 이 무엇인지?Speak () 함수가 다시 재정의 될 수 있음을 나타낸다.
        public virtual void Speak()
        {
            Console.WriteLine("동물이 소리를 냅니다.");
        }
        
    }

   
}
