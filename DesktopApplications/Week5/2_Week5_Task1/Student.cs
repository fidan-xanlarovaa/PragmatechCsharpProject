using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Week5_Task1
{
    class Student
    {


        public static string AddName()
        {
            Console.WriteLine("Zehmet olmasa adiniz,soyadinizi ve imtahan neticelerinizi daxil edin");
            string name = Console.ReadLine();
            string surname = Console.ReadLine();

            return name + " " + surname;
        }

        public static int ReadTheResult()
        {
            string result;
            int result1;
            result = Console.ReadLine();
            
            if (result == "")
            {
                result1 = 51;
                
            }
            else
            {
                result1 = Convert.ToInt32(result);
            }
          return result1; 
        }
       public static int[] CheckResult()
        {
            int[] results = new int[3];
            int result;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Zehmet olmasa {i + 1}-ci imtahanin neticesini daxil edin");

            checkAgain:
                try
                {


                    result = ReadTheResult(); 
                    while (result < 0 || result > 100)
                    {
                        Console.WriteLine("Daxil etdiyiniz reqem dogru deyil.Eded 0 ve 100 araliqinda olmalidir.");
                        result = Convert.ToInt32(Console.ReadLine());
                        
                    }
                }

                catch (Exception)
                {
                    
                    Console.WriteLine("Zehmet olmasa eded daxil edin");
                    goto checkAgain;

                }
                results[i] = result;


            }

            return results;

        }

        public static double Calculate(int[] arr)
        {
            double avarage;
            int total = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                total += arr[i];
            }


            avarage = total / arr.Length;
            return avarage;
        }

        public static void CheckAvarage(double avarage)
        {
            if (avarage>81)
            {
                Console.WriteLine("Tebrikler!!! Siz diplom isine dushdunuz.");
            }
            else
            {
                Console.WriteLine($"Teesssufler olsunki sizin {avarage} oralamaniz,diplom isi ucun yeterli deyil");
            }
        }
    }
}
