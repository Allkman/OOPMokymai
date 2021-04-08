using Microsoft.EntityFrameworkCore;
using SQL.P2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SQL.P2.Database
{
    public class EfCoreDbContext :DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Author>  Authors { get; set; }
        public DbSet<AuthorBlog>  AuthorBlogs { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = EfCoreBloging");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AuthorBlog>().HasKey(k => new { k.AuthorId, k.BlogId });
            modelBuilder.Entity<AuthorBlog>()
                .HasOne(a => a.Author)
                .WithMany(ab => ab.AuthorBlogs)
                .HasForeignKey(k => k.AuthorId);

            modelBuilder.Entity<AuthorBlog>()
                .HasOne(b => b.Blog)
                .WithMany(ab => ab.AuthorBlogs)
                .HasForeignKey(k => k.BlogId);
        }
    }
}
