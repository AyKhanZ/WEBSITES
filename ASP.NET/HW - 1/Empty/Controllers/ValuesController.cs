using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Empty.Controllers
{
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet,Route("Get")]
        public string GetStr()
        {
            return "All";
        }
    }
}
