using ChopeBastillaApplicationService.BookServiceDomain.Entity;
using ChopeBastillaApplicationService.BookServiceDomain.Repository;

namespace ChopeBastillaApplicationService.BookServiceInfrastructure.Adapter
{
    public class BookRepositoryAdapter : IBookRepository
    {

        // arreglo 3 registros fake tipo Book
        List<Book> books = new()
        {
            new Book(Guid.Parse("2c75588a-74c0-4b27-b4ad-8e93b7f01642"), "978-3-16-148410-0", "English", "The Great Adventure", "A Journey Beyond", "An epic journey across unknown lands.", 300,
                     new BookDetail("John Doe", new List<string> { "English", "Spanish" }, new List<string> { "Adventure", "Fantasy" }, new List<string> { "Hardcover", "eBook" })),
            new Book(Guid.Parse("129ad84d-2fd6-406f-bd67-228f4ac0712d"), "978-1-23-456789-7", "Spanish", "El Misterio Oculto", "Descubriendo Secretos", "Una historia llena de misterio y secretos.", 250,
                     new BookDetail("Maria Perez", new List<string> { "Spanish", "French" }, new List<string> { "Mystery", "Thriller" }, new List<string> { "Paperback", "Audiobook" })),
            new Book(Guid.Parse("04503563-6577-4cd1-bf24-b4a3878e9191"), "978-0-12-345678-9", "French", "Le Voyage Énigmatique", "Dans un Monde Inconnu", "Un voyage énigmatique dans un monde mystérieux.", 400,
                     new BookDetail("Jean Dupont", new List<string> { "French", "German" }, new List<string> { "Sci-Fi", "Adventure" }, new List<string> { "Hardcover", "eBook" }))
        };

        public Task<Book> FindById(Guid id)
        {
            return Task.FromResult(books.FirstOrDefault(x => x.Id == id));
        }

        public Task<Book> FindByISBN(string isbn)
        {
            return Task.FromResult(books.FirstOrDefault(x => x.ISBN == isbn));
        }
    }
}
