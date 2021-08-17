using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        public static int Cash()
        {

            int[] money = { 1, 5, 10, 20, 50, 100, 200 };
            Console.WriteLine("Elde etmek istediyiniz mebleqi daxil edin");
            int cash = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < money.Length; i++)
            {
                int count = cash / money[i];
                if (count != 0)
                {
                    Console.WriteLine($"{count} eded {money[i]}");
                }
                cash = cash - count * money[i];
            }

            
            return cash;

        }

        static void Main(string[] args)
        {
            int a=Cash();
            

            Console.WriteLine(a);
        }
    }
}
