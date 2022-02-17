using System.Collections.Generic;
using Blog.Shared.Entities;
using Blog.Shared.Extentions;
using Microsoft.AspNetCore.Identity;

namespace Blog.Entities.Concrete
{
    public class User : IdentityUser<int>, IEntity
    {
        public string Avatar { get; set; }

        // relations 
        public ICollection<Post> Posts { get; set; }

        // methods
        public void SetPassword(string password)
        {
            if (!string.IsNullOrEmpty(password))
            {
                this.PasswordHash = password.HashPassword();
            }
        }
    }


    public class UserClaim : IdentityUserClaim<int>
    {

    }

    public class UserLogin : IdentityUserLogin<int>
    {

    }

    public class UserRole : IdentityUserRole<int>
    {

    }

    public class UserToken : IdentityUserToken<int>
    {

    }
}

//using Blog.Shared.Entities;
//using Blog.Shared.Extentions;
//using System.Collections.Generic;

//namespace Blog.Entities
//{
//    public class User : EntityBase, IEntity //burda  IEntity yazmaqla  bunu IEntityes
//    {
//        public int RoleId { get; set; }
//        public string FirstName { get; set; }
//        public string LastName { get; set; }
//        public string FullName => $"{this.FirstName} {this.LastName}";
//        public string Username { get; set; }
//        public string Email { get; set; }
//        public bool IsEmailConfirmed { get; set; }
//        public string PasswordHash { get; set; }
//        public string Avatar { get; set; }
//        public string Bio { get; set; }

//        // relations 

//        /// <summary>
//        /// user hansi roldadir(manager isci ve s.)
//        /// </summary>
//        public Role Role { get; set; } 
//        public ICollection<Post> Posts { get; set; }

//        // methods
//        public void SetEmailConfirmed(bool control)
//        {
//            this.IsEmailConfirmed = control;
//        }

//        public void SetPassword(string password)
//        {
//            if (!string.IsNullOrEmpty(password))
//            {
//                this.PasswordHash = password.HashPassword();
//            }
//        }
//    }
//}


/// <summary>
/// identity Autotictaionla baqli islerimizi gormek ucn bir nuget paketdir. Burda etmeli olduqumuz ilk is Identitynin classlarini inheritance ile toretmekdir. Evveller normal DbContecxtden toredirdikse indi Identity DbContextden toruyur. Generic olaraq User gonderilmesini teleb edir, 3 cu elemnt olara identitynin tipini teleb edir (biz id olara int istf. elemisik).
/// 1. data hissesine Microsoft.AspNetCore.Identity.EntityFrameworkCore paketini yuklemek
/// 2. entity layerine Microsoft.Extensions.Identity.Stores paketini yuklemek
/// 3. service layerine Microsoft.AspNetCore.Identity paketini yuklemek
/// 
/// </summary>
