using Cursos.Domain.Interfaces;
using Cursos.Domain.Models;
using Cursos.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Cursos.Infrastructure.Repositories;

public class CursoRepository : ICursosRepository
{
    private readonly AppDbContext _context;
    
    public CursoRepository(AppDbContext context)
    {
        _context = context;
    }
    
    public async Task<IEnumerable<Curso>> GetAllCursos()
    {
        return await _context.Cursos.ToListAsync();
    }

    public async Task<Curso> AddCurso(Curso curso)
    {
        _context.Cursos.Add(curso);
        await _context.SaveChangesAsync();
        return curso;
    }

    public async Task<Curso> GetCursoById(int id)
    {
        return await _context.Cursos.FindAsync(id);
    }

    public async Task<Curso> UpdateCurso(Curso curso)
    {
        _context.Cursos.Update(curso);
        await _context.SaveChangesAsync();
        return curso;    
    }

    public Task DeleteCurso(Curso curso)
    {
        _context.Cursos.Remove(curso);
        return _context.SaveChangesAsync();
    }
}