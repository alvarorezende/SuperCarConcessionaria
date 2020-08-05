using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SuperCar.Business.Models;

namespace SuperCar.Data.Mappings
{
    public class VeiculoMapping : IEntityTypeConfiguration<Veiculo>
    { 
        public void Configure(EntityTypeBuilder<Veiculo> builder)
        {
            builder.HasKey(p => p.VeiculoId);

            builder.Property(p => p.Placa)
                .IsRequired()
                .HasColumnType("varchar(7)");

            builder.Property(p => p.Modelo)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(p => p.ObsVeiculo)
                .HasColumnType("varchar(1000)");

            builder.HasOne(c => c.Cor)
                .WithMany()
                .HasForeignKey("CorId");

            builder.HasOne(m => m.Marca)
                .WithMany()
                .HasForeignKey("MarcaId");

            builder.HasOne(c => c.Cambio)
                .WithMany()
                .HasForeignKey("CambioId");

            builder.HasOne(c => c.Combustivel)
                .WithMany()
                .HasForeignKey("CombustivelId");

            builder.ToTable("Veiculos");
        }
    }

    public class MarcaMapping : IEntityTypeConfiguration<Marca>
    {
        public void Configure(EntityTypeBuilder<Marca> builder)
        {
            builder.HasKey(p => p.MarcaId);

            builder.Property(p => p.NomeMarca)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.ToTable("Marcas");
        }
    }

    public class CambioMapping : IEntityTypeConfiguration<Cambio>
    {
        public void Configure(EntityTypeBuilder<Cambio> builder)
        {
            builder.HasKey(p => p.CambioId);

            builder.Property(p => p.TipoCambio)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.ToTable("Cambios");
        }
    }

    public class CorMapping : IEntityTypeConfiguration<Cor>
    {
        public void Configure(EntityTypeBuilder<Cor> builder)
        {
            builder.HasKey(p => p.CorId);

            builder.Property(p => p.NomeCor)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.ToTable("Cores");
        }
    }

    public class CombustivelMapping : IEntityTypeConfiguration<Combustivel>
    {
        public void Configure(EntityTypeBuilder<Combustivel> builder)
        {
            builder.HasKey(p => p.CombustivelId);

            builder.Property(p => p.TipoCombustivel)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.ToTable("Combustiveis");
        }
    }
}