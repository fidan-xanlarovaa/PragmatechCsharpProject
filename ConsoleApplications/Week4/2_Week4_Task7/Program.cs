using System;

namespace _2_Week4_Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            Console.WriteLine("Iki musbet eded daxil edin");
            int num1=Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < num2; i++)
            {
                total = total + num1;
            }
            Console.WriteLine(total);
        }
    }
}
