using Farmacia.Abstactions;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Farmacia.Entities
{
    public class Sucursal : IEntidad
    {
        public Sucursal()
        {
            Ventas = new HashSet<Venta>();
        }
        public int Id { get; set; }
        [StringLength(100)]
        public string Nombre { get; set; }
        [StringLength(200)]
        public string Direccion { get; set; }
        [StringLength(20)]
        public string Telefono { get; set; }
        public virtual ICollection<Venta> Ventas { get; set; }
    }
}
