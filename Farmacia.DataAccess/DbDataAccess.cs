using Farmacia.Entities;
using Farmacia.Entities.MicrosoftIdentity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace Farmacia.DataAccess
{
    public class DbDataAccess : IdentityDbContext<User, Role, Guid, UserClaim, UserRole, UserLogin, RoleClaim, UserToken>
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
            => optionsBuilder.LogTo(Console.WriteLine).EnableDetailedErrors();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);

            modelBuilder.Entity<DetalleVenta>()
                .Property(d => d.PrecioUnitario)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<ProveedorMedicamento>()
                .Property(p => p.PrecioProveedor)
                .HasColumnType("decimal(18,2)");
        }
    }
}
