using Blog.Shared.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Shared.Data
{
    public class EfRepositoryBase<TEntity> : IEntityRepository<TEntity> where TEntity : class, IEntity, new() //IEntityRepositorinin implementasiyasidir
                                                                                                              // Adina ona gore EF yazmisiq ki bu entity frameworkun implementasiyasidir
    {
        #region fields

        private readonly DbContext _context; //queryleri ve oz entitylerimizi save elemek ucun istifade edirik
        private readonly DbSet<TEntity> _dbSet; //Bu bizim cedvellerimize(sqldeki) uyqun gelecek
        #endregion

        public EfRepositoryBase(DbContext context)
        {
            _context=context; //new() yazmamaq,her caqiranda yeni instance alinmasindan qacinmaq ucun injectiondan isifade eledik
            _dbSet = context.Set<TEntity>();
        }
        public async Task AddAsync(TEntity entity)// burda biz hiss elemesek bele Task-dan sonra <> yazmamisiq deye void metoddur ve ona gore return yaza bilmerik

        {
            await _dbSet.AddAsync(entity);
        }

        public async Task UpdateAsync(TEntity entity)
        {
            await Task.Run(() => { _dbSet.Update(entity); }); //Run taskin metodududr ve o prqument olaraq action teleb edir. Action action-deleqatdir
                                                              //ve void tipdedir.bir nov ozu de metoddur yeni . Bunu yazmaq ucun ananymous metod yaziriq.
                                                              //Bunu bu formada yazdiq cunki Update ucun async metod yoxdur.
        }

        public async Task<bool> AnyAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await _dbSet.AnyAsync(predicate);
        }

        public async Task<int> CountAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await _dbSet.CountAsync(predicate);
        }

        public async  Task DeleteAsync(TEntity entity) 
        {
            await Task.Run(() => { _dbSet.Remove(entity); });
        }

        public async Task<IList<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> predicate = null, params Expression<Func<TEntity, object>>[] includeProperties)
        {
            IQueryable<TEntity> query = _dbSet; //select* all from Post

            if (predicate is not null) //where id=5
            {
                query = query.Where(predicate);
            }

            if (includeProperties is not null) // left join
            {
                foreach (var includeProperty in includeProperties)
                {
                    query = query.Include(includeProperty);
                }
            }


            return await query.ToListAsync();
        }

        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] includeProperties)
        {
            throw new NotImplementedException(); IQueryable<TEntity> query = _dbSet;

            if (predicate is not null)
            {
                query = query.Where(predicate);
            }

            if (includeProperties is not null) //bu bize propertilere el catmaqa imkan verir
            {
                foreach (var includeProperty in includeProperties)
                {
                    query = query.Include(includeProperty);
                }
            }


            return await query.SingleOrDefaultAsync(); //asinxron proqramlasdirmada methodu geri qaytarmaq isteyirsense, evveline await yazmalisan ve
                                                       //methoddan evvel de assync elave etmelisen
                                                       // await yazmaqla biz demis oluruq ki eger bu metodda gozleme olarsa diger metodlari davam ele
        }

        
    }
}


/*Entity framework deyende ne basa dusmeliyik?
 
 entiry framework ozu bir ORM-dir___ORM database ile bizimi applicationumuz arasinda bir connection yaradir
 arxasinda bunun da Ado(Ado da database kodlari ile yaziriq) isleyir
 */