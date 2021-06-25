using System;

namespace Week3_Task8
{
    class Program
    {   public int i;

        static void Main(string[] args)
        {
            int total_0 = 0, total_1 = 0,total_2 = 0,total_3 = 0,total_4 = 0,total_5 = 0,total_6 = 0,total_7 = 0,total_8 = 0, total_9 = 0;
            int[] RandomNumbers = new int[10];
            Random RandomNum = new Random();
            for (int i = 0; i < 10; i++)
            {
                RandomNumbers[i] = RandomNum.Next(10);
                
                x:
                switch (RandomNumbers[i])
                {
                    case 0:
                        total_0++;
                        break;
                    case 1:
                        total_1++;
                        break;
                    case 2:
                        total_2++;
                        break;
                    case 3:
                        total_3++;
                        break;
                    case 4:
                        total_4++;
                        break;
                    case 5:
                        total_5++;
                        break;
                    case 6:
                        total_6++;
                        break;
                    case 7:
                        total_7++;
                        break;
                    case 8:
                        total_8++;
                        break;
                    case 9:
                        total_9++;
                        break;
                    default:
                        break;
                }

                if (i > 0)
                {
                
                    for (int j = i - 1; j >= 0; j--)
                    {
                        if (RandomNumbers[j] == RandomNumbers[i])
                        {   
                            RandomNumbers[i] = RandomNum.Next(10);
                            goto x;
                        }
                    }
                }
            }

            Console.WriteLine("\n\nOur array elements:\n");

            string str = String.Join(",", RandomNumbers);
           
            Console.WriteLine(str);

            
            Console.WriteLine("\n\nThe numbers which is displayed more than 1\tThe number of times they displayed\n");

            if (total_0 > 1)
                   Console.WriteLine($"zero :\t\t\t\t\t\t {total_0}");
            if (total_1 > 1)
                Console.WriteLine($"one :\t\t\t\t\t\t {total_1}");
            if (total_2 > 1)
                Console.WriteLine($"two :\t\t\t\t\t\t {total_2}");
            if (total_3 > 1)
                Console.WriteLine($"three :\t\t\t\t\t\t {total_3}");
            if (total_4 > 1)
                Console.WriteLine($"four :\t\t\t\t\t\t {total_4}");
            if (total_5 > 1)
                Console.WriteLine($"five :\t\t\t\t\t\t {total_5}");
            if (total_6 > 1)
                Console.WriteLine($"six :\t\t\t\t\t\t {total_6}");
            if (total_7 > 1)
                Console.WriteLine($"seven :\t\t\t\t\t\t {total_7}");
            if (total_8 > 1)
                Console.WriteLine($"eight :\t\t\t\t\t\t {total_8}");
            if (total_9 > 1)
                Console.WriteLine($"nine :\t\t\t\t\t\t {total_9}");

        }
    }
}
