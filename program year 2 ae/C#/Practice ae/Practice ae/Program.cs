using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_ae
{
    namespace MyNameSpace
    {
        class HelloWorld
        {
            static double SquareRoot(double Result)
            {
                return (Math.Sqrt(Result));
            }
            static void Main(string[] args)
            {
                Console.WriteLine("Hello World");
                Console.WriteLine(SquareRoot(16));
                double Value = Convert.ToDouble( Console.ReadLine());
                Console.WriteLine(SquareRoot(Value));
                
            }
        }
    }
}
