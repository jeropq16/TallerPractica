using Cursos.Domain.Models;

namespace Cursos.Application.Interfaces
{
    public interface IInscripcionesService
    {
        Task<IEnumerable<Inscripciones>> ListarAsync();
        Task<Inscripciones?> BuscarPorIdAsync(int id);
        Task<IEnumerable<Inscripciones>> BuscarPorEstudianteAsync(int estudianteId);
        Task<IEnumerable<Inscripciones>> BuscarPorCursoAsync(int cursoId);
        Task CrearAsync(Inscripciones inscripcion);
    }
}
