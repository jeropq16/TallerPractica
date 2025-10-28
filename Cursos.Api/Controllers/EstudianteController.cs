using Cursos.Application.Services;
using Cursos.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cursos.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EstudianteController : ControllerBase
{
    private readonly EstudianteService _service;

    public EstudianteController(EstudianteService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var estudiantes = await _service.GetAllEstudiantes();
        return Ok(estudiantes);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var estudiante = await _service.GetEstudianteById(id);
        if (estudiante == null) return NotFound();
        return Ok(estudiante);
    }

    [HttpPost]
    public async Task<IActionResult> Add(Estudiante estudiante)
    {
        var crear = await _service.AddEstudiante(estudiante);
        return CreatedAtAction(nameof(GetById), new { id = crear.Id }, crear);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, Estudiante estudiante)
    {
        var actualizado = await _service.UpdateEstudiante(id, estudiante);
        if (actualizado == null) return NotFound();
        return Ok(actualizado);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var eliminado = await _service.DeleteEstudiante(id);
        if (eliminado == null) return NotFound();
        return Ok(eliminado);
    }

}