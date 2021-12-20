using Blog.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entities
{
    public class Comment : EntityBase, IEntity
    {
        public int PostId { get; set; }
        public string Text { get; set; }

        // relations
        public Post Post { get; set; }
    }
}
