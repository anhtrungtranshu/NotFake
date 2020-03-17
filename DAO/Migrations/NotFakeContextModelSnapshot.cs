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

                    b.Property<string>("FilmAddress");

                    b.Property<int?>("GenreId");

                    b.Property<string>("Name");

                    b.Property<int>("RunTime");

                    b.HasKey("FilmId");

                    b.HasIndex("GenreId");

                    b.ToTable("Film");
                });

            modelBuilder.Entity("DAO.Models.Genre", b =>
                {
                    b.Property<int>("GenreId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("GenreId");

                    b.ToTable("Genre");
                });

            modelBuilder.Entity("DAO.Models.Post", b =>
                {
                    b.Property<int>("PostID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .IsRequired();

                    b.Property<DateTime>("Created");

                    b.Property<int?>("UserId");

                    b.Property<int?>("UserId1");

                    b.HasKey("PostID");

                    b.HasIndex("UserId");

                    b.HasIndex("UserId1");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("DAO.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<string>("Fullname");

                    b.Property<string>("Password");

                    b.Property<int>("Role");

                    b.Property<int?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("User");

                    b.HasData(
                        new { Id = 1, Email = "admin@demo.com", Fullname = "admin", Password = "@123456Xx", Role = 1 }
                    );
                });

            modelBuilder.Entity("DAO.Models.UserFilm", b =>
                {
                    b.Property<int>("UserFilmID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FilmId");

                    b.Property<int>("SecondsWatched");

                    b.Property<int?>("UserId");

                    b.HasKey("UserFilmID");

                    b.HasIndex("UserId");

                    b.ToTable("UserFilm");
                });

            modelBuilder.Entity("DAO.Models.UserFilmInvite", b =>
                {
                    b.Property<int>("UserFilmInviteID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created");

                    b.Property<int>("FilmID");

                    b.Property<int?>("UserId");

                    b.Property<int?>("UserId1");

                    b.Property<DateTime>("WatchDate");

                    b.Property<bool>("isAccepted");

                    b.HasKey("UserFilmInviteID");

                    b.HasIndex("UserId");

                    b.HasIndex("UserId1");

                    b.ToTable("UserFilmInvites");
                });

            modelBuilder.Entity("DAO.Models.Film", b =>
                {
                    b.HasOne("DAO.Models.Genre")
                        .WithMany("Films")
                        .HasForeignKey("GenreId");
                });

            modelBuilder.Entity("DAO.Models.Post", b =>
                {
                    b.HasOne("DAO.Models.User")
                        .WithMany("PostsFromOtherUsers")
                        .HasForeignKey("UserId");

                    b.HasOne("DAO.Models.User")
                        .WithMany("PostsToOtherUsers")
                        .HasForeignKey("UserId1");
                });

            modelBuilder.Entity("DAO.Models.User", b =>
                {
                    b.HasOne("DAO.Models.User")
                        .WithMany("Friends")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("DAO.Models.UserFilm", b =>
                {
                    b.HasOne("DAO.Models.User")
                        .WithMany("Films")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("DAO.Models.UserFilmInvite", b =>
                {
                    b.HasOne("DAO.Models.User")
                        .WithMany("InvitesFromOtherUsers")
                        .HasForeignKey("UserId");

                    b.HasOne("DAO.Models.User")
                        .WithMany("InvitesToOtherUsers")
                        .HasForeignKey("UserId1");
                });
#pragma warning restore 612, 618
        }
    }
}
