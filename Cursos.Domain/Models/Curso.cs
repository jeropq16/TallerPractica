namespace Cursos.Domain.Models;

public class Curso
{
    public int Id { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public string Descripcion { get; set; } = string.Empty;
    
    public List<Inscripciones> Inscripciones { get; set; } = new();
}