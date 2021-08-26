using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Week6_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            EDV edv1=new EDV();
            int mehsulNo;
            int mehsulkq;

            ArrayList mehsulNoArray= new ArrayList();
            ArrayList mehsulkqArray = new ArrayList();
            
            Console.WriteLine("Zehmet olmasa menyudan almaq istediyiniz mehsullarin ilk once nomresini novbeti setirde ise" +
                " qederini daxil edin.\nMeselen 5 ci mehsuldan 3kq 9 cu mehsuldan 1 kq elde etme isteyirsinizse deyerleri " +
                "asaqidaki formada daxil edin:\n5\n3\n9\n1\nDaxil etmek istediyiniz mehsullar bitdikde 0 duymesini basaraq chekinizi elde ede bilersiniz");
            edv1.Menyu();
            while (true)
            {
                mehsulNo = Convert.ToInt32(Console.ReadLine());
                mehsulkq = Convert.ToInt32(Console.ReadLine());
                if (mehsulNo==0)
                {
                    break;
                }
                else
                {
                    mehsulkqArray.Add(mehsulkq);
                    mehsulNoArray.Add(mehsulNo);
                }
            }

            Console.WriteLine("\n\nBonus kartiniz varsa 1 yoxdurs 0 daxil edin:");
            int endirimkarti = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nagd pulla odeyeceksinizse 2 kartla odeyeceksinizse 1 daxil edin");
            int odenisnovu= Convert.ToInt32(Console.ReadLine());
            edv1.PrintCheck(mehsulNoArray, mehsulkqArray);
            edv1.PrintCheck2(odenisnovu);
            Console.WriteLine("___________________________________________________");
            edv1.Money(endirimkarti, odenisnovu);
            Console.ReadLine();



        }
    }
}
