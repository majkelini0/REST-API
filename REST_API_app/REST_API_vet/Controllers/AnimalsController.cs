using Microsoft.AspNetCore.Mvc;
using REST_API_vet.Models;
using REST_API_vet.Database;

namespace REST_API_vet.Controllers;

[Route("my_api/animals")]
[ApiController]
public class AnimalsController : ControllerBase
{
    [HttpGet]
    public IActionResult GetAnimals()
    {
        var animals = MockDB.getInstance().Animals;
        return Ok(animals);
    }

    [HttpGet("{id}")]
    public IActionResult GetAnimalById(int id)
    {
        var animals = MockDB.getInstance().Animals;
        var animal = animals.FirstOrDefault(a => a.id == id);
        if (animal == null)
            return NotFound();
        return Ok(animal);
    }
    
    [HttpPost]
    public IActionResult AddAnimal([FromBody] Animal animal)
    {
        var animals = MockDB.getInstance().Animals;
        animals.Add(animal);
        return CreatedAtAction(nameof(GetAnimalById), new { id = animal.id }, animal);
    }
    
    [HttpPut("{id}")]
    public IActionResult EditAnimalById(int id, [FromBody] Animal editedAnimal)
    {
        var animals = MockDB.getInstance().Animals;
        var animal = animals.FirstOrDefault(a => a.id == id);
        if (animal == null)
            return NotFound();
        animal.name = editedAnimal.name;
        animal.category = editedAnimal.category;
        animal.weight = editedAnimal.weight;
        animal.color = editedAnimal.color;
        return Ok(animal);
    }
    
    [HttpDelete("{id}")]
    public IActionResult DeleteAnimalById(int id)
    {
        var animals = MockDB.getInstance().Animals;
        var animal = animals.FirstOrDefault(a => a.id == id);
        if (animal == null)
            return NotFound();
        animals.Remove(animal);
        return NoContent();
    }
}