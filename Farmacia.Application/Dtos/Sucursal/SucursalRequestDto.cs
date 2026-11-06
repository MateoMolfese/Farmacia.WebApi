using System.ComponentModel.DataAnnotations;

namespace Farmacia.Application.Dtos.Sucursal
{
    public class SucursalRequestDto
    {
        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }
        [StringLength(200)]
        public string Direccion { get; set; }
        [StringLength(14, MinimumLength = 8, ErrorMessage = "El telefono debe tener entre 8 y 13 numeros (14 caracteres con el +)")]
        [RegularExpression(@"^\+?\d{8,13}$", ErrorMessage = "El telefono solo puede tener numeros (y un + inicial)")]
        public string Telefono { get; set; }
    }
}
