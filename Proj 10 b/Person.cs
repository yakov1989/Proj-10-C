using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_10_b
{
    class Person
    {
        string name;
        int age;
        Car myCar;

        public Person() : this("yakov", 29,new Car()) { }
        
        public void SetCar(Car c)
        {
            myCar = c;
        }
        public Person(string n,int A,Car Mc)
        {
            name = n;
            age = A;
            myCar = Mc;
        }

        public void Print()
        {
            Console.WriteLine();
            Console.WriteLine($"{name} ,{age }");
            myCar.Print();
            Console.WriteLine();
        }
    }
}
