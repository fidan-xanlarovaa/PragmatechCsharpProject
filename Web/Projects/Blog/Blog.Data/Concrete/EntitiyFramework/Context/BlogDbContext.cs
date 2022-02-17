using Blog.Data.Concrete.EntitiyFramework.Configurations;
using Blog.Data.Concrete.EntityFramework.Configurations;
using Blog.Entities;
using Blog.Entities.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Blog.Data.Concrete.EntityFramework.Context
{
    public class BlogDbContext : IdentityDbContext<User, Role, int, UserClaim, UserRole, UserLogin, RoleClaim, UserToken>
    {
        public const string IDENTITY_SCHEMA = "Identity";
        public const string DEFAULT_SCHEMA = "dbo";

        #region .::dbSet::.

        public DbSet<Post> Posts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        #endregion

        #region Overrides of DbContext

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=.;Database=BlogProject;Trusted_Connection=True;Connect Timeout=30;MultipleActiveResultSets=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region identity
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.ApplyConfiguration(new UserClaimConfiguration());
            modelBuilder.ApplyConfiguration(new UserRoleConfiguration());
            modelBuilder.ApplyConfiguration(new UserLoginConfiguration());
            modelBuilder.ApplyConfiguration(new RoleClaimConfiguration());
            modelBuilder.ApplyConfiguration(new UserTokenConfiguration());
            #endregion

            modelBuilder.ApplyConfiguration(new CommentConfiguration());
            modelBuilder.ApplyConfiguration(new PostConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
        }

        #endregion
    }
}

//using Blog.Data.Concrete.EntitiyFramework.Configurations;
//using Blog.Entities;
//using Blog.Entities.Concrete;
//using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore;

//namespace Blog.Data.Concrete.EntitiyFramework.Context
//{
//    /// <summary>
//    /// DbContextden inheritance almaqla biz bildirdik ki bu ORM-den istifade edeceyik
//    /// </summary>
//    public class BlogDbContext : IdentityDbContext<User,Role,int,UserClaim,UserRole,UserLogin,RoleClaim,UserToken>
//    {

//        public const string IDENTITY_SCHEMA="Identity";
//        public const string DEFAULT_SCHEMA = "dbo";
//        /// <summary>
//        /// DbSet<Hansi // entitye uyqun cedvel yaransin> burda bir-bir sql-de yaranacaq cedvellerimizi qeyd edirik
//        /// </summary>
//        #region dbSet
//        public DbSet<Post> Posts { get; set; }
//        public DbSet<Category> Categories { get; set; }
//        public DbSet<Comment> Comments { get; set; }
//        //public DbSet<User> Users { get; set; } //// Bunlar artiq lazim deyil deye silirik
//        //public DbSet<Role> Roles { get; set; }

//        #endregion

//        #region overrides of DbContext
//        /// <summary>
//        /// burda SqlServerden istifade edeceyimizi bildiririk
//        /// </summary>
//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            optionsBuilder.UseSqlServer(@"Server=.;Database=BlogProject;Trusted_Connection=True;Connect Timeout=30;MultipleActiveResultSets=True;");
//        }

//        /// <summary>
//        /// Burda Confiqurasiyalarimiz tanidiriq
//        /// 
//        /// Biz confiqurasiya fayllarimiz basqa layerde olsa idi modelBuilder.ApplyConfigurationsFromAssembly() -den istifade edecekdik____reflection
//        /// vasitesi ile.
//        /// </summary>

//        protected override void OnModelCreating(ModelBuilder modelBuilder)
//        {

//            modelBuilder.ApplyConfiguration(new UserConfiguration());
//            modelBuilder.ApplyConfiguration(new CommentConfiguration());
//            modelBuilder.ApplyConfiguration(new PostConfiguration());
//            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
//            modelBuilder.ApplyConfiguration(new RoleConfiguration());
//        }
//        #endregion
//    }
//}
