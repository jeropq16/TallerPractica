using Cursos.Domain.Models;

namespace Cursos.Domain.Interfaces;

public interface IEstudiantesRepository
{
    Task<IEnumerable<Estudiante>> GetAllEstudiantes();
    Task<Estudiante> AddEstudiante(Estudiante estudiante);
    
    Task<Estudiante> GetEstudianteById(int id);
    
    Task<Estudiante> UpdateEstudiante(Estudiante estudiante);
    Task DeleteEstudiante(Estudiante estudiante);
}