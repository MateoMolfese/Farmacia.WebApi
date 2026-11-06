using System.ComponentModel.DataAnnotations;

namespace Farmacia.Application.Dtos.Proveedor
{
    public class ProveedorRequestDto
    {
        [Required]
        [StringLength(100)]
        public string RazonSocial { get; set; }
        [StringLength(14, MinimumLength = 8, ErrorMessage = "El telefono debe tener entre 8 y 13 numeros (14 caracteres con el +)")]
        [RegularExpression(@"^\+?\d{8,13}$", ErrorMessage = "El telefono solo puede tener numeros (y un + inicial)")]
        public string Telefono { get; set; }
        [StringLength(150)]
        public string Email { get; set; }
    }
}
