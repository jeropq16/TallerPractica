using Cursos.Domain.Interfaces;
using Cursos.Domain.Models;
using Cursos.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Cursos.Infrastructure.Repositories;

public class EstudiantesRepository : IEstudiantesRepository
{
    private readonly AppDbContext _context;
    
    public EstudiantesRepository(AppDbContext context)
    {
        _context = context;
    }
    
    public async Task<IEnumerable<Estudiantes>> GetAllEstudiantes()
    {
        return await _context.Estudiantes.ToListAsync();
    }

    public  async Task<Estudiantes> AddEstudiante(Estudiantes estudiantes)
    {
        _context.Estudiantes.Add(estudiantes);
        await _context.SaveChangesAsync();
        return estudiantes;
    }

    public  async Task<Estudiantes> GetEstudianteById(int id)
    {
     return await _context.Estudiantes.FindAsync(id);
    }

    public  async Task UpdateEstudiante(Estudiantes estudiantes)
    {
        _context.Estudiantes.Update(estudiantes);
        await _context.SaveChangesAsync();
        
    }

    public Task DeleteEstudiante(Estudiantes estudiantes)
    {
        _context.Estudiantes.Remove(estudiantes);
        return _context.SaveChangesAsync();
    }
}