using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog.Entities;
using Blog.Shared.Data;

namespace Blog.Data.Abstract
{
    public interface IUserRepository : IEntityRepository<User>
    {
    }
}
