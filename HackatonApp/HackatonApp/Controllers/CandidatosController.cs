using System;
using HackatonApp.Entities;
using HackatonApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace HackatonApp.Controllers
{
    [ApiController]
    [Route("candidatos")]
    public class CandidatosController : ControllerBase
    {
        private readonly ICandidatoService _candidatoService;

        public CandidatosController(ICandidatoService candidatoService)
        {
            _candidatoService = candidatoService;
        }

        [HttpGet]
        public IActionResult GetCandidatos()
        {
            try
            {
                return Ok(_candidatoService.GetCandidatos());
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        [HttpGet("{idCandidato}")]
        public IActionResult GetCandidato(int idCandidato)
        {
            try
            {
                return Ok(_candidatoService.GetCandidato(idCandidato));
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        [HttpPost]
        public IActionResult RegisterCandidato(Candidato candidato)
        {
            try
            {
                return Created("/candidatos", _candidatoService.RegisterCandidato(candidato));
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        [HttpPut]
        public IActionResult EditCandidato(Candidato candidato)
        {
            try
            {
                _candidatoService.UpdateCandidato(candidato);

                return NoContent();
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        [HttpDelete("{idCandidato}")]
        public IActionResult DeleteCandidatos(int idCandidato)
        {
            try
            {
                _candidatoService.DeleteCandidato(idCandidato);

                return Ok(new { Success = true, Message = "Deletado com sucesso!"});
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }
    }
}
