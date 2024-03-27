using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_5
{
    public class ref_swap
    {
        static public void Swap(ref int i, ref int j) //goi tu ten class, neu trong class ko co object thiphai dung static
        {
            int temp = i;
            i = j;
            j = temp;
        }
    }
}
