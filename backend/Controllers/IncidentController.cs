using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class IncidentController : ControllerBase
    {
        public IncidentController(){}

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Incidents cadastradas: apae, fazenda feliz");
        }
    }
}