// Despite this being a one to many relationship, the migrations wouldn't build without a join table, so we made it a bit more interesting.

using System.Collections.Generic;

namespace Library.Models
{
  public class BookLocation
  {
    public int BookLocationId { get; set; }
    public int BookId { get; set; }
    public int LocationId { get; set; }

    // A bool to determine if this join is the current location of this book.
    public bool CurrentLocation { get; set; }
    public Book Book { get; set; }
    public Location Location { get; set; }
  }
}