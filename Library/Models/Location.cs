using System.Collections.Generic;

namespace Library.Models
{
  public class Location
  {
    public Location()
    {
      this.Books = new HashSet<BookLocation>();
    }
    public int LocationId { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public float Latitude { get; set; }
    public float Longitude { get; set; }
    public virtual ICollection<BookLocation> Books { get; }
  }
}