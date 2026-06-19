using Farmacia.Abstactions;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Farmacia.Entities
{
    public class Cliente : IEntidad
    {
        public Cliente()
        {
            Ventas = new HashSet<Venta>();
        }
        public int Id { get; set; }
        [StringLength(50)]
        public string Nombre { get; set; }
        [StringLength(50)]
        public string Apellido { get; set; }
        [StringLength(15)]
        public string Dni { get; set; }
        [StringLength(100)]
        public string Email { get; set; }
        public virtual ICollection<Venta> Ventas { get; set; }
    }
}
