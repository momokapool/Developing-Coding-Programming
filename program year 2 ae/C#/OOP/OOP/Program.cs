using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OOP
{
    static class Calculator
    {
        public static double add(double a, double b)
        {
            return a + b;
        }
        public static double minus(double a, double b)
        {
            return a + b;
        }
        public static double multi(double a, double b)
        {
            return a + b;
        }
        public static double div(double a, double b)
        {
            return a + b;
        }
    }


    static class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("enter a:");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter b:");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("choose your operator (+ - * /):");
                string ope = (Console.ReadLine());
                if (ope == "+")
                {
                    double result = Calculator.add(a, b);
                    Console.WriteLine("a + b = {0}", result);
                }
                if (ope == "-")
                {
                    double result = Calculator.minus(a, b);
                    Console.WriteLine("a - b = {0}", result);
            }
                if (ope == "*")
                {
                    double result = Calculator.multi(a, b);
                    Console.WriteLine("a * b = {0}", result);
            }
                if (ope == "/")
                {
                    if (b == 0)
                    {
                        Console.WriteLine("Cannot divide 0");
                    }
                    else
                    {
                        double result = Calculator.div(a, b);
                        Console.WriteLine("a / b = {0}", result);
                    }   
                }
            }
        }
    }

