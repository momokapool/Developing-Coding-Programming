using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_3_lab
{
    public class Lab_ex_3
    {
        private int MaxPosition;
        private int MinPosition;

        public static int[] Array_Integer()
        {
            Random rnd = new Random();
            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                int num = rnd.Next(1, 100);
                arr[i] = num;
            }
            return arr;
        }

        public static void Array_Display()
        {
            int[] arr = Lab_ex_3.Array_Integer();
            for (int i = 0;i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        public static int Max()
        {
            int[] arr = Lab_ex_3.Array_Integer();
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }

        public static int Min()
        {
            int[] arr = Lab_ex_3.Array_Integer();
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            return min;
        }


        public static int Max_position()
        {
            int[] arr = Lab_ex_3.Array_Integer();
            int max = Lab_ex_3.Max();
            var index = arr.FindIndex(i => i == 7);
        }
    }
}

