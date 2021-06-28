using System;

namespace Week4_Task1_second_method
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            Random RandomNum = new Random();
            Console.WriteLine("Actual array is:\n");

            for (int i = 0; i < 5; i++)
            {
                array[i] = RandomNum.Next(5);
                Console.WriteLine(array[i]);
            }



            Console.WriteLine("\nReversed array is:\n");


            for (int j = array.Length - 1; j > -1; j--)
            {
                Console.WriteLine(array[j]);
            }






        }
    }
}
