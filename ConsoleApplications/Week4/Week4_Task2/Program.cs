using System;

namespace Week4_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            Random RandomNum = new Random();

            for (int i = 0; i < 5; i++)
            {
                array[i] = RandomNum.Next(5);
            }

            string str1 = String.Join(",", array);

            Console.WriteLine("Actual array is:\n");
            Console.WriteLine(str1);

            Array.Reverse(array);

            string str = String.Join(",", array);

            Console.WriteLine("\nReversed array is:\n");
            Console.WriteLine(str);



        }
    }
}
