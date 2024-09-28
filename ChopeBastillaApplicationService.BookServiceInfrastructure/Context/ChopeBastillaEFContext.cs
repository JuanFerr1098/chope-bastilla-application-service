using ChopeBastillaApplicationService.BookServiceDomain.Entity;
using ChopeBastillaApplicationService.BookServiceInfrastructure.Entity;
using Microsoft.EntityFrameworkCore;

namespace ChopeBastillaApplicationService.BookServiceInfrastructure.Context
{
    public class ChopeBastillaEFContext : DbContext
    {
        public ChopeBastillaEFContext(DbContextOptions<ChopeBastillaEFContext> options) : base(options) 
        {
        }

        public DbSet<BookEntity> Books { get; set; }
        public DbSet<BookDetailEntity> BookDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookEntity>()
                .HasOne(x => x.BookDetail)
                .WithOne(x => x.Book)
                .HasForeignKey<BookEntity>(x => x.BookDetailId)
                .IsRequired()
                ;
        }

    }
}
