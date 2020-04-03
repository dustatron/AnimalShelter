using System.Xml;
using MvcAnimalShelter.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;


namespace MvcAnimalShelter.Controllers
{
  public class AnimalsController : Controller
  {
    public IActionResult Index()
    {
      var allAnimals = Animal.GetAnimals();
      return View(allAnimals);
    }

    public IActionResult Details(int id)
    {
      var thisAnimal = Animal.GetDetails(id);
      return View(thisAnimal);
    }
    public IActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public IActionResult Create(Animal animal)
    {
      Animal.Post(animal);
      return RedirectToAction("Index");
    }

    public IActionResult Edit(int id)
    {
      Animal thisAnimal = Animal.GetDetails(id);
      return View(thisAnimal);
    }

    [HttpPost]
    public IActionResult Edit(Animal animal)
    {
      Animal.Put(animal);
      return RedirectToAction("Details", new { id = animal.AnimalId });
    }

    public ActionResult Delete(int id)
    {
      Animal thisAnimal = Animal.GetDetails(id);
      return View(thisAnimal);
    }
    [HttpPost, ActionName("Delete")]
    public ActionResult ConfirmDelete(int id)
    {
      Animal.Delete(id);
      return RedirectToAction("Index");
    }

  }
}