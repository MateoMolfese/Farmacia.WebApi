using Farmacia.Abstactions;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Farmacia.Entities
{
    public class Medicamento : IEntidad
    {
        public Medicamento()
        {
            MedicamentosPorMarcas = new HashSet<MedicamentosPorMarcas>();
            MedicamentosPorTipos = new HashSet<MedicamentosPorTipos>();
            ProveedorMedicamentos = new HashSet<ProveedorMedicamento>();
            DetallesVenta = new HashSet<DetalleVenta>();
        }
        public int Id { get; set; }
        [StringLength(10)]
        public string Nombre { get; set; }
        public int IdMarca { get; set; }
        public virtual Marca Marca { get; set; }
        public virtual ICollection<MedicamentosPorMarcas> MedicamentosPorMarcas { get; set; }
        public virtual ICollection<MedicamentosPorTipos> MedicamentosPorTipos { get; set; }
        public virtual ICollection<ProveedorMedicamento> ProveedorMedicamentos { get; set; }
        public virtual ICollection<DetalleVenta> DetallesVenta { get; set; }
    }
}
