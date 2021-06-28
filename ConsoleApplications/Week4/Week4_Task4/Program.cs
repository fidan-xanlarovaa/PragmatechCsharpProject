using System;
using System.Collections;
using System.Linq;
using System.ComponentModel.Design;
using System.Diagnostics;

namespace Week4_Task4
{
    class Program
    {
        static void Main(string[] args)
        {

            ArrayList user = new ArrayList();
            ArrayList user2 = new ArrayList();
            Console.WriteLine("Sport komplekse qeydiyyat sistemi\n");

        x:
            Console.WriteLine("\n\nEdeceyiniz emeliyyati secin\n");
            Console.WriteLine("1-Uzv daxil edin");
            Console.WriteLine("2-Uzvu qeydiyyatdan silin");
            Console.WriteLine("3 - Uzvlerin shisini gorun");
            Console.WriteLine("5-Uzvlerin qeydiyyatda olub olmamasini yoxlayin");
            Console.WriteLine("6-Uzvlerin siyahisini bashdan sona siralayin");
            Console.WriteLine("7-Butun uzvlerin qeydiyyatini silin");
            Console.WriteLine("8-Sport komlekse qeydiyyat sisteminden cixin");

            int emeliyyat = Convert.ToInt32(Console.ReadLine());
            int i = 0;

            switch (emeliyyat)
            {
                case 1:

                    Console.WriteLine("\n\nUzv daxil etme ekranina xosh geldiniz\n");
                    Console.WriteLine("\nNece uzv daxil etmek istediyinizi yazin");
                    int number = Convert.ToInt32(Console.ReadLine());

                    do
                    {
                        Console.WriteLine($"{i + 1}-ci uzvu daxil edin");
                        string user1 = Console.ReadLine();
                        user.Add(user1);
                        i++;
                    } while (i != number);
                    Console.WriteLine("Emeliyyat ugurla basha catdi.");
                    goto x;
                    break;




                case 2:

                    Console.WriteLine("\n\nUzv silme ekranina xosh geldiniz\n");
                    if (user.Count == 0)
                    {
                        Console.WriteLine("\nTessufki hec bir istifadeci movcud deyil,buna gore de istifadeci sile bilmezsiniz.\n");
                    }

                    else
                    {
                        Console.WriteLine("Sile bileceyiniz istifadecilerin siyahisi:\n");
                        foreach (var item in user)
                        {
                            Console.WriteLine(item);
                        }
                        Console.WriteLine("\nSilmek istediyiniz istifadecinin adini daxil edin");
                        string user22 = Console.ReadLine();
                        user.Remove(user22);
                        Console.WriteLine("\nSilme prosesinden sonra istifadecilerin siyahisi:\n");
                        foreach (var item in user)
                        {
                            Console.WriteLine(item);
                        }
                    }
                    Console.WriteLine("Emeliyyat ugurla basha catdi.");
                    goto x;
                    break;




                case 3:

                    Console.WriteLine("\n\nUzvleri gorme ekranina xosh geldiniz\n");
                    if (user.Count == 0)
                    {
                        Console.WriteLine("\nTessufki hec bir istifadeci movcud deyil,buna gore de istifadeci sile bilmezsiniz.\n");
                    }

                    else
                    {
                        foreach (var item in user)
                        {
                            Console.WriteLine(item);
                        }
                    }
                    Console.WriteLine("Emeliyyat ugurla basha catdi.");
                    goto x;
                    break;




                case 4:

                    Console.WriteLine("\n\nUzvleri ters gorme ekranina xosh geldiniz\n");
                    if (user.Count == 0)
                    {
                        Console.WriteLine("\nTessufki hec bir istifadeci movcud deyil,buna gore de istifadeci sile bilmezsiniz.\n");
                    }

                    else
                    {

                        user2 = (ArrayList)user.Clone();
                        user2.Reverse();

                        foreach (var item in user2)
                        {
                            Console.WriteLine(item);
                        }

                    }
                    Console.WriteLine("Emeliyyat ugurla basha catdi.");
                    goto x;
                    break;




                case 5:

                    Console.WriteLine("\n\nUzvlerin movcudluqunu yoxlama ekranina xosh geldiniz\n");
                    if (user.Count == 0)
                    {
                        Console.WriteLine("\nTessufki hec bir istifadeci movcud deyil,buna gore de istifadeci sile bilmezsiniz.\n");
                    }

                    else
                    {
                        Console.WriteLine("\nMovcdluqunu yoxlamaq istediyiniz istifadecinin adini daxil edin\n");
                        string user3 = Console.ReadLine();
                        bool a = user.Contains(user3);

                        if (a)
                        {
                            Console.WriteLine($"{user3} adda istifadeci movcuddur");
                        }

                        else
                        {
                            Console.WriteLine($"{user3} adda istifadeci movcud deyil");
                        }
                    }
                    Console.WriteLine("Emeliyyat ugurla basha catdi.");
                    goto x;
                    break;




                case 6:

                    Console.WriteLine("\n\nUzvleri elifba sirasi ile gorme ekranina xosh geldiniz\n");
                    if (user.Count == 0)
                    {
                        Console.WriteLine("\nTessufki hec bir istifadeci movcud deyil,buna gore de istifadeci sile bilmezsiniz.\n");
                    }

                    else
                    {
                        user2 = (ArrayList)user.Clone();
                        user2.Sort();

                        foreach (var item in user2)
                        {
                            Console.WriteLine(item);
                        }
                    }
                    Console.WriteLine("Emeliyyat ugurla basha catdi.");
                    goto x;
                    break;




                case 7:

                    user.RemoveRange(0, user.Count);
                    Console.WriteLine("Emeliyyat ugurla basha catdi.");
                    goto x;
                    break;




                case 8:

                    Console.WriteLine("Sport komlekse qeydiyyat sisteminden cixisiniz ugurla heyate kecirildi.\nSistemden yaralandiqiniz ucun tesekkur edirik!");
                    break;




                default:

                    Console.WriteLine("Daxil edilen emeliyyat duzgun deyil,zehmet olmasa br daha daxil edin.");
                    goto x;
                    break;
            }





        }
    }
}