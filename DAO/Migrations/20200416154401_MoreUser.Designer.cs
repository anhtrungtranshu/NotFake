﻿// <auto-generated />
using System;
using DAO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DAO.Migrations
{
    [DbContext(typeof(NotFakeContext))]
    [Migration("20200416154401_MoreUser")]
    partial class MoreUser
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
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
                        new { FilmId = 1, GenreId = 1, Name = "Tom and Jerry", ThumbnailAddress = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/__ia_thumb.jpg", Type = 1 }
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
                        new { Id = 8, FilmId = 1, Address = "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/008%20%20%20Fine%20Feathered%20Friend%20%5B1942%5D.mp4", Name = "Fine Feathered Friend", RunTime = 100, ThumbnailAddress = "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/008%20%20%20Fine%20Feathered%20Friend%20%5B1942%5D_000001.jpg" }
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
                        new { GenreId = 1, Name = "Cartoons" }
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
                        new { UserId = 1, Email = "admin@demo.com", Fullname = "admin", Password = "AAp8Gl5mR9l+RlupYIJ1UoXUjW81CKVwf0iuiFGfp1MLOG88+6/QXX2otuFVpOUc5A==", Role = 1 },
                        new { UserId = 2, Email = "user2@demo.com", Fullname = "user full name 2", Password = "AJE0hszwGTufuEp64wM8sW8y6F6/N5xtGWWPPZ29CTGAO4+bJkUtwugDJlDGMlW02Q==", Role = 0 },
                        new { UserId = 3, Email = "user3@demo.com", Fullname = "user full name 3", Password = "APGxsJVpfYZiES+mBThYBzMnv7ro5WBBmP8yR2ebSm/+g0qrQ4YW+LcfKMRQDorKPw==", Role = 0 },
                        new { UserId = 4, Email = "user4@demo.com", Fullname = "user full name 4", Password = "APu00iJlok7VpieXTelifUq5/G+gVuXv7txQ6n3XuFVktbjDIyjDmZxKkt8os33j1A==", Role = 0 },
                        new { UserId = 5, Email = "user5@demo.com", Fullname = "user full name 5", Password = "AJ8Ex959VwH588C3PJoNM/lo6AIMHYJKax8ONrMG0nb8Iy34JIBgR+4Oq8Lylckfbw==", Role = 0 },
                        new { UserId = 6, Email = "user6@demo.com", Fullname = "user full name 6", Password = "ADnEvfd1JW88Gic0Kk5d0PyjNlN7Wt4qd+/gIs4z/p4NmiLKrJo78dxNTqhNhPuVUQ==", Role = 0 },
                        new { UserId = 7, Email = "user7@demo.com", Fullname = "user full name 7", Password = "APenOYHGcuN3gimx0iX3/2mb+NumdtURe7zifyFTmwEZQkdHCNvc2qA4Wrd0j3Re2g==", Role = 0 },
                        new { UserId = 8, Email = "user8@demo.com", Fullname = "user full name 8", Password = "AAnCe8M7LcMpKj4xJkKs9QbpccuZ7h1NmzU5mKLjgI00aaz+kf5O92oDLZ/DzLKAqg==", Role = 0 },
                        new { UserId = 9, Email = "user9@demo.com", Fullname = "user full name 9", Password = "AJkuTMEnzAMAi0fZ1MVFKUEe8Y48eIw+O/Bi1m3QahX2iWH9yjRkkgKfDewXHu7iDw==", Role = 0 }
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
                    b.Property<int>("InvitedUserId");

                    b.Property<int>("InvitingUserId");

                    b.Property<int>("FilmId");

                    b.Property<DateTime>("Created");

                    b.Property<DateTime>("WatchDate");

                    b.Property<int>("isAccepted");

                    b.HasKey("InvitedUserId", "InvitingUserId", "FilmId");

                    b.HasIndex("FilmId");

                    b.HasIndex("InvitingUserId");

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
                    b.HasOne("DAO.Models.Film", "Film")
                        .WithMany()
                        .HasForeignKey("FilmId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("DAO.Models.User", "InvitedUser")
                        .WithMany()
                        .HasForeignKey("InvitedUserId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("DAO.Models.User", "InvitingUser")
                        .WithMany()
                        .HasForeignKey("InvitingUserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}