using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Week4_Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] banknote = { 200, 100, 50, 20, 10, 5, 1 };
            int banknoteCount;
            while (true)
            {
                int money = Convert.ToInt32(Console.ReadLine());
                if (money <= 0)
                {
                    break;
                }
                for (int i = 0; i <= banknote.Length - 1; i++)
                {
                    banknoteCount = money / banknote[i];
                    if (banknoteCount != 0)
                        Console.WriteLine(banknoteCount.ToString() + " number : " + Convert.ToString(banknote[i] + " AZN "));
                    money %= banknote[i];
                }
            }
        }
    }
}
