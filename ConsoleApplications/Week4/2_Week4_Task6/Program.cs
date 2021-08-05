using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Week4_Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dagum ilinizi daxil edin:");
            int z = Convert.ToInt32(Console.ReadLine());
            DateTime w = DateTime.Now;
            Console.WriteLine(w.Year-z);
        }
    }
}
