using Microsoft.EntityFrameworkCore;
using SuperCar.Business.Models;
using System.Linq;

namespace SuperCar.Data.Context
{
    public class MeuDbContext : DbContext
    {
        public MeuDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Veiculo> Veiculos { get; set; }

        public DbSet<Combustivel> Combustiveis { get; set; }

        public DbSet<Cor> Cores { get; set; }

        public DbSet<Marca> Marcas { get; set; }

        public DbSet<Cambio> Cambios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var property in modelBuilder.Model.GetEntityTypes()
                .SelectMany(e => e.GetProperties()
                .Where(p => p.ClrType == typeof(string))))
                property.Relational().ColumnType = "varchar(200)";

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MeuDbContext).Assembly);

            foreach (var relationship in modelBuilder.Model.GetEntityTypes()
                .SelectMany(e => e.GetForeignKeys())) relationship.DeleteBehavior = DeleteBehavior.ClientSetNull;

            base.OnModelCreating(modelBuilder);
        }
    }
}
