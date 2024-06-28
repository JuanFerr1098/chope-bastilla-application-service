

namespace ChopeBastillaApplicationService.BookServiceDomain.Exception
{
    public class BookNotFoundException : BookDomainException
    {
        public BookNotFoundException(string? message) : base(message)
        {
        }

        public BookNotFoundException(string? message, System.Exception? innerException) : base(message, innerException)
        {
        }
    }
}
