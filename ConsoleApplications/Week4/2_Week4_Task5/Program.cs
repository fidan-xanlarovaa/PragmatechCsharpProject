using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Week4_Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            for (int i = 1; i <10; i=i+2)
            {
                total = i * i * i + total;
            }
            Console.WriteLine($"1-den 10-a qeder ededlerin kublari cemi {total}-dir.");
        }
    }
}
