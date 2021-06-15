using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string surname;
            

            Console.WriteLine("Enter your name");
            name = Console.ReadLine();

            Console.WriteLine("Enter your surname");
            surname = Console.ReadLine();


            Console.WriteLine($"Hello, {name} {surname}. ");
        }
    }
}
