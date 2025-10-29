using Cursos.Domain.Interfaces;
using Cursos.Domain.Models;
using Cursos.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Cursos.Infrastructure.Repositories
{
    public class InscripcionesRepository : IInscripcionesRepository
    {
        private readonly AppDbContext _db;

        public InscripcionesRepository(AppDbContext db)
        {
            _db = db;
        }

        public async Task<IEnumerable<Inscripciones>> ListarAsync()
        {
            return await _db.Inscripciones
                .Include(i => i.Estudiante)
                .Include(i => i.Curso)
                .ToListAsync();
        }

        public async Task<Inscripciones?> BuscarPorIdAsync(int id)
        {
            return await _db.Inscripciones
                .Include(i => i.Estudiante)
                .Include(i => i.Curso)
                .FirstOrDefaultAsync(i => i.Id == id);
        }

        public async Task<IEnumerable<Inscripciones>> BuscarPorEstudianteAsync(int estudianteId)
        {
            return await _db.Inscripciones
                .Include(i => i.Curso)
                .Where(i => i.EstudianteId == estudianteId)
                .ToListAsync();
        }

        public async Task<IEnumerable<Inscripciones>> BuscarPorCursoAsync(int cursoId)
        {
            return await _db.Inscripciones
                .Include(i => i.Estudiante)
                .Where(i => i.CursoId == cursoId)
                .ToListAsync();
        }

        public async Task CrearAsync(Inscripciones inscripciones)
        {
            await _db.Inscripciones.AddAsync(inscripciones);
        }

        public async Task GuardarCambiosAsync()
        {
            await _db.SaveChangesAsync();
        }
    }
}

