using Cursos.Application.Services;
using Cursos.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cursos.Api.Controllers;

[ApiController]
[Route("api/[controller]")] 
public class CursoController : ControllerBase
{
    private readonly CursoService _service;

    public CursoController(CursoService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var cursos = await _service.GetAllCursos();
        return Ok(cursos);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var cursos = await _service.GetCursoById(id);
        if (cursos == null) return NotFound();
        return Ok(cursos);
    }

    [HttpPost]
    public async Task<IActionResult> Add(Curso curso)
    {
        var crear = await _service.AddCurso(curso);
        return CreatedAtAction(nameof(GetById), new { id = crear.Id }, crear);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id,Curso curso)
    {
        var actualizado = await _service.UpdateCurso(id, curso);
        if (actualizado == null) return NotFound();
        return Ok(actualizado);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var eliminado = await _service.DeleteCurso(id);
        if (eliminado == null) return NotFound();
        return Ok(eliminado);
    }
}