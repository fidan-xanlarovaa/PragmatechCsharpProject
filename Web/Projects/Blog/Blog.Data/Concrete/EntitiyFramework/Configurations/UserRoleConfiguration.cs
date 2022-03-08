using Blog.Data.Concrete.EntityFramework.Context;
using Blog.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Data.Concrete.EntitiyFramework.Configurations
{
    public class UserRoleConfiguration : IEntityTypeConfiguration<UserRole>
    {
        public void Configure(EntityTypeBuilder<UserRole> builder)
        {
            //Many to many elaqe qururuq
            // Primary key
            builder.HasKey(r => new { r.UserId, r.RoleId });

            // Maps to the AspNetUserRoles table
            builder.ToTable("AspNetUserRoles", BlogDbContext.IDENTITY_SCHEMA);

            //seed
            
            builder.HasData(
                new UserRole
                {
                    UserId = 1, //admin admindir...
                    RoleId = 1
                },
                new UserRole
                {
                    UserId = 2,
                    RoleId = 2
                },
                new UserRole
                {
                    UserId = 3,
                    RoleId = 3
                });


        }
    }
}
