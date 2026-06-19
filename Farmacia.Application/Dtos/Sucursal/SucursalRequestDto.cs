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
        [StringLength(20)]
        public string Telefono { get; set; }
    }
}
