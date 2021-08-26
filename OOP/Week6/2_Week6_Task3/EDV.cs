using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Week6_Task3
{
    class EDV
    {
        private double edv;
        private ArrayList edvArray = new ArrayList();
        private double endirim;
        private ArrayList endirimArray = new ArrayList();
        private double total;
        private ArrayList totalArray = new ArrayList();
        private double money=450;
        private string data = DateTime.Now.ToString("dd / M / yyyy");
        Random random = new Random();
       

        #region PriceFields       
        private double corekP = 0.50;
        private double etkP = 9.80;
        private double goyertiP = 0.10;

        private double vafliP = 1.70;
        private double almaP = 1.60;
        private double baliqP = 3.70;

        private double mercimekP = 2.10;
        private double zeytunP = 9.90;
        private double limonkP = 4.10;

        private double sokoladP = 0.90;
        private double toyuqP = 5.60;
        private double tomatP = 2.40;
        #endregion

        #region EdvField
        private int corekEdv = 0;
        private int etkEdv = 18;
        private int goyertiEdv = 0;

        private int vafliEdv = 18;
        private int almaEdv = 0;
        private int baliqEdv = 18;

        private int mercimekEdv = 0;
        private int zeytunEdv = 18;
        private double limonkEdv = 0;

        private int sokoladEdv = 18;
        private int toyuqEdv = 18;
        private int tomatEdv = 18;
        #endregion

        #region Salefields
        private int corekEndirim = 0;
        private int etkEndirim= 25;
        private int goyertiEndirim = 0;

        private int vafliEndirim = 30;
        private int almaEndirim = 0;
        private int baliqEndirim = 40;

        private int mercimekEndirim = 0;
        private int zeytunEndirim = 20;
        private double limonkEndirim = 15;

        private int sokoladEndirim = 0;
        private int toyuqEndirim = 0;
        private int tomatEndirim = 50;
        #endregion

        public double TotalEdv()
        {
            double total=0;
            for (int i = 0; i < edvArray.Count; i++)
            {
                total = total + (double)edvArray[i];
            }

            

            return total;
        }

        public double TotalEndirim()
        {
            double total = 0;
            for (int i = 0; i < endirimArray.Count; i++)
            {
                total = total + (double)endirimArray[i];
            }
            return total;
        }
        public double CalcTotal()
        {
            double total=0;
            double endirim = TotalEndirim();
            for (int i = 0; i < totalArray.Count; i++)
            {
                total = total + (double)totalArray[i];
            }
            total = total - endirim;
            return total;
        } 

        public void Money(int endirimKarti, int odenisnovu)
        {
            double a=0; 
            if (450 - CalcTotal()>=0)
            {
                if (odenisnovu == 1)
                {
                    a = TotalEdv() * 0.1;
                }

                else if (odenisnovu == 2)
                {
                    a = TotalEdv() * 0.15;
                }
                money = 450 - CalcTotal() + a;
                if (endirimKarti == 1)
                {
                    money = money + CalcTotal() * 0.02;

                    Console.WriteLine("Odenisiniz ugurla heyata kecirildi");
                }

                
            }

            else
            {
                Console.WriteLine("Tessufki balansinizda bu emeliyyati yerine yetirmek ucun kifayet qeder mebleq yoxdur.");
            }

        }


        

        public void Menyu()
        {
            Console.WriteLine("1. | Corek | 0.50 azn |\n" +
                "2. | Et | 9.80 azn |\n" +
                "3. | Goyerti | 0.10 azn |\n" +
               "4. | Vafli | 1.70 azn |\n" +
                "5. | Alma | 1.60 azn |\n" +
                 "6. | Baliq Konservasi | 3.70 azn |\n" +
                  "7. | Mercimek | 2.10 azn |\n+" +
                   "8. | Zeytun Yaqi | 9.90 azn |\n" +
                     
                     "9. | Limon| 4.10 azn |\n" +
                      "10. | Sokolad | 0.90 azn |\n" +
                       "11. | Toyuq | 5.60 azn |\n"+
                       "12. | Tomat | 2.40 azn |\n+");
        }

        public void PrintCheck(ArrayList No, ArrayList Kq)
        {
                        Console.WriteLine("| mehsul adi        |  miqdar  |  qiymet  |EDV  |toplam|");
            for (int i = 0; i < No.Count; i++)
            {
                switch (No[i])
                {
                    case 1:
                        total= (int)Kq[i] * corekP;
                        endirim = (int)Kq[i] * corekP * corekEndirim / 100;
                        edv = (int)Kq[i] * corekP * corekEdv / 100;

                        Console.WriteLine($"| Corek             |  {Kq[i]}  |  {corekP}  |{corekEdv}  |{total}| ");
                        Console.WriteLine($"  Sizin qazanciniz=================== {endirim} ");

                        totalArray.Add(total);
                        endirimArray.Add(endirim);
                        edvArray.Add(edv);
                        break;

                    case 2:
                        total = (int)Kq[i] * etkP;
                        endirim = (int)Kq[i] * etkP * etkEndirim / 100;
                        edv= (int)Kq[i] * etkP * etkEdv / 100;

                        Console.WriteLine($"| Et                |  {Kq[i]}  |  {etkP}  |{etkEdv}  |{total }| ");
                        Console.WriteLine($"  Sizin qazanciniz=================== {endirim} ");

                        totalArray.Add(total);
                        endirimArray.Add(endirim);
                        edvArray.Add(edv);
                        break;

                    case 3:
                        total = (int)Kq[i] * goyertiP;
                        endirim = (int)Kq[i] * goyertiP * goyertiEndirim / 100;
                        edv = (int)Kq[i] * goyertiP * goyertiEdv / 100;

                        Console.WriteLine($"| Goyerti           | {Kq[i]}   |  {goyertiP}  |{goyertiEdv} |{total}|");
                        Console.WriteLine($"  Sizin qazanciniz=================== {endirim} ");

                        totalArray.Add(total);
                        endirimArray.Add(endirim);
                        edvArray.Add(edv);
                        break;

                    case 4:
                        total = (int)Kq[i] * vafliP;
                        endirim = (int)Kq[i] * vafliP * vafliEndirim / 100;
                        edv = (int)Kq[i] * vafliP * vafliEdv/ 100;

                        Console.WriteLine($"| Vafli             |  {Kq[i]}  |  {vafliP}  |{vafliEdv}  |{total}| ");
                        Console.WriteLine($"  Sizin qazanciniz=================== {endirim} ");

                        totalArray.Add(total);
                        endirimArray.Add(endirim);
                        edvArray.Add(edv);
                        break;

                    case 5:
                        total = (int)Kq[i] * almaP;
                        endirim =(int)Kq[i] * almaP * almaEndirim / 100;
                        edv = (int)Kq[i] * almaP * almaEdv / 100;

                        Console.WriteLine($"| Alma              |  {Kq[i]}  |  {almaP}  |{almaEdv}  |{total}| ");
                        Console.WriteLine($"  Sizin qazanciniz=================== {endirim} ");

                        totalArray.Add(total);
                        endirimArray.Add(endirim);
                        edvArray.Add(edv);
                        break;

                    case 6:
                        total = (int)Kq[i] * baliqP;
                        endirim = (int)Kq[i] * baliqP * baliqEndirim / 100;
                        edv = (int)Kq[i] * baliqP * baliqEdv / 100;

                        Console.WriteLine($"| Baliq konservasi  |  {Kq[i]}  |  {baliqP}  |{baliqEdv}  |{total}| ");
                        Console.WriteLine($"  Sizin qazanciniz=================== {endirim} ");

                        totalArray.Add(total);
                        endirimArray.Add(endirim);
                        edvArray.Add(edv);
                        break;

                    case 7:
                        total = (int)Kq[i] * mercimekP;
                        endirim = (int)Kq[i] * mercimekP * mercimekEndirim / 100;
                        edv = (int)Kq[i] * mercimekP * mercimekEdv / 100;

                        Console.WriteLine($"| Mercimek          |  {Kq[i]}  |  {mercimekP}  |{mercimekEdv}  |{total}| ");
                        Console.WriteLine($"  Sizin qazanciniz=================== {endirim} ");

                        totalArray.Add(total);
                        endirimArray.Add(endirim);
                        edvArray.Add(edv);
                        break;  
                        
                    case 8:
                        total = (int)Kq[i] * zeytunP;
                        endirim = (int)Kq[i] * zeytunP * zeytunEndirim / 100;
                        edv = (int)Kq[i] * zeytunP * zeytunEdv / 100;

                        Console.WriteLine($"| Zeytun Yaqi       |  {Kq[i]}  |  {zeytunP}  |{zeytunEdv}  |{total}| ");
                        Console.WriteLine($"  Sizin qazanciniz=================== {endirim} ");

                        totalArray.Add(total);
                        endirimArray.Add(endirim);
                        edvArray.Add(edv);
                        break;

                    case 9:
                        total = (int)Kq[i] * limonkP;
                        endirim = (int)Kq[i] * limonkP * limonkEndirim / 100;
                        edv = (int)Kq[i] * limonkP * limonkEdv/ 100; ;

                        Console.WriteLine($"| Limon             |  {Kq[i]}  |  {limonkP}  |{limonkEdv}  |{total}| ");
                        Console.WriteLine($"  Sizin qazanciniz=================== {endirim} ");

                        totalArray.Add(total);
                        endirimArray.Add(endirim);
                        edvArray.Add(edv);
                        break; 
                        
                    case 10:
                        total = (int)Kq[i] * sokoladP;
                        endirim = (int)Kq[i] * sokoladP * sokoladEndirim / 100;
                        edv = (int)Kq[i] * sokoladP * sokoladEdv / 100;
                        

                        Console.WriteLine($"| Sokolad           |  {Kq[i]}  |  {sokoladP}  |{sokoladEdv}  |{total}| ");
                        Console.WriteLine($"  Sizin qazanciniz=================== {endirim} ");

                        totalArray.Add(total);
                        endirimArray.Add(endirim);
                        edvArray.Add(edv);
                        break;

                    case 11:
                        total = (int)Kq[i] * toyuqP;
                        endirim = (int)Kq[i] * toyuqP * toyuqEndirim / 100;
                        edv = (int)Kq[i] * toyuqP * toyuqEdv / 100;

                        Console.WriteLine($"| Toyuq             |  {Kq[i]}  |  {toyuqP}  |{toyuqEdv} |{total}| ");
                        Console.WriteLine($"  Sizin qazanciniz=================== {endirim} ");

                        totalArray.Add(total);
                        endirimArray.Add(endirim);
                        edvArray.Add(edv);
                        break;

                    case 12:
                        total = (int)Kq[i] * tomatP;
                        endirim = (int)Kq[i] * tomatP * tomatEndirim / 100;
                        edv = (int)Kq[i] * tomatP * tomatEdv / 100;

                        Console.WriteLine($"| Tomat             |  {Kq[i]}  |  {tomatP}  |{tomatEdv} |{total}| ");                         
                        Console.WriteLine($"  Sizin qazanciniz=================== {endirim} ");

                        totalArray.Add(total);
                        endirimArray.Add(endirim);
                        edvArray.Add(edv);
                        break;

                    default:
                        break;
                }
            }

            
        }

        
        public void PrintCheck2(int odenisnovu)
        {
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine($"Endirim|    {TotalEndirim()}");
            Console.WriteLine($"Vergi EDV |  {TotalEdv()}");
            Console.WriteLine($"Yekun Mebleg | {CalcTotal()}");
            if (odenisnovu==1)
            {
                Console.WriteLine($"odenis novu: | kartla odenilib");
            }
            else
            {
                Console.WriteLine($"odenis novu: | nagd pulla odenilib");
            }
            
            Console.WriteLine($"Tarix | {data}");
            Console.WriteLine($"Qebz Nomresi | { random.Next(1, 100000)}");
            
        }
    }
}
