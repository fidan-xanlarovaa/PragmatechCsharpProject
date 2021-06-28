using System;
using System.Linq;

namespace Week4_Task2_second_method
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[] array = new int[5];
            Random RandomNum = new Random();

            for (int i = 0; i < 5; i++)
            {
                array[i] = RandomNum.Next(5);
                sum += array[i];
            }

            string str1 = String.Join(",", array);

            Console.WriteLine("Actual array is:\n");
            Console.WriteLine(str1);





            Console.WriteLine("\nThe sum of the array elements is:\n");
            Console.WriteLine(sum);



        }
    }
}
