using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week_3_lab;


namespace Project
{
    class MyClass
    {
        // Data
        private double? Z = null;

        // Functionality
        public void Logarithm(double X, double Y)
        {
            Z = Math.Log(X, Y);
        }
        public double? GetResult()
        {
            return (Z);
        }
    }

    public class MyProject
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Enter A:");
            double A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter B:");
            double B = Convert.ToInt32(Console.ReadLine());

            MyClass MyObject = new MyClass();

            MyObject.Logarithm(A, B);

            //Console.WriteLine("The logarithm of {0} to the base {1} is {2}", A, B, MyObject.GetResult());*/

            Lab_ex_3.Array_Integer();
            Lab_ex_3.Array_Display();

            int Max = Lab_ex_3.Max();
            Console.WriteLine("Max number is: {0}", Max);

            int Min = Lab_ex_3.Min();
            Console.WriteLine("Min number is: {0}", Min);
        }
    }
}



