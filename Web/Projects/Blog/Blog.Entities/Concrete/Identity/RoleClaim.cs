using Microsoft.AspNetCore.Identity;

namespace Blog.Entities.Concrete
{
    public class RoleClaim : IdentityRoleClaim<int>
    {
    }
}


//using Blog.Shared.Entities;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Blog.Entities
//{
//    public class Role : EntityBase, IEntity
//    {

//        public string Name { get; set; }
//        public string Description { get; set; }

//        // relations
//        public ICollection<User> Users { get; set; }
//    }
//}
