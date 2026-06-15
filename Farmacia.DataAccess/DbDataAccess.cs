using Farmacia.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Farmacia.DataAccess
{
    public class DbDataAccess : IdentityDbContext
    {
        public virtual DbSet<Medicamento> Medicamentos { get; set; }
        public virtual DbSet<Laboratorio> Laboratorios { get; set; }
        public virtual DbSet<Marca> Marcas { get; set; }

        public virtual DbSet<TiposDeMedicamento> TiposDeMedicamentos { get; set; }
        public virtual DbSet<MedicamentosPorMarcas> MedicamentosPorMarcas { get; set; }

        public virtual DbSet<MedicamentosPorTipos> MedicamentosPorTipos { get; set; }
        public DbDataAccess(DbContextOptions<DbDataAccess> options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.LogTo(Console.WriteLine).EnableDetailedErrors();

    }
}
