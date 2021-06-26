using System;

namespace Week3_Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pls enter a word");

            string word = Console.ReadLine();

            char[] wordArray = word.ToCharArray();
            int a = 0, e = 0, i = 0, o = 0, u = 0, y = 0;
            foreach (char charr in wordArray)
            {

                switch (charr)
                {
                    case 'a':
                    case 'A':
                        a++;
                        break;
                    case 'e':
                    case 'E':
                        e++;
                        break;
                    case 'i':
                    case 'I':
                        i++;
                        break;
                    case 'O':
                    case 'o':
                        o++;
                        break;
                    case 'u':
                    case 'U':
                        u++;
                        break;
                    case 'y':
                    case 'Y':
                        y++;
                        break;
                    default:
                        break;
                }

            }

            Console.WriteLine($"This word contain {a + e + i + u + o + y} vowels.\n\nThe number of a in this word is {a}.\nThe number of e in this word is {e}.\nThe number of o in this word is {o}.\nThe number of u in this word is {u}.\nThe number of i in this word is {i}.\nThe number of y in this word is {y}.");


        }
    }
}