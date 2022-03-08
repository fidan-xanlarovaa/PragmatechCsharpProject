using Blog.Data.Concrete.EntityFramework.Context;
using Blog.Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

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

            // seed 
            var admin = new User()
            {
                Id = 1,
                UserName = "adminUser",
                NormalizedUserName = "ADMINUSER",
                Email = "adminUser@gmail.com",
                NormalizedEmail = "ADMINUSER@GMAIL.COM",
                PhoneNumber = "+9949999999",
                Avatar = "Users/defaultUser.png",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString(),
            };

            admin.PasswordHash = CreatePasswordHash(admin, "Admin123!User"); // password (identitynin paswordhasherinden istifade edirik)


            var editor = new User()
            {
                Id = 2,
                UserName = "editorUser",
                NormalizedUserName = "EDITORUSER",
                Email = "editorUser@gmail.com",
                NormalizedEmail = "EDITORUSER@GMAIL.COM",
                PhoneNumber = "+9949999999",
                Avatar = "Users/defaultUser.png",
                EmailConfirmed = true,// Ozumuz elle yardiriq dey email confirmation istemirik, bir basa true veririk.
                                      // Normal userler ise qeydiyyatdan kecenden ve oz email-lerini confirm etdikden
                                      // sonra bu parametr true-ya cevrilir

                PhoneNumberConfirmed = true,// Ozumuz elle yardiriq dey phone confirmation istemirik, bir basa true veririk.
                                            // Normal userler ise qeydiyyatdan kecenden ve oz phone-lerini confirm etdikden
                                            // sonra bu parametr true-ya cevrilir

                SecurityStamp = Guid.NewGuid().ToString(), // Security cehetden Token yaradiriqki, User uzerinde her hansi
                                                           // deyisklik olanda bas aduse bilsinki bu hemen userdir yoxsa yox

            };
            editor.PasswordHash = CreatePasswordHash(editor, "Editor123!User");

            var member = new User()
            {
                Id = 3,
                UserName = "memberUser",
                NormalizedUserName = "MEMBERUSER",
                Email = "memberUser@gmail.com",
                NormalizedEmail = "MEMBERUSER@GMAIL.COM",
                PhoneNumber = "+9949999999",
                Avatar = "Users/defaultUser.png",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString(),

            };
            member.PasswordHash = CreatePasswordHash(member, "Member123!User"); //memberin PasswordHash propertisine
                                                                                //CreatePasswordHash(editor, "Member123!User")
                                                                                //deyerini verdik icerisine userimizi ve
                                                                                //verceyimiz paswordu oturduk

            builder.HasData(member, admin, editor);
        }

        private string CreatePasswordHash(User user, string password)
        {
            var passwordHasher = new PasswordHasher<User>();
            return passwordHasher.HashPassword(user, password); // paswordu hashlenmis formada geri qaytarir. Cunki biz databasede
                                                                // passwordleri aciq formada saxlamiriqki, sabah databemizi eger
                                                                // hacklenerse hemen hacker o passwordlari aciq sekilde gore bilmesin 
        }
        
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


