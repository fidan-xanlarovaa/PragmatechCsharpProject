using System;

namespace Week3_Task11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prime numbers till 100");
            for (int i = 2; i < 101; i++)
            {
                int k = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        k++;
                    }
                }

                if (k == 2)
                {
                    Console.WriteLine(i);
                }

            }
        }
    }
}