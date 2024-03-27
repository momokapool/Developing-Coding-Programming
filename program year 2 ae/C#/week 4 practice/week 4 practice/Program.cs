using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_4_practice
{
    internal class Program
    {
        class Yotsuba
        {
            public Yotsuba() { Console.WriteLine("This is Yotsuba"); }
            public void Say() { Console.WriteLine("Yotsuba"); }
        }


        class Shiba: Yotsuba
        {
            public Shiba() { Console.WriteLine("This is Shiba"); }
            public new void Say() { Console.WriteLine("Shiba"); }
        }

        class Shibata : Yotsuba
        {
            public Shibata() { Console.WriteLine("This is Shibata"); }
            public new void Say() { Console.WriteLine("Shibata"); }
        }

        class Kuroba : Yotsuba
        {
            public Kuroba() { Console.WriteLine("This is Kuroba"); }
            public new void Say() { Console.WriteLine("Kuroba"); }
        }


        static void Main(string[] args)
        {
            Yotsuba Shiba_Tatusuya = new Shiba();
            Yotsuba Kuroba_Fumiya = new Kuroba();
        }
    }
}
