using System;

namespace Week2_Task1
{
    class Program
    {
       struct User
        {
            public string Username;
            public int Password;
            

            public User(string name, int pass)
            {
                this.Username = name;
                this.Password = pass;
                
            }
        }

        static void Main(string[] args)
        {
            string uName;
            int uPass;
            User user = new User( "fidan", 1234567);
       
            Console.WriteLine("UserName daxil edin");
            uName = Console.ReadLine();
            Console.WriteLine("PassWord daxil edin");
            uPass = Convert.ToInt32(Console.ReadLine());

            if (uName == user.Username && uPass == user.Password){
                Console.WriteLine("sayta xosh gelmisiniz");
            }

            else{
                Console.WriteLine("UserName ve ya PassWord yalnishdir");
            }
        }
    }
}


