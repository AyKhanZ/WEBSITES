using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic; 

namespace WebApplication2.Controllers;
    public class Currency
    { 
        public int Id { get; set; }
        public string Name { get; set; } = "USD";
    }
[ApiController]
public class CurrentciesController : ControllerBase
{
    [HttpGet,Route("Currencies")]
    public IEnumerable<Currency> Currencies()
    {
        Currency currency1 = new() {Id =  1 };
        Currency currency2 = new() {Id =  2 };
        List<Currency> lst = new();
        lst.Add(currency1);
        lst.Add(currency2);
        return lst;
    }
}
