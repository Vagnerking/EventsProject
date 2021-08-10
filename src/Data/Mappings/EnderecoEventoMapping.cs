using Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Mappings
{
    public class EnderecoEventoMapping : IEntityTypeConfiguration<EnderecoEvento>
    {
        public void Configure(EntityTypeBuilder<EnderecoEvento> builder)
        {

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Logradouro)
                .IsRequired()
                .HasColumnType("varchar(150)");

            builder.Property(e => e.Numero)
                .IsRequired()
                .HasColumnType("varchar(50)");

            builder.Property(e => e.Complemento)
                .HasColumnType("varchar(100)");

            builder.Property(e => e.Cep)
                .IsRequired()
                .HasColumnType("varchar(10)");

            builder.Property(e => e.Bairro)
                .IsRequired()
                .HasColumnType("varchar(50)");

            builder.Property(e => e.Cidade)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(e => e.Estado)
                .IsRequired()
                .HasColumnType("varchar(50)");

            builder.ToTable("EnderecoEventos");


        }
    }
}
