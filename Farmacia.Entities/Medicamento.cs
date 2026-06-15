using Farmacia.Abstactions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Farmacia.Entities
{
    public class Medicamento : IEntidad
    {
        public Medicamento()
        {
            MedicamentosPorMarcas = new HashSet<MedicamentosPorMarcas>();
            MedicamentosPorTipos = new HashSet<MedicamentosPorTipos>();
        }
        public int Id { get; set; }
        [StringLength(10)]
        public string Nombre { get; set; }
        public int IdMarca { get; set; }
        public virtual Marca Marca { get; set; }
        public virtual ICollection<MedicamentosPorMarcas> MedicamentosPorMarcas { get; set; }
        public virtual ICollection<MedicamentosPorTipos> MedicamentosPorTipos { get; set; }
    }
}
