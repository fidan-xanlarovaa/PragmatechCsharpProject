using System;

namespace Week3_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number,sum=0;

            do
            {
                Console.WriteLine("Pls enter a number");
                number =Convert.ToInt32(Console.ReadLine());
                sum += number;
            } while (number != 0);

            Console.WriteLine($"The sum of the entered numbers equal to the {sum}");

           
        }
    }
}
