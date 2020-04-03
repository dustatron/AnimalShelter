using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;

namespace ApiAnimalShelter.Models
{
  public class AnimalShelterContext : DbContext
  {
    public DbSet<Animal> Animals { get; set; }
    public AnimalShelterContext(DbContextOptions<AnimalShelterContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder build)
    {
      build.Entity<Animal>()
          .HashData(
              new Animal { AnimalId = 1, Name = "Jerry", Age = 12, Type = "Tiger", Img = "https://www.newsmax.com/CMSPages/GetFile.aspx?guid=7b87c9cf-647e-4092-961d-282cddd1a205", Comment = "Mean as all get out." },
              new Animal { AnimalId = 2, Name = "Larry", Age = 2, Type = "Tiger", Img = "https://www.newsmax.com/CMSPages/GetFile.aspx?guid=7b87c9cf-647e-4092-961d-282cddd1a205", Comment = "A read English and French." },
              new Animal { AnimalId = 3, Name = "Berry", Age = 4, Type = "Tiger", Img = "https://www.newsmax.com/CMSPages/GetFile.aspx?guid=7b87c9cf-647e-4092-961d-282cddd1a205", Comment = "Eats people." },
              new Animal { AnimalId = 4, Name = "Marry", Age = 6, Type = "Tiger", Img = "https://www.newsmax.com/CMSPages/GetFile.aspx?guid=7b87c9cf-647e-4092-961d-282cddd1a205", Comment = "Flight risk." },
              new Animal { AnimalId = 5, Name = "Phil", Age = 7, Type = "Tiger", Img = "https://www.newsmax.com/CMSPages/GetFile.aspx?guid=7b87c9cf-647e-4092-961d-282cddd1a205", Comment = "Like to vomit... a lot." },
              new Animal { AnimalId = 6, Name = "Moon Dusty", Age = 9, Type = "Tiger", Img = "https://www.newsmax.com/CMSPages/GetFile.aspx?guid=7b87c9cf-647e-4092-961d-282cddd1a205", Comment = "A real lover." }
          );
    }
  }
}