using AutoMapper;
using ChopeBastillaApplicationService.BookServiceApplicationDomain.Dto;
using ChopeBastillaApplicationService.BookServiceDomain.Repository;
using MediatR;

namespace ChopeBastillaApplicationService.BookServiceApplicationDomain.Handler
{
    public class FindByIdentifierHandler : IRequestHandler<FindByIdentifierQuery, BookDetailResponse>
    {
        private readonly IBookRepository _bookRepository;
        private readonly IMapper _mapper;

        public FindByIdentifierHandler(IBookRepository bookRepository, IMapper mapper)
        {
            _bookRepository = bookRepository;
            _mapper = mapper;
        }

        // Patron cqrs
        public async Task<BookDetailResponse> Handle(FindByIdentifierQuery request, CancellationToken cancellationToken)
        {

            if (request.Id != null)
            {
                var response = await _bookRepository.FindById(request.Id.GetValueOrDefault());
                return _mapper.Map<BookDetailResponse>(response);
                
            }
            if(request.ISBN != null)
            {
                var response = await _bookRepository.FindByISBN(request.ISBN);
                return _mapper.Map<BookDetailResponse>(response);
            }

            // TODO: Refactor para validar el error
            return new() { Title = "Sin titulo" };
        }
    }
}
