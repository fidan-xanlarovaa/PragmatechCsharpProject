using System;

namespace Week2_Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int integer;

            Console.WriteLine("Pls enter the integer");
            integer = Convert.ToInt32(Console.ReadLine());


            if (integer < 0)
            {
                Console.WriteLine($"Integer {integer} is a negative number.");
            }

            else if (integer > 0)
            {
                Console.WriteLine($"Integer {integer} is a positive number.");
            }

            else
            {
                Console.WriteLine($"Integer {integer} is equal to zero.");
            }
        }
    }
}