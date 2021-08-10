using Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Mappings
{
    public class ClienteMapping : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {

            builder.HasKey(x => x.Id);

            builder.Property(x => x.NomeCompleto)
                 .IsRequired()
                 .HasColumnType("varchar(100)");

            builder.Property(x => x.Tipo)
                .IsRequired()
                .HasColumnType("int");

            builder.Property(x => x.Documento)
                .IsRequired()
                .HasColumnType("varchar(18)");

            builder.Property(x => x.Telefone)
                .IsRequired()
                .HasColumnType("varchar(15)");

            builder.Property(x => x.Genero)
                .IsRequired()
                .HasColumnType("int");


            builder.Property(x => x.DataNascimento)
                .IsRequired()
                .HasColumnType("datetime");


            builder.Property(x => x.DataCadastro)
                .IsRequired()
                .HasColumnType("datetime");


            builder.Property(x => x.Ativo)
                .IsRequired()
                .HasColumnType("bit");


            builder.HasMany(x => x.Eventos)
                .WithOne(x => x.Cliente)
                .HasForeignKey(x => x.ClienteId);

            builder.HasOne(f => f.Endereco)
                .WithOne(e => e.Cliente);

            builder.ToTable("Clientes");

        }
    }
}
