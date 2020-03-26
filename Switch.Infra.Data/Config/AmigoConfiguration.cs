using Microsoft.EntityFrameworkCore;
using Switch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Switch.Infra.Data.Config
{
    public class AmigoConfiguration : IEntityTypeConfiguration<Amigo>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Amigo> builder)
        {
            //builder.HasKey(a => new { a.UsuarioId, a.UsuarioAmigo});
            builder.HasKey(a => a.Id);
        }
    }
}
