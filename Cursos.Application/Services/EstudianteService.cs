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

    public async Task<Estudiante> AddEstudiante(Estudiante estudiante)
    {
        return await _repository.AddEstudiante(estudiante);
    }

    public async Task<IEnumerable<Estudiante>> GetAllEstudiantes()
    {
        return await _repository.GetAllEstudiantes();
    }

    public async Task<Estudiante> GetEstudianteById(int id)
    {
        return await _repository.GetEstudianteById(id);
    }

    public async Task<Estudiante?> UpdateEstudiante(int id, Estudiante estudiante)
    {
        var existe = await _repository.GetEstudianteById(id);

        if (existe == null) return null;

        existe.Nombre = estudiante.Nombre;
        existe.Email = estudiante.Email;
        existe.Telefono = estudiante.Telefono;

        return await _repository.UpdateEstudiante(existe);
    }

    public async Task<Estudiante?> DeleteEstudiante(int id)
    {
        var existe = await _repository.GetEstudianteById(id);
        if (existe == null) return null;

        await _repository.DeleteEstudiante(existe);
        return existe;
    }


}