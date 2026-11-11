using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Farmacia.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class _10112026 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetallesVenta_Medicamentos_IdMedicamento",
                table: "DetallesVenta");

            migrationBuilder.DropForeignKey(
                name: "FK_DetallesVenta_Ventas_IdVenta",
                table: "DetallesVenta");

            migrationBuilder.DropForeignKey(
                name: "FK_Medicamentos_Marcas_IdMarca",
                table: "Medicamentos");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicamentosPorMarcas_Laboratorios_IdLaboratorio",
                table: "MedicamentosPorMarcas");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicamentosPorMarcas_Medicamentos_IdMedicamento",
                table: "MedicamentosPorMarcas");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicamentosPorTipos_Medicamentos_IdMedicamento",
                table: "MedicamentosPorTipos");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicamentosPorTipos_TiposDeMedicamentos_IdTiposDeMedicamento",
                table: "MedicamentosPorTipos");

            migrationBuilder.DropForeignKey(
                name: "FK_ProveedorMedicamentos_Medicamentos_IdMedicamento",
                table: "ProveedorMedicamentos");

            migrationBuilder.DropForeignKey(
                name: "FK_ProveedorMedicamentos_Proveedores_IdProveedor",
                table: "ProveedorMedicamentos");

            migrationBuilder.DropForeignKey(
                name: "FK_RoleClaim_Role_RoleId",
                table: "RoleClaim");

            migrationBuilder.DropForeignKey(
                name: "FK_UserClaim_User_UserId",
                table: "UserClaim");

            migrationBuilder.DropForeignKey(
                name: "FK_UserLogin_User_UserId",
                table: "UserLogin");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRole_Role_RoleId",
                table: "UserRole");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRole_User_UserId",
                table: "UserRole");

            migrationBuilder.DropForeignKey(
                name: "FK_UserToken_User_UserId",
                table: "UserToken");

            migrationBuilder.DropForeignKey(
                name: "FK_Ventas_Clientes_IdCliente",
                table: "Ventas");

            migrationBuilder.DropForeignKey(
                name: "FK_Ventas_Sucursales_IdSucursal",
                table: "Ventas");

            migrationBuilder.AddForeignKey(
                name: "FK_DetallesVenta_Medicamentos_IdMedicamento",
                table: "DetallesVenta",
                column: "IdMedicamento",
                principalTable: "Medicamentos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DetallesVenta_Ventas_IdVenta",
                table: "DetallesVenta",
                column: "IdVenta",
                principalTable: "Ventas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Medicamentos_Marcas_IdMarca",
                table: "Medicamentos",
                column: "IdMarca",
                principalTable: "Marcas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MedicamentosPorMarcas_Laboratorios_IdLaboratorio",
                table: "MedicamentosPorMarcas",
                column: "IdLaboratorio",
                principalTable: "Laboratorios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MedicamentosPorMarcas_Medicamentos_IdMedicamento",
                table: "MedicamentosPorMarcas",
                column: "IdMedicamento",
                principalTable: "Medicamentos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MedicamentosPorTipos_Medicamentos_IdMedicamento",
                table: "MedicamentosPorTipos",
                column: "IdMedicamento",
                principalTable: "Medicamentos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MedicamentosPorTipos_TiposDeMedicamentos_IdTiposDeMedicamento",
                table: "MedicamentosPorTipos",
                column: "IdTiposDeMedicamento",
                principalTable: "TiposDeMedicamentos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProveedorMedicamentos_Medicamentos_IdMedicamento",
                table: "ProveedorMedicamentos",
                column: "IdMedicamento",
                principalTable: "Medicamentos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProveedorMedicamentos_Proveedores_IdProveedor",
                table: "ProveedorMedicamentos",
                column: "IdProveedor",
                principalTable: "Proveedores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RoleClaim_Role_RoleId",
                table: "RoleClaim",
                column: "RoleId",
                principalTable: "Role",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserClaim_User_UserId",
                table: "UserClaim",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserLogin_User_UserId",
                table: "UserLogin",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRole_Role_RoleId",
                table: "UserRole",
                column: "RoleId",
                principalTable: "Role",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRole_User_UserId",
                table: "UserRole",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserToken_User_UserId",
                table: "UserToken",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Ventas_Clientes_IdCliente",
                table: "Ventas",
                column: "IdCliente",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Ventas_Sucursales_IdSucursal",
                table: "Ventas",
                column: "IdSucursal",
                principalTable: "Sucursales",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetallesVenta_Medicamentos_IdMedicamento",
                table: "DetallesVenta");

            migrationBuilder.DropForeignKey(
                name: "FK_DetallesVenta_Ventas_IdVenta",
                table: "DetallesVenta");

            migrationBuilder.DropForeignKey(
                name: "FK_Medicamentos_Marcas_IdMarca",
                table: "Medicamentos");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicamentosPorMarcas_Laboratorios_IdLaboratorio",
                table: "MedicamentosPorMarcas");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicamentosPorMarcas_Medicamentos_IdMedicamento",
                table: "MedicamentosPorMarcas");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicamentosPorTipos_Medicamentos_IdMedicamento",
                table: "MedicamentosPorTipos");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicamentosPorTipos_TiposDeMedicamentos_IdTiposDeMedicamento",
                table: "MedicamentosPorTipos");

            migrationBuilder.DropForeignKey(
                name: "FK_ProveedorMedicamentos_Medicamentos_IdMedicamento",
                table: "ProveedorMedicamentos");

            migrationBuilder.DropForeignKey(
                name: "FK_ProveedorMedicamentos_Proveedores_IdProveedor",
                table: "ProveedorMedicamentos");

            migrationBuilder.DropForeignKey(
                name: "FK_RoleClaim_Role_RoleId",
                table: "RoleClaim");

            migrationBuilder.DropForeignKey(
                name: "FK_UserClaim_User_UserId",
                table: "UserClaim");

            migrationBuilder.DropForeignKey(
                name: "FK_UserLogin_User_UserId",
                table: "UserLogin");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRole_Role_RoleId",
                table: "UserRole");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRole_User_UserId",
                table: "UserRole");

            migrationBuilder.DropForeignKey(
                name: "FK_UserToken_User_UserId",
                table: "UserToken");

            migrationBuilder.DropForeignKey(
                name: "FK_Ventas_Clientes_IdCliente",
                table: "Ventas");

            migrationBuilder.DropForeignKey(
                name: "FK_Ventas_Sucursales_IdSucursal",
                table: "Ventas");

            migrationBuilder.AddForeignKey(
                name: "FK_DetallesVenta_Medicamentos_IdMedicamento",
                table: "DetallesVenta",
                column: "IdMedicamento",
                principalTable: "Medicamentos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DetallesVenta_Ventas_IdVenta",
                table: "DetallesVenta",
                column: "IdVenta",
                principalTable: "Ventas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Medicamentos_Marcas_IdMarca",
                table: "Medicamentos",
                column: "IdMarca",
                principalTable: "Marcas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MedicamentosPorMarcas_Laboratorios_IdLaboratorio",
                table: "MedicamentosPorMarcas",
                column: "IdLaboratorio",
                principalTable: "Laboratorios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MedicamentosPorMarcas_Medicamentos_IdMedicamento",
                table: "MedicamentosPorMarcas",
                column: "IdMedicamento",
                principalTable: "Medicamentos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MedicamentosPorTipos_Medicamentos_IdMedicamento",
                table: "MedicamentosPorTipos",
                column: "IdMedicamento",
                principalTable: "Medicamentos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MedicamentosPorTipos_TiposDeMedicamentos_IdTiposDeMedicamento",
                table: "MedicamentosPorTipos",
                column: "IdTiposDeMedicamento",
                principalTable: "TiposDeMedicamentos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProveedorMedicamentos_Medicamentos_IdMedicamento",
                table: "ProveedorMedicamentos",
                column: "IdMedicamento",
                principalTable: "Medicamentos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProveedorMedicamentos_Proveedores_IdProveedor",
                table: "ProveedorMedicamentos",
                column: "IdProveedor",
                principalTable: "Proveedores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RoleClaim_Role_RoleId",
                table: "RoleClaim",
                column: "RoleId",
                principalTable: "Role",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserClaim_User_UserId",
                table: "UserClaim",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserLogin_User_UserId",
                table: "UserLogin",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRole_Role_RoleId",
                table: "UserRole",
                column: "RoleId",
                principalTable: "Role",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRole_User_UserId",
                table: "UserRole",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserToken_User_UserId",
                table: "UserToken",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ventas_Clientes_IdCliente",
                table: "Ventas",
                column: "IdCliente",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ventas_Sucursales_IdSucursal",
                table: "Ventas",
                column: "IdSucursal",
                principalTable: "Sucursales",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
