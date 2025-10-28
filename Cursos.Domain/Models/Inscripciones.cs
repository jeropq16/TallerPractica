using System.ComponentModel.DataAnnotations.Schema;

namespace Cursos.Domain.Models;

public class Inscripciones
{
    public int Id { get; set; }
    public int EstudianteId { get; set; }
    [ForeignKey("EstudianteId")]
    public Estudiantes Estudiante { get; set; }
    public int CursoId { get; set; }
    [ForeignKey("CursoId")]
    public Curso Curso { get; set; }
    public DateTime FechaInscrippcion { get; set; }
    
}