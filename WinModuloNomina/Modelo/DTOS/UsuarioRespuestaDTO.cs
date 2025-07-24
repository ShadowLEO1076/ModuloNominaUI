using System.ComponentModel.DataAnnotations;

public class UsuarioRespuestaDTO
{
    public int IdUsuario { get; set; }

    [StringLength(100)]
    public string Nombre { get; set; }

    [StringLength(20)]
    public string Cedula { get; set; }

    [StringLength(50)]
    public string Rol { get; set; }

    public DateTime? FechaRegistro { get; set; }

    // Propiedad calculada (opcional)
    public string NombreRol => $"{Nombre} ({Rol})";
}