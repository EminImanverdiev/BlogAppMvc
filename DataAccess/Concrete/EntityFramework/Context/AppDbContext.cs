using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework.Context
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=LAPTOP-S4ROCGFN\SQLEXPRESS01;Database=BlogDb;Trusted_Connection=true");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Entities.Concrete.Match>()
                .HasOne(x => x.HomeTeam)
                .WithMany(y=>y.HomeMatches)
                .HasForeignKey(z=>z.HomeTeamId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Entities.Concrete.Match>()
                 .HasOne(x => x.GuestTeam)
                .WithMany(y => y.AwayMatches)
                .HasForeignKey(z => z.GuestTeamId)
                .OnDelete(DeleteBehavior.ClientSetNull);
            modelBuilder.Entity<SecondMessage>()
              .HasOne(x => x.SenderUser)
             .WithMany(y => y.WriterSender)
             .HasForeignKey(z => z.MessageSenderId)
             .OnDelete(DeleteBehavior.ClientSetNull);
            modelBuilder.Entity<SecondMessage>()
           .HasOne(x => x.ReceiverUser)
          .WithMany(y => y.WriterReceiver)
          .HasForeignKey(z => z.MessageReceiverId)
          .OnDelete(DeleteBehavior.ClientSetNull);

        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Category> Categorys { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Writer> Writers { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<NewsLetter> NewsLetters { get; set; }
        public DbSet<ArticleRayting> ArticleRaytings { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<SecondMessage> secondMessages { get; set; }
        public DbSet<Entities.Concrete.Match> Matches { get; set; }

    }

}
