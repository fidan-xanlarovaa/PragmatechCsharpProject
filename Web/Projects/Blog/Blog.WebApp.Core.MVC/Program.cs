using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
/// <summary>
/// Remote serverdeki, local kompdaki branchdir.
/// Pull ederken konflikt cixamisini sebebi, evvel birlesdirdiyim main branc ile hazirki main branchinin eyni olmamamsidir
/// Merging zamani conflict olanda hansi fayllarda conflict olduqu sira sira cixir. Hemen fayla saq click edib Merge secirik
/// ve o bize local ile serverde olan codelar arasindaki ferqi gosterir. Kodu analiz ederek(qirmizi hisseleri) bize lazim olan
/// hisse codun qarisina clik qoyuruq. Lazimli hisseler secildikden sonra asaqida bize yaranacaq kodu gosterir. Onu analiz 
/// etdikden sonra yuxaridan Accpt merge edirik ve belelikle 1 faylin conflictini hell elemis oluruq.
/// Butun fayllardaki conflictleri bu formada hell etdikden sonra commit yazib save edirik."all conflicts solved"
/// Daha sonra solutionu clean edib rebuild edirik.
/// Eger bu zaman hansisa layer yuklenmezse onun uzerine sag click vurub reload-a click edirik, bu zaman da onun packetlerinde
/// problem cixa biler(mes: entity layerinden asliliq ve ya instal elediyimiz her hansi bir nuget packet) Bele hallarda o packeti
/// silib yeniden yukleyirik ve ya yeniden project reference add edirik.
/// 
/// Main branche birlesdirmek istediyimiz branchin uzerine gelib saq click vurduqda merge into cureent branch yaziriq ve eger 
/// conflict varsa yaranan o conflictleri helledirik.
/// 
/// Eger conflictleri hell ederken sehven onlari silsek onlar onsuzda muveqqeti olaraq stash yaddasinda qalacaq deye 
/// stash yaddasina kecib ordan yuxarida balaca goy rengde olan Apply-a click etsek etdiyimiz deyisikler, itemeyecek yeniden 
/// berpa olunacaq. Conflictleri hell etdikden sonra yeni commit edirik ve yeniden branchin uzerine gelib saq click vurduqda 
/// merge into current branch yaziriq. Main prancha birlesdirdikden sonra push edib yeniden pull edirik ki, localdaki main de 
/// duzelmis olsun. Clean ve rebuild etmeyi unutmuruq pul ve pushdan once
/// 
/// 
/// Proqramda ERROR cixanda mentiqli sekilde codu oxumaq lazimdi:
/// harda cixir eror?
/// filan yere qeder duzdu ondan sonrakine bax. Metodlari analiz ele(mes: if metoduna girirmi console.log ele(print olsa demeli 
/// girir) ) KODU OXU. HISSIYATIN OLSUN.
/// DEBUG ele c#-da
/// javascriptde Manual debugging
/// 
/// </summary>
namespace Blog.WebApp.Core.MVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
