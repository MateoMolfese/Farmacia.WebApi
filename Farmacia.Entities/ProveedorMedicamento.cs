using Farmacia.Abstactions;
using System.ComponentModel.DataAnnotations.Schema;

namespace Farmacia.Entities
{
    public class ProveedorMedicamento : IEntidad
    {
        public int Id { get; set; }
        [ForeignKey(nameof(Proveedor))]
        public int IdProveedor { get; set; }
        [ForeignKey(nameof(Medicamento))]
        public int IdMedicamento { get; set; }
        public decimal PrecioProveedor { get; set; }
        public virtual Proveedor Proveedor { get; set; }
        public virtual Medicamento Medicamento { get; set; }
    }
}
