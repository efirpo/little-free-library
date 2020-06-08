using Microsoft.EntityFrameworkCore;

namespace Library.Models
{
  public class LibraryContext : DbContext
  {
    public LibraryContext(DbContextOptions<LibraryContext> options) : base(options)
    {

    }
    public DbSet<Book> Books { get; set; }
    public DbSet<Location> Locations { get; set; }

    public virtual DbSet<BookLocation> BookLocation { get; set; }
  }
}