using System;

namespace Week3_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, numberOfAttempts = 0;
            Random randomNumber = new Random();
            int random = randomNumber.Next(50);
           

            do
            {
                Console.WriteLine("Pls enteryour guess between 0 and 50");
                number = Convert.ToInt32(Console.ReadLine());
                numberOfAttempts++;
                if (number < random)
                {
                    Console.WriteLine("Your guess is less than the actual number");
                    Console.WriteLine($"Your remaining guessing change is {5-numberOfAttempts}.\n");
                }

                if (number > random)
                {
                    Console.WriteLine("Your guess is more than the actual number");
                    Console.WriteLine($"Your remaining guessing change is {5-numberOfAttempts}.\n");
                }



                if (numberOfAttempts == 5)
                {
                    Console.WriteLine($"Your guessing chance is over. The number was {random}");
                    break;
                }

                if (number == random)
                {
                    Console.WriteLine("Congratulations you find the number");
                    break;

                }

            } while (number != random);

        }
    }
}