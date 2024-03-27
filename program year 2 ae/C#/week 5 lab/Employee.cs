using System;
using System.Collections;
using System.Collections.Generic;

namespace MyNamespace
{
    class Employee
    {
        private string name = "";
        private double salary;
        public string Name
        {
            get { return (name); }
            set { name = value; }
        }
        public double Salary
        {
            get { return (salary); }
            set { if ((value > 10000) && (value < 100000)) { salary = value; } }
        }
    }

    public class MyClass
    {
        public static void Main(string[] args)
        {
            int i;
            // Array of 5 elements
            // Each array element is an object
            Employee[] MyArray = new Employee[5];

            // Initialise the array
            for (i = 0; i < 5; i++)
            {
                MyArray[i] = new Employee();
            }

            // Update the records
            MyArray[0].Name = "John";
            MyArray[0].Salary = 50000;

            MyArray[1].Name = "Ann";
            MyArray[1].Salary = 25000;
         

            // Display all elements from the array
            foreach (Employee a in MyArray)
            {
                Console.WriteLine("{0} {1}", a.Name, a.Salary);
            }

            Console.WriteLine("\n **************** \n");

            // Add third record
            MyArray[2].Name = "Mary";
            MyArray[2].Salary = 40000;

            // Declare a list of objects
            List<Employee> MyList = new List<Employee>();

            // Add the objects to the list
            MyList.Add(MyArray[0]);
            MyList.Add(MyArray[1]);
            MyList.Add(MyArray[2]);

            // Display all items from the list
            foreach (Employee  b in MyList)
            {
                Console.WriteLine("{0} {1}", b.Name, b.Salary);
            }

            Console.WriteLine("\n **************** \n");

            // Access specific element from the array
            Console.WriteLine("Array: {0} {1}", MyArray[1].Name, MyArray[1].Salary);
            // Access specific element from the list
            Console.WriteLine("List: {0} {1}", MyList[1].Name, MyList[1].Salary);
        }
    }
}