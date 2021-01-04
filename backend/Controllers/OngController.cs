using System.Linq;
using backend.Data;
using backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OngController : ControllerBase
    {
        private readonly DataContext _context;

        public OngController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return Ok(_context.Ongs);
        }

        [HttpPost]
        public IActionResult Create(Ong ong){
            _context.Add(ong);
            _context.SaveChanges();
            return Ok(ong);
        }
    }
}