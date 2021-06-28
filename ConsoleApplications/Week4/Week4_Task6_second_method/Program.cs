using System;

namespace Week4_Task6_second_method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many numbers would you initialize?");
            int number, number1 = Convert.ToInt32(Console.ReadLine());
            int[] numberArray1 = new int[number1];
            int min;


            for (int i = 0; i < number1; i++)
            {

                Console.WriteLine($"Pls enter {i + 1} number.");
                number = Convert.ToInt32(Console.ReadLine());
                numberArray1[i] = number;
            }

            Console.WriteLine("\n\nOur array elements:\n");

            string str = String.Join(",", numberArray1);
            Console.WriteLine(str);

            min = numberArray1[0];
            for (int i = 0; i < number1; i++)
            {
                if (numberArray1[i] < min)
                {
                    min = numberArray1[i];
                }

            }
            Console.WriteLine($"\nThe minimum element of our array is {min}");
        }
    }
}
