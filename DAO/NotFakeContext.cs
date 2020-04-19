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
            // add some more user
            List<User> someMoreUsers = new List<User>(){
                new User()
                {
                    UserId = 1,
                    Email = "admin@demo.com",
                    Password = Utilities.Crypto.HashPassword("NotFake@123"),
                    Role = UserRoles.Admin,
                    Fullname = "admin"
                }
            };
            for (int i = 2; i < 10; i++)
            {
                someMoreUsers.Add(new User()
                {
                    UserId = i,
                    Email = String.Format("user{0}@demo.com", i),
                    Password = Utilities.Crypto.HashPassword(String.Format("password{0}", i)),
                    Role = UserRoles.User,
                    Fullname = String.Format("user full name {0}", i)
                });
            }

            modelBuilder.Entity<User>().HasData(
                someMoreUsers.ToArray()
                );

            modelBuilder.Entity<Genre>()
                .HasData(new Genre()
                {
                    GenreId = 1,
                    Name = "Cartoons"
                });

            modelBuilder.Entity<Film>()
                .HasData(
                    new Film()
                    {
                        FilmId = 1,
                        Name = "Tom and Jerry",
                        ThumbnailAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/__ia_thumb.jpg",
                        GenreId = 1,
                        Type = FilmType.Series
                    }
                );

            modelBuilder.Entity<FilmData>()
                .HasKey(fd => new { fd.Id, fd.FilmId });

            modelBuilder.Entity<FilmData>()
                .HasData(
                    new FilmData()
                    {
                        Id = 1,
                        Name = "Puss Gets the Boot",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/001%20%20%20Puss%20Gets%20the%20Boot%20%5B1940%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/001%20%20%20Puss%20Gets%20the%20Boot%20%5B1940%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 2,
                        Name = "The Midnight Snack",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/002%20%20%20The%20Midnight%20Snack%20%5B1941%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/002%20%20%20The%20Midnight%20Snack%20%5B1941%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 3,
                        Name = "The Night Before Christmas",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/003%20%20%20The%20Night%20Before%20Christmas%20%5B1941%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/003%20%20%20The%20Night%20Before%20Christmas%20%5B1941%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 4,
                        Name = "Fraidy Cat",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/004%20%20%20Fraidy%20Cat%20%5B1942%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/004%20%20%20Fraidy%20Cat%20%5B1942%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 5,
                        Name = "Dog Trouble",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/005%20%20%20Dog%20Trouble%20%5B1942%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/005%20%20%20Dog%20Trouble%20%5B1942%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 6,
                        Name = "Puss n' Toots",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/006%20%20%20Puss%20n%27%20Toots%20%5B1942%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/006%20%20%20Puss%20n%27%20Toots%20%5B1942%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 7,
                        Name = "The Bowling Alley Cat",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/007%20%20%20The%20Bowling%20Alley%20Cat%20%5B1942%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/007%20%20%20The%20Bowling%20Alley%20Cat%20%5B1942%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 8,
                        Name = "Fine Feathered Friend",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/008%20%20%20Fine%20Feathered%20Friend%20%5B1942%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/008%20%20%20Fine%20Feathered%20Friend%20%5B1942%5D.mp4"
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

            modelBuilder.Entity<Group>()
                .HasOne(g => g.Film)
                .WithMany()
                .OnDelete(DeleteBehavior.SetNull);
            modelBuilder.Entity<Group>()
                .HasOne(g => g.Creator)
                .WithMany()
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<GroupMembers>()
                .HasKey(gm => new { gm.GroupId, gm.MemberId });
            modelBuilder.Entity<GroupMembers>()
                .HasOne(gm => gm.Group)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<GroupMembers>()
                .HasOne(gm => gm.Member)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Post>()
                .HasOne(p => p.Group)
                .WithMany()
                .OnDelete(DeleteBehavior.SetNull);
            modelBuilder.Entity<Post>()
                .HasOne(p => p.Creator)
                .WithMany()
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<UserFilm>()
                .HasKey(uf => new { uf.UserId, uf.FilmId });

            modelBuilder.Entity<UserFilmInvite>()
                .HasOne(ufi => ufi.Group)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);
                
            modelBuilder.Entity<UserFilmInvite>()
                .HasOne(ufi => ufi.InvitedUser)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }
        public DbSet<Film> Film { get; set; }
        public DbSet<FilmData> FilmData { get; set; }
        public DbSet<Friendship> Friendships { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<UserFilmInvite> UserFilmInvites { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Genre> Genre { get; set; }
        public DbSet<UserFilm> UserFilm { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<GroupMembers> GroupMembers { get; set; }
    }
}
