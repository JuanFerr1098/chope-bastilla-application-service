
using ChopeBastillaApplicationService.CommonDomian.CommonException;

namespace ChopeBastillaApplicationService.BookServiceDomain.Exception
{
    public class BookDomainException : DomainException
    {
        public BookDomainException(string? message) : base(message)
        {
        }

        public BookDomainException(string? message, System.Exception? innerException) : base(message, innerException)
        {
        }
    }
}
