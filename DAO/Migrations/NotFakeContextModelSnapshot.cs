﻿// <auto-generated />
using System;
using DAO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DAO.Migrations
{
    [DbContext(typeof(NotFakeContext))]
    partial class NotFakeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<string>("FilmAddress")
                        .IsRequired();

                    b.Property<int>("GenreId");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("RunTime");

                    b.Property<string>("ThumbnailAddress")
                        .IsRequired();

                    b.HasKey("FilmId");

                    b.HasIndex("GenreId");

                    b.ToTable("Film");

                    b.HasData(
                        new { FilmId = 1, FilmAddress = "", GenreId = 1, Name = "Balloon", RunTime = 100, ThumbnailAddress = "../../NotFake/wwwroot/Thumbnails/Balloon.PNG" }
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
                        new { GenreId = 1, Name = "Comedies" }
                    );
                });

            modelBuilder.Entity("DAO.Models.Post", b =>
                {
                    b.Property<int>("PostID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content");

                    b.Property<DateTime>("Created");

                    b.Property<int>("ReceivedUserId");

                    b.Property<int>("SentUserId");

                    b.HasKey("PostID");

                    b.HasIndex("ReceivedUserId");

                    b.HasIndex("SentUserId");

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
                        new { UserId = 1, Email = "admin@demo.com", Fullname = "admin", Password = "APPVwpd/Tr4SRfJPU+8iupNtBDr7wpXtN463r5v9GuDvAg/w2iycGO07fogrg6V9Rg==", Role = 1 }
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

            modelBuilder.Entity("DAO.Models.Post", b =>
                {
                    b.HasOne("DAO.Models.User", "ReceivedUser")
                        .WithMany()
                        .HasForeignKey("ReceivedUserId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("DAO.Models.User", "SentUser")
                        .WithMany()
                        .HasForeignKey("SentUserId")
                        .OnDelete(DeleteBehavior.Restrict);
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
