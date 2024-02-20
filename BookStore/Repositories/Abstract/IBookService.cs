using BookStore.Models.Entities;

namespace BookStore.Repositories.Abstract
{
    public interface IBookService
    {
        bool Add(Book model);
        bool Delete(int Id);
        bool Update(Book model);
        IEnumerable<Book> GetAll();
        Book GetById(int id);

    }
}
