using System.Collections.Generic;

namespace Library.Models
{
  public class BookLocation
  {
    public int BookLocationId { get; set; }
    public int BookId { get; set; }
    public int LocationId { get; set; }
    public bool CurrentLocation { get; set; }
    public Book Book { get; set; }
    public Location Location { get; set; }
  }
}