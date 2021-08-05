using System;

namespace _2_Week4_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 2, 9, 4, 3, 5, 1, 7 };
            int x = intArray[0];

            for (int i = 0; i < intArray.Length; i++)
            {
                for (int j = 0; j < intArray.Length; j++)
                {
                    if (intArray[i] < intArray[j])
                    {
                        x = intArray[i];
                        intArray[i] = intArray[j];
                        intArray[j] = x;
                    }
                }

            }

            foreach (int item in intArray)
            {
                Console.WriteLine(item);
            }

        }
    }
}
