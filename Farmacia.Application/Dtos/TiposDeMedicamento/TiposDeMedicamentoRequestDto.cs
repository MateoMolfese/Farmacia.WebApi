using System.ComponentModel.DataAnnotations;

namespace Farmacia.Application.Dtos.TiposDeMedicamento
{
    public class TiposDeMedicamentoRequestDto
    {
        [StringLength(30)]
        public string Nombre { get; set; }
    }
}
