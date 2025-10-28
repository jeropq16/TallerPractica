using Cursos.Domain.Interfaces;
using Cursos.Domain.Models;

namespace Cursos.Application.Services;

public class EstudianteService
{
    private readonly IEstudiantesRepository _repository;

    public EstudianteService(IEstudiantesRepository repository)
    {
        _repository = repository;
    }

    public async Task<Estudiantes> AddEstudiante(Estudiantes estudiantes)
    {
        return await _repository.AddEstudiante(estudiantes);
    }

    public async Task<IEnumerable<Estudiantes>> GetAllEstudiantes()
    {
        return await _repository.GetAllEstudiantes();
    }

    public async Task<Estudiantes> GetEstudianteById(int id)
    {
        return await _repository.GetEstudianteById(id);
    }

    public async Task<Estudiantes> UpdateEstudiante( int id, Estudiantes estudiantes)
    {
        var existe = _repository.GetEstudianteById(id);
        if (existe == null) return null;
        return estudiantes;
    }
}