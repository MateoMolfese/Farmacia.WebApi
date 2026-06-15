using Farmacia.Abstactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Farmacia.Entities
{
    public class TiposDeMedicamento : IEntidad
    {
        public TiposDeMedicamento()
        {
            MedicamentosPorTipos = new HashSet<MedicamentosPorTipos>();
        }
        public int Id { get; set; }
        public string Nombre { get; set; }
        public virtual ICollection<MedicamentosPorTipos> MedicamentosPorTipos { get; set; }

    }
}
