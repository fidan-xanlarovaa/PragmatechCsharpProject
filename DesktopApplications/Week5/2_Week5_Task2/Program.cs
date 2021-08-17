using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Week5_Task2
{
    class Program
    /*details:

     pin kodun sehv olma hali
    menyudan yanlis reqem secilmesi*/
    {
        /*
            * Evvelceden teyin edilen pin vasitesile ATM-ye yaxinlasan vetendas pini daxil edir.
            * Qarsinina cixan menu-dan balansina baxa, negd pul cixarda, ve ya umumi hesabdan cixaris
            * isteye biler.Secilen her hansi bir emeliyyatdan sonra istifadeci yeniden menuya- geri done bilmelidir.
            *
            *
            * login
            *
            * pin:
            * pin sadece reqemlerden ibaret olmalidir // 1234
            * pin sadece 4 reqemden ibaret olmalidir.
            *
            *
            * Menu
            *
            * 1.Balans:
            * (evvelceden standart olaraq balans 1000 azn olaraq nezerde tutulur.)
            *
            * 2.Negd pulun verilmesi:
            *  Istifadeci ATM-den min 1 manat max 1000 manat ceke biler.Balans yoxlamasi olacaq,
            *  daxil edilen mebleg hansi esginasdan nece eded olacaq o sekilde netice olaraq gosterilir.
            *   
            *
            * 3.Balansdan cixaris:
            *   Eger balansdan mexaric olubsa mexaric olunan meblegi ve hemin tarixi cap edin,
            *   Yox eger hele balansdan mexaric olunmayibsa bu haqqda mesaj gosterin.
            *
            *
            * Qeyd: consoledan daxil edilenler yalniz eded ola biler bular yoxlayanacaq ,
            * mumkun derece methodlarla isleyin
            *   
            */
        


        static void Main(string[] args)
        {


            int num=0;
            string pin = "1234";
            Console.WriteLine("ATM-ye Xosh Geldiniz zehmet olmasa pin kodunuzu daxil edin");
            string pin2=Console.ReadLine();

            atm atm1 = new atm();
            if (pin==pin2)
            {
                do
                {
                    num = atm.Menyu();
                    switch (num)
                    {
                        case 1:
                            Console.WriteLine($"\nSizin hazirki balansiniz {atm1.balance} azn teskil edir");
                            break;
                        case 2:
                            atm1.Cash();
                            
                            break;
                        case 3:
                            
                            atm1.Receipt();
                            break;
                        default:
                            break;
                    }

                } while (num!=0);

                Console.WriteLine("\n\nATM-den istifade etdiyiniz ucun tesekkur edirik.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Daxil etdiyiniz pin dogru deyil");
                Console.ReadLine();
            }
        }
    }
}
