using Farmacia.Abstactions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Farmacia.Entities
{
    public class MedicamentosPorTipos : IEntidad
    {
        public int Id { get; set; }
        [ForeignKey(nameof(TiposDeMedicamento))]
        public int IdTiposDeMedicamento { get; set; }
        [ForeignKey(nameof(Medicamento))]
        public int IdMedicamento { get; set; }
        public virtual TiposDeMedicamento TiposDeMedicamento { get; set; }
        public virtual Medicamento Medicamento { get; set; }
    }
}
