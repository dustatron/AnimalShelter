using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace ApiAnimalShelter.Models
{
  public class AnimalShelterContextFactory : IDesignTimeDbContextFactory<AnimalShelterContext>
  {
    AnimalShelterContext IDesignTimeDbContextFactory<AnimalShelterContext>.CreateDbContext(string[] args)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder()
          .SetBasePath(Directory.GetCurrentDirectory())
          .AddJsonFile("appsettings.json")
          .Build();

      var builder = new DbContextOptionsBuilder<AnimalShelterContext>();
      var connectionString = configuration.GetConnectionString("DefaultConnection");

      builder.UseMySql(connectionString);

      return new AnimalShelterContext(builder.Options);
    }

  }
}