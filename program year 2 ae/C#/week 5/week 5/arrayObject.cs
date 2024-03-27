using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_5
{
    public class Person
    {
        public string name;
        public int age;

      
        public void setName(string name)
        {
            this.name = name;
        }

        public void setAge(int age)
        {
            this.age = age;
        }
    }


    public class Animal
    {
        public string name {  get; set; }
        public virtual void MakeSound()
        {
            Console.WriteLine("make sounds");
        }
    }

    class Dog: Animal
    {
        public Dog(string name) { this.name = name; }
        public override void MakeSound()
        {
            Console.WriteLine("Bau bau");
        }
    }


    class Cat : Animal
    {
        public Cat(string name) { this.name = name; }
        public override void MakeSound()
        {
            Console.WriteLine("Nyan");
        }
    }






}
