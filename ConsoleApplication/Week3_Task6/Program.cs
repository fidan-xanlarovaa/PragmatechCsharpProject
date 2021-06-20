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
            
            while (number % 2 != 0)
            {
                Console.WriteLine("Pls enter an even number");
                number = Convert.ToInt32(Console.ReadLine());
            }

            string[] Names = new string[number];

            for(int i = 0; i < number; i++)
            {
                Console.WriteLine($"Pls enter {i + 1} element of array");
                Names[i] = Console.ReadLine();

                if (i > 0) { 
                
                    for (int j = i-1; j >= 0; j--) {
                    
                        
                        while (Names[j] == Names[i]) 
                        { 
                            Console.WriteLine("This name alredy entered pls enter another name,this name alredy entered");
                            Names[i] = Console.ReadLine();
                        }
                        
               
                    } 
                }
            }

           


            Console.WriteLine("\nAll names we have\n");
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine(Names[i]);
            }


            /*

                        int[] RandomNumbers = new int[number];

                        for (int i = 0; i < number; i++)
                        {
                            Random RandomNum = new Random();
                            int random = RandomNum.Next(number);

                            RandomNumbers[i] = random;

                            if (i > 0)
                            {

                                for (int j = i - 1; j >= 0; j--)
                                {


                                    while (RandomNumbers[j] == RandomNumbers[i])
                                    {

                                         random = RandomNum.Next(number);

                                        RandomNumbers[i] = random;
                                    }


                                }
                            }
                        }*/



        }
    }
}
