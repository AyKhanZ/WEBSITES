using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers;
[ApiController]
[Route("[controller]")]
public class CarController : ControllerBase
{
    Car bmv = new(1, "Baby", "BMV");
    Car audi = new(1, "Drogo", "AUDI");

    //[HttpGet,Route("Get/All")]
    [HttpGet]
    [Route("Get/All")]
    public IEnumerable<Car> Get()
    {
        List<Car> Cars = new() { bmv, audi };
        return Cars;
    }

    [HttpGet, Route("Get/{id}")]
    public Car Get(int id)
    {
        List<Car> Cars = new() { bmv, audi };
        foreach (var car in Cars)
        {
            if (car.Id == id) return car;
        }
        return new(id, "Def", "Def");
    }

    [HttpPut, Route("Put/All")]
    public IActionResult Put()
    {
        return Ok("put well");
    }


    [HttpDelete, Route("Delete/All")]
    public IActionResult Delete()
    {
        return Ok("Deleted well");
    }


    [HttpPost, Route("Post/All")]
    public IActionResult Post()
    {
        return Ok("Post well");
    }
}