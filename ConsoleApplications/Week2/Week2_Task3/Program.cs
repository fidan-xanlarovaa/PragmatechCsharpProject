using System;

namespace Week2_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int integer;

            Console.WriteLine("Pls enter the integer");
            integer = Convert.ToInt32(Console.ReadLine());


            if (integer % 2 == 0)
            {
                Console.WriteLine($"Integer {integer} is an even number.");
            }

            else
            {
                Console.WriteLine($"Integer {integer} is an odd number.");
            }
        }
    }
}