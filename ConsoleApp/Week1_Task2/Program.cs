using System;

namespace Week1_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string surname;
            int age;
            string uni;

            Console.WriteLine("Enter your name");
            name = Console.ReadLine();

            Console.WriteLine("Enter your surname");
            surname = Console.ReadLine();

            Console.WriteLine("Enter your surname");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your University");
            uni = Console.ReadLine();

            Console.WriteLine("Hello. My name is " + name + " " + surname + ". I am " + age + ". I study in " + uni + ".");
        }
    }
}
