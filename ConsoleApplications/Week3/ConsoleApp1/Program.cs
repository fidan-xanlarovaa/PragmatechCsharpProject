using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creates and initializes a new Array of type Int32.  
            Array oddArray = Array.CreateInstance(Type.GetType("System.Int32"), 5);
            oddArray.SetValue(1, 0);
            oddArray.SetValue(3, 1);
            oddArray.SetValue(5, 2);
            oddArray.SetValue(7, 3);
            oddArray.SetValue(9, 4);
            // Creates and initializes a new Array of type Object.  
            Array objArray = Array.CreateInstance(Type.GetType("System.Object"), 5);
            Array.Copy(oddArray, oddArray.GetLowerBound(0), objArray, objArray.GetLowerBound(0), 4);
            int items1 = objArray.GetUpperBound(0);
            for (int i = 0; i < items1; i++) Console.WriteLine(objArray.GetValue(i).ToString());
        }
    }
}
