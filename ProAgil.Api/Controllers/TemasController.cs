using Microsoft.AspNetCore.Mvc;
using ProAgil.Dominio.Entidades;
using ProAgil.Dominio.Interfaces;
using System;

namespace ProAgil.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventosController : ControllerBase
    {
        private readonly IEventoRepositorio _eventoRepositorio;

        public EventosController(IEventoRepositorio eventoRepositorio)
        {
            _eventoRepositorio = eventoRepositorio;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_eventoRepositorio.ToList()); ;
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
            
        }
        [HttpPost]
        public IActionResult Post([FromBody] Evento evento)
        {
            try
            {
                _eventoRepositorio.Add(evento);
                return Created("api/Eventos", evento);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }

        }
    }
}
