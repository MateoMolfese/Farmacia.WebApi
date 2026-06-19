using System.ComponentModel.DataAnnotations;

namespace Farmacia.Application.Dtos.Proveedor
{
    public class ProveedorRequestDto
    {
        [Required]
        [StringLength(100)]
        public string RazonSocial { get; set; }
        [StringLength(20)]
        public string Telefono { get; set; }
        [StringLength(150)]
        public string Email { get; set; }
    }
}
