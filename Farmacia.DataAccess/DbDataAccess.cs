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
        public virtual DbSet<Proveedor> Proveedores { get; set; }
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Sucursal> Sucursales { get; set; }
        public virtual DbSet<Venta> Ventas { get; set; }
        public virtual DbSet<DetalleVenta> DetallesVenta { get; set; }
        public virtual DbSet<ProveedorMedicamento> ProveedorMedicamentos { get; set; }

        public DbDataAccess(DbContextOptions<DbDataAccess> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.ConfigureWarnings(w =>
                w.Ignore(Microsoft.EntityFrameworkCore.Diagnostics.RelationalEventId.PendingModelChangesWarning));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<DetalleVenta>()
                .Property(d => d.PrecioUnitario)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<ProveedorMedicamento>()
                .Property(p => p.PrecioProveedor)
                .HasColumnType("decimal(18,2)");
        }
    }
}
