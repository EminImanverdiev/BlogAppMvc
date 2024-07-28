using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework.Context
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=LAPTOP-S4ROCGFN\SQLEXPRESS01;Database=BlogDb;Trusted_Connection=true");

        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Category> Categorys { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Writer> Writers { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<NewsLetter> NewsLetters { get; set; }

	}

}
