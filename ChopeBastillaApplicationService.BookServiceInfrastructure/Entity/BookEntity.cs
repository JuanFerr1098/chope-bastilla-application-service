namespace ChopeBastillaApplicationService.BookServiceInfrastructure.Entity
{
    public class BookEntity
    {
        public Guid Id { get; set; }
        public string ISBN { get; } // identificador del libro - International Standar Book Number
        public Guid BookDetailId { get; set; }
        public string Language { get; }
        public string Title { get; }
        public string SubTitle { get; }
        public string Synopsis { get; }
        public int NumberOfPages { get; }
        public virtual BookDetailEntity BookDetail { get; }

    }
}
