using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Switch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Switch.Infra.Data.Config
{
    public class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> buider)
        {
            buider.HasKey(u => u.Id);
            buider.Property(u => u.Titulo).HasMaxLength(255).IsRequired();
            buider.Property(u => u.DataDoPost).HasMaxLength(255).IsRequired();
            buider.Property(u => u.Postagem).IsRequired();
        }
    }
}
