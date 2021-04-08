using Microsoft.EntityFrameworkCore;
using SQL.P2.Database;
using SQL.P2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SQL.P2
{
    public class ManageDb
    {
        private readonly EfCoreDbContext _context;

        public ManageDb(EfCoreDbContext context)
        {
            _context = context;
            _context.Database.EnsureCreated();
        }

        public void AddBlog(string name)
        {
            _context.Blogs.Add(new Blog { Name = name });
            _context.SaveChanges();
        }

        public void AddAuthor(string firstName, string lastName, int blogId)
        {
            _context.AuthorBlogs.Add(
                new AuthorBlog
                {
                    BlogId = blogId,
                    Author = new Author
                    {
                        FirstName = firstName,
                        LastName = lastName,
                    }
                });
            _context.SaveChanges();
        }
        public void GetBlogs()
        {
            var blogs = _context.Blogs.Include(b => b.Posts);
            foreach (var blog in blogs)
            {
                Console.WriteLine($"** {blog.BlogId}  {blog.Name}  posts:");
                foreach (var post in blog.Posts)
                {
                    Console.WriteLine($"     {post.Title} - {post.Content}");
                }
            }
        }
        public void GetAuthors()
        {
            var authors = _context.Authors.Include(a => a.AuthorBlogs).ThenInclude(z => z.Blog);
            foreach (var author in authors)
            {
                Console.WriteLine($"** {author.FirstName} {author.LastName} blogs:");
                foreach (var item in author.AuthorBlogs)
                {
                    Console.WriteLine($"      {item.Blog.Name}");
                }
            }
        }
        public void AddPost(string title, string content, int blogId)
        {
            var blog = _context.Blogs.Where(b => b.BlogId == blogId).Include(b => b.Posts).FirstOrDefault();
            blog.Posts.Add(new Post { Title = title, Content = content });
            _context.SaveChanges();
        }
        public void RemovePost()
        {
            var posts = _context.Posts.Where(p => p.PostId > 1);
            _context.Posts.RemoveRange(posts);
            _context.SaveChanges();
        }
    }
}
