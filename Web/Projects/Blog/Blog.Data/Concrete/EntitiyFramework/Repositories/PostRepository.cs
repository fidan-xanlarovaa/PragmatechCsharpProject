using System;
using Blog.Data.Abstract;
using Blog.Entities;
using Blog.Shared.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.Concrete.EntitiyFramework.Repositories
{
    public class PostRepository : EfRepositoryBase<Post>, IPostRepository
    {
        public PostRepository(DbContext context) : base(context)
        {

        }
    }
}
