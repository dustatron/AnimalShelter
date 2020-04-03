using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
using ApiAnimalShelter.Models;

namespace ApiAnimalShelter.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class AnimalsController : ControllerBase
  {
    private AnimalShelterContext _db;

    public AnimalsController(AnimalShelterContext db)
    {
      _db = db;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Animal>> Get()
    {
      return _db.Animals.ToList();
    }

    [HttpGet("{id}")]
    public ActionResult<Animal> Get(int id)
    {
      Animal thisAnimal = _db.Animals.FirstOrDefault(entry => entry.AnimalId == id);
      return thisAnimal;
    }

    [HttpPost]
    public ActionResult Post([FromBody] Animal animal)
    {
      _db.Animals.Add(animal);
      _db.SaveChanges();
      return Ok($"{animal.Name} was added to the database");
    }

    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Animal animal)
    {
      _db.Entry(animal).State = EntityState.Modified;
      _db.SaveChanges();

    }

    [HttpDelete("{id}")]
    public ActionResult Delete(int id)
    {
      Animal thisAnimal = _db.Animals.FirstOrDefault(animal => animal.AnimalId == id);
      _db.Animals.Remove(thisAnimal);
      _db.SaveChanges();
      return Ok($"{thisAnimal.Name} As been Deleted");
    }
  }
}