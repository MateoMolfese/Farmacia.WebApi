using System.ComponentModel.DataAnnotations;

namespace Farmacia.Application.Dtos.Cliente
{
    public class ClienteRequestDto
    {
        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }
        [Required]
        [StringLength(50)]
        public string Apellido { get; set; }
        [StringLength(8, MinimumLength = 8, ErrorMessage = "El DNI debe tener exactamente 8 caracteres")]
        [RegularExpression(@"^\d{8}$", ErrorMessage = "El DNI debe tener exactamente 8 numeros")]
        public string Dni { get; set; }
        [StringLength(100)]
        public string Email { get; set; }
    }
}
