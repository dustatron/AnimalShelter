using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;

namespace ApiAnimalShelter.Models
{
  public class AnimalShelterContext : DbContext
  {
    public DbSet<Animal> Animals { get; set; }
    public AnimalShelterContext(DbContextOptions<AnimalShelterContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Animal>()
          .HasData(
            new Animal { AnimalId = 1, Name = "Jerry", Age = 12, Type = "Tiger", Img = "https://c402277.ssl.cf1.rackcdn.com/photos/18134/images/hero_small/Medium_WW226365.jpg?1574452099", Comment = "Eats Humans" },
            new Animal { AnimalId = 2, Name = "Lil T Bone", Age = 10, Type = "Tiger", Img = "https://upload.wikimedia.org/wikipedia/commons/e/e7/GarfieldStanding.jpg", Comment = "Eats Humans" },
            new Animal { AnimalId = 3, Name = "Jar Jar", Age = 5, Type = "Tiger", Img = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcRFvER-gcaCz8GRzG5nFlSaJJ2xBJ_JM2uIoJq2JEgsziwwqPDt&usqp=CAU", Comment = "Reads English and French" },
            new Animal { AnimalId = 4, Name = "Dan", Age = 12, Type = "Pug", Img = "https://outwardhound.com/buzzwoof/wp-content/uploads/2017/09/Old-Pug.jpg", Comment = "Eats Everything" },
            new Animal { AnimalId = 5, Name = "Darth Varder", Age = 11, Type = "Pug", Img = "https://i.ytimg.com/vi/J3lK7kZ0_mk/hqdefault.jpg", Comment = "Can not hear." }
          );
    }
  }
}