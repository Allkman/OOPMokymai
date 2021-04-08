using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SQL.P2.Models
{
    public class Author
    {
            [Key]
            public int AuthorId { get; set; }
            [MaxLength(100)]
            [Required(ErrorMessage = "FirstName is required")]
            public string FirstName { get; set; }
            [MaxLength(100)]
            [Required(ErrorMessage = "LastName is required")]
            public string LastName { get; set; }
            public virtual IList<AuthorBlog> AuthorBlogs { get; set; }
        }
    
}
