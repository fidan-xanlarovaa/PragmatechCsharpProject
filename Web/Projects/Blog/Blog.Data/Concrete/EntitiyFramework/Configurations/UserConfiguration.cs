using Blog.Data.Concrete.EntityFramework.Context;
using Blog.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Data.Concrete.EntitiyFramework.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            // Primary key
            builder.HasKey(u => u.Id);

            // Indexes for "normalized" username and email, to allow efficient lookups
            builder.HasIndex(u => u.NormalizedUserName).HasDatabaseName("UserNameIndex").IsUnique();
            builder.HasIndex(u => u.NormalizedEmail).HasDatabaseName("EmailIndex");

            // Maps to the AspNetUsers table
            builder.ToTable("AspNetUsers", BlogDbContext.IDENTITY_SCHEMA);

            // A concurrency token for use with the optimistic concurrency checking
            builder.Property(u => u.ConcurrencyStamp).IsConcurrencyToken();

            // Limit the size of columns to use efficient database types
            builder.Property(u => u.UserName).HasMaxLength(50);
            builder.Property(u => u.NormalizedUserName).HasMaxLength(50);
            builder.Property(u => u.Email).HasMaxLength(50);
            builder.Property(u => u.NormalizedEmail).HasMaxLength(50);

            builder.Property(a => a.Avatar)
                .HasMaxLength(250)
                .IsRequired();

            // The relationships between User and other entity types
            // Note that these relationships are configured with no navigation properties

            // Each User can have many UserClaims
            builder.HasMany<UserClaim>().WithOne().HasForeignKey(uc => uc.UserId).IsRequired();

            // Each User can have many UserLogins
            builder.HasMany<UserLogin>().WithOne().HasForeignKey(ul => ul.UserId).IsRequired();

            // Each User can have many UserTokens
            builder.HasMany<UserToken>().WithOne().HasForeignKey(ut => ut.UserId).IsRequired();

            // Each User can have many entries in the UserRole join table
            builder.HasMany<UserRole>().WithOne().HasForeignKey(ur => ur.UserId).IsRequired();
        }
    }
    //public class UserConfiguration : IEntityTypeConfiguration<User>
    //{
    //    public void Configure(EntityTypeBuilder<User> builder)
    //    {
    //        builder.ToTable("Users");

    //        builder.HasKey(a => a.Id);// primary key
    //        builder.Property(a => a.Id).ValueGeneratedOnAdd();// auto incremented

    //        builder.Property(a => a.FirstName)
    //            .HasMaxLength(50)
    //            .IsRequired();

    //        builder.Property(a => a.FirstName)
    //            .HasMaxLength(50)
    //            .IsRequired();

    //        builder.Property(a => a.Username)
    //            .HasMaxLength(20)
    //            .IsRequired();
    //        builder.HasIndex(a => a.Username)
    //            .IsUnique();

    //        builder.Property(a => a.Email)
    //            .HasMaxLength(50)
    //            .IsRequired();
    //        builder.HasIndex(a => a.Email)
    //            .IsUnique();
    //        builder.Property(a => a.PasswordHash)
    //            .HasColumnType("NVARCHAR(MAX)")
    //            .IsRequired();
    //        builder.Property(a => a.Bio)
    //            .HasMaxLength(500)
    //            .IsRequired(false);
    //        builder.Property(a => a.Avatar)
    //            .HasMaxLength(250)
    //            .IsRequired();
    //        // relations
    //        builder
    //            .HasOne<Role>(i => i.Role)
    //            .WithMany(i => i.Users)
    //            .HasForeignKey(i => i.RoleId);

    //        // seed 
    //        var entity = new User()
    //        {
    //            Id = 1,
    //            RoleId = 1,
    //            FirstName = "System",
    //            LastName = "User",
    //            Username = "system.user",
    //            Email = "system.user@gmail.com",
    //            Avatar = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcSX4wVGjMQ37PaO4PdUVEAliSLi8-c2gJ1zvQ&usqp=CAU"
    //        };
    //        entity.SetCreatedByName("InitialCreate");
    //        entity.SetModifiedByName("InitialCreate");
    //        entity.SetEmailConfirmed(true);
    //        entity.SetPassword("system@.@user");

    //        builder.HasData(entity);
    //    }
    //}

}
