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

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Location>()
      .HasData(
        // SEED LOCATIONS
        new Location
        {
          LocationId = 1,
          Name = "Charter 70947",
          Address = "320 SE 16th Ave, Portland OR 97229",
          Latitude = 45.520F,
          Longitude = -122.648F
        },
        new Location
        {
          LocationId = 2,
          Name = "Charter 738",
          Address = null,
          Latitude = 45.552F,
          Longitude = -122.683F
        },
        new Location
        {
          LocationId = 3,
          Name = "Charter 23646",
          Address = "88th & Oak, 8885 Nw Oak St, Portland OR 97229",
          Latitude = 45.521F,
          Longitude = -122.768F
        },
        new Location
        {
          LocationId = 4,
          Name = "Charter 10710",
          Address = "5635 NE 12th Ave, Portland OR 97211",
          Latitude = 45.563F,
          Longitude = -122.653F
        },
        new Location
        {
          LocationId = 5,
          Name = "Carter 76693",
          Address = "8310 N. Dana Ave, PORTLAND OR 97203",
          Latitude = 45.583F,
          Longitude = -122.712F
        },
        new Location
        {
          LocationId = 6,
          Name = "Carter 84632",
          Address = "6830 N Olin Ave, Portland OR 97203",
          Latitude = 45.574F,
          Longitude = -122.720F
        },
        new Location
        {
          LocationId = 7,
          Name = "Carter 92069",
          Address = "4525 Ne Campaign St, Portland OR 97218",
          Latitude = 45.554F,
          Longitude = -122.617F
        },
        new Location
        {
          LocationId = 8,
          Name = "Carter 19749",
          Address = "3145 NE 54th, Portland OR 97213",
          Latitude = 45.546F,
          Longitude = -122.608F
        },
        new Location
        {
          LocationId = 9,
          Name = "Carter 35332",
          Address = "2531 NE 38th Ave, Portland OR 97212",
          Latitude = 45.541F,
          Longitude = -122.624F
        },
        new Location
        {
          LocationId = 10,
          Name = "Carter 54633",
          Address = "6906 NE Siskiyou St., Portland OR 97213",
          Latitude = 45.545F,
          Longitude = -122.592F
        },
        new Location
        {
          LocationId = 11,
          Name = "Carter 16292",
          Address = "7310 NE Failing St, Portland OR 97213",
          Latitude = 45.550F,
          Longitude = -122.588F
        },
        new Location
        {
          LocationId = 12,
          Name = "Charter 60705",
          Address = "6701 NE Prescott St, Portland OR 97218",
          Latitude = 45.556F,
          Longitude = -122.594F
        },
        new Location
        {
          LocationId = 13,
          Name = "Charter 2400",
          Address = null,
          Latitude = 45.512F,
          Longitude = -122.609F
        },
        new Location
        {
          LocationId = 14,
          Name = "Charter 36705",
          Address = "7814 SE Grant Street, Portland OR 97215",
          Latitude = 45.507F,
          Longitude = -122.583F
        },
        new Location
        {
          LocationId = 15,
          Name = "Charter 98773",
          Address = "7230 Se Grant St, Portland OR 97215",
          Latitude = 45.507F,
          Longitude = -122.588F
        },
        new Location
        {
          LocationId = 16,
          Name = "Charter 88936",
          Address = "1707 Se 43rd Ave, Portland OR 97215",
          Latitude = 45.510F,
          Longitude = -122.618F
        },
        new Location
        {
          LocationId = 17,
          Name = "Charter 45756",
          Address = "SE 59th Avenue and Stark Street, Portland OR 97215",
          Latitude = 45.510F,
          Longitude = -122.603F
        },
        new Location
        {
          LocationId = 18,
          Name = "Charter 67860",
          Address = "113 se 28th ave, Portland OR 97214",
          Latitude = 45.521F,
          Longitude = -122.637F
        },
        new Location
        {
          LocationId = 19,
          Name = "Charter 19064",
          Address = "2336 NE 45th Ave, Portland OR 97213",
          Latitude = 45.539F,
          Longitude = -122.617F
        },
        new Location
        {
          LocationId = 20,
          Name = "Charter 23646",
          Address = "8885 Nw Oak St, Portland OR 97229",
          Latitude = 45.521F,
          Longitude = -122.768F
        }
      );
      // SEED JOINS BOOKLOCATION
      builder.Entity<BookLocation>()
      .HasData(
        new BookLocation
        {
          BookLocationId = 3,
          BookId = 18,
          LocationId = 20,
          CurrentLocation = true,
        },
        new BookLocation
        {
          BookLocationId = 4,
          BookId = 13,
          LocationId = 20,
          CurrentLocation = true,
        },
        new BookLocation
        {
          BookLocationId = 5,
          BookId = 1,
          LocationId = 20,
          CurrentLocation = false,
        },
        new BookLocation
        {
          BookLocationId = 6,
          BookId = 19,
          LocationId = 20,
          CurrentLocation = false,
        },
        new BookLocation
        {
          BookLocationId = 7,
          BookId = 3,
          LocationId = 19,
          CurrentLocation = true,
        },
        new BookLocation
        {
          BookLocationId = 8,
          BookId = 22,
          LocationId = 19,
          CurrentLocation = true,
        },
        new BookLocation
        {
          BookLocationId = 9,
          BookId = 8,
          LocationId = 19,
          CurrentLocation = false,
        },
        new BookLocation
        {
          BookLocationId = 10,
          BookId = 8,
          LocationId = 18,
          CurrentLocation = true,
        },
        new BookLocation
        {
          BookLocationId = 11,
          BookId = 17,
          LocationId = 18,
          CurrentLocation = true,
        },
        new BookLocation
        {
          BookLocationId = 12,
          BookId = 14,
          LocationId = 18,
          CurrentLocation = true,
        },
        new BookLocation
        {
          BookLocationId = 13,
          BookId = 6,
          LocationId = 18,
          CurrentLocation = true,
        },
        new BookLocation
        {
          BookLocationId = 14,
          BookId = 5,
          LocationId = 17,
          CurrentLocation = true,
        },
        new BookLocation
        {
          BookLocationId = 15,
          BookId = 7,
          LocationId = 17,
          CurrentLocation = false,
        },
        new BookLocation
        {
          BookLocationId = 16,
          BookId = 18,
          LocationId = 17,
          CurrentLocation = true,
        },
        new BookLocation
        {
          BookLocationId = 17,
          BookId = 10,
          LocationId = 16,
          CurrentLocation = true,
        },
        new BookLocation
        {
          BookLocationId = 18,
          BookId = 63,
          LocationId = 16,
          CurrentLocation = true,
        },
        new BookLocation
        {
          BookLocationId = 19,
          BookId = 54,
          LocationId = 16,
          CurrentLocation = true,
        },
        new BookLocation
        {
          BookLocationId = 20,
          BookId = 40,
          LocationId = 16,
          CurrentLocation = true,
        },
        new BookLocation
        {
          BookLocationId = 21,
          BookId = 34,
          LocationId = 16,
          CurrentLocation = true,
        },
        new BookLocation
        {
          BookLocationId = 22,
          BookId = 33,
          LocationId = 16,
          CurrentLocation = true,
        },
         new BookLocation
         {
           BookLocationId = 23,
           BookId = 53,
           LocationId = 15,
           CurrentLocation = true,
         },
        new BookLocation
        {
          BookLocationId = 24,
          BookId = 52,
          LocationId = 15,
          CurrentLocation = true,
        },
        new BookLocation
        {
          BookLocationId = 25,
          BookId = 51,
          LocationId = 15,
          CurrentLocation = false,
        },
        new BookLocation
        {
          BookLocationId = 26,
          BookId = 50,
          LocationId = 14,
          CurrentLocation = false,
        },
        new BookLocation
        {
          BookLocationId = 27,
          BookId = 49,
          LocationId = 14,
          CurrentLocation = true,
        },
        new BookLocation
        {
          BookLocationId = 28,
          BookId = 48,
          LocationId = 14,
          CurrentLocation = true,
        },
        new BookLocation
        {
          BookLocationId = 29,
          BookId = 47,
          LocationId = 13,
          CurrentLocation = false,
        },
        new BookLocation
        {
          BookLocationId = 30,
          BookId = 46,
          LocationId = 13,
          CurrentLocation = true,
        },
        new BookLocation
        {
          BookLocationId = 31,
          BookId = 45,
          LocationId = 13,
          CurrentLocation = true,
        },
        new BookLocation
        {
          BookLocationId = 32,
          BookId = 44,
          LocationId = 12,
          CurrentLocation = true,
        },
        new BookLocation
        {
          BookLocationId = 33,
          BookId = 43,
          LocationId = 12,
          CurrentLocation = true,
        },
        new BookLocation
        {
          BookLocationId = 34,
          BookId = 42,
          LocationId = 12,
          CurrentLocation = true,
        },
        new BookLocation
        {
          BookLocationId = 35,
          BookId = 41,
          LocationId = 11,
          CurrentLocation = false,
        },
        new BookLocation
        {
          BookLocationId = 36,
          BookId = 40,
          LocationId = 11,
          CurrentLocation = true,
        },
        new BookLocation
        {
          BookLocationId = 37,
          BookId = 39,
          LocationId = 11,
          CurrentLocation = true,
        },
        new BookLocation
        {
          BookLocationId = 38,
          BookId = 38,
          LocationId = 11,
          CurrentLocation = true,
        },
        new BookLocation
        {
          BookLocationId = 39,
          BookId = 37,
          LocationId = 10,
          CurrentLocation = true,
        },
        new BookLocation
        {
          BookLocationId = 40,
          BookId = 36,
          LocationId = 10,
          CurrentLocation = true,
        },
        new BookLocation
        {
          BookLocationId = 41,
          BookId = 35,
          LocationId = 10,
          CurrentLocation = true,
        },
        new BookLocation
        {
          BookLocationId = 42,
          BookId = 34,
          LocationId = 10,
          CurrentLocation = true,
        },
        new BookLocation
        {
          BookLocationId = 43,
          BookId = 33,
          LocationId = 9,
          CurrentLocation = true,
        },
        new BookLocation
        {
          BookLocationId = 44,
          BookId = 32,
          LocationId = 9,
          CurrentLocation = true,
        },
        new BookLocation
        {
          BookLocationId = 45,
          BookId = 31,
          LocationId = 9,
          CurrentLocation = true,
        },
        new BookLocation
        {
          BookLocationId = 46,
          BookId = 33,
          LocationId = 9,
          CurrentLocation = true,
        },
        new BookLocation
        {
          BookLocationId = 47,
          BookId = 32,
          LocationId = 9,
          CurrentLocation = true,
        },
        new BookLocation
        {
          BookLocationId = 48,
          BookId = 31,
          LocationId = 8,
          CurrentLocation = true,
        },
        new BookLocation
        {
          BookLocationId = 49,
          BookId = 30,
          LocationId = 8,
          CurrentLocation = true,
        },
        new BookLocation
        {
          BookLocationId = 50,
          BookId = 29,
          LocationId = 8,
          CurrentLocation = true,
        },
        new BookLocation
        {
          BookLocationId = 51,
          BookId = 28,
          LocationId = 7,
          CurrentLocation = true,
        },
        new BookLocation
        {
          BookLocationId = 52,
          BookId = 27,
          LocationId = 6,
          CurrentLocation = true,
        },
        new BookLocation
        {
          BookLocationId = 53,
          BookId = 26,
          LocationId = 6,
          CurrentLocation = true,
        },
        new BookLocation
        {
          BookLocationId = 54,
          BookId = 25,
          LocationId = 6,
          CurrentLocation = true,
        },
        new BookLocation
        {
          BookLocationId = 55,
          BookId = 24,
          LocationId = 5,
          CurrentLocation = true,
        },
        new BookLocation
        {
          BookLocationId = 56,
          BookId = 23,
          LocationId = 5,
          CurrentLocation = true,
        },
        new BookLocation
        {
          BookLocationId = 57,
          BookId = 22,
          LocationId = 4,
          CurrentLocation = true,
        },
        new BookLocation
        {
          BookLocationId = 58,
          BookId = 21,
          LocationId = 3,
          CurrentLocation = true,
        }
      );

      builder.Entity<Book>()
      .HasData(

      // SEED BOOKS
        new Book
        {
          BookId = 1,
          Title = "Living to Tell the Tale",
          Author = "Gabriel Garcia Marquez",
          Condition = "Good",
          Available = true,
        },
        new Book
        {
          BookId = 2,
          Title = "The Call of Cthulhu",
          Author = "Howard Phillips Lovecraft",
          Condition = "Poor",
          Available = true,
        },
        new Book
        {
          BookId = 3,
          Title = "Undaunted Courage",
          Author = "Stephen Ambrose",
          Condition = "Excellent",
          Available = true,
        },
        new Book
        {
          BookId = 4,
          Title = "The Devil in Massachusetts",
          Author = "Marion Starkey",
          Condition = "Poor",
          Available = true,
        },
        new Book
        {
          BookId = 5,
          Title = "The Poetry of Robert Frost",
          Author = "Robert Frost",
          Condition = "Fair",
          Available = true,
        },
        new Book
        {
          BookId = 6,
          Title = "Meditations",
          Author = "Marcus Aurelius",
          Condition = "Good",
          Available = true,
        },
        new Book
        {
          BookId = 7,
          Title = "The Book of Lies",
          Author = "Aleister Crowley",
          Condition = "Fair",
          Available = true,
        },
        new Book
        {
          BookId = 8,
          Title = "A New Face on the Countryside",
          Author = "Timothy Silver",
          Condition = "Fair",
          Available = true,
        },
        new Book
        {
          BookId = 9,
          Title = "A Choice of Catastrophes",
          Author = "Isaac Asimov",
          Condition = "Poor",
          Available = true,
        },
        new Book
        {
          BookId = 10,
          Title = "At Home",
          Author = "Bill Bryson",
          Condition = "Excellent",
          Available = true,
        },
        new Book
        {
          BookId = 11,
          Title = "Sapiens",
          Author = "Yuval Noah Harari",
          Condition = "Excellent",
          Available = true,
        },
        new Book
        {
          BookId = 12,
          Title = "Shamanism",
          Author = "Mircea Eliade",
          Condition = "Good",
          Available = true,
        },
        new Book
        {
          BookId = 13,
          Title = "Evil in Modern Society",
          Author = "Susan Neiman",
          Condition = "Good",
          Available = true,
        },
        new Book
        {
          BookId = 14,
          Title = "Full House",
          Author = "Stephen J. Gould",
          Condition = "Fair",
          Available = true,
        },
        new Book
        {
          BookId = 15,
          Title = "The Encyclopedia of Country Living",
          Author = "Carla Emery",
          Condition = "Fair",
          Available = true,
        },
        new Book
        {
          BookId = 16,
          Title = "Thus Spake Zarathustra",
          Author = "Frederich Nietzsche",
          Condition = "Poor",
          Available = true,
        },
        new Book
        {
          BookId = 17,
          Title = "Man and His Symbols",
          Author = "Carl Jung",
          Condition = "Poor",
          Available = true,
        },
        new Book
        {
          BookId = 18,
          Title = "Authority and the Individual",
          Author = "Bertrand Russell",
          Condition = "Poor",
          Available = true,
        },
        new Book
        {
          BookId = 19,
          Title = "A People’s History of the United States",
          Author = "Howard Zinn",
          Condition = "Good",
          Available = true,
        },
        new Book
        {
          BookId = 20,
          Title = "Tropic of Cancer",
          Author = "Henry Miller",
          Condition = "Good",
          Available = true,
        },
        new Book
        {
          BookId = 21,
          Title = "Tropic of Capricorn",
          Author = "Henry Miller",
          Condition = "Good",
          Available = true,
        },
        new Book
        {
          BookId = 22,
          Title = "Everyday Life in the Massachusetts Bay Colony",
          Author = "George Dow",
          Condition = "Poor",
          Available = true,
        },
        new Book
        {
          BookId = 23,
          Title = "Homo Deus",
          Author = "Yuval Noah Harari",
          Condition = "Excellent",
          Available = true,
        },
        new Book
        {
          BookId = 24,
          Title = "The Backyard Homestead",
          Author = "Carleen Madigan",
          Condition = "Fair",
          Available = true,
        },
        new Book
        {
          BookId = 25,
          Title = "The Right Stuff",
          Author = "Tom Wolfe",
          Condition = "Poor",
          Available = true,
        },
        new Book
        {
          BookId = 26,
          Title = "The New World Order",
          Author = "H.G. Wells",
          Condition = "Poor",
          Available = true,
        },
        new Book
        {
          BookId = 27,
          Title = "The Mandarins",
          Author = "Simone de Beauvoir",
          Condition = "Good",
          Available = true,
        },
        new Book
        {
          BookId = 28,
          Title = "One Hundred Years of Solitude",
          Author = "Gabriel Garcia Marquez",
          Condition = "Excellent",
          Available = true,
        },
        new Book
        {
          BookId = 29,
          Title = "The Fossil Trail",
          Author = "Stephen J. Gould",
          Condition = "Good",
          Available = true,
        },
        new Book
        {
          BookId = 30,
          Title = "Myths to Live By",
          Author = "Joseph Campbell",
          Condition = "Poor",
          Available = true,
        },
        new Book
        {
          BookId = 31,
          Title = "The Satanic Rituals",
          Author = "Anton Szandor LaVey",
          Condition = "Excellent",
          Available = true,
        },
        new Book
        {
          BookId = 32,
          Title = "Punch and Judy: A Complete History and Text",
          Author = "John Collier",
          Condition = "Good",
          Available = true,
        },
        new Book
        {
          BookId = 33,
          Title = "Alan Moore Spells It Out",
          Author = "Bill Baker",
          Condition = "Fair",
          Available = true,
        },
        new Book
        {
          BookId = 34,
          Title = "Cages",
          Author = "Dave McKean",
          Condition = "Poor",
          Available = true,
        },
        new Book
        {
          BookId = 35,
          Title = "Nicomachean Ethics",
          Author = "Aristotle",
          Condition = "Fair",
          Available = true,
        },
        new Book
        {
          BookId = 36,
          Title = "The Age of Missing Information",
          Author = "Bill McKibben",
          Condition = "Fair",
          Available = true,
        },
        new Book
        {
          BookId = 37,
          Title = "Empire",
          Author = "Gore Vidal",
          Condition = "Good",
          Available = true,
        },
        new Book
        {
          BookId = 38,
          Title = "Of Love and Other Demons",
          Author = "Gabriel Garcia Marquez",
          Condition = "Fair",
          Available = true,
        },
        new Book
        {
          BookId = 39,
          Title = "Wonderful Life",
          Author = "Stephen J. Gould",
          Condition = "Good",
          Available = true,
        },
        new Book
        {
          BookId = 40,
          Title = "Modern Man in Search of a Soul",
          Author = "Carl Jung",
          Condition = "Fair",
          Available = true,
        },
        new Book
        {
          BookId = 41,
          Title = "Comics and Sequential Art",
          Author = "Will Eisner",
          Condition = "Excellent",
          Available = true,
        },
        new Book
        {
          BookId = 42,
          Title = "Graphic Storytelling and Visual Narrative",
          Author = "Will Eisner",
          Condition = "Excellent",
          Available = true,
        },
        new Book
        {
          BookId = 43,
          Title = "Erasmus/Luther: Discourse on Free Will",
          Author = "Thomas Winter",
          Condition = "Good",
          Available = true,
        },
        new Book
        {
          BookId = 44,
          Title = "The Myth of Sisyphus and Other Essays",
          Author = "Albert Camus",
          Condition = "Poor",
          Available = true,
        },
        new Book
        {
          BookId = 45,
          Title = "The Fellowship of the Ring",
          Author = "J.R.R. Tolkien",
          Condition = "Poor",
          Available = true,
        },
        new Book
        {
          BookId = 46,
          Title = "The Two Towers",
          Author = "J.R.R. Tolkien",
          Condition = "Poor",
          Available = true,
        },
        new Book
        {
          BookId = 47,
          Title = "The Return of the King",
          Author = "J.R.R. Tolkien",
          Condition = "Poor",
          Available = true,
        },
        new Book
        {
          BookId = 48,
          Title = "The Conquest of Bread",
          Author = "Peter Kropotkin",
          Condition = "Fair",
          Available = true,
        },
        new Book
        {
          BookId = 49,
          Title = "Modern Death",
          Author = "Haider Warraich",
          Condition = "Good",
          Available = true,
        },
        new Book
        {
          BookId = 50,
          Title = "The Strategy of Peace",
          Author = "John F. Kennedy",
          Condition = "Poor",
          Available = true,
        },
        new Book
        {
          BookId = 51,
          Title = "The Problems of Philosophy",
          Author = "Bertrand Russell",
          Condition = "Fair",
          Available = true,
        },
        new Book
        {
          BookId = 52,
          Title = "On The Good Life",
          Author = "Cicero",
          Condition = "Poor",
          Available = true,
        },
        new Book
        {
          BookId = 53,
          Title = "The Left Hand of Darkness",
          Author = "Ursula LeGuin",
          Condition = "Poor",
          Available = true,
        },
        new Book
        {
          BookId = 54,
          Title = "Maus",
          Author = "Art Spiegelman",
          Condition = "Good",
          Available = true,
        },
        new Book
        {
          BookId = 55,
          Title = "Arkham Asylum: A Serious House on Serious Earth",
          Author = "Grant Morrison",
          Condition = "Excellent",
          Available = true,
        },
        new Book
        {
          BookId = 56,
          Title = "The Folklore of Capitalism",
          Author = "Thurman Arnold",
          Condition = "Poor",
          Available = true,
        },
        new Book
        {
          BookId = 57,
          Title = "This Changes Everything",
          Author = "Naomi Klein",
          Condition = "Good",
          Available = true,
        },
        new Book
        {
          BookId = 58,
          Title = "Gilliamesque",
          Author = "Terry Gilliam",
          Condition = "Excellent",
          Available = true,
        },
        new Book
        {
          BookId = 59,
          Title = "Fear and Loathing on the Campaign Trial ’72",
          Author = "Hunter S. Thompson",
          Condition = "Fair",
          Available = true,
        },
        new Book
        {
          BookId = 60,
          Title = "The Great Shark Hunt",
          Author = "Hunter S. Thompson",
          Condition = "Good",
          Available = true,
        },
        new Book
        {
          BookId = 61,
          Title = "The Divine Comedy",
          Author = "Dante Alighieri",
          Condition = "Good",
          Available = true,
        },
        new Book
        {
          BookId = 62,
          Title = "Love in the Time of Cholera",
          Author = "Gabriel Garcia Marquez",
          Condition = "Excellent",
          Available = true,
        },
        new Book
        {
          BookId = 63,
          Title = "The Picture of Dorian Grey",
          Author = "Oscar Wilde",
          Condition = "Good",
          Available = true,
        },
        new Book
        {
          BookId = 64,
          Title = "The Brothers Karamazov",
          Author = "Fyodor Dostoevsky",
          Condition = "Fair",
          Available = true,
        },
        new Book
        {
          BookId = 65,
          Title = "The Pedagogical Sketchbook",
          Author = "Paul Klee",
          Condition = "Poor",
          Available = true,
        }
    );
    }
  }
}