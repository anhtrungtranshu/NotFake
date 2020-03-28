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
                            Name = "Puss Gets the Boot",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/001%20%20%20Puss%20Gets%20the%20Boot%20%5B1940%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/001%20%20%20Puss%20Gets%20the%20Boot%20%5B1940%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 2,
                            Name = "The Midnight Snack",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/002%20%20%20The%20Midnight%20Snack%20%5B1941%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/002%20%20%20The%20Midnight%20Snack%20%5B1941%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 3,
                            Name = "The Night Before Christmas",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/003%20%20%20The%20Night%20Before%20Christmas%20%5B1941%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/003%20%20%20The%20Night%20Before%20Christmas%20%5B1941%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 4,
                            Name = "Fraidy Cat",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/004%20%20%20Fraidy%20Cat%20%5B1942%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/004%20%20%20Fraidy%20Cat%20%5B1942%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 5,
                            Name = "Dog Trouble",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/005%20%20%20Dog%20Trouble%20%5B1942%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/005%20%20%20Dog%20Trouble%20%5B1942%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 6,
                            Name = "Puss n' Toots",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/006%20%20%20Puss%20n%27%20Toots%20%5B1942%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/006%20%20%20Puss%20n%27%20Toots%20%5B1942%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 7,
                            Name = "The Bowling Alley Cat",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/007%20%20%20The%20Bowling%20Alley%20Cat%20%5B1942%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/007%20%20%20The%20Bowling%20Alley%20Cat%20%5B1942%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 8,
                            Name = "Fine Feathered Friend",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/008%20%20%20Fine%20Feathered%20Friend%20%5B1942%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/008%20%20%20Fine%20Feathered%20Friend%20%5B1942%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 9,
                            Name = "Sufferin' Cats!",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/009%20%20%20Sufferin%27%20Cats%21%20%5B1943%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/009%20%20%20Sufferin%27%20Cats%21%20%5B1943%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 10,
                            Name = "The Lonesome Mouse",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/010%20%20%20The%20Lonesome%20Mouse%20%5B1943%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/010%20%20%20The%20Lonesome%20Mouse%20%5B1943%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 11,
                            Name = "The Yankee Doodle Mouse",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/011%20%20%20The%20Yankee%20Doodle%20Mouse%20%5B1943%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/011%20%20%20The%20Yankee%20Doodle%20Mouse%20%5B1943%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 12,
                            Name = "Baby Puss",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/012%20%20%20Baby%20Puss%20%5B1943%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/012%20%20%20Baby%20Puss%20%5B1943%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 13,
                            Name = "The Zoot Cat",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/013%20%20%20The%20Zoot%20Cat%20%5B1944%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/013%20%20%20The%20Zoot%20Cat%20%5B1944%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 14,
                            Name = "The Million Dollar Cat",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/014%20%20%20The%20Million%20Dollar%20Cat%20%5B1944%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/014%20%20%20The%20Million%20Dollar%20Cat%20%5B1944%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 15,
                            Name = "The Bodyguard",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/015%20%20%20The%20Bodyguard%20%5B1944%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/015%20%20%20The%20Bodyguard%20%5B1944%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 16,
                            Name = "Puttin' on the Dog",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/016%20%20%20Puttin%27%20on%20the%20Dog%20%5B1944%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/016%20%20%20Puttin%27%20on%20the%20Dog%20%5B1944%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 17,
                            Name = "Mouse Trouble",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/017%20%20%20Mouse%20Trouble%20%5B1944%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/017%20%20%20Mouse%20Trouble%20%5B1944%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 18,
                            Name = "The Mouse Comes to Dinner",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/018%20%20%20The%20Mouse%20Comes%20to%20Dinner%20%5B1945%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/018%20%20%20The%20Mouse%20Comes%20to%20Dinner%20%5B1945%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 19,
                            Name = "Mouse in Manhattan",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/019%20%20%20Mouse%20in%20Manhattan%20%5B1945%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/019%20%20%20Mouse%20in%20Manhattan%20%5B1945%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 20,
                            Name = "Tee for Two",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/020%20%20%20Tee%20for%20Two%20%5B1945%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/020%20%20%20Tee%20for%20Two%20%5B1945%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 21,
                            Name = "Flirty Birdy",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/021%20%20%20Flirty%20Birdy%20%5B1945%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/021%20%20%20Flirty%20Birdy%20%5B1945%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 22,
                            Name = "Quiet Please!",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/022%20%20%20Quiet%20Please%21%20%5B1945%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/022%20%20%20Quiet%20Please%21%20%5B1945%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 23,
                            Name = "Springtime for Thomas",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/023%20%20%20Springtime%20for%20Thomas%20%5B1946%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/023%20%20%20Springtime%20for%20Thomas%20%5B1946%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 24,
                            Name = "The Milky Waif",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/024%20%20%20The%20Milky%20Waif%20%5B1946%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/024%20%20%20The%20Milky%20Waif%20%5B1946%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 25,
                            Name = "Trap Happy",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/025%20%20%20Trap%20Happy%20%5B1946%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/025%20%20%20Trap%20Happy%20%5B1946%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 26,
                            Name = "Solid Serenade",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/026%20%20%20Solid%20Serenade%20%5B1946%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/026%20%20%20Solid%20Serenade%20%5B1946%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 27,
                            Name = "Cat Fishin'",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/027%20%20%20Cat%20Fishin%27%20%5B1947%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/027%20%20%20Cat%20Fishin%27%20%5B1947%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 28,
                            Name = "Part Time Pal",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/028%20%20%20Part%20Time%20Pal%20%5B1947%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/028%20%20%20Part%20Time%20Pal%20%5B1947%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 29,
                            Name = "The Cat Concerto",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/029%20%20%20The%20Cat%20Concerto%20%5B1947%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/029%20%20%20The%20Cat%20Concerto%20%5B1947%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 30,
                            Name = "Dr. Jekyll and Mr. Mouse",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/030%20%20%20Dr.%20Jekyll%20and%20Mr.%20Mouse%20%5B1947%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/030%20%20%20Dr.%20Jekyll%20and%20Mr.%20Mouse%20%5B1947%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 31,
                            Name = "Salt Water Tabby",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/031%20%20%20Salt%20Water%20Tabby%20%5B1947%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/031%20%20%20Salt%20Water%20Tabby%20%5B1947%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 32,
                            Name = "A Mouse in the House",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/032%20%20%20A%20Mouse%20in%20the%20House%20%5B1947%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/032%20%20%20A%20Mouse%20in%20the%20House%20%5B1947%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 33,
                            Name = "The Invisible Mouse",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/033%20%20%20The%20Invisible%20Mouse%20%5B1947%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/033%20%20%20The%20Invisible%20Mouse%20%5B1947%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 34,
                            Name = "Kitty Foiled",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/034%20%20%20Kitty%20Foiled%20%5B1948%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/034%20%20%20Kitty%20Foiled%20%5B1948%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 35,
                            Name = "The Truce Hurts",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/035%20%20%20The%20Truce%20Hurts%20%5B1948%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/035%20%20%20The%20Truce%20Hurts%20%5B1948%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 36,
                            Name = "Old Rockin' Chair Tom",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/036%20%20%20Old%20Rockin%27%20Chair%20Tom%20%5B1948%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/036%20%20%20Old%20Rockin%27%20Chair%20Tom%20%5B1948%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 37,
                            Name = "Professor Tom",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/037%20%20%20Professor%20Tom%20%5B1948%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/037%20%20%20Professor%20Tom%20%5B1948%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 38,
                            Name = "Mouse Cleaning",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/038%20%20%20Mouse%20Cleaning%20%5B1948%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/038%20%20%20Mouse%20Cleaning%20%5B1948%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 39,
                            Name = "Polka Dot Puss",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/039%20%20%20Polka%20Dot%20Puss%20%5B1949%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/039%20%20%20Polka%20Dot%20Puss%20%5B1949%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 40,
                            Name = "The Little Orphan",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/040%20%20%20The%20Little%20Orphan%20%5B1949%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/040%20%20%20The%20Little%20Orphan%20%5B1949%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 41,
                            Name = "Hatch Up Your Troubles",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/041%20%20%20Hatch%20Up%20Your%20Troubles%20%5B1949%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/041%20%20%20Hatch%20Up%20Your%20Troubles%20%5B1949%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 42,
                            Name = "Heavenly Puss",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/042%20%20%20Heavenly%20Puss%20%5B1949%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/042%20%20%20Heavenly%20Puss%20%5B1949%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 43,
                            Name = "The Cat and the Mermouse",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/043%20%20%20The%20Cat%20and%20the%20Mermouse%20%5B1949%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/043%20%20%20The%20Cat%20and%20the%20Mermouse%20%5B1949%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 44,
                            Name = "Love That Pup",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/044%20%20%20Love%20That%20Pup%20%5B1949%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/044%20%20%20Love%20That%20Pup%20%5B1949%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 45,
                            Name = "Jerry's Diary",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/045%20%20%20Jerry%27s%20Diary%20%5B1949%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/045%20%20%20Jerry%27s%20Diary%20%5B1949%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 46,
                            Name = "Tennis Chumps",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/046%20%20%20Tennis%20Chumps%20%5B1949%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/046%20%20%20Tennis%20Chumps%20%5B1949%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 47,
                            Name = "Little Quacker",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/047%20%20%20Little%20Quacker%20%5B1950%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/047%20%20%20Little%20Quacker%20%5B1950%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 48,
                            Name = "Saturday Evening Puss",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/048%20%20%20Saturday%20Evening%20Puss%20%5B1950%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/048%20%20%20Saturday%20Evening%20Puss%20%5B1950%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 49,
                            Name = "Texas Tom",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/049%20%20%20Texas%20Tom%20%5B1950%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/049%20%20%20Texas%20Tom%20%5B1950%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 50,
                            Name = "Jerry and the Lion",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/050%20%20%20Jerry%20and%20the%20Lion%20%5B1950%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/050%20%20%20Jerry%20and%20the%20Lion%20%5B1950%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 51,
                            Name = "Safety Second",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/051%20%20%20Safety%20Second%20%5B1950%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/051%20%20%20Safety%20Second%20%5B1950%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 52,
                            Name = "The Hollywood Bowl",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/052%20%20%20The%20Hollywood%20Bowl%20%5B1950%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/052%20%20%20The%20Hollywood%20Bowl%20%5B1950%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 53,
                            Name = "The Framed Cat",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/053%20%20%20The%20Framed%20Cat%20%5B1950%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/053%20%20%20The%20Framed%20Cat%20%5B1950%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 54,
                            Name = "Cue Ball Cat",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/054%20%20%20Cue%20Ball%20Cat%20%5B1950%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/054%20%20%20Cue%20Ball%20Cat%20%5B1950%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 55,
                            Name = "Casanova Cat",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/055%20%20%20Casanova%20Cat%20%5B1951%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/055%20%20%20Casanova%20Cat%20%5B1951%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 56,
                            Name = "Jerry and the Goldfish",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/056%20%20%20Jerry%20and%20the%20Goldfish%20%5B1951%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/056%20%20%20Jerry%20and%20the%20Goldfish%20%5B1951%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 57,
                            Name = "Jerry's Cousin",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/057%20%20%20Jerry%27s%20Cousin%20%5B1951%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/057%20%20%20Jerry%27s%20Cousin%20%5B1951%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 58,
                            Name = "Sleepy Time Tom",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/058%20%20%20Sleepy%20Time%20Tom%20%5B1951%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/058%20%20%20Sleepy%20Time%20Tom%20%5B1951%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 59,
                            Name = "His Mouse Friday",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/059%20%20%20His%20Mouse%20Friday%20%5B1951%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/059%20%20%20His%20Mouse%20Friday%20%5B1951%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 60,
                            Name = "Slicked up Pup",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/060%20%20%20Slicked%20up%20Pup%20%5B1951%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/060%20%20%20Slicked%20up%20Pup%20%5B1951%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 61,
                            Name = "Nit Witty Kitty",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/061%20%20%20Nit%20Witty%20Kitty%20%5B1951%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/061%20%20%20Nit%20Witty%20Kitty%20%5B1951%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 62,
                            Name = "Cat Napping",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/062%20%20%20Cat%20Napping%20%5B1951%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/062%20%20%20Cat%20Napping%20%5B1951%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 63,
                            Name = "The Flying Cat",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/063%20%20%20The%20Flying%20Cat%20%5B1952%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/063%20%20%20The%20Flying%20Cat%20%5B1952%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 64,
                            Name = "The Duck Doctor",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/064%20%20%20The%20Duck%20Doctor%20%5B1952%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/064%20%20%20The%20Duck%20Doctor%20%5B1952%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 65,
                            Name = "The Two Mouseketeers",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/065%20%20%20The%20Two%20Mouseketeers%20%5B1952%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/065%20%20%20The%20Two%20Mouseketeers%20%5B1952%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 66,
                            Name = "Smitten Kitten",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/066%20%20%20Smitten%20Kitten%20%5B1952%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/066%20%20%20Smitten%20Kitten%20%5B1952%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 67,
                            Name = "Triplet Trouble",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/067%20%20%20Triplet%20Trouble%20%5B1952%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/067%20%20%20Triplet%20Trouble%20%5B1952%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 68,
                            Name = "Little Runaway",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/068%20%20%20Little%20Runaway%20%5B1952%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/068%20%20%20Little%20Runaway%20%5B1952%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 69,
                            Name = "Fit to be Tied",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/069%20%20%20Fit%20to%20be%20Tied%20%5B1952%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/069%20%20%20Fit%20to%20be%20Tied%20%5B1952%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 70,
                            Name = "Push Button Kitty",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/070%20%20%20Push%20Button%20Kitty%20%5B1952%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/070%20%20%20Push%20Button%20Kitty%20%5B1952%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 71,
                            Name = "Cruise Cat",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/071%20%20%20Cruise%20Cat%20%5B1952%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/071%20%20%20Cruise%20Cat%20%5B1952%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 72,
                            Name = "The Dog House",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/072%20%20%20The%20Dog%20House%20%5B1952%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/072%20%20%20The%20Dog%20House%20%5B1952%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 73,
                            Name = "The Missing Mouse",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/073%20%20%20The%20Missing%20Mouse%20%5B1953%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/073%20%20%20The%20Missing%20Mouse%20%5B1953%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 74,
                            Name = "Jerry and Jumbo",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/074%20%20%20Jerry%20and%20Jumbo%20%5B1953%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/074%20%20%20Jerry%20and%20Jumbo%20%5B1953%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 75,
                            Name = "Johann Mouse",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/075%20%20%20Johann%20Mouse%20%5B1953%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/075%20%20%20Johann%20Mouse%20%5B1953%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 76,
                            Name = "That's My Pup!",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/076%20%20%20That%27s%20My%20Pup%21%20%5B1953%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/076%20%20%20That%27s%20My%20Pup%21%20%5B1953%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 77,
                            Name = "Just Ducky",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/077%20%20%20Just%20Ducky%20%5B1953%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/077%20%20%20Just%20Ducky%20%5B1953%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 78,
                            Name = "Two Little Indians",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/078%20%20%20Two%20Little%20Indians%20%5B1953%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/078%20%20%20Two%20Little%20Indians%20%5B1953%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 79,
                            Name = "Life with Tom",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/079%20%20%20Life%20with%20Tom%20%5B1953%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/079%20%20%20Life%20with%20Tom%20%5B1953%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 80,
                            Name = "Puppy Tale",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/080%20%20%20Puppy%20Tale%20%5B1954%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/080%20%20%20Puppy%20Tale%20%5B1954%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 81,
                            Name = "Posse Cat",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/081%20%20%20Posse%20Cat%20%5B1954%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/081%20%20%20Posse%20Cat%20%5B1954%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 82,
                            Name = "Hic cup Pup",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/082%20%20%20Hic%20cup%20Pup%20%5B1954%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/082%20%20%20Hic%20cup%20Pup%20%5B1954%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 83,
                            Name = "Little School Mouse",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/083%20%20%20Little%20School%20Mouse%20%5B1954%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/083%20%20%20Little%20School%20Mouse%20%5B1954%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 84,
                            Name = "Baby Butch",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/084%20%20%20Baby%20Butch%20%5B1954%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/084%20%20%20Baby%20Butch%20%5B1954%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 85,
                            Name = "Mice Follies",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/085%20%20%20Mice%20Follies%20%5B1954%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/085%20%20%20Mice%20Follies%20%5B1954%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 86,
                            Name = "Neapolitan Mouse",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/086%20%20%20Neapolitan%20Mouse%20%5B1954%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/086%20%20%20Neapolitan%20Mouse%20%5B1954%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 87,
                            Name = "Downhearted Duckling",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/087%20%20%20Downhearted%20Duckling%20%5B1954%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/087%20%20%20Downhearted%20Duckling%20%5B1954%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 88,
                            Name = "Pet Peeve",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/088%20%20%20Pet%20Peeve%20%5B1954%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/088%20%20%20Pet%20Peeve%20%5B1954%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 89,
                            Name = "Touché, Pussy Cat!",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/089%20%20%20Touch%C3%A9%2C%20Pussy%20Cat%21%20%5B1954%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/089%20%20%20Touch%C3%A9%2C%20Pussy%20Cat%21%20%5B1954%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 90,
                            Name = "Southbound Duckling",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/090%20%20%20Southbound%20Duckling%20%5B1955%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/090%20%20%20Southbound%20Duckling%20%5B1955%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 91,
                            Name = "Pup on a Picnic",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/091%20%20%20Pup%20on%20a%20Picnic%20%5B1955%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/091%20%20%20Pup%20on%20a%20Picnic%20%5B1955%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 92,
                            Name = "Mouse for Sale",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/092%20%20%20Mouse%20for%20Sale%20%5B1955%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/092%20%20%20Mouse%20for%20Sale%20%5B1955%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 93,
                            Name = "Designs on Jerry",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/093%20%20%20Designs%20on%20Jerry%20%5B1955%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/093%20%20%20Designs%20on%20Jerry%20%5B1955%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 94,
                            Name = "Tom and Chérie",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/094%20%20%20Tom%20and%20Ch%C3%A9rie%20%5B1955%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/094%20%20%20Tom%20and%20Ch%C3%A9rie%20%5B1955%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 95,
                            Name = "Smarty Cat",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/095%20%20%20Smarty%20Cat%20%5B1955%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/095%20%20%20Smarty%20Cat%20%5B1955%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 96,
                            Name = "Pecos Pest",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/096%20%20%20Pecos%20Pest%20%5B1955%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/096%20%20%20Pecos%20Pest%20%5B1955%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 97,
                            Name = "That's My Mommy",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/097%20%20%20That%27s%20My%20Mommy%20%5B1955%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/097%20%20%20That%27s%20My%20Mommy%20%5B1955%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 98,
                            Name = "The Flying Sorceress",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/098%20%20%20The%20Flying%20Sorceress%20%5B1956%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/098%20%20%20The%20Flying%20Sorceress%20%5B1956%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 99,
                            Name = "The Egg and Jerry",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/099%20%20%20The%20Egg%20and%20Jerry%20%5B1956%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/099%20%20%20The%20Egg%20and%20Jerry%20%5B1956%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 100,
                            Name = "Busy Buddies",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/100%20%20%20Busy%20Buddies%20%5B1956%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/100%20%20%20Busy%20Buddies%20%5B1956%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 101,
                            Name = "Muscle Beach Tom",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/101%20%20%20Muscle%20Beach%20Tom%20%5B1956%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/101%20%20%20Muscle%20Beach%20Tom%20%5B1956%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 102,
                            Name = "Down Beat Bear",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/102%20%20%20Down%20Beat%20Bear%20%5B1956%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/102%20%20%20Down%20Beat%20Bear%20%5B1956%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 103,
                            Name = "Blue Cat Blues",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/103%20%20%20Blue%20Cat%20Blues%20%5B1956%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/103%20%20%20Blue%20Cat%20Blues%20%5B1956%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 104,
                            Name = "Barbecue Brawl",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/104%20%20%20Barbecue%20Brawl%20%5B1956%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/104%20%20%20Barbecue%20Brawl%20%5B1956%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 105,
                            Name = "Tops with Pops",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/105%20%20%20Tops%20with%20Pops%20%5B1957%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/105%20%20%20Tops%20with%20Pops%20%5B1957%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 106,
                            Name = "Timid Tabby",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/106%20%20%20Timid%20Tabby%20%5B1957%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/106%20%20%20Timid%20Tabby%20%5B1957%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 107,
                            Name = "Feedin' the Kiddie",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/107%20%20%20Feedin%27%20the%20Kiddie%20%5B1957%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/107%20%20%20Feedin%27%20the%20Kiddie%20%5B1957%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 108,
                            Name = "Mucho Mouse",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/108%20%20%20Mucho%20Mouse%20%5B1957%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/108%20%20%20Mucho%20Mouse%20%5B1957%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 109,
                            Name = "Tom's Photo Finish",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/109%20%20%20Tom%27s%20Photo%20Finish%20%5B1957%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/109%20%20%20Tom%27s%20Photo%20Finish%20%5B1957%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 110,
                            Name = "Happy Go Ducky",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/110%20%20%20Happy%20Go%20Ducky%20%5B1958%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/110%20%20%20Happy%20Go%20Ducky%20%5B1958%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 111,
                            Name = "Royal Cat Nap",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/111%20%20%20Royal%20Cat%20Nap%20%5B1958%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/111%20%20%20Royal%20Cat%20Nap%20%5B1958%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 112,
                            Name = "The Vanishing Duck",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/112%20%20%20The%20Vanishing%20Duck%20%5B1958%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/112%20%20%20The%20Vanishing%20Duck%20%5B1958%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 113,
                            Name = "Robin Hoodwinked",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/113%20%20%20Robin%20Hoodwinked%20%5B1958%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/113%20%20%20Robin%20Hoodwinked%20%5B1958%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 114,
                            Name = "Tot Watchers",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/114%20%20%20Tot%20Watchers%20%5B1958%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/114%20%20%20Tot%20Watchers%20%5B1958%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 115,
                            Name = "Switchin' Kitten",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/115%20%20%20Switchin%27%20Kitten%20%5B1961%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/115%20%20%20Switchin%27%20Kitten%20%5B1961%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 116,
                            Name = "Down and Outing",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/116%20%20%20Down%20and%20Outing%20%5B1961%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/116%20%20%20Down%20and%20Outing%20%5B1961%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 117,
                            Name = "It's Greek to Me ow",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/117%20%20%20It%27s%20Greek%20to%20Me%20ow%20%5B1961%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/117%20%20%20It%27s%20Greek%20to%20Me%20ow%20%5B1961%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 118,
                            Name = "High Steaks",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/118%20%20%20High%20Steaks%20%5B1962%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/118%20%20%20High%20Steaks%20%5B1962%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 119,
                            Name = "Mouse Into Space",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/119%20%20%20Mouse%20Into%20Space%20%5B1962%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/119%20%20%20Mouse%20Into%20Space%20%5B1962%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 120,
                            Name = "Landing Stripling",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/120%20%20%20Landing%20Stripling%20%5B1962%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/120%20%20%20Landing%20Stripling%20%5B1962%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 121,
                            Name = "Calypso Cat",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/121%20%20%20Calypso%20Cat%20%5B1962%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/121%20%20%20Calypso%20Cat%20%5B1962%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 122,
                            Name = "Dicky Moe",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/122%20%20%20Dicky%20Moe%20%5B1962%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/122%20%20%20Dicky%20Moe%20%5B1962%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 123,
                            Name = "The Tom and Jerry Cartoon Kit",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/123%20%20%20The%20Tom%20and%20Jerry%20Cartoon%20Kit%20%5B1962%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/123%20%20%20The%20Tom%20and%20Jerry%20Cartoon%20Kit%20%5B1962%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 124,
                            Name = "Tall in the Trap",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/124%20%20%20Tall%20in%20the%20Trap%20%5B1962%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/124%20%20%20Tall%20in%20the%20Trap%20%5B1962%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 125,
                            Name = "Sorry Safari",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/125%20%20%20Sorry%20Safari%20%5B1962%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/125%20%20%20Sorry%20Safari%20%5B1962%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 126,
                            Name = "Buddies Thicker Than Water",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/126%20%20%20Buddies%20Thicker%20Than%20Water%20%5B1962%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/126%20%20%20Buddies%20Thicker%20Than%20Water%20%5B1962%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 127,
                            Name = "Carmen Get It!",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/127%20%20%20Carmen%20Get%20It%21%20%5B1962%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/127%20%20%20Carmen%20Get%20It%21%20%5B1962%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 128,
                            Name = "Pent House Mouse",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/128%20%20%20Pent%20House%20Mouse%20%5B1963%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/128%20%20%20Pent%20House%20Mouse%20%5B1963%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 129,
                            Name = "The Cat Above and the Mouse Below",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/129%20%20%20The%20Cat%20Above%20and%20the%20Mouse%20Below%20%5B1964%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/129%20%20%20The%20Cat%20Above%20and%20the%20Mouse%20Below%20%5B1964%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 130,
                            Name = "Is There a Doctor in the Mouse",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/130%20%20%20Is%20There%20a%20Doctor%20in%20the%20Mouse%20%5B1964%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/130%20%20%20Is%20There%20a%20Doctor%20in%20the%20Mouse%20%5B1964%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 131,
                            Name = "Much Ado About Mousing",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/131%20%20%20Much%20Ado%20About%20Mousing%20%5B1964%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/131%20%20%20Much%20Ado%20About%20Mousing%20%5B1964%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 132,
                            Name = "Snowbody Loves Me",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/132%20%20%20Snowbody%20Loves%20Me%20%5B1964%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/132%20%20%20Snowbody%20Loves%20Me%20%5B1964%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 133,
                            Name = "The Unshrinkable Jerry Mouse",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/133%20%20%20The%20Unshrinkable%20Jerry%20Mouse%20%5B1964%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/133%20%20%20The%20Unshrinkable%20Jerry%20Mouse%20%5B1964%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 134,
                            Name = "Ah, Sweet Mouse Story of Life",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/134%20%20%20Ah%2C%20Sweet%20Mouse%20Story%20of%20Life%20%5B1965%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/134%20%20%20Ah%2C%20Sweet%20Mouse%20Story%20of%20Life%20%5B1965%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 135,
                            Name = "Tom ic Energy",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/135%20%20%20Tom%20ic%20Energy%20%5B1965%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/135%20%20%20Tom%20ic%20Energy%20%5B1965%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 136,
                            Name = "Bad Day at Cat Rock",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/136%20%20%20Bad%20Day%20at%20Cat%20Rock%20%5B1965%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/136%20%20%20Bad%20Day%20at%20Cat%20Rock%20%5B1965%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 137,
                            Name = "The Brothers Carry Mouse Off",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/137%20%20%20The%20Brothers%20Carry%20Mouse%20Off%20%5B1965%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/137%20%20%20The%20Brothers%20Carry%20Mouse%20Off%20%5B1965%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 138,
                            Name = "Haunted Mouse",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/138%20%20%20Haunted%20Mouse%20%5B1965%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/138%20%20%20Haunted%20Mouse%20%5B1965%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 139,
                            Name = "I'm Just Wild About Jerry",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/139%20%20%20I%27m%20Just%20Wild%20About%20Jerry%20%5B1965%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/139%20%20%20I%27m%20Just%20Wild%20About%20Jerry%20%5B1965%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 140,
                            Name = "Of Feline Bondage",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/140%20%20%20Of%20Feline%20Bondage%20%5B1965%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/140%20%20%20Of%20Feline%20Bondage%20%5B1965%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 141,
                            Name = "The Year of the Mouse",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/141%20%20%20The%20Year%20of%20the%20Mouse%20%5B1965%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/141%20%20%20The%20Year%20of%20the%20Mouse%20%5B1965%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 142,
                            Name = "The Cat's Me Ouch",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/142%20%20%20The%20Cat%27s%20Me%20Ouch%20%5B1965%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/142%20%20%20The%20Cat%27s%20Me%20Ouch%20%5B1965%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 143,
                            Name = "Duel Personality",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/143%20%20%20Duel%20Personality%20%5B1966%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/143%20%20%20Duel%20Personality%20%5B1966%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 144,
                            Name = "Jerry, Jerry, Quite Contrary",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/144%20%20%20Jerry%2C%20Jerry%2C%20Quite%20Contrary%20%5B1966%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/144%20%20%20Jerry%2C%20Jerry%2C%20Quite%20Contrary%20%5B1966%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 145,
                            Name = "Jerry Go Round",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/145%20%20%20Jerry%20Go%20Round%20%5B1966%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/145%20%20%20Jerry%20Go%20Round%20%5B1966%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 146,
                            Name = "Love Me, Love My Mouse",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/146%20%20%20Love%20Me%2C%20Love%20My%20Mouse%20%5B1966%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/146%20%20%20Love%20Me%2C%20Love%20My%20Mouse%20%5B1966%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 147,
                            Name = "Puss 'n' Boats",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/147%20%20%20Puss%20%27n%27%20Boats%20%5B1966%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/147%20%20%20Puss%20%27n%27%20Boats%20%5B1966%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 148,
                            Name = "Filet Meow",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/148%20%20%20Filet%20Meow%20%5B1966%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/148%20%20%20Filet%20Meow%20%5B1966%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 149,
                            Name = "Matinee Mouse",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/149%20%20%20Matinee%20Mouse%20%5B1966%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/149%20%20%20Matinee%20Mouse%20%5B1966%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 150,
                            Name = "The A Tom Inable Snowman",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/150%20%20%20The%20A%20Tom%20Inable%20Snowman%20%5B1966%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/150%20%20%20The%20A%20Tom%20Inable%20Snowman%20%5B1966%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 151,
                            Name = "Catty Cornered",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/151%20%20%20Catty%20Cornered%20%5B1966%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/151%20%20%20Catty%20Cornered%20%5B1966%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 152,
                            Name = "Cat and Dupli cat",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/152%20%20%20Cat%20and%20Dupli%20cat%20%5B1966%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/152%20%20%20Cat%20and%20Dupli%20cat%20%5B1966%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 153,
                            Name = "O Solar Meow",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/153%20%20%20O%20Solar%20Meow%20%5B1966%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/153%20%20%20O%20Solar%20Meow%20%5B1966%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 154,
                            Name = "Guided Mouse ille",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/154%20%20%20Guided%20Mouse%20ille%20%5B1966%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/154%20%20%20Guided%20Mouse%20ille%20%5B1966%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 155,
                            Name = "Rock 'n' Rodent",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/155%20%20%20Rock%20%27n%27%20Rodent%20%5B1967%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/155%20%20%20Rock%20%27n%27%20Rodent%20%5B1967%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 156,
                            Name = "Cannery Rodent",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/156%20%20%20Cannery%20Rodent%20%5B1967%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/156%20%20%20Cannery%20Rodent%20%5B1967%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 157,
                            Name = "The Mouse from H.U.N.G.E.R.",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/157%20%20%20The%20Mouse%20from%20H.U.N.G.E.R.%20%5B1967%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/157%20%20%20The%20Mouse%20from%20H.U.N.G.E.R.%20%5B1967%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 158,
                            Name = "Surf Bored Cat",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/158%20%20%20Surf%20Bored%20Cat%20%5B1967%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/158%20%20%20Surf%20Bored%20Cat%20%5B1967%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 159,
                            Name = "Shutter Bugged Cat",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/159%20%20%20Shutter%20Bugged%20Cat%20%5B1967%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/159%20%20%20Shutter%20Bugged%20Cat%20%5B1967%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 160,
                            Name = "Advance and Be Mechanized",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/160%20%20%20Advance%20and%20Be%20Mechanized%20%5B1967%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/160%20%20%20Advance%20and%20Be%20Mechanized%20%5B1967%5D.mp4"
                        },
                        new Film()
                        {
                            FilmId = 161,
                            Name = "Purr Chance to Dream",
                            GenreId = 1,
                            RunTime = 100,
                            ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/161%20%20%20Purr%20Chance%20to%20Dream%20%5B1967%5D_000001.jpg",
                            FilmAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/161%20%20%20Purr%20Chance%20to%20Dream%20%5B1967%5D.mp4"
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
