using System;

namespace Week3_Task4_firstsolution
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            do
            {
                Console.WriteLine("Pls enter a number");
                number = Convert.ToInt32(Console.ReadLine());

            } while (number == 0);

            int factorial = number;
            for (int i = number - 1; i >= 2; i--)
            {
                factorial *= i;
            }

            Console.WriteLine($"Factorial of {number} is equal to {factorial}");
        }
    }
}
