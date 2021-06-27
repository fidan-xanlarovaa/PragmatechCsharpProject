using System;

namespace Week3_Task4_second_method
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;

            Console.WriteLine("Pls enter a number");
            number = Convert.ToInt32(Console.ReadLine());

           
                while (number == 0)
                {
                    Console.WriteLine("Pls enter a number");
                    number = Convert.ToInt32(Console.ReadLine());
                }
           

            int factorial = number;

            for (int i = number - 1; i >= 2; i--)
            {
                factorial *= i;
            }

            Console.WriteLine($"Factorial of {number} is equal to {factorial}");

        }
    }
}
