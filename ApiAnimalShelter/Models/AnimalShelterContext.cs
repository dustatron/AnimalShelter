using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;

namespace ApiAnimalShelter.Models
{
  public class AnimalShelterContext : DbContext
  {
    public DbSet<Animal> Animals { get; set; }
    public AnimalShelterContext(DbContextOptions<AnimalShelterContext> options) : base(options) { }

  }
}