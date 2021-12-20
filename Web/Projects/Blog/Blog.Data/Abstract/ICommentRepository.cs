using Blog.Data.Abstract;
using Blog.Entities;
using Blog.Shared.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.Abstract
{
    public interface ICommentRepository : IEntityRepository<Comment>
    {
        
    }
}
