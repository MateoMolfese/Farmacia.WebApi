using Farmacia.Abstactions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Farmacia.Entities
{
    public class Venta : IEntidad
    {
        public Venta()
        {
            DetallesVenta = new HashSet<DetalleVenta>();
        }
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        [ForeignKey(nameof(Cliente))]
        public int IdCliente { get; set; }
        [ForeignKey(nameof(Sucursal))]
        public int IdSucursal { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual Sucursal Sucursal { get; set; }
        public virtual ICollection<DetalleVenta> DetallesVenta { get; set; }
    }
}
