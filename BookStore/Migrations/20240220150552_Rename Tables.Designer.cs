﻿// <auto-generated />
using BookStore.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BookStore.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240220150552_Rename Tables")]
    partial class RenameTables
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BookStore.Models.Entities.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AuthorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorName = "First Author"
                        },
                        new
                        {
                            Id = 2,
                            AuthorName = "Second Author"
                        },
                        new
                        {
                            Id = 3,
                            AuthorName = "Third Author"
                        },
                        new
                        {
                            Id = 4,
                            AuthorName = "Fourth Author"
                        });
                });

            modelBuilder.Entity("BookStore.Models.Entities.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("GenreId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorId = 1,
                            Description = "This is a very good book",
                            GenreId = 1,
                            Title = "Book 1"
                        },
                        new
                        {
                            Id = 2,
                            AuthorId = 1,
                            Description = "Amazing.!",
                            GenreId = 1,
                            Title = "Book2"
                        },
                        new
                        {
                            Id = 3,
                            AuthorId = 1,
                            Description = "Fantastic Book",
                            GenreId = 1,
                            Title = "Book 3"
                        },
                        new
                        {
                            Id = 4,
                            AuthorId = 2,
                            Description = "This is a very good book",
                            GenreId = 2,
                            Title = "Book 4"
                        },
                        new
                        {
                            Id = 5,
                            AuthorId = 2,
                            Description = "This book has got a some suprising elements",
                            GenreId = 2,
                            Title = "Book 5"
                        },
                        new
                        {
                            Id = 6,
                            AuthorId = 2,
                            Description = "Good Book",
                            GenreId = 2,
                            Title = "Book 6"
                        },
                        new
                        {
                            Id = 7,
                            AuthorId = 3,
                            Description = "Amazing Book",
                            GenreId = 3,
                            Title = "Book 7"
                        },
                        new
                        {
                            Id = 8,
                            AuthorId = 3,
                            Description = "Nice story",
                            GenreId = 3,
                            Title = "Book 8"
                        },
                        new
                        {
                            Id = 9,
                            AuthorId = 4,
                            Description = "Great Literature",
                            GenreId = 4,
                            Title = "Book 9"
                        },
                        new
                        {
                            Id = 10,
                            AuthorId = 4,
                            Description = "Easy to ready",
                            GenreId = 4,
                            Title = "Book 10"
                        });
                });

            modelBuilder.Entity("BookStore.Models.Entities.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("GenreName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            GenreName = "Science Friction"
                        },
                        new
                        {
                            Id = 2,
                            GenreName = "Horror"
                        },
                        new
                        {
                            Id = 3,
                            GenreName = "History"
                        },
                        new
                        {
                            Id = 4,
                            GenreName = "Fantasy"
                        });
                });

            modelBuilder.Entity("BookStore.Models.Entities.Book", b =>
                {
                    b.HasOne("BookStore.Models.Entities.Author", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookStore.Models.Entities.Genre", "Genre")
                        .WithMany()
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Genre");
                });
#pragma warning restore 612, 618
        }
    }
}
