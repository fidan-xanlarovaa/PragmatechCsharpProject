using System;

namespace Week2_Task5
{
    class Program
    {
        struct Student
        {
            public int grade;
        }
        static void Main(string[] args)
        {
            Student student1;
            Console.WriteLine("Enter your point: ");
            student1.grade = Convert.ToInt32(Console.ReadLine());

            if(91<= student1.grade && student1.grade <= 100)
            {
                Console.WriteLine("Your mark is: A");
            }

            else if (81 <= student1.grade && student1.grade <= 90)
            {
                Console.WriteLine("Your mark is: B");
            }

            else if (71 <= student1.grade && student1.grade <= 80)
            {
                Console.WriteLine("Your mark is: C");
            }

            else if (61 <= student1.grade && student1.grade <= 70)
            {
                Console.WriteLine("Your mark is: D");
            }

            else if (51 <= student1.grade && student1.grade <= 60)
            {
                Console.WriteLine("Your mark is: E");
            }

            else
            {
                Console.WriteLine("Unortunatelly,you did not pass the exam.");
            }
        }
    }
}
