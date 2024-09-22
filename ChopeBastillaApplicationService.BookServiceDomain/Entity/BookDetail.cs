namespace ChopeBastillaApplicationService.BookServiceDomain.Entity
{
    public class BookDetail
    {
        public string Author { get; }
        public ICollection<string> AvailableLanguages { get; }
        public ICollection<string> Tags { get; }
        public ICollection<string> AvailablePresentations { get; }

        public BookDetail(string author, ICollection<string> availableLanguages, ICollection<string> tags, ICollection<string> availablePresentations)
        {
            Author = author;
            AvailableLanguages = availableLanguages;
            Tags = tags;
            AvailablePresentations = availablePresentations;
        }
    }
}
