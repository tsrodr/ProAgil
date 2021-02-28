using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProAgil.Dominio.Entidades;
using System;

namespace ProAgil.Repositorio.Config
{
    public class EventoConfiguration : IEntityTypeConfiguration<Evento>
    {
        public void Configure(EntityTypeBuilder<Evento> builder)
        {
            builder.HasKey(o => o.Id);
            builder.Property(o => o.Nome).HasColumnType("varchar");
        }
    }
}
