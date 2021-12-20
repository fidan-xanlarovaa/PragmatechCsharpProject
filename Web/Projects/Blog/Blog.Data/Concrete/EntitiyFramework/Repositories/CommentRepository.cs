using Blog.Data.Abstract;
using Blog.Entities;
using Blog.Shared.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Blog.Data.Concrete.EntityFramework.Repositories
{
    public class CommentRepository : EfRepositoryBase<Comment>, ICommentRepository
    {
        /// <summary>
        /// Generc repositorynin constructurunda DBContext var deye inhertance alanda mecburuq ki, burda da ctor-da DBContext yaz,aliyiq
        /// </summary>
        /// <param name="context"></param>
        public CommentRepository(DbContext context) : base(context) 
        {
        }

    }
}