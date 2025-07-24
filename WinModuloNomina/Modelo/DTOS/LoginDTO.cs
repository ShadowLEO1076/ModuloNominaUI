using System.ComponentModel.DataAnnotations;

namespace WinModuloNomina.Modelo.DTOS
{
    internal class LoginDTO
    {
        [Required(ErrorMessage = "La cédula es requerida")]
        [StringLength(20, MinimumLength = 3)]
        public string Cedula { get; set; }
        [Required(ErrorMessage = "La contraseña es requerida")]
        public string Contraseña { get; set; }
    }
}