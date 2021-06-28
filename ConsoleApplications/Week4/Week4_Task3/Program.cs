using System;

namespace Week4_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            int total = 0;
            Console.WriteLine("How many words would you initialize first?");
            int number1 = Convert.ToInt32(Console.ReadLine());
            string[] stringArray1 = new string[number1];
            int z = number1;
            
            
            for (int i = 0; i < number1; i++)
            {
                Console.WriteLine($"Pls enter{i+1} word");
                str = Console.ReadLine();
                stringArray1[i] = str;
            }

            Console.WriteLine("How many words would you initialize second?");
            int number2 = Convert.ToInt32(Console.ReadLine());
            if (number2 < number1)
            {
                z = number2;
            }
            string[] stringArray3 = new string[z];
            int k = 0;

            string[] stringArray2 = new string[number2];

            for (int i = 0; i < number2; i++)
            {
                Console.WriteLine($"Pls enter{i + 1} word");
                str = Console.ReadLine();
                stringArray2[i] = str;
            }

            Console.WriteLine("\nThe list of dublicate words:");
            
            for (int i = 0; i < number1; i++)
            {
               
                for (int j = 0; j < number2; j++)
                {
                    if (stringArray1[i]==stringArray2[j] && stringArray3[j]!= stringArray1[i])
                    {
                        stringArray3[k] = stringArray1[i];
                        Console.WriteLine(stringArray1[i]);
                        total++;
                        k++;
                    }

                }

            }

            Console.WriteLine($"\nThe number of dublicate words is {total}");
        }
    }
}
