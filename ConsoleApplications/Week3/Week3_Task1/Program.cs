using System;

namespace Week3_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                    Console.WriteLine($"The number {i}");
                }
            }

            Console.WriteLine($"\n The sum of numbers {sum}");
        }
    }
}