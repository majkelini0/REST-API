using Microsoft.AspNetCore.Mvc;
using REST_API_vet.Models;

namespace REST_API_vet.Controllers;

[Route("my_api/animals")]
[ApiController]
public class AnimalsController : ControllerBase
{
    // public static readonly List<Animal> animalsList = new ()
    // {
    //     //new Animal {id=1, name="Pimpek", category="dog", weight=38.9, color="brown"},
    //     //new Animal {id=2, name="Filowstret", category="cat", weight=3.3, color="pitch black"},
    //     new Animal (3, "Jas", "cat", 7.3, "tabby"),
    //     // new Animal {4, "Maja", "bee", 0.005, "yellow"}
    // };
    
    [HttpGet]
    public IActionResult GetAnimals()
    {
        return Ok(Animal.listOfAnimals);
    }
}