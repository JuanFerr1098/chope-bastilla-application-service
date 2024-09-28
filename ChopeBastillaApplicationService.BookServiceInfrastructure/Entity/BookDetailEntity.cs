namespace ChopeBastillaApplicationService.BookServiceInfrastructure.Entity
{
    public class BookDetailEntity
    {
        public Guid Id { get; set; }
        public Guid BookId { get; set; }
        public string Author { get; }
        public ICollection<string> AvailableLanguages { get; }
        public ICollection<string> Tags { get; }
        public ICollection<string> AvailablePresentations { get; }
        public virtual BookEntity Book { get; set; }
    }
}