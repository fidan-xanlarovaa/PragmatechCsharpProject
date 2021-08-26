using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Week6_Task1
{/*
             * Console-dan daxil edilen en ve uzunluga gore duzbucaqlinin sahesinin hesablanmasi.
             * class member-ler ve encapsulation movuzlarina uygun isleyin.
             * Qeyd: daxil edilenlerden her hansisa birinin menfi olub olmamasini yoxlayin.
             * menfidirse deyeri 0 beraber edin.
             */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zehmet olmasa duzbucaqlinin enini daxil edin");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Zehmet olmasa duzbucaqlinin uzunluqunu daxil edin");
            int y = Convert.ToInt32(Console.ReadLine());

            Rectangle rc1 = new Rectangle(y,x);
            

            Console.WriteLine($"Duzbucaqlini Sahesi {rc1.Calc()} sm teskil edir");
            int xjkzfbnf = Convert.ToInt32(Console.ReadLine());


        }
    }
}
