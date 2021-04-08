namespace SQL.P2.Models
{
    public class AuthorBlog
        {
            public int AuthorId { get; set; }
            public int BlogId { get; set; }
            public Author Author { get; set; }
            public Blog Blog { get; set; }
        }
    
}
