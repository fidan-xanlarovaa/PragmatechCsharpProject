using System;
using System.Collections.Generic;
using System.Text;

namespace Week7_Task1
{
    public class Database
    {
        #region methods

        private static bool CheckBarcode(Product pr)
        {
            bool checkingValue = false;

            foreach (var item in BaseEntity._database)
            {
                Product tempItem = (Product)item;

                if (tempItem.Barcode == pr.Barcode)
                {
                    checkingValue = true;
                }

            }
            return checkingValue;
        }

        public static void Add(Product pr)
        {
            if (CheckBarcode(pr))
            {
                Console.WriteLine("Barcode eyni olduqu ucun bu melumati bazaya yerlesdire bilmerik,yeniden cehd edin");
            }
            else
            {
                pr.CreateDate = DateTime.Now;
                BaseEntity._database.Add(pr);
                Console.WriteLine("added");
            }

        }

        public  static void GetAll(Product item1)

        {
            if (BaseEntity._database != null && BaseEntity._database.Count > 0)
            {
                if (item1 is Laptop)
                {
                    foreach (var item2 in BaseEntity._database)
                    {
                        Laptop itemtype = (Laptop)item2;
                        Console.WriteLine($"Id: {itemtype.Id} | Barcode : {itemtype.Barcode} | Brand: {itemtype.Brand} |  Model: {itemtype.Model} | SalePrice: { itemtype.SalePrice} | PurchasePrice: { itemtype.PurchasePrice} |   DiscountPrice: { itemtype.DiscountPrice} | Cpu: { itemtype.Cpu} | Ram: {itemtype.Ram} | VideoCard: {itemtype.VideoCard}");
                    }
                }

                else if (item1 is Tv)
                {
                    foreach (var item2 in BaseEntity._database)
                    {
                        Tv itemtype = (Tv)item2;
                        Console.WriteLine($"Id: {itemtype.Id} | Barcode : {itemtype.Barcode} | Brand: {itemtype.Brand} |  Model: {itemtype.Model} | SalePrice: { itemtype.SalePrice} | PurchasePrice: { itemtype.PurchasePrice} |   DiscountPrice: { itemtype.DiscountPrice} | Inch: { itemtype.Inch} | Hdmi: {itemtype.Hdmi} | SmartTv: {itemtype.SmartTv}");
                    }
                }
            }
            else
            {
                Console.WriteLine("Datebase bosdur.");
            }

        }

        public  static void Remove(int id)
        {

            if (id >= BaseEntity._database.Count || id <= 0)
            {
                Console.WriteLine("Silmek istediyiniz data movcud deyil");
            }

            else
            {
                for (int i = 0; i < BaseEntity._database.Count; i++)
                {
                    Product itemtype = (Product)BaseEntity._database[i];
                    if (itemtype.Id == id)
                    {
                        itemtype.IsDeleted = true;
                        Console.WriteLine("Mehsul ugurla silinmisdir");
                        break;
                    }

                }

            }
        }

        public  static void Update(int id, Product model)
        {
            if (BaseEntity._database != null && BaseEntity._database.Count > 0 && id >= BaseEntity._database.Count)
            {
                if (model != null && !string.IsNullOrEmpty(model.Barcode))
                {
                    for (int i = 0; i < BaseEntity._database.Count; i++)
                    {
                        Product itemtype = (Product)BaseEntity._database[i];
                        if (itemtype.Id == id)
                        {
                            if (model is Laptop)
                            {
                                Laptop itemtype2 = (Laptop)itemtype;
                                Laptop model2 = (Laptop)model;

                                itemtype2.Model = model2.Model;
                                itemtype2.Barcode = model2.Barcode;
                                itemtype2.SalePrice = model2.SalePrice;
                                itemtype2.PurchasePrice = model2.PurchasePrice;
                                itemtype2.DiscountPrice = model2.DiscountPrice;
                                itemtype2.Brand = model2.Brand;
                                itemtype2.Cpu = model2.Cpu;
                                itemtype2.Ram = model2.Ram;
                                itemtype2.VideoCard = model2.VideoCard;

                            }

                            else if (model is Tv)
                            {
                                Tv itemtype3 = (Tv)itemtype;
                                Tv model3 = (Tv)model;

                                itemtype3.Model = model3.Model;
                                itemtype3.Barcode = model3.Barcode;
                                itemtype3.SalePrice = model3.SalePrice;
                                itemtype3.PurchasePrice = model3.PurchasePrice;
                                itemtype3.DiscountPrice = model3.DiscountPrice;
                                itemtype3.Brand = model3.Brand;
                                itemtype3.Inch = model3.Inch;
                                itemtype3.Hdmi = model3.Hdmi;
                                itemtype3.SmartTv = model3.SmartTv;
                            }

                            Console.WriteLine("Model ugurla deyisdirilmisdir");
                        }


                    }
                }
            }

            else
            {
                Console.WriteLine("Deyisdirmek istediyiniz mehsul movcud deyil.");
            }

        }

        #endregion
    }
}
