using Microsoft.AspNetCore.Mvc;
using ProAgil.Dominio.Entidades;
using ProAgil.Dominio.Interfaces;
using System;

namespace ProAgil.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TemasController : ControllerBase
    {
        private readonly ITemaRepositorio _temaRepositorio;

        public TemasController(ITemaRepositorio temaRepositorio)
        {
            _temaRepositorio = temaRepositorio;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_temaRepositorio.ToList()); ;
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
            
        }
        [HttpPost]
        public IActionResult Post([FromBody] Tema tema)
        {
            try
            {
                _temaRepositorio.Add(tema);
                return Created("api/Eventos", tema);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }

        }
    }
}
