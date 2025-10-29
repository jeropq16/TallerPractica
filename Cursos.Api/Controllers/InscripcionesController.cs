using Microsoft.AspNetCore.Mvc;
using Cursos.Domain.Interfaces;
using Cursos.Application.Services;
using Cursos.Domain.Models;

namespace Cursos.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InscripcionesController : ControllerBase
    {
        private readonly InscripcionesService _service;

        public InscripcionesController(InscripcionesService service)
        {
            _service = service;
        }
        
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var lista = await _service.ListarAsync();
            return Ok(lista);
        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var inscripcion = await _service.BuscarPorIdAsync(id);
            if (inscripcion == null)
                return NotFound($"No se encontró una inscripción con ID {id}");
            
            return Ok(inscripcion);
        }
        
        [HttpGet("estudiante/{estudianteId}")]
        public async Task<IActionResult> GetByEstudiante(int estudianteId)
        {
            var lista = await _service.BuscarPorEstudianteAsync(estudianteId);
            return Ok(lista);
        }
        
        [HttpGet("curso/{cursoId}")]
        public async Task<IActionResult> GetByCurso(int cursoId)
        {
            var lista = await _service.BuscarPorCursoAsync(cursoId);
            return Ok(lista);
        }
        
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Inscripciones inscripciones)
        {
            if (inscripciones == null)
                return BadRequest("Los datos de la inscripción son obligatorios.");

            await _service.CrearAsync(inscripciones);
            return Ok("Inscripción registrada correctamente.");
        }
    }
}
