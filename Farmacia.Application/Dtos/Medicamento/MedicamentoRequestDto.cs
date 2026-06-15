using System.ComponentModel.DataAnnotations;

namespace Farmacia.Application.Dtos.Medicamento
{
    public class MedicamentoRequestDto
    {
        [StringLength(10)]
        public string Nombre { get; set; }
        public int IdMarca { get; set; }
    }
}
