using Cursos.Domain.Interfaces;
using Cursos.Domain.Models;

namespace Cursos.Application.Services;

public class CursoService
{
    private readonly ICursosRepository _repository;

    public CursoService(ICursosRepository repository)
    {
        _repository = repository;
    } 
    
    public async Task<Curso> AddCurso(Curso curso)
    {
        return await _repository.AddCurso(curso);
    }

    public async Task<IEnumerable<Curso>> GetAllCursos()
    {
        return await _repository.GetAllCursos();
    }
    
    public async Task<Curso> GetCursoById(int id)
    {
        return await _repository.GetCursoById(id);
    }

    public async Task<Curso?> UpdateCurso(int id, Curso curso)
    {
        var existe = await _repository.GetCursoById(id);

        if (existe == null) return null;

        existe.Nombre = curso.Nombre;
        existe.Descripcion = curso.Descripcion;

        return await _repository.UpdateCurso(existe);
    }

    public async Task<Curso?> DeleteCurso(int id)
    {
        var existe = await _repository.GetCursoById(id);
        if (existe == null) return null;

        await _repository.DeleteCurso(existe);
        return existe;
    }
}