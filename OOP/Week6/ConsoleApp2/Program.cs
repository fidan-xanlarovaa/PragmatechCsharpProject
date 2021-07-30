using System;
namespace defaultConstractor
{
    public class Counter
    {
        private Counter()   //private constrctor declaration  
        {
        }

        public static int currentview;
        public static int visitedCount()
        {
            return ++currentview;
        }
    }
    class viewCountedetails
    {
        static void Main()
        {
            // Counter aCounter = new Counter();   // Error  
            Console.WriteLine("-------Private constructor example by vithal wadje----------");
            Console.WriteLine();
            Counter.currentview = 500;
            Counter.visitedCount();
            Console.WriteLine("Now the view count is: {0}", Counter.currentview);
            Console.ReadLine();
        }
    }
}