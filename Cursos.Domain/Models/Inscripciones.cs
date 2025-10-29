using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Cursos.Domain.Models;

public class Inscripciones
{
    public int Id { get; set; }
    public int EstudianteId { get; set; }
    [ForeignKey("EstudianteId")] 
    [JsonIgnore]
    public Estudiante? Estudiante { get; set; }
    public int CursoId { get; set; }
    [ForeignKey("CursoId")]
    [JsonIgnore]
    public Curso? Curso { get; set; }
    public DateTime FechaInscrippcion { get; set; }
    
}