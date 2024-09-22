using ChopeBastillaApplicationService.CommonDomian.Entity;

namespace ChopeBastillaApplicationService.BookServiceDomain.Entity
{
    public class Book : BaseEntity<Guid>
    {
        public string ISBN { get; } // identificador del libro - International Standar Book Number
        public BookDetail BookDetail { get; }
        public string Language { get; }
        public string Title { get; }
        public string SubTitle { get; }
        public string Synopsis { get; }
        public int NumberOfPages { get; }

        public Book(Guid id, string iSBN, string language, string title, string subTitle, string synopsis, int numberOfPages, BookDetail bookDetail) : base (id)
        {
            ISBN = iSBN;
            BookDetail = bookDetail;
            Language = language;
            Title = title;
            SubTitle = subTitle;
            Synopsis = synopsis;
            NumberOfPages = numberOfPages;
        }
    }
}
