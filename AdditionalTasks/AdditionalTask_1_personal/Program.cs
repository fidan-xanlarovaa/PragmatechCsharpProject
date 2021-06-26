using System;
using System.Linq;

namespace AdditionalTask_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            /*int[] numbers = { 6, 8, 9, 1, 2, 3, 4, 4, 5, 6, 8, 9, 1, 3, 10 };
            int[] dis = numbers.Distinct().ToArray();

            foreach (var i in dis)
            {
                Console.WriteLine(i);
            }*/

            //Array arr = Array.CreateInstance(typeof(int), 5);
            Array arr = Array.CreateInstance(Type.GetType("System.Int32"), 5);
            arr.SetValue(1,0);//teyin etmediyimiz valualari default olaraq 0 qebul edir
            arr.SetValue(2, 1);
            arr.SetValue(3, 2);
            arr.SetValue(4, 3);
            arr.SetValue(5, 4);
            
            
            /*foreach (var i in arr)
            {
                Console.WriteLine(i);
            }*/

            Array neww= Array.CreateInstance(Type.GetType("System.Object"), 5);
            Array.Copy(arr,arr.GetLowerBound(0),neww)

        }
    }
}
