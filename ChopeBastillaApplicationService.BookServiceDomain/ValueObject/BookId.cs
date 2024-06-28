
using ChopeBastillaApplicationService.CommonDomian.ValueObject;

namespace ChopeBastillaApplicationService.BookServiceDomain.ValueObject
{
    public class BookId : BaseId<Guid>
    {
        public BookId(Guid value) : base(value)
        {
        }
    }
}
