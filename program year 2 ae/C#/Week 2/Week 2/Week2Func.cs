using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2
{
    internal class Week2Func
    {
        static public void Func1() //phai co static de call ham trong Main ae
        {
            int a;
            int b = 5;
            a = 10;
            Console.WriteLine("mmb = {0} {1}", a, b);
        }

        static public void Func2()
        {
            double input;
            bool Flag;
            input = Convert.ToDouble(Console.ReadLine());
            Flag = input > 10;
            Console.WriteLine("{0}", Flag);
        }

        static public void Grade() 
        {
            double grade;
            Console.WriteLine("Enter the grade: ");
            grade = Convert.ToDouble(Console.ReadLine());
            if (grade > 8)
            {
                Console.WriteLine("Pro ae");
            }
            else
            {
                if (grade > 6)
                {
                    Console.WriteLine("Good");
                }
                else if (grade == 5)
                {
                    Console.WriteLine("Ayanokoji Kiyotaka");
                }
                else
                {
                    Console.WriteLine(" Cx dc");
                }
            }

        }

        static public void ForLoopPractice()
        {
            for (int i = 1; i <100; i += 2) 
            {
                Console.WriteLine(i);
            }

            string[] array1 = { "me", "may", "beo" };
            foreach(string s in array1)
            {
                Console.WriteLine(s);
            }
        }

        static public void Month()
        {
            System.Globalization.DateTimeFormatInfo Months = new System.Globalization.DateTimeFormatInfo();
            //string MonthName = Convert.ToString(Months.GetMonthName(2));
            //Console.WriteLine(MonthName);

            string[] months = new string[12]; 

            for(int i = 1; i < 13; i++)
            {
                string MonthName = Convert.ToString(Months.GetMonthName(i));
                months[i] = MonthName;
                Console.WriteLine(months[i]);
            }
            

           

        }

        static public void MaxMin()
        {

        }
    }
}
