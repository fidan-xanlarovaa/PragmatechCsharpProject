using System;

namespace Week3_Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string letter;
            Console.WriteLine("Printing alphabet using ASCII caracters.\n");
            for (int i = 97; i < 123; i++)
            {
                letter = char.ConvertFromUtf32(i);
                Console.WriteLine(letter);
            }
        }
    }
}
