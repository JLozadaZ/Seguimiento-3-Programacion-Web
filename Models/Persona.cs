using System.ComponentModel.DataAnnotations;
namespace Tienda.Models;

public class Persona
{
    [Required]
    public string Nombre { get; set; } = string.Empty;
    [Required]
    public string Correo { get; set; } = string.Empty;
    [Required]
    public string Telefono { get; set; } = string.Empty;
    [Required]
    public string Tipo { get; set; } = string.Empty;
    public bool PrimeraVez { get; set; } = false;
}
