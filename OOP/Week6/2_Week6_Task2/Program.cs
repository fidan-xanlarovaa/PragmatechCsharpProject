using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Week6_Task2
{
    class Program
    {
        /*
            *  Muellim modeli yaradin, id, adi,soyadi,vezifesi,
            *  dogum tarixi, ise baslama tarixi, 
            *  islediyi yer
            *  datalarini saxlasin.
            *  Id: sadece oxuna biler auto yaradilacaq.
            *  Vezife: daxil edilmeyibse null-dursa Teacher deye set edilsin.
            *  Ise Baslama tarixi : Muellimin eger 23 yasi varsa muellim olaraq fealiyyet gostere biler.
            */

        #region Sual
        /*Console-dan DataTime deyerini nece daxil etmek olar
         _id -nin her defe 1 vahid artmasini nece temin ede bilerik?*/
        #endregion
        static void Main(string[] args)
        {
            
            Teacher teacher = new Teacher();
            Console.WriteLine("Muellimin adini daxil edin");
            teacher.Name = Console.ReadLine();
           
            Console.WriteLine("Muellimin soyadini daxil edin");
            teacher.Surname = Console.ReadLine();

            Console.WriteLine("Muellimin vezifesini daxil edin");
            teacher.Position = Console.ReadLine();

            Console.WriteLine("Muellimin islediyi yeri daxil edin");
            teacher.SchoolNumber = Console.ReadLine();

            teacher.BirthDay = DateTime.Now.AddYears(-22);
            teacher.Date = DateTime.Now;
            teacher.ShowDate();
            teacher.CanWork();
            Console.ReadLine();

            //Teacher teacher1 = new Teacher();
            //Console.WriteLine("Muellimin adini daxil edin");
            //teacher1.Name = Console.ReadLine();

            //Console.WriteLine("Muellimin soyadini daxil edin");
            //teacher1.Surname = Console.ReadLine();

            //Console.WriteLine("Muellimin vezifesini daxil edin");
            //teacher1.Position = Console.ReadLine();

            //Console.WriteLine("Muellimin islediyi yeri daxil edin");
            //teacher1.SchoolNumber = Console.ReadLine();

            //teacher1.BirthDay = DateTime.Now.AddYears(-24);
            //teacher1.Date = DateTime.Now;
            //teacher1.ShowDate();
            //teacher1.CanWork();


            //Teacher teacher2 = new Teacher();
            //Console.WriteLine("Muellimin adini daxil edin");
            //teacher2.Name = Console.ReadLine();

            //Console.WriteLine("Muellimin soyadini daxil edin");
            //teacher2.Surname = Console.ReadLine();

            //Console.WriteLine("Muellimin vezifesini daxil edin");
            //teacher2.Position = Console.ReadLine();

            //Console.WriteLine("Muellimin islediyi yeri daxil edin");
            //teacher2.SchoolNumber = Console.ReadLine();

            //teacher2.BirthDay = DateTime.Now.AddYears(-56);
            //teacher2.Date = DateTime.Now;
            //teacher2.ShowDate();
            //teacher2.CanWork();
            //Console.ReadLine();






        }
    }
}
