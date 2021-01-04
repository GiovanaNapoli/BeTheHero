using System.Linq;
using backend.Data;
using backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class IncidentController : ControllerBase
    {
        private readonly DataContext _context;

        public IncidentController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return Ok(_context.Incidents);
        }
        
        [HttpPost]
        public IActionResult Create(Incident incident){
            _context.Add(incident);
            _context.SaveChanges();
            return Ok(incident);
        }

        [HttpDelete]
        public IActionResult Delete(int id){
            var incident = _context.Incidents.FirstOrDefault( o => o.Id == id);

            if(incident == null) return BadRequest("Incident não encontrado");

            _context.Remove(incident);
            _context.SaveChanges();

            return Ok(incident);
        }
    }
}