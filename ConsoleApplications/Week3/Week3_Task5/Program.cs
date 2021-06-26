using System;

namespace Week3_Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            Console.WriteLine("Pls enter a number");
            int number = Convert.ToInt32(Console.ReadLine());

            string[] arrayOfString = new string[number];

            for (int i = 0; i < number; i++)
            {
                Console.WriteLine($"Pls enter {i + 1} element of array");
                arrayOfString[i] = Console.ReadLine();
            }

            Console.WriteLine("Which name would you select?");
            string name = Console.ReadLine();

            for (int i = 0; i < number; i++)
            {
                if (arrayOfString[i] == name)
                {
                    total += 1;
                }
            }



            if (total == 0)
            {
                Console.WriteLine($"The entered name was {name}\nSorry but our array doesn't contain this name.");
            }

            else
            {
                Console.WriteLine($"The entered name was {name}.\nThe number of this name in our array is {total}.");
            }


        }
    }
}