using Farmacia.Abstactions;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Farmacia.Entities
{
    public class Proveedor : IEntidad
    {
        public Proveedor()
        {
            ProveedorMedicamentos = new HashSet<ProveedorMedicamento>();
        }
        public int Id { get; set; }
        [StringLength(100)]
        public string RazonSocial { get; set; }
        [StringLength(20)]
        public string Telefono { get; set; }
        [StringLength(150)]
        public string Email { get; set; }
        public virtual ICollection<ProveedorMedicamento> ProveedorMedicamentos { get; set; }
    }
}
