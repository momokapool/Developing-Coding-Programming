using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void PhuongTrinhBac2(double a, double b, double c)
        {
            double x1, x2, D;
            D = Convert.ToDouble(b*b - 4*a*c);
            if ((a!=0) & (D > 0)){
                x1 = Convert.ToDouble((-b + Math.Sqrt(D)) / (2 * a));
                x2 = Convert.ToDouble((-b - Math.Sqrt(D)) / (2 * a));
                Console.WriteLine("Result: ", x1, x2);
            }
            else 
            {
                Console.WriteLine("No solution");
            }
        }
        static void Main(string[] args)
        {
            double v1, v2, v3;
            v1 = Convert.ToDouble(Console.ReadLine());
            v2 = Convert.ToDouble(Console.ReadLine());
            v3 = Convert.ToDouble(Console.ReadLine());
            PhuongTrinhBac2(v1, v2, v3);
        }
    }
}
