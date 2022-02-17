using Blog.Entities.Concrete;
using Blog.Shared.Entities;
using System;
using System.Collections.Generic;

namespace Blog.Entities
{
    public class Post : EntityBase, IEntity
    {
        public Post()
        {

        }

        public Post( int categoryId, string content, DateTime date, string note, string seoAuthor, string seoDescription, string seoTags, string thumbnail,
            string title, int userId) : base(note)
        {
            this.Title = title;
            this.CategoryId = categoryId;
            this.Content = content;
            this.Date = date;
            this.SeoAuthor = seoAuthor;
            this.SeoDescription = seoDescription;
            this.SeoTags = seoTags;
            this.Thumbnail = thumbnail;
            this.UserId = userId;            
        }
        public int UserId { get; set; }
        public int CategoryId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Thumbnail { get; set; }
        public DateTime Date { get; set; }
        public int ViewsCount { get; set; }
        public int CommentCount { get; set; }
        public string SeoAuthor { get; set; }
        public string SeoDescription { get; set; }
        public string SeoTags { get; set; }

        // relations
        public Category Category { get; set; }
        public User User { get; set; }
        public ICollection<Comment> Comments { get; set; }

        // methods
        public void SetViewCount()
        {
            this.ViewsCount += 1;
        }
    }
}
