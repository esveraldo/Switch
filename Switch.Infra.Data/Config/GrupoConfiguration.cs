using Microsoft.EntityFrameworkCore;
using Switch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Switch.Infra.Data.Config
{
    public class GrupoConfiguration : IEntityTypeConfiguration<Grupo>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Grupo> builder)
        {
            builder.HasKey(g => g.Id);
            builder.Property(g => g.Nome).HasMaxLength(255).IsRequired();
            builder.Property(g => g.Descricao).IsRequired();
            builder.Property(g => g.UrlFoto).IsRequired();
        }
    }
}
