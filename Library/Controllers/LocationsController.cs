using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Library.Models;

namespace Library.Controllers
{
  [Route("api/[controller]")]
  public class LocationsController : Controller
  {
    private LibraryContext _db;

    public LocationsController(LibraryContext db)
    {
      _db = db;
    }

    [HttpPost]

    //POST api/locations
    public void Post([FromBody] Location location)
    {
      _db.Locations.Add(location);
      _db.SaveChanges();
    }

    //GET api/locations/1
    [HttpGet("{id}")]

    public ActionResult<Location> Get(int id)
    {
      var thisLocation = _db.Locations
      .Include(loc => loc.Books)
      .ThenInclude(join => join.Book)
      .FirstOrDefault(loc => loc.LocationId == id);

      return thisLocation;
    }

    //GET api/locations/1

    [ActionName("Get")]
    public ActionResult<IEnumerable<Location>> Search(string name, float Latitude, float Longitude)
    {
      var query = _db.Locations.AsQueryable();
      if (name != null)
      {
        query = query.Where(entry => entry.Name == name);
      }
      if (Latitude != null && Longitude != null)
      {
        query = query
        .Where(entry => (entry.Latitude < (Latitude + 0.010) && entry.Latitude > (Latitude - 0.010)))
        .Where(entry => (entry.Longitude < (Longitude + 0.010) && entry.Longitude > (Longitude - 0.010)));
      }
      return query.ToList();
    }
    //PUT api/locations/1
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Location location)
    {
      location.LocationId = id;
      _db.Entry(location).State = EntityState.Modified;
      _db.SaveChanges();
    }
    [HttpDelete("{id}")]

    //DELETE api/locations/1
    public void Delete(int id)
    {
      var locationToDelete = _db.Locations.FirstOrDefault(loc => loc.LocationId == id);
      _db.Locations.Remove(locationToDelete);
      _db.SaveChanges();
    }
  }
}