﻿// <auto-generated />
using System;
using DAO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace NotFake.Migrations
{
    [DbContext(typeof(NotFakeContext))]
    [Migration("20200426171215_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DAO.Models.Film", b =>
                {
                    b.Property<int>("FilmId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GenreId");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("ThumbnailAddress")
                        .IsRequired();

                    b.Property<int>("Type");

                    b.HasKey("FilmId");

                    b.HasIndex("GenreId");

                    b.ToTable("Film");

                    b.HasData(
                        new { FilmId = 1, GenreId = 1, Name = "Tom and Jerry", ThumbnailAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/__ia_thumb.jpg", Type = 1 },
                        new { FilmId = 2, GenreId = 1, Name = "Tom and Jerry 2", ThumbnailAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/__ia_thumb.jpg", Type = 1 },
                        new { FilmId = 3, GenreId = 1, Name = "The Land Before Rhyme", ThumbnailAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/__ia_thumb.jpg", Type = 1 },
                        new { FilmId = 4, GenreId = 1, Name = "Excalibur!", ThumbnailAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/__ia_thumb.jpg", Type = 1 },
                        new { FilmId = 5, GenreId = 1, Name = "Meet the Dogs", ThumbnailAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/__ia_thumb.jpg", Type = 1 },
                        new { FilmId = 6, GenreId = 1, Name = "Home Away From Home", ThumbnailAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/__ia_thumb.jpg", Type = 1 },
                        new { FilmId = 7, GenreId = 2, Name = "Action Film Example 1", ThumbnailAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/__ia_thumb.jpg", Type = 1 },
                        new { FilmId = 8, GenreId = 2, Name = "Hard Gun", ThumbnailAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/__ia_thumb.jpg", Type = 1 },
                        new { FilmId = 9, GenreId = 2, Name = "Hard Gun II : Reloaded", ThumbnailAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/__ia_thumb.jpg", Type = 1 },
                        new { FilmId = 10, GenreId = 2, Name = "A Knock at the Door", ThumbnailAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/__ia_thumb.jpg", Type = 1 }
                    );
                });

            modelBuilder.Entity("DAO.Models.FilmData", b =>
                {
                    b.Property<int>("Id");

                    b.Property<int>("FilmId");

                    b.Property<string>("Address")
                        .IsRequired();

                    b.Property<string>("Name");

                    b.Property<int>("RunTime");

                    b.Property<string>("ThumbnailAddress")
                        .IsRequired();

                    b.HasKey("Id", "FilmId");

                    b.HasIndex("FilmId");

                    b.ToTable("FilmData");

                    b.HasData(
                        new { Id = 1, FilmId = 1, Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/001%20%20%20Puss%20Gets%20the%20Boot%20%5B1940%5D.mp4", Name = "Puss Gets the Boot", RunTime = 100, ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/001%20%20%20Puss%20Gets%20the%20Boot%20%5B1940%5D_000001.jpg" },
                        new { Id = 2, FilmId = 1, Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/002%20%20%20The%20Midnight%20Snack%20%5B1941%5D.mp4", Name = "The Midnight Snack", RunTime = 100, ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/002%20%20%20The%20Midnight%20Snack%20%5B1941%5D_000001.jpg" },
                        new { Id = 3, FilmId = 1, Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/003%20%20%20The%20Night%20Before%20Christmas%20%5B1941%5D.mp4", Name = "The Night Before Christmas", RunTime = 100, ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/003%20%20%20The%20Night%20Before%20Christmas%20%5B1941%5D_000001.jpg" },
                        new { Id = 4, FilmId = 1, Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/004%20%20%20Fraidy%20Cat%20%5B1942%5D.mp4", Name = "Fraidy Cat", RunTime = 100, ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/004%20%20%20Fraidy%20Cat%20%5B1942%5D_000001.jpg" },
                        new { Id = 5, FilmId = 1, Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/005%20%20%20Dog%20Trouble%20%5B1942%5D.mp4", Name = "Dog Trouble", RunTime = 100, ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/005%20%20%20Dog%20Trouble%20%5B1942%5D_000001.jpg" },
                        new { Id = 6, FilmId = 1, Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/006%20%20%20Puss%20n%27%20Toots%20%5B1942%5D.mp4", Name = "Puss n' Toots", RunTime = 100, ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/006%20%20%20Puss%20n%27%20Toots%20%5B1942%5D_000001.jpg" },
                        new { Id = 7, FilmId = 1, Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/007%20%20%20The%20Bowling%20Alley%20Cat%20%5B1942%5D.mp4", Name = "The Bowling Alley Cat", RunTime = 100, ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/007%20%20%20The%20Bowling%20Alley%20Cat%20%5B1942%5D_000001.jpg" },
                        new { Id = 8, FilmId = 1, Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/008%20%20%20Fine%20Feathered%20Friend%20%5B1942%5D.mp4", Name = "Fine Feathered Friend", RunTime = 100, ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/008%20%20%20Fine%20Feathered%20Friend%20%5B1942%5D_000001.jpg" },
                        new { Id = 9, FilmId = 2, Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/008%20%20%20Fine%20Feathered%20Friend%20%5B1942%5D.mp4", Name = "Fine Feathered Friend", RunTime = 100, ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/008%20%20%20Fine%20Feathered%20Friend%20%5B1942%5D_000001.jpg" },
                        new { Id = 10, FilmId = 2, Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/008%20%20%20Fine%20Feathered%20Friend%20%5B1942%5D.mp4", Name = "Fine Feathered Friend", RunTime = 100, ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/008%20%20%20Fine%20Feathered%20Friend%20%5B1942%5D_000001.jpg" },
                        new { Id = 11, FilmId = 3, Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/008%20%20%20Fine%20Feathered%20Friend%20%5B1942%5D.mp4", Name = "Fine Feathered Friend", RunTime = 100, ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/008%20%20%20Fine%20Feathered%20Friend%20%5B1942%5D_000001.jpg" },
                        new { Id = 12, FilmId = 3, Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/008%20%20%20Fine%20Feathered%20Friend%20%5B1942%5D.mp4", Name = "Fine Feathered Friend", RunTime = 100, ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/008%20%20%20Fine%20Feathered%20Friend%20%5B1942%5D_000001.jpg" },
                        new { Id = 13, FilmId = 4, Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/008%20%20%20Fine%20Feathered%20Friend%20%5B1942%5D.mp4", Name = "Fine Feathered Friend", RunTime = 100, ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/008%20%20%20Fine%20Feathered%20Friend%20%5B1942%5D_000001.jpg" },
                        new { Id = 14, FilmId = 4, Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/008%20%20%20Fine%20Feathered%20Friend%20%5B1942%5D.mp4", Name = "Fine Feathered Friend", RunTime = 100, ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/008%20%20%20Fine%20Feathered%20Friend%20%5B1942%5D_000001.jpg" },
                        new { Id = 15, FilmId = 5, Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/008%20%20%20Fine%20Feathered%20Friend%20%5B1942%5D.mp4", Name = "Fine Feathered Friend", RunTime = 100, ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/008%20%20%20Fine%20Feathered%20Friend%20%5B1942%5D_000001.jpg" },
                        new { Id = 16, FilmId = 5, Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/008%20%20%20Fine%20Feathered%20Friend%20%5B1942%5D.mp4", Name = "Fine Feathered Friend", RunTime = 100, ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/008%20%20%20Fine%20Feathered%20Friend%20%5B1942%5D_000001.jpg" },
                        new { Id = 17, FilmId = 6, Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/008%20%20%20Fine%20Feathered%20Friend%20%5B1942%5D.mp4", Name = "Fine Feathered Friend", RunTime = 100, ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/008%20%20%20Fine%20Feathered%20Friend%20%5B1942%5D_000001.jpg" },
                        new { Id = 18, FilmId = 6, Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/008%20%20%20Fine%20Feathered%20Friend%20%5B1942%5D.mp4", Name = "Fine Feathered Friend", RunTime = 100, ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/008%20%20%20Fine%20Feathered%20Friend%20%5B1942%5D_000001.jpg" },
                        new { Id = 19, FilmId = 7, Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/008%20%20%20Fine%20Feathered%20Friend%20%5B1942%5D.mp4", Name = "Fine Feathered Friend", RunTime = 100, ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/008%20%20%20Fine%20Feathered%20Friend%20%5B1942%5D_000001.jpg" },
                        new { Id = 20, FilmId = 7, Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/008%20%20%20Fine%20Feathered%20Friend%20%5B1942%5D.mp4", Name = "Fine Feathered Friend", RunTime = 100, ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/008%20%20%20Fine%20Feathered%20Friend%20%5B1942%5D_000001.jpg" },
                        new { Id = 21, FilmId = 8, Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/008%20%20%20Fine%20Feathered%20Friend%20%5B1942%5D.mp4", Name = "Fine Feathered Friend", RunTime = 100, ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/008%20%20%20Fine%20Feathered%20Friend%20%5B1942%5D_000001.jpg" },
                        new { Id = 22, FilmId = 8, Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/008%20%20%20Fine%20Feathered%20Friend%20%5B1942%5D.mp4", Name = "Fine Feathered Friend", RunTime = 100, ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/008%20%20%20Fine%20Feathered%20Friend%20%5B1942%5D_000001.jpg" },
                        new { Id = 23, FilmId = 9, Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/008%20%20%20Fine%20Feathered%20Friend%20%5B1942%5D.mp4", Name = "Fine Feathered Friend", RunTime = 100, ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/008%20%20%20Fine%20Feathered%20Friend%20%5B1942%5D_000001.jpg" },
                        new { Id = 24, FilmId = 9, Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/008%20%20%20Fine%20Feathered%20Friend%20%5B1942%5D.mp4", Name = "Fine Feathered Friend", RunTime = 100, ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/008%20%20%20Fine%20Feathered%20Friend%20%5B1942%5D_000001.jpg" },
                        new { Id = 25, FilmId = 10, Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/008%20%20%20Fine%20Feathered%20Friend%20%5B1942%5D.mp4", Name = "Fine Feathered Friend", RunTime = 100, ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/008%20%20%20Fine%20Feathered%20Friend%20%5B1942%5D_000001.jpg" },
                        new { Id = 26, FilmId = 10, Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/008%20%20%20Fine%20Feathered%20Friend%20%5B1942%5D.mp4", Name = "Fine Feathered Friend", RunTime = 100, ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/008%20%20%20Fine%20Feathered%20Friend%20%5B1942%5D_000001.jpg" }
                    );
                });

            modelBuilder.Entity("DAO.Models.Friendship", b =>
                {
                    b.Property<int>("InvitedUserId");

                    b.Property<int>("InvitingUserId");

                    b.Property<int>("Status");

                    b.HasKey("InvitedUserId", "InvitingUserId");

                    b.HasIndex("InvitingUserId");

                    b.ToTable("Friendships");
                });

            modelBuilder.Entity("DAO.Models.Genre", b =>
                {
                    b.Property<int>("GenreId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("GenreId");

                    b.ToTable("Genre");

                    b.HasData(
                        new { GenreId = 1, Name = "Cartoons" },
                        new { GenreId = 2, Name = "Action" }
                    );
                });

            modelBuilder.Entity("DAO.Models.Group", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created");

                    b.Property<int?>("CreatorId");

                    b.Property<int?>("FilmId");

                    b.HasKey("Id");

                    b.HasIndex("CreatorId");

                    b.HasIndex("FilmId");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("DAO.Models.GroupMembers", b =>
                {
                    b.Property<int>("GroupId");

                    b.Property<int>("MemberId");

                    b.HasKey("GroupId", "MemberId");

                    b.HasIndex("MemberId");

                    b.ToTable("GroupMembers");
                });

            modelBuilder.Entity("DAO.Models.Post", b =>
                {
                    b.Property<int>("PostID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content");

                    b.Property<DateTime>("Created");

                    b.Property<int?>("CreatorId");

                    b.Property<int?>("GroupId");

                    b.HasKey("PostID");

                    b.HasIndex("CreatorId");

                    b.HasIndex("GroupId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("DAO.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Fullname")
                        .IsRequired();

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<int>("Role");

                    b.HasKey("UserId");

                    b.ToTable("User");

                    b.HasData(
                        new { UserId = 1, Email = "admin@demo.com", Fullname = "admin", Password = "AAk1S0t46sDydaTCD8PHXmiGdRejB63z59WeQscaMekQs9EwYnGemCqTv1Seg+AvuA==", Role = 1 },
                        new { UserId = 2, Email = "user2@demo.com", Fullname = "user full name 2", Password = "AFBzcZPxWCbbX9/qZ1awo++ibWyZUxXQZ9rVIiTgvBcC2nio2clWa66hO2IfXbtORg==", Role = 0 },
                        new { UserId = 3, Email = "user3@demo.com", Fullname = "user full name 3", Password = "ABtpOkfDMfagWyNh1PsZ4uHCX9wHErBbIZ0VS+NCQxdTtiBSeWRcqX69ritLEHzq8g==", Role = 0 },
                        new { UserId = 4, Email = "user4@demo.com", Fullname = "user full name 4", Password = "AEluIfBdEGXNvPsCFpLlv4dk/xyaMf96Z+1yQ7KidVaI5jcAehqUgGetQMmQjEC7CA==", Role = 0 },
                        new { UserId = 5, Email = "user5@demo.com", Fullname = "user full name 5", Password = "AL9y0233tMlqCXwzkGdgcIPA6ZFPHb8TtOfnRuII9C6UaiYxycolJ67LlXboIs2wMw==", Role = 0 },
                        new { UserId = 6, Email = "user6@demo.com", Fullname = "user full name 6", Password = "APk4qDQ0FJG+zn5Vh6mYjocIvOh3o1VG/V8QQi+m6II1a+ybg2dV9mTT0L98iG5hsQ==", Role = 0 },
                        new { UserId = 7, Email = "user7@demo.com", Fullname = "user full name 7", Password = "AKYlKvRGml/42K9t/b7cjSz+e+fr5VLPaSuEfOrZmZ+D+oa88U0koPgCaoN0Y4ZcSw==", Role = 0 },
                        new { UserId = 8, Email = "user8@demo.com", Fullname = "user full name 8", Password = "AMzDXinHTNI8CBHrOWhklClFBt5VqwbKTW6z+fb6V6R1DHS4HDvipeSiCabQJ8BcxQ==", Role = 0 },
                        new { UserId = 9, Email = "user9@demo.com", Fullname = "user full name 9", Password = "ANg7xKTebWQC0m71uoKBDlQ47hmdWyxbCw1gF8wugclwOv3o102GXpsqU3PG8Zic4A==", Role = 0 }
                    );
                });

            modelBuilder.Entity("DAO.Models.UserFilm", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<int>("FilmId");

                    b.Property<int?>("SecondsWatched");

                    b.HasKey("UserId", "FilmId");

                    b.HasIndex("FilmId");

                    b.ToTable("UserFilm");
                });

            modelBuilder.Entity("DAO.Models.UserFilmInvite", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GroupId");

                    b.Property<int>("InvitedUserId");

                    b.Property<int>("isAccepted");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.HasIndex("InvitedUserId");

                    b.ToTable("UserFilmInvites");
                });

            modelBuilder.Entity("DAO.Models.Film", b =>
                {
                    b.HasOne("DAO.Models.Genre", "Genre")
                        .WithMany("Films")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DAO.Models.FilmData", b =>
                {
                    b.HasOne("DAO.Models.Film", "Film")
                        .WithMany("FilmData")
                        .HasForeignKey("FilmId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DAO.Models.Friendship", b =>
                {
                    b.HasOne("DAO.Models.User", "InvitedUser")
                        .WithMany()
                        .HasForeignKey("InvitedUserId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("DAO.Models.User", "InvitingUser")
                        .WithMany()
                        .HasForeignKey("InvitingUserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("DAO.Models.Group", b =>
                {
                    b.HasOne("DAO.Models.User", "Creator")
                        .WithMany()
                        .HasForeignKey("CreatorId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("DAO.Models.Film", "Film")
                        .WithMany()
                        .HasForeignKey("FilmId")
                        .OnDelete(DeleteBehavior.SetNull);
                });

            modelBuilder.Entity("DAO.Models.GroupMembers", b =>
                {
                    b.HasOne("DAO.Models.Group", "Group")
                        .WithMany()
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("DAO.Models.User", "Member")
                        .WithMany()
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("DAO.Models.Post", b =>
                {
                    b.HasOne("DAO.Models.User", "Creator")
                        .WithMany()
                        .HasForeignKey("CreatorId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("DAO.Models.Group", "Group")
                        .WithMany()
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.SetNull);
                });

            modelBuilder.Entity("DAO.Models.UserFilm", b =>
                {
                    b.HasOne("DAO.Models.Film", "Film")
                        .WithMany()
                        .HasForeignKey("FilmId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DAO.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DAO.Models.UserFilmInvite", b =>
                {
                    b.HasOne("DAO.Models.Group", "Group")
                        .WithMany()
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("DAO.Models.User", "InvitedUser")
                        .WithMany()
                        .HasForeignKey("InvitedUserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
