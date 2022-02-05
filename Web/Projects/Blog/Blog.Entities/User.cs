using Blog.Shared.Entities;
using Blog.Shared.Extentions;
using System.Collections.Generic;

namespace Blog.Entities
{
    public class User : EntityBase, IEntity //burda  IEntity yazmaqla  bunu IEntityes
    {
        public int RoleId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{this.FirstName} {this.LastName}";
        public string Username { get; set; }
        public string Email { get; set; }
        public bool IsEmailConfirmed { get; set; }
        public string PasswordHash { get; set; }
        public string Avatar { get; set; }
        public string Bio { get; set; }

        // relations 

        /// <summary>
        /// user hansi roldadir(manager isci ve s.)
        /// </summary>
        public Role Role { get; set; } 
        public ICollection<Post> Posts { get; set; }

        // methods
        public void SetEmailConfirmed(bool control)
        {
            this.IsEmailConfirmed = control;
        }

        public void SetPassword(string password)
        {
            if (!string.IsNullOrEmpty(password))
            {
                this.PasswordHash = password.HashPassword();
            }
        }
    }
}



