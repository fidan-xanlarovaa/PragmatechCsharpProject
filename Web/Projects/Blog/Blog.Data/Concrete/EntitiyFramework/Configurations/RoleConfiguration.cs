using Blog.Data.Concrete.EntityFramework.Context;
using Blog.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Blog.Data.Concrete.EntityFramework.Configurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            // Primary key
            builder.HasKey(r => r.Id);

            // Index for "normalized" role name to allow efficient lookups
            builder.HasIndex(r => r.NormalizedName).HasDatabaseName("RoleNameIndex").IsUnique();

            // Maps to the AspNetRoles table
            builder.ToTable("AspNetRoles", BlogDbContext.IDENTITY_SCHEMA);

            // A concurrency token for use with the optimistic concurrency checking
            builder.Property(r => r.ConcurrencyStamp).IsConcurrencyToken();

            // Limit the size of columns to use efficient database types
            builder.Property(u => u.Name).HasMaxLength(50);
            builder.Property(u => u.NormalizedName).HasMaxLength(50);

            // The relationships between Role and other entity types
            // Note that these relationships are configured with no navigation properties

            // Each Role can have many entries in the UserRole join table
            builder.HasMany<UserRole>().WithOne().HasForeignKey(ur => ur.RoleId).IsRequired();

            // Each Role can have many associated RoleClaims
            builder.HasMany<RoleClaim>().WithOne().HasForeignKey(rc => rc.RoleId).IsRequired();

            builder.HasData(new Role()
            {
                Id = 1, // Hem userde hem rolede id - leri elle vermisik,cunki ilk yarananlardir
                        // deye biz yaziriqki sonradan avtomatikgenerate ede bilsin
                Name = "Admin",
                NormalizedName = "ADMIN",
                ConcurrencyStamp = Guid.NewGuid().ToString(),

            },
                new Role()
                {
                    Id = 2,
                    Name = "Editor",
                    NormalizedName = "EDITOR",
                    ConcurrencyStamp = Guid.NewGuid().ToString(),

                },
                new Role()
                {
                    Id = 3,
                    Name = "Member",
                    NormalizedName = "MEMBER",
                    ConcurrencyStamp = Guid.NewGuid().ToString(),

                });
        }
    }
}
//using Blog.Entities;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;

//namespace Blog.Data.Concrete.EntitiyFramework.Configurations
//{
//    public class RoleConfiguration : IEntityTypeConfiguration<Role>
//    {
//        public void Configure(EntityTypeBuilder<Role> builder)
//        {
//            builder.ToTable("Roles");

//            builder.HasKey(a => a.Id);// primary key
//            builder.Property(a => a.Id).ValueGeneratedOnAdd();// auto incremented
//            builder.Property(a => a.Name)
//                .HasMaxLength(70)
//                .IsRequired();
//            builder.Property(a => a.Description)
//                .HasMaxLength(500)
//                .IsRequired();


//            // seed
//            var entity = new Role()
//            {
//                Id = 1,
//                Name = "Admin",
//                Description = "BOSS",
//            };
//            entity.SetCreatedByName("InitialCreate");
//            entity.SetModifiedByName("InitialCreate");

//            builder.HasData(entity);
//        }
//    }

//}
