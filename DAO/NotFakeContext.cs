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
                UserId = 1,
                Email = "admin@demo.com",
                Password = Utilities.Crypto.HashPassword("NotFake@123"),
                Role = UserRoles.Admin,
                Fullname = "admin"
            });

            modelBuilder.Entity<Genre>()
                .HasData(new Genre()
                {
                    GenreId = 1,
                    Name = "Comedies"
                });

            modelBuilder.Entity<Film>()
                .HasData(
                        new Film() { FilmId = 1, 
                        Name = "Balloon", 
                        GenreId = 1, 
                        RunTime = 100, 
                        ThumbnailAddress = "Thumbnails/Balloon.PNG",
                        FilmAddress = "" 
                        }
                );
            modelBuilder.Entity<Friendship>()
                .HasKey(f => new { f.InvitedUserId, f.InvitingUserId });
            modelBuilder.Entity<Friendship>()
                .HasOne(f => f.InvitingUser)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Friendship>()
                .HasOne(f => f.InvitedUser)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Post>()
               .HasOne(p => p.SentUser)
               .WithMany()
               .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Post>()
                .HasOne(p => p.ReceivedUser)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<UserFilm>()
                .HasKey(uf => new { uf.UserId, uf.FilmId });

            modelBuilder.Entity<UserFilmInvite>()
                .HasKey(ufi => new { ufi.InvitedUserId, ufi.InvitingUserId, ufi.FilmId });
            modelBuilder.Entity<UserFilmInvite>()
                .HasOne(ufi => ufi.InvitingUser)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<UserFilmInvite>()
                .HasOne(ufi => ufi.InvitingUser)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<UserFilmInvite>()
                .HasOne(ufi => ufi.InvitedUser)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<UserFilmInvite>()
                .HasOne(ufi => ufi.Film)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);
        }

        public DbSet<Film> Film { get; set; }
        public DbSet<Friendship> Friendships { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<UserFilmInvite> UserFilmInvites { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Genre> Genre { get; set; }
        public DbSet<UserFilm> UserFilm { get; set; }
    }
}
