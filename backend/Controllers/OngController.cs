using System.Collections.Generic;
using System.Linq;
using backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OngController : ControllerBase
    {

        public List<Ong> Ongs = new List<Ong>(){
            new Ong(){
                Id = 1,
                Name = "APAE",
                Email = "contato@apae.com.br",
                City = "Mongaguá",
                Uf = "SP"
            },new Ong(){
                Id = 2,
                Name = "Estrela da Mama",
                Email = "contato@estreladamama.com.br",
                City = "Praia Grande",
                Uf = "SP"
            },
        };
        public OngController(){}

        [HttpGet]
        public IActionResult Index()
        {
            return Ok(Ongs);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id){

            var ong = Ongs.FirstOrDefault( o => o.Id == id);

            if(ong == null) return BadRequest("Ong não encontrada");

            return Ok(ong);
        }

        [HttpPut]
        public IActionResult Create(){
            return Ok("create");
        }
    }
}