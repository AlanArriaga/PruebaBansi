using System.ComponentModel.DataAnnotations;
namespace PruebaBansi.Models;

public class Examen
{
    // Indica que la propiedad 'IdExamen' es la clave primaria de la entidad
    [Key]
    public int IdExamen { get; set; }
    public string? Nombre { get; set; }
    public string? Descripcion { get; set; }
}
