using System;
using Blog.Entities;
using Blog.Shared.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.Abstract
{
    public interface IPostRepository : IEntityRepository<Post>
    {
    }
}
