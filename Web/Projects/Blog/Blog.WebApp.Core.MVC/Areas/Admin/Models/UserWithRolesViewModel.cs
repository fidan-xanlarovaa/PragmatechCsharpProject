﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Entities.Concrete;

namespace Blog.WebAPP.CORE.MVC.Areas.Admin.Models
{
    public class UserWithRolesViewModel
    {
        public User User { get; set; }

        public IList<string> Roles { get; set; } = new List<string>();
    }
}