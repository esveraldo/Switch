using Microsoft.EntityFrameworkCore;
using Switch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Switch.Infra.Data.Config
{
    class StatusRelacionamentoConfiguration : IEntityTypeConfiguration<StatusRelacionamento>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<StatusRelacionamento> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Status);
        }
    }
}
