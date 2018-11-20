using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_10_b
{

    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Print();
            Car c1 = new Car("mazda", 150, 2.2,true);
            Person p2 = new Person("benny",29,c1);
            p2.Print();
        }
    }

    

}
