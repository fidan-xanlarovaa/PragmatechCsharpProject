using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Ingilis-Azerbaycan mini luget hazirlayin.
 *
 * Lugete yeni soz elave etmek isteyirsinizmi? b/x (beli/xeyr)
 *
 * Beli cavabinda yeni soz elave edilir.
 * Istifadeci once Ingilis dilinde sozu daxil edir,
 * Sozun Lugetde olub olmamasi yoxlanilir,
 * Yoxdursa Bu sefer sozun Azerbaycan dilinde qarsiligini daxil edir.
 * Xeyr cavabinda elave edilmis sozlerin hamisi istifadeciye gosterilir.
 *
 */

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable vocabulary = new Hashtable();
            vocabulary.Add("car", "masin");
            vocabulary.Add("doll", "gelincik");
            vocabulary.Add("girl", "qiz");
            vocabulary.Add("ship", "gemi");
            string answer = "";

            do
            {

                Console.Clear();
                Console.WriteLine("Pls enter a word in English");
                string worden = Console.ReadLine();
                if (vocabulary.Contains(worden))
                {
                    Console.WriteLine($"Vocabulary contains this word and its meaning is {vocabulary[worden]} ");

                }
                else
                {
                    Console.WriteLine("Pls enter its translation in Azerbaijan");
                    string wordaz = Console.ReadLine();
                    vocabulary.Add(worden, wordaz);
                    Console.WriteLine($"You entered the word {worden} and its translation is {wordaz}");



                }
                Console.WriteLine("Do you want to add new word to dictionary.(yes or no)");
                answer = Console.ReadLine();

            } while (answer is "yes");






        }
    }
}





































