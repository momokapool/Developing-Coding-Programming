using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_5
{
    public enum Season
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }

    public enum Days
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }



    public enum employee
    {
        Manager,
        Dev,
        Tester,
        Designer
    }



    class Employee
    {
        public int employeeID {  get; set; }
        public string name { get; set; }
        public employee role { get; set; }       //declare the enum here bruh

        public void DisplayDetail()
        {
            Console.WriteLine(employeeID + " " + name + " " + role);
        }
    }

    internal class Program
    {
        static void Main(string[] args) 
        {
            Season season = Season.Spring;
            Console.WriteLine(season);

            season = season + 3;
            Console.WriteLine(season);

            season = (Season)2;
            Console.WriteLine(season);

            Days day = Days.Friday;
            Console.WriteLine(day);


            //Employee employee = new Employee(employeeID = 1, name = "oe", role = ) ;


            Console.WriteLine(Generic.Addition<int>(1, 2));

            int x = 0; 
            int y = 1;


            ref_swap.Swap(ref x, ref y); //goi tu ten class, neu trong class ko co object thiphai dung static

            Person[] people = new Person[10];

            for(int i = 0; i < people.Length; i++)
            {
                people[i] = new Person();
                people[i].setName(Console.ReadLine());  
            }


            for(int i = 0;i < people.Length; i++)
            {
                Console.WriteLine(people[i].name);
            }

            Animal[] animal = new Animal[3];
            animal[0] = new Dog("Fuwawa"); 
            animal[1] = new Dog("Mococo");
            animal[2] = new Cat("Zeta");

            animal[0].MakeSound();

            List<Animal> animal_list = new List<Animal>();
            animal_list.Add(animal_list[0]); 

            DateTime a = DateTime.Now;
            Console.WriteLine(a);

           


        }
    }
}
