using Microsoft.AspNetCore.Mvc;

namespace FirstApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FirstController : ControllerBase
    {
        [HttpGet]
        public string FirstEndpoint([FromServices] FirstService firstService) => firstService.FirstMethod();
    }
}
