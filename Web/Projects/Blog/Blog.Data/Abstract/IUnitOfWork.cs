using System;
using System.Threading.Tasks;

namespace Blog.Data.Abstract
{
    /// <summary>
    /// 
    ///  Design paterni olaraq artiq Generic Repositori ile tanis olduq. Indi ise IUnitOfWork ile tanis olaq.
    ///  IUnitOfWork-un isi bizim repositorilerimizin icerisindeki seyleri idare ede bilmekden ibaretdir. 
    ///  Yeni bir IUnitOfWork ile butun repositorilerimizi
    ///  idare edeceyik. Hamsini ayri ayri caqirmaq yerine IUnitOfWork-u cagirib ordan idare edeceyik.
    /// 
    /// </summary>
    public interface IUnitOfWork : IAsyncDisposable
    {
        public IUserRepository Users { get; }
        public IRoleRepository Roles { get; }
        public IPostRepository Posts { get; }
        public ICommentRepository Comments { get; }
        public ICategoryRepository Categories { get; }
        Task<int> SaveChangesAsync();
    }
}