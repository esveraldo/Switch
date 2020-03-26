using Microsoft.EntityFrameworkCore;
using Switch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Switch.Infra.Data.Config
{
    public class ProcurandoPorConfiguration : IEntityTypeConfiguration<ProcurandoPor>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<ProcurandoPor> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Descricao);
        }
    }
}
