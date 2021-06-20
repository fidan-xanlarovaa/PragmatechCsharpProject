using System;

namespace Week3_Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine($"\n\nMultiplication table for {i}:\n");

                for (int j = 1; j < 11; j++)
                {
                    Console.WriteLine($"{i}*{j}={i * j}");

                }

            }
        }
    }
}
