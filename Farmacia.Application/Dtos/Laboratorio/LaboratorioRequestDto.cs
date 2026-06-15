using System.ComponentModel.DataAnnotations;

namespace Farmacia.Application.Dtos.Laboratorio
{
    public class LaboratorioRequestDto
    {
        [StringLength(30)]
        public string Nombre { get; set; }
    }
}
