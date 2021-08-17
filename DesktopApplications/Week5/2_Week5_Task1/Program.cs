using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Week5_Task1
{/*
             * Telebinin adini soyadini 3 imtahan neticesini
             * (((her hansisa imtahan neticesi daxil edilmezse default deyer 51 verilecek,
             * daxil edilen imtahan neticeleri0-dan kicik 100-den boyuk ola bilmez,
             * eded yerine simvol ve sair daxil edilen zaman xeta mesaji cixmalidir, yeniden emeliyyati duzgun yerine yetirerek davam etmelidir))) daxil edib,
             * ortalamasini hesablayaraq console-da  adi,soyadi, imtahan neticeleri,
             * ortalamasi, Diplom isine dusub dusmediyi yazilacaq(((bunun ucun ortalama 81den boyuk ve ya beraber olmalidir))).
             *
             * Taski mumkun derece kicik methodlara bolerek her methoda verilen adi ehtiva eden isler gorulsun.
             * Student classi yaradaraq method-lari orada yazib Program classi icerisinde Main methodunda istifade edeceksiz.
             */
    class Program
    {
        



        static void Main(string[] args)
        {
            string fullname = Student.AddName();
            int[] arr = Student.CheckResult();
            double avarage = Student.Calculate(arr);

            Console.WriteLine($"Shagirdin Adi Soyadi: {fullname}");
            Console.WriteLine($"Shagirdin ortalamasi: {avarage}");
            Student.CheckAvarage(avarage);
            Console.ReadLine();


        }
        


    }
       


        
}

