using DAO.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAO
{
    public class NotFakeContext : DbContext
    {
        public NotFakeContext(DbContextOptions<NotFakeContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(new User()
            {
                Id = 1,
                Email = "admin@demo.com",
                Password = "@123456Xx",
                Role = UserRoles.Admin,
                Fullname = "admin"
            });
            
            modelBuilder.Entity<Friendship>()
                .HasKey( o => new { o.User1Id, o.User2Id });
            modelBuilder.Entity<Post>()
                .HasKey(o => new { o.User1ID, o.User2ID });
            modelBuilder.Entity<UserFilmInvite>()
                .HasKey(o => new { o.User1ID, o.User2ID, o.FilmID, o.WatchDate });
            modelBuilder.Entity<UserFilm>()
                .HasKey(o => new { o.UserId, o.FilmId });
        }

        public DbSet<User> User { get; set; }
        public DbSet<Friendship> Friendships { get; set; }
        public DbSet<UserFilmInvite> UserFilmInvites { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Film> Film { get; set; }
        public DbSet<Genre> Genre { get; set; }
        public DbSet<UserFilm> UserFilm { get; set; }
    }
}
