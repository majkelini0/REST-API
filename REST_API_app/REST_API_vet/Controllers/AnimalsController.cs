using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using REST_API_vet.Models;

namespace REST_API_vet.Controllers;

[Route("my_api/animals")]
[ApiController]
public class AnimalsController : ControllerBase
{
    public static List<Animal> animals = new List<Animal>();
    
    [HttpGet]
    public IActionResult GetAnimals()
    {
        return Ok(animals);
    }

    [HttpGet("{id}")]
    public IActionResult GetAnimalByID(int id)
    {
        var animal = animals.FirstOrDefault(a => a.id == id);
        if (animal == null)
            return NotFound();
        return Ok(animal);
    }

    [HttpPost]
    public IActionResult AddAnimal([FromBody] Animal animal)
    {
        animals.Add(animal);
        return CreatedAtAction(nameof(GetAnimalByID), new { id = animal.id }, animal);
    }

    [HttpPut("{id}")]
    public IActionResult EditAnimalByID(int id, [FromBody] Animal updatedAnimal)
    {
        var animal = animals.FirstOrDefault(a => a.id == id);
        if (animal == null)
            return NotFound();
        animal.name = updatedAnimal.name;
        animal.category = updatedAnimal.category;
        animal.weight = updatedAnimal.weight;
        animal.color = updatedAnimal.color;
        return Ok(animal);
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteAnimalByID(int id)
    {
        var animal = animals.FirstOrDefault(a => a.id == id);
        if (animal == null)
            return NotFound();
        animals.Remove(animal);
        return NoContent();
    }
}