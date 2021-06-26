using System;

namespace AdditionalTask_1_Discord
{
    /*Write a C# Sharp program which takes a positive number and return the nth odd number.Sample Output:
      1st odd number: 1
      2nd odd number: 3
      4th odd number: 7
      100th odd number: 199*/
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pls enter a positive number");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{number}th odd number is {number * 2 - 1}");
        }
    }
}
