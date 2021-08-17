using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Week5_Task2
{
    class atm
    {
        public int balance = 1000;
        Hashtable h1 = new Hashtable();
        public static int Menyu()
        {
            Console.WriteLine("\n\n\nZehmet olmasa sechmek istediyiniz emeliyyatin nomresini daxil edin:\n1.Balans\n2.Negd pulun verilmesi\n3.Balansdan cixaris");

            int number = ValidateMenyu();
            return number;
        }

        public static int ValidateMenyu()
        {
            int number;

        checkAgain:
            try
            {

                number = Convert.ToInt32(Console.ReadLine());
                while (number < 0 || number > 3)
                {
                    Console.WriteLine("Daxil etdiyiniz reqem dogru deyil.Eded 1 ve 3 araliqinda olmalidir.");
                    number = Convert.ToInt32(Console.ReadLine());

                }
            }

            catch (Exception)
            {

                Console.WriteLine("Zehmet olmasa eded daxil edin");
                goto checkAgain;

            }
            return number;
        }

          
        

        public  void Cash()
        {
           
            
            int[] money = { 1, 5, 10, 20, 50, 100, 200 };
            Console.WriteLine("\nElde etmek istediyiniz mebleqi daxil edin");
            int cash = Convert.ToInt32(Console.ReadLine());
            

            if (balance-cash >0)
            {
                balance = balance - cash;
                string x = DateTime.Now.ToString();
                h1.Add(x, cash);
                Console.WriteLine("\nElde etmek istediyiniz mebleg asagidaki eskinaslarla verilimisdir:");
                for (int i = money.Length - 1; i >= 0; i--)
                {
                    int count = cash / money[i];
                    if (count != 0)
                    {
                        Console.WriteLine($"{count} eded {money[i]}");
                    }
                    cash = cash - count * money[i];

                }
            }

            else
            {
                Console.WriteLine("\nTeessufki kartinizda yeterli mebleq yoxdur.");
            }
            
                     

        }  



        public  void Receipt()
        {
            if (h1.Count==0)
            {
                Console.WriteLine("\nKartdan mexaric olunmayib");
                
            }

            else
            {
                ICollection keys = h1.Keys;
                Console.WriteLine("\n");
                foreach (String k in keys)
                {
                    Console.WriteLine($"Siz {k} tarixinde {h1[k]} manat pul cixarisi etmisiniz.");
                }
            }
        }
    }
}
