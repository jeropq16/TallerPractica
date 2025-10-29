using Cursos.Application.Interfaces;
using Cursos.Domain.Interfaces;
using Cursos.Domain.Models;

namespace Cursos.Application.Services
{
    public class InscripcionesService : IInscripcionesService
    {
        private readonly IInscripcionesRepository _repo;

        public InscripcionesService(IInscripcionesRepository repo)
        {
            _repo = repo;
        }

        public async Task<IEnumerable<Inscripciones>> ListarAsync()
        {
            return await _repo.ListarAsync();
        }

        public async Task<Inscripciones?> BuscarPorIdAsync(int id)
        {
            return await _repo.BuscarPorIdAsync(id);
        }

        public async Task<IEnumerable<Inscripciones>> BuscarPorEstudianteAsync(int estudianteId)
        {
            return await _repo.BuscarPorEstudianteAsync(estudianteId);
        }

        public async Task<IEnumerable<Inscripciones>> BuscarPorCursoAsync(int cursoId)
        {
            return await _repo.BuscarPorCursoAsync(cursoId);
        }

        public async Task CrearAsync(Inscripciones inscripcion)
        {
            await _repo.CrearAsync(inscripcion);
            await _repo.GuardarCambiosAsync();
        }
    }
}