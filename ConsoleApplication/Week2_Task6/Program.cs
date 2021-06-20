using System;

namespace Week2_Task6
{
    struct Person
    {
        public string Name;
        public string Surname;
        public int Age;

        public Person( int age,string name="Fidan", string surname="Xanlarova")
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string _surname_, _name_;
            int _age_;
            Console.WriteLine("Enter your age:");
            _age_ = Convert.ToInt32(Console.ReadLine());

            Person person = new Person(_age_);

            Console.WriteLine("Enter your name:");
            _name_ = Console.ReadLine();
            Console.WriteLine("Enter your surname:");
            _surname_ = Console.ReadLine();

            
            
           if (_name_==person.Name && _surname_== person.Surname)
           {
                if (_age_ >= 18)
                {
                    Console.WriteLine("Your can see this content.");
                }

                else
                {
                    Console.WriteLine("Your cann't see this content, because age-restricted contents are not viewable to users who are under 18 years of age ");
                }
            
            }
            



        }
    }
}
