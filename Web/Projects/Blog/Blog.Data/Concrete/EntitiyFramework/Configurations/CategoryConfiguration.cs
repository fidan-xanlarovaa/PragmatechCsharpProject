using Blog.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;

namespace Blog.Data.Concrete.EntitiyFramework.Configurations
{
    /// <summary>
    /// Confiquration hisssede constreintlerimizi()qaydalar toplumuzu yaziriq
    /// </summary>
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Categories");

            builder.HasKey(i => i.Id); // primary key __Function delegat teleb edir deye o sekilde otururuk
            builder.Property(i => i.Id).ValueGeneratedOnAdd(); // auto increment

            builder.Property(i => i.Name)
                .HasMaxLength(70) // nvarchar(70
                .IsRequired(); // not null

            builder.Property(i => i.Description).HasMaxLength(500).IsRequired();

            // seed---
            var entities = new List<Category>()
            {
                new(){ Id = 1,  Name = "C#",  Description = "C#"},
                new(){ Id = 2,  Name = "C++",  Description = "C++"},
                new(){Id = 3, Name = "JavaScript",Description = "JavaScript" }                               
            };
            entities.ForEach(i => {
                i.SetCreatedByName("InitialCreate");
                i.SetModifiedByName("InitialCreate");
            });
            builder.HasData(entities); // cedvel yarananda bu datalar tableye insert olunsun. (Mes: Adminler sonradan yaranmir,onlari onceden
                                       // bu sekilde oture bilerik)
        }
    }
}
