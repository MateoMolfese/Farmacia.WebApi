using Farmacia.Abstactions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Farmacia.Entities
{
    public class MedicamentosPorMarcas : IEntidad
    {
        public int Id { get; set; }
        [ForeignKey(nameof(Laboratorio))]
        public int IdLaboratorio { get; set; }
        [ForeignKey(nameof(Medicamento))]
        public int IdMedicamento { get; set; }
        public virtual Laboratorio Laboratorio { get; set; }
        public virtual Medicamento Medicamento { get; set; }
    }
}
