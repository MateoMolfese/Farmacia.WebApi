using Farmacia.Abstactions;
using System.ComponentModel.DataAnnotations.Schema;

namespace Farmacia.Entities
{
    public class DetalleVenta : IEntidad
    {
        public int Id { get; set; }
        [ForeignKey(nameof(Venta))]
        public int IdVenta { get; set; }
        [ForeignKey(nameof(Medicamento))]
        public int IdMedicamento { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public virtual Venta Venta { get; set; }
        public virtual Medicamento Medicamento { get; set; }
    }
}
