using BookStore.Data;
using BookStore.Models.Entities;
using BookStore.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Repositories.Implementation
{
    public class BookService : IBookService
    {
        private readonly AppDbContext _appDbContext;

        public BookService(AppDbContext appDbContext) 
        {
            _appDbContext = appDbContext;
        }
        public bool Add(Book model)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Book> GetAll()
        {
            return _appDbContext.Books
                .Include(book => book.Author)
                .Include(book => book.Genre)
                .ToList();
        }

        public Book GetById(int id)
        {
            return _appDbContext.Books
                .Include(book => book.Author)
                .Include(book => book.Genre)
                .FirstOrDefault(book => book.Id == id)!;
        }

        public bool Update(Book model)
        {
            throw new NotImplementedException();
        }
    }
}
