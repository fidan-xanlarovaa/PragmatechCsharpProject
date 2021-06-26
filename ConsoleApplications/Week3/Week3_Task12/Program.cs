using System;

namespace Week3_Task12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pls enter 2 numbers.");
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Prime numbers betwen {number1} and {number2}.");
            for (int i = number1; i <= number2; i++)
            {
                int k = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        k++;
                    }
                }

                if (k == 2)
                {
                    Console.WriteLine(i);
                }

            }
        }
    }
}