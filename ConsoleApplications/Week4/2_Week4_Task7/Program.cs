using System;

namespace _2_Week4_Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 2, 9, 4, 3, 5, 1, 7 };
            int x = intArray[0];
            y:
            for (int i = 0; i < intArray.Length; i++)
            {
                
                    if(intArray[i]< intArray[0])
                {
                    x = intArray[i];
                    Console.WriteLine(x);
                    goto y;
                }
                
            }
            Console.ReadLine();
            Console.ReadLine();
        }
    }
}
