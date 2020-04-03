using System;

namespace ApiAnimalShelter.Models
{
  public class Animal
  {
    public int AnimalId { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Type { get; set; }
    public string Img { get; set; }
    public string Comment { get; set; }
  }
}