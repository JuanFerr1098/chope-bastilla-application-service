using AutoMapper;
using ChopeBastillaApplicationService.BookServiceApplicationDomain.Dto;
using ChopeBastillaApplicationService.BookServiceApplicationDomain.Handler;
using ChopeBastillaApplicationService.BookServiceApplicationDomain.Mapper;
using ChopeBastillaApplicationService.BookServiceDomain.Repository;
using ChopeBastillaApplicationService.BookServiceTest.Mock;
using Moq;

namespace ChopeBastillaApplicationService.BookServiceTest.Feature
{
    public class BookServiceTest
    {
        private readonly IMapper _mapper;
        private readonly Mock<IBookRepository> _bookRepository;

        public BookServiceTest()
        {
            _bookRepository = MockBookRepository.GetBookRepository();
            var mapperConfig = new MapperConfiguration(x =>
            {
                x.AddProfile<MappingProfile>();
            });
            _mapper = mapperConfig.CreateMapper();
        }

        [Fact]
        public async Task FindByIdBookTest()
        {
            var handler = new FindByIdentifierHandler(_bookRepository.Object, _mapper);
            var response = await handler.Handle(new FindByIdentifierQuery()
            {
                Id = Guid.Parse("2c75588a-74c0-4b27-b4ad-8e93b7f01642")
            }, CancellationToken.None);
            Assert.Equal(MockBookRepository.books.FirstOrDefault().Title, response.Title);
        }
    }
}
