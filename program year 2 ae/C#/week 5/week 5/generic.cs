using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_5
{
    public class Generic
    {
        public static T Addition<T>(T left, T right)
        {
            dynamic x = left;
            dynamic y = right;
            dynamic z = x + y;
            return (z);
        }





    }
}
