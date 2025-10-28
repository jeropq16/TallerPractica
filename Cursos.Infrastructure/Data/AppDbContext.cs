using Cursos.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Cursos.Infrastructure.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    
    public DbSet<Estudiantes>  Estudiantes { get; set; }
    public DbSet<Curso>  Cursos { get; set; }
    public DbSet<Inscripciones> Inscripciones { get; set; }
}
