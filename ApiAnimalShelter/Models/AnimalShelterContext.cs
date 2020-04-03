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
            new Animal { AnimalId = 1, Name = "Jerry", Age = 12, Type = "Tiger", Img = "", Comment = "Eats Humans" },
            new Animal { AnimalId = 2, Name = "Larry", Age = 12, Type = "Tiger", Img = "", Comment = "Eats Humans" },
            new Animal { AnimalId = 3, Name = "Berry", Age = 12, Type = "Tiger", Img = "", Comment = "Eats Humans" },
            new Animal { AnimalId = 4, Name = "Marry", Age = 12, Type = "Tiger", Img = "", Comment = "Eats Humans" }
          );
    }
  }
}