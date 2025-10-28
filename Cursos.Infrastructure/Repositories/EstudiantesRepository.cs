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
    
    public async Task<IEnumerable<Estudiante>> GetAllEstudiantes()
    {
        return await _context.Estudiantes.ToListAsync();
    }

    public  async Task<Estudiante> AddEstudiante(Estudiante estudiante)
    {
        _context.Estudiantes.Add(estudiante);
        await _context.SaveChangesAsync();
        return estudiante;
    }

    public  async Task<Estudiante> GetEstudianteById(int id)
    {
     return await _context.Estudiantes.FindAsync(id);
    }

    public async Task<Estudiante> UpdateEstudiante(Estudiante estudiante)
    {
        _context.Estudiantes.Update(estudiante);
        await _context.SaveChangesAsync();
        return estudiante;
        
    }

    public Task DeleteEstudiante(Estudiante estudiante)
    {
        _context.Estudiantes.Remove(estudiante);
        return _context.SaveChangesAsync();
    }
}