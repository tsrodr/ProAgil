using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProAgil.Dominio.Entidades;
using System;

namespace ProAgil.Repositorio.Config
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(o => o.Id);
            builder.Property(o => o.Nome).IsRequired().HasColumnType("varchar");
            builder.Property(o => o.UserName).IsRequired().HasColumnType("varchar");
            builder.Property(o => o.Email).IsRequired().HasColumnType("varchar");
            builder.Property(o => o.Senha).IsRequired().HasColumnType("varchar");
           
        }
    }
}

