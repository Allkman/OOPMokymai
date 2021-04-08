using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SQL.P2.Models
{
    public class Blog
    {
        [Key]
        public int BlogId { get; set; }
        public string Name { get; set; }
        public decimal Rating { get; set; }
        public virtual List<Post> Posts { get; set; }
        public virtual IList<AuthorBlog> AuthorBlogs { get; set; }
    }
}
