using Cursos.Domain.Models;

namespace Cursos.Domain.Interfaces
{
    public interface IInscripcionesRepository
    {
        Task<IEnumerable<Inscripciones>> ListarAsync();
        Task<Inscripciones?> BuscarPorIdAsync(int id);
        Task<IEnumerable<Inscripciones>> BuscarPorEstudianteAsync(int estudianteId);
        Task<IEnumerable<Inscripciones>> BuscarPorCursoAsync(int cursoId);
        Task CrearAsync(Inscripciones inscripciones);
        Task GuardarCambiosAsync();
    }
}
