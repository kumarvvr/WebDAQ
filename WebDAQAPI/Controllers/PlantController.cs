using Microsoft.AspNetCore.Mvc;
using WebDAQAPI.Models;
using WebDAQCore.Models;
using WebDAQCore.Services;

namespace WebDAQAPI.Controllers;


[Route("api/[controller]")]
[ApiController]
public class PlantController : ControllerBase
{
    private PlantsService plantsService;
    public PlantController(PlantsService _plantsService)
    {
        this.plantsService = _plantsService;
    }

    [HttpGet]
    public IEnumerable<Plant> Get()
    {
        return plantsService.GetAllPlants();
    }


    [HttpGet("{id}")]
    public Plant? Get(Guid id)
    {
        return plantsService.GetPlant(id);
    }

    // POST api/<PlantController>
    [HttpPost]
    public Guid Post([FromBody] CreatePlantModel plant)
    {
        return plantsService.CreateNewPlant(plant);
    }

    // PUT api/<PlantController>/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

}
