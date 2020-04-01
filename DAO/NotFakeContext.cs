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
                    },
                    new FilmData()
                    {
                        Id = 9,
                        Name = "Sufferin' Cats!",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/009%20%20%20Sufferin%27%20Cats%21%20%5B1943%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/009%20%20%20Sufferin%27%20Cats%21%20%5B1943%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 10,
                        Name = "The Lonesome Mouse",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/010%20%20%20The%20Lonesome%20Mouse%20%5B1943%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/010%20%20%20The%20Lonesome%20Mouse%20%5B1943%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 11,
                        Name = "The Yankee Doodle Mouse",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/011%20%20%20The%20Yankee%20Doodle%20Mouse%20%5B1943%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/011%20%20%20The%20Yankee%20Doodle%20Mouse%20%5B1943%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 12,
                        Name = "Baby Puss",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/012%20%20%20Baby%20Puss%20%5B1943%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/012%20%20%20Baby%20Puss%20%5B1943%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 13,
                        Name = "The Zoot Cat",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/013%20%20%20The%20Zoot%20Cat%20%5B1944%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/013%20%20%20The%20Zoot%20Cat%20%5B1944%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 14,
                        Name = "The Million Dollar Cat",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/014%20%20%20The%20Million%20Dollar%20Cat%20%5B1944%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/014%20%20%20The%20Million%20Dollar%20Cat%20%5B1944%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 15,
                        Name = "The Bodyguard",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/015%20%20%20The%20Bodyguard%20%5B1944%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/015%20%20%20The%20Bodyguard%20%5B1944%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 16,
                        Name = "Puttin' on the Dog",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/016%20%20%20Puttin%27%20on%20the%20Dog%20%5B1944%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/016%20%20%20Puttin%27%20on%20the%20Dog%20%5B1944%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 17,
                        Name = "Mouse Trouble",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/017%20%20%20Mouse%20Trouble%20%5B1944%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/017%20%20%20Mouse%20Trouble%20%5B1944%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 18,
                        Name = "The Mouse Comes to Dinner",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/018%20%20%20The%20Mouse%20Comes%20to%20Dinner%20%5B1945%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/018%20%20%20The%20Mouse%20Comes%20to%20Dinner%20%5B1945%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 19,
                        Name = "Mouse in Manhattan",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/019%20%20%20Mouse%20in%20Manhattan%20%5B1945%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/019%20%20%20Mouse%20in%20Manhattan%20%5B1945%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 20,
                        Name = "Tee for Two",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/020%20%20%20Tee%20for%20Two%20%5B1945%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/020%20%20%20Tee%20for%20Two%20%5B1945%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 21,
                        Name = "Flirty Birdy",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/021%20%20%20Flirty%20Birdy%20%5B1945%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/021%20%20%20Flirty%20Birdy%20%5B1945%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 22,
                        Name = "Quiet Please!",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/022%20%20%20Quiet%20Please%21%20%5B1945%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/022%20%20%20Quiet%20Please%21%20%5B1945%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 23,
                        Name = "Springtime for Thomas",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/023%20%20%20Springtime%20for%20Thomas%20%5B1946%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/023%20%20%20Springtime%20for%20Thomas%20%5B1946%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 24,
                        Name = "The Milky Waif",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/024%20%20%20The%20Milky%20Waif%20%5B1946%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/024%20%20%20The%20Milky%20Waif%20%5B1946%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 25,
                        Name = "Trap Happy",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/025%20%20%20Trap%20Happy%20%5B1946%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/025%20%20%20Trap%20Happy%20%5B1946%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 26,
                        Name = "Solid Serenade",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/026%20%20%20Solid%20Serenade%20%5B1946%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/026%20%20%20Solid%20Serenade%20%5B1946%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 27,
                        Name = "Cat Fishin'",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/027%20%20%20Cat%20Fishin%27%20%5B1947%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/027%20%20%20Cat%20Fishin%27%20%5B1947%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 28,
                        Name = "Part Time Pal",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/028%20%20%20Part%20Time%20Pal%20%5B1947%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/028%20%20%20Part%20Time%20Pal%20%5B1947%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 29,
                        Name = "The Cat Concerto",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/029%20%20%20The%20Cat%20Concerto%20%5B1947%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/029%20%20%20The%20Cat%20Concerto%20%5B1947%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 30,
                        Name = "Dr. Jekyll and Mr. Mouse",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/030%20%20%20Dr.%20Jekyll%20and%20Mr.%20Mouse%20%5B1947%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/030%20%20%20Dr.%20Jekyll%20and%20Mr.%20Mouse%20%5B1947%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 31,
                        Name = "Salt Water Tabby",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/031%20%20%20Salt%20Water%20Tabby%20%5B1947%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/031%20%20%20Salt%20Water%20Tabby%20%5B1947%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 32,
                        Name = "A Mouse in the House",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/032%20%20%20A%20Mouse%20in%20the%20House%20%5B1947%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/032%20%20%20A%20Mouse%20in%20the%20House%20%5B1947%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 33,
                        Name = "The Invisible Mouse",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/033%20%20%20The%20Invisible%20Mouse%20%5B1947%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/033%20%20%20The%20Invisible%20Mouse%20%5B1947%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 34,
                        Name = "Kitty Foiled",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/034%20%20%20Kitty%20Foiled%20%5B1948%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/034%20%20%20Kitty%20Foiled%20%5B1948%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 35,
                        Name = "The Truce Hurts",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/035%20%20%20The%20Truce%20Hurts%20%5B1948%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/035%20%20%20The%20Truce%20Hurts%20%5B1948%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 36,
                        Name = "Old Rockin' Chair Tom",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/036%20%20%20Old%20Rockin%27%20Chair%20Tom%20%5B1948%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/036%20%20%20Old%20Rockin%27%20Chair%20Tom%20%5B1948%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 37,
                        Name = "Professor Tom",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/037%20%20%20Professor%20Tom%20%5B1948%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/037%20%20%20Professor%20Tom%20%5B1948%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 38,
                        Name = "Mouse Cleaning",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/038%20%20%20Mouse%20Cleaning%20%5B1948%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/038%20%20%20Mouse%20Cleaning%20%5B1948%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 39,
                        Name = "Polka Dot Puss",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/039%20%20%20Polka%20Dot%20Puss%20%5B1949%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/039%20%20%20Polka%20Dot%20Puss%20%5B1949%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 40,
                        Name = "The Little Orphan",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/040%20%20%20The%20Little%20Orphan%20%5B1949%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/040%20%20%20The%20Little%20Orphan%20%5B1949%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 41,
                        Name = "Hatch Up Your Troubles",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/041%20%20%20Hatch%20Up%20Your%20Troubles%20%5B1949%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/041%20%20%20Hatch%20Up%20Your%20Troubles%20%5B1949%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 42,
                        Name = "Heavenly Puss",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/042%20%20%20Heavenly%20Puss%20%5B1949%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/042%20%20%20Heavenly%20Puss%20%5B1949%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 43,
                        Name = "The Cat and the Mermouse",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/043%20%20%20The%20Cat%20and%20the%20Mermouse%20%5B1949%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/043%20%20%20The%20Cat%20and%20the%20Mermouse%20%5B1949%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 44,
                        Name = "Love That Pup",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/044%20%20%20Love%20That%20Pup%20%5B1949%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/044%20%20%20Love%20That%20Pup%20%5B1949%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 45,
                        Name = "Jerry's Diary",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/045%20%20%20Jerry%27s%20Diary%20%5B1949%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/045%20%20%20Jerry%27s%20Diary%20%5B1949%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 46,
                        Name = "Tennis Chumps",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/046%20%20%20Tennis%20Chumps%20%5B1949%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/046%20%20%20Tennis%20Chumps%20%5B1949%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 47,
                        Name = "Little Quacker",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/047%20%20%20Little%20Quacker%20%5B1950%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/047%20%20%20Little%20Quacker%20%5B1950%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 48,
                        Name = "Saturday Evening Puss",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/048%20%20%20Saturday%20Evening%20Puss%20%5B1950%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/048%20%20%20Saturday%20Evening%20Puss%20%5B1950%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 49,
                        Name = "Texas Tom",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/049%20%20%20Texas%20Tom%20%5B1950%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/049%20%20%20Texas%20Tom%20%5B1950%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 50,
                        Name = "Jerry and the Lion",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/050%20%20%20Jerry%20and%20the%20Lion%20%5B1950%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/050%20%20%20Jerry%20and%20the%20Lion%20%5B1950%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 51,
                        Name = "Safety Second",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/051%20%20%20Safety%20Second%20%5B1950%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/051%20%20%20Safety%20Second%20%5B1950%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 52,
                        Name = "The Hollywood Bowl",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/052%20%20%20The%20Hollywood%20Bowl%20%5B1950%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/052%20%20%20The%20Hollywood%20Bowl%20%5B1950%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 53,
                        Name = "The Framed Cat",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/053%20%20%20The%20Framed%20Cat%20%5B1950%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/053%20%20%20The%20Framed%20Cat%20%5B1950%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 54,
                        Name = "Cue Ball Cat",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/054%20%20%20Cue%20Ball%20Cat%20%5B1950%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/054%20%20%20Cue%20Ball%20Cat%20%5B1950%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 55,
                        Name = "Casanova Cat",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/055%20%20%20Casanova%20Cat%20%5B1951%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/055%20%20%20Casanova%20Cat%20%5B1951%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 56,
                        Name = "Jerry and the Goldfish",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/056%20%20%20Jerry%20and%20the%20Goldfish%20%5B1951%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/056%20%20%20Jerry%20and%20the%20Goldfish%20%5B1951%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 57,
                        Name = "Jerry's Cousin",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/057%20%20%20Jerry%27s%20Cousin%20%5B1951%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/057%20%20%20Jerry%27s%20Cousin%20%5B1951%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 58,
                        Name = "Sleepy Time Tom",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/058%20%20%20Sleepy%20Time%20Tom%20%5B1951%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/058%20%20%20Sleepy%20Time%20Tom%20%5B1951%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 59,
                        Name = "His Mouse Friday",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/059%20%20%20His%20Mouse%20Friday%20%5B1951%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/059%20%20%20His%20Mouse%20Friday%20%5B1951%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 60,
                        Name = "Slicked up Pup",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/060%20%20%20Slicked%20up%20Pup%20%5B1951%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/060%20%20%20Slicked%20up%20Pup%20%5B1951%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 61,
                        Name = "Nit Witty Kitty",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/061%20%20%20Nit%20Witty%20Kitty%20%5B1951%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/061%20%20%20Nit%20Witty%20Kitty%20%5B1951%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 62,
                        Name = "Cat Napping",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/062%20%20%20Cat%20Napping%20%5B1951%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/062%20%20%20Cat%20Napping%20%5B1951%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 63,
                        Name = "The Flying Cat",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/063%20%20%20The%20Flying%20Cat%20%5B1952%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/063%20%20%20The%20Flying%20Cat%20%5B1952%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 64,
                        Name = "The Duck Doctor",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/064%20%20%20The%20Duck%20Doctor%20%5B1952%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/064%20%20%20The%20Duck%20Doctor%20%5B1952%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 65,
                        Name = "The Two Mouseketeers",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/065%20%20%20The%20Two%20Mouseketeers%20%5B1952%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/065%20%20%20The%20Two%20Mouseketeers%20%5B1952%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 66,
                        Name = "Smitten Kitten",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/066%20%20%20Smitten%20Kitten%20%5B1952%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/066%20%20%20Smitten%20Kitten%20%5B1952%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 67,
                        Name = "Triplet Trouble",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/067%20%20%20Triplet%20Trouble%20%5B1952%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/067%20%20%20Triplet%20Trouble%20%5B1952%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 68,
                        Name = "Little Runaway",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/068%20%20%20Little%20Runaway%20%5B1952%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/068%20%20%20Little%20Runaway%20%5B1952%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 69,
                        Name = "Fit to be Tied",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/069%20%20%20Fit%20to%20be%20Tied%20%5B1952%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/069%20%20%20Fit%20to%20be%20Tied%20%5B1952%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 70,
                        Name = "Push Button Kitty",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/070%20%20%20Push%20Button%20Kitty%20%5B1952%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/070%20%20%20Push%20Button%20Kitty%20%5B1952%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 71,
                        Name = "Cruise Cat",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/071%20%20%20Cruise%20Cat%20%5B1952%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/071%20%20%20Cruise%20Cat%20%5B1952%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 72,
                        Name = "The Dog House",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/072%20%20%20The%20Dog%20House%20%5B1952%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/072%20%20%20The%20Dog%20House%20%5B1952%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 73,
                        Name = "The Missing Mouse",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/073%20%20%20The%20Missing%20Mouse%20%5B1953%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/073%20%20%20The%20Missing%20Mouse%20%5B1953%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 74,
                        Name = "Jerry and Jumbo",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/074%20%20%20Jerry%20and%20Jumbo%20%5B1953%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/074%20%20%20Jerry%20and%20Jumbo%20%5B1953%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 75,
                        Name = "Johann Mouse",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/075%20%20%20Johann%20Mouse%20%5B1953%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/075%20%20%20Johann%20Mouse%20%5B1953%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 76,
                        Name = "That's My Pup!",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/076%20%20%20That%27s%20My%20Pup%21%20%5B1953%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/076%20%20%20That%27s%20My%20Pup%21%20%5B1953%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 77,
                        Name = "Just Ducky",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/077%20%20%20Just%20Ducky%20%5B1953%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/077%20%20%20Just%20Ducky%20%5B1953%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 78,
                        Name = "Two Little Indians",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/078%20%20%20Two%20Little%20Indians%20%5B1953%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/078%20%20%20Two%20Little%20Indians%20%5B1953%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 79,
                        Name = "Life with Tom",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/079%20%20%20Life%20with%20Tom%20%5B1953%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/079%20%20%20Life%20with%20Tom%20%5B1953%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 80,
                        Name = "Puppy Tale",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/080%20%20%20Puppy%20Tale%20%5B1954%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/080%20%20%20Puppy%20Tale%20%5B1954%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 81,
                        Name = "Posse Cat",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/081%20%20%20Posse%20Cat%20%5B1954%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/081%20%20%20Posse%20Cat%20%5B1954%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 82,
                        Name = "Hic cup Pup",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/082%20%20%20Hic%20cup%20Pup%20%5B1954%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/082%20%20%20Hic%20cup%20Pup%20%5B1954%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 83,
                        Name = "Little School Mouse",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/083%20%20%20Little%20School%20Mouse%20%5B1954%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/083%20%20%20Little%20School%20Mouse%20%5B1954%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 84,
                        Name = "Baby Butch",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/084%20%20%20Baby%20Butch%20%5B1954%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/084%20%20%20Baby%20Butch%20%5B1954%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 85,
                        Name = "Mice Follies",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/085%20%20%20Mice%20Follies%20%5B1954%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/085%20%20%20Mice%20Follies%20%5B1954%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 86,
                        Name = "Neapolitan Mouse",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/086%20%20%20Neapolitan%20Mouse%20%5B1954%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/086%20%20%20Neapolitan%20Mouse%20%5B1954%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 87,
                        Name = "Downhearted Duckling",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/087%20%20%20Downhearted%20Duckling%20%5B1954%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/087%20%20%20Downhearted%20Duckling%20%5B1954%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 88,
                        Name = "Pet Peeve",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/088%20%20%20Pet%20Peeve%20%5B1954%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/088%20%20%20Pet%20Peeve%20%5B1954%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 89,
                        Name = "Touché, Pussy Cat!",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/089%20%20%20Touch%C3%A9%2C%20Pussy%20Cat%21%20%5B1954%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/089%20%20%20Touch%C3%A9%2C%20Pussy%20Cat%21%20%5B1954%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 90,
                        Name = "Southbound Duckling",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/090%20%20%20Southbound%20Duckling%20%5B1955%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/090%20%20%20Southbound%20Duckling%20%5B1955%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 91,
                        Name = "Pup on a Picnic",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/091%20%20%20Pup%20on%20a%20Picnic%20%5B1955%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/091%20%20%20Pup%20on%20a%20Picnic%20%5B1955%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 92,
                        Name = "Mouse for Sale",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/092%20%20%20Mouse%20for%20Sale%20%5B1955%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/092%20%20%20Mouse%20for%20Sale%20%5B1955%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 93,
                        Name = "Designs on Jerry",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/093%20%20%20Designs%20on%20Jerry%20%5B1955%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/093%20%20%20Designs%20on%20Jerry%20%5B1955%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 94,
                        Name = "Tom and Chérie",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/094%20%20%20Tom%20and%20Ch%C3%A9rie%20%5B1955%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/094%20%20%20Tom%20and%20Ch%C3%A9rie%20%5B1955%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 95,
                        Name = "Smarty Cat",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/095%20%20%20Smarty%20Cat%20%5B1955%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/095%20%20%20Smarty%20Cat%20%5B1955%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 96,
                        Name = "Pecos Pest",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/096%20%20%20Pecos%20Pest%20%5B1955%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/096%20%20%20Pecos%20Pest%20%5B1955%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 97,
                        Name = "That's My Mommy",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/097%20%20%20That%27s%20My%20Mommy%20%5B1955%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/097%20%20%20That%27s%20My%20Mommy%20%5B1955%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 98,
                        Name = "The Flying Sorceress",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/098%20%20%20The%20Flying%20Sorceress%20%5B1956%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/098%20%20%20The%20Flying%20Sorceress%20%5B1956%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 99,
                        Name = "The Egg and Jerry",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/099%20%20%20The%20Egg%20and%20Jerry%20%5B1956%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/099%20%20%20The%20Egg%20and%20Jerry%20%5B1956%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 100,
                        Name = "Busy Buddies",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/100%20%20%20Busy%20Buddies%20%5B1956%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/100%20%20%20Busy%20Buddies%20%5B1956%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 101,
                        Name = "Muscle Beach Tom",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/101%20%20%20Muscle%20Beach%20Tom%20%5B1956%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/101%20%20%20Muscle%20Beach%20Tom%20%5B1956%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 102,
                        Name = "Down Beat Bear",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/102%20%20%20Down%20Beat%20Bear%20%5B1956%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/102%20%20%20Down%20Beat%20Bear%20%5B1956%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 103,
                        Name = "Blue Cat Blues",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/103%20%20%20Blue%20Cat%20Blues%20%5B1956%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/103%20%20%20Blue%20Cat%20Blues%20%5B1956%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 104,
                        Name = "Barbecue Brawl",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/104%20%20%20Barbecue%20Brawl%20%5B1956%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/104%20%20%20Barbecue%20Brawl%20%5B1956%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 105,
                        Name = "Tops with Pops",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/105%20%20%20Tops%20with%20Pops%20%5B1957%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/105%20%20%20Tops%20with%20Pops%20%5B1957%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 106,
                        Name = "Timid Tabby",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/106%20%20%20Timid%20Tabby%20%5B1957%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/106%20%20%20Timid%20Tabby%20%5B1957%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 107,
                        Name = "Feedin' the Kiddie",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/107%20%20%20Feedin%27%20the%20Kiddie%20%5B1957%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/107%20%20%20Feedin%27%20the%20Kiddie%20%5B1957%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 108,
                        Name = "Mucho Mouse",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/108%20%20%20Mucho%20Mouse%20%5B1957%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/108%20%20%20Mucho%20Mouse%20%5B1957%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 109,
                        Name = "Tom's Photo Finish",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/109%20%20%20Tom%27s%20Photo%20Finish%20%5B1957%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/109%20%20%20Tom%27s%20Photo%20Finish%20%5B1957%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 110,
                        Name = "Happy Go Ducky",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/110%20%20%20Happy%20Go%20Ducky%20%5B1958%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/110%20%20%20Happy%20Go%20Ducky%20%5B1958%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 111,
                        Name = "Royal Cat Nap",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/111%20%20%20Royal%20Cat%20Nap%20%5B1958%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/111%20%20%20Royal%20Cat%20Nap%20%5B1958%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 112,
                        Name = "The Vanishing Duck",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/112%20%20%20The%20Vanishing%20Duck%20%5B1958%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/112%20%20%20The%20Vanishing%20Duck%20%5B1958%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 113,
                        Name = "Robin Hoodwinked",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/113%20%20%20Robin%20Hoodwinked%20%5B1958%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/113%20%20%20Robin%20Hoodwinked%20%5B1958%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 114,
                        Name = "Tot Watchers",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/114%20%20%20Tot%20Watchers%20%5B1958%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/114%20%20%20Tot%20Watchers%20%5B1958%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 115,
                        Name = "Switchin' Kitten",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/115%20%20%20Switchin%27%20Kitten%20%5B1961%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/115%20%20%20Switchin%27%20Kitten%20%5B1961%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 116,
                        Name = "Down and Outing",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/116%20%20%20Down%20and%20Outing%20%5B1961%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/116%20%20%20Down%20and%20Outing%20%5B1961%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 117,
                        Name = "It's Greek to Me ow",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/117%20%20%20It%27s%20Greek%20to%20Me%20ow%20%5B1961%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/117%20%20%20It%27s%20Greek%20to%20Me%20ow%20%5B1961%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 118,
                        Name = "High Steaks",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/118%20%20%20High%20Steaks%20%5B1962%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/118%20%20%20High%20Steaks%20%5B1962%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 119,
                        Name = "Mouse Into Space",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/119%20%20%20Mouse%20Into%20Space%20%5B1962%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/119%20%20%20Mouse%20Into%20Space%20%5B1962%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 120,
                        Name = "Landing Stripling",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/120%20%20%20Landing%20Stripling%20%5B1962%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/120%20%20%20Landing%20Stripling%20%5B1962%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 121,
                        Name = "Calypso Cat",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/121%20%20%20Calypso%20Cat%20%5B1962%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/121%20%20%20Calypso%20Cat%20%5B1962%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 122,
                        Name = "Dicky Moe",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/122%20%20%20Dicky%20Moe%20%5B1962%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/122%20%20%20Dicky%20Moe%20%5B1962%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 123,
                        Name = "The Tom and Jerry Cartoon Kit",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/123%20%20%20The%20Tom%20and%20Jerry%20Cartoon%20Kit%20%5B1962%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/123%20%20%20The%20Tom%20and%20Jerry%20Cartoon%20Kit%20%5B1962%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 124,
                        Name = "Tall in the Trap",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/124%20%20%20Tall%20in%20the%20Trap%20%5B1962%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/124%20%20%20Tall%20in%20the%20Trap%20%5B1962%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 125,
                        Name = "Sorry Safari",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/125%20%20%20Sorry%20Safari%20%5B1962%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/125%20%20%20Sorry%20Safari%20%5B1962%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 126,
                        Name = "Buddies Thicker Than Water",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/126%20%20%20Buddies%20Thicker%20Than%20Water%20%5B1962%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/126%20%20%20Buddies%20Thicker%20Than%20Water%20%5B1962%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 127,
                        Name = "Carmen Get It!",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/127%20%20%20Carmen%20Get%20It%21%20%5B1962%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/127%20%20%20Carmen%20Get%20It%21%20%5B1962%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 128,
                        Name = "Pent House Mouse",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/128%20%20%20Pent%20House%20Mouse%20%5B1963%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/128%20%20%20Pent%20House%20Mouse%20%5B1963%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 129,
                        Name = "The Cat Above and the Mouse Below",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/129%20%20%20The%20Cat%20Above%20and%20the%20Mouse%20Below%20%5B1964%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/129%20%20%20The%20Cat%20Above%20and%20the%20Mouse%20Below%20%5B1964%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 130,
                        Name = "Is There a Doctor in the Mouse",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/130%20%20%20Is%20There%20a%20Doctor%20in%20the%20Mouse%20%5B1964%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/130%20%20%20Is%20There%20a%20Doctor%20in%20the%20Mouse%20%5B1964%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 131,
                        Name = "Much Ado About Mousing",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/131%20%20%20Much%20Ado%20About%20Mousing%20%5B1964%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/131%20%20%20Much%20Ado%20About%20Mousing%20%5B1964%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 132,
                        Name = "Snowbody Loves Me",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/132%20%20%20Snowbody%20Loves%20Me%20%5B1964%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/132%20%20%20Snowbody%20Loves%20Me%20%5B1964%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 133,
                        Name = "The Unshrinkable Jerry Mouse",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/133%20%20%20The%20Unshrinkable%20Jerry%20Mouse%20%5B1964%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/133%20%20%20The%20Unshrinkable%20Jerry%20Mouse%20%5B1964%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 134,
                        Name = "Ah, Sweet Mouse Story of Life",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/134%20%20%20Ah%2C%20Sweet%20Mouse%20Story%20of%20Life%20%5B1965%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/134%20%20%20Ah%2C%20Sweet%20Mouse%20Story%20of%20Life%20%5B1965%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 135,
                        Name = "Tom ic Energy",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/135%20%20%20Tom%20ic%20Energy%20%5B1965%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/135%20%20%20Tom%20ic%20Energy%20%5B1965%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 136,
                        Name = "Bad Day at Cat Rock",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/136%20%20%20Bad%20Day%20at%20Cat%20Rock%20%5B1965%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/136%20%20%20Bad%20Day%20at%20Cat%20Rock%20%5B1965%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 137,
                        Name = "The Brothers Carry Mouse Off",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/137%20%20%20The%20Brothers%20Carry%20Mouse%20Off%20%5B1965%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/137%20%20%20The%20Brothers%20Carry%20Mouse%20Off%20%5B1965%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 138,
                        Name = "Haunted Mouse",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/138%20%20%20Haunted%20Mouse%20%5B1965%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/138%20%20%20Haunted%20Mouse%20%5B1965%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 139,
                        Name = "I'm Just Wild About Jerry",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/139%20%20%20I%27m%20Just%20Wild%20About%20Jerry%20%5B1965%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/139%20%20%20I%27m%20Just%20Wild%20About%20Jerry%20%5B1965%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 140,
                        Name = "Of Feline Bondage",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/140%20%20%20Of%20Feline%20Bondage%20%5B1965%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/140%20%20%20Of%20Feline%20Bondage%20%5B1965%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 141,
                        Name = "The Year of the Mouse",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/141%20%20%20The%20Year%20of%20the%20Mouse%20%5B1965%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/141%20%20%20The%20Year%20of%20the%20Mouse%20%5B1965%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 142,
                        Name = "The Cat's Me Ouch",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/142%20%20%20The%20Cat%27s%20Me%20Ouch%20%5B1965%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/142%20%20%20The%20Cat%27s%20Me%20Ouch%20%5B1965%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 143,
                        Name = "Duel Personality",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/143%20%20%20Duel%20Personality%20%5B1966%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/143%20%20%20Duel%20Personality%20%5B1966%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 144,
                        Name = "Jerry, Jerry, Quite Contrary",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/144%20%20%20Jerry%2C%20Jerry%2C%20Quite%20Contrary%20%5B1966%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/144%20%20%20Jerry%2C%20Jerry%2C%20Quite%20Contrary%20%5B1966%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 145,
                        Name = "Jerry Go Round",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/145%20%20%20Jerry%20Go%20Round%20%5B1966%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/145%20%20%20Jerry%20Go%20Round%20%5B1966%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 146,
                        Name = "Love Me, Love My Mouse",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/146%20%20%20Love%20Me%2C%20Love%20My%20Mouse%20%5B1966%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/146%20%20%20Love%20Me%2C%20Love%20My%20Mouse%20%5B1966%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 147,
                        Name = "Puss 'n' Boats",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/147%20%20%20Puss%20%27n%27%20Boats%20%5B1966%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/147%20%20%20Puss%20%27n%27%20Boats%20%5B1966%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 148,
                        Name = "Filet Meow",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/148%20%20%20Filet%20Meow%20%5B1966%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/148%20%20%20Filet%20Meow%20%5B1966%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 149,
                        Name = "Matinee Mouse",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/149%20%20%20Matinee%20Mouse%20%5B1966%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/149%20%20%20Matinee%20Mouse%20%5B1966%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 150,
                        Name = "The A Tom Inable Snowman",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/150%20%20%20The%20A%20Tom%20Inable%20Snowman%20%5B1966%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/150%20%20%20The%20A%20Tom%20Inable%20Snowman%20%5B1966%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 151,
                        Name = "Catty Cornered",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/151%20%20%20Catty%20Cornered%20%5B1966%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/151%20%20%20Catty%20Cornered%20%5B1966%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 152,
                        Name = "Cat and Dupli cat",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/152%20%20%20Cat%20and%20Dupli%20cat%20%5B1966%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/152%20%20%20Cat%20and%20Dupli%20cat%20%5B1966%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 153,
                        Name = "O Solar Meow",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/153%20%20%20O%20Solar%20Meow%20%5B1966%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/153%20%20%20O%20Solar%20Meow%20%5B1966%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 154,
                        Name = "Guided Mouse ille",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/154%20%20%20Guided%20Mouse%20ille%20%5B1966%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/154%20%20%20Guided%20Mouse%20ille%20%5B1966%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 155,
                        Name = "Rock 'n' Rodent",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/155%20%20%20Rock%20%27n%27%20Rodent%20%5B1967%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/155%20%20%20Rock%20%27n%27%20Rodent%20%5B1967%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 156,
                        Name = "Cannery Rodent",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/156%20%20%20Cannery%20Rodent%20%5B1967%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/156%20%20%20Cannery%20Rodent%20%5B1967%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 157,
                        Name = "The Mouse from H.U.N.G.E.R.",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/157%20%20%20The%20Mouse%20from%20H.U.N.G.E.R.%20%5B1967%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/157%20%20%20The%20Mouse%20from%20H.U.N.G.E.R.%20%5B1967%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 158,
                        Name = "Surf Bored Cat",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/158%20%20%20Surf%20Bored%20Cat%20%5B1967%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/158%20%20%20Surf%20Bored%20Cat%20%5B1967%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 159,
                        Name = "Shutter Bugged Cat",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/159%20%20%20Shutter%20Bugged%20Cat%20%5B1967%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/159%20%20%20Shutter%20Bugged%20Cat%20%5B1967%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 160,
                        Name = "Advance and Be Mechanized",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/160%20%20%20Advance%20and%20Be%20Mechanized%20%5B1967%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/160%20%20%20Advance%20and%20Be%20Mechanized%20%5B1967%5D.mp4"
                    },
                    new FilmData()
                    {
                        Id = 161,
                        Name = "Purr Chance to Dream",
                        RunTime = 100,
                        FilmId = 1,
                        ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/161%20%20%20Purr%20Chance%20to%20Dream%20%5B1967%5D_000001.jpg",
                        Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/161%20%20%20Purr%20Chance%20to%20Dream%20%5B1967%5D.mp4"
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
        public DbSet<FilmData> FilmData { get; set; }
        public DbSet<Friendship> Friendships { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<UserFilmInvite> UserFilmInvites { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Genre> Genre { get; set; }
        public DbSet<UserFilm> UserFilm { get; set; }
    }
}
