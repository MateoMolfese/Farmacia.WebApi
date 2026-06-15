using System.ComponentModel.DataAnnotations;

namespace Farmacia.Application.Dtos.Marca
{
    public class MarcaRequestDto
    {
        [StringLength(30)]
        public string Nombre { get; set; }
    }
}
