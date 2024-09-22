using AutoMapper;
using ChopeBastillaApplicationService.BookServiceApplicationDomain.Dto;
using ChopeBastillaApplicationService.BookServiceDomain.Entity;

namespace ChopeBastillaApplicationService.BookServiceApplicationDomain.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile() {
            CreateMap<Book, BookDetailResponse>()
                //.ForMember(dest => dest.Title, src => src.MapFrom(s => s.Title))
                //.ReverseMap()
                ;
        }
    }
}
