using Microsoft.AspNetCore.Mvc;
using WebDAQCore.Models;
using WebDAQCore.Services;

namespace WebDAQApp.Server.Controllers;


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
        // Gets all the details of the plant
        return plantsService.GetPlant(id);
    }


    [HttpPost]
    public Guid Post([FromBody] NewPlantRecord plant)
    {
        return plantsService.CreateNewPlant(plant);
    }


    [HttpPut("{id}")]
    public void Put([FromBody] UpdatePlantRecord record)
    {

        plantsService.UpdatePlant(record);
    }

}
