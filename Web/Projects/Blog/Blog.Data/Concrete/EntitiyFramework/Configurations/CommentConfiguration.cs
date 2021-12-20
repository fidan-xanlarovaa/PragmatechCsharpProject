using Blog.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Data.Concrete.EntitiyFramework.Configurations
{
    public class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.ToTable("Comments");

            builder.HasKey(a => a.Id);// primary key
            builder.Property(a => a.Id).ValueGeneratedOnAdd();// auto incremented
            builder.Property(a => a.Text)
                .HasMaxLength(1000)
                .IsRequired();

            // relations
            builder
                .HasOne<Post>(i => i.Post)  //post tablesi (joini olan table)
                .WithMany(i => i.Comments) //comment tablesi  (hazirda olan table)
                .HasForeignKey(i => i.PostId); //foreign key olan column

            //seed
            var entity = new Comment()
            {
                Id = 1,
                PostId = 1,
                Text = "lorem ipsum sit amet sasj"
            };
            entity.SetCreatedByName("InitialCreate");
            entity.SetModifiedByName("InitialCreate");
            builder.HasData(entity);
        }
    }
}
