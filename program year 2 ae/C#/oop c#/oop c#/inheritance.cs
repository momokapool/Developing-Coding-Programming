using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_c_
{
    internal class inheritance
    {
        class Vehicle
        {
            public void say() { Console.WriteLine("Vehicle"); }

        }

        class Car:Vehicle 
        {
            public new void say() { Console.WriteLine("Car"); }
        }
    }
}
