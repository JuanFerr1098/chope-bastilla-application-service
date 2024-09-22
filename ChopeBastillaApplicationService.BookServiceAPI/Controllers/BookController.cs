using ChopeBastillaApplicationService.BookServiceApplicationDomain.Dto;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ChopeBastillaApplicationService.BookServiceAPI.Controllers
{
 
    [ApiController]
    [Route("[controller]")]
    public class BookController : ControllerBase
    {
        private readonly ILogger<BookController> _logger;
        private readonly IMediator _mediator;

        public BookController(ILogger<BookController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        [HttpGet(Name = "BookById/{id}")]
        public async Task<BookDetailResponse> Get(Guid id)
        {
            return await _mediator.Send(new FindByIdentifierQuery() { Id = id });
        }
    }
}
