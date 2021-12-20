using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TagHelpers.Data;
using TagHelpers.Models;

namespace TagHelpers.wwwroot
{
    public class BookController : Controller
    {
        /* Index sehifeleri adeten giris sehifeleri olur(HomeController-in Indexi). LAkin indiki halda gorunduyu kimi
       BookControllerin indexindeyik. Home xaricindeki controllerin indexinde biz adeten listlerimizi yaziriq
       Indiki hal ucun : kitablarin siyahisi*/


        //----------------------------------------------------Bu View-a data elave etmenin 1-ci yolu:------------------------------------------
        /*public IActionResult Index()

        {
            List<BookModel> books = new List<BookModel>()
            {
                new BookModel
                {
                    Id=1,
                    Name="Book1",
                    Description="Description1"
                },
                new BookModel
                {
                    Id=2,
                    Name="Book2",
                    Description="Description2"
                }
            };


            return View(books); //Burda biz bir collection yaradib datani BIR BASA VIEWin icine otururuk
        }*/

        //------------------------------------------------------------------------------------------------------------------------------------------------



        //----------------------------------------------------Bu View-a data elave etmenin 2-ci yolu:-------------------------------------------

        // GET: BookController

        public IActionResult Index()
        {
            return View(Datasource.Books);
        }


        // GET: BookController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BookController/Create
        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(BookModel book)
        {
            try
            {
                Datasource.Books.Add(book);
                return RedirectToAction(nameof(Index)); //Bu bizi hansi sehifeye qayitmaliyiqsa ora yonlendirir, sadece Index yox nameof(Index) yazmaqimizin
                                                        //sebebi var o daha sonra izah edilecek. Indexde de biz butun DataSourcedeki melumatlari gotermeyini
                                                        //demisik deye son elave etdiymiz book-u da siyahida gormus oluruq
            }
            catch
            {
                return View();
            }
        }
        /*View-dan data goturmayin bir nece yolu var Amma en duzgunu yuxaridakideir--------------------------------------------------1-ci metod*/


        // POST: BookController/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //----------------------------------------------------------------------------------------------------------------------------------

        //-----------------2-ci metod---------------------------------------------------------------------------------------------------------

        //public ActionResult Create(int id,string name, string desc) //Sual: Bu nece basa dusurki men bura id gonderdim, description gonderdim ya name gonderdim ve
        //                                                            // onlari bu data tiplerine nece cevirir?_____________Form-dan gelen adlara baxib uyqunlasdirir,
        //                                                            // burda men ( string desc,int id,string name) seklinde yerdeyisme etsem bele hec bir problem
        //                                                            // olmayacaq, cunki burda Model Binding texnologiyasi var. Yeni ASP>NET CORE texnologiyasinin ozu
        //                                                            // arxada uyqunlasdirib.uyqun tipe gore sene gosterir

        //{
        //    try
        //    {
        //        var book = new BookModel
        //        {
        //            Id = id,
        //            Name = name,
        //            Description = desc
        //        };

        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //-------------------------------------------------------------------------------------------------------------------------------------------






        //Biz datani query string seklinde de goture bilerik_____________tapaz da filterleme neticesinde gelen result kimi
                                                                        //Container/ActionName?this=that&this=that&this=that tipde yazaraq
        public IActionResult bookquery()
        {
            var querystring = Request.QueryString;

            var id = Request.Query["id"];
            var name = Request.Query["name"];
            var description = Request.Query["description"];

            if (querystring.HasValue)
            {
                //if not null mensini verir
            }

            return new JsonResult (new { querystring ,id, name, description}); //normalda bele bir sey qaytarmiriq sadece eyani olaraq gore bilek
                                                                               //deye bele yazdiq
        }







        //Query string ile Route arasindaki ferq ondan ibaretdirk qury stringde nameni verib = yaziriq /id=1..... seklinde yaziriq amma
        // Route de /1 seklinde     BookController/Edit/5








        // GET: BookController/Edit/5
        public ActionResult Edit(int id)    
        {
            var bookid = Request.RouteValues["id"]; //eger yuxaridan parametr olaraq id gelmese idi bu sekilde yazib goture bilerdik
            return View();
        }

        // POST: BookController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BookController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BookController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
