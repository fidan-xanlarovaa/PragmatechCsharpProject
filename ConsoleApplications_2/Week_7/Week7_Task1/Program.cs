using System;

namespace Week7_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Tv tv1 = new Tv();
            tv1.Barcode = "3547";
            tv1.Brand = "Lc";
            tv1.Model = "Lc1234";
            tv1.PurchasePrice = 800;
            tv1.SalePrice = 1000;
            tv1.DiscountPrice = 50;
            tv1.Inch = 102;
            tv1.Hdmi = true;
            tv1.SmartTv = true;

            Database.Add(tv1);

        }
    }
}
