﻿using System.Collections.Generic;
using Blog.Shared.Entities;
using Blog.Shared.Entities.Abstract;
using Microsoft.AspNetCore.Identity;

namespace Blog.Entities.Concrete
{
    public class Role : IdentityRole<int>, IEntity
    {
    }

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
