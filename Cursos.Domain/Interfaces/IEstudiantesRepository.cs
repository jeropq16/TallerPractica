using Cursos.Domain.Models;

namespace Cursos.Domain.Interfaces;

public interface IEstudiantesRepository
{
    Task<IEnumerable<Estudiantes>> GetAllEstudiantes();
    Task<Estudiantes> AddEstudiante(Estudiantes estudiantes);
    
    Task<Estudiantes> GetEstudianteById(int id);
    
    Task UpdateEstudiante(Estudiantes estudiantes);
    Task DeleteEstudiante(Estudiantes estudiantes);
}