using Farmacia.Abstactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Farmacia.Entities
{
    public class Marca : IEntidad
    {
        public Marca()
        {
            Medicamentos = new HashSet<Medicamento>();
        }
        public int Id { get; set; }
        public string Nombre { get; set; }
        public virtual ICollection<Medicamento> Medicamentos { get; set; }
    }
}
