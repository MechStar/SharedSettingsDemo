using Microsoft.AspNetCore.Mvc;

namespace SecondApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SecondController : ControllerBase
    {
        [HttpGet]
        public string SecondEndpoint([FromServices] SecondService secondService) => secondService.SecondMethod();
    }
}
