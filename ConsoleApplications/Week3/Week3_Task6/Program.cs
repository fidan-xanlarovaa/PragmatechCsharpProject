using System;

namespace Week3_Task6
{
    class Program
    {


        static void Main(string[] args)
        {
            int number;

            Console.WriteLine("How many names would you insert?");
            number = Convert.ToInt32(Console.ReadLine());

            int[] RandomNumbers = new int[number];
            Random RandomNum = new Random();

            string[] Names = new string[number];
            string[] firstCommand = new string[number / 2];
            string[] secondCommand = new string[number / 2];

            while (number % 2 != 0)
            {
                Console.WriteLine("Pls enter an even number");
                number = Convert.ToInt32(Console.ReadLine());
            }



            for (int i = 0; i < number; i++)
            {
                Console.WriteLine($"Pls enter {i + 1} element of array");
                Names[i] = Console.ReadLine();

                if (i > 0)
                {
                x:
                    for (int j = i - 1; j >= 0; j--)
                    {


                        if (Names[j] == Names[i])
                        {
                            Console.WriteLine("This name alredy entered pls enter another name,this name alredy entered");
                            Names[i] = Console.ReadLine();
                            goto x;
                        }


                    }
                }
            }




            Console.WriteLine("\nAll names we have\n");
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine(Names[i]);
            }


            for (int i = 0; i < number; i++)
            {
                RandomNumbers[i] = RandomNum.Next(number);

                if (i > 0)
                {
                x:
                    for (int j = i - 1; j >= 0; j--)
                    {
                        if (RandomNumbers[j] == RandomNumbers[i])
                        {
                            RandomNumbers[i] = RandomNum.Next(number);
                            goto x;

                        }
                    }
                }


            }

            
            for (int i = 0; i < number / 2; i++)
            {
                firstCommand[i] = Names[RandomNumbers[i]];
                secondCommand[i] = Names[RandomNumbers[number - i - 1]];
            }

            Console.WriteLine("\n\nThese are our first team members\tThese are our second team members");
            for (int i = 0; i < number / 2; i++)
            {
                Console.WriteLine($"{firstCommand[i]}\t\t\t\t\t{secondCommand[i]}");
            }



        }



    }
}
