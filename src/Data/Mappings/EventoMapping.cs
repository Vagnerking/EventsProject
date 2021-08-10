using Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Mappings
{
    public class EventoMapping : IEntityTypeConfiguration<Evento>
    {
        public void Configure(EntityTypeBuilder<Evento> builder)
        {

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Titulo)
                 .IsRequired()
                 .HasColumnType("varchar(100)");

            builder.Property(x => x.Descricao)
                 .IsRequired()
                 .HasColumnType("varchar(1000)");

            builder.Property(p => p.Valor)
                .IsRequired()
                .HasColumnType("decimal(6,2)");

            builder.Property(p => p.Convidados)
                .IsRequired()
                .HasColumnType("int");

            builder.Property(x => x.DataEvento)
                .IsRequired()
                .HasColumnType("datetime");

            builder.Property(x => x.DataCadastro)
                 .IsRequired()
                 .HasColumnType("datetime");

            builder.HasOne(f => f.Endereco)
                .WithOne(e => e.Evento);

            builder.ToTable("Eventos");

        }
    }
}
