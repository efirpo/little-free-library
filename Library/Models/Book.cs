using System.Collections.Generic;

namespace Library.Models
{
  public class Book
  {
    public Book()
    {
      this.Locations = new HashSet<BookLocation>();
    }
    public int BookId { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public string Condition { get; set; }
    public bool Available { get; set; }
    public virtual ICollection<BookLocation> Locations { get; }
  }
}