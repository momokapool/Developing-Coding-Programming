using oop_c_;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_c_
{
    class Student
    {
        public string name;
        public int age;

        public void setName(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return name;
        }
    }

    class MonthName
    {
        private int month = 1;
        //declare a variable

        public int Month
        {
            get {  return (month); }
            set { if ((value > 0) && (value < 13)) { month = value; } }}
        }
        /* get method: return month variable (integer), set method: create a condition to input value and condition
        satisfied, set input value equal to month value f the class */
        
    }

    class QuadraticEquation
    {
        private double a;
        private double b;
        private double c;
        private double d;
        private double? x1;
        private double? x2;


        public void Calculate(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            d = Convert.ToDouble(b * b - 4 * a * c);
            if ((a != 0) && (d >= 0))
            {
                x1 = Convert.ToDouble((-b + Math.Sqrt(d) / (2 * a)));
                x2 = Convert.ToDouble((-b - Math.Sqrt(d) / (2 * a)));

                Console.WriteLine(Convert.ToString(x1));
                Console.WriteLine(Convert.ToString(x2));
            }
            else
            {
                x1 = null; x2 = null;

                Console.WriteLine(Convert.ToString(x1));
                Console.WriteLine(Convert.ToString(x2));
            }
        }

        public double? X1 { get { return x1; } set { this.x1 = X1; } }
        public double? X2 { get { return x2; } set { this.x2 = X2; } }
        
    }
class MyClass
{
    public void Call(int p)
    {
        Console.WriteLine("Ali");
    }
    public void Call(double p)
    {
        Console.WriteLine("Bli");
    }
    public void Call(char p)
    {
        Console.WriteLine("Cli");
    }
}






internal class Program
    {
        static void Main(string[] args)
        {
            String S;
            //new string
            System.Globalization.DateTimeFormatInfo Months = new System.Globalization.DateTimeFormatInfo();
            //Months variable use data of DateTimeFormatInfo which fetch data of date and time 
            MonthName a = new MonthName();
            //new object belong to class MonthName
            
            a.Month = 3;
            //object a call the public method of class (Month), get value = 3

            S = Convert.ToString(Months.GetMonthName(a.Month));
            //Convert number to string
            System.Console.WriteLine(S);





            QuadraticEquation q = new QuadraticEquation();
            q.Calculate(3, 4, 5);
            Console.WriteLine("x1={0}, x2={0}", q.X1, q.X2);
            
            MyClass myClass = new MyClass();
            myClass.Call(1);
            myClass.Call(2.5);
            myClass.Call('a');          

    }
    }

