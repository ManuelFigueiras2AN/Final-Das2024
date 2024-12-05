﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Modelo;

#nullable disable

namespace Modelo.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Modelo.Categoria", b =>
                {
                    b.Property<int>("IdCategoria")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCategoria"));

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdCategoria");

                    b.ToTable("Categorias", (string)null);
                });

            modelBuilder.Entity("Modelo.Cliente", b =>
                {
                    b.Property<int>("IdCliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCliente"));

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Contacto")
                        .HasColumnType("bigint");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Dni")
                        .HasColumnType("bigint");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdCliente");

                    b.ToTable("Clientes", (string)null);

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("Modelo.DetalleFactura", b =>
                {
                    b.Property<int>("IdDetalle")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdDetalle"));

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<int>("FacturaAsociadaIdFactura")
                        .HasColumnType("int");

                    b.Property<int>("ProductoIdProducto")
                        .HasColumnType("int");

                    b.Property<decimal>("Subtotal")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("IdDetalle");

                    b.HasIndex("FacturaAsociadaIdFactura");

                    b.HasIndex("ProductoIdProducto");

                    b.ToTable("DetallesFacturas", (string)null);
                });

            modelBuilder.Entity("Modelo.Factura", b =>
                {
                    b.Property<int>("IdFactura")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdFactura"));

                    b.Property<int>("ClienteIdCliente")
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<int>("NumeroFactura")
                        .HasColumnType("int");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("IdFactura");

                    b.HasIndex("ClienteIdCliente");

                    b.ToTable("Facturas", (string)null);
                });

            modelBuilder.Entity("Modelo.Producto", b =>
                {
                    b.Property<int>("IdProducto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdProducto"));

                    b.Property<int>("CategoriaId")
                        .HasColumnType("int");

                    b.Property<string>("CodigoProducto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.Property<int>("StockMinimo")
                        .HasColumnType("int");

                    b.HasKey("IdProducto");

                    b.HasIndex("CategoriaId");

                    b.ToTable("Productos", (string)null);

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("Modelo.Proveedor", b =>
                {
                    b.Property<int>("IdProveedor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdProveedor"));

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Contacto")
                        .HasColumnType("bigint");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdProveedor");

                    b.ToTable("Proveedores", (string)null);
                });

            modelBuilder.Entity("ProductoProveedor", b =>
                {
                    b.Property<int>("CatalogoProductosIdProducto")
                        .HasColumnType("int");

                    b.Property<int>("ProveedorIdProveedor")
                        .HasColumnType("int");

                    b.HasKey("CatalogoProductosIdProducto", "ProveedorIdProveedor");

                    b.HasIndex("ProveedorIdProveedor");

                    b.ToTable("ProductoProveedor");
                });

            modelBuilder.Entity("Modelo.ClienteMayorista", b =>
                {
                    b.HasBaseType("Modelo.Cliente");

                    b.Property<decimal>("DescuentoMayorista")
                        .HasColumnType("decimal(18,2)");

                    b.ToTable("ClientesMayoristas", (string)null);
                });

            modelBuilder.Entity("Modelo.ProductoImportado", b =>
                {
                    b.HasBaseType("Modelo.Producto");

                    b.Property<string>("Nacionalidad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("ProductosImportados", (string)null);
                });

            modelBuilder.Entity("Modelo.DetalleFactura", b =>
                {
                    b.HasOne("Modelo.Factura", "FacturaAsociada")
                        .WithMany("Detalle")
                        .HasForeignKey("FacturaAsociadaIdFactura")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Modelo.Producto", "Producto")
                        .WithMany()
                        .HasForeignKey("ProductoIdProducto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FacturaAsociada");

                    b.Navigation("Producto");
                });

            modelBuilder.Entity("Modelo.Factura", b =>
                {
                    b.HasOne("Modelo.Cliente", "Cliente")
                        .WithMany("Facturaciones")
                        .HasForeignKey("ClienteIdCliente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("Modelo.Producto", b =>
                {
                    b.HasOne("Modelo.Categoria", "CategoriaAsociada")
                        .WithMany("ProductosCategorizados")
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CategoriaAsociada");
                });

            modelBuilder.Entity("ProductoProveedor", b =>
                {
                    b.HasOne("Modelo.Producto", null)
                        .WithMany()
                        .HasForeignKey("CatalogoProductosIdProducto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Modelo.Proveedor", null)
                        .WithMany()
                        .HasForeignKey("ProveedorIdProveedor")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Modelo.ClienteMayorista", b =>
                {
                    b.HasOne("Modelo.Cliente", null)
                        .WithOne()
                        .HasForeignKey("Modelo.ClienteMayorista", "IdCliente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Modelo.ProductoImportado", b =>
                {
                    b.HasOne("Modelo.Producto", null)
                        .WithOne()
                        .HasForeignKey("Modelo.ProductoImportado", "IdProducto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Modelo.Categoria", b =>
                {
                    b.Navigation("ProductosCategorizados");
                });

            modelBuilder.Entity("Modelo.Cliente", b =>
                {
                    b.Navigation("Facturaciones");
                });

            modelBuilder.Entity("Modelo.Factura", b =>
                {
                    b.Navigation("Detalle");
                });
#pragma warning restore 612, 618
        }
    }
}
