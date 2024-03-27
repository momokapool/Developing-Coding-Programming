using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_c_
{
    internal class polymophism
    {
        class MyClass
        {
            public void Call(int p)
            {
                Console.WriteLine("Ali");
            }
            public void Call(double p)
            {
                Console.WriteLine("Ali");
            }
            public void Call(char p)
            {
                Console.WriteLine("Ali");
            }
        }
    }
}
