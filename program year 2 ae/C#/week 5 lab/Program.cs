using System;
using System.Collections;
using System.Collections.Generic;

namespace MyNamespace
{
    public enum RoleType
    {
        Manager,
        Associate,
        Admin,
        Intern
    }

    class Employee
    {
        // Private data
        private string name = "";
        private RoleType role = RoleType.Intern;
        private double salary = 0;
        // Implementing properties
        public string Name
        {
            get { return (name); }
            set { name = value; }
        }
        public RoleType Role
        {

            get { return (role); }
            set { if (((int)value >= (int)RoleType.Manager) && ((int)value <= (int)RoleType.Intern)) { role = value; } }
            
        }
        public double Salary
        {
            get { return (salary); }
            set { if ((value >= 10000) && (value <= 100000)) { salary = value; } }
        }
    }

    public class MyClass
    {
        public static void Main(string[] args)
        {
            int i = 0;
            int c = 1;
            int r = 0;
            // List of objects
            List<Employee> Employees = new List<Employee>();

            while (c < 4)
            {
                Console.WriteLine("\n Main Menu \n");
                Console.WriteLine("1. Add new record");
                Console.WriteLine("2. List all records");
                Console.WriteLine("3. List records by role");
                Console.WriteLine("4. Exit");
                c = Convert.ToInt32(Console.ReadLine());
                switch (c)
                {
                    case 1:
                        Console.WriteLine("\n Adding new record \n");
                        Employee a = new Employee();
                        // Enter data
                        Console.Write("Enter name: ");
                        a.Name = Convert.ToString(Console.ReadLine());
                        Console.Write("Enter a role (0: Manager, 1: Associate, 2: Admin, 3: Intern): ");
                        r = Convert.ToInt32(Console.ReadLine());
                        a.Role = (RoleType)r;
                        Console.Write("Enter salary: ");
                        a.Salary = Convert.ToDouble(Console.ReadLine());
                        // Save object to list
                        Employees.Add(a);
                        break;
                    case 2:
                        Console.WriteLine("\n Listing all records \n");
                        i = 1;
                        foreach (Employee b in Employees)
                        {
                            Console.WriteLine("{0}. {1} {2} {3}", i, b.Name, b.Role, b.Salary);
                            i = i + 1;
                        }
                        break;
                    case 3:
                        Console.Write("Enter a role (0: Manager, 1: Associate, 2: Admin, 3: Intern): ");
                        r = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("You selected {0}: ", (RoleType)r);
                        i = 1;
                        foreach (Employee b in Employees)
                        {
                            if (r == (int)b.Role)
                            {
                                Console.WriteLine("{0}. {1} {2} {3}", i, b.Name, b.Role, b.Salary);
                                i = i + 1;
                            }
                        }
                        break;
                }
            }
        }
    }
}