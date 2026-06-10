using Farmacia.Abstactions;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Farmacia.Entities
{
    public class Laboratorio : IEntidad
    {
        public Laboratorio()
        {
            MedicamentosPorMarcas = new HashSet<MedicamentosPorMarcas>();
        }
        public int Id { get; set; }
        [StringLength(30)]
        public string Nombre { get; set; }
        public virtual ICollection<MedicamentosPorMarcas> MedicamentosPorMarcas { get; set; }
    }
}
