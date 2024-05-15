using Microsoft.AspNetCore.Mvc;
using WebDAQCore.Models;

namespace WebDAQAPI.Controllers;


[Route("api/[controller]")]
[ApiController]
public class PlantController : ControllerBase
{
    // GET: api/<PlantController>
    [HttpGet]
    public IEnumerable<Plant> Get()
    {
        return new string[] { "value1", "value2" };
    }

    // GET api/<PlantController>/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
        return "value";
    }

    // POST api/<PlantController>
    [HttpPost]
    public void Post([FromBody] string value)
    {
    }

    // PUT api/<PlantController>/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/<PlantController>/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
}
