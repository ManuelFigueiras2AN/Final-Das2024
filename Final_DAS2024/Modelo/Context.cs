using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;


namespace Modelo
{
    public class Context:DbContext
    {

        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<ClienteMayorista> ClientesMayoristas { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<ProductoImportado> ProductosImportados {  get; set; }
        public DbSet<Factura> Facturas { get; set; }
        public DbSet<DetalleFactura> DetallesFacturas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Tienda;Integrated Security=True;Persist Security Info=False;Pooling=False;Multiple Active Result Sets=False;Encrypt=False;Trust Server Certificate=False;Command Timeout=0");

        protected override void OnModelCreating(ModelBuilder model)
        {
            model.Entity<Proveedor>().ToTable("Proveedores").HasKey(b => b.IdProveedor);
            model.Entity<Producto>().ToTable("Productos").HasKey(b => b.IdProducto);
            model.Entity<Cliente>().ToTable("Clientes").HasKey(b => b.IdCliente);
            model.Entity<Categoria>().ToTable("Categorias").HasKey(b => b.IdCategoria);
            model.Entity<Factura>().ToTable("Facturas").HasKey(b => b.IdFactura);
            model.Entity<DetalleFactura>().ToTable("DetallesFacturas").HasKey(b => b.IdDetalle);

            model.Entity<ProductoImportado>()
                .ToTable("ProductosImportados")
                .HasBaseType<Producto>();
            model.Entity<ClienteMayorista>().ToTable("ClientesMayoristas").HasBaseType<Cliente>();
            model.Entity<Proveedor>().HasMany(p => p.CatalogoProductos).WithMany();
            model.Entity<Producto>().HasOne(p => p.CategoriaAsociada).WithMany(c=>c.ProductosCategorizados).HasForeignKey(p=>p.CategoriaId);
            model.Entity<Factura>().HasMany(f => f.Detalle).WithOne(d=>d.FacturaAsociada);
            model.Entity<Factura>().HasOne(f => f.Cliente).WithMany(c => c.Facturaciones);
            base.OnModelCreating(model);


        }
    }
}
