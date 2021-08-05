using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Week4_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 6, 9, 12, 15, 7, 3, 20, 14, 36, 24 };
            int x = 0;

            for (int i = 0; i < arr.Length / 2; i++)
            {
                x = arr[i];
                arr[i] = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = x;
            }

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

        }
    }
}
