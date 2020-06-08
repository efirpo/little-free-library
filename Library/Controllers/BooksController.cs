using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Library.Models;
using Microsoft.EntityFrameworkCore;

namespace Library.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class BooksController : ControllerBase
  {
    private LibraryContext _db;
    public BooksController(LibraryContext db)
    {
      _db = db;
    }

    // GET api/books/GetAll
    [ActionName("GetAll")]
    public ActionResult<IEnumerable<Book>> GetAll()
    {
      return _db.Books.ToList();
    }

    //GET api/books
    // [ActionName("Get")]
    public ActionResult<IEnumerable<Book>> GetTitle(string title)
    {
      var query = _db.Books.AsQueryable();
      if (title != null)
      {
        query = query.Where(entry => entry.Title == title);
      }
      return query.ToList();
    }

    // //GET api/books
    // [HttpGet("{title, author, available, bookId}"), ActionName("Get")]
    // public ActionResult<IEnumerable<Book>> Get(string title, string author, bool available, int bookId)
    // {
    //   var query = _db.Books.AsQueryable();
    //   if (title != null)
    //   {
    //     query = query.Where(entry => entry.Title == title);
    //   }
    //   if (author != null)
    //   {
    //     query = query.Where(entry => entry.Author == author);
    //   }
    //   if (available != null)
    //   {
    //     query = query.Where(entry => entry.Available == available);
    //   }
    //   if (bookId != null)
    //   {
    //     query = query.Where(entry => entry.BookId == bookId);
    //   }
    //   return query.ToList();
    // }

    //POST api/books
    [HttpPost]
    public void Post([FromBody] Book book)
    {
      _db.Books.Add(book);
      _db.SaveChanges();
    }

    //GET api/books/7
    [HttpGet("{id}")]
    public ActionResult<Book> Get(int id)
    {
      return _db.Books.FirstOrDefault(entry => entry.BookId == id);
    }

    //PUT api/books/7
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Book book)
    {
      book.BookId = id;
      _db.Entry(book).State = EntityState.Modified;
      _db.SaveChanges();
    }

    //DELETE api/books/7
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var bookToDelete = _db.Books.FirstOrDefault(entry => entry.BookId == id);
      _db.Books.Remove(bookToDelete);
      _db.SaveChanges();
    }
  }
}