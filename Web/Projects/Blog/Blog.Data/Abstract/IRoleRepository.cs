using System;
using Blog.Entities;
using Blog.Shared.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog.Entities.Concrete;

namespace Blog.Data.Abstract
{
    public interface  IRoleRepository : IEntityRepository<Role>
    {
    }
}
