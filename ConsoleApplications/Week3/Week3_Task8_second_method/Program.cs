using System;

namespace Week3_Task8_second_method
{
    class Program
    {
        public int i;

        static void Main(string[] args)
        {
            int total = 0;
            int[] RandomNumbers = new int[10];
            Random RandomNum = new Random();
            for (int i = 0; i < 10; i++)
            {
                RandomNumbers[i] = RandomNum.Next(10);

            x:
                

                if (i > 0)
                {

                    for (int j = i - 1; j >= 0; j--)
                    {
                        if (RandomNumbers[j] == RandomNumbers[i])
                        {
                            RandomNumbers[i] = RandomNum.Next(10);
                            total++;
                            goto x;
                        }
                    }
                }
            }

            Console.WriteLine("\n\nOur array elements:\n");

            string str = String.Join(",", RandomNumbers);

            Console.WriteLine(str);


            Console.WriteLine($"\n\nThe total numberof duplicates displayed is {total}.\n");

            

        }
    }
}