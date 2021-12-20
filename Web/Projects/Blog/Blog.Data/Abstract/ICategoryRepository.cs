using Blog.Entities;
using Blog.Shared.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.Abstract
{
    public interface  ICategoryRepository : IEntityRepository<Category>
    {
    }
}
