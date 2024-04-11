using Microsoft.AspNetCore.Mvc;
using REST_API_vet.Models;
using REST_API_vet.Database;

namespace REST_API_vet.Controllers;

[Route("my_api/visits")]
[ApiController]
public class VisitsController : ControllerBase
{
    [HttpGet("{pasedAnimalId}")]
    public IActionResult GetVisitByAnimalId(int pasedAnimalId)
    {
        var visits = MockDB.getInstance().Visits;
        List<Visit> animalVisits = visits.FindAll(a => a.animalId == pasedAnimalId);
        
        if (animalVisits == null)
            return NotFound();
        return Ok(animalVisits);
    }

    [HttpPost]
    public IActionResult AddVisit([FromBody] Visit visit)
    {
        var visits = MockDB.getInstance().Visits;
        var animals = MockDB.getInstance().Animals;
        var animal = animals.FirstOrDefault(a => a.id == visit.animalId);
        if (animal == null)
            return NoContent();
        
        visits.Add(visit);
        return StatusCode(StatusCodes.Status201Created);
    }
}