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
        [StringLength(15)]
        public string Dni { get; set; }
        [StringLength(100)]
        public string Email { get; set; }
    }
}
