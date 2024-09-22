using MediatR;

namespace ChopeBastillaApplicationService.BookServiceApplicationDomain.Dto
{
    public class FindByIdentifierQuery : IRequest<BookDetailResponse>
    {
        public Guid? Id { get; set; }
        public string? ISBN { get; set; }
    }
}
