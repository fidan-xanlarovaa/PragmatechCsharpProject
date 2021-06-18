using System;

namespace Task1__w2
{
    class Program
    {
        struct User{
        public string Username {get; set;}
        public string Password {get; set;}

            public User(string name,string pass){
                this.Username=name;
                this.Password=pass;
             }
        }




        static void Main(string[] args)
        {
            string uName,uPass;
             User user = new User("fidan","123456f");
            Console.WriteLine( "UserName daxil edin");
            uName=Console.ReadLine();
            Console.WriteLine( "PassWord daxil edin");
            uPass=Console.ReadLine();

            
           

            
            if(uName==user.Username && uPass==user.Password){
              Console.WriteLine("sayta xosh gelmisiniz");
            }
            
            else{
              
                    Console.WriteLine("UserName ve ya PassWord yalnishdir");
            }
            


           
                

        }
    }
}







