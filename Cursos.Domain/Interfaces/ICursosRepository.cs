using Cursos.Domain.Models;

namespace Cursos.Domain.Interfaces;

public interface ICursosRepository
{
    Task<IEnumerable<Curso>> GetAllCursos();
    Task<Curso> AddCurso(Curso curso);
    
    Task<Curso> GetCursoById(int id);
    
    Task<Curso> UpdateCurso(Curso curso);
    Task DeleteCurso(Curso curso);
}