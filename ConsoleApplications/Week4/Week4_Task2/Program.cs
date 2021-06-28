using System;
using System.Linq;

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

           int sum=array.Sum();

            

            Console.WriteLine("\nThe sum of the array elements is:\n");
            Console.WriteLine(sum);



        }
    }
}
