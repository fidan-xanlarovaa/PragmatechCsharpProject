using System;

namespace Task2__w2
{
    class Program
    {
        static void Main(string[] args)
        {
           int integer1,integer2;

            Console.WriteLine("Pls enter first integer");
            integer1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pls enter second integer");
            integer2=Convert.ToInt32(Console.ReadLine());

            if(integer1>integer2){
                Console.WriteLine($"First integer {integer1} is greater than the second intger {integer2}.");
            }
            else if(integer1<integer2){
                Console.WriteLine($"Second integer {integer2} is greater than the first intger {integer1}.");
            }
            else{
                 Console.WriteLine($"First integer {integer1} and the second intger {integer2} are equal.");
            }
        }
    }
}
