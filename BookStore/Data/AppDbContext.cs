using BookStore.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Genre
            modelBuilder.Entity<Genre>().HasData(new Genre
            {
                Id = 1,
                GenreName = "Science Friction"

            });
            modelBuilder.Entity<Genre>().HasData(new Genre
            {
                Id = 2,
                GenreName = "Horror"

            });
            modelBuilder.Entity<Genre>().HasData(new Genre
            {
                Id = 3,
                GenreName = "History"

            });
            modelBuilder.Entity<Genre>().HasData(new Genre
            {
                Id = 4,
                GenreName = "Fantasy"

            });

            //Author
            modelBuilder.Entity<Author>().HasData(new Author
            {
                Id = 1,
                AuthorName = "First Author"

            });
            modelBuilder.Entity<Author>().HasData(new Author
            {
                Id = 2,
                AuthorName = "Second Author"

            });
            modelBuilder.Entity<Author>().HasData(new Author
            {
                Id = 3,
                AuthorName = "Third Author"

            });
            modelBuilder.Entity<Author>().HasData(new Author
            {
                Id = 4,
                AuthorName = "Fourth Author"

            });

            //Books 
            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 1,
                Title = "Book 1",
                Description = "This is a very good book",
                AuthorId = 1,
                GenreId = 1

            });
            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 2,
                Title = "Book2",
                Description = "Amazing.!",
                AuthorId = 1,
                GenreId = 1

            });
            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 3,
                Title = "Book 3",
                Description = "Fantastic Book",
                AuthorId = 1,
                GenreId = 1

            });
            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 4,
                Title = "Book 4",
                Description = "This is a very good book",
                AuthorId = 2,
                GenreId = 2
            });
            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 5,
                Title = "Book 5",
                Description = "This book has got a some suprising elements",
                AuthorId = 2,
                GenreId = 2

            });
            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 6,
                Title = "Book 6",
                Description = "Good Book",
                AuthorId = 2,
                GenreId = 2

            });
            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 7,
                Title = "Book 7",
                Description = "Amazing Book",
                AuthorId = 3,
                GenreId = 3

            });
            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 8,
                Title = "Book 8",
                Description = "Nice story",
                AuthorId = 3,
                GenreId = 3

            });
            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 9,
                Title = "Book 9",
                Description = "Great Literature",
                AuthorId = 4,
                GenreId = 4

            });
            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 10,
                Title = "Book 10",
                Description = "Easy to ready",
                AuthorId = 4,
                GenreId = 4
            });
        }

        public DbSet<Genre> Genres { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}
