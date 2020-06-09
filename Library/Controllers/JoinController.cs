using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Library.Models;

namespace Library.Controllers
{
  [Route("api/[controller]")]
  [ApiController]

  public class JoinController : ControllerBase
  {
    private readonly LibraryContext _db;
    public JoinController(LibraryContext db)
    {
      _db = db;
    }
    [HttpGet]
    public ActionResult<IEnumerable<BookLocation>> Get(int bookId, int locationId)
    {
      var query = _db.BookLocation.AsQueryable();
      if (bookId != 0)
      {
        query = query.Where(entry => entry.BookId == bookId);
      }
      if (locationId != 0)
      {
        query = query.Where(entry => entry.LocationId == locationId);
      }
      return query.ToList();
    }

    [HttpPost]
    public void Post([FromBody] BookLocation bookLocation)
    {
      _db.BookLocation.Add(bookLocation);
      _db.SaveChanges();
    }

    //GET api/join/7
    [HttpGet("{id}")]
    public ActionResult<BookLocation> GetAction(int id)
    {
      return _db.BookLocation.FirstOrDefault(entry => entry.BookLocationId == id);
    }

    [HttpPut("{id}")]

    public void Put(int id, [FromBody] BookLocation bookLocation)
    {
      bookLocation.BookLocationId = id;
      _db.Entry(bookLocation).State = EntityState.Modified;
      _db.SaveChanges();
    }

    //DELETE api/jin/7
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var joinToDelete = _db.BookLocation.FirstOrDefault(entry => entry.BookLocationId == id);
      _db.BookLocation.Remove(joinToDelete);
      _db.SaveChanges();
    }
  }
}