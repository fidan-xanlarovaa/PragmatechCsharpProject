using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string letter1, letter2, letter3;

            Console.WriteLine("Enter first letter");
            letter1 = Console.ReadLine();

            Console.WriteLine("Enter second letter");
            letter2 = Console.ReadLine();

            Console.WriteLine("Enter third letter");
            letter3 = Console.ReadLine();

            Console.WriteLine($"{letter3} {letter2} {letter1}");

        }
    }
}
