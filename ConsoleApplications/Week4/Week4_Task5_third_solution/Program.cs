using System;

namespace Week4_Task5_third_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many numbers would you initialize?");
            int number, number1 = Convert.ToInt32(Console.ReadLine());
            int[] numberArray1 = new int[number1];
            int[] numberArray2 = new int[number1];
            int k = 0;

            for (int i = 0; i < number1; i++)
            {

                Console.WriteLine($"Pls enter {i + 1} number.");
                number = Convert.ToInt32(Console.ReadLine());
                numberArray1[i] = number;
                if (number%2!=0)
                {
                    numberArray2[k]=number;
                    k++;
                }

            }

            Console.WriteLine("\n\nOur array elements:\n");

            string str = String.Join(",", numberArray1);
            Console.WriteLine(str);
        


            Console.WriteLine("\n\nOur array elements after deletion process:\n");

            for (int i = 0; i<k; i++)
            {
                Console.WriteLine(numberArray2[i]);
            }

            
        }
    }
}
