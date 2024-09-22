using ChopeBastillaApplicationService.BookServiceDomain.Entity;

namespace ChopeBastillaApplicationService.BookServiceDomain.Repository
{
    public interface IBookRepository
    {
        Task<Book> FindById(Guid id);
        Task<Book> FindByISBN(string isbn);
    }
}
