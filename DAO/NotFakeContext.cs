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
        }

        public DbSet<User> User { get; set; }
        public DbSet<UserFilmInvite> UserFilmInvites { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Film> Film { get; set; }
        public DbSet<Genre> Genre { get; set; }
        public DbSet<UserFilm> UserFilm { get; set; }
    }
}
