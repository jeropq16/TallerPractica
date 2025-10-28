namespace Cursos.Domain.Models;

public class Estudiante
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Email { get; set; }
    public string Telefono { get; set; }
    public List<Inscripciones> Inscripciones { get; set; } = new();
}